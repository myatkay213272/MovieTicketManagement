SELECT * FROM users;

SELECT * FROM movies WHERE status = 'Available' AND delete_date IS NULL

CREATE TABLE customers 
(

	 id  INT PRIMARY KEY IDENTITY(1,1),
	 movie_id VARCHAR(MAX) NULL,
	 seat_type VARCHAR(MAX) NULL,
	 available_seat INT NULL,
	 totalPrice FLOAT NULL,	
	 foods VARCHAR(MAX) NULL,
	 drinks VARCHAR(MAX) NULL,
	 amount FLOAT NULL,
	 change FLOAT NULL,
	 status VARCHAR(MAX) NULL,
	 date_buy DATETIME NULL


)

SELECT * FROM customers;