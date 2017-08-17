using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Gurmanpreet Kaur
 * Date: 17 aug , 2017
 * StudentID: 300933392
 * Description: This is the SplashForm form 
 * Version 0.1 - Created the SplashForm form and assigned values to its properties 
 */
namespace COMP123_S2017_FinalExam_300933392
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
