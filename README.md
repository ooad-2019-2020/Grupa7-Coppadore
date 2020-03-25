# e-videoteka Coppadore
# ![images](https://user-images.githubusercontent.com/56490989/77188954-17ead400-6ad7-11ea-94eb-8b28a40de9c3.png)  
 

**Članovi tima:**
* Mirza Mujkanović
* Fejsal Mujkić

**Opis teme:**

Aplikacija Coppadoro služi za online kupovinu I pregled filmova, korisnik inicijalno dobija listu filmova sa servera gde su prikazani podaci o imenu, godini izdanja filma, oceni kao i poster filma. Takođe implementirana je i pretraga korisnika, glumaca te filmova iz liste filmova dobijenih sa servera. Klikom na film iz liste otvara se novi ekran koji prikazuje više informacija o izabranom filmu, dodatne informacije o filmu takođe dolaze sa servera u odvojenom zahtevu.Klikom na glumca otvara se novi prozor sa listom filmova u kojima je glumio taj glumac sortiranih prema ocjeni filma. Pored dodatnih informacija koje uključuju kratko opisanu radnju filma, uloge i ocenu korisnika, data je i mogućnost korisniku da doda film u listu želja kao i  da kupi film te nakon kupovine film se automatski dodaje u folder myMovies gdje se nalaze kupljeni filmovi koje korisnik može preuzeti na svoj računar koliko god puta hoće . Pretraživanjem i klikom na  korisnika možete vidjeti filmove koje je taj korisnik kupio.Korisnik nakon gledanja filma može da da sopstvenu ocenu filma ili da napiše neki komentar na film. Pomenute liste kao i ocena filma se čuvaju u lokalnoj bazi aplikacije.

## Procesi:
* Registracija 
       
       Omogućuje korisniku ukoliko nema account da se registrira sa osnovnim informacijama o sebi(ime,
      prezime , korisničko ime, mail, šifra) . 
* Prijavljivanje
       
       Omogućuje korisniku koji je registrovan na sajt da se prijavi upisujući informacije
       (korisničko ime , šifra).
* Pretraživanje filmova
       
       Box za pretraživanje omogućava korisniku da u polje unese naziv filma I pretraži bazu podataka 
       i nadje film sa datim imenom
* Pretraživanje glumaca 
       
       Box za pretraživanje glumaca  gdje se unosi ime glumca I dobijaju osnovne informacije o glumcu  i
       njihove najbolje ocijenjene filmove
* Spremanje filmova 
       
       Svaki film koji korisnik pregledao sprema se u myMovies folder odnosno folder sa filmovima koje je
       dati korisnik pogledao
* Pretrazivanje korisnika
       
       Korisnik može pretražiti bilo kojeg korisnika na sistemu I može vidjet koje je filmove pogledao kao
       I njegove najbolje ocijenjene filmove
* Ocjenjivanje filmova
       
       Korisnik nakon gledanja filma moze ocijeniti isti te ta ocjena utiče na konačnu ocjenu filma 
* Komentarisanje filmova
       
       Korisnik nakon gledanja filma moze komentarisati isti I svaki korisnik ili gost na sajtu moze naći 
       komentare na bilo koji film 
* Kratak tekstualni opis filma 
       
       Korisnik moze pregledati tekstualni opis za film koji ga zanima 
* Dodavanje filma na listu zelja
       
       Svaki korisnik prilikom registrovanja na sajt ima svoju listu zelja koja je na početku prazna , 
       I može u nnju dodavati filmove po želji
* Kupovina filma
       
       Ukoliko korisnik poželi kupiti film može to uraditi preko platnog procesora(paypala) ili preko 
       debitne kartice tako sto unese korektne podatke za isti, te tako korisnik moze skinuti film koji 
       je kupio kada hoće I koliko puta hoce
* Pozivanje gosta
        
        Ukoliko gost postane korisnik ovog sajta inicijativu već registrovanog korisnika , taj korisnik 
        moze ostvariti popust na bilo koji film koji krisnik želi kupiti
 * Sortiranje filmova
       
       Korisnik može sortirati filmove recimo(datum –najnoviji, najstariji ili cijena- najniža- najviša)
* Odjavljivanje korisnika
       
       Korisnik nakon što završi korištenje aplikacije može se odjaviti I sve sto je uradio bit će sačuvano 
       kad se sljedeci put prijavi




## Funkcionalnosti:
 
 Gost
- Registrovanje korisnika 
- Mogućnost da vidi sa kojim filmovima videoteka raspolaže

Korisnik
- Prijava korisnika
- Pretraživanje filmova, glumaca, reditelja
- Mogućnost da korisnik vidi kratak opis filma kao I osnovne informacije o filmu(žanr, glumce, reditelj, trajanje, ocjenu , komentare…)
- Pretraživanje korisnika
- Ocjenjivanje filmova
- Komentarisanje filmova
- Kupovanje filmova
- Pozivanje gosta 
- Sortiranje filmova
- Preuzimanje kupljenog filma 

Administrator
- Brisanje I dodavanje korisnika u bazu podataka
- Brisanje I dodavanje filmova u bazu podataka


## Akteri:

1. Administratori
   * Osobe koje kreiraju sistem , nadgledaju I ažuriraju sistem, slušaju I ispunjavaju korisničke zahtjeve, vrše postupke dodavanja I brisanja filmova iz baze podataka, dodavanja I brisanja korisnika iz baze podataka …
2. Korisnik  
   * Korisnik aplikacije je osoba koja se registrovala na sistem I ima mogućnost kupovine filma, pravljenje liste filmova koje ima u planu da pogleda, pregleda ostalih korisnika te traženja korisnika i filmova.
3. Gost 
   * Gosti na ovom sajtu su potencijalni korisnici koji će moći vidjeti kojim filmovima raspolaže aplikacija
4. Sistem 
   * Sadrži informacije o filmovima, listama želja korisnika, listama filmova koje je korisnik pregledao

5. Sistem za plaćanje

5.1. Platni processor
   * Platni procesor koji ćemo korisntiti u ovoj aplikaciji je PAYPAL iz razloga što je jedan od najpopularnijih I najsigurnijih internetskih servisa za obavljanje financijskih transakcija.

5.2. Sistem za kartično plaćanje 
   * Ukoliko se radi o korisnicima koji nemaju svoj paypal account(svakako im se preporučuje da otvore paypal zbog sigurnosti I brzine koju on nudi) a žele da koriste ovu aplikaciju, takvim korisnicima će biti omogućeno plaćanje  debitnom karticom 


