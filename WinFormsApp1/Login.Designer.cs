namespace WinFormsApp1
{
    partial class FormLogin
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
            labLogin = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labUsuario = new Label();
            labClave = new Label();
            btnSesion = new Button();
            SuspendLayout();
            // 
            // labLogin
            // 
            labLogin.AutoSize = true;
            labLogin.BackColor = SystemColors.HighlightText;
            labLogin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labLogin.ForeColor = Color.FromArgb(128, 128, 255);
            labLogin.Location = new Point(257, 39);
            labLogin.Name = "labLogin";
            labLogin.Size = new Size(271, 35);
            labLogin.TabIndex = 2;
            labLogin.Text = "INICIAR SECCION";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(408, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(408, 393);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 27);
            textBox2.TabIndex = 4;
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.BackColor = SystemColors.HighlightText;
            labUsuario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labUsuario.ForeColor = Color.FromArgb(128, 128, 255);
            labUsuario.Location = new Point(233, 322);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(118, 27);
            labUsuario.TabIndex = 5;
            labUsuario.Text = "USUARIO";
            // 
            // labClave
            // 
            labClave.AutoSize = true;
            labClave.BackColor = SystemColors.HighlightText;
            labClave.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labClave.ForeColor = Color.FromArgb(128, 128, 255);
            labClave.Location = new Point(233, 393);
            labClave.Name = "labClave";
            labClave.Size = new Size(88, 27);
            labClave.TabIndex = 6;
            labClave.Text = "CLAVE";
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSesion.ForeColor = Color.FromArgb(128, 128, 255);
            btnSesion.Location = new Point(475, 479);
            btnSesion.Margin = new Padding(0, 3, 0, 2);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(266, 33);
            btnSesion.TabIndex = 7;
            btnSesion.Text = "INICIAR SESION ";
            btnSesion.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.usuario;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 650);
            Controls.Add(btnSesion);
            Controls.Add(labClave);
            Controls.Add(labUsuario);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labUsuario;
        private Label labClave;
        private Button btnSesion;
    }
}