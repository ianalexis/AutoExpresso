using Microsoft.EntityFrameworkCore;
using mvc.Models;
using System.Collections.Generic;

namespace mvc.Context
{

    // Esta clase es el contexto de EF
    // El contexto "equivale" a una conexión al servidor de base de datos, 
    // y también tiene todas las clases de negocio "mapeadas" a tablas de base de datos

    public class EscuelaDatabaseContext : DbContext
    {
   
 
 public
EscuelaDatabaseContext(DbContextOptions<EscuelaDatabaseContext> options) : base (options)

        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }

}

