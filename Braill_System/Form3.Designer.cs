namespace Braill_System
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.btncon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbraill = new System.Windows.Forms.Label();
            this.lblNdot = new System.Windows.Forms.Label();
            this.lbldot = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.btntext = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AnticFont", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Braill Calculator";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(34, 155);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(43, 17);
            this.lblT.TabIndex = 5;
            this.lblT.Text = "Text :";
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(83, 152);
            this.txtT.MinimumSize = new System.Drawing.Size(0, 177);
            this.txtT.Multiline = true;
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(294, 177);
            this.txtT.TabIndex = 11;
            this.txtT.TextChanged += new System.EventHandler(this.txtT_TextChanged);
            // 
            // btncon
            // 
            this.btncon.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.Location = new System.Drawing.Point(393, 199);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(122, 63);
            this.btncon.TabIndex = 14;
            this.btncon.Text = "Convert";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblbraill);
            this.panel1.Location = new System.Drawing.Point(531, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 177);
            this.panel1.TabIndex = 15;
            // 
            // lblbraill
            // 
            this.lblbraill.AutoSize = true;
            this.lblbraill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbraill.Location = new System.Drawing.Point(3, 13);
            this.lblbraill.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblbraill.Name = "lblbraill";
            this.lblbraill.Size = new System.Drawing.Size(47, 24);
            this.lblbraill.TabIndex = 8;
            this.lblbraill.Text = "Text";
            // 
            // lblNdot
            // 
            this.lblNdot.AutoSize = true;
            this.lblNdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdot.Location = new System.Drawing.Point(370, 381);
            this.lblNdot.Name = "lblNdot";
            this.lblNdot.Size = new System.Drawing.Size(81, 17);
            this.lblNdot.TabIndex = 17;
            this.lblNdot.Text = "No of dots :";
            // 
            // lbldot
            // 
            this.lbldot.AutoSize = true;
            this.lbldot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldot.Location = new System.Drawing.Point(457, 381);
            this.lbldot.Name = "lbldot";
            this.lbldot.Size = new System.Drawing.Size(39, 17);
            this.lbldot.TabIndex = 18;
            this.lbldot.Text = "dots ";
            // 
            // btncal
            // 
            this.btncal.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(718, 335);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(122, 63);
            this.btncal.TabIndex = 19;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btntext
            // 
            this.btntext.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntext.Location = new System.Drawing.Point(101, -3);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(110, 34);
            this.btntext.TabIndex = 22;
            this.btntext.Text = "Shapes";
            this.btntext.UseVisualStyleBackColor = true;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(-4, -3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(110, 34);
            this.btnhome.TabIndex = 21;
            this.btnhome.Text = "<<Back";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btntext);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.lbldot);
            this.Controls.Add(this.lblNdot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbraill;
        private System.Windows.Forms.Label lblNdot;
        private System.Windows.Forms.Label lbldot;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btntext;
        private System.Windows.Forms.Button btnhome;
    }
}