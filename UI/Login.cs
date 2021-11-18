using _3A1Pedro37.Code.BLL;
using _3A1Pedro37.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1Pedro37.UI
{
    public partial class Login : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            
            loginDTO.Email = txt_email.Text;
            loginDTO.Senha = txt_senha.Text;


            
            if (loginBLL.RealizarLogin(loginDTO) == true)
            {

                FormRedes formgames = new FormRedes();
                formgames.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique nome e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
