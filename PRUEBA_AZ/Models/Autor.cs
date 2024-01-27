using System;
using System.Collections.Generic;

namespace PRUEBA_AZ.Models
{
    /// <summary>
    /// Tabla que almacena los datos del autor
    /// </summary>
    public partial class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        /// <summary>
        /// ID del autor
        /// </summary>
        public int AutorId { get; set; }
        /// <summary>
        /// Nombre del autor
        /// </summary>
        public string? Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
