namespace Addition_task
{
    class Presenter
    {
        Model _model;
        MainWindow _mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            _model = new Model();
            _mainWindow = mainWindow;
            _mainWindow.myEvent += mainWindow_myEvent;
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            _mainWindow.textBox1.Text = _model.Logic(_mainWindow.textBox1.Text);
        }
    }
}
