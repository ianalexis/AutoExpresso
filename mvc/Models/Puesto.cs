using System.Runtime.CompilerServices;

namespace Test
{
    public class Puesto
    {
        private int id; //comentario
        private TipoServicio tipo;

        public double calcularPresupuesto(Vehiculo vehiculo) 
        {

            try
            {
                validarVehiculo(vehiculo);  
            }
            catch (ArgumentNullException ex) { Console.WriteLine(ex.Message); }

            DisablePrivateReflectionAttribute validarVehiculo(Vehiculo vehiculo)
            {
                if (vehiculo == null) { throw new ArgumentNullException("El vehiculo no puede ser nulo o vacio"); }
            }
            return;

        }
    }
}
