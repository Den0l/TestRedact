using System.Text;
using System.Linq;
using Microsoft.WindowsAPICodePack;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using Microsoft.WindowsAPICodePack.Shell.Interop;
using System.Threading;
using System.Reflection;
using System.ComponentModel;



namespace Audioplayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public Random rand = new Random();
        public Thread MusicGo;
        public List<string> history = new List<string>();
        CommonFileDialogResult result;
        string path = null;
        string rpath = null;
        string[] files;
        string[] rfiles; 
        
        public MainWindow()
        {
            InitializeComponent();
            MediaEl.Volume = 1;
            Volume.Maximum = 1;
            Volume.Value = 1;
            Slide.Value = 0;
             
            MusicGo = new Thread(RunSlideValueChanged) { IsBackground = true }; ;
            MusicGo.Start();
            
        }

        private void RunSlideValueChanged()
        {
            Dispatcher.InvokeAsync(() =>
            
            {
             

                    if (MediaEl.NaturalDuration.HasTimeSpan || MediaEl.Position > TimeSpan.Zero)
                    {
                        TimeSpan currentTime = MediaEl.Position;
                        TimeSpan totalTime = MediaEl.NaturalDuration.TimeSpan;
                        TimeF.Text = $"{currentTime:hh\\:mm\\:ss} / {totalTime:hh\\:mm\\:ss}";
                        Slide.Maximum = totalTime.TotalSeconds;
                        Slide.Value = currentTime.TotalSeconds;

                    }
                    else
                    {
                        TimeF.Text = "00:00:00 / 00:00:00";

                    }
                
            });
        }

     

        private bool FilesAudio(string path)
        {
            string extension = System.IO.Path.GetExtension(path).ToLower();
            return extension == ".mp3" || extension == ".m4a" || extension == ".wav";
        }

        

        private void Slide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dispatcher.InvokeAsync(() =>
            {
                MediaEl.Position = (TimeSpan.FromSeconds(Slide.Value)) * 10;
                
            });

        }

        private void MediaEl_MediaOpened(object sender, RoutedEventArgs e)
        {
                    
        }
        private void Space_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            result = dialog.ShowDialog();
            if(result == CommonFileDialogResult.Ok)
            {
                files = Directory.GetFiles(dialog.FileName);
                files = files.Where(file => FilesAudio(file)).ToArray();
                rfiles = files;
                ListMusic.ItemsSource = files;
            }
            MediaEl.Source = new Uri(files[0]);
            path = files[0];
            MediaEl.Play();
            
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow win = new HistoryWindow(history);
            bool? res = win.ShowDialog();
            if(res == true)
            {
                path = win.path;
                MediaEl.Source = new Uri(path);
                MediaEl.Play();
            }
            else if(res == false)
            {
                MediaEl.Source = new Uri(path);
                MediaEl.Play();
            }
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MediaEl.Source = new Uri(files[Array.BinarySearch(files, path) - 1 < 0 ? files.Length : Array.BinarySearch(files, path) - 1]);
            MediaEl.Play();
            path = files[Array.BinarySearch(files, path) - 1];
            history.Add(path);
           
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
       
            MediaEl.Source = new Uri(path);
            MediaEl.Play();
            if(MediaEl.CanPause)
            {
                MediaEl.Pause();
            }
            history.Add(path);
            
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            MediaEl.Source = new Uri(files[Array.BinarySearch(files, path)+1 >= files.Length ? 0 : Array.BinarySearch(files, path)]);
            MediaEl.Play();
            path = files[Array.BinarySearch(files, path) + 1];
            history.Add(path);
           
        }

        private void MediaEl_MediaEnded(object sender, RoutedEventArgs e)
        {
            path = files[Array.BinarySearch(files, path) + 1];
            MediaEl.Source = new Uri(path);
            MediaEl.Position = TimeSpan.Zero;
            Slide.Value = 0;
            MediaEl.Play();
        }

        private void Repeate_Click(object sender, RoutedEventArgs e)
        {
            if(rpath == path)
            {
                MediaEl.Source = new Uri(path);
                
            }
            else
            {
                rpath = path;
                MediaEl.Source = new Uri(rpath);
               
            }



        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            
            if(files.SequenceEqual(rfiles))
            {
                rand.Shuffle<string>(rfiles);
                ListMusic.ItemsSource = null;
                ListMusic.ItemsSource = rfiles;
                MediaEl.Source = new Uri(rfiles[0]);
                MediaEl.Play();
            }
            else
            {
                rfiles = files;
                ListMusic.ItemsSource = null;
                ListMusic.ItemsSource = files;
                MediaEl.Source = new Uri(rfiles[0]);
                MediaEl.Play();
            }

        }

        private void Volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaEl.Volume = (Convert.ToDouble(Volume.Value));
        }

        private void ListMusic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            path = ListMusic.SelectedItem.ToString();
        }

        
    }
}