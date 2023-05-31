
-- create
CREATE TABLE EMPLOYEE (
  Id INTEGER PRIMARY KEY AUTO_INCREMENT,
  name TEXT NOT NULL,
  age INTEGER NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Clark', 15, 'ул. Московская, д. 5');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Dave', 16, 'ул. Московская, д. 6');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Eva', 18, 'ул. Мира, д. 5');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Yana', 19, 'ул. Мира, д. 20');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('David', 22, 'ул. Московская, д. 15');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Anna', 23, 'ул. Московская, д. 15');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Clark', 24, 'ул. Московская, д. 15');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Dav', 25, 'ул. Мира, д. 2');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Ivan', 30, 'ул. Московская, д. 10');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Clark', 32, 'ул. Мира, д. 11');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Danna', 33, 'ул. Московская, д. 10');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Alla', 34, 'ул. Московская, д. 1');

-- fetch 
SELECT name имя
  FROM EMPLOYEE 
    WHERE address like '%Московская%' and age between 18 and 29 
      order by name;