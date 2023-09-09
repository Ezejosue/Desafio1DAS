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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            tabInfo2 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            tabEstadistica = new TabPage();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            tabControl1.SuspendLayout();
            tabInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabEstadistica.SuspendLayout();
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
            tabInfo1.BackColor = SystemColors.ActiveCaption;
            tabInfo1.Controls.Add(button3);
            tabInfo1.Controls.Add(button2);
            tabInfo1.Controls.Add(button1);
            tabInfo1.Controls.Add(pictureBox1);
            tabInfo1.Controls.Add(textBox1);
            tabInfo1.Location = new Point(4, 29);
            tabInfo1.Name = "tabInfo1";
            tabInfo1.Padding = new Padding(3);
            tabInfo1.Size = new Size(816, 640);
            tabInfo1.TabIndex = 0;
            tabInfo1.Text = "tabPage1";
            // 
            // button3
            // 
            button3.Location = new Point(642, 578);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Cerrar ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(505, 578);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Estadística";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(363, 578);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.redes;
            pictureBox1.Location = new Point(29, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabInfo2
            // 
            tabInfo2.BackColor = SystemColors.ActiveCaption;
            tabInfo2.Controls.Add(button6);
            tabInfo2.Controls.Add(button5);
            tabInfo2.Controls.Add(button4);
            tabInfo2.Controls.Add(pictureBox2);
            tabInfo2.Controls.Add(textBox2);
            tabInfo2.Location = new Point(4, 29);
            tabInfo2.Name = "tabInfo2";
            tabInfo2.Padding = new Padding(3);
            tabInfo2.Size = new Size(816, 640);
            tabInfo2.TabIndex = 1;
            tabInfo2.Text = "tabPage2";
            // 
            // button6
            // 
            button6.Location = new Point(642, 578);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 4;
            button6.Text = "Cerrar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(505, 578);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "Estadisticas";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(363, 578);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Anterior";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario2;
            pictureBox2.Location = new Point(29, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(520, 27);
            textBox2.TabIndex = 0;
            // 
            // tabEstadistica
            // 
            tabEstadistica.BackColor = SystemColors.ActiveCaption;
            tabEstadistica.Controls.Add(button9);
            tabEstadistica.Controls.Add(button8);
            tabEstadistica.Controls.Add(button7);
            tabEstadistica.Location = new Point(4, 29);
            tabEstadistica.Name = "tabEstadistica";
            tabEstadistica.Padding = new Padding(3);
            tabEstadistica.Size = new Size(816, 640);
            tabEstadistica.TabIndex = 2;
            tabEstadistica.Text = "tabPage3";
            // 
            // button7
            // 
            button7.Location = new Point(363, 578);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 0;
            button7.Text = "Anterior";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(505, 578);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 1;
            button8.Text = "Anterior";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(642, 578);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 2;
            button9.Text = "Anterior";
            button9.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabInfo2.ResumeLayout(false);
            tabInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabEstadistica.ResumeLayout(false);
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button9;
        private Button button8;
        private Button button7;
    }
}