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
    public partial class Settings : Form
    {
        Menu uf;
        public int hard;
        public Settings()
        {
            InitializeComponent();
            hard = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uf = new Menu(hard);
            this.Hide();
            uf.ShowDialog();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            hard++;
            if(hard > 4)
            {
                hard -= 4;
            }
            HardCheck();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            hard--;
            if(hard < 1)
            {
                hard += 4;
            }
            HardCheck();
        }
        private void HardCheck()
        {
            if(hard == 1)
            {
                Harder.Text = "Легко";
            }
            if(hard == 2)
            {
                Harder.Text = "Средне";
            }
            if(hard == 3)
            {
                Harder.Text = "Сложно";
            }
            if(hard == 4)
            {
                Harder.Text = "Кошмар!";
            }
        }
    }
}
