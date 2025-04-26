Episodio ep1 = new(4, "Preguiça de nomear o título", 600000000);

ep1.AdicionarConvidados("Juca Balero");
ep1.AdicionarConvidados("Buca Jalero");
ep1.AdicionarConvidados("Jale Bucero");




Episodio ep2 = new(8, "Como aprender C# em 60 segundos", 1);

ep2.AdicionarConvidados("Alien X");
ep2.AdicionarConvidados("Alan Turin");
ep2.AdicionarConvidados("Ada Lovelace");
ep2.AdicionarConvidados("Bil do Bora Bil");


Episodio ep3 = new(3, "O caminho para Castidade", 69);

ep3.AdicionarConvidados("Alexandre Frota");
ep3.AdicionarConvidados("Andressa Urach");
ep3.AdicionarConvidados("Grávida de Taubaté");


Podcast podcast = new("João Paulo II", "Conclave");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();