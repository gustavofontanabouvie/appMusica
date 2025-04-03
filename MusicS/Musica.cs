//Musica
class Musica
{

    //construtor para sempre adicionar uma banda quando se cria uma musica
    public Musica(Banda artista, string nome)
    {
        //sempre que eu criar um objeto da classe Musica, vou precisar passar
        //uma banda ja existente
        Artista = artista;
        Nome = nome;
        //esse Artista que recebe o parametro é uma propriedade de Musica
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a {Artista.Nome}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição resumida: {DescricaoResumida}");
        if (Disponivel)
        {
            Console.WriteLine("A musica esta disponivel");
        }
        else
        {
            Console.WriteLine("A musica não esta disponivel");
        }
    }
};