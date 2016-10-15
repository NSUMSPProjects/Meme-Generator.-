using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meme_generator_trial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rdButton = radioButton1.Text;
            if (radioButton1.Checked)
                happy();
            else if (radioButton2.Checked)
                sad();
            else if (radioButton3.Checked)
                angry();
            else if (radioButton4.Checked)
                confused();


            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void happy()
        {
            this.Hide();
            HappyForm happyform = new HappyForm();
            happyform.ShowDialog();
        }

        private void sad()
        {
            this.Hide();
            SadForm sadform = new SadForm();
            sadform.ShowDialog();
        }

        private void angry()
        {
            this.Hide();
            AngryForm angryform = new AngryForm();
            angryform.ShowDialog();
        }

        private void confused()
        {
            this.Hide();
            ConfusedForm confusedform = new ConfusedForm();
            confusedform.ShowDialog();
        }


    }
}
