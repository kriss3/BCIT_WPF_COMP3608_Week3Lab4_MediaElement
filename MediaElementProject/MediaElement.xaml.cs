using System.Windows;
using System.Windows.Input;

namespace MediaElementProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MediaElement : Window
    {
        public MediaElement()
        {
            InitializeComponent();
            //playBtn.Click += new RoutedEventHandler(playBtn_Click);
           // MyMediaElement.Play();
        }

        void playBtn_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Play();
        }

        private void playBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyMediaElement.Play();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I was clicked","Message from Click Button",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
