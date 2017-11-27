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

        public MediaElement()
        {
            InitializeComponent();
            playBtn.Click += PlayBtn_Click;
            stopBtn.Click += StopBtn_Click;
            stopBtn.PreviewMouseDown += StopBtn_PreviewMouseDown;
            pauseBtn.Click += PauseBtn_Click;
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
    }
}
