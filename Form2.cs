using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_system
{
    public partial class Form2 : Form
    {
        public EmployeeBase _employee;
        Overtime Extra;

        public Form2(EmployeeBase employee)
        {
            InitializeComponent();
            _employee = employee;
            Extra = new Overtime();
            panel1.Controls.Add(Extra);
            Extra.Dock = DockStyle.Fill;
            Extra.Visible = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                _employee.ChangeContract(new InternContract());
            }
            else if (radioButton2.Checked)
            {

                int overtimeValue = Extra._overtime;
                _employee.ChangeContract(new FullTimeContract(overtimeValue));
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Extra.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                Extra.Visible = true;
            }
        }
    }
}
