using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_and_progs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Notepad: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Calculator: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Paint: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string customProgramPath = @"F:\\Progs\\Sublime Text\\sublime_text.exe";
                Process.Start(customProgramPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching SublimeText: " + ex.Message);
            }
        }
    }
}
