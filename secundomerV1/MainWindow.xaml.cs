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

        private int blocker = 0;

        private bool reseter = false;

        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Сode maker is @haha4un©");

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            reseter = false;
            counter = 1;
            start = true;
            blocker = 1;
            if (blocker == 1)
            {
                counter += 0;
                Secundomer();
            }

        }

        private async Task Secundomer()
        {
            while (counter == 1)
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
                if (hour == 59 & minute == 59 & secunds == 59)
                {
                    break;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reseter = true;
            reset();
        }

        private void reset()
        {
            if (reseter == true)
            {
                hour = 0;
                minute = 0;
                secunds = 0;

                s.Text = secunds.ToString();
                m.Text = minute.ToString();
                h.Text = hour.ToString();
            }
            else
            {
                counter = 0;
                counter = 1;
                Secundomer();               
            }
        }
    }
}