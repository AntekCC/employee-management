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
    public partial class Overtime : UserControl
    {
        public int _overtime { get; set; }
        public int Result;
        public Overtime()
        {
            InitializeComponent();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int result);
            _overtime = result;
        }
    }
}
