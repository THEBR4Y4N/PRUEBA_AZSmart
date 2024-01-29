using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string? Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
