using SistemaInventario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.Irepositorio
{
    public interface ICategoriaRepositorio : IRepositorio<Categoria>
    {

        void Actualizar(Categoria categoria);
    }
}
