CREATE TABLE patients(
patient_id INT NOT NULL IDENTITY PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
gender char(6) CHECK (gender IN('M','F','Other')),
age INT CHECK(age>0 AND age<120),
email VARCHAR(50) UNIQUE,
created_at DATETIME DEFAULT CURRENT_TIMESTAMP)