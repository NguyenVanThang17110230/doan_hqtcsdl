USE [QLlaptop2]
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[IDHoaDonBan] [nvarchar](50) NOT NULL,
	[IDLap] [nvarchar](50) NULL,
	[IDKhachHang] [nvarchar](50) NULL,
	[IDNhanVien] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NgayBan] [date] NULL,
	[Sdt] [nvarchar](50) NULL,
	[ThongTinKhuyenMai] [nvarchar](500) NULL,
	[DonGia] [money] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonBan] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[IDHoaDonNhap] [nvarchar](50) NOT NULL,
	[IDNhanVien] [nvarchar](50) NULL,
	[IDNhaCC] [nvarchar](50) NULL,
	[IDLapNhap] [nvarchar](50) NULL,
	[TenLapNhap] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[DonGia] [money] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyUser]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyUser](
	[id] [nvarchar](50) NOT NULL,
	[password] [nvarchar](30) NULL,
	[PhanQuyen] [int] NULL,
 CONSTRAINT [PK_MyUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[IDNhaCC] [nvarchar](50) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[IDNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinKhuyenMai]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinKhuyenMai](
	[IDThongTinKM] [nvarchar](50) NOT NULL,
	[IDLap] [nvarchar](50) NULL,
	[KhuyenMai] [nvarchar](500) NULL,
 CONSTRAINT [PK_ThongTinKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[IDThongTinKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinLap]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinLap](
	[IDLap] [nvarchar](50) NOT NULL,
	[TenLap] [nvarchar](50) NULL,
	[IDNhaCC] [nvarchar](50) NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ThongTin] [nvarchar](150) NULL,
 CONSTRAINT [PK_ThongTinLap] PRIMARY KEY CLUSTERED 
(
	[IDLap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_KhachHang] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KhachHang] ([IDKhachHang])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_ThongTinLap] FOREIGN KEY([IDLap])
REFERENCES [dbo].[ThongTinLap] ([IDLap])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_ThongTinLap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCC] FOREIGN KEY([IDNhaCC])
REFERENCES [dbo].[NhaCC] ([IDNhaCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCC]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
ALTER TABLE [dbo].[ThongTinKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinKhuyenMai_ThongTinLap] FOREIGN KEY([IDLap])
REFERENCES [dbo].[ThongTinLap] ([IDLap])
GO
ALTER TABLE [dbo].[ThongTinKhuyenMai] CHECK CONSTRAINT [FK_ThongTinKhuyenMai_ThongTinLap]
GO
ALTER TABLE [dbo].[ThongTinLap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinLap_NhaCC] FOREIGN KEY([IDNhaCC])
REFERENCES [dbo].[NhaCC] ([IDNhaCC])
GO
ALTER TABLE [dbo].[ThongTinLap] CHECK CONSTRAINT [FK_ThongTinLap_NhaCC]
GO
/****** Object:  StoredProcedure [dbo].[uspDeleteHoadon]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Xóa hóa đơn bán
CREATE PROCEDURE [dbo].[uspDeleteHoadon]
	@IDHoaDonBan nvarchar(50)
AS
BEGIN	
	DELETE FROM HoaDonBan WHERE IDHoaDonBan = @IDHoaDonBan;
END
GO
/****** Object:  StoredProcedure [dbo].[uspDeletehoadonnhap]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Xóa hóa đơn nhập
create proc [dbo].[uspDeletehoadonnhap]
@IDHoaDonNhap nvarchar(50)
as
begin
	delete from HoaDonNhap where @IDHoaDonNhap=IDHoaDonNhap;
end
GO
-- Xóa Thông tin lap
create proc [dbo].[uspDeletethongtinlap]
@IDLap nvarchar(50)
as
	begin
		delete from ThongTinLap where @IDLap=IDLap;
	end
go
-- Xóa nhân viên
create proc [dbo].[uspDeletenhanvien]
@IDNhanVien nvarchar(50)
as
	begin
		delete from NhanVien where @IDNhanVien=IDNhanVien;
	end
go
-- Xóa Khách hàng
create proc dbo.uspDeletekhachhang
@IDKhachHang nvarchar(50)
as
	begin
		delete from KhachHang where @IDKhachHang=IDKhachHang;
	end
go
-- Xóa thông tin khuyến mãi
create proc dbo.uspDeletethongtinkhuyenmai
@IDKhuyenMai nvarchar(50)
as
	begin
		delete from ThongTinKhuyenMai where @IDKhuyenMai=IDThongTinKM;
	end
go
/****** Object:  StoredProcedure [dbo].[uspFixHoadon]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------
drop proc uspFixHoadon
go
-- Sửa hóa đơn bán
create proc [dbo].[uspFixHoadon]
	@IDHoaDonBan nvarchar(50),
	@IDLap nvarchar(50),
	@IDKhachHang nvarchar(50),
	@IDNhanVien nvarchar(50),
	@SoLuong int,
	@NgayBan datetime,
	@DonGia money,
	@Sdt nvarchar(50)
as
IF  @SoLuong>(SELECT SoLuong FROM ThongTinLap WHERE @IDLap=IDLap) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
IF	@IDHoaDonBan = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDKhachHang IS NULL OR @IDKhachHang = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDLap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
BEGIN
		UPDATE	HoaDonBan
		SET			
				IDLap=@IDLap,
				IDKhachHang=@IDKhachHang, 
				IDNhanVien=@IDNhanVien, 
				SoLuong=@SoLuong,
				NgayBan=@NgayBan,
				DonGia=@DonGia,
				Sdt=@Sdt
		WHERE	IDHoaDonBan = @IDHoaDonBan
		update ThongTinLap set SoLuong=SoLuong + (select SoLuong from HoaDonBan where ThongTinLap.IDLap=HoaDonBan.IDLap) where IDLap=IDLap
		update ThongTinLap set SoLuong=SoLuong-@SoLuong where IDLap=@IDLap
		update HoaDonBan set Sdt=(select Sdt from KhachHang where HoaDonBan.IDKhachHang=KhachHang.IDKhachHang) where IDKhachHang=@IDKhachHang
		update HoaDonBan set DonGia=0+(select DonGia from ThongTinLap where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDLap=@IDLap
		update HoaDonBan set TongTien=@SoLuong * (select DonGia
												  from ThongTinLap
												  where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDHoaDonBan=@IDHoaDonBan
	END
GO
/****** Object:  StoredProcedure [dbo].[uspFixhoadonnhap]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------
drop proc uspFixhoadonnhap
go
-- Sửa hóa đơn nhập
create proc [dbo].[uspFixhoadonnhap]
	@IDHoaDonNhap nvarchar(50),
	@IDNhaCC nvarchar(50),
	@IDNhanVien nvarchar(50),
	@IDLapNhap nvarchar(50),
	@TenLapNhap nvarchar(50),
	@SoLuong int,
	@NgayNhap datetime,
	@DonGia money,
	@TongTien money
as
IF	@IDHoaDonNhap = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDNhaCC IS NULL OR @IDNhaCC = '' THROW 50001, 'Mã nhà cung cấp không được để trống!', 1;
IF	@IDLapNhap IS NULL OR @IDLapNhap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
	BEGIN
		
		UPDATE	HoaDonNhap
		SET			
				IDNhanVien=@IDNhanVien,
				IDNhaCC=@IDNhaCC,				 
				IDLapNhap=@IDLapNhap,
				TenLapNhap=@TenLapNhap,
				SoLuong=@SoLuong,
				NgayNhap=@NgayNhap,
				DonGia=@DonGia,
				TongTien=@TongTien
		WHERE	IDHoaDonNhap = @IDHoaDonNhap
	END
GO

-------------------------
drop proc uspFixthongtinlap
go
--sửa thông tin lap
create proc [dbo].[uspFixthongtinlap]
	@IDLap nvarchar(50),
	@TenLap nvarchar(50),
	@IDNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50),
	@SoLuong int,
	@DonGia money,
	@ThongTin nvarchar(150)
as
	begin
		update ThongTinLap
		set			
			TenLap=@TenLap,			
			TenNhaCC=@TenNhaCC,
			SoLuong=@SoLuong,
			DonGia=@DonGia,
			ThongTin=@ThongTin
		where IDLap=@IDLap and IDNhaCC=@IDNhaCC
	end
go
--
drop proc dbo.uspFixnhanvien
go
-- sửa thông tin nhân viên
create proc [dbo].[uspFixnhanvien]
@IDNhanvien nvarchar(50),
	@TenNhanVien nvarchar(50),
	@GioiTinh nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@Sdt nvarchar(50)
as

if @TenNhanVien is null or @TenNhanVien='' throw 50001,'Tên nhân viên không được để trống!!',1;
if @GioiTinh is null or @GioiTinh='' throw 50001,'giới tính nhân viên không được để trống!!',1;
if @NgaySinh is null or @NgaySinh='' throw 50001,'Ngày sinh nhân viên không được để trống!!',1;
if @DiaChi is null or @DiaChi='' throw 50001,'Địa chỉ nhân viên không được để trống!!',1;
if @Sdt is null or @Sdt='' throw 50001,'Số điện thoại nhân viên không được để trống!!',1;
begin
	update NhanVien
	set 
		TenNhanVien=@TenNhanVien,
		GioiTinh=@GioiTinh,
		NgaySinh=@NgaySinh,
		DiaChi=@DiaChi,
		Sdt=@Sdt
	where IDNhanVien=@IDNhanvien
end
go
-- sửa thông tin khách hàng
create proc dbo.uspFixkhachhang
	@IDKhachHang nvarchar(50),
	@TenKhachHang nvarchar(50),
	@GioiTinh nvarchar(50),
	@DiaChi nvarchar(50),
	@Sdt nvarchar(50)
as
begin
	begin try
		begin tran
			update KhachHang
			set
				TenKhachHang=@TenKhachHang,
				GioiTinh=@GioiTinh,
				DiaChi=@DiaChi,
				Sdt=@Sdt
			where IDKhachHang=@IDKhachHang
		commit tran
			print 'Sửa thành công';
	end try
	begin catch
		rollback tran
		print 'lỗi rồi';
	end catch
end
go
-- sửa thông tin khuyến mãi
drop proc dbo.uspFixthongtinkhuyenmai
go
create proc dbo.uspFixthongtinkhuyenmai
	@IDThongTinKM nvarchar(50),
	@IDLap nvarchar(50),
	@KhuyenMai nvarchar(500)
as
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @KhuyenMai is null or @KhuyenMai='' throw 50001,'Thông tin khuyến mãi không được để trống!!!',1;
begin
	begin try
		begin tran
			update ThongTinKhuyenMai
			set
				IDLap=@IDLap,
				KhuyenMai=@KhuyenMai
			where IDThongTinKM=@IDThongTinKM
		commit tran
			print 'Sửa thành công!!'
	end try
	begin catch
		rollback tran
		print 'lỗi rồi';
	end catch
end
go
	
	


/****** Object:  StoredProcedure [dbo].[uspInserthoadon]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------
drop proc uspInserthoadon
go
-- Thêm hóa đơn bán
create proc [dbo].[uspInserthoadon]
@IDHoaDonBan nvarchar(50),@IDKhachHang nvarchar(50)=null,@IDNhanVien nvarchar(50)=null,@IDLap nvarchar(50)=null
,@SoLuong int =null,@NgayBan date =null,@Sdt nvarchar(50) =null,@ThongTinKhuyenMai nvarchar(500) =null,@DonGia money =null,@TongTien money =null
as
IF	EXISTS (SELECT * FROM HoaDonBan WHERE IDHoaDonBan = @IDHoaDonBan) THROW 50001, 'Mã hóa đơn đã tồn tại!', 1;
IF  @SoLuong>(SELECT SoLuong FROM ThongTinLap WHERE @IDLap=IDLap) THROW 50001,'Số lượng hàng trong kho không đủ!',1;

IF	@IDHoaDonBan = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDLap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
IF	@IDKhachHang IS NULL OR @IDKhachHang = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;

BEGIN

	INSERT HoaDonBan
	
	VALUES (@IDHoaDonBan, @IDLap ,@IDKhachHang, @IDNhanVien, @SoLuong, @NgayBan, @Sdt, @ThongTinKhuyenMai, @DonGia, @TongTien);
	update ThongTinLap set SoLuong=SoLuong-@SoLuong where IDLap=@IDLap
	update HoaDonBan set Sdt=(select Sdt from KhachHang where HoaDonBan.IDKhachHang=KhachHang.IDKhachHang) where IDKhachHang=@IDKhachHang
	update HoaDonBan set DonGia=0+(select DonGia from ThongTinLap where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDLap=@IDLap
	update HoaDonBan set TongTien=@SoLuong * (select DonGia
											  from ThongTinLap
											  where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDHoaDonBan=@IDHoaDonBan
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserthoadonnhap]    Script Date: 11/14/2019 11:52:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------
drop proc uspInserthoadonnhap
go
-- Thêm hóa đơn nhập
create proc [dbo].[uspInserthoadonnhap]
	@IDHoaDonNhap nvarchar(50),
	@IDNhaCC nvarchar(50)=null,
	@IDNhanVien nvarchar(50)=null,
	@IDLapNhap nvarchar(50)=null,
	@TenLapNhap nvarchar(50)=null,
	@SoLuong int=null,
	@NgayNhap date=null,
	@DonGia money=null,
	@TongTien money=null
as
if	exists (select * from HoaDonNhap where IDHoaDonNhap=@IDHoaDonNhap) throw 50001,'Mã hóa đơn đã tồn tại!',1;
IF	@IDHoaDonNhap = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDNhaCC IS NULL OR @IDNhaCC = '' THROW 50001, 'Mã nhà cung cấp không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDLapNhap IS NULL OR @IDLapNhap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
	begin
		insert HoaDonNhap
		values (@IDHoaDonNhap, @IDNhanVien, @IDNhaCC, @IDLapNhap,@TenLapNhap, @SoLuong, @NgayNhap, @DonGia, @TongTien);
		update ThongTinLap set SoLuong = SoLuong+@SoLuong where IDLap=@IDLapNhap
		update HoaDonNhap set TongTien = @DonGia * @SoLuong where IDHoaDonNhap=@IDHoaDonNhap
	end
GO
--thêm thông tin lap
create proc [dbo].[uspInsertthongtinlap]
	@IDLap nvarchar(50),
	@TenLap nvarchar(50)=null,
	@IDNhaCC nvarchar(50)=null,
	@TenNhaCC nvarchar(50)=null,
	@SoLuong int=null,
	@DonGia money=null,
	@ThongTin nvarchar(150)=null
as
if exists (select * from ThongTinLap where IDLap=@IDLap) throw 50001,'Mã laptop đã tồn tại!',1;
if @TenLap is null or @TenLap='' throw 50001,'Tên laptop không được để trống!',1;
if @IDNhaCC is null or @IDNhaCC='' throw 50001,'Mã nhà cung cấp không được để trống!',1;
if @TenNhaCC is null or @IDNhaCC='' throw 50001,'Tên nhà cung cấp không được để trống!',1;
if @SoLuong is null or @SoLuong='' throw 50001,'Số lượng không được để trống!',1;
if @DonGia is null or @DonGia ='' throw 50001,'Đơn giá không được để trống!',1;
begin
	insert ThongTinLap
	values (@IDLap,@TenLap,@IDNhaCC,@TenNhaCC,@SoLuong,@DonGia,@ThongTin);
end
go
--
drop proc dbo.uspInsertnhanvien
go
--Thêm Nhân viên
create proc [dbo].[uspInsertnhanvien]
	@IDNhanvien nvarchar(50),
	@TenNhanVien nvarchar(50)=null,
	@GioiTinh nvarchar(50)=null,
	@NgaySinh datetime =null,
	@DiaChi nvarchar(50)=null,
	@Sdt nvarchar(50)=null
as
if exists (select * from NhanVien where IDNhanVien=@IDNhanvien) throw 50001,'Mã nhân viên đã tồn tại!!',1;
if @TenNhanVien is null or @TenNhanVien='' throw 50001,'Tên nhân viên không được để trống!!',1;
if @GioiTinh is null or @GioiTinh='' throw 50001,'giới tính nhân viên không được để trống!!',1;
if @NgaySinh is null or @NgaySinh='' throw 50001,'Ngày sinh nhân viên không được để trống!!',1;
if @DiaChi is null or @DiaChi='' throw 50001,'Địa chỉ nhân viên không được để trống!!',1;
if @Sdt is null or @Sdt='' throw 50001,'Số điện thoại nhân viên không được để trống!!',1;
begin
	insert NhanVien
	values(@IDNhanvien,@TenNhanVien,@GioiTinh,@NgaySinh,@DiaChi,@Sdt);
end
go
--Thêm khách hang
create proc dbo.uspInsertkhachhang
	@IDKhachHang nvarchar(50),
	@TenKhachHang nvarchar(50)=null,
	@GioiTinh nvarchar(50)=null,
	@DiaChi nvarchar(50)=null,
	@Sdt nvarchar(50)=null
as
if exists (select * from KhachHang where IDKhachHang=@IDKhachHang) throw 50001,'Mã nhân viên đã tồn tại!!!',1;
if @TenKhachHang is null or @TenKhachHang='' throw 50001,'Tên khách hàng không được để trống!!!',1;
if @GioiTinh is null or @GioiTinh='' throw 50001,'giới tính khách hàng không được để trống!!!',1;
if @DiaChi is null or @DiaChi='' throw 50001,'Địa chỉ khách hàng không được để trống!!!',1;
if @Sdt is null or @DiaChi='' throw 50001,'Số điện thoại khách hàng không được để trống!!!',1;
begin
	begin try
		begin tran
			insert KhachHang
			values (@IDKhachHang,@TenKhachHang,@GioiTinh,@DiaChi,@Sdt);
		commit tran
			print 'Thêm thành công!!!';
	end try
	begin catch
		rollback tran
		print 'Lỗi rồi!!!';
	end catch
end
go
--thêm thông tin khuyến mãi
create proc dbo.uspInsertthongtinkhuyenmai
	@IDThongTinKM nvarchar(50),
	@IDLap nvarchar(50)=null,
	@KhuyenMai nvarchar(500)=null
as
if exists (select * from ThongTinKhuyenMai where IDThongTinKM=@IDThongTinKM) throw 50001,'Mã khuyến mãi đã tồn tại!!!',1;
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @KhuyenMai is null or @KhuyenMai='' throw 50001,'Thông tin khuyến mãi không được để trống!!!',1;
begin
	begin try
		begin tran
			insert ThongTinKhuyenMai
			values (@IDThongTinKM,@IDLap,@KhuyenMai);
		commit tran
			print 'Thêm thành công!!!';
	end try
	begin catch
		rollback tran
			print 'Lỗi rồi!!!';
	end catch
end
go
--
drop proc dbo.Searchkhachhang
go
--
create proc dbo.Searchkhachhang
@Key nvarchar(50)
as
begin
	select * from KhachHang where TenKhachHang like '%'+@key+'%';
end
go
--
create proc dbo.Searchkhachhang2
@Key nvarchar(50)
as
begin
	select * from KhachHang where IDKhachHang like '%'+@key+'%';
end
go

create proc dbo.Searchnhacungcap
@key nvarchar(50)
as
begin
	select * from NhaCC where IDNhaCC like '%'+@key+'%';
end
go

create proc dbo.Searchnhacungcap2
@key nvarchar(50)
as
begin
	select * from NhaCC where TenNhaCC like '%'+@key+'%';
end
go