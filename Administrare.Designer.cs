
namespace PAWproject
{
    partial class Administrare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GridAdministrare = new System.Windows.Forms.DataGridView();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authentificationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            this.label1 = new System.Windows.Forms.Label();
           
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.uSERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logincountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdministrare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authentificationDataSetBindingSource)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAdministrare
            // 
            this.GridAdministrare.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridAdministrare.AllowUserToAddRows = false;
            this.GridAdministrare.AllowUserToDeleteRows = false;
            this.GridAdministrare.AllowUserToResizeRows = false;
            this.GridAdministrare.AutoGenerateColumns = false;
            this.GridAdministrare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdministrare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.lastloginDataGridViewTextBoxColumn,
            this.idroleDataGridViewTextBoxColumn,
            this.logincountDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.GridAdministrare.DataSource = this.uSERSBindingSource1;
            this.GridAdministrare.Location = new System.Drawing.Point(0, 122);
            this.GridAdministrare.MultiSelect = false;
            this.GridAdministrare.Name = "GridAdministrare";
            this.GridAdministrare.RowHeadersVisible = false;
            this.GridAdministrare.Size = new System.Drawing.Size(706, 357);
            this.GridAdministrare.TabIndex = 0;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.authentificationDataSetBindingSource;
            // 
            // authentificationDataSetBindingSource
            // 
        
            this.authentificationDataSetBindingSource.Position = 0;
            // 
            // authentificationDataSet
            // 
          
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrare Utilizatori";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uSERSTableAdapter
            // 
      
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Lime;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(559, 491);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(127, 34);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Actualizeaza";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // uSERSBindingSource1
            // 
            this.uSERSBindingSource1.DataMember = "USERS";
            this.uSERSBindingSource1.DataSource = this.authentificationDataSetBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // lastloginDataGridViewTextBoxColumn
            // 
            this.lastloginDataGridViewTextBoxColumn.DataPropertyName = "lastlogin";
            this.lastloginDataGridViewTextBoxColumn.HeaderText = "lastlogin";
            this.lastloginDataGridViewTextBoxColumn.Name = "lastloginDataGridViewTextBoxColumn";
            // 
            // idroleDataGridViewTextBoxColumn
            // 
            this.idroleDataGridViewTextBoxColumn.DataPropertyName = "idrole";
            this.idroleDataGridViewTextBoxColumn.HeaderText = "idrole";
            this.idroleDataGridViewTextBoxColumn.Name = "idroleDataGridViewTextBoxColumn";
            // 
            // logincountDataGridViewTextBoxColumn
            // 
            this.logincountDataGridViewTextBoxColumn.DataPropertyName = "logincount";
            this.logincountDataGridViewTextBoxColumn.HeaderText = "logincount";
            this.logincountDataGridViewTextBoxColumn.Name = "logincountDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // Administrare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 537);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAdministrare);
            this.Name = "Administrare";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Administrare";
            this.Load += new System.EventHandler(this.Administrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdministrare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
          
        
          

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAdministrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource authentificationDataSetBindingSource;

        private System.Windows.Forms.BindingSource uSERSBindingSource;
    
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logincountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uSERSBindingSource1;
    }
}