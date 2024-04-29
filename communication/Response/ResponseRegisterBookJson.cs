namespace ApiLivraria.communication.Response;

public class ResponseRegisterBookJson
{
    public int id { get; set; }
    public string titulo { get; set; } = string.Empty;
    public string autor { set; get; } = string.Empty;
    public string genero { set; get; } = string.Empty;
    public int preco { set; get; }
    public int estoque { set; get; }
}
