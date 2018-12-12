namespace HideTextInPic
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
            this.picAsli = new System.Windows.Forms.PictureBox();
            this.picTabdil = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabdil)).BeginInit();
            this.SuspendLayout();
            // 
            // picAsli
            // 
            this.picAsli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.picAsli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAsli.Location = new System.Drawing.Point(12, 25);
            this.picAsli.Name = "picAsli";
            this.picAsli.Size = new System.Drawing.Size(321, 278);
            this.picAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAsli.TabIndex = 0;
            this.picAsli.TabStop = false;
            // 
            // picTabdil
            // 
            this.picTabdil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picTabdil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTabdil.Location = new System.Drawing.Point(408, 25);
            this.picTabdil.Name = "picTabdil";
            this.picTabdil.Size = new System.Drawing.Size(321, 278);
            this.picTabdil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTabdil.TabIndex = 1;
            this.picTabdil.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(573, 324);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 35);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(654, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 35);
            this.textBox1.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(61, 324);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(185, 324);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 35);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 365);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.picTabdil);
            this.Controls.Add(this.picAsli);
            this.Name = "Form1";
            this.Text = "HideTextInPic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabdil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAsli;
        private System.Windows.Forms.PictureBox picTabdil;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCheck;
    }
}

