CREATE TABLE patients(
patient_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
gender char(6) CHECK (gender IN('M','F','Other')),
age INT CHECK(age>0 AND age<120),
email VARCHAR(50) UNIQUE,
created_at DATETIME DEFAULT CURRENT_TIMESTAMP)

INSERT INTO patients(patient_id,first_name,last_name,gender,age,email,created_at)
VALUES(1, 'John', 'Doe', 'M', 34, 'john.doe@example.com', '2024-10-01 09:30:00'),
(2, 'Jane', 'Smith', 'F', 28, 'jane.smith@example.com', '2024-10-02 10:45:00'),
(3, 'Michael', 'Johnson', 'M', 45, 'michael.johnson@example.com', '2024-10-03 08:15:00'),
(4, 'Emily', 'Davis', 'F', 22, 'emily.davis@example.com', '2024-10-04 11:00:00'),
(5, 'Alex', 'Taylor', 'Other', 30, 'alex.taylor@example.com', '2024-10-05 14:25:00');