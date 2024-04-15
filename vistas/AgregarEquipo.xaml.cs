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
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }
        private void btnVolverAlMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            string nombreEquipo = txtNombreEquipo.Text;

#pragma warning disable CS0168
            int cantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
#pragma warning restore CS0168

            string nombreDT = txtNombreDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capitanEquipo = txtCapitanEquipo.Text;

            // bool tieneSub21 = (ckTieneSub21.IsChecked.Value)? true : false;
            bool tieneSub21 = ckTieneSub21.IsChecked ?? false;

            clases.Equipo equipo = new(nombreEquipo, cantidadJugadores, nombreDT, tipoEquipo, capitanEquipo, tieneSub21);  
            clases.ListadoEquipos.Equipos.Add(equipo);

            Close();
        }

        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
