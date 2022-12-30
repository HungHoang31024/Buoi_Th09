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
	NgayNhap smalldatetime NULL
)

CREATE  TABLE HOADON
(
	MaHD char(5)primary key,
	NgayBan date NULL,
	SLMua smallint,
	ThanhTien int ,
	MaSach char(5) FOREIGN KEY (MaSach) REFERENCES SACH (MaSach)
)

 insert into SACH values ('S001','Tin hoc A','Binh Minh','Nguyen Minh Minh','N001',25000,40,'01/02/2019 5:30:00')
 insert into SACH values ('S002','Tin hoc B','Van Van','Vo Nhu Dan','N002',22000,50,'1/1/2021 5:30:00')
 insert into SACH values ('S003','PreTest B','Nguyen Hanh','Tong Gia Bach','N003',5500,80,'5/26/2009 5:30:00')
 insert into SACH values ('S004','Thuat toan','Le Huong','Ha Nhat Vi','N004',37500,10,'9/11/2017 5:30:00')
 insert into SACH values ('S005','Nhiep anh','Tran Chau','Mai Xuan Huy','N005',50000,40,'12/3/2013 5:30:00')
 insert into SACH values ('S006','Thuoc co truyen','Hai Nam','Vo Ngoc Minh Huy','N006',30000,50,'09/07/2017 5:30:00')
 insert into SACH values ('S007','Ky nghe lanh','Cao Tuan','Truong Hoang Phuc','N007',32000,80,'12/20/2022 5:30:00')
 insert into SACH values ('S008','Mon qua giang sinh','O.Henry','ToNy Teo','N008',100000,10,'09/09/2020 5:30:00')
 insert into SACH values ('S009','Cho doi mot tinh yeu','Thach Bien','Tran Tri Bang','N009',150000,10,'09/03/2015 5:30:00')
 insert into SACH values ('S010','Tri tue nhan tao','Tuan Anh','Vo Vu Linh','N010',38000,10,'10/16/2015 5:30:00')
 insert into SACH values ('S011','Khoa hoc vien tuong','Ngoc Le','Tri Nguyen','N011',25000,20,'01/03/2019 5:30:00')
 insert into SACH values ('S012','Hoa hoc tro','Van Van','Minh Hoa','N012',22500,13,'12/01/2021 5:30:00')
 insert into SACH values ('S013','Muc tim','Nguyen Hanh','Buu Chi','N013',5500,6,'05/26/2022 5:30:00')
 insert into SACH values ('S014','Lap trinh can ban','Khanh Toan','Rose','N014',32500,10,'09/01/2020 5:30:00')
 insert into SACH values ('S015','Hoa hoc','Tran Chau','Mai Quynh Anh','N015',51000,40,'12/06/2018 5:30:00')
 insert into SACH values ('S016','Vat li','Hai Nam','Cirs Pham','N016',33000,34,'09/07/2017 5:30:00')
 insert into SACH values ('S017','Ky nang giao tiep','Cao Tuan','Kens','N017',32000,90,'12/02/2022 5:30:00')
 insert into SACH values ('S018','Truyen thong Viet Nam','Jeny','Minh Beo','N018',101000,55,'09/09/2021 5:30:00')
 insert into SACH values ('S019','Giao duc cong dan','Khoa Tien','Le Nguyen','N019',15000,29,'03/03/2015 5:30:00')
 insert into SACH values ('S020','Hoa ngu','Tuan Anh','Vu Ha','N020',27000,44,'10/19/2019 5:30:00')
 insert into SACH values ('S021','Tam giac hong','Dam Hung','Bao Lan','N021',23000,40,'01/04/2019 5:30:00')
 insert into SACH values ('S022','Ly thuyet do thi','Dong Nhi','Mrs Ha','N022',22000,50,'07/01/2021 5:30:00')
 insert into SACH values ('S023','Van hoc','Gia Bach','Tran My','N023',8500,80,'10/24/2016 5:30:00')
 insert into SACH values ('S024','Chuon trinh hay hoc','Huu Anh','Vo Ngoc','N024',19500,10,'05/27/2017 5:30:00')
 insert into SACH values ('S025','Co tich tuyen truyen','Tran Chau','Thao My','N025',34000,40,'02/13/2014 5:30:00')
 insert into SACH values ('S026','Lop hoc ve','My Ngoc','Thuy Quynh','N026',36000,50,'09/08/2018 5:30:00')
 insert into SACH values ('S027','Kinh te chinh tri','Tung Son','Cuong Nguyen','N027',32000,70,'7/28/2022 5:30:00')
 insert into SACH values ('S028','Gioi thieu nganh','Tran Thanh','Gia Huy','N028',10000,10,'06/09/2020 5:30:00')
 insert into SACH values ('S029','Dia li','Thach Bien','Thuy Vy','N029',15500,66,'04/03/2012 5:30:00')
 insert into SACH values ('S030','Giao trinh tin hoc','Ngoc Anh','Dong Dong','N030',38500,10,'10/30/2011 5:30:00')

 insert into HOADON values (1,'7/15/2017','1','0','S001')
 insert into HOADON values (2,'8/16/2015','1','0','S002')
 insert into HOADON values (3,'6/16/2015','1','0','S003')
 insert into HOADON values (4,'3/16/2021','1','0','S004')
 insert into HOADON values (5,'12/18/2019','1','0','S005')
 insert into HOADON values (6,'1/20/2020','1','0','S006')
 insert into HOADON values (7,'12/23/2022','1','0','S007')
 insert into HOADON values (8,'8/10/2020','1','0','S008')
 insert into HOADON values (9,'11/16/2015','1','0','S009')
 insert into HOADON values (10,'12/16/2021','1','0','S010')
 insert into HOADON values (11,'12/18/2019','1','0','S020')
 insert into HOADON values (12,'5/20/2020','1','0','S021')
 insert into HOADON values (13,'7/15/2021','1','0','S022')
 insert into HOADON values (14,'8/16/2017','1','0','S023')
 insert into HOADON values (15,'1/1/2017','1','0','S024')
 insert into HOADON values (16,'3/16/2014','1','0','S025')
 insert into HOADON values (17,'12/18/2019','1','0','S026')
 insert into HOADON values (18,'7/30/2022','1','0','S027')
 
 SELECT *FROM SACH
 SELECT *FROM HOADON