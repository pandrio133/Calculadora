using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        long a, b;
        double res;
        char operador = '.';
        char[] UltNro;

        private void nro1_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "1";
            }
            else
            {
                textB.Text = "1";
            }
        }

        private void nro2_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "2";
            }
            else
            {
                textB.Text = "2";
            }
        }

        private void nro3_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "3";
            }
            else
            {
                textB.Text = "3";
            }
        }

        private void nro4_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "4";
            }
            else
            {
                textB.Text = "4";
            }
        }

        private void nro5_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "5";
            }
            else
            {
                textB.Text = "5";
            }
        }

        private void nro6_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "6";
            }
            else
            {
                textB.Text = "6";
            }
        }

        private void nro7_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "7";
            }
            else
            {
                textB.Text = "7";
            }
        }

        private void nro8_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "8";
            }
            else
            {
                textB.Text = "8";
            }
        }

        private void nro9_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "9";
            }
            else
            {
                textB.Text = "9";
            }
        }

        private void nro0_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                textB.Text = textB.Text + "0";
            }
            else
            {
                textB.Text = "0";
            }
        }

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            operador = '+';
            UltNro = textB.Text.ToCharArray();
            if (textB.Text == null)
            {
                textB.Text = "0";
            }
            if (digito1.Text.Contains('+'))
            {
            }
            else if (textB.Text.Length == 1 && textB.Text[textB.Text.Length - 1] == '-')
            {
            }
            else if (digito1.Text.Contains('-') || digito1.Text.Contains('x') || digito1.Text.Contains('÷'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;

                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {
                digito1.Text = textB.Text + operador;
                textB.Clear();
                textB.Text = "0";
            }

        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {
            operador = '-';
            UltNro = digito1.Text.ToCharArray();
            if (textB.Text == null)
            {
                textB.Text = "0";
            }
            if (textB.Text.Length == 1 && textB.Text[textB.Text.Length - 1] == '-')
            {
            }
            else if (long.TryParse(textB.Text, out long nro) && nro == 0)// el numero es igual a 0
            {
                textB.Text = "-";
            }
            else if (digito1.Text.Contains('+') || digito1.Text.Contains('x') || digito1.Text.Contains('÷'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = string.Concat(UltNro);
            }
            else if (verificacion())
            {
                digito1.Text = textB.Text + operador;
                textB.Clear();
                textB.Text = "0";
            }

        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            operador = 'x';
            UltNro = digito1.Text.ToCharArray();
            if (textB.Text == null)
            {
                textB.Text = "0";
            }
            if (UltNro.Contains('x'))
            {
            }
            else if (textB.Text.Length == 1 && textB.Text[textB.Text.Length - 1] == '-')
            {
            }
            else if (digito1.Text.Contains('+') || digito1.Text.Contains('-') || digito1.Text.Contains('÷'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {

                digito1.Text = textB.Text + operador;
                textB.Clear();
                textB.Text = "0";
            }

        }
        private void divi_Click(object sender, RoutedEventArgs e)
        {
            operador = '÷';
            UltNro = digito1.Text.ToCharArray();
            if (textB.Text == null)
            {
                textB.Text = "0";
            }
            if (UltNro.Contains('÷'))
            {
            }
            else if (textB.Text.Length == 1 && textB.Text[textB.Text.Length - 1] == '-')
            {
            }
            else if (digito1.Text.Contains('+') || digito1.Text.Contains('x') || digito1.Text.Contains('-'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {   digito1.Text = textB.Text + operador;
                textB.Clear();
                textB.Text = "0";
            }

        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            if (digito1 != null && digito1.Text.Length > 0)
            {
                char[] UNro = digito1.Text.ToCharArray();
                switch (UNro[digito1.Text.Length - 1])
                {
                    case '+':
                        a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                        b = long.Parse(textB.Text);
                        res = a + b;
                        textB.Clear();
                        digito1.Text = String.Concat(res);
                        textB.Text = "0";
                        break;
                    case '-':
                        a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                        b = long.Parse(textB.Text);
                        res = a - b;
                        textB.Clear();
                        digito1.Text = String.Concat(res);
                        textB.Text = "0";
                        break;
                    case 'x':
                        a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                        b = long.Parse(textB.Text);
                        res = a * b;
                        textB.Clear();
                        digito1.Text = String.Concat(res);
                        textB.Text = "0";
                        break;
                    case '÷':
                        a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                        b = long.Parse(textB.Text);
                        res = (double)a / b;
                        textB.Clear();
                        digito1.Text = String.Concat(res);
                        textB.Text = "0";
                        break;
                    default: break;
                }
            }
        }

        private bool verificacion()
        {
            bool condicion = false;
            // forma de verificar lo que hay en el textBox, dice:
            // si el texto es mayor o igual a 1 digito
            if (textB.Text.Length >= 1)
            {
                // el valor debe ser distinto a 0 ó igual a negativo
                if (long.TryParse(textB.Text, out long num) && num != 0 || textB.Text == "-")
                {
                    condicion = true;
                }
            }
            return condicion;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                if (textB.Text.Length == 1)
                {
                    textB.Text = "0";
                }
                else
                {
                    textB.Text = textB.Text.Remove(textB.Text.Length - 1);
                }

            }
        }

        private void textB_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Setter_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            digito1.Text = "";
            textB.Text = "0";
        }


    }
}