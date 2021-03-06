USE [QuanLyNhanSu]
GO
/****** Object:  StoredProcedure [dbo].[getThongtincanhan]    Script Date: 3/9/2018 7:51:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getThongtincanhan]
as
begin
	select a.manv,a.tennv,a.cmnd,a.sdt,a.diachi,a.ngaysinh,b.tenphong,c.tentdhv
	from thongtincanhan as a
	inner join phongban as b on a.maphong = b.maphong
	inner join trinhdohocvan as c on a.tdhv = c.matdhv
end
GO

create or alter proc alsoThongtincanhan
as
begin
select manv,tennv,cmnd,sdt,diachi,ngaysinh,tenphong,tentdhv
from thongtincanhan
inner join phongban on phongban.maphong= thongtincanhan.maphong
inner join trinhdohocvan on trinhdohocvan.matdhv = thongtincanhan.tdhv
end
go


exec alsoThongtincanhan
exec getThongtincanhan