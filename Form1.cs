using Newtonsoft.Json;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "EmployeData.txt");
            if (File.Exists(path)) { 
                { 
                    string JsonFill = File.ReadAllText(path);
                    var obj = JsonConvert.DeserializeObject<List<employeeBase>>(JsonFill,new JsonSerializerSettings() {TypeNameHandling = TypeNameHandling.Auto });
                    if (JsonFill.Length > 0) {
                        foreach (var i in obj)
                        {
                            employeeBase.AllEmployees.Add(i);
                        }
                        
                        
                    }
                    
                }
            }
        }
    }

}
