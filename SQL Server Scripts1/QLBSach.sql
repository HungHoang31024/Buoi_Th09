CREATE DATABASE QLBSach

USE QLBSach

CREATE TABLE SACH
(
	MaSach char(5) 	primary key,
	TenSach nvarchar(40) ,
	TacGia nvarchar(20) ,
	TenNSX nvarchar(20),
	MaLoai char(5) ,
	DonGia int ,
	SLTon smallint,
	NgayNhap date NULL
)

CREATE  TABLE HOADON
(
	MaHD char(5),
	NgayBan date NULL,
	SLMua smallint,
	ThanhTien int ,
	MaSach char(5) FOREIGN KEY (MaSach) REFERENCES SACH (MaSach)
)

 insert into SACH values ('S001','Tin hoc A','Binh Minh','Nguyen Minh Minh','N001',25000,40,'01/02/2019')
 insert into SACH values ('S002','Tin hoc B','Van Van','Vo Nhu Dan','N001',22000,50,'1/1/2021')
 insert into SACH values ('S003','PreTest B','Nguyen Hanh','Tong Gia Bach','N003',5500,80,'5/26/2009')
 insert into SACH values ('S004','Thuat toan','Le Huong','Ha Nhat Vi','N002',37500,10,'9/11/2017')
 insert into SACH values ('S005','Nhiep anh','Tran Chau','Mai Xuan Huy','N002',50000,40,'12/3/2013')
 insert into SACH values ('S006','Thuoc co truyen','Hai Nam','Vo Ngoc Minh Huy','N004',30000,50,'09/07/2017')
 insert into SACH values ('S007','Ky nghe lanh','Cao Tuan','N002','Truong Hoang Phuc',32000,80,'12/20/2022')
 insert into SACH values ('S008','Mon qua giang sinh','O.Henry','ToNy Teo','N006',100000,10,'09/09/2020')
 insert into SACH values ('S009','Cho doi mot tinh yeu','Thach Bien','Tran Tri Bang','N006',150000,10,'09/03/2015')
 insert into SACH values ('S010','Tri tue nhan tao','Tuan Anh','N001','Vo Vu Linh',38000,10,'10/16/2015')

 insert into HOADON values (1,'7/15/2015','1','0','S001')
 insert into HOADON values (2,'7/16/2015','1','0','S002')
 insert into HOADON values (3,'7/16/2015','1','0','S003')
 insert into HOADON values (4,'7/16/2015','1','0','S004')
 insert into HOADON values (5,'7/18/2015','1','0','S005')
 insert into HOADON values (6,'7/20/2015','1','0','S006')

 SELECT *FROM SACH
 SELECT *FROM HOADON