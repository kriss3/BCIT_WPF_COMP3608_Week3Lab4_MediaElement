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
           MyMediaElement.Play();
        }

       
    }
}
