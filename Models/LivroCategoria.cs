using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
    }
        public int LivroCategoriaID {get; set;}

        [ForeignKey("Livro")]
        public int LivroID {get; set;}

        public Livro Livro {get; set;}

         [ForeignKey("Categoria")]
        public int CategoriaID {get; set;}

        public Categoria Categoria {get; set;}
}