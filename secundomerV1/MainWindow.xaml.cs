using System.Threading.Tasks;
using System.Windows;

namespace secundomerV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool start = false;
        private bool stop = true;

        private int secunds = 0;
        private int minute = 0;
        private int hour = 0;

        private int counter = 0;


        public MainWindow()
        {
            InitializeComponent();


        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;
            start = true;

            Secundomer();
        }

        private async Task Secundomer()
        {
            while (start = true || counter == 1)
            {
                // deloy
                await Task.Delay(1000);

                // секунды мерит
                secunds += 1;
                s.Text = secunds.ToString();

                // конвертит секунды в минуты
                if (secunds == 60)
                {
                    secunds = 0;
                    minute += 1;
                    m.Text = minute.ToString();

                    // конвертит минуты в часы
                    if (minute == 60)
                    {
                        minute = 0;
                        hour += 1;
                        h.Text = hour.ToString();
                    }
                }
            }
        }
    }
}