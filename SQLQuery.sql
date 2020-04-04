create table Students(
	Id int primary key identity,
	Name nvarchar(100),
	Surname nvarchar(100)
)

Select Name from Students where Id=5

Insert into Students values('Gunel','Memmedova')

Select Name,Surname from Students