SELECT first_name, second_name FROM students
	WHERE 5 < (SELECT points FROM additionalPoints WHERE students.student_id = additionalPoints.student_id)
		  AND students.student_id IN (SELECT students.student_id AS studid FROM disciplineResults, students
									  				WHERE students.student_id = disciplineResults.student_id
									  					AND points < 86 GROUP BY studid ORDER BY studid DESC); /* 1 */

SELECT students.first_name, students.second_name, students.patronimyc, teacher.first_name, teacher.second_name
FROM students, teacher WHERE teacher.disciplines_id IN (SELECT discipline_id FROM disciplineResults WHERE students.student_id = student_id AND passed = '0'); /* 2 */

SELECT AVG(disciplineResults.points), direction_id AS direction FROM groups
				INNER JOIN students ON students.group_id = groups.group_id
					INNER JOIN disciplineResults ON students.student_id = disciplineResults.student_id
						  GROUP BY direction
						  	ORDER BY direction; /* 3 */

SELECT AVG(disciplineResults.points) AS points, groups.group_id AS groupNumber FROM groups
		INNER JOIN students ON students.group_id = groups.group_id
				INNER JOIN disciplineResults ON students.student_id = disciplineResults.student_id
					WHERE groups.direction_id = '3' /* 1 - JAVA, 2 - Python, 3 - C# */
						  GROUP BY groupNumber
						  	ORDER BY groupNumber; /* 4 */

SELECT t.first_name || t.second_name as ФИ, disciplines.name AS предмет, AVG(disciplineResults.points) AS среднийбалл FROM teacher AS t
	JOIN disciplines ON t.disciplines_id = disciplines.discipline_id
		JOIN disciplineResults ON t.disciplines_id = disciplineResults.discipline_id
			GROUP BY предмет, ФИ
				ORDER BY среднийбалл; /* 7 */

SELECT MAX(disciplineResults.points), MIN(disciplineResults.points), first_name, second_name FROM students
	INNER JOIN disciplineResults ON students.student_id = disciplineResults.student_id GROUP BY (first_name, second_name); /* 9 */                             


							
SELECT first_name || second_name AS ФИ,
CASE
WHEN AVG(dR.points) > 86 THEN 'Отличник'
WHEN AVG(dR.points) <= 86 AND AVG(dR.points) > 71 THEN 'Ударник'
WHEN AVG(dR.points) <= 71 AND AVG(dR.points) >= 56 THEN 'Троечник'
WHEN AVG(dR.points) < 56 THEN 'Двоечник'
END Рейтинг

FROM students
JOIN disciplineResults dR on students.student_id = dR.student_id
GROUP BY ФИ
ORDER BY ФИ DESC; /* 10 */

