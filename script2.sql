
USE [QLlaptop2]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[IDChucVu] [nvarchar](50) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
	[IDLuong] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[IDChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 12/2/2019 10:59:26 PM ******/
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
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 12/2/2019 10:59:26 PM ******/
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
	[NgayNhap] [date] NULL,
	[DonGia] [money] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongNhanVien]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongNhanVien](
	[IDLuong] [nvarchar](50) NOT NULL,
	[LuongCoban] [money] NULL,
	[LuongThuong] [money] NULL,
	[TongLuong] [money] NULL,
 CONSTRAINT [PK_LuongNhanVien] PRIMARY KEY CLUSTERED 
(
	[IDLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyUser]    Script Date: 12/2/2019 10:59:26 PM ******/
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
/****** Object:  Table [dbo].[NhaCC]    Script Date: 12/2/2019 10:59:26 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNhanVien] [nvarchar](50) NOT NULL,
	[IDChucVu] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomLap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomLap](
	[IDNhomLap] [nvarchar](50) NOT NULL,
	[TenNhomLap] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomLap] PRIMARY KEY CLUSTERED 
(
	[IDNhomLap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NuocSanXuat]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NuocSanXuat](
	[IDQuocGia] [nvarchar](50) NOT NULL,
	[IDLap] [nvarchar](50) NULL,
	[TenQuocGia] [nvarchar](50) NULL,
	[ThanhPhoSanXuat] [nvarchar](50) NULL,
 CONSTRAINT [PK_NuocSanXuat] PRIMARY KEY CLUSTERED 
(
	[IDQuocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTraGop]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraGop](
	[IDHoaDonTraGop] [nvarchar](50) NOT NULL,
	[IDLap] [nvarchar](50) NULL,
	[IDNhanVien] [nvarchar](50) NULL,
	[IDKhachHang] [nvarchar](50) NULL,
	[CMND] [int] NULL,
	[NgayBan] [date] NULL,
	[ThoiHanTraGop] [int] NULL,
	[TongTien] [money] NULL,
	[ThanhToanTruoc] [money] NULL,
	[TienTraMoiThang] [money] NULL,
	[TongTienSeTra] [money] NULL,
 CONSTRAINT [PK_PhieuTraGop] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonTraGop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinKhuyenMai]    Script Date: 12/2/2019 10:59:26 PM ******/
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
/****** Object:  Table [dbo].[ThongTinLap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinLap](
	[IDLap] [nvarchar](50) NOT NULL,
	[TenLap] [nvarchar](50) NULL,
	[IDNhomLap] [nvarchar](50) NULL,
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
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_ChucVu_LuongNhanVien] FOREIGN KEY([IDLuong])
REFERENCES [dbo].[LuongNhanVien] ([IDLuong])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_ChucVu_LuongNhanVien]
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
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([IDChucVu])
REFERENCES [dbo].[ChucVu] ([IDChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NuocSanXuat]  WITH CHECK ADD  CONSTRAINT [FK_NuocSanXuat_ThongTinLap] FOREIGN KEY([IDLap])
REFERENCES [dbo].[ThongTinLap] ([IDLap])
GO
ALTER TABLE [dbo].[NuocSanXuat] CHECK CONSTRAINT [FK_NuocSanXuat_ThongTinLap]
GO
ALTER TABLE [dbo].[PhieuTraGop]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraGop_KhachHang] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KhachHang] ([IDKhachHang])
GO
ALTER TABLE [dbo].[PhieuTraGop] CHECK CONSTRAINT [FK_PhieuTraGop_KhachHang]
GO
ALTER TABLE [dbo].[PhieuTraGop]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraGop_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[PhieuTraGop] CHECK CONSTRAINT [FK_PhieuTraGop_NhanVien]
GO
ALTER TABLE [dbo].[PhieuTraGop]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraGop_ThongTinLap] FOREIGN KEY([IDLap])
REFERENCES [dbo].[ThongTinLap] ([IDLap])
GO
ALTER TABLE [dbo].[PhieuTraGop] CHECK CONSTRAINT [FK_PhieuTraGop_ThongTinLap]
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
ALTER TABLE [dbo].[ThongTinLap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinLap_NhomLap] FOREIGN KEY([IDNhomLap])
REFERENCES [dbo].[NhomLap] ([IDNhomLap])
GO
ALTER TABLE [dbo].[ThongTinLap] CHECK CONSTRAINT [FK_ThongTinLap_NhomLap]
GO
/****** Object:  StoredProcedure [dbo].[Searchkhachhang]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Searchkhachhang]
@Key nvarchar(50)
as
begin
	select * from KhachHang where TenKhachHang like '%'+@key+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[Searchkhachhang2]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Searchkhachhang2]
@Key nvarchar(50)
as
begin
	select * from KhachHang where IDKhachHang like '%'+@key+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[Searchnhacungcap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Searchnhacungcap]
@key nvarchar(50)
as
begin
	select * from NhaCC where IDNhaCC like '%'+@key+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[Searchnhacungcap2]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Searchnhacungcap2]
@key nvarchar(50)
as
begin
	select * from NhaCC where TenNhaCC like '%'+@key+'%';
end
GO
--
create proc dbo.Searchnhanvien
@key nvarchar(50)
as
begin
	select * from NhanVien where IDNhanVien like '%'+@key+'%';
end
go
--
create proc dbo.Searchnhanvien2
@key nvarchar(50)
as
begin
	select * from NhanVien where TenNhanVien like '%'+@key+'%';
end
go
/****** Object:  StoredProcedure [dbo].[uspDeleteHoadon]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeleteHoadon
go
CREATE PROCEDURE [dbo].[uspDeleteHoadon]
	@IDHoaDonBan nvarchar(50)
AS
if @IDHoaDonBan is null or @IDHoaDonBan='' throw 50001,'Vui lòng nhập mã hóa đơn muốn xóa',1;
BEGIN	
	DELETE FROM HoaDonBan WHERE IDHoaDonBan = @IDHoaDonBan;
END
GO
/****** Object:  StoredProcedure [dbo].[uspDeletehoadonnhap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletehoadonnhap
go
create proc [dbo].[uspDeletehoadonnhap]
@IDHoaDonNhap nvarchar(50)
as
if @IDHoaDonNhap is null or @IDHoaDonNhap='' throw 50001,'Vui lòng nhập mã hóa đơn muốn xóa',1;
begin
	delete from HoaDonNhap where @IDHoaDonNhap=IDHoaDonNhap;
end
GO
/****** Object:  StoredProcedure [dbo].[uspDeletekhachhang]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletekhachhang
go
create proc [dbo].[uspDeletekhachhang]
@IDKhachHang nvarchar(50)
as
if @IDKhachHang is null or @IDKhachHang='' throw 50001,'Vui lòng nhập mã khách hàng muốn xóa',1;
	begin
		delete from KhachHang where @IDKhachHang=IDKhachHang;
	end
GO
/****** Object:  StoredProcedure [dbo].[uspDeletencc]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletencc
go
create proc [dbo].[uspDeletencc]
	@IDNhaCC nvarchar(50)
as
if @IDNhaCC is null or @IDNhaCC='' throw 50001,'Vui lòng nhập mã nhà cung cấp muốn xóa',1;
begin
	delete from NhaCC where @IDNhaCC=IDNhaCC;
end
GO
/****** Object:  StoredProcedure [dbo].[uspDeletenhanvien]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletenhanvien
go
create proc [dbo].[uspDeletenhanvien]
@IDNhanVien nvarchar(50)
as
if @IDNhanVien is null or @IDNhanVien='' throw 50001,'Vui lòng nhập mã nhân viên muốn xóa',1;
	begin
		delete from NhanVien where @IDNhanVien=IDNhanVien;
	end
GO
/****** Object:  StoredProcedure [dbo].[uspDeletethongtinkhuyenmai]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletethongtinkhuyenmai
go
create proc [dbo].[uspDeletethongtinkhuyenmai]
@IDKhuyenMai nvarchar(50)
as
if @IDKhuyenMai is null or @IDKhuyenMai='' throw 50001,'Vui lòng nhập mã khuyến mãi muốn xóa',1;
	begin
		delete from ThongTinKhuyenMai where @IDKhuyenMai=IDThongTinKM;
	end
GO
/****** Object:  StoredProcedure [dbo].[uspDeletethongtinlap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspDeletethongtinlap
go
create proc [dbo].[uspDeletethongtinlap]
@IDLap nvarchar(50)
as
if @IDLap is null or @IDLap='' throw 50001,'Vui lòng nhập mã laptop muốn xóa',1;
	begin
		delete from ThongTinLap where @IDLap=IDLap;
	end
GO
/****** Object:  StoredProcedure [dbo].[uspFixHoadon]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspFixHoadon
go
create proc [dbo].[uspFixHoadon]
	@IDHoaDonBan nvarchar(50),
	@IDLap nvarchar(50),
	@IDKhachHang nvarchar(50),
	@IDNhanVien nvarchar(50),
	@SoLuong int,
	@NgayBan date,
	@DonGia money,
	@Sdt nvarchar(50)
as
IF  @SoLuong>(SELECT SoLuong FROM ThongTinLap WHERE @IDLap=IDLap) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
IF	@IDKhachHang IS NULL OR @IDKhachHang = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDLap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
if  exists(select HoaDonBan.IDNhanVien 
		   from NhanVien inner join HoaDonBan on NhanVien.IDNhanVien=HoaDonBan.IDNhanVien
		   where IDChucVu='NVNH' and @IDNhanVien=NhanVien.IDNhanVien) throw 50001,'Nhân viên này không thuộc nhân viên bán hàng!',1; 
BEGIN
	begin tran
	begin try
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
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
	END
GO
/****** Object:  StoredProcedure [dbo].[uspFixhoadonnhap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspFixhoadonnhap
go
create proc [dbo].[uspFixhoadonnhap]
	@IDHoaDonNhap nvarchar(50),
	@IDNhaCC nvarchar(50),
	@IDNhanVien nvarchar(50),
	@IDLapNhap nvarchar(50),
	@TenLapNhap nvarchar(50),
	@SoLuong int,
	@NgayNhap date,
	@DonGia money,
	@TongTien money
as
IF	@IDHoaDonNhap = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDNhaCC IS NULL OR @IDNhaCC = '' THROW 50001, 'Mã nhà cung cấp không được để trống!', 1;
IF	@IDLapNhap IS NULL OR @IDLapNhap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
if  exists(select HoaDonNhap.IDNhanVien 
		   from NhanVien inner join HoaDonNhap on NhanVien.IDNhanVien=HoaDonNhap.IDNhanVien
		   where IDChucVu='NVBH' and @IDNhanVien=NhanVien.IDNhanVien) throw 50001,'Nhân viên này không thuộc nhân viên bán hàng!',1;
	BEGIN
	begin tran
	begin try
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
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
	END
GO
/****** Object:  StoredProcedure [dbo].[uspFixkhachhang]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspFixkhachhang
go
create proc [dbo].[uspFixkhachhang]
	@IDKhachHang nvarchar(50),
	@TenKhachHang nvarchar(50),
	@GioiTinh nvarchar(50),
	@DiaChi nvarchar(50),
	@Sdt nvarchar(50)
as
begin	
	begin tran
	begin try
		update KhachHang
		set
			TenKhachHang=@TenKhachHang,
			GioiTinh=@GioiTinh,
			DiaChi=@DiaChi,
			Sdt=@Sdt
		where IDKhachHang=@IDKhachHang
	commit			
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
/****** Object:  StoredProcedure [dbo].[uspFixncc]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspFixncc
go
create proc [dbo].[uspFixncc]
	@IDNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50),
	@DiaChi nvarchar(50),
	@Sdt nvarchar(50)
as
if @TenNhaCC='' or @TenNhaCC is null throw 50001,'Tên nhà cung cấp không được để trống!!!',1;
if @DiaChi='' or @DiaChi is null throw 50001,'Địa chỉ nhà cung cấp không được để trống!!!',1;
if @Sdt='' or @Sdt is null throw 50001,'Số điện thoại nhà cung cấp không được để trống!!!',1;
begin
	begin tran
	begin try
		update NhaCC
		set
			TenNhaCC=@TenNhaCC,
			DiaChi=@DiaChi,
			Sdt=@Sdt
		where IDNhaCC=@IDNhaCC
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspFixnhanvien]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
drop proc dbo.uspFixnhanvien
go
create proc [dbo].[uspFixnhanvien]
	@IDNhanvien nvarchar(50),
	@IDChucVu nvarchar(50),
	@TenNhanVien nvarchar(50),
	@GioiTinh nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@Sdt nvarchar(50)
as
if @IDChucVu is null or @IDChucVu='' throw 50001,'Mã chức vụ không được để trống!!',1;
if @TenNhanVien is null or @TenNhanVien='' throw 50001,'Tên nhân viên không được để trống!!',1;
if @GioiTinh is null or @GioiTinh='' throw 50001,'giới tính nhân viên không được để trống!!',1;
if @NgaySinh is null or @NgaySinh='' throw 50001,'Ngày sinh nhân viên không được để trống!!',1;
if @DiaChi is null or @DiaChi='' throw 50001,'Địa chỉ nhân viên không được để trống!!',1;
if @Sdt is null or @Sdt='' throw 50001,'Số điện thoại nhân viên không được để trống!!',1;
begin
	begin tran
	begin try
		update NhanVien
		set 
			IDChucVu=@IDChucVu,
			TenNhanVien=@TenNhanVien,
			GioiTinh=@GioiTinh,
			NgaySinh=@NgaySinh,
			DiaChi=@DiaChi,
			Sdt=@Sdt
		where IDNhanVien=@IDNhanvien
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspFixthongtinkhuyenmai]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspFixthongtinkhuyenmai
go
create proc [dbo].[uspFixthongtinkhuyenmai]
	@IDThongTinKM nvarchar(50),
	@IDLap nvarchar(50),
	@KhuyenMai nvarchar(500)
as
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @KhuyenMai is null or @KhuyenMai='' throw 50001,'Thông tin khuyến mãi không được để trống!!!',1;
begin	
	begin tran
	begin try
		update ThongTinKhuyenMai
		set
			IDLap=@IDLap,
			KhuyenMai=@KhuyenMai
		where IDThongTinKM=@IDThongTinKM
	commit tran	
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspFixthongtinlap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
drop proc dbo.uspFixthongtinlap
go
create proc [dbo].[uspFixthongtinlap]
	@IDLap nvarchar(50),
	@TenLap nvarchar(50),
	@IDNhomLap nvarchar(50),
	@IDNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50),
	@SoLuong int,
	@DonGia money,
	@ThongTin nvarchar(150)
as
if @TenLap is null or @TenLap='' throw 50001,'Tên lap không được để trống!!',1;
if @SoLuong is null or @SoLuong='' throw 50001,'Số lượng không được để trống!!',1;
if @DonGia is null or @DonGia='' throw 50001,'Đơn giá không được để trống',1;
	begin
	begin tran
	begin try
		update ThongTinLap
		set				
			TenLap=@TenLap,
			IDNhomLap=@IDNhomLap,
			IDNhaCC=@IDNhaCC,
			TenNhaCC=@TenNhaCC,
			SoLuong=@SoLuong,
			DonGia=@DonGia,
			ThongTin=@ThongTin
		where IDLap=@IDLap
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[uspInserthoadon]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspInserthoadon
go
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
if  exists(select HoaDonBan.IDNhanVien 
		   from NhanVien inner join HoaDonBan on NhanVien.IDNhanVien=HoaDonBan.IDNhanVien
		   where IDChucVu='NVNH' and @IDNhanVien=NhanVien.IDNhanVien) throw 50001,'Nhân viên này không thuộc nhân viên bán hàng!',1;
BEGIN
	begin tran
	begin try
		INSERT HoaDonBan	
		VALUES (@IDHoaDonBan, @IDLap ,@IDKhachHang, @IDNhanVien, @SoLuong, @NgayBan, @Sdt, @ThongTinKhuyenMai, @DonGia, @TongTien);
		update ThongTinLap set SoLuong=SoLuong-@SoLuong where IDLap=@IDLap
		update HoaDonBan set Sdt=(select Sdt from KhachHang where HoaDonBan.IDKhachHang=KhachHang.IDKhachHang) where IDHoaDonBan=@IDHoaDonBan
		update HoaDonBan set DonGia=0+(select DonGia from ThongTinLap where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDHoaDonBan=@IDHoaDonBan
		update HoaDonBan set TongTien=@SoLuong * (select DonGia
											  from ThongTinLap
											  where HoaDonBan.IDLap=ThongTinLap.IDLap) where IDHoaDonBan=@IDHoaDonBan
		update HoaDonBan set ThongTinKhuyenMai=(select KhuyenMai 
												from ThongTinKhuyenMai 
												where IDLap=@IDLap) where IDHoaDonBan=@IDHoaDonBan
	commit		
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message=N'Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserthoadonnhap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspInserthoadonnhap
go
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
if  exists(select HoaDonNhap.IDNhanVien 
		   from NhanVien inner join HoaDonNhap on NhanVien.IDNhanVien=HoaDonNhap.IDNhanVien
		   where IDChucVu='NVBH' and @IDNhanVien=NhanVien.IDNhanVien) throw 50001,'Nhân viên này không thuộc nhân viên bán hàng!',1;
IF	@IDHoaDonNhap = '' THROW 50001, 'Mã hóa đơn không được để trống!', 1;
IF	@IDNhaCC IS NULL OR @IDNhaCC = '' THROW 50001, 'Mã nhà cung cấp không được để trống!', 1;
IF	@IDNhanVien IS NULL OR @IDNhanVien='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
IF	@IDLapNhap IS NULL OR @IDLapNhap='' THROW 50001, 'Mã Laptop không được để trống!', 1;
begin
	begin tran
	begin try
		insert HoaDonNhap
		values (@IDHoaDonNhap, @IDNhanVien, @IDNhaCC, @IDLapNhap,@TenLapNhap, @SoLuong, @NgayNhap, @DonGia, @TongTien);
		update ThongTinLap set SoLuong = SoLuong+@SoLuong where IDLap=@IDLapNhap and DonGia=@DonGia
		update HoaDonNhap set TongTien = @DonGia * @SoLuong where IDHoaDonNhap=@IDHoaDonNhap
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspInsertkhachhang]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspInsertkhachhang
go
create proc [dbo].[uspInsertkhachhang]
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
if @GioiTinh<>'nam' or @GioiTinh<>'nữ' throw 50001,'Giới tính chỉ có thể là nam hoặc nữ!!!',1;
begin
	begin tran
	begin try
		insert KhachHang
		values (@IDKhachHang,@TenKhachHang,@GioiTinh,@DiaChi,@Sdt);
	commit tran			
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspInsertncc]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspInsertncc
go
create proc [dbo].[uspInsertncc]
	@IDNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50)=null,
	@DiaChi nvarchar(50)=null,
	@Sdt nvarchar(50)=null
as
if exists (select * from NhaCC where @IDNhaCC=IDNhaCC) throw 50001,'Mã nhà cung cấp đã tồn tại!!!',1;
if @TenNhaCC='' or @TenNhaCC is null throw 50001,'Tên nhà cung cấp không được để trống!!!',1;
if @DiaChi='' or @DiaChi is null throw 50001,'Địa chỉ nhà cung cấp không được để trống!!!',1;
if @Sdt='' or @Sdt is null throw 50001,'Số điện thoại nhà cung cấp không được để trống!!!',1;
begin
	begin tran
	begin try
		insert NhaCC
		values(@IDNhaCC,@TenNhaCC,@DiaChi,@Sdt);
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspInsertnhanvien]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
drop proc dbo.uspInsertnhanvien
go
create proc [dbo].[uspInsertnhanvien]
	@IDNhanvien nvarchar(50),
	@IDChucVu nvarchar(50)=null,
	@TenNhanVien nvarchar(50)=null,
	@GioiTinh nvarchar(50)=null,
	@NgaySinh datetime =null,
	@DiaChi nvarchar(50)=null,
	@Sdt nvarchar(50)=null
as
if exists (select * from NhanVien where IDNhanVien=@IDNhanvien) throw 50001,'Mã nhân viên đã tồn tại!!',1;
if @IDChucVu is null or @IDChucVu='' throw 50001,'Tên nhân viên không được để trống!!',1;
if @TenNhanVien is null or @TenNhanVien='' throw 50001,'Tên nhân viên không được để trống!!',1;
if @GioiTinh is null or @GioiTinh='' throw 50001,'giới tính nhân viên không được để trống!!',1;
if @NgaySinh is null or @NgaySinh='' throw 50001,'Ngày sinh nhân viên không được để trống!!',1;
if @DiaChi is null or @DiaChi='' throw 50001,'Địa chỉ nhân viên không được để trống!!',1;
if @Sdt is null or @Sdt='' throw 50001,'Số điện thoại nhân viên không được để trống!!',1;
if @GioiTinh <>'nam' or @GioiTinh <>'nữ' throw 50001,'Giới tính chỉ có thể là nam hoặc nữ!!',1;
begin
	begin tran
	begin try
		insert NhanVien
		values(@IDNhanvien,@IDChucVu,@TenNhanVien,@GioiTinh,@NgaySinh,@DiaChi,@Sdt);
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
/****** Object:  StoredProcedure [dbo].[uspInsertthongtinkhuyenmai]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop proc dbo.uspInsertthongtinkhuyenmai
go
create proc [dbo].[uspInsertthongtinkhuyenmai]
	@IDThongTinKM nvarchar(50),
	@IDLap nvarchar(50)=null,
	@KhuyenMai nvarchar(500)=null
as
if exists (select * from ThongTinKhuyenMai where IDThongTinKM=@IDThongTinKM) throw 50001,'Mã khuyến mãi đã tồn tại!!!',1;
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @KhuyenMai is null or @KhuyenMai='' throw 50001,'Thông tin khuyến mãi không được để trống!!!',1;
begin
	begin tran
	begin try
		insert ThongTinKhuyenMai
		values (@IDThongTinKM,@IDLap,@KhuyenMai);
	commit tran			
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspInsertthongtinlap]    Script Date: 12/2/2019 10:59:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
drop proc dbo.uspInsertthongtinlap
go
create proc [dbo].[uspInsertthongtinlap]
	@IDLap nvarchar(50),
	@TenLap nvarchar(50)=null,
	@IDNhomLap nvarchar(50)=null,
	@IDNhaCC nvarchar(50)=null,
	@TenNhaCC nvarchar(50)=null,
	@SoLuong int=null,
	@DonGia money=null,
	@ThongTin nvarchar(150)=null
as
if exists (select * from ThongTinLap where IDLap=@IDLap) throw 50001,'Mã laptop đã tồn tại!',1;
if @TenLap is null or @TenLap='' throw 50001,'Tên laptop không được để trống!',1;
if @IDNhomLap is null or @IDNhomLap='' throw 50001,'Nhóm lap không được để trống!',1;
if @IDNhaCC is null or @IDNhaCC='' throw 50001,'Mã nhà cung cấp không được để trống!',1;
if @TenNhaCC is null or @IDNhaCC='' throw 50001,'Tên nhà cung cấp không được để trống!',1;
if @SoLuong is null or @SoLuong='' throw 50001,'Số lượng không được để trống!',1;
if @DonGia is null or @DonGia ='' throw 50001,'Đơn giá không được để trống!',1;
begin
	begin tran
	begin try
		insert ThongTinLap
		values (@IDLap,@TenLap,@IDNhomLap,@IDNhaCC,@TenNhaCC,@SoLuong,@DonGia,@ThongTin);
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
GO

-- thanh toán trả góp
--thêm
drop proc dbo.uspInserthoadontg
go

create proc dbo.uspInserthoadontg
	@IDHoaDonTraGop	nvarchar(50),
	@IDLap nvarchar(50)=null,
	@IDNhanVien	nvarchar(50)=null,
	@IDKhachHang nvarchar(50)=null,
	@CMND int=null,	
	@NgayBan date=null,
	@ThoiHanTraGop int=null,
	@TongTien money=null,
	@ThanhToanTruoc	money=null,
	@TienTraMoiThang money=null,
	@TongTienSeTra money=null
as
if exists(select * from PhieuTraGop where @IDHoaDonTraGop=IDHoaDonTraGop) throw 50001,'Mã hóa đơn này đã tồn tại!!',1;
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @IDNhanVien is null or @IDNhanVien='' throw 50001,'Mã nhân viên không được để trống!!!',1;
if @IDKhachHang is null or @IDKhachHang='' throw 50001,'Mã khách hàng không được để trống!!!',1;
if @CMND is null or @CMND='' throw 50001,'Chứng minh nhân dân không được để trống!!!',1;
if @NgayBan is null or @NgayBan='' throw 50001,'Ngày bán không được để trống!!!',1;
if @ThoiHanTraGop is null or @ThoiHanTraGop='' throw 50001,'Thời hạn trả góp không được để trống!!!',1;
if @ThanhToanTruoc is null or @ThanhToanTruoc='' throw 50001,'Thanh toán trước không được để trống!!!',1;

begin
	begin tran
	begin try
		insert PhieuTraGop
		values(@IDHoaDonTraGop,@IDLap,@IDNhanVien,@IDKhachHang,@CMND,@NgayBan,@ThoiHanTraGop,@TongTien,@ThanhToanTruoc,@TienTraMoiThang,@TongTienSeTra);
		update ThongTinLap
		set SoLuong=SoLuong-1 where IDLap=@IDLap
		update PhieuTraGop 
		set  TongTienSeTra=@TongTien+((select DonGia from ThongTinLap where IDLap=@IDLap)*0.05)
		where IDHoaDonTraGop=@IDHoaDonTraGop
		update PhieuTraGop
		set TienTraMoiThang=(TongTienSeTra-@ThanhToanTruoc)/@ThoiHanTraGop
		where IDHoaDonTraGop=@IDHoaDonTraGop
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
-- sửa
drop proc dbo.uspFixhoadontg
go
--
create proc dbo.uspFixhoadontg
	@IDHoaDonTraGop	nvarchar(50),
	@IDLap nvarchar(50),
	@IDNhanVien	nvarchar(50),
	@IDKhachHang nvarchar(50),
	@CMND int,	
	@NgayBan date,
	@ThoiHanTraGop int,
	@TongTien money,
	@ThanhToanTruoc	money,
	@TienTraMoiThang money,
	@TongTienSeTra money
as
if @IDLap is null or @IDLap='' throw 50001,'Mã laptop không được để trống!!!',1;
if @IDNhanVien is null or @IDNhanVien='' throw 50001,'Mã nhân viên không được để trống!!!',1;
if @IDKhachHang is null or @IDKhachHang='' throw 50001,'Mã khách hàng không được để trống!!!',1;
if @CMND is null or @CMND='' throw 50001,'Chứng minh nhân dân không được để trống!!!',1;
if @NgayBan is null or @NgayBan='' throw 50001,'Ngày bán không được để trống!!!',1;
if @ThoiHanTraGop is null or @ThoiHanTraGop='' throw 50001,'Thời hạn trả góp không được để trống!!!',1;
if @ThanhToanTruoc is null or @ThanhToanTruoc='' throw 50001,'Thanh toán trước không được để trống!!!',1;

begin
	begin tran
	begin try
		update PhieuTraGop
		set
			IDLap=@IDLap,
			IDNhanVien=@IDNhanVien,
			IDKhachHang=@IDKhachHang,
			CMND=@CMND,				
			NgayBan=@NgayBan,
			ThoiHanTraGop=@ThoiHanTraGop,
			TongTien=@TongTien,
			ThanhToanTruoc=@ThanhToanTruoc,
			TienTraMoiThang=TienTraMoiThang,
			TongTienSeTra=@TongTienSeTra
		where IDHoaDonTraGop=@IDHoaDonTraGop
		update PhieuTraGop 
		set  TongTienSeTra=@TongTien+((select DonGia from ThongTinLap where IDLap=@IDLap)*0.05)
		where IDHoaDonTraGop=@IDHoaDonTraGop
		update PhieuTraGop
		set TienTraMoiThang=(TongTienSeTra-@ThanhToanTruoc)/@ThoiHanTraGop
		where IDHoaDonTraGop=@IDHoaDonTraGop
	commit
	end try
	begin catch
		rollback tran
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
--xóa
create proc dbo.uspDeletehoadontg
	@IDHoaDonTraGop nvarchar(50)
as
begin
	delete from PhieuTraGop where @IDHoaDonTraGop=IDHoaDonTraGop
end
go

-- tra cứu theo tháng hóa đơn bán
drop proc dbo.uspThongkehoadonban
go
CREATE PROCEDURE dbo.uspThongkehoadonban
@Month int
AS
BEGIN
	SELECT A.IDHoaDonBan,B.TenLap,A.SoLuong,A.TongTien
	FROM HoaDonBan A,ThongTinLap B
	WHERE  Month(NgayBan)=@Month and A.IDLap=B.IDLap
	group by A.IDHoaDonBan,B.TenLap,A.SoLuong,A.TongTien
END
GO

drop view dbo.Xemthongkeban
go
create proc dbo.Xemthongkeban
as
	select HoaDonBan.IDHoaDonBan,ThongTinLap.TenLap,HoaDonBan.SoLuong,HoaDonBan.TongTien 
	from HoaDonBan inner join ThongTinLap on HoaDonBan.IDLap=ThongTinLap.IDLap
	where HoaDonBan.TongTien>0;
go
--
drop proc dbo.tongtien
go
create proc dbo.TongTien
@Month int
as
begin
	select sum(TongTien) as tongtien
	from HoaDonBan
	where month(NgayBan)=@Month
end
go

-- Nhập
drop proc dbo.uspThongkehoadonnhap
go
create proc dbo.uspThongkehoadonnhap
@Month int
AS
BEGIN
	SELECT IDHoaDonNhap,IDLapNhap,SoLuong,TongTien
	FROM HoaDonNhap
	WHERE  Month(NgayNhap)=@Month	
END
GO
drop proc dbo.XemthongkeNhap
go
create proc dbo.Xemthongkenhap
as
	select IDHoaDonNhap,IDLapNhap,SoLuong,TongTien
	from HoaDonNhap
	where HoaDonNhap.TongTien>0;
go
--
drop proc dbo.TongTienNhap
go
create proc dbo.TongTienNhap
@Month int
as
begin
	select sum(TongTien) as tongtien
	from HoaDonNhap
	where month(NgayNhap)=@Month
end
go
--
drop proc dbo.uspThongkehoadontg
go
create proc dbo.uspThongkehoadontg
@Month int
AS
BEGIN
	SELECT A.IDHoaDonTraGop,B.TenLap,A.ThanhToanTruoc,(A.TongTienSeTra-A.ThanhToanTruoc) as TienConThieu
	FROM PhieuTraGop A inner join ThongTinLap B on A.IDLap=B.IDLap
	WHERE  Month(NgayBan)=@Month
END
GO
drop proc dbo.uspThongketg
go
create proc dbo.uspThongketg
as
	select A.IDHoaDonTraGop,B.TenLap,A.ThanhToanTruoc,(A.TongTienSeTra-A.ThanhToanTruoc) as TienConThieu
	from PhieuTraGop A inner join ThongTinLap B on A.IDLap=B.IDLap
	where A.ThanhToanTruoc>0;
go
--
drop proc dbo.uspTongtientratrc
go
create proc dbo.uspTongtientratrc
@Month int
as
begin
	select sum(ThanhToanTruoc) as thanhtoantruoc
	from PhieuTraGop
	where month(NgayBan)=@Month
end
go
drop proc dbo.uspTongtienthieu
go
create proc dbo.uspTongtienthieu
@Month int
as
begin
	select sum(TongTienSeTra-ThanhToanTruoc) as tienconthieu
	from PhieuTraGop
	where month(NgayBan)=@Month
end
go
drop proc dbo.uspLuong
go
create proc dbo.uspLuong
as
begin
	select a.IDNhanVien,a.TenNhanVien,b.TenChucVu,c.TongLuong
	from NhanVien A inner join ChucVu B on a.IDChucVu=b.IDChucVu inner join LuongNhanVien C on b.IDLuong=c.IDLuong
end
go
-- tài khoản
drop proc uspLayuser
go
create proc dbo.uspLayuser
as
begin
	select * from MyUser
end
go
drop proc dbo.uspInsertuser
go
create proc dbo.uspInsertuser
@id nvarchar(50),
@password nvarchar(30)=null,
@PhanQuyen int=null
as
if exists(select * from MyUser where @id=id) throw 50001,'ID này đã tồn tại vui lòng nhập lại!!',1;
if @password is null or @password='' throw 50001,'Mật khẩu không được đê trống!!',1;
if @PhanQuyen is null or @PhanQuyen='' throw 50001,'Phân quyền không được đê trống!!',1;
begin
	begin transaction
	begin try
		insert MyUser
		values(@id,@password,@PhanQuyen)
	commit
	end try
	begin catch
		rollback transaction
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go

drop proc dbo.uspFixuser
go
create proc dbo.uspFixuser
@id nvarchar(50),
@password nvarchar(30),
@PhanQuyen int
as
if @password is null or @password='' throw 50001,'Mật khẩu không được đê trống!!',1;
if @PhanQuyen is null or @PhanQuyen='' throw 50001,'Phân quyền không được đê trống!!',1;
begin
	begin transaction
	begin try
		update MyUser
		set
			password=@password,
			PhanQuyen=@PhanQuyen
			where id=@id
	commit
	end try
	begin catch
		rollback transaction
		declare @message nvarchar(1000)
		select @message='Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
-- Xem thông tin laptop
create proc dbo.uspLaythongtinlap
as
begin
	select * from ThongTinLap
end
go
-- Xem thông tin nhân viên
create proc dbo.uspLaynhanvien
as
begin
	select * from NhanVien
end
go
-- Xem thông tin nhà cung cấp
create proc dbo.uspLaynhacc
as
begin
	select * from NhaCC
end
go
-- Xem thông tin hóa đơn bán
create proc dbo.uspLayhoadonban
as
begin
	select * from HoaDonBan
end
go
-- Xem thông tin hóa đơn nhập
create proc dbo.uspLayhoadonnhap
as
begin
	select * from HoaDonNhap
end
go
-- Xem thông tin hóa đơn trả góp
create proc dbo.uspLayhoadontg
as
begin
	select * from PhieuTraGop
end
go
-- Xem thông tin khuyến mãi
create proc dbo.uspLaythongtinkm
as
begin
	select * from ThongTinKhuyenMai
end
go
-- Xem thông tin khách hàng
create proc dbo.uspLaykhachhang
as
begin
	select * from KhachHang
end
go
-- Xem thông tin chức vụ
create proc dbo.uspLaychucvu
as
begin
	select * from ChucVu
end
go
-- lấy đơn giá lên hóa đơn bán
create proc dbo.uspLaydongiahdb
@IDLap nvarchar(50)
as
begin
	select DonGia
	from ThongTinLap
	where IDLap=@IDLap
end
go
drop proc dbo.uspLaytongtienhdb
go
create proc dbo.uspLaytongtienhdb
@SoLuong int,
@IDlap nvarchar(50)
as
begin
	select (DonGia*@SoLuong) as tongtien
	from ThongTinLap
	where @IDlap=IDLap
end
go

-- lấy thông tin sdt khách lên hóa đơn bán
create proc dbo.uspLaysdthdb
@idkhach nvarchar(50)
as
begin
	select Sdt
	from KhachHang
	where @idkhach=IDKhachHang
end
go
-- lấy thông tin tổng tiền hóa đơn nhập
drop proc dbo.uspLaytongtienhdn
go
create proc dbo.uspLaytongtienhdn
@soluong int,
@dongia money
as
begin
	select(@soluong*@dongia) as tongtien
end
go

---
drop proc dbo.uspLaynhomlap
go
create proc dbo.uspLaynhomlap
as
begin
	select * from NhomLap
end
go

create proc dbo.uspInsertnhomlap
@id nvarchar(50),
@ten nvarchar(50)=null
as
if exists(select * from NhomLap where @id=TenNhomLap) throw 50001,'Mã hóa đơn này đã tồn tại!!',1;
if @ten is null or @ten='' throw 50001,'Tên nhóm lap không được để trống',1;
begin
	begin transaction
	begin try
		insert NhomLap
		values (@id,@ten)
	commit
	end try
	begin catch
		rollback transaction
		declare @message nvarchar(1000)
		select @message=N'Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
drop proc dbo.uspFixnhomlap
go
create proc dbo.uspFixnhomlap
@id nvarchar(50),
@ten nvarchar(50)
as
if @ten is null or @ten='' throw 50001,'Tên nhóm lap không được để trống',1;
begin
	begin transaction
	begin try
		update NhomLap
		set
			TenNhomLap=@ten
		where IDNhomLap=@id
	commit
	end try
	begin catch
		rollback transaction
		declare @message nvarchar(1000)
		select @message=N'Không thể thực thi vì không đáp ứng đủ điều kiện!!!!'
		raiserror(@message,16,1)
	end catch
end
go
create proc dbo.uspDeletenhomlap
@id nvarchar(50)
as
begin
	delete from NhomLap where @id=IDNhomLap
end
go