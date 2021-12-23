)Pi{student, teacher}(teacher ⋈ student);
SELECT students.second_name, teacher.second_name FROM teacher INNER JOIN students ON students.group_id = teacher.group_id

2)Pi{second_name} (students) ∞ (б(points > 86)(disciplineResults)))
SELECT DISTINCT name FROM students INNER JOIN disciplineResults AS dr ON students.student_id = disciplineResults.student_id WHERE dr.points > 86;	
