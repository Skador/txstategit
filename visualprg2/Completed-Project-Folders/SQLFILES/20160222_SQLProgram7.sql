SELECT * FROM Student

SELECT StudentId, StuFirstName FROM Student

INSERT INTO Student(StuFirstName, StuLastName, DateOfBirth) VALUES ('Mary', 'Johnson', '03/03/2015')

INSERT INTO Student(StuFirstName, StuLastName, DateOfBirth) VALUES ('Mary', 'Smith', '03/03/2015')

UPDATE Student SET StuLastName='Poppins' WHERE StudentID=5

UPDATE Student SET StuLastName='Johnson' WHERE StudentID=4

DELETE FROM Student WHERE StudentID=3

DELETE FROM Student WHERE StudentID=2

SELECT * FROM Student WHERE StuFirstName='Mary'
