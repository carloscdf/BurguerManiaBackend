using System.ComponentModel.DataAnnotations;


public class Produto
{
    public int id { get; set; }
    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    public string nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "A descrição base do produto é obrigatório.")]
    public string baseDesc { get; set; } = string.Empty; //descrição base
    [Required(ErrorMessage = "A descrição completa do produto é obrigatório.")]
    public string fullDesc { get; set; } = string.Empty; //descrição completa
    [Required(ErrorMessage = "O preço do produto é obrigatório.")]

    public decimal preco { get; set; }
    
    [Required(ErrorMessage = "A imagem do produto é obrigatório.")]  
    public string imagem { get; set; } = string.Empty;
    public int CategoriaId { get; set; }
}