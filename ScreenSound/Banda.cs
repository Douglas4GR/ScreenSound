class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }
    public void AdicionarAlbum(Album album)
    {
        if (albuns != null)
        {
            albuns.Add(album);
            Console.WriteLine($"Álbum '{album.Nome}' adicionado à banda '{Nome}'.");
        }
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda '{Nome}':");
        foreach (var album in albuns)
        {
            Console.WriteLine($"- Álbum: {album.Nome}, Duração Total: {album.DuracaoTotal} minutos");
        }
    }
}