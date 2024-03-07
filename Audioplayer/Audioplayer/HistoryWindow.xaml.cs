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

namespace Audioplayer
{
    /// <summary>
    /// Логика взаимодействия для HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : Window
    {
        public string path;
        public HistoryWindow(List<string> history)
        {
            InitializeComponent();
            HistoryList.ItemsSource = history;
        }

        private void HistoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            path = HistoryList.SelectedItem.ToString();
            DialogResult = true;
            
        }
    }
}
