using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form2 : Form
    {
        formDashboard dashboard;
        formTransaction transaction;
        formReports reports;
        formBudget budget;
        formSettings settings;

        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //this.FormBorderStyle = FormBorderStyle.None; // Remove default border
            //this.DoubleBuffered = true;                 // Reduce flickers
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    int borderRadius = 35; // Adjust the radius for rounding
        //    Graphics g = e.Graphics;

        //    // Enable smoothing for better rounded edges
        //    g.SmoothingMode = SmoothingMode.AntiAlias;

        //    // Create a rounded rectangle path
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        //    path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        //    path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        //    path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        //    path.CloseFigure();

        //    // Set the form's region to the rounded rectangle
        //    this.Region = new Region(path);

        //    // Optional: Draw a border
        //    using (Pen borderPen = new Pen(Color.Black, 2)) // Adjust border color and width
        //    {
        //        g.DrawPath(borderPen, path);
        //    }
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
                dashboard.Dock = DockStyle.Fill;
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new formSettings();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Show();
                settings.Dock = DockStyle.Fill;
            }
            else
            {
                settings.Activate();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 62)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnBudget.Width = sidebar.Width;
                    pnTransactions.Width = sidebar.Width;
                    pnReports.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 292)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnBudget.Width = sidebar.Width;
                    pnTransactions.Width = sidebar.Width;
                    pnReports.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (budget == null)
            {
                budget = new formBudget();
                budget.FormClosed += Budget_FormClosed;
                budget.MdiParent = this;
                budget.Show();
                budget.Dock = DockStyle.Fill;
            }
            else
            {
                budget.Activate();
            }
        }

        private void Budget_FormClosed(object sender, FormClosedEventArgs e)
        {
            budget = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (transaction == null)
            {
                transaction = new formTransaction();
                transaction.FormClosed += Transaction_FormClosed;
                transaction.MdiParent = this;
                transaction.Show();
                transaction.Dock = DockStyle.Fill;
            }
            else
            {
                transaction.Activate();
            }
        }

        private void Transaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            transaction = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reports == null)
            {
                reports = new formReports();
                reports.FormClosed += Reports_FormClosed;
                reports.MdiParent = this;
                reports.Show();
                reports.Dock = DockStyle.Fill;
            }
            else
            {
                reports.Activate();
            }
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            reports = null;
        }
    }
}