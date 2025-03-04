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
        double   res;
        char operador = '.';

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
            char[] UltNro = textB.Text.ToCharArray();
            if (digito1.Text.Contains('-') || digito1.Text.Contains('x') || digito1.Text.Contains('÷'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;

                digito1.Text = String.Concat(UltNro);

            }
            else  if (verificacion())
            {
                digito1.Text = textB.Text + operador;
                textB.Clear();
                
            }
            else if (textB.Text.Length - 1 == '+')
            {

            }
        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {
            operador = '-';
            char[] UltNro = textB.Text.ToCharArray();
            if (digito1.Text.Contains('+') ||digito1.Text.Contains('x') || digito1.Text.Contains('÷'))
            {
                UltNro =digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {
                
                digito1.Text = textB.Text + operador;
                textB.Clear();

            }
            else if (digito1.Text.Length - 1 == '-')
            {

            }
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            operador = 'x';
            char[] UltNro = textB.Text.ToCharArray();
            if (digito1.Text.Contains('+') || digito1.Text.Contains('-') || digito1.Text.Contains('÷'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {
                
                digito1.Text = textB.Text + operador;
                textB.Clear();

            }
            else if (digito1.Text.Length - 1 == '-')
            {

            }
        }
        private void divi_Click(object sender, RoutedEventArgs e)
        {
            operador = '÷';
            char[] UltNro = textB.Text.ToCharArray();
            if (digito1.Text.Contains('+') || digito1.Text.Contains('x') || digito1.Text.Contains('-'))
            {
                UltNro = digito1.Text.ToCharArray();
                UltNro[UltNro.Length - 1] = operador;
                digito1.Text = String.Concat(UltNro);

            }
            else if (verificacion())
            {
                
                digito1.Text = textB.Text + operador;
                textB.Clear();

            }
            else if (digito1.Text.Length - 1 == '÷')
            {

            }
        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            char[] UNro = digito1.Text.ToCharArray();

            switch (UNro[digito1.Text.Length-1])
            {
                case '+':
                    a = long.Parse( digito1.Text.Remove(digito1.Text.Length - 1));
                    b = long.Parse(textB.Text);
                    res = a + b;
                    textB.Clear();
                    digito1.Text=String.Concat(res);

                    break;
                case '-':
                    a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                    b = long.Parse(textB.Text);
                    res = a - b;
                    textB.Clear();
                    digito1.Text = String.Concat(res);
                    break;
                case 'x':
                    a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                    b = long.Parse(textB.Text);
                    res = a * b;
                    textB.Clear();
                    digito1.Text = String.Concat(res);
                    break;
                case '÷':
                    a = long.Parse(digito1.Text.Remove(digito1.Text.Length - 1));
                    b = long.Parse(textB.Text);
                    res=(double) a / b;
                    textB.Clear();
                    digito1.Text = String.Concat(res);
                    break;
                default: break;
            }
        }

        private bool verificacion()
        {
            bool condicion = false;

            if ( (textB.Text.Length == 1 && long.Parse(textB.Text) > 0) || textB.Text.Length > 1)
            {
                condicion = true;
            }

            return condicion;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (verificacion())
            {
                if (textB.Text.Length==1)
                {
                    textB.Text="0";
                }
                else
                {
                    textB.Text=textB.Text.Remove(textB.Text.Length-1);
                }

            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            digito1.Text = "";
            textB.Text = "0";
        }

       
    }
}