using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityLoopNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrtProc_Click(object sender, EventArgs e)
        {
            try
            {

                int counter = 0;
                while (true)
                {
                    tbnum.Text = counter++.ToString();
                    int result = counter * counter;
                    tbsqr.Text = result.ToString();
                    Application.DoEvents();
                }
            }
            catch(OverflowException ofex)
            {
                MessageBox.Show("OverFlow Exception Occured");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught" + ex.Message);
            }
        }
    }
}
