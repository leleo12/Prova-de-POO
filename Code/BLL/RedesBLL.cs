using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3A1Pedro37.Code.DAL;


namespace _3A1Pedro37.Code.BLL
{
    class RedesBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "perfumes";
        public void Inserir(RedesDTO rededto)
        {
            
            string inserir = $"insert into {tabela} values(null,'{rededto.Nome}','{rededto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()    
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(RedesDTO rededto)
        {
            string alterar = $"update {tabela} set medicamento = '{rededto.Nome}', composicao = '{rededto.Preco}' where id = '{rededto.Id}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(RedesDTO rededto)
        {
            string excluir = $"delete from {tabela} where id = '{rededto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}