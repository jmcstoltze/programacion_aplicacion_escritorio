using PrimeraEvaluacion.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class ActualizarEquipo : Window
    {        
        private Equipo EquipoActualizar { get; set; }

        public ActualizarEquipo(Equipo equipo)
        {
            InitializeComponent();
            EquipoActualizar = equipo;            
            DataContext = EquipoActualizar;
            MostrarDatosEquipo();
        }

        private void MostrarDatosEquipo()
        {            
            txtNombreEquipo.Text = EquipoActualizar.NombreEquipo;
            txtCantidadJugadores.Text = EquipoActualizar.CantidadJugadores.ToString();
            txtNombreDT.Text = EquipoActualizar.NombreDT;
            txtTipoEquipo.Text = EquipoActualizar.TipoEquipo;
            txtCapitanEquipo.Text = EquipoActualizar.CapitanEquipo;
            ckTieneSub21.IsChecked = EquipoActualizar.TieneSub21;
        }

        private void btnActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            string nombreEquipo = txtNombreEquipo.Text;

#pragma warning disable CS0168
            int cantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
#pragma warning restore CS0168

            string nombreDT = txtNombreDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capitanEquipo = txtCapitanEquipo.Text;
          
            bool tieneSub21 = ckTieneSub21.IsChecked ?? false;

            int index = ListadoEquipos.Equipos.IndexOf(EquipoActualizar);
                          
            Equipo equipo = ListadoEquipos.Equipos[index];
            equipo.NombreEquipo = nombreEquipo;
            equipo.CantidadJugadores = cantidadJugadores;
            equipo.NombreDT = nombreDT;
            equipo.TipoEquipo = tipoEquipo;
            equipo.CapitanEquipo = capitanEquipo;
            equipo.TieneSub21 = tieneSub21;            

            Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private static readonly Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
