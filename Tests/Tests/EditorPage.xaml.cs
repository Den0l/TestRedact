using System;
using System.IO;
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

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для EditorPage.xaml
    /// </summary>
    public partial class EditorPage : Page
    {
        List<TestClass> ListTests = new List<TestClass>();
          
        public EditorPage()
        {
            InitializeComponent();
            if(System.IO.Path.Exists(Json.desktop) ) ListTests = Json.Deserilaz<List<TestClass>>();

            EditorGrid.ItemsSource = ListTests;

            ComboText.DisplayMemberPath = "questionName";
            ComboText.ItemsSource = ListTests;
        }

        private void UpdateGrid(List<TestClass> ListTests)
        {
            EditorGrid.ItemsSource = null;
            EditorGrid.ItemsSource = ListTests;
            Json.Serilaz<List<TestClass>>(ListTests);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(ComboText.SelectedItem != null && TextName.Text != "" && TextDesk.Text != "" && TextFirs.Text != "" && TextSeco.Text != "" && TextThri.Text != "" && TextAnsw.Text != "")
            {
                var change = new TestClass(TextName.Text, TextDesk.Text, TextFirs.Text, TextSeco.Text, TextThri.Text, TextAnsw.Text);
                ListTests[ComboText.SelectedIndex] = change;
                UpdateGrid(ListTests);
            }
            else if(ComboText.SelectedItem != null && TextName.Text == "" && TextDesk.Text == "" && TextFirs.Text == "" && TextSeco.Text == "" && TextThri.Text == "" && TextAnsw.Text == "")
            {
                ListTests.RemoveAt(ComboText.SelectedIndex);
                UpdateGrid(ListTests);
            }
            else
            {
                ListTests.Add(new TestClass(TextName.Text, TextDesk.Text, TextFirs.Text, TextSeco.Text, TextThri.Text, TextAnsw.Text));
                UpdateGrid(ListTests);
            }

            ComboText.SelectedItem = null;
            TextName.Text = null; TextDesk.Text = null; TextFirs.Text = null; TextSeco.Text = null; TextThri.Text = null; TextAnsw.Text = null;

        }

    }
}
