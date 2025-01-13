using System.Configuration;
using System.Data;
using System.Windows;

namespace Wpf_MVVM_practice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow main = new();
            main.ShowDialog(); //그냥 Show와의 차이점 궁금
        }
    }

}
