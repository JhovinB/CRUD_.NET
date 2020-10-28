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
    public partial class ManProducto : Window
    {
        public int ID { get; set; }

        public ManProducto(int Id)
        {
            InitializeComponent();
           
        }
      
    
        private void BtnCerrar_Click(object sender , RoutedEventArgs e)
        {
            Close();
        }
    
    }
}
