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

namespace Ejercicio8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tecla_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox cajaTexto = (TextBox)sender;

            if (e.Key == Key.F1)
            {

                if (cajaTexto.Tag.ToString().Contains("Nombre"))
                {
                    if (tipNombreTextBox.Text == "") tipNombreTextBox.Text = cajaTexto.Tag.ToString();
                    else tipNombreTextBox.Text = "";

                }
                else if (cajaTexto.Tag.ToString().Contains("Apellido"))
                {
                    if (tipApellidoTextBox.Text == "") tipApellidoTextBox.Text = cajaTexto.Tag.ToString();
                    else tipApellidoTextBox.Text = "";
                }

            }
            else if (e.Key == Key.F2)
            {
                if (cajaTexto.Tag.ToString().Contains("Edad"))
                {
                    if (!int.TryParse(cajaTexto.Text, out int s))
                    {
                        if (errorEdadTextBox.Text == "") errorEdadTextBox.Text = cajaTexto.Tag.ToString();
                        else errorEdadTextBox.Text = "";
                    }
                }
            }

        }

    }
}
