
namespace HomeW_Ado.NET_for_14._07._2021
{
    partial class Form1
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbxDB = new System.Windows.Forms.ListBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(38, 21);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(235, 55);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(38, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(235, 55);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(38, 188);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(235, 55);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(35, 243);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(238, 100);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbxDB
            // 
            this.lbxDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDB.FormattingEnabled = true;
            this.lbxDB.ItemHeight = 29;
            this.lbxDB.Location = new System.Drawing.Point(461, 21);
            this.lbxDB.Name = "lbxDB";
            this.lbxDB.Size = new System.Drawing.Size(228, 207);
            this.lbxDB.TabIndex = 4;
            // 
            // tbDBName
            // 
            this.tbDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDBName.Location = new System.Drawing.Point(461, 243);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(227, 41);
            this.tbDBName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(461, 303);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(228, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "  Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxTables
            // 
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.ItemHeight = 16;
            this.lbxTables.Location = new System.Drawing.Point(35, 363);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(307, 84);
            this.lbxTables.TabIndex = 7;
            this.lbxTables.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.lbxTables);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.lbxDB);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAddress);
            this.Name = "Form1";
            this.Text = "Ado.Net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lbxDB;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxTables;
    }
}

