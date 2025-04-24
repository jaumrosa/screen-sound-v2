Banda travis = new Banda();
travis.Nome = "Travis Scott";

Album albumDoTravis = new Album();
albumDoTravis.Nome = "Utopia";

Musica musica1 = new Musica(travis);
musica1.Nome = "My Eyes";
musica1.Duracao = 251;


Musica musica2 = new Musica(travis);
musica2.Nome = "I Know?";
musica2.Duracao = 211;

albumDoTravis.AdicionarMusica(musica1);
albumDoTravis.AdicionarMusica(musica2);


travis.AdicionarAlbum(albumDoTravis);
travis.ExibirDiscografia();