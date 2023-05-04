namespace IES.Models;

// Classe que representa uma instituição de ensino
public class Instituicao
{
    // Construtor que inicializa as propriedades
    public Instituicao()
    {
        Nome = string.Empty;
        Endereco = string.Empty;
    }

    public long? InstituicaoID { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
}