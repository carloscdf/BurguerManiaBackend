public class Produto{
    public int id {get;set;}
    public string nome {get;set;} = string.Empty;
    public string baseDesc {get;set;} = string.Empty; //descrição base

    public string fullDesc {get;set;} = string.Empty; //descrição completa
    public decimal preco {get;set;}
    public string categoria {get;set;} = string.Empty;
    public string imagem {get;set;} = string.Empty;
    public int CategoriaId {get;set;}
 }