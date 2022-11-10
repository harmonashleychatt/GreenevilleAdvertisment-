using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisment
{
    public partial class Form1 : Form
    {
        public bool Checked { get; private set; }
        public string Message { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_fee_CheckChanged(object sender, EventArgs e)
        {
            string fees = "Adults ages 18 & + \n Teens ages 13 - 17 \n Children ages 12 & under";
            if (checkBox_fee.Checked == true)
            {
                MessageBox.Show(fees);
                checkBox_age.Enabled = false;
                checkBox_talent.Enabled = false;
            }
            else
            {
                checkBox_talent.Enabled = true;
                checkBox_age.Enabled = true;
            }

        }



    private void checkBox_talent_CheckChanged(object sender, EventArgs e)
        {
            string talents = "Talent Categories:\n>>Singing,\n>>Dancing,\n>>Musical Instrument,\n>>Other";
           if (checkBox_talent.Checked == true)
            {
                MessageBox.Show(talents);
                checkBox_age.Enabled = false;
                checkBox_fee.Enabled = false;
            }
            else
            {
                checkBox_fee.Enabled = true;
                checkBox_age.Enabled = true;
            }
            // adult fee 30 age 18 +, teen 20 age 13 - 17 child 15 age 12 and under

        }

        private void checkBox_age_CheckedChanged(object sender, EventArgs e)
        {
            string ages = "Talent Age Groups:\n>>Adults ages 18 & + \n>>Teens ages 13 - 17 \n>>Children ages 12 & under";
            if (checkBox_age.Checked == true)
            {
                MessageBox.Show(ages);
                checkBox_fee.Enabled = false;
                checkBox_talent.Enabled = false;
            }
            else
            {
                checkBox_fee.Enabled = true;
                checkBox_talent.Enabled = true;
            }
        }

        private void idk_KeyPress(object sender, KeyPressEventArgs e)
        { // by pressing the enter key the check boxes will be deselected 

            
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkBox_age.Checked = false;
                checkBox_fee.Checked = false;
                checkBox_talent.Checked = false; 
            }
        }

    }
}
