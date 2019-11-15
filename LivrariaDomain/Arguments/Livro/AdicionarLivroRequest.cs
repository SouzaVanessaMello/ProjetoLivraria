using LivrariaDomain.Interfaces.Arguments;
using LivrariaDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDomain.Arguments.Livro
{
    public class AdicionarLivroRequest : IRequest
    {
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
    }
}
