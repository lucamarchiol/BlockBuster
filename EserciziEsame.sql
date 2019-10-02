-- esercizio 1
select nome, cognome from attori
order by annoNascita desc

-- esercizio 2
select titolo, anno from film
where genereId = '3'

-- esercizio 3
select titolo from film
join attori on protagonistaId = attori.id
where nome = 'Tom' and cognome = 'Cruise'

-- esercizio 4
select count (id) from film

-- esercizio 5
select anno, titolo, attori.nome, attori.cognome, generi.nome from film
join attori on protagonistaId = attori.id
join generi on genereId = generi.id
order by anno, film.titolo, attori.cognome