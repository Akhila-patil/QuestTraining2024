CREATE TABLE appointment(
app_id INT NOT NULL PRIMARY KEY,
patient_id INT ,
appointment_date DATE ,
appointement_time TIME ,
reason_for_visit TEXT NOT NULL,
doctor_name VARCHAR(50) NOT NULL,
created_at   DATETIME DEFAULT CURRENT_TIMESTAMP
FOREIGN KEY (patient_id) REFERENCES patients(patient_id)

)

INSERT INTO appointment(app_id,patient_id,appointment_date,appointement_time,reason_for_visit,doctor_name,created_at)
VALUES
(1, 1, '2024-10-10', '09:00:00', 'General check-up', 'Dr. Williams', '2024-10-01 09:35:00'),
(2, 2, '2024-10-12', '11:30:00', 'Flu symptoms', 'Dr. Smith', '2024-10-02 11:00:00'),
(3, 3, '2024-10-15', '14:00:00', 'Back pain', 'Dr. Johnson', '2024-10-03 08:30:00'),
(4, 4, '2024-10-20', '10:00:00', 'Skin rash', 'Dr. Brown', '2024-10-04 11:30:00'),
(5, 5, '2024-10-18', '15:00:00', 'Routine follow-up', 'Dr. Taylor', '2024-10-05 14:40:00');
