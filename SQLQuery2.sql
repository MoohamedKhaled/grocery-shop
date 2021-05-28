create database theshop
use theshop
create table employee(
ID int not null primary key,
name varchar(20) not null,
phoneNumber varchar(20) not null,
address nvarchar(30)
);
insert into employee values (1,'mohamed','01115486','151 mo street')
insert into employee values (2,'khaled','01024689','151 hfg street')
insert into employee values (3,'essam','0124587','151 azx street')
insert into employee values (4,'nour','123456','151 es street')
 
create table bedo(
ItemsID int not null primary key,
name varchar(20) not null,
cost int not null,
category varchar(20) not null
);
insert into bedo values (012,'Pasta Shells',8,'Pasta ')
insert into bedo values (345,'Corn Flakes',25,'cereal ')
insert into bedo values (678,'Sunflower Oil',48,'Oil ')
insert into bedo values (910,'Texas Sauce Chips',30,'Chips')
insert into bedo values (112,'Premium Malban',18,'nutzzi ')
insert into bedo values (124,'AL DOHA White Rice',78,'Rice ')
select * from bedo ;

