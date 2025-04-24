Banda travis = new Banda("Travis Scott");

Album albumDoTravis = new Album("Utopia");

Musica musica1 = new Musica(travis, "My Eyes")
{
    Duracao = 251,
    Disponivel = false,
};

Musica musica2 = new Musica(travis, "I Know?")
{
    Duracao = 211,
    Disponivel = true,
};

albumDoTravis.AdicionarMusica(musica1);
albumDoTravis.AdicionarMusica(musica2);
travis.AdicionarAlbum(albumDoTravis);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoTravis.ExibirMusicasDoAlbum();
travis.ExibirDiscografia();