namespace Test
{
    public class Propietario
    {
        private int documento;
        private String nombre;
        private String telefono;
        private string correo;

        public Propietario(int documento, string nombre, string telefono, string correo)
        {

            try
            {
                setDocumento(documento);
                setNombre(nombre);
                setTelefono(telefono);
                setCorreo(correo);
            }
            catch (ArgumentNullException ex) { Console.WriteLine(ex.Message); }
        }


        private void setDocumento(int documento)
        {
            if (documento == null)
            {
                throw new ArgumentNullException("El documento no puede ser nulo o vacio");
            }
            this.documento = documento;
        }

        public String getDocumento() { return documento; }


        private void setNombre(String nombre)
        {
            if (String.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException("El nombre no puede ser nulo o vacio");
            }
            this.nombre = nombre;
        }

        public String getNombre() { return telefono; }


        private void setTelefono(String telefono)
        {
            if (String.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentNullException("El telefono no puede ser nulo o vacio");
            }
            this.telefono = telefono;
        }

        public String getTelefono() { return telefono; }


        private void setCorreo(String correo)
        {
            if (String.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentNullException("El correo no puede ser nulo o vacio");
            }
            this.correo = correo;
        }

        public String getCorreo() { return correo; }

        
    }
}
