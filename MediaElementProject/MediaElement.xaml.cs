using System.Windows;
using System;
using System.Windows.Input;
/// <summary>
/// Krzysztof Szczurowski
/// BCIT: WPF COMP 3608
/// Repo address: https://github.com/kriss3/BCIT_WPF_COMP3608_Week3Lab4_MediaElement.git
/// </summary>
namespace MediaElementProject
{
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
                _myVideo = "Resources/toy_plane_liftoff.avi";    
                Uri src = new Uri("Resources/toy_plane_liftoff.avi", UriKind.Relative);                
                MyMediaElement.Source = src;               
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
