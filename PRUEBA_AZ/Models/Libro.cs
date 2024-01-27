using System;
using System.Collections.Generic;

namespace PRUEBA_AZ.Models
{
    /// <summary>
    /// Tabla que almacena los distintos libros registrados
    /// </summary>
    public partial class Libro
    {
        /// <summary>
        /// ID del libro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titulo del libro
        /// </summary>
        public string? Título { get; set; }
        /// <summary>
        /// ID del autor (Foranea)
        /// </summary>
        public int AutorId { get; set; }

        public Autor? Autor { get; set; }
    }
}
