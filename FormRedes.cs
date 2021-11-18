using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1Pedro37.Code.BLL;




namespace _3A1Pedro37
{
    public partial class FormRedes : Form


    {

        RedesBLL redebll = new RedesBLL();
        RedesDTO rededto = new RedesDTO();






        public FormRedes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGames_Load(object sender, EventArgs e)
        {
            dgv_dados.DataSource = redebll.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            rededto.Nome = txt_nome.Text;
            rededto.Preco = txt_preco.Text;

        
            redebll.Inserir(rededto);

         
            MessageBox.Show("Cadastrado com sucesso!", "Perfume", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            rededto.Id = int.Parse(txt_id.Text);
            rededto.Nome= txt_nome.Text;
            rededto.Preco = txt_preco.Text;

            redebll.Editar(rededto);

           
            MessageBox.Show("Alterado com sucesso!", "Perfume", MessageBoxButtons.OK, MessageBoxIcon.Information);

 
            redebll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
         
            rededto.Id = int.Parse(txt_id.Text);

   
            redebll.Excluir(rededto);

           
            MessageBox.Show("Excluido com sucesso!", "Perfume", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
            redebll.Listar();

         
            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_dados.DataSource = redebll.Listar();
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_dados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_dados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco.Text = dgv_dados.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
