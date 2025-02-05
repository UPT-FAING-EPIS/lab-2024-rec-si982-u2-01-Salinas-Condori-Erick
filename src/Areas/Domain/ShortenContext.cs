using Microsoft.EntityFrameworkCore;  // Usamos esta directiva solo una vez

namespace Shorten.Areas.Domain  // Define solo un espacio de nombres para todo el archivo
{
    /// <summary>
    /// Clase de infraestructura que representa el contexto de la base de datos
    /// </summary>
    public class ShortenContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="options">opciones de conexión de BD</param>
        public ShortenContext(DbContextOptions<ShortenContext> options) : base(options)
        {
        }

        /// <summary>
        /// Propiedad que representa la tabla de mapeo de urls
        /// </summary>
        /// <value>Conjunto de UrlMapping</value>
        public DbSet<UrlMapping> UrlMappings { get; set; }
    }
}