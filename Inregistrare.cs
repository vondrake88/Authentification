using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWproject
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

       

        private void BtnInregistrare_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnLogare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var otherform = new Logare();
            otherform.Closed += (s, args) => this.Close();
            otherform.Show();
        }
    }
}
