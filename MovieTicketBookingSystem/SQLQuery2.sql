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

INSERT INTO movies (movie_id, movie_name, genre, price, capacity, movie_image, status, created_at)
VALUES ('M001', 'Avatar', 'Sci-Fi', 15.99, 100, 'avatar.jpg', 'Available', GETDATE());



DROP TABLE movies

SELECT * FROM movies