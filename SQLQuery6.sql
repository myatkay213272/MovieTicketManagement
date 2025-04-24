SELECT * FROM movies

CREATE TABLE buy_ticket
(
	id INT PRIMARY KEY IDENTITY(1,1),
	movie_id VARCHAR(MAX) NULL,
	seat_number INT NULL,
	price DECIMAL(10,2),
	amount DECIMAL(10,2),
	change FLOAT, 
	status VARCHAR(MAX) NULL,
	created_at DATETIME
);


UPDATE buy_ticket SET [change] = 10 WHERE id = 1;

SELECT * FROM buy_ticket

SELECT [change] FROM buy_ticket;










DROP TABLE buy_ticket

SELECT capacity FROM movies WHERE delete_date IS NULL and status != 'Deleted'

SELECT movies.capacity , buy_ticket.* FROM movies LEFT JOIN buy_ticket
ON movies.movie_id = buy_ticket.movie_id WHERE movies.movie_id = 'MD-001' ;