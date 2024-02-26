using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncAwaitWPFExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        async void Method()
        {
            await Task.Run(() =>
            {
                while (File.Exists(@"C:\Users\Vadim.Nacharov\Desktop\testdoc.txt"))
                {
                    Task.Delay(5);
                    pb1.Value++;
                }
              
            });
            
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {  
            Method();
            int a = 0;
            while(a < 10)
            {
                a++;
                await Task.Delay(500);
                lbl1.Content = a.ToString();
            }        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();  
        }
    }
}
