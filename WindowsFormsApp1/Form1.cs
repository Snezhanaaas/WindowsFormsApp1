using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int _FrameIndex;
        public Form1()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello world");
            ButtonTimer.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 10;
            if (button1.Left > Width)
                button1.Left = 0;
            _FrameIndex++;
            Text = "Frame#" + _FrameIndex;
        }
    }
}
