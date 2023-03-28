CREATE TABLE logins (
loginID INT PRIMARY KEY iDENTITY (1,1),
userName varchar(255) UNIQUE,
userPassword varchar(255),
priorityLevel int
)
insert into logins (userName, userPassword,priorityLevel) VALUES ('Charlie.Gale', '5E884898DA28047151D0E56F8DC6292773603D0D6AABBDD62A11EF721D1542D8',1)
delete from logins where loginid >0
drop table logins
select * from logins