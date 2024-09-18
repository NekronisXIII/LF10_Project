using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LF10_Project.Resources.Utils
{
    public static class WindowManager
    {
        public static bool? ShowDialog<T>(object viewModel) where T : Window
        {
            Window window = ActivatorUtilities.CreateInstance<T>(App.Instance.ServiceProvider, viewModel);
            if(Application.Current.MainWindow.IsActive) window.Owner = Application.Current.MainWindow;
            return window.ShowDialog();
        }

        public static void ShowWindow<T>(object viewModel) where T : Window
        {
            Window window = ActivatorUtilities.CreateInstance<T>(App.Instance.ServiceProvider, viewModel);
            if(Application.Current.MainWindow.IsActive) window.Owner = Application.Current.MainWindow;
            window.Show();
        }

        public static bool? ShowDialog<T>() where T : Window
        {
            var window = App.Instance.ServiceProvider.GetRequiredService<T>();
            if(Application.Current.MainWindow.IsActive) window.Owner = Application.Current.MainWindow;
            return window.ShowDialog();
        }

        public static void ShowWindow<T>() where T : Window
        {
            var window = App.Instance.ServiceProvider.GetRequiredService<T>();
            if(Application.Current.MainWindow.IsActive) window.Owner = Application.Current.MainWindow;
            window.Show();
        }

        public static void CloseWindow<T>(bool dialogResult = true) where T : Window
        {
            foreach (var window in Application.Current.Windows.OfType<T>())
            {
                window.DialogResult = dialogResult;
                window.Close();
            }
        }

        public static void ShowMessageBox(string message, string title, MessageBoxButton buttons = MessageBoxButton.OK)
        {
            MessageBox.Show(message, title, buttons);
        }
    }
}
