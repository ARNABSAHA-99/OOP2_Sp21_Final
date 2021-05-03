
namespace Modern_Medical_Management_System
{
    partial class ShowPatient
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
            this.dtShowPatient = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dtShowPatient
            // 
            this.dtShowPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtShowPatient.GridColor = System.Drawing.SystemColors.Desktop;
            this.dtShowPatient.Location = new System.Drawing.Point(12, 87);
            this.dtShowPatient.Name = "dtShowPatient";
            this.dtShowPatient.RowHeadersWidth = 51;
            this.dtShowPatient.RowTemplate.Height = 24;
            this.dtShowPatient.Size = new System.Drawing.Size(776, 226);
            this.dtShowPatient.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(312, 330);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 68);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show All Information of Patients";
            // 
            // ShowPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtShowPatient);
            this.Name = "ShowPatient";
            this.Text = "ShowInfo";
            this.Load += new System.EventHandler(this.ShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtShowPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtShowPatient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}