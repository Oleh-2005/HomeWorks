using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeW_Ado.NET_for_14._07._2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAddress.Text = "194.44.93.225";
            lblLogin.Text = "test";
            lblPassword.Text = "1";
        }
        bool btnConOk = false;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConOk)
            {
                return;
            }
            using (SqlConnection conection = new SqlConnection(@"Data Source=194.44.93.225;Initial catalog=master;Integrated Security = false;User Id=test; Password=1"))
            {  
                try
                {
                    conection.Open();
                    SqlCommand AllDB = new SqlCommand("select * from sys.databases", conection);
                    SqlDataReader ALLDBRead = AllDB.ExecuteReader();
                    while (ALLDBRead.Read())
                    {
                        lbxDB.Items.Add(ALLDBRead[0]);
                    }
                    conection.Close();

                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            btnConOk = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxTables.Visible = true;
            lbxTables.Items.Clear();
            foreach (var item in lbxDB.Items)
            {
                if((item as string) == tbDBName.Text)
                {
                    using (SqlConnection conection = new SqlConnection(@"Data Source=194.44.93.225;Initial catalog=master;Integrated Security = false;User Id=test; Password=1"))
                    {
                        try
                        {                            
                            conection.Open();
                            SqlCommand AllTables = new SqlCommand($"use {tbDBName.Text} ; ", conection);
                            AllTables.Connection.Open();                            
                            AllTables.ExecuteScalar();
                            AllTables.Connection.Close();
                            SqlCommand ATB = new SqlCommand($"select * from sys.tables;", conection);
                            SqlDataReader ATBRead = ATB.ExecuteReader();                            
                            while (ATBRead.Read())
                            {
                                lbxTables.Items.Add(ATBRead[0]);
                            }
                            conection.Close();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                }
            }
        }
    }
}
