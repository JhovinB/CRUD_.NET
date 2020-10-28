using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crud
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class ListaProducto : Window
    {
        public ListaProducto()
        {
            InitializeComponent();
        }
        public void BtnConsultar_Click(object sender,RoutedEventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            BProducto Bproducto = null;

            try
            {
                Bproducto = new BProducto();
                dgvProducto.ItemsSource = Bproducto.Listar(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
            finally
            {
                Bproducto = null;
            }
        }

        private void BtnNuevo_Click(object sender,RoutedEventArgs e)
        {
            ManProducto manProducto = new ManProducto(0);
            manProducto.ShowDialog();
            Cargar();
        }
        private void DgvProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idProducto;
            var item = (Producto)dgvProducto.SelectedItem;
            if (null == item) return;
            idProducto = Convert.ToInt32(item.IdProducto);

            ManProducto manProducto = new ManProducto(idProducto);
            manProducto.ShowDialog();
            Cargar();
        }
    }
}
