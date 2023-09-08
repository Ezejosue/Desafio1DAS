namespace WinFormsApp1
{
    partial class Information
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
            tabControl1 = new TabControl();
            tabInfo1 = new TabPage();
            tabInfo2 = new TabPage();
            tabEstadistica = new TabPage();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabInfo1.SuspendLayout();
            tabInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInfo1);
            tabControl1.Controls.Add(tabInfo2);
            tabControl1.Controls.Add(tabEstadistica);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 673);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // tabInfo1
            // 
            tabInfo1.BackColor = SystemColors.InactiveCaption;
            tabInfo1.Controls.Add(pictureBox1);
            tabInfo1.Controls.Add(textBox1);
            tabInfo1.Location = new Point(4, 29);
            tabInfo1.Name = "tabInfo1";
            tabInfo1.Padding = new Padding(3);
            tabInfo1.Size = new Size(816, 640);
            tabInfo1.TabIndex = 0;
            tabInfo1.Text = "tabPage1";
            // 
            // tabInfo2
            // 
            tabInfo2.BackColor = Color.Gainsboro;
            tabInfo2.Controls.Add(pictureBox2);
            tabInfo2.Controls.Add(textBox2);
            tabInfo2.Location = new Point(4, 29);
            tabInfo2.Name = "tabInfo2";
            tabInfo2.Padding = new Padding(3);
            tabInfo2.Size = new Size(816, 640);
            tabInfo2.TabIndex = 1;
            tabInfo2.Text = "tabPage2";
            // 
            // tabEstadistica
            // 
            tabEstadistica.Location = new Point(4, 29);
            tabEstadistica.Name = "tabEstadistica";
            tabEstadistica.Padding = new Padding(3);
            tabEstadistica.Size = new Size(816, 640);
            tabEstadistica.TabIndex = 2;
            tabEstadistica.Text = "tabPage3";
            tabEstadistica.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario1;
            pictureBox1.Location = new Point(18, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(473, 27);
            textBox2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario2;
            pictureBox2.Location = new Point(39, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 28, 65);
            ClientSize = new Size(858, 697);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Information";
            Text = "Information";
            tabControl1.ResumeLayout(false);
            tabInfo1.ResumeLayout(false);
            tabInfo1.PerformLayout();
            tabInfo2.ResumeLayout(false);
            tabInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInfo1;
        private TabPage tabInfo2;
        private TabPage tabEstadistica;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
    }
}