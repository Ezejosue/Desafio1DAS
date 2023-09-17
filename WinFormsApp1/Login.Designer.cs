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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            labUsuario = new Label();
            labClave = new Label();
            btnSesion = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labLogin
            // 
            labLogin.AutoSize = true;
            labLogin.BackColor = SystemColors.HighlightText;
            labLogin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labLogin.ForeColor = Color.FromArgb(128, 128, 255);
            labLogin.Location = new Point(225, 29);
            labLogin.Name = "labLogin";
            labLogin.Size = new Size(199, 29);
            labLogin.TabIndex = 2;
            labLogin.Text = "INICIAR SESION";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.ActiveCaption;
            txtUser.Location = new Point(357, 242);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(292, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.Location = new Point(357, 295);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(292, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.BackColor = SystemColors.HighlightText;
            labUsuario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labUsuario.ForeColor = Color.FromArgb(128, 128, 255);
            labUsuario.Location = new Point(204, 242);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(95, 22);
            labUsuario.TabIndex = 5;
            labUsuario.Text = "USUARIO";
            // 
            // labClave
            // 
            labClave.AutoSize = true;
            labClave.BackColor = SystemColors.HighlightText;
            labClave.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labClave.ForeColor = Color.FromArgb(128, 128, 255);
            labClave.Location = new Point(204, 295);
            labClave.Name = "labClave";
            labClave.Size = new Size(74, 22);
            labClave.TabIndex = 6;
            labClave.Text = "CLAVE";
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSesion.ForeColor = Color.FromArgb(128, 128, 255);
            btnSesion.Location = new Point(388, 360);
            btnSesion.Margin = new Padding(0, 2, 0, 2);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(233, 37);
            btnSesion.TabIndex = 7;
            btnSesion.Text = "INICIAR SESION ";
            btnSesion.UseVisualStyleBackColor = true;
            btnSesion.Click += btnSesion_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(388, 413);
            button1.Margin = new Padding(0, 2, 0, 2);
            button1.Name = "button1";
            button1.Size = new Size(233, 37);
            button1.TabIndex = 8;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.usuario;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(710, 488);
            Controls.Add(button1);
            Controls.Add(btnSesion);
            Controls.Add(labClave);
            Controls.Add(labUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(labLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label labUsuario;
        private Label labClave;
        private Button btnSesion;
        private Button button1;
    }
}