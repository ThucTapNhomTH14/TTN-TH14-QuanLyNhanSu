USE [QuanLyNhanSu]
GO
/****** Object:  StoredProcedure [dbo].[updateThongtincanhan]    Script Date: 3/19/2018 2:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create or alter proc [dbo].[updateThongtincanhan] (@manv varchar(10),@tennv nvarchar(50),@cmnd varchar(10),@sdt varchar(11),@diachi nvarchar(100),@ngaysinh date,@tenphong nvarchar(50),@tentdhv nvarchar(10))
as
begin
	declare @maphong varchar(50) = (select maphong from phongban where @tenphong = tenphong)
	declare @tdhv int = (select matdhv from trinhdohocvan where @tentdhv = tentdhv)
	update thongtincanhan set
	tennv = @tennv,
	cmnd = @cmnd,
	ngaysinh = @ngaysinh,
	diachi = @diachi,
	sdt = @sdt,
	maphong = @maphong,
	tdhv = @tdhv
	where manv = @manv
end
GO
