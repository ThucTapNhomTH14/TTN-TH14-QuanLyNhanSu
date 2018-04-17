use [QuanLyNhanSu]
go
drop proc if exists themnhanvien
go
create proc themnhanvien (@manv varchar(10),@tennv nvarchar(50),@cmnd varchar(10)=null,@sdt varchar(10)=null,@diachi nvarchar(100) = null,@ngaysinh date = null,@phong varchar(10),@tdhv int)
as begin
if exists (select maphong from phongban where maphong=@phong)
and exists (select matdhv from trinhdohocvan where matdhv=@tdhv)
and not exists (select manv from thongtincanhan where manv=@manv)
insert into thongtincanhan (manv,tennv,cmnd,sdt,diachi,ngaysinh,maphong,tdhv)
values (@manv,@tennv,@cmnd,@sdt,@diachi,@ngaysinh,@phong,@tdhv)
end




