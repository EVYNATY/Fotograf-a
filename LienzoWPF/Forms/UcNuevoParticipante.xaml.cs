using Logica;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LienzoWPF.Forms
{
    /// <summary>
    /// Lógica de interacción para UcNuevoParticipante.xaml
    /// </summary>
    public partial class UcNuevoParticipante : UserControl
    {
        public UcNuevoParticipante()
        {
            InitializeComponent();
        }
         private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DtFechaInscripcion.DisplayDateEnd = DateTime.Today;
            DtFechaInscripcion.SelectedDate = DateTime.Today;

         }
         private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CboNivel.ItemsSource = Enum.GetValues(typeof(Nivel));
            CboNivel.SelectedItem = Nivel.Default;

            CboCategoria.ItemsSource = Enum.GetValues(typeof(Categoria));   
            CboCategoria.SelectedItem =Categoria.Default;
        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Capturar datos
            string nombre = TxtNombre.Text.Trim();
            string email = TxtMail.Text.Trim();
            DateTime fechaInscripcion = (DateTime)DtFechaInscripcion.SelectedDate;
            Nivel nivel = (Nivel)CboNivel.SelectedItem;
            Categoria categoria = (Categoria)CboCategoria.SelectedItem;

            //Validar datos
            List<string> errores = new List<string>();

            if (nombre == string.Empty)
            {
                errores.Add("Debe ingresar el nombre del contacto");
            }
            if (email == string.Empty)
            {
                errores.Add("Debe ingresar el correo electronico");
            }
            if (errores.Count == 0)
            {
                //guardar los datos
                Inscripcion nuevaInscripcion = new Inscripcion();
                nuevaInscripcion.Nombre = nombre;
                nuevaInscripcion.Email = email;
                nuevaInscripcion.FechaInscripcion = fechaInscripcion;
                nuevaInscripcion.Categoria = categoria;
                nuevaInscripcion.Nivel = nivel;

                InscripcionBLL ipbll = new InscripcionBLL();
                ipbll.Agregar(nuevaInscripcion);

                //limpiar formulario
                TxtNombre.Text = string.Empty;
                TxtMail.Text = string.Empty;
                DtFechaInscripcion.SelectedDate = DateTime.Today;
                CboNivel.SelectedItem = Nivel.Default;
                CboCategoria.SelectedItem = Categoria.Default;

                //mensajes
                MessageBox.Show(nombre + " se ha agregado correctamente", "Nuevo Ingreso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                //hay errores
                string mensajesError = string.Join("\n", errores);
                MessageBox.Show(mensajesError, "Error al ingresar", MessageBoxButton.OK, MessageBoxImage.Error);
                //mensajes
            }



        }

        private void CboCategoria_SelectionChanged()
        {

        }

        private void TxtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
