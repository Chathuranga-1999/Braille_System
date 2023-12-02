namespace Braill_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblchoice = new System.Windows.Forms.Label();
            this.choiceBox = new System.Windows.Forms.ComboBox();
            this.lblshape = new System.Windows.Forms.Label();
            this.shapebox = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AnticFont", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Braill Calculator";
            // 
            // lblchoice
            // 
            this.lblchoice.AutoSize = true;
            this.lblchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoice.Location = new System.Drawing.Point(293, 220);
            this.lblchoice.Name = "lblchoice";
            this.lblchoice.Size = new System.Drawing.Size(100, 17);
            this.lblchoice.TabIndex = 1;
            this.lblchoice.Text = "Select choice :";
            // 
            // choiceBox
            // 
            this.choiceBox.FormattingEnabled = true;
            this.choiceBox.Items.AddRange(new object[] {
            "Text",
            "Shape"});
            this.choiceBox.Location = new System.Drawing.Point(399, 220);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(194, 21);
            this.choiceBox.TabIndex = 2;
            this.choiceBox.SelectedIndexChanged += new System.EventHandler(this.choiceBox_SelectedIndexChanged);
            // 
            // lblshape
            // 
            this.lblshape.AutoSize = true;
            this.lblshape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshape.Location = new System.Drawing.Point(293, 294);
            this.lblshape.Name = "lblshape";
            this.lblshape.Size = new System.Drawing.Size(98, 17);
            this.lblshape.TabIndex = 3;
            this.lblshape.Text = "Select shape :";
            // 
            // shapebox
            // 
            this.shapebox.FormattingEnabled = true;
            this.shapebox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Triangle",
            "Circle"});
            this.shapebox.Location = new System.Drawing.Point(399, 293);
            this.shapebox.Name = "shapebox";
            this.shapebox.Size = new System.Drawing.Size(194, 21);
            this.shapebox.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Font = new System.Drawing.Font("Neon Lights", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(362, 366);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(185, 52);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Select";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.shapebox);
            this.Controls.Add(this.lblshape);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.lblchoice);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblchoice;
        private System.Windows.Forms.ComboBox choiceBox;
        private System.Windows.Forms.Label lblshape;
        private System.Windows.Forms.ComboBox shapebox;
        private System.Windows.Forms.Button btnOk;
    }
}

