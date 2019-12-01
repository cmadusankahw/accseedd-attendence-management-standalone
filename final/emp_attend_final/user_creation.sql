--copy the following codes one by one and run in your MySql Interpreter/ interface
--if you are using phpmyadmin run all at once on the sql interface

--creating new user
CREATE USER 'empadmin'@'localhost' IDENTIFIED BY 'admin';

--creating database
CREATE DATABASE employee_attendence;

--granting privilages
GRANT ALL PRIVILEGES ON * . * TO 'empadmin'@'localhost';
FLUSH PRIVILEGES;