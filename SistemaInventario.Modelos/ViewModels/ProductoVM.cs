using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaInventario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.ViewModels
{
    public class ProductoVM
    {
        public Producto Producto { get; set; }

        public IEnumerable<SelectListItem> CategoriaListas { get; set; }
        public IEnumerable<SelectListItem> MarcaListas { get; set; }
        public IEnumerable<SelectListItem> PadreListas { get; set; }
        

    }
}
