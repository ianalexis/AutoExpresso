namespace Test
{
    public class Vehiculo
    {
        private int id;
        private String marca;
        private String modelo;
        private String matricula ;
        private Propietario propietario ;

        public Vehiculo(int id, string marca, string modelo, string matricula, Propietario propietario)
        {
            try
            {
                setMarca(marca);
                setModelo(modelo);
                setMatricula(matricula);
                setPropietario(propietario);
            }
            catch (ArgumentNullException ex) { Console.WriteLine(ex.Message); }

        }

        private void setMarca(String marca)
        {
            if (String.IsNullOrWhiteSpace(marca))
            {
                    throw new ArgumentNullException("La marca no puede ser nula o vacia");
             } 
            this.marca = marca;
        }

        private void setModelo(String modelo)
        {
            if (String.IsNullOrWhiteSpace(modelo))
            {
                throw new ArgumentNullException("El modelo no puede ser nulo o vacio");
            }
            this.modelo = modelo;
        }

        private void setMatricula(String matricula)
        {
            if (String.IsNullOrWhiteSpace(matricula))
            {
                throw new ArgumentNullException("La matricula no puede ser nula o vacia");
            }
            this.matricula = matricula;
        }

        private void setPropietario(Propietario propietario)
        {
            if (propietario == null)
            {
                throw new ArgumentNullException("El propietario no puede ser nulo o vacio");
            }
            this.propietario = propietario;
        }

        public int getId() { return id; }

        public String getMarca() { return marca; }

        public String getModelo() { return modelo; }

        public String getMatricula() {  return matricula; }

        public String getPropietario() { return propietario; }



    }
}
