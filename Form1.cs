using System.Windows.Forms.Integration;

namespace WF_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ElementHost elementHost = new ElementHost();
            WpfControlLibrary1.UserControl1 wpfControl = new WpfControlLibrary1.UserControl1();
            elementHost.Child = wpfControl;
            elementHost.Dock = DockStyle.Fill;

            Controls.Add(elementHost);
        }
    }
}