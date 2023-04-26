using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda4E.Shared.Modelos
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage ="El número de inventario debe ser entero positivo")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Debe escribir el nombre")]
        public string? Nombre { get; set; }
        [Range(1,3,ErrorMessage ="Debe seleccionar departamento")]
        public int Departamento { get; set; }
    }
}
