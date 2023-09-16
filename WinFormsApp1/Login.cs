using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {

        private Dictionary<string, User> usuariosRegistrados = new Dictionary<string, User>();

        public FormLogin()
        {
            InitializeComponent();
            InitializeRegisteredUser();
        }

        private void InitializeRegisteredUser()
        {
            usuariosRegistrados.Add("Kevin", new User("Kevin", "123", "Redes"));
            usuariosRegistrados.Add("Gerardo", new User("Gerardo", "238", "Streaming"));
            usuariosRegistrados.Add("Sofia", new User("Sofia", "789", "Streaming"));
            usuariosRegistrados.Add("Josue", new User("Josue", "987", "Estadisticas"));
            usuariosRegistrados.Add("Karens", new User("Karens", "852", "Streaming"));

        }


        private void btnSesion_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            if (usuariosRegistrados.ContainsKey(username))
            {
                User user = usuariosRegistrados[username];

                if (user.Password == password)
                {
                    
                    MessageBox.Show("Bienvenido a la plataforma de Streaming " + username);
                    Information Information = new Information(user.Theme);
                    Information.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sus credenciales son incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Usuario no Registrado");
            }


        }
    }
}
