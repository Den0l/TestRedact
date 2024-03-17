using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        List<TestClass> ListTests = new List<TestClass>();
        private int i = 0;
        private int ans = 0;
        public TestPage()
        {
            InitializeComponent();
            if (System.IO.Path.Exists(Json.desktop)) ListTests = Json.Deserilaz<List<TestClass>>();

            Test(i);
        }

        private void Test(int i)
        {
            if(i < ListTests.Count)
            {
                TestQuest.Text = ListTests[i].questionDeskrp;
                TestFirs.Content = ListTests[i].questionFirst;
                TestSeco.Content = ListTests[i].questionSecond;
                TestThir.Content = ListTests[i].questionThird;
                
            }
            else if (i  == ListTests.Count)
            {
                
                TestQuest.Text = "Вы правильно ответили на " + ans + " из " + ListTests.Count;
                TestFirs.Content = null;
                TestSeco.Content = null;
                TestThir.Content = null;
            }
            else
            {
                
            }
            
        }

        private void AnwerQuest(string l, int i)
        {
           
                if (ListTests[i].questionAnswer == l)
                {
                    ans++;
                }
            
           
        }

        private void TestFirs_Click(object sender, RoutedEventArgs e)
        {
            if (i < ListTests.Count)
            {
                AnwerQuest(ListTests[i].questionFirst, i);
            }
            i++;
            Test(i);
        }

        private void TestSeco_Click(object sender, RoutedEventArgs e)
        {
            if (i < ListTests.Count)
            {
                AnwerQuest(ListTests[i].questionSecond, i);
            }
            i++;
            Test(i);
        }

        private void TestThir_Click(object sender, RoutedEventArgs e)
        {
            if (i < ListTests.Count)
            {
                AnwerQuest(ListTests[i].questionThird, i);
            } 
            i++;
            Test(i);
        }
    }
}
