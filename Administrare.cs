using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWproject
{
    public partial class Administrare : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmbl;


        public Administrare()
        {
            InitializeComponent();
        }

        private void Administrare_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-HB9T9G5\SQLEXPRESS;Initial Catalog=authentification;Integrated Security=True";
                con.Open();
                // TODO: This line of code loads data into the 'authentificationDataSet.USERS' table. You can move, or remove it, as needed.
              
               
                adap = new SqlDataAdapter(@"Select  ID as 'ID',email,password,lastlogin,idrole,logincount,username FROM USERS", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "USERS");
                GridAdministrare.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmbl = new SqlCommandBuilder(adap);
                adap.Update(ds, "USERS");
                MessageBox.Show("Date actualizate!", "Update",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
    }
}
