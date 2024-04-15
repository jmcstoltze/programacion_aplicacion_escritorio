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
using System.Windows.Shapes;

namespace PrimeraEvaluacion.vistas
{
    public partial class ListarEquipos : Window
    {
        public ListarEquipos()
        {
            InitializeComponent();
            InitializeComponent();
            dgListadoEquipos.ItemsSource = clases.ListadoEquipos.Equipos;
            dgListadoEquipos.CanUserAddRows = false;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            if (index != -1 && index < clases.ListadoEquipos.Equipos.Count)
            {                
                clases.Equipo equipo = clases.ListadoEquipos.Equipos[index];
                
                ActualizarEquipo actualizarEquipo = new ActualizarEquipo(equipo);             
                actualizarEquipo.ShowDialog();
                
                dgListadoEquipos.Items.Refresh();
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            
            if (index != -1 && index < clases.ListadoEquipos.Equipos.Count)
            {
                clases.ListadoEquipos.Equipos.RemoveAt(index);
                dgListadoEquipos.Items.Refresh(); // Actualizar el DataGrid
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dgListadoEquipos.Items.Refresh();
        }
    }
}
