SELECT * FROM movies m
WHERE m.year = 2000;
<!--время без индекса 2.37566 сек-->

CREATE INDEX movie_name_description
ON movies(name, description);
<!--время запроса с индексом 2.29-->


//пункт б
SELECT m.country, m.name FROM movies m
WHERE  m.country = 'Russia';
<!--время без индекса 2.2286845 сек-->

CREATE INDEX movies_name_country
ON movies(country, name);
<!--время запроса с индексом 1.6911103-->



//пунтк в
SELECT * FROM movies m
WHERE m.budget = 100000;
<!--время без индекса 2.2469020 сек-->

CREATE INDEX movies_budget ON movies(budget)
WHERE budget = 100000
<!--время запроса с индексом 1.9409089-->



//пункт г
SELECT * FROM movies m
WHERE m.budget = 100000 or m.budget <10000
ORDER BY name;
<!--время без индекса 1.9679867 сек-->


CREATE INDEX movies_budget ON movies(name ASC)
<!--время запроса с индексом 1.9478982-->
