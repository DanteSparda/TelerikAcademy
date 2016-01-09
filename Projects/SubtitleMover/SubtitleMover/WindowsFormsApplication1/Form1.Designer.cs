using System;

namespace WindowsFormsApplication1
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
            this.inputForPath = new System.Windows.Forms.TextBox();
            this.subsToFolders = new System.Windows.Forms.RadioButton();
            this.moviesToMainDirectory = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputForPath
            // 
            this.inputForPath.Location = new System.Drawing.Point(12, 24);
            this.inputForPath.Name = "inputForPath";
            this.inputForPath.Size = new System.Drawing.Size(260, 20);
            this.inputForPath.TabIndex = 0;
            // 
            // subsToFolders
            // 
            this.subsToFolders.AutoSize = true;
            this.subsToFolders.Location = new System.Drawing.Point(12, 70);
            this.subsToFolders.Name = "subsToFolders";
            this.subsToFolders.Size = new System.Drawing.Size(123, 17);
            this.subsToFolders.TabIndex = 1;
            this.subsToFolders.TabStop = true;
            this.subsToFolders.Text = "Move subs to folders";
            this.subsToFolders.UseVisualStyleBackColor = true;
            this.subsToFolders.CheckedChanged += new System.EventHandler(this.subsToFolders_CheckedChanged);
            // 
            // moviesToMainDirectory
            // 
            this.moviesToMainDirectory.AutoSize = true;
            this.moviesToMainDirectory.Location = new System.Drawing.Point(12, 93);
            this.moviesToMainDirectory.Name = "moviesToMainDirectory";
            this.moviesToMainDirectory.Size = new System.Drawing.Size(182, 17);
            this.moviesToMainDirectory.TabIndex = 2;
            this.moviesToMainDirectory.TabStop = true;
            this.moviesToMainDirectory.Text = "Move video files to main directory";
            this.moviesToMainDirectory.UseVisualStyleBackColor = true;
            this.subsToFolders.CheckedChanged += new System.EventHandler(this.moviesToMainDirectory_checkedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // responseBox
            // 
            this.responseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responseBox.Location = new System.Drawing.Point(12, 186);
            this.responseBox.Multiline = true;
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(260, 145);
            this.responseBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moviesToMainDirectory);
            this.Controls.Add(this.subsToFolders);
            this.Controls.Add(this.inputForPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox inputForPath;
        private System.Windows.Forms.RadioButton subsToFolders;
        private System.Windows.Forms.RadioButton moviesToMainDirectory;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.Button button1;
    }
}

