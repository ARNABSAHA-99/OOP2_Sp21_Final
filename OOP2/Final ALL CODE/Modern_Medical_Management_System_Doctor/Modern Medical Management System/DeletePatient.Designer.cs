﻿
namespace Modern_Medical_Management_System
{
    partial class DeletePatient
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
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.tbDeleteSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.dtDeletePatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtDeletePatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.BackColor = System.Drawing.Color.Red;
            this.btnDeleteInfo.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInfo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInfo.Location = new System.Drawing.Point(288, 245);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(198, 52);
            this.btnDeleteInfo.TabIndex = 0;
            this.btnDeleteInfo.Text = "Delete";
            this.btnDeleteInfo.UseVisualStyleBackColor = false;
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // tbDeleteSearch
            // 
            this.tbDeleteSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeleteSearch.Location = new System.Drawing.Point(274, 87);
            this.tbDeleteSearch.Name = "tbDeleteSearch";
            this.tbDeleteSearch.Size = new System.Drawing.Size(144, 31);
            this.tbDeleteSearch.TabIndex = 1;
            // 
            // btnDeleteSearch
            // 
            this.btnDeleteSearch.BackColor = System.Drawing.Color.Black;
            this.btnDeleteSearch.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSearch.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSearch.Location = new System.Drawing.Point(438, 74);
            this.btnDeleteSearch.Name = "btnDeleteSearch";
            this.btnDeleteSearch.Size = new System.Drawing.Size(198, 52);
            this.btnDeleteSearch.TabIndex = 2;
            this.btnDeleteSearch.Text = "Search";
            this.btnDeleteSearch.UseVisualStyleBackColor = false;
            this.btnDeleteSearch.Click += new System.EventHandler(this.btnDeleteSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(166, 314);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 78);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGo.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(402, 314);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(234, 78);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go to ShowInfo";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dtDeletePatient
            // 
            this.dtDeletePatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDeletePatient.Location = new System.Drawing.Point(63, 142);
            this.dtDeletePatient.Name = "dtDeletePatient";
            this.dtDeletePatient.RowHeadersWidth = 51;
            this.dtDeletePatient.RowTemplate.Height = 24;
            this.dtDeletePatient.Size = new System.Drawing.Size(690, 87);
            this.dtDeletePatient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delete Patient Information";
            // 
            // DeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDeletePatient);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSearch);
            this.Controls.Add(this.tbDeleteSearch);
            this.Controls.Add(this.btnDeleteInfo);
            this.Name = "DeletePatient";
            this.Text = "DeleteInfo";
            this.Load += new System.EventHandler(this.DeleteInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDeletePatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteInfo;
        private System.Windows.Forms.TextBox tbDeleteSearch;
        private System.Windows.Forms.Button btnDeleteSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dtDeletePatient;
        private System.Windows.Forms.Label label1;
    }
}