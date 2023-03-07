create database SManagement
use SManagement

create table Register
(UserName varchar(50) primary key,
Password varchar(20),
PhoneNumber varchar(12),
EmailAddress varchar(50),

);

create table Events
(EventName varchar(50),
EventDate DateTime,
);

insert 
into Events(EventName, EventDate)
values(
'Teachers Day','2022-04-05'
)

create table Announce
(Announce varchar(50));

insert 
into Announce(Announce)
values('nothing here');

create table Shedule
(Task varchar(50),
SDateAndTime DateTime,
Duration DateTime,
Discription varchar(100),
);

insert into Shedule(Task, SDateAndTime, Duration, Discription)
values ('Gui Project', '2022-05-09', '2022-7-10', 'nothing ');


create table TL
(TUserName varchar(50),
TPassword varchar(20)
);

insert into TL(TUserName, TPassword)
values('teacher', '123');

create table ALog
(AUserName varchar(50),
APassword varchar(20)
);

insert into ALog(AUserName, APassword)
values('admin', '123');

select * from Shedule;
select  * from Register;
select * from Events;
select * from Announce;