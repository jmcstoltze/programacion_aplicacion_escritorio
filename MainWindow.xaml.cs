using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimeraEvaluacion
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            vistas.AcercaDe acercaDe = new();
            acercaDe.ShowDialog();
        }

        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            vistas.AgregarEquipo agregarEquipo = new();
            agregarEquipo.ShowDialog();
        }
        private void btnListarEquipos_Click(object sender, RoutedEventArgs e)
        {
            vistas.ListarEquipos listarEquipos = new();
            listarEquipos.ShowDialog();
        }
    }
}
