using System.Timers;

namespace management_system
{
    public partial class UserControl1 : UserControl
    {

        bool postion;
        FlowLayoutPanel FlowLayoutPanel1;
        int OVTconstrutor;
        EmployeeBase worker;
        Overtime overtime;
        public UserControl1(bool constructor, FlowLayoutPanel flowLayoutPanelConstructor)
        {

            postion = constructor;
            InitializeComponent();
            textBox1.KeyPress += NameValidation;
            textBox2.KeyPress += NameValidation;
            this.radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            this.radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            overtime = new Overtime();
            overtime.Dock = DockStyle.Fill;
            panel1.Controls.Add(overtime);
            overtime.Visible = false;

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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                overtime.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                overtime.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool intern = true;
            worker = new EmployeeBase(textBox1.Text, textBox2.Text);
            if (radioButton1.Checked)
            {
                worker.contract = new InternContract();
            }
            else if (radioButton2.Checked)
            {
                int overtimeValue = overtime._overtime;  
                worker.contract = new FullTimeContract(overtimeValue);
              
            }
            else
            {
                worker.contract = new InternContract();

            }
            worker.contract.ContractType();
            EmployeeBase.AllEmployees.Add(worker);
            FlowAdd.PanelAdd(FlowLayoutPanel1);
        }
    }
}
