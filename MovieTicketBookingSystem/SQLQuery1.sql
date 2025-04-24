CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_reg DATE NULL
)

SELECT * FROM users

INSERT INTO users (username,password,role,status,date_reg) 
VALUES ('admin','admin123','Admin','Active','2024-06-08')

SELECT * FROM  users WHERE role = 'staff'

SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'users';
ALTER TABLE users ADD date_reg DATE;




