CREATE TABLE IF NOT EXISTS faculties (
	id SERIAL PRIMARY KEY,
	prefix VARCHAR(2) NOT NULL,
	name VARCHAR(60) NOT NULL
);

CREATE TABLE IF NOT EXISTS directions (
	direction_id SERIAL PRIMARY KEY,
	name VARCHAR(80) NOT NULL,
	faculty_id INTEGER NOT NULL,
	FOREIGN KEY (faculty_id) REFERENCES faculties (id)
);

CREATE TABLE IF NOT EXISTS groups (
	group_id SERIAL PRIMARY KEY,
	number VARCHAR(2) NOT NULL,
	direction_id INTEGET NOT NULL,
	FOREIGN KEY (direction_id) REFERENCES directions (id),
	description VARCHAR(100),
	create_year VARCHAR(4) NOT NULL
);

CREATE TABLE IF NOT EXISTS disciplines (
	discipline_id SERIAL PRIMARY KEY,
	year DATE NOT NULL,
	name VARCHAR(15) NOT NULL,
	semester varchar(1) NOT NULL
	
);

CREATE TABLE IF NOT EXISTS students (
	student_id SERIAL PRIMARY KEY,
	group_id INTEGER NOT NULL,
	FOREIGN KEY (group_id) REFERENCES groups (group_id),
	first_name VARCHAR(30) NOT NULL,
	second_name VARCHAR(50) NOT NULL,
	patronimyc VARCHAR(30),
	passport_ser VARCHAR(10) UNIQUE NOT NULL,
	passport_no VARCHAR(10) UNIQUE NOT NULL,
	UNIQUE (passport_ser, passport_no)
);

CREATE TABLE IF NOT EXISTS additionalCourses(
	adCourse_id SERIAL PRIMARY KEY,
	student_id INTEGER NOT NULL,
	discipline_id INTEGER NOT NULL,
	FOREIGN KEY (student_id) REFERENCES students (student_id),
	FOREIGN KEY (discipline_id) REFERENCES disciplines (discipline_id)
);

CREATE TABLE IF NOT EXISTS additionalPoints(
	additionalPoints_id SERIAL PRIMARY KEY,
	student_id INTEGER NOT NULL,
	FOREIGN KEY (student_id) REFERENCES students (student_id),
	semester VARCHAR(1) NOT NULL,
	year DATE NOT NULL,
	points INTEGER NOT NULL
);

CREATE TABLE IF NOT EXISTS additionalDormitoryPoints(
	additionalDormitoryPoints_id SERIAL PRIMARY KEY,
	student_id INTEGER NOT NULL,
	FOREIGN KEY (student_id) REFERENCES students (student_id),
	year DATE NOT NULL,
	points INTEGER NOT NULL
);

DO $$ BEGIN
CREATE TYPE PASSED_STATE AS ENUM ('0', '1');
EXCEPTION
    WHEN duplicate_object THEN null;
END $$;

CREATE TABLE IF NOT EXISTS discplineResults(
	disciplineResults_id SERIAL PRIMARY KEY,
	student_id INTEGER NOT NULL,
	discipline_id INTEGER NOT NULL,
	FOREIGN KEY (student_id) REFERENCES students (student_id),
	FOREIGN KEY (discipline_id) REFERENCES disciplines (discipline_id),
	points INTEGER CONSTRAINT discplineResults_points_check CHECK(points >0 AND points < 100),
	passed PASSED_STATE
);

CREATE TABLE IF NOT EXISTS dormitoryWilling(
	dormitoryWilling_id SERIAL PRIMARY KEY,
	student_id INTEGER NOT NULL,
	FOREIGN KEY (student_id) REFERENCES students (student_id)
);

CREATE TABLE IF NOT EXISTS dormitories(
	dormitory_id SERIAL PRIMARY KEY,
	name VARCHAR(20) NOT NULL,
	address VARCHAR(40) NOT NULL
);

CREATE TABLE IF NOT EXISTS dormitoryPlaces(
	dromPlaces_id SERIAL PRIMARY KEY,
	dormitory_id INTEGER NOT NULL,
	FOREIGN KEY (dormitory_id) REFERENCES dormitories(dormitory_id),
	year DATE
);

CREATE TABLE IF NOT EXISTS teacher(
	teacher_id SERIAL PRIMARY KEY,
	disciplines_id INTEGER NOT NULL,
	faculty_id INTEGER NOT NULL,
	FOREIGN KEY (disciplines_id) REFERENCES disciplines(discipline_id),
	FOREIGN KEY (faculty_id) REFERENCES faculties(faculty_id)
);




