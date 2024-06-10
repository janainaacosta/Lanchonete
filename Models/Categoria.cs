using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete.Models
{

    [Table ("Categorias")]
    public class Categoria
    {

        [Key]
        public int CategoriaID { get; set; }

        [StringLength (100, ErrorMessage ="o tamanho máximo é 100 caracteres.")]
        [Required(ErrorMessage = "informe o nome da categoria.")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "o tamanho máximo é 200 caracteres.")]
        [Required(ErrorMessage = "informe a descrição da categoria.")]
        [Display(Name = "Nome")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
      
    }
}

    
