using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksamensProjekt
{
   public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    string presetTypes = "Anyfile|*.*|PDF|*.PDF|Word|*.doc*|Tekst|*.txt|Zip|*.zip|Powerpoint|*.ppt*|Excel|*.xls*";
    bool custom = false;
    OpenFileDialog ofd = new OpenFileDialog();

    private void Form1_Load(object sender, EventArgs e)
    {

    }

   

    private void button1_Click(object sender, EventArgs e)
    {
        if (custom == true && textBox1.Text != "")
        {
            if (textBox1.Text.Contains("."))
            {
                ofd.Filter = presetTypes + "|custom|*" + textBox1.Text;
            }
            else
            {
                ofd.Filter = presetTypes + "|custom|*." + textBox1.Text;
            }
        }
        else
        {
            ofd.Filter = presetTypes;
        }
        ofd.ShowDialog();
    }

   

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;
                custom = true;
            }
            else
            {
                textBox1.Visible = false;
                custom = false;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

