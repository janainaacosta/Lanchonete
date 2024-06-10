using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "o nome do lanche deve ser informado!")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = " O {0} deve ter no mínimo {1} e no máximo {2} ")]                              
        public string Name { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "A descrição curta do lanche deve ser informado!")]
        [Display(Name = "Descrição curta do lanche")]
        [MinLength(20, ErrorMessage = " descrição curta deve ter no mínimo {1} caracteres. ")]
        [MaxLength(200, ErrorMessage = " descrição curta pode exceder {1} caracteres.")]
        public string DescricaoCurta { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informado!")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = " descrição detalhada deve ter no mínimo {1} caracteres. ")]
        [MaxLength(200, ErrorMessage = " descrição detalhada pode exceder {1} caracteres.")]
        public string  DescricaoDetalhada { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "informe o preço do lanche!")]
        [Display(Name = "preço")]
        [Column(TypeName = "decimal(10.2")]
        [Range(1, 999.99, ErrorMessage = "o preço deve estar entre $1 e $999,99")]
        public decimal Preco { get; set; }

        //-------------------------------------------------------------
        [Display(Name = "caminho imagem normal")]
        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1} caracteres.")]
        public string ImagemUrl { get; set; }

        //-------------------------------------------------------------

        [Display(Name = "caminho imagem normal")]
        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1} caracteres.")]
        public string ImagemThumbnailUrl { get; set; }

        //-------------------------------------------------------------

        [Display(Name = "preferido?")]
        public bool IsLanchePreferido { get; set; }

        //-------------------------------------------------------------

        [Display(Name = "em estoque?")]
        public bool EmEstoque { get; set; }





        public int CategoriaId { get; set;}
        public virtual Categoria Categoria { get; set; }
    }
}
