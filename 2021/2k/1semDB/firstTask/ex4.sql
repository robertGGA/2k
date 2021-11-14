SELECT student_id FROM additionalPoints WHERE points > 5;

SELECT discipline_id, student_id FROM disciplineResults WHERE passed = '0';

SELECT dateOfBirth FROM students WHERE second_name LIKE 'А%';

SELECT first_name, second_name FROM students WHERE EXTRACT (YEAR FROM CURRENT_TIMESTAMP) - EXTRACT (YEAR FROM dateOfBirth) >= 20;

SELECT student_id FROM additionalDormitoryPoints WHERE student_id > 10 LIMIT 10;

SELECT student_id, ROUND(AVG(points), 2) FROM disciplineResults GROUP BY student_id;