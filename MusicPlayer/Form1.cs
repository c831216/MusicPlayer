using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Player.settings.volume = (Player.settings.volume + 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Player.settings.volume = Player.settings.volume - 10;
        }
    }
}
