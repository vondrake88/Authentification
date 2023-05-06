
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
    public partial class Logare : Form
    {

        public Logare()
        {
            InitializeComponent();
            
        }
        private void Logare_Load(object sender, EventArgs e)
        {
            G.initializare();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (userBox.Text == "")
            {
                MessageBox.Show("Nici un utilizator introdus!");
                return;
            }
            if (passBox.Text == "")
            {
                MessageBox.Show("Nici o parola introdusa!");
                return;
            }

            USERS user = G.context.USERS.Where(u => u.username == userBox.Text && u.password==passBox.Text).FirstOrDefault();

            if (user == null)

            {
                MessageBox.Show("Userul nu a fost gasit in baza de date sau parola este incorecta!");
                
            }
            else
            {
                MessageBox.Show("Te-ai autentificat cu succes!");

                this.Hide();
                var otherform = new Administrare();
                otherform.Closed += (s, args) => this.Close();
                otherform.Show();
              
                
            }
            
            

            
                
            
        }

        private void BtnInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var otherform = new Inregistrare();
            otherform.Closed += (s, args) => this.Close();
            otherform.Show();
        }

        private void ChkArataPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkArataPass.Checked == true)
            {
                passBox.PasswordChar = '\0';
            }
            else
            {
                passBox.PasswordChar = '*';
            }
           
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var otherform = new Administrare();
            otherform.Closed += (s, args) => this.Close();
            otherform.Show();
        }
    }
}
