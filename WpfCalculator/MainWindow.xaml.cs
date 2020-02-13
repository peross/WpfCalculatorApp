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

namespace WpfCalculator
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

        private void btnJedan_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "1";
            else
                txtEkran1.Text = txtEkran1.Text + "1";
        }

        private void btnDva_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "2";
            else
                txtEkran1.Text = txtEkran1.Text + "2";
        }

        private void btnTri_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "3";
            else
                txtEkran1.Text = txtEkran1.Text + "3";
        }

        private void btnCetiri_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "4";
            else
                txtEkran1.Text = txtEkran1.Text + "4";
        }

        private void btnPet_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "5";
            else
                txtEkran1.Text = txtEkran1.Text + "5";
        }

        private void btnSest_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "6";
            else
                txtEkran1.Text = txtEkran1.Text + "6";
        }

        private void btnSedam_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "7";
            else
                txtEkran1.Text = txtEkran1.Text + "7";
        }

        private void btnOsam_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "8";
            else
                txtEkran1.Text = txtEkran1.Text + "8";
        }

        private void btnDevet_Click(object sender, RoutedEventArgs e)
        {
            if (txtEkran1.Text == "0" && txtEkran1.Text != null)
                txtEkran1.Text = "9";
            else
                txtEkran1.Text = txtEkran1.Text + "9";
        }

        private void btnUlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
