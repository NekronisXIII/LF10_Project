using LF10_Project.MVVM.Services.Interfaces;
using LF10_Project.MVVM.ViewModels;
using LF10_Project.Resources.Utils;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LF10_Project.MVVM.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            DataContext = App.Instance.ServiceProvider.GetRequiredService<MainWindowViewModel>();
            InitializeComponent();

        }


    }
}