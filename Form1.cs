using Newtonsoft.Json;
using System.Diagnostics;

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
            MessageBox.Show("siema");

            string acces = "4/1AVMBsJgaD0q4caKOS8l7qt_EvIJCHOP30G_US4oczJmYU4mkG5DQ-OiPYLM";
            string redirectUri = "urn:ietf:wg:oauth:2.0:oob";
            string scope = "https://www.googleapis.com/auth/userinfo.profile";
            string clientId = "152825418837-jkqe2pa8s0hj427328rd431sef5781q3.apps.googleusercontent.com";
            string authUrl = $"https://accounts.google.com/o/oauth2/v2/auth?response_type=code&client_id={clientId}&redirect_uri={redirectUri}&scope={scope}&access_type=offline";
            Process.Start(new ProcessStartInfo(authUrl) { UseShellExecute = true });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "EmployeData.txt");
            if (File.Exists(path))
            {
                {
                    string JsonFill = File.ReadAllText(path);
                    var obj = JsonConvert.DeserializeObject<List<EmployeeBase>>(JsonFill, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
                    if (JsonFill.Length > 0)
                    {
                        foreach (var i in obj)
                        {
                            EmployeeBase.AllEmployees.Add(i);
                        }


                    }

                }
            }
        }
    }

}
