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

namespace ElTrompo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] turno = { "Vespertino", "Matutino", "Diurno" };
            string[] sector = { "Publica", "Privada" };
            string[] estados = {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Coahuila", "Colima",
                                "Chiapas", "Ciudad de Mexico", "Chihuahua", "Durango", "Guanajuato", "Guerrero", "Hidalgo",
                                "Jalisco", "Michoacan", "Morelos", "Nayarit", "Nuevo Leon", "Oaxaca", "Puebla", "Queretaro",
                                "Quintana Roo", "San Luis Potosi", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala",
                                "Veracruz", "Yucatan", "Zacatecas"};

            for (int i = 0; i < turno.Length; i++)
            {
                cbTurno.Items.Add(turno[i]);
            }

            for (int i = 0; i < sector.Length; i++)
            {
                cbSector.Items.Add(sector[i]);
            }

            for (int i = 0; i < estados.Length; i++)
            {
                cbEstados.Items.Add(estados[i]);
            }
            

        }
    }
}
