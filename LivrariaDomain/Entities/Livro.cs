using LivrariaDomain.Entities.Base;
using LivrariaDomain.ValueObjects;
using System;
using System.Collections.Generic;

namespace LivrariaDomain.Entities
{
    public class Livro : BaseEntity
    {
        // ISBN, Autor, Nome, Preço, Data Publicação, Imagem da Capa
        public ISBN Isbn  { get; set; }
        public List<Nome> AutorCollection { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
    }
}
