CREATE TABLE STUDENT(id INT PRIMARY KEY IDENTITY,
                     s_name VARCHAR(50))


insert into  student (s_name) values
('Akhila'),
('sunil'),
('Bapu'),
('Patil'),
('Mansa')


CREATE TABLE SUBJECTS( id int primary key identity,sub_code VARCHAR(50),subject varchar(50))

insert into subjects(sub_code,subject) values
('MATH101', 'Mathematics'),
('SCI102', 'Science'),
('ENG103', 'English'),
('HIST104', 'History'),
('GEO105', 'Geography');


CREATE TABLE EXAM (id int primary key identity, exam_name varchar(50),min_marks int,max_marks int)

insert into exam(exam_name,min_marks,max_marks) values
('Midterm Exam', 35, 100),
('Final Exam', 40, 100),
('Quiz 1', 30, 100),
('Quiz 2', 25, 100),
('Practical Exam', 50, 100);

CREATE TABLE marks(
           id int primary key identity,
           std_id int,
           sub_id int,
           exam int ,
           marks int,
           CONSTRAINT fk_std_id FOREIGN KEY (std_id) REFERENCES student(id),
           CONSTRAINT fk_exam_id FOREIGN KEY (exam) REFERENCES exam(id),
           CONSTRAINT fk_sub_id FOREIGN KEY (sub_id) REFERENCES subjects(id) )

insert into marks(std_id,sub_id,exam,marks) values
(1,2,1,85),
(2,2,2,75),
(3,4,2,65),
(4,3,1,96),
(5,1,2,56)


select 
student.id,
subjects.subject,
marks.marks,
exam.exam_name
from marks
inner join 
student on marks.std_id=student.id
inner join
subjects on marks.sub_id=subjects.id
inner join
exam on marks.exam=exam.id;

--If the subject name is given fetch all marks

select
student.id,
student.s_name,
subjects.subject,
subjects.sub_code,
marks.exam.id,
marks.marks

from
marks
inner join
student on marks.id=student.id
inner join
subjects on marks.sub_code=subjects. sub_code
where
subjects.subject='Science';

--If student id is given fetch all the exam attended

select student.id,
student.s_name,
exam.id,
marks.sub_code,
marks.marks,
exam.max_marks

from
marks
inner join 
student on marks.id=student.id
inner  join 
exam on marks.id=exam.id
where 
student.id=3;













