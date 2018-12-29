-- Count the ammount of Johns in table students.
SELECT COUNT(*) FROM students WHERE firstName='John';

-- Update rows. 
UPDATE enrollments SET year=2015  WHERE id <= 100 AND id >= 20;

-- PL/SQL Example.
CREATE OR REPLACE FUNCTION count_users 
RETURN NUMBER 
IS 
  user_count NUMBER;
BEGIN
  SELECT COUNT(*) INTO user_count FROM users;
  RETURN user_count;
END;
/

-- When the users table is dropped, the count_users function is invalidated.
-- When the users table is dropped any function, procedure, or package using count_users is invalidated.


-- Consider the following table definition:

CREATE TABLE couples(
  id NUMBER PRIMARY KEY NOT NULL,
  first_name VARCHAR2(50) NOT NULL,
  last_name VARCHAR2(50) NOT NULL
);
-- Later the following code is executed:

DECLARE
  husband_id NUMBER;
BEGIN
  SELECT id INTO husband_id FROM couples WHERE first_name = 'John' AND last_name = 'Johnson';
  INSERT INTO couples(id, first_name, last_name) VALUES(husband_id + 1, 'Jane', 'Johnson');
END;

-- NO_DATA_FOUND
-- TOO_MANY_ROWS
-- DUP_VAL_ON_INDEX

-- Pets
-- Full outer join, join two colums.
select distinct name from dogs full outer join cats where condition
-- Union of two selects.
select distinct name from dogs union select distinct name from cats

-- Select with join.
select items.name, sellers.name from items join sellers on items.sellerID = sellers.id where sellers.rating>4;

-- Select from another select.
select name from employees where id NOT IN (select managerId from employees where managerId IS NOT NULL or managerId!='');

-- Having usage example, useful for using agregate functions, it's like a where.
select userId, avg(duration) duration from sessions group by userId having count(*) > 1;

-- Select several values starting with vowels.
select distinct city from station where city like 'a%' or city like 'e%' or city like 'i%' or city like 'o%' or city like 'u%';

-- Ordered by last 3 characters of name.
select name from students where marks > 75 order by right(name, 3), id ASC;

-- Get the ones with the longest and shortest names.
(select city, length(city) as lengthName from station order by lengthName asc, city limit 1)
union all
(select city, length(city) as lengthName from station order by lengthName desc, city  limit 1);

-- Resource: https://www.w3schools.com/sql/sql_wildcards.asp

SELECT companyName, marketCapitalization from (SELECT companyName, marketCapitalization from fsia
union 
SELECT companyName, sharePrice * sharesOutstanding as marketCapitalization from fsib)
order by  marketCapitalization desc;

-- esteban.zeledon@pa.ey.com