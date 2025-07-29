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
            MessageBox.Show("Zliczono: " + employeeBase.AllEmployees.Count);
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            foreach (var workerr in employeeBase.AllEmployees)
            {
                Panel panel = new Panel();

                panel.Size = new Size(280, 110);
                panel.Margin = new Padding(5);
                panel.BackColor = Color.White;
                panel.MouseEnter += Panel_MouseEnter;
                panel.MouseLeave += Panel_MouseLeave;

                Label labelName = new Label();
                labelName.Text = $"{workerr.name.ToUpper()} {workerr.surname.ToUpper()}\n{workerr.contract.ContractType()}";

                labelName.Font = new Font("Arial", 5, FontStyle.Bold);
                labelName.ForeColor = Color.Black;
                labelName.BackColor = Color.Transparent;
                labelName.AutoSize = false;
                labelName.TextAlign = ContentAlignment.TopLeft;
                labelName.Size = new Size(280, 50);
                labelName.Location = new Point(10, 10);
                labelName.BringToFront();

                Button SalrayButton = new Button();
                SalrayButton.Text = "Wypłata";
                SalrayButton.Size = new Size(90, 30);
                SalrayButton.Location = new Point(10, 65);
                SalrayButton.Click += (sender, e) => MessageBox.Show($"{workerr.contract.Salary()}zl");
                Button ChangeContract = new Button();
                ChangeContract.Text = "Zmien kontrakt";
                ChangeContract.Size = new Size(90, 30);
                ChangeContract.Location = new Point(100, 65);
                ChangeContract.Click += (sender, e) =>
                {
                    if (workerr.contract is InternContract)
                    {
                        workerr.contract = new FullTimeContract();

                    }
                    else
                    {
                        workerr.contract = new InternContract();
                    }
                    workerr.contract.ContractType();
                    workerr.contract.Salary();
                    labelName.Text = $"{workerr.name.ToUpper()} {workerr.surname.ToUpper()}\n{workerr.contract.ContractType()}";

                };
                Button DeleteButton = new Button() { Text = "X" };
                DeleteButton.Location = new Point(240,0);
                DeleteButton.Size = new Size(35, 30);
                DeleteButton.FlatStyle = FlatStyle.Flat;
                DeleteButton.FlatAppearance.BorderSize = 0;
                DeleteButton.Click += (sender, e) =>
                {
                    var btn =  sender as Button;
                    if (panel.Contains(btn))
                    {
                        flowLayoutPanel.Controls.Remove(panel);
                        employeeBase.AllEmployees.Remove(workerr);
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
            string JsonFile = JsonConvert.SerializeObject(employeeBase.AllEmployees);
            if (!File.Exists(path))
            {
                File.WriteAllText(path, JsonFile);
            }
        }
        

        private static void Panel_MouseLeave(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.White;
        }

        private static void Panel_MouseEnter(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.LightGray;
        }
    }
}
