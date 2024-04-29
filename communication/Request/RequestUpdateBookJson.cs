namespace ApiLivraria.communication.Request;

public class RequestUpdateBookJson
{
    public string genero { set; get; } = string.Empty;
    public int preco { set; get; }
    public int estoque { set; get; }

}
