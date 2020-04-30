/*Измените существующий проект данного урока 003_MVP, расширив его добавлением методов доступа add и remove к событию. */
using System.Windows;

namespace Addition_task
{
    public delegate void EventDelegate(object sender, RoutedEventArgs e);

    public partial class MainWindow : Window
    {
        EventDelegate eventDelegate = null;

        public event EventDelegate myEvent
        {
            add { eventDelegate += value; }
            remove { eventDelegate -= value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eventDelegate(sender, e);
        }
    }
}
