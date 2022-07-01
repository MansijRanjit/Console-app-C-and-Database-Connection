create table PersonalInfo
(
	id int primary key identity(1,1),
	name nvarchar(20) not null,
	email nvarchar(50),
	phone nvarchar(20)

)

select * from PersonalInfo;