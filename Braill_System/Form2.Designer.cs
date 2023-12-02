namespace Braill_System
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblshape = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.lblpe = new System.Windows.Forms.Label();
            this.lblval = new System.Windows.Forms.Label();
            this.lblNdot = new System.Windows.Forms.Label();
            this.lbldot = new System.Windows.Forms.Label();
            this.pbraill = new System.Windows.Forms.Panel();
            this.lbldotc = new System.Windows.Forms.Label();
            this.lbldotval = new System.Windows.Forms.Label();
            this.lblBval = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btntext = new System.Windows.Forms.Button();
            this.shapebox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.pbraill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AnticFont", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Braill Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shape :";
            // 
            // lblshape
            // 
            this.lblshape.AutoSize = true;
            this.lblshape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshape.Location = new System.Drawing.Point(666, 149);
            this.lblshape.Name = "lblshape";
            this.lblshape.Size = new System.Drawing.Size(45, 17);
            this.lblshape.TabIndex = 3;
            this.lblshape.Text = "Name";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(603, 192);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(60, 17);
            this.lblL.TabIndex = 4;
            this.lblL.Text = "Length :";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(611, 237);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(52, 17);
            this.lblW.TabIndex = 5;
            this.lblW.Text = "Width :";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(524, 240);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(139, 17);
            this.lblP.TabIndex = 6;
            this.lblP.Text = "Perpendicular hight :";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(603, 192);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(60, 17);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "Radius :";
            // 
            // txtL
            // 
            this.txtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL.Location = new System.Drawing.Point(669, 189);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(132, 23);
            this.txtL.TabIndex = 8;
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(669, 189);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(132, 23);
            this.txtR.TabIndex = 10;
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtW.Location = new System.Drawing.Point(669, 234);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(132, 23);
            this.txtW.TabIndex = 12;
            // 
            // btncal
            // 
            this.btncal.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(750, 443);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(122, 63);
            this.btncal.TabIndex = 13;
            this.btncal.Text = "calculate";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // lblpe
            // 
            this.lblpe.AutoSize = true;
            this.lblpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpe.Location = new System.Drawing.Point(544, 323);
            this.lblpe.Name = "lblpe";
            this.lblpe.Size = new System.Drawing.Size(71, 17);
            this.lblpe.TabIndex = 14;
            this.lblpe.Text = "perimiter :";
            // 
            // lblval
            // 
            this.lblval.AutoSize = true;
            this.lblval.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblval.Location = new System.Drawing.Point(621, 323);
            this.lblval.Name = "lblval";
            this.lblval.Size = new System.Drawing.Size(42, 17);
            this.lblval.TabIndex = 15;
            this.lblval.Text = "value";
            // 
            // lblNdot
            // 
            this.lblNdot.AutoSize = true;
            this.lblNdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdot.Location = new System.Drawing.Point(534, 380);
            this.lblNdot.Name = "lblNdot";
            this.lblNdot.Size = new System.Drawing.Size(81, 17);
            this.lblNdot.TabIndex = 16;
            this.lblNdot.Text = "No of dots :";
            // 
            // lbldot
            // 
            this.lbldot.AutoSize = true;
            this.lbldot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbldot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldot.Location = new System.Drawing.Point(621, 380);
            this.lbldot.Name = "lbldot";
            this.lbldot.Size = new System.Drawing.Size(35, 17);
            this.lbldot.TabIndex = 17;
            this.lbldot.Text = "dots";
            // 
            // pbraill
            // 
            this.pbraill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbraill.Controls.Add(this.lbldotc);
            this.pbraill.Controls.Add(this.lbldotval);
            this.pbraill.Controls.Add(this.lblBval);
            this.pbraill.Controls.Add(this.label3);
            this.pbraill.Location = new System.Drawing.Point(731, 292);
            this.pbraill.Name = "pbraill";
            this.pbraill.Size = new System.Drawing.Size(132, 105);
            this.pbraill.TabIndex = 18;
            // 
            // lbldotc
            // 
            this.lbldotc.AutoSize = true;
            this.lbldotc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldotc.Location = new System.Drawing.Point(3, 70);
            this.lbldotc.Name = "lbldotc";
            this.lbldotc.Size = new System.Drawing.Size(77, 17);
            this.lbldotc.TabIndex = 20;
            this.lbldotc.Text = "Dot count :";
            // 
            // lbldotval
            // 
            this.lbldotval.AutoSize = true;
            this.lbldotval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldotval.Location = new System.Drawing.Point(78, 70);
            this.lbldotval.Name = "lbldotval";
            this.lbldotval.Size = new System.Drawing.Size(38, 17);
            this.lbldotval.TabIndex = 20;
            this.lbldotval.Text = "DOT";
            // 
            // lblBval
            // 
            this.lblBval.AutoSize = true;
            this.lblBval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBval.Location = new System.Drawing.Point(29, 31);
            this.lblBval.Name = "lblBval";
            this.lblBval.Size = new System.Drawing.Size(51, 17);
            this.lblBval.TabIndex = 19;
            this.lblBval.Text = "Bvalue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Braill";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-6, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntext
            // 
            this.btntext.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntext.Location = new System.Drawing.Point(99, -3);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(110, 34);
            this.btntext.TabIndex = 20;
            this.btntext.Text = "Text";
            this.btntext.UseVisualStyleBackColor = true;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // shapebox
            // 
            this.shapebox.FormattingEnabled = true;
            this.shapebox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Triangle",
            "Circle"});
            this.shapebox.Location = new System.Drawing.Point(669, 112);
            this.shapebox.Name = "shapebox";
            this.shapebox.Size = new System.Drawing.Size(194, 21);
            this.shapebox.TabIndex = 22;
            this.shapebox.SelectedIndexChanged += new System.EventHandler(this.shapebox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select shape :";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(614, 443);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(122, 63);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.shapebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbraill);
            this.Controls.Add(this.lbldot);
            this.Controls.Add(this.lblNdot);
            this.Controls.Add(this.lblval);
            this.Controls.Add(this.lblpe);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblshape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pbraill.ResumeLayout(false);
            this.pbraill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblshape;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label lblpe;
        private System.Windows.Forms.Label lblval;
        private System.Windows.Forms.Label lblNdot;
        private System.Windows.Forms.Label lbldot;
        private System.Windows.Forms.Panel pbraill;
        private System.Windows.Forms.Label lblBval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldotval;
        private System.Windows.Forms.Label lbldotc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntext;
        private System.Windows.Forms.ComboBox shapebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclear;
    }
}