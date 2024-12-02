using Logica;
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

namespace LienzoWPF.Forms
{
    /// <summary>
    /// Lógica de interacción para UcVerInscripcion.xaml
    /// </summary>
    public partial class UcVerInscripcion : UserControl
    {
        InscripcionBLL ipbll;
        public UcVerInscripcion()
        {
            InitializeComponent();
            ipbll = new InscripcionBLL();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<Inscripcion> inscripciones = ipbll.Listar();

            if (inscripciones.Count == 0)
            {
                MessageBox.Show("No existen contactos", "Ver contactos", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                DgInscripciones.ItemsSource = inscripciones;
            }


        }
    }
}
