class Episodios
{
    public double Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo => $"Episodio: {Ordem} - Titulo: {Titulo} - Duração: {Duracao} minutos - Convidados:{string.Join(", ",convidados)} ";
    public string Titulo { get; set; }
    public Podcast podcast { get; }

    private List<string> convidados = new List<string>();

    public Episodios(double duracao, int ordem, string titulo, Podcast podcast)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
        this.podcast = podcast;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}