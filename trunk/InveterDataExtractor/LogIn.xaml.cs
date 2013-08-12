using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace InveterDataExtractor
{
    /// <summary>
    /// Interaction logic for LogInPromtWindow.xaml
    /// </summary>
    public partial class LogInPromtWindow : Window
    {
        private FileStream fs;

        private const string FileName = "ExtractorLogin.np";

        private readonly string _filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                            FileName);


        public LogInPromtWindow()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }



            InitializeComponent();
            this.Topmost = true;







        }

        
    }
}
