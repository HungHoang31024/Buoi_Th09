create database QLHS
use QLHS

create table hocsinh
(
	mahs char(5),
	holot nvarchar(40),
	tenhs nvarchar(30),
	phai nvarchar(15),
	ngaysinh date not NULL,
	maqq char(5) FOREIGN key (maqq) references quequan (maqq)
)

create table quequan
(
	maqq char(5) primary key,
	tenqq nvarchar(20)
)

Insert into hocsinh values('HS001','Tran thi','A','Nu','5/29/2000','AG');
Insert into hocsinh values('HS002','Tran Dinh','B','Nam','7/09/2000','TG');
Insert into hocsinh values('HS003','Truong van','C','Nam','01/15/2000','AG');
Insert into hocsinh values('HS004','Le thi','D','Nu','6/19/2000','KG');

Insert into quequan values('AG','An Giang');
Insert into quequan values('TG','Tien Giang');
Insert into quequan values('KG','kien Giang');

select *from hocsinh
select *from quequan
