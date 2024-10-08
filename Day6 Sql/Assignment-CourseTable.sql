CREATE TABLE course(course_id INt,course_name varchar(50),course_fee INT,student_id INT);
INSERT INTO course(course_id,course_name,course_fee,student_id)VALUES
(1, 'C#', 500, 1),
(1, 'C#', 500, 2),
(1, 'C#', 500, 3),
(2, 'C++', 550, 4),
(1, 'C#', 500, 5),
(3, 'Python', 400, 6),
(1, 'C#', 500, 7),
(4, 'Java', 600, 8),
(1, 'C#', 500, 9),
(3, 'Python', 400, 10),
(5, 'Full Stack', 650, 11),
(1, 'C#', 500, 12),
(1, 'C#', 500, 13),
(2, 'C++', 550, 14);

SELECT course_name, COUNT(student_id) AS total_students
FROM course 
GROUP BY course_name;

SELECT course_name ,SUM(course_fee) AS total_fees_collected
FROM COURSE 
GROUP BY course_name;

SELECT course_name ,COUNT(student_id) AS total_student
FROM course
GROUP BY course_name
ORDER BY total_student desc; 