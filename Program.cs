Episodio ep1 = new(3, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Geovana");


Episodio ep2 = new(2, "Técnicas de aprendizado", 61);
ep2.AdicionarConvidados("Pedro");
ep2.AdicionarConvidados("Jorge");
ep2.AdicionarConvidados("Guilherme");


Episodio ep3 = new(1, "Técnicas de Marketing", 30);
ep3.AdicionarConvidados("João");
ep3.AdicionarConvidados("Geovana");
ep3.AdicionarConvidados("Pedro");

Podcast podcast = new("Podcast Coding", "João");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();
