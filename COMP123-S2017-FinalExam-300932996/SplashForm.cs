using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300932996
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            FormTimer.Tick += new EventHandler(FormTimer_Tick);
            PickHighestCardForm  PickCard = new PickHighestCardForm();
            PickCard.Show();
            this.Hide();
            FormTimer.Enabled = false;
        }

        private void WelcomeText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
