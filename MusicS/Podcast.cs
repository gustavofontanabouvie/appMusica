class Podcast
{
    private List<Episodios> TotalEpisodios = new List<Episodios> ();
    public string Host { get;}
    public string Nome { get;}

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodios titulo)
    {
        TotalEpisodios.Add(titulo);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
        Console.WriteLine($"Lista de episodios: ");
        foreach (var ep in TotalEpisodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine($"Episodio: {ep.Titulo}, Numero: {ep.Ordem}");
        }
    }
}