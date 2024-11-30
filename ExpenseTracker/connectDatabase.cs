using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class connectDatabase : Form
    {
        public connectDatabase()
        {
            InitializeComponent();
        }

        private void connectDatabase_Load(object sender, EventArgs e)
        {
            // Enable custom form shape
            this.FormBorderStyle = FormBorderStyle.None;

            // Create rounded rectangle path
            int radius = 30; // Adjust radius size as needed
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Apply the rounded shape to form
            this.Region = new Region(path);
        }
    }
}
