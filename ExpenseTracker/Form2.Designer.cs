namespace ExpenseTracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnBudget = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pnTransactions = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnReports = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customButton1 = new CustomControls.Custom.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.pnBudget.SuspendLayout();
            this.pnTransactions.SuspendLayout();
            this.pnReports.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXPENSE TRACKER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(57, 50);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnBudget);
            this.sidebar.Controls.Add(this.pnTransactions);
            this.sidebar.Controls.Add(this.pnReports);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(281, 611);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.button1);
            this.pnDashboard.Location = new System.Drawing.Point(3, 43);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pnDashboard.Size = new System.Drawing.Size(281, 77);
            this.pnDashboard.TabIndex = 3;
            this.pnDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-26, -8);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(335, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "           Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnBudget
            // 
            this.pnBudget.Controls.Add(this.button4);
            this.pnBudget.Location = new System.Drawing.Point(3, 126);
            this.pnBudget.Name = "pnBudget";
            this.pnBudget.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pnBudget.Size = new System.Drawing.Size(281, 77);
            this.pnBudget.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-21, -9);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(342, 100);
            this.button4.TabIndex = 2;
            this.button4.Text = "           Budget Goals";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnTransactions
            // 
            this.pnTransactions.Controls.Add(this.button2);
            this.pnTransactions.Location = new System.Drawing.Point(3, 209);
            this.pnTransactions.Name = "pnTransactions";
            this.pnTransactions.Size = new System.Drawing.Size(281, 77);
            this.pnTransactions.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-26, -38);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(347, 157);
            this.button2.TabIndex = 2;
            this.button2.Text = "           Transactions";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnReports
            // 
            this.pnReports.Controls.Add(this.button3);
            this.pnReports.Location = new System.Drawing.Point(3, 292);
            this.pnReports.Name = "pnReports";
            this.pnReports.Size = new System.Drawing.Size(281, 77);
            this.pnReports.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-26, -39);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(343, 157);
            this.button3.TabIndex = 2;
            this.button3.Text = "           Reports";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.button5);
            this.pnSettings.Location = new System.Drawing.Point(3, 375);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(281, 77);
            this.pnSettings.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-26, -39);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(343, 157);
            this.button5.TabIndex = 2;
            this.button5.Text = "           Settings";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(346, 153);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(120, 52);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.pnBudget.ResumeLayout(false);
            this.pnTransactions.ResumeLayout(false);
            this.pnReports.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Panel pnTransactions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnReports;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnBudget;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.Custom.CustomButton customButton1;
    }
}