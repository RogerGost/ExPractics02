using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExPractics02
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
        private void Themes(string theme)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            var newTheme = new ResourceDictionary
            {
                Source = new Uri($"Themes/{theme}", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Resources.MergedDictionaries[0].Source.ToString().Contains("TemaClar"))
            {
                Themes("TemaFosc.xaml");
            }
            else
            {
                Themes("TemaClar.xaml");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}