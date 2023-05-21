namespace Test
{
    public class Vehiculo
    {
        private int id;
        private String marca;
        private String modelo;
        private String matricula;
        private Propietario propietario;

        public Vehiculo(int id, string marca, string modelo, string matricula, Propietario propietario)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.propietario = propietario;
        }



    }
}
