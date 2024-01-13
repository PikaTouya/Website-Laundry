CREATE database Laundry

USE Laundry

create table Pengguna (
	id_pengguna varchar(6),
	nama_pengguna varchar(50),
	password_pengguna varchar(50),
	level_pengguna varchar(10),
	nomortelepon_pengguna varchar(15)
)

create table Transaksi (
	id_transaksi varchar(8),
	id_pengguna varchar(6),
	tanggal_transaksi datetime,
	id_jasa varchar(6),
	berat_pakaian float,
	harga_transaksi money,
	pakai_kupon bit,
	status_transaksi text
)

create table Jasa (
	id_jasa varchar(6),
	jenis_cuci nvarchar(max),
	harga money
)

INSERT INTO Pengguna(id_pengguna, nama_pengguna, password_pengguna, level_pengguna, nomortelepon_pengguna) VALUES ('ADM001', 'ADMIN001', 'SAYAADMIN001', 'ADMIN', '081293939393')
INSERT INTO Pengguna(id_pengguna, nama_pengguna, password_pengguna, level_pengguna, nomortelepon_pengguna) VALUES ('USR001', 'USER001', 'SAYAUSER001', 'USER', '081295732943')

INSERT INTO Transaksi(id_transaksi, id_pengguna, tanggal_transaksi, id_jasa, berat_pakaian, harga_transaksi, pakai_kupon, status_transaksi) VALUES ('TR001', 'USR001', GETDATE(), 'JS001', 5, 50000, 0, 'Completed')

INSERT INTO Jasa (id_jasa, jenis_cuci, harga) VALUES ('JS001', 'Normal Wash', '10000')
INSERT INTO Jasa (id_jasa, jenis_cuci, harga) VALUES ('JS002', 'Normal Wash + Ironing', '15000')
INSERT INTO Jasa (id_jasa, jenis_cuci, harga) VALUES ('JS003', 'Quick Wash', '20000')
INSERT INTO Jasa (id_jasa, jenis_cuci, harga) VALUES ('JS004', 'Quick Wash + Ironing', '25000')