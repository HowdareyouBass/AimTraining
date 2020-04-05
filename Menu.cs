using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Menu : Form
    {
        int harder;
        Form1 f;
        Tutorial m;
        Settings c = new Settings();
        public Menu(int hard)
        {
            InitializeComponent();
            harder = hard;
        }

        private void Menu_Load(object sender, EventArgs e)
        {       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form1(harder);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Close();
            f.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            m = new Tutorial();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}
