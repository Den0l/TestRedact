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
using System.Windows.Shapes;

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для EntryWindow.xaml
    /// </summary>
    public partial class EntryWindow : Window
    {
        MainWindow mainWindow;
        public EntryWindow()
        {
            InitializeComponent();
            
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow = new MainWindow(false);
            Close();
            mainWindow.Show();
        }

        private void AuthorButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow = new MainWindow(true);
            if (AuthorWord.Text == "aaa")
            {
                Close();
                mainWindow.Show();
            }
            else
            {
                TextBlockWord.Text = "Неправильное слово";
            }
                
        }
    }
}
