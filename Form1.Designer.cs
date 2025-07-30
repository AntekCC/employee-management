namespace management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 0;
            button1.Text = "dodaj pracownika";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(152, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 356);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 31);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 310);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(148, 5);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 358);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 358);
            panel4.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(366, 2);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(301, 411);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(361, 10);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 358);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 358);
            panel7.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 414);
            Controls.Add(panel6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Panel panel7;
    }
}
