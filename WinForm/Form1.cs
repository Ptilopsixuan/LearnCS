using ClassLibrary;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MyClass myClass = new MyClass();
            string message = myClass.MyMethod();
            tbSayHello.Text = "Hello, World!" + message;
        }
    }
}
