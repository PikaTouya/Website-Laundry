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
	jenis_cuci text,
	berat_pakaian decimal,
	harga_transaksi money,
	pakai_kupon bit
)

INSERT INTO Pengguna(id_pengguna, nama_pengguna, password_pengguna, level_pengguna, nomortelepon_pengguna) VALUES ('ADM001', 'ADMIN001', 'SAYAADMIN001', 'ADMIN', '081293939393')
INSERT INTO Pengguna(id_pengguna, nama_pengguna, password_pengguna, level_pengguna, nomortelepon_pengguna) VALUES ('USR001', 'USER001', 'SAYAUSER001', 'USER', '081295732943')
INSERT INTO Pengguna(id_pengguna, nama_pengguna, password_pengguna, level_pengguna, nomortelepon_pengguna) VALUES ('ADM100', 'ADMIN100', 'SAYAADMIN100', 'ADMIN', '0812947353923')

INSERT INTO Transaksi(id_transaksi, id_pengguna, tanggal_transaksi, jenis_cuci, berat_pakaian, harga_transaksi, pakai_kupon) VALUES ('TR001', 'USR001', GETDATE(), 'Cuci reguler', 5, 50000, 1)