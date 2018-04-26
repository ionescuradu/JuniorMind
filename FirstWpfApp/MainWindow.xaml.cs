using System.Windows;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FirstWpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog().ToString() != null)
            {
                PathInput.Text = openFolder.SelectedPath.ToString();
            }
        }
    }
}
