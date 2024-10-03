#Web Api

způsob, jak můžeme data requestovat a posílat
Klient - u nás (prohlížeč, aplikace v mobilu) pošle request na server (beží na cloudu, jiné prohlížeči, na cloudu)

Frontend - klient - co vií uživatel
backend, to co běží v cloudu na serveru

API - rozhraní, přes které můžeme komunikovat, má definici, jak komunikovat. Pokud chceš získat písničky, musíš napsat request na naše api, které vypadá tak a tak

zpátky pošle response

Klient přojme odpověď, vidí seznam písniček, vyberu si písníčku , pošlu request na konkrétní písničku - a on mi ji pošle

je to jiné doména než dáávme uživateli

POST - pro update
GET - získává data

JSON - javascript on notation, důpuhý string, jednoduše se to transformuji, je to lidsky čitelné

poprvé spustíme webovou stránku, nedostaneme celý obsah -> 
jak převede json na html
vezme response json -> přečte -> deserializace (spšl druh parsování) -> udělá objekty, kterým rozumí
preview -> tam vidím, co z toho udělal



