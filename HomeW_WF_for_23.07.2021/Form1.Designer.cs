
namespace HomeW_WF_for_23._07._2021
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
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAfterDot = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFiles
            // 
            this.lbxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.ItemHeight = 29;
            this.lbxFiles.Location = new System.Drawing.Point(12, 12);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(315, 236);
            this.lbxFiles.TabIndex = 1;
            this.lbxFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFiles_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(391, 12);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(290, 34);
            this.tbName.TabIndex = 2;
            // 
            // tbAfterDot
            // 
            this.tbAfterDot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAfterDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAfterDot.Location = new System.Drawing.Point(391, 72);
            this.tbAfterDot.Name = "tbAfterDot";
            this.tbAfterDot.ReadOnly = true;
            this.tbAfterDot.Size = new System.Drawing.Size(290, 34);
            this.tbAfterDot.TabIndex = 3;
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSize.Location = new System.Drawing.Point(391, 131);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(290, 34);
            this.tbSize.TabIndex = 4;
            // 
            // tbCreate
            // 
            this.tbCreate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCreate.Location = new System.Drawing.Point(12, 292);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Size = new System.Drawing.Size(669, 49);
            this.tbCreate.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(270, 375);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(148, 63);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbCreate);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbAfterDot);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbxFiles);
            this.Name = "Form1";
            this.Text = "Home Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAfterDot;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbCreate;
        private System.Windows.Forms.Button btnCreate;
    }
}

