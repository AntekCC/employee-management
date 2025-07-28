using System.Windows.Forms;

namespace management_system
{
    public partial class Form1 : Form
    {
        UserControl1 userControl1;
        public bool Positon = true;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl1 = new UserControl1(Positon, flowLayoutPanel1);
            userControl1.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl1);
        }
    }

}
