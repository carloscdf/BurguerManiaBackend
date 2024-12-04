using System.ComponentModel.DataAnnotations;

public class Usuario {
    public int id {get;set;}
    [Required(ErrorMessage = "A nome do usuário é obrigatório.")]
    public string nome {get;set;} = string.Empty;
    [Required(ErrorMessage = "A email do usuário é obrigatório.")]
    public string  email {get;set;} = string.Empty;
    [Required(ErrorMessage = "A senha do usuário é obrigatório.")]
    public int senha {get;set;}
}