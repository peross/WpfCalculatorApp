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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double rezultat;
        double prviBroj;
        string aritmetickiOperator;
        bool izabranaOperacija = false;

        public MainWindow()
        {
            InitializeComponent();
            txtEkranGlavni.MaxLength = 10;
            txtEkranGlavni.MaxLines = 1;
        }

        /// <summary>
        /// Omogucen unos samo brojeva
        /// PreviewTextInput="provjeriUnos" XAML
        /// </summary>
        private void provjeriUnos(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private static bool duzinaEkrana(TextBox textBox)
        {
            if (textBox.Text.Length > 9)
                return false;
            return true;
        }

        private void btnJedan_Click(object sender, RoutedEventArgs e)
        {
            duzinaEkrana(txtEkranGlavni);
            if (txtEkranGlavni.Text == "0" || izabranaOperacija)
                txtEkranGlavni.Text = string.Empty;

            izabranaOperacija = false;

            Button button = (Button)sender;
            if(button.Content.ToString() == ".")
            {
                if (!txtEkranGlavni.Text.Contains("."))
                    txtEkranGlavni.Text += button.Content.ToString();
                else if (txtEkranGlavni.Text == "0")
                    txtEkranGlavni.Text = "0" + button.Content.ToString();
            }
            else
                txtEkranGlavni.Text += button.Content.ToString();
        }

        private void btnUlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {
            txtEkranGlavni.Text = "0";
            txtEkran1.Text = "";
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            rezultat = double.Parse(txtEkranGlavni.Text);
            rezultat *= -1;
            txtEkranGlavni.Text = rezultat.ToString();
        }

        private void btnPuta_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "*";
            txtEkran1.Text = prviBroj + "*";
            izabranaOperacija = true;
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "-";
            txtEkran1.Text = prviBroj + "-";
            izabranaOperacija = true;
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "+";
            txtEkran1.Text = prviBroj + "+";
            izabranaOperacija = true;
        }
        private void btnPodjeljeno_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "/";
            txtEkran1.Text = prviBroj + "÷";
            izabranaOperacija = true;
        }
        private void btnJednako_Click(object sender, RoutedEventArgs e)
        {
            switch (aritmetickiOperator)
            {
                case "*":
                    txtEkranGlavni.Text = (prviBroj * double.Parse(txtEkranGlavni.Text)).ToString();
                    txtEkran1.Text = "";
                    break;
                case "/":
                    txtEkranGlavni.Text = (prviBroj / double.Parse(txtEkranGlavni.Text)).ToString();
                    txtEkran1.Text = "";
                    break;
                case "+":
                    txtEkranGlavni.Text = (prviBroj + double.Parse(txtEkranGlavni.Text)).ToString();
                    txtEkran1.Text = "";
                    break;
                case "-":
                    txtEkranGlavni.Text = (prviBroj - double.Parse(txtEkranGlavni.Text)).ToString();
                    txtEkran1.Text = "";
                    break;
                case "exp":
                    double kvadrat = double.Parse(txtEkranGlavni.Text);
                    txtEkran1.Text = prviBroj + ".e+" + kvadrat;
                    double rezultat = Math.Pow(10, kvadrat)*2;
                    txtEkranGlavni.Text = rezultat.ToString();
                    break;
                case "mod":
                    txtEkran1.Text = prviBroj + " Mod(" + txtEkranGlavni.Text + ")";
                    txtEkranGlavni.Text = (prviBroj % double.Parse(txtEkranGlavni.Text)).ToString();
                    break;
            }
        }

        private void btnBrisi_Click(object sender, RoutedEventArgs e)
        {
            int index = txtEkranGlavni.Text.Length;
            index--;
            txtEkranGlavni.Text = txtEkranGlavni.Text.Remove(index);
            if (txtEkranGlavni.Text == string.Empty)
                txtEkranGlavni.Text = "0";
        }

        private void iskljuciDugmad()
        {
            //btnPi.Visibility = Visibility.Hidden;
            //btnSinh.Visibility = Visibility.Hidden; 
            //btnCosh.Visibility = Visibility.Hidden;
            //btnTanh.Visibility = Visibility.Hidden;
            //btnExp.Visibility = Visibility.Hidden;

            //btnLog.Visibility = Visibility.Hidden; 
            //btnSin.Visibility = Visibility.Hidden;
            //btnCos.Visibility = Visibility.Hidden;
            //btnTan.Visibility = Visibility.Hidden;
            //btnMod.Visibility = Visibility.Hidden;

            //btnKorijen.Visibility = Visibility.Hidden;
            //btnDec.Visibility = Visibility.Hidden;
            //btnHex.Visibility = Visibility.Hidden;
            //btnOct.Visibility = Visibility.Hidden;
            //btnBin.Visibility = Visibility.Hidden;

            //btnKvadrat.Visibility = Visibility.Hidden;
            //btnKubni.Visibility = Visibility.Hidden;
            //btnReciprocno.Visibility = Visibility.Hidden;
            //btnLn.Visibility = Visibility.Hidden;
            //btnPosto.Visibility = Visibility.Hidden;

            //gridGlavnaMreza.ColumnDefinitions.RemoveAt(4);
        }
        private void obrisiKol4()
        {
            if (gridGlavnaMreza.ColumnDefinitions.Count >= 4)
                gridGlavnaMreza.ColumnDefinitions.RemoveRange(0, 4);
        }
        private void btnObicni_Click(object sender, RoutedEventArgs e)
        {
            iskljuciDugmad();
            obrisiKol4();
            Application.Current.MainWindow.Width = 300;
        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {
            double pi = Math.PI;
            txtEkranGlavni.Text = pi.ToString();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            double log = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "log(" + log + ")";
            log = Math.Log10(log);
            txtEkranGlavni.Text = log.ToString();
        }

        private void btnKorijen_Click(object sender, RoutedEventArgs e)
        {
            double korijen = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "√" + korijen;
            korijen = Math.Sqrt(korijen);
            txtEkranGlavni.Text = korijen.ToString();
        }

        private void btnKvadrat_Click(object sender, RoutedEventArgs e)
        {
            double kvadrat = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "sqr(" + kvadrat + ")";
            kvadrat = Math.Pow(kvadrat, 2);
            txtEkranGlavni.Text = kvadrat.ToString();
        }

        private void btnSinh_Click(object sender, RoutedEventArgs e)
        {
            double sinh = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "sinh(" + sinh + ")";
            sinh = Math.Sinh(sinh);
            txtEkranGlavni.Text = sinh.ToString();
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            double sin = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "sin(" + sin + ")";
            sin = Math.Sin(sin);
            txtEkranGlavni.Text = sin.ToString();
        }

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int dec = int.Parse(txtEkranGlavni.Text);
                txtEkran1.Text = "DEC(" + dec + ")";
                txtEkranGlavni.Text = System.Convert.ToString(dec, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKubni_Click(object sender, RoutedEventArgs e)
        {
            double kub = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "cube(" + kub + ")";
            kub = Math.Pow(kub, 3);
            txtEkranGlavni.Text = kub.ToString();
        }

        private void btnCosh_Click(object sender, RoutedEventArgs e)
        {
            double cosh = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "cosh(" + cosh + ")";
            cosh = Math.Cosh(cosh);
            txtEkranGlavni.Text = cosh.ToString();
        }

        private void btnCos_Click(object sender, RoutedEventArgs e)
        {
            double cos = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "cos(" + cos + ")";
            cos = Math.Cos(cos);
            txtEkranGlavni.Text = cos.ToString();
        }

        private void btnHex_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int hex = int.Parse(txtEkranGlavni.Text);
                txtEkran1.Text = "HEX(" + hex + ")";
                txtEkranGlavni.Text = System.Convert.ToString(hex, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReciprocno_Click(object sender, RoutedEventArgs e)
        {
            double reciprocno = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "1÷" + reciprocno;
            reciprocno = 1 / reciprocno;
            txtEkranGlavni.Text = reciprocno.ToString();
        }

        private void btnTanh_Click(object sender, RoutedEventArgs e)
        {
            double tanh = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "tanh(" + tanh + ")";
            tanh = Math.Tanh(tanh);
            txtEkranGlavni.Text = tanh.ToString();
        }

        private void btnTan_Click(object sender, RoutedEventArgs e)
        {
            double tan = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "tan(" + tan + ")";
            tan = Math.Tan(tan);
            txtEkranGlavni.Text = tan.ToString();
        }

        private void btnBin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int bin = int.Parse(txtEkranGlavni.Text);
                txtEkran1.Text = "BIN(" + bin + ")";
                txtEkranGlavni.Text = System.Convert.ToString(bin, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLn_Click(object sender, RoutedEventArgs e)
        {
            double ln = double.Parse(txtEkranGlavni.Text);
            txtEkran1.Text = "ln(" + ln + ")";
            ln = Math.Log(ln);
            txtEkranGlavni.Text = ln.ToString();
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "exp";
            txtEkran1.Text = prviBroj + ".e+";
            izabranaOperacija = true;
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            prviBroj = double.Parse(txtEkranGlavni.Text);

            Button button = (Button)sender;
            aritmetickiOperator = "mod";
            txtEkran1.Text = prviBroj + " Mod(";
            izabranaOperacija = true;
        }

        private void btnOct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int oct = int.Parse(txtEkranGlavni.Text);
                txtEkran1.Text = "OCT(" + oct + ")";
                txtEkranGlavni.Text = System.Convert.ToString(oct, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPosto_Click(object sender, RoutedEventArgs e)
        {
            double posto = double.Parse(txtEkranGlavni.Text);
            posto = posto / 100;
            txtEkranGlavni.Text = posto.ToString();
        }
    }
}
