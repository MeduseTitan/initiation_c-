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

namespace ex01
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private int Check_Command()
        {
            string[] boisson = {"Coca", "Ice-Tea", "Orangina", "Sprite"};
            string command = "commande envoyé =" + this.Burger.Text.ToString();

            if (this.Frites.IsChecked == true)
                command += ", " + "frites";
            else if (this.Potatoes.IsChecked == true)
                command += ", " + "potatoes";

    
            command += ", " + boisson[this.Boissons.SelectedIndex];
            Console.WriteLine(command);
            return (0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string msg = "Confirmer la commande: ";
            string ttl = "SUCCESSS";
            MessageBoxButton btn = MessageBoxButton.OKCancel;
            MessageBoxImage img = MessageBoxImage.Information;
 
            MessageBoxResult res = MessageBox.Show(msg, ttl, btn, img);

            switch(res)
            {
                case MessageBoxResult.OK:
                    MessageBox.Show("Commande confirmée");
                    if (Check_Command() == 84)
                        return;
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Commande annulée");
                    break;
            }
        }
    }
}
