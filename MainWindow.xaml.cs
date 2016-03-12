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
using System.Windows.Resources;
using System.Windows.Media.Animation;



namespace ElTrompo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Arrays arrays = new Arrays();

        public MainWindow()
        {

            InitializeComponent();
            
            //Alta _Alta = new Alta();
            //tbClaveInterna.Text = _Alta.getClaveInterna();
            tbNombre.Focus();

            for (int i = 0; i < arrays.turno.Length; i++)
            {
                cbTurno.Items.Add(arrays.turno[i]);
            }

            for (int i = 0; i < arrays.sector.Length; i++)
            {
                cbSector.Items.Add(arrays.sector[i]);
            }

            for (int i = 0; i < arrays.estados.Length; i++)
            {
                cbEstados.Items.Add(arrays.estados[i]);
            }
        }

        private void cbEstados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string selection = cbEstados.SelectedItem.ToString();

                switch (selection)
                {
                    case "Aguascalientes":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.AguascalientesMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.AguascalientesMun[i]);
                        }
                        break;

                    case "Baja California":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.BajaCaliforniaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.BajaCaliforniaMun[i]);
                        }
                        break;

                    case "Baja California Sur":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.BajaCaliforniaSMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.BajaCaliforniaSMun[i]);
                        }
                        break;
                    case "Campeche":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.CampecheMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.CampecheMun[i]);
                        }
                        break;
                    case "Coahuila":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.CoahuilaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.CoahuilaMun[i]);
                        }
                        break;
                    case "Colima":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.ColimaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.ColimaMun[i]);
                        }
                        break;
                    case "Chiapas":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.ChiapasMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.ChiapasMun[i]);
                        }
                        break;
                    case "Ciudad de Mexico":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.CiudadDeMexicoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.CiudadDeMexicoMun[i]);
                        }
                        break;
                    case "Chihuahua":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.ChihuahuaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.ChihuahuaMun[i]);
                        }
                        break;
                    case "Durango":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.DurangoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.DurangoMun[i]);
                        }
                        break;
                    case "Guanajuato":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.GuanajuatoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.GuanajuatoMun[i]);
                        }
                        break;
                    case "Guerrero":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.GuerreroMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.GuerreroMun[i]);
                        }
                        break;
                    case "Hidalgo":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.HidalgoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.HidalgoMun[i]);
                        }
                        break;
                    case "Jalisco":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.JaliscoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.JaliscoMun[i]);
                        }
                        break;
                    case "Mexico":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.MexicoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.MexicoMun[i]);
                        }
                        break;
                    case "Michoacan":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.MichoacanMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.MichoacanMun[i]);
                        }
                        break;
                    case "Morelos":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.MorelosMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.MorelosMun[i]);
                        }
                        break;
                    case "Nayarit":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.NayaritMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.NayaritMun[i]);
                        }
                        break;
                    case "Nuevo Leon":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.NuevoLeonMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.NuevoLeonMun[i]);
                        }
                        break;
                    case "Oaxaca":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.OaxacaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.OaxacaMun[i]);
                        }
                        break;
                    case "Puebla":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.PueblaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.PueblaMun[i]);
                        }
                        break;
                    case "Queretaro":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.QueretaroMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.QueretaroMun[i]);
                        }
                        break;
                    case "Quintana Roo":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.QuintanaRooMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.QuintanaRooMun[i]);
                        }
                        break;
                    case "San Luis Potosi":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.SanLuisPotosiMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.SanLuisPotosiMun[i]);
                        }
                        break;
                    case "Sinaloa":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.SinaloaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.SinaloaMun[i]);
                        }
                        break;
                    case "Sonora":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.SonoraMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.SonoraMun[i]);
                        }
                        break;
                    case "Tabasco":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.TabascoMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.TabascoMun[i]);
                        }
                        break;
                    case "Tamaulipas":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.TamaulipasMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.TamaulipasMun[i]);
                        }
                        break;
                    case "Tlaxcala":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.TlaxcalaMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.TlaxcalaMun[i]);
                        }
                        break;
                    case "Veracruz":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.VeracruzMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.VeracruzMun[i]);
                        }
                        break;
                    case "Yucatan":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.YucatanMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.YucatanMun[i]);
                        }
                        break;
                    case "Zacatecas":
                        cbMunicipios.Items.Clear();
                        for (int i = 0; i < arrays.ZacatecasMun.Length; i++)
                        {
                            cbMunicipios.Items.Add(arrays.ZacatecasMun[i]);
                        }
                        break;
                    default:
                        cbMunicipios.SelectedIndex = -1;
                        cbEstados.SelectedIndex = -1;
                        break;
                }
            }
            catch { }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Alta darAlta = new Alta();
            darAlta.Cliente();
        }

        private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void btnGuardar_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFA1C517");
            SolidColorBrush brush = new SolidColorBrush(color);
            btnGuardar.Background = brush;
        }

        private void btnGuardar_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FF552998");
            SolidColorBrush brush = new SolidColorBrush(color);
            btnGuardar.Background = brush;
        }

        private void btnCancelar_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFA1C517");
            SolidColorBrush brush = new SolidColorBrush(color);
            btnCancelar.Background = brush;
        }

        private void btnCancelar_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FF552998");
            SolidColorBrush brush = new SolidColorBrush(color);
            btnCancelar.Background = brush;
        }

        private void btnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (cvBienvenida.IsVisible == true)
            {
                cvBienvenida.Visibility = System.Windows.Visibility.Hidden;
                cvBienvenida.IsEnabled = false;
            }
            if (cvAltaCliente.IsVisible == true)
            {
                cvConsultaCliente.Visibility = System.Windows.Visibility.Hidden;
                cvConsultaCliente.IsEnabled = false;
            }
            cvAltaCliente.Visibility = System.Windows.Visibility.Visible;
            cvAltaCliente.IsEnabled = true;
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void btnConsultaUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (cvBienvenida.IsVisible == true)
            {
                cvBienvenida.Visibility = System.Windows.Visibility.Hidden;
                cvBienvenida.IsEnabled = false;
            }
            if (cvAltaCliente.IsVisible == true)
            {
                cvAltaCliente.Visibility = System.Windows.Visibility.Hidden;
                cvAltaCliente.IsEnabled = false;
            }
            cvConsultaCliente.Visibility = System.Windows.Visibility.Visible;
            cvConsultaCliente.IsEnabled = true;
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            tbClaveInterna.Clear();
            tbNombre.Clear();
            tbClave.Clear();
            tbTelefono.Clear();
            tbCelular.Clear();
            tbCorreoElectronico.Clear();
            tbColonia.Clear();
            cbEstados.SelectedItem = null;
            cbMunicipios.SelectedItem = null;
            cbSector.SelectedIndex = -1;
            cbTurno.SelectedIndex = -1;
            cvAltaCliente.Visibility = System.Windows.Visibility.Hidden;
            cvAltaCliente.IsEnabled = false;
            cvBienvenida.Visibility = System.Windows.Visibility.Visible;
            cvBienvenida.IsEnabled = true;
        }

        private void tbbuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchableText = tbbuscar.Text;
            var data = dgConsulta.Items;

            //data[0].Nombre.Contains(searchableText) || data[0].Apellido.Contains(searchableText)
            // search over columns/properties in data
        }
    }
}