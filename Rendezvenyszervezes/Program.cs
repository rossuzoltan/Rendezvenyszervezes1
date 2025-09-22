using Rendezvenyszervezes;

Rendezvenyek rendezveny = new Rendezvenyek(new DateTime(2025, 09, 24), "Sarkadkeresztur", 300, 200, "Bamgutya", 150);
Konferenciak konferencia = new Konferenciak(new DateTime(2024, 11, 15), "Budapest", 480, 100, "TechKonf", 90, new string[] { "Dr. Kovács Anna", "Nagy Béla", "Szabó Katalin" }, true, "Innováció a jövőben");

rendezveny.RendezvenyInfo("Kiss Péter");
rendezveny.ResztvevoHozzaad(80);
konferencia.eloadasokHossza();
