using System;
using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Model
{
    public class CategoriaModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public bool Insertar(CategoriaModel categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }
        public bool Actualizar(CategoriaModel categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }
        public CategoriaModel()
        {
            var listar = (new BCategoria()).Listar(0))
            Categorias = new ObservableCollection<Categoria>(lista);
        }
    }
}