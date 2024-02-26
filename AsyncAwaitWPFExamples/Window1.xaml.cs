using System;
using System.Collections.Generic;
using System.IO;
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

namespace AsyncAwaitWPFExamples
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        async void Method()
        {
            await Task.Run(() =>
            {
                while (File.Exists(@"C:\Users\Vadim.Nacharov\Desktop\testdoc.txt"))
                {
                    Task.Delay(500);
                }
                this.Close();
            });

        }
        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Method();   
        }
    }
}
