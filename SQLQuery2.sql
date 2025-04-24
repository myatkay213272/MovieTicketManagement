CREATE TABLE movies
(
	id INT PRIMARY KEY IDENTITY(1,1),
	movie_id VARCHAR(MAX) NULL,
	movie_name VARCHAR(MAX) NULL,
	genre VARCHAR(MAX) NULL,
	price float null,
	capacity INT NULL,
	movie_image VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	created_at DATETIME NULL
	
)

ALTER TABLE movies ADD delete_date DATETIME NULL;
ALTER TABLE movies ADD update_date DATETIME NULL;




DROP TABLE movies

SELECT * FROM movies