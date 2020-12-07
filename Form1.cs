using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void changeLabelColor()
        {
            Random rnd = new Random();
            this.label1.ForeColor = Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void majtas_Click(object sender, EventArgs e)
        {
            int speed = 0;
            try
            {
                 speed = int.Parse(this.textBox1.Text);
                this.label1.Left = this.label1.Left - speed;
                changeLabelColor();

            }
            catch(Exception)
            {
                label1.Text = "O vella vendos nje numer tek textfield-i";
            }
            
            
        }

        private void djathtas_Click(object sender, EventArgs e)
        {
            int speed = 0;
            try
            {
                speed = int.Parse(this.textBox1.Text);
                this.label1.Left = this.label1.Left + speed;
                changeLabelColor();

            }
            catch (Exception)
            {
                label1.Text = "O vella vendos nje numer tek textfield-i";
            }

        }

        private void lart_Click(object sender, EventArgs e)
        {
            int speed = 0;
            try
            {
                speed = int.Parse(this.textBox1.Text);
                this.label1.Top = this.label1.Top - speed;
                changeLabelColor();

            }
            catch (Exception)
            {
                label1.Text = "O vella vendos nje numer tek textfield-i";
            }

        }

        private void poshte_Click(object sender, EventArgs e)
        {
            int speed = 0;
            try
            {
                speed = int.Parse(this.textBox1.Text);
                this.label1.Top = this.label1.Top + speed;
                changeLabelColor();

            }
            catch (Exception)
            {
                label1.Text = "O vella vendos nje numer tek textfield-i";
            }
        }
    }
}
