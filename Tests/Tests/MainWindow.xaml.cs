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

namespace Tests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntryWindow entryWindow;
        EditorPage editorPage = new EditorPage();
        public bool WhoEntry;
        List<TestClass> ListTests = new List<TestClass>();


        public MainWindow(bool WhoEntry)
        {
            InitializeComponent();
            Editor_Button.IsEnabled = WhoEntry;
            if (System.IO.Path.Exists(Json.desktop)) ListTests = Json.Deserilaz<List<TestClass>>();
            editorPage.EditorGrid.ItemsSource = ListTests;
        }

        private void Editor_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new EditorPage();
        }

        private void Test_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new TestPage();

            if(editorPage.EditorGrid.Items.Count == 0)
            {
                PageFrame.Content = new NoTestPage();
            }
            else
            { 
            
            }

        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            entryWindow = new EntryWindow();
            Close();
            entryWindow.Show();
        }
    }
}
