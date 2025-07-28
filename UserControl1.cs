using System.Timers;

namespace management_system
{
    public partial class UserControl1 : UserControl
    {
        bool postion;
        FlowLayoutPanel FlowLayoutPanel1;
        public UserControl1(bool constructor, FlowLayoutPanel flowLayoutPanelConstructor)
        {

            postion = constructor;
            InitializeComponent();
            textBox1.KeyPress += NameValidation;
            textBox2.KeyPress += NameValidation;
            FlowLayoutPanel1 = flowLayoutPanelConstructor;
        }

        private void NameValidation(object? sender, KeyPressEventArgs e)
        {
            Control control = sender as Control;
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool intern = true;
            employeeBase worker = new employeeBase();
            worker.name = textBox1.Text;
            worker.surname = textBox2.Text;
            if (radioButton1.Checked)
            {
                worker.contract = new InternContract();
            }
            else if(radioButton2.Checked)
            {
                worker.contract = new FullTimeContract();
            }
            else  {
                worker.contract = new InternContract();

            }
            worker.contract.ContractType();
            employeeBase.AllEmployees.Add(worker);
            FlowAdd.PanelAdd(FlowLayoutPanel1);
        }
    }
}
