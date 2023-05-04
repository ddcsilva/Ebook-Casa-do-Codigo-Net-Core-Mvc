namespace IES.Models;

public class Instituicao
{
    public Instituicao()
    {
        Nome = string.Empty;
        Endereco = string.Empty;
    }

    public long? InsituicaoID { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
}