using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHexa
{
    public partial class FormHexa : Form
    {
        public FormHexa()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            tbRed.Text = trackBarRed.Value.ToString();
            setColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            tbGreen.Text = trackBarGreen.Value.ToString();
            setColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            tbBlue.Text = trackBarBlue.Value.ToString();
            setColor();
        }
        private void setColor()
        {
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            lbColor.BackColor = color;
        }

        private void FormHexa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Vient de la classe : " + Hexagone.HexagonNumber.ToString());
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings["HexagonSize"] ?? "Not found";
            MessageBox.Show("Vient de app config : " + result);
        }
    }
}
