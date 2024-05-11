create database Travel_World;

create table Package (
p_id int,
A_id int,
c_id int,
p_country varchar (26),
p_hotel varchar(26),
p_price int,
p_capacity int,
p_duration int
)
select * from Admin;
select * from UserDetails;
select * from AgenciesDetails;
select * from Package;
select * from TransactionDetails;
select * from customoffer;
select * from Package where p_price between 30000 and 50000

select Uname from Admin where Uname='shanto' AND Password='s';
select A_id from AgenciesDetails where Username='bdtravel' and Password='123';
select * from Package where A_id=1;
create table AgenciesDetails(

Agencies_Name varchar(50),
Email varchar(26),
Phone int,
Address Varchar(60),
password Varchar(10),
p_id int
)


alter table UserDetails Add picloc varchar(100); 
alter table AgenciesDetails  add Username varchar(26);
alter table Admin  add Admin_id int;

ALTER TABLE Package
ALTER COLUMN p_country  varchar(200);

ALTER TABLE UserDetails
ALTER COLUMN Email  varchar(200);

DELETE FROM UserDetails WHERE password='s' or password='ss';
DELETE FROM Package WHERE p_id>0;
DELETE FROM TransactionDetails WHERE Payment_id>0;
DELETE FROM UserDetails WHERE c_id=7;
DELETE FROM customoffer WHERE custom_id=3;
DELETE FROM TransactionDetails WHERE Payment_id>0;

ALTER TABLE Admin
ADD Balance float

ALTER TABLE Admin
DROP COLUMN Balance;

ALTER TABLE UserDetails
DROP CONSTRAINT PK__UserDeta__213EE774532DD45C;

ALTER TABLE Package
Add p_hotel varchar(100);

create table Admin(
Uname varchar(26),
Password varchar(26)

)

create table UserDetails(
  
  firstName varchar(26),
  Secondname varchar(26),
  email varchar(26),
  Address varchar(26),
  password varchar(26),
  p_id int ,
  c_id int ,
  Username varchar(26),
  Phone int(11),
  picloc varchar (26)
)
create table TransactionDetails(
  
  Payment_id int primary key,
  Payment_date varchar(50),
  Customer_id int,
  Agencies_id int,
  Package_id int,
  Amount int,
  Payment_Method varchar(26)

)
create table customoffer(
custom_id int,
A_id int,
c_id int,
cp_country varchar (100),
cp_hotel varchar(100),
cp_price int,
cp_capacity int,
cp_duration int,
picloc varchar(150)

);

insert into Admin(Admin_id) values('1')
insert into Package(p_id,A_id,p_country,p_hotel,p_price,p_capacity,p_duration) values('shanto','s')

UPDATE AgenciesDetails
SET picloc = 'C:\Users\GKisl\OneDrive\Desktop\organization_icon.png'
WHERE A_id = '1' OR A_id = '2';
UPDATE Admin
SET Admin_id = '1'
WHERE Password='s';


UPDATE Admin SET Balance = 0 WHERE Password='s';
Drop Table customoffer;