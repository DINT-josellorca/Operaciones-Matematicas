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

namespace Operaciones_Matematicos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando_1_TextBox.Text = "0";
            Operando_2_TextBox.Text = "0";
            Suma_RadioButton.IsChecked = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Suma_RadioButton.IsChecked = true;
            Operando_1_TextBox.Text = "0";
            Operando_2_TextBox.Text = "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Operando_1_TextBox.Text != "" && Operando_2_TextBox.Text != "")
            {
                Operacion();
            }

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (Operando_2_TextBox.Text != "" && Operando_1_TextBox.Text != "")
            {
                Operacion();
            }
        }

        private void Suma_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operacion();
        }

        private void Resta_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operacion();
        }

        private void Multiplicacion_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operacion();
        }

        private void Division_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operacion();
        }
        private void Operacion()
        {
            float operando1 = float.Parse(Operando_1_TextBox.Text), operando2 = float.Parse(Operando_2_TextBox.Text);
            if ((bool)Suma_RadioButton.IsChecked)
            {
                Resultado_TextBox.Text = (operando1 + operando2).ToString();
            }
            else if ((bool)Resta_RadioButton.IsChecked)
            {
                Resultado_TextBox.Text = (operando1 - operando2).ToString();
            }
            else if ((bool)Multiplicacion_RadioButton.IsChecked)
            {
                Resultado_TextBox.Text = (operando1 * operando2).ToString();
            }
            else
            {
                if (operando2 != 0)
                    Resultado_TextBox.Text = (operando1 / operando2).ToString();
                else
                    Resultado_TextBox.Text = "Error";
            }
        }
    }
}
