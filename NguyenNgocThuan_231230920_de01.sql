create database NguyenNgocThuan_231230920_de01
go 
use NguyenNgocThuan_231230920_de01
go
create table NntComputer (
	NntComId nvarchar(20) not null primary key,
	NntComName nvarchar(100) not null,
	NntComPrice decimal(10, 2) not null,
	NntComImage nvarchar(200),
	NntComStatus bit not null
);

insert into NntComputer (NntComId, NntComName, NntComPrice, NntComImage, NntComStatus)
values 
('C001', 'MSI', 16000, null, 1),
('C002', 'Acer', 1200, null, 0),
('C003', 'Del', 1300, null, 1);
