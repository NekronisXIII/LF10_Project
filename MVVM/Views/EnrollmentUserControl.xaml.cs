using LF10_Project.MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class EnrollmentUserControl : UserControl
    {
        public EnrollmentUserControl()
        {
            DataContext = App.Instance.ServiceProvider.GetRequiredService<TeacherListViewModel>();
            InitializeComponent();

            SetupControls();
		}

        private void SetupControls()
        {
			var documentBytes = Encoding.UTF8.GetBytes(Properties.Resources.Enrollment);
			using (var reader = new MemoryStream(documentBytes))
			{
				enrollmentRichTextBox.Selection.Load(reader, DataFormats.Rtf);
				enrollmentRichTextBox.CaretPosition = enrollmentRichTextBox.Document.ContentStart;
				enrollmentRichTextBox.ScrollToHome();
			}
		}
    }
}
