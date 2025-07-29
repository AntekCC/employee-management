using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace management_system
{
    public static class FlowAdd
    {
         
        public static void PanelAdd(FlowLayoutPanel flowLayoutPanelConstruct2)
        {

            FlowLayoutPanel flowLayoutPanel = flowLayoutPanelConstruct2;
            flowLayoutPanel.Controls.Clear();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            foreach (var workerr in EmployeeBase.AllEmployees)
            {
                Panel panel = new Panel();

                panel.Size = new Size(280, 120);
                panel.Margin = new Padding(5);
                panel.BackColor = Color.LightGray;
              
                panel.BorderStyle = BorderStyle.FixedSingle;

                panel.MouseEnter += Panel_MouseEnter; 
                panel.MouseLeave += Panel_MouseLeave;

                Label labelName = new Label();
                labelName.Text = $"{workerr.name.ToUpper()} {workerr.surname.ToUpper()}\n{workerr.contract.ContractType()}";

                labelName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                labelName.ForeColor = Color.Black;
                labelName.BackColor = Color.Transparent;
                labelName.AutoSize = false;
                labelName.TextAlign = ContentAlignment.TopLeft;
                labelName.Size = new Size(280, 50);
                labelName.Location = new Point(10, 10);
                labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                labelName.BringToFront();


                Button SalrayButton = new Button();
                SalrayButton.Text = "Wypłata";
                SalrayButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                SalrayButton.ForeColor = Color.Black;
                SalrayButton.FlatStyle = FlatStyle.Flat;
                SalrayButton.FlatAppearance.BorderSize = 0;
                SalrayButton.Size = new Size(90, 30);
                SalrayButton.BackColor = Color.Snow;
                SalrayButton.Location = new Point(10, 65);
                SalrayButton.Click += (sender, e) => MessageBox.Show($"{workerr.GetSalary()}zl");
                
                
                Button ChangeContract = new Button();
                ChangeContract.Text = "Zmien kontrakt";
                ChangeContract.Size = new Size(90, 30);
                SalrayButton.ForeColor = Color.Black;
                SalrayButton.FlatStyle = FlatStyle.Flat;
                SalrayButton.FlatAppearance.BorderSize = 0;
                ChangeContract.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                ChangeContract.Location = new Point(100, 65);
                ChangeContract.BackColor = Color.Snow;

                ChangeContract.Click += (sender, e) =>
                {
                    workerr.ChangeContract();
                    labelName.Text = $"{workerr.name.ToUpper()} {workerr.surname.ToUpper()}\n{workerr.contract.ContractType()}";
                };
                Button DeleteButton = new Button() { Text = "X" };
                DeleteButton.Location = new Point(240,0);
                DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                DeleteButton.Size = new Size(35, 30);
                DeleteButton.FlatStyle = FlatStyle.Flat;
                DeleteButton.BackColor = Color.LightCoral;
                DeleteButton.ForeColor = Color.White;
                DeleteButton.FlatAppearance.BorderSize = 0;
                DeleteButton.Click += (sender, e) =>
                {
                    var btn =  sender as Button;
                    if (panel.Contains(btn))
                    {
                        flowLayoutPanel.Controls.Remove(panel);
                        EmployeeBase.AllEmployees.Remove(workerr);
                    }
                };

                //
                panel.Controls.Add(DeleteButton);
                panel.Controls.Add(ChangeContract);
                panel.Controls.Add(SalrayButton);
                panel.Controls.Add(labelName);
                flowLayoutPanel.Controls.Add(panel);
            }
            

        }

        private static void CurrentDomain_ProcessExit(object? sender, EventArgs e)
        {
          
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "EmployeData.txt");
            string JsonFile = JsonConvert.SerializeObject(EmployeeBase.AllEmployees, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto});
            if (File.Exists(path))
            {
                File.WriteAllText(path, JsonFile);
            }
        }
        

        private static void Panel_MouseLeave(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.LightGray;
        }

        private static void Panel_MouseEnter(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.Gray;
        }
    }
}
