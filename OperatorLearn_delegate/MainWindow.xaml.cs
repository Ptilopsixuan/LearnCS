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

namespace OperatorLearn_delegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.btnHello.Click += btnHello_Click;
            //
            this.btnHello.Click += delegate (object sender, RoutedEventArgs e)  //匿名方法，等效于被注释部分
            {
                tbHello.Text = "Hello World!";
            };
            //
            this.btnHello.Click += (sender, e) =>                               //Lambda表达式方法，等效于被注释的下面的部分
            {
                tbHello.Text = "Hello World!";
            };
        }

        //private void btnHello_Click(object sender, RoutedEventArgs e)
        //{
        //    tbHello.Text = "Hello World!";
        //}
    }
}