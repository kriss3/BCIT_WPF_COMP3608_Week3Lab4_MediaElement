using System.Windows;
using System;
using System.Windows.Input;

namespace MediaElementProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MediaElement : Window
    {
        private bool _isPaused = true;
        private string _myVideo = "Resources/Running.avi";

        public MediaElement()
        {
            InitializeComponent();
            playBtn.Click += PlayBtn_Click;
            stopBtn.Click += StopBtn_Click;
            stopBtn.PreviewMouseDown += StopBtn_PreviewMouseDown;
            pauseBtn.Click += PauseBtn_Click;
            toggleBtn.Click += ToggleBtn_Click;
        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            _isPaused = false;
            MyMediaElement.Play();
        }

        private void StopBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MyMediaElement.Position = new TimeSpan(0);
        }
        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Stop();
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_isPaused == true)
            {
                _isPaused = false;
                MyMediaElement.Play();
            }
            else
            {
                _isPaused = true;
                MyMediaElement.Pause();
            }
            MyMediaElement.Pause();
        }

        private void ToggleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_myVideo == "Resources/Running.avi")
            {
                //set _vdieoVar to the next video              
                _myVideo = "Resources/toy_plane_liftoff.avi";
                // create a var called src of the type Uri              
                // set the source of the Uri to the new video              
                // inform it that the Uri is a Relative path             
                Uri src = new Uri("Resources/toy_plane_liftoff.avi", UriKind.Relative);
                // set MyMediaElement's Source                  
                MyMediaElement.Source = src;
                // Tell the MediaElement to play                 
                MyMediaElement.Play();
            }
            else
            {
                _myVideo = "Resources/Running.avi";
                Uri src = new Uri("Resources/Running.avi", UriKind.Relative);
                MyMediaElement.Source = src;
                MyMediaElement.Play();
            }
        }

    }
}
