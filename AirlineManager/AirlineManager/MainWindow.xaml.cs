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
using AirlineManager.ViewModel;

namespace AirlineManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Viewmodel view = new Viewmodel();
        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox3.Text = view.Boeing747();
            textBox3a.Text = view.BoeingTicketSales();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = view.A320();
            textBox2a.Text = view.A320ticketSales();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = view.MD90();
            textBox1a.Text = view.MD90TicketSales();
        }
    }
}
