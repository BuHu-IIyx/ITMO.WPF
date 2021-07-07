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

namespace ITMO.WPF.Practice11.Param
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = ITMO.WPF.Practice12.Param.Properties.Settings.Default.ApplicationName;
            this.Background = new System.Windows.Media.SolidColorBrush(
            ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!(listBox1.SelectedItem == null))
            {
                String astring = ((ListBoxItem)listBox1.SelectedItem).Content.ToString();
                switch (astring)
                {
                    case "Red":
                        ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor = Colors.Red;
                        break;
                    case "Blue":
                        ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor = Colors.Blue;
                        break;
                    case "Green":
                        ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor = Colors.Green;
                        break;
                    case "Tomato":
                        ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor = Colors.Tomato;
                        break;
                }
                this.Background = new System.Windows.Media.SolidColorBrush(
                ITMO.WPF.Practice12.Param.Properties.Settings.Default.BackgroundColor);
                ITMO.WPF.Practice12.Param.Properties.Settings.Default.Save();
            }
        }
    }
}
