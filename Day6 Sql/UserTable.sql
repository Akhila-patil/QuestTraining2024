﻿CREATE TABLE USERS(
id INT PRIMARY KEY IDENTITY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
email VARCHAR(100) NOT NULL,
age int NOT NULL DEFAULT 18
)
