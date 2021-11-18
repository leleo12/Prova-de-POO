using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1Pedro37.Code.BLL
{
    class RedesDTO
    {
        private int _id;
            private string _nome;
            private string _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Preco { get => _preco; set => _preco = value; }
    }
}
