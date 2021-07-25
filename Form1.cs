using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW_WF_for_23._07._2021
{
    public partial class Form1 : Form
    {
        public Form1()       {
            
            
            InitializeComponent();
            Start();        
            

        }
        private void Start()
        {
            List<FilesFromDesktop> lst = new List<FilesFromDesktop>();

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var dirInfo = new DirectoryInfo(path);

            foreach (var item in dirInfo.GetFiles())
            {
                lst.Add(new FilesFromDesktop(item.Name , item.Length));
            }

            lbxFiles.DataSource = lst;
            lbxFiles.DisplayMember = "Name";
            lbxFiles.ValueMember = "Size";

        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e) 
        {
            tbSize.Text = $"{(sender as ListBox).SelectedValue}";
            string [] FullName = (lbxFiles.SelectedItem as FilesFromDesktop).Name.Split('.');
            string NameWithoutEnd = "";
            for(int i = 0;i < FullName.Length; i++)
            {
                NameWithoutEnd += FullName[i];
            }
            tbName.Text = $"{NameWithoutEnd}";
            tbAfterDot.Text = $"{FullName[FullName.Length-1]}";
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var dirInfo = new DirectoryInfo(path);
            try
            {
                string NewFile = Path.Combine(path, $"{tbCreate.Text}");
                File.Create(NewFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
