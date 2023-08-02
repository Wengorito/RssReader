using RssReader.ViewModel;
using System.Windows;

namespace RssReader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DependencyInjector.Register<IRssHelper, FakeRssHelper>();
            MainWindow = DependencyInjector.Retrieve<MainWindow>();
            MainWindow.Show();
        }
    }
}
