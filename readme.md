# Sonasatku eli sanasotku

## Linkki

Peliä pelattavissa [Sonasatku](https://student.labranet.jamk.fi/~n3652/peliohjelmointi/sonasatku/)

## Yleistä

Sonasatkun idea on opettaa pienemmille aakkosia ja sanoja. Alkuun kirjoitetaan sana joka palastellaan kirjaimiksi, jonka jälkeen raketilla pyydystetään kirjaimet oikeassa järjestyksessä ja olet voittaja.

## Pelimoottori

Pelimoottorina käytetty Unity 2D 2014.4 versiota.

## Käytetyt resurssit

Avaruusalus: https://assetstore.unity.com/packages/templates/packs/space-adventure-endless-game-template-178094

Tausta: https://gamesupply.itch.io/50-xy-repeat-space-backgrounds

Taustamusiikki: https://freemusicarchive.org/music/REW_1123/tephra/tazieff-2

Kirjaimen ääni: https://assetstore.unity.com/packages/audio/sound-fx/coins-sfx-39052

Kirjainkolikot Aini Hyvärinen 

## Scriptejä

## Raketin ohjaus

- Raketille annetaan maksimi nopeus, pyörimisnopeus ja Kirjainkoliko

- Ääni asetuksia kirjainten keräykseen

- Haetaan raketin suunta ja seurataan onko painettuna sivu näppäimiä jonka avulla voidaan tallentaa uusi suunta.  

![raketin ohjaus](sanaseka/pics/rocketcontroller1.JPG)

- Liikutetaan rakettia vertailemmalla positioneita ja rajataan lento alue ikkunan kokoseksi (ylälaitaa vähän madallettu) Tallennetaan uusi positioni. 

![raketin ohjaus](sanaseka/pics/rocketcontroller2.JPG)

## Kirjainten luonti

- Luodaan apukirjaimet, haetaan GameObjectin prefabit taulukkoon ja luodaan laskuri

- Haetaan PlayerPrefs sana joka on tallennettu syötettäessä lausetta

![kirjainten luonti](sanaseka/pics/letterspawn1.JPG)

- Muutetaan syöttétty sana kirjaimiksi taulukkoon

- Vertaillaan apukirjainten indeksin avulla onko samaa kirjainta kuin sanassa

- Luodaan teksti sanasta peli ikkunaan

- Luodaan random paikoille kirjaimet

![kirjainten luonti](sanaseka/pics/letterspawn2.JPG)

## Kirjainten hallinta

- Luodaan muuttujia ja kirjaimelle äänipaikka

- Haetaan sana ja laskuri

- luodaan uusi taulukko ja kirjain joka vastaa laskurin indeksi numeroa luodussa taulussa

![kirjainten hallinta](sanaseka/pics/lettercontroller1.JPG)

- Vertaillaan onko kirjain sama kun noudettu kirjain 

- jos kirjain vastaa noudettua kirjainta niin laskuri kasvaa yhdellä, tuhotaan kirjain ja soitetaan kirjaimen nouto ääni

- Vertaillaan onko laskuri samassa kuin sanan pituus jos on siirrytään voitto ruutuun 

![kirjainten hallinta](sanaseka/pics/lettercontroller2.JPG)

## Kuvia pelistä

## Etusivu

- Etusivulle syötetään sana jonka kirjaimia halutaan pyydystää

- On myös mahdollista "poistua" pelistä

![Etusivu](sanaseka/pics/mainwindow.JPG)

## Virhe sanassa

- Tyhjän sanan syöttö estetty 

![Ei sanaa](sanaseka/pics/mainwindownoword.JPG)

## Virhe sanassa

- Liian pitkän sanan syöttö estetty

![Liian pitkä sana](sanaseka/pics/mainwindowtoolongword.JPG)

## Peli

- Kirjaimet tulevat sekaisin ja arvottuihin paikkoihin ruudulle

- Kirjaimet pitää pyydystää järjestyksessä, oikean kirjaimen ottaminen hävittää kirjaimen

- Mahdollisuus palata myös takaisin etusivulle 

![Peli ikkuna](sanaseka/pics/gamewindow.JPG)

## Voitto

- Onnitellaan voittajaa ja kerrotaan mikä sana on kirjoitettua

- Mahdollisuus jatkaa peliä uudella sanalla tai "lopettaa" peli

![Voittaja](sanaseka/pics/victoryScreen.JPG)

## Uloskirjaus

- Kiitetään pelaajaa

- Annetaan mahdollisuus palata takaisin uuteen peliin

![Ulos kirjaus](sanaseka/pics/logoutwindow.JPG)

## Yhteenveto

Mielestäni onnistuin erittäin hyvin (kokemukseen nähden). Olin todella tyytyväinen pelin ideaan (joka tuli autoa ajaessa). Toteutuksen puolesta sain toteutettua noin 95% mitä olin suunnitellutkin. Tuli todella paljon kirjoitettua omaa koodia ja suunniteltua eri toiminnallisuuksia, toki oli Youtube ja Unityn omat materiaalit apuna. Todella ehjä ja positiivinen kuva jäi pelistä.

## Kehityskohteita

- Kirjaimen poimiminen ääntäisi kirjaimen

- Kirjaimen poiminta vaihtaisi väriä sanan kohdalla

- Oikean ja väärän kirjaimen poimiminen aiheuttaisi animaation (molempiin eri)

- Voitto ruutuun eri ilmoitus kun kaikki on kerätty oikeassa järjestyksessä

- Sanakirjasto, josta saisi poimittua sanan ja sinne voisi myös tallentaa sanoja

- Sanan äänitys

## Ajan käyttö

- Pelin suunnittelu 4h

- Sivujen layoutit 4h

- Toiminnalisuus (koodit) 30h

- Muihin hienosäätöihin 10h

- Testauksiin ja buildauksiin 3h


Yhteensä +50h (Mutta oli mukavaa)

## Arvosana

Oma arvioni arvosanaksi olisi 4,5-5

Pelin idea 5

Toteutus 4.5

Haastavuus 4

Pelin eheys 5




  



