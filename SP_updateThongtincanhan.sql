USE [QuanLyNhanSu]
GO
/****** Object:  StoredProcedure [dbo].[updateThongtincanhan]    Script Date: 3/19/2018 2:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateThongtincanhan] (@manv varchar(10),@tennv nvarchar(50),@cmnd varchar(10),@sdt varchar(11),@diachi nvarchar(100),@ngaysinh date,@maphong varchar(10),@tdhv int)
as
begin
	update thongtincanhan set 
	manv = @manv,
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
