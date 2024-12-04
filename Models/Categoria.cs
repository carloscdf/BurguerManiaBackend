using System.ComponentModel.DataAnnotations;

public class Categoria
{
    public int id { get; set; }
    [Required(ErrorMessage = "A nome da categoria é obrigatório.")]
    public string nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "A descrição da categoria é obrigatório.")]
    public string desc { get; set; } = string.Empty;
    [Required(ErrorMessage = "O tipo da categoria é obrigatório.")]
    public string tipo { get; set; } = string.Empty;
    [Required(ErrorMessage = "A imagem da categoria é obrigatório.")]
    public string imagem { get; set; } = string.Empty;
}