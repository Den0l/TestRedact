using System.IO;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pract2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ClassMark> marks = new List<ClassMark>();
        List<ClassMark> marksToday = new List<ClassMark>();
        DateTime date;
        
        public void Show(DateTime dat)
        {
            marks = Json.Deserilaz<List<ClassMark>>();
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i].DateMark.Date == dat.Date)
                {
                    marksToday.Add(marks[i]);
                }
            }
            ListItem.Items.Refresh();
            ListItem.ItemsSource = marksToday;
            ListItem.DisplayMemberPath = "Name";
        }

        public MainWindow()
        {
            InitializeComponent();
            Name.Text = "Введите название для заметки";
            Name.Foreground = Brushes.Gray;
            Mark.Text = "Введите описание заметки";
            Mark.Foreground = Brushes.Gray;
            ShowDate.Text = DateTime.Now.ToShortDateString();
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Mark.json"))
            {
                Show(DateTime.Now);
            }
            else
            {
                Json.Serilaz(marks);
            }
           
        }



        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if(Name.Text == "Введите название для заметки")
            {
                Name.Text = "";
                Name.Foreground = Brushes.Black ;
            }
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text))
            {
                Name.Text = "Введите название для заметки";
                Name.Foreground = Brushes.Gray;
            }
        }

        private void Mark_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Mark.Text == "Введите описание заметки")
            {
                Mark.Text = "";
                Mark.Foreground = Brushes.Black;
            }
        }

        private void Mark_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mark.Text))
            {
                Mark.Text = "Введите описание заметки";
                Mark.Foreground = Brushes.Gray;
            }
        }


        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            marksToday.Clear();
            date = Convert.ToDateTime(Calendar.SelectedDate);
            ShowDate.Text = date.ToShortDateString();
            Show(date);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            date = Convert.ToDateTime(Calendar.SelectedDate);
            int ind = 0;
            ClassMark selectedMark = ListItem.SelectedItem as ClassMark;

            ind = marks.IndexOf(selectedMark);

            marks.RemoveAt(ind);

            Json.Serilaz(marks);
            Show(date);
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            date = Convert.ToDateTime(Calendar.SelectedDate);
            marks.Add(new ClassMark(Name.Text, Mark.Text, date));
            Json.Serilaz(marks);
            Show(date);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            date = Convert.ToDateTime(Calendar.SelectedDate);
            int ind = 0;
            ClassMark selectedMark = ListItem.SelectedItem as ClassMark;

            ind = marks.IndexOf(selectedMark);

            marks[ind] = new ClassMark(Name.Text, Mark.Text, date);

            Json.Serilaz(marks);
            Show(date);
        }

        private void ListItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            date = Convert.ToDateTime(Calendar.SelectedDate);
            ClassMark selectedMark = ListItem.SelectedItem as ClassMark;
            if(selectedMark != null)
            { 
                if (selectedMark.DateMark.Date == date.Date)
                {
                    Name.Text = selectedMark.Name;
                    Name.Foreground = Brushes.Black;
                    Mark.Text = selectedMark.Mark;
                    Mark.Foreground = Brushes.Black;
                }
            }

        }
    }
}