namespace MazeAiProject
{
    partial class Start
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdi_off = new System.Windows.Forms.RadioButton();
            this.rdi_on = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(566, 444);
            this.btn_1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(299, 52);
            this.btn_1.TabIndex = 0;
            this.btn_1.TabStop = false;
            this.btn_1.Text = "Level 1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(68, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maze Game";
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(566, 358);
            this.btn_2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(299, 52);
            this.btn_2.TabIndex = 2;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "Level 2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(566, 273);
            this.btn_3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(299, 52);
            this.btn_3.TabIndex = 3;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "Level 3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(566, 529);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(299, 52);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MazeAiProject.Properties.Resources.Start;
            this.pictureBox1.Location = new System.Drawing.Point(362, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rdi_off
            // 
            this.rdi_off.AutoSize = true;
            this.rdi_off.Location = new System.Drawing.Point(195, 90);
            this.rdi_off.Name = "rdi_off";
            this.rdi_off.Size = new System.Drawing.Size(77, 40);
            this.rdi_off.TabIndex = 6;
            this.rdi_off.Text = "Off";
            this.rdi_off.UseVisualStyleBackColor = true;
            this.rdi_off.Click += new System.EventHandler(this.rdi_off_Click);
            // 
            // rdi_on
            // 
            this.rdi_on.AutoSize = true;
            this.rdi_on.Location = new System.Drawing.Point(64, 90);
            this.rdi_on.Name = "rdi_on";
            this.rdi_on.Size = new System.Drawing.Size(77, 40);
            this.rdi_on.TabIndex = 7;
            this.rdi_on.Text = "On";
            this.rdi_on.UseVisualStyleBackColor = true;
            this.rdi_on.Click += new System.EventHandler(this.rdi_on_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdi_on);
            this.panel1.Controls.Add(this.rdi_off);
            this.panel1.Location = new System.Drawing.Point(26, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 173);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Control Voice";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(924, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdi_off;
        private System.Windows.Forms.RadioButton rdi_on;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}