CREATE PROCEDURE NewLoginRecord 
@employee_id INT, @cabin_id INT, @login_time DATETIME
as
INSERT INTO LOGIN_RECORD (employee_id, cabin_id, login_time) VALUES (@employee_id, @cabin_id, @login_time)
