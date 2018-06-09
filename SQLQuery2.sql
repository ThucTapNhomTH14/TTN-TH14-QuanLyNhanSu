

create or alter proc timNhanvien(
@tennv nvarchar(50),
@cmnd varchar(10),
@sdt varchar(11),
@diachi nvarchar(100),
@ngaysinh date,
@tenphong nvarchar(50),
@tentdhv nvarchar(10)
)
as
begin
select manv,tennv,cmnd,sdt,diachi,ngaysinh,tenphong,tentdhv
from thongtincanhan
inner join phongban on phongban.maphong= thongtincanhan.maphong
inner join trinhdohocvan on trinhdohocvan.matdhv = thongtincanhan.tdhv
inner join trinhdohocvan on trinhdohocvan.tentdhv like @tennv

where tennv like @tennv or cmnd like @cmnd or sdt like @sdt or diachi like @diachi or tenphong like @tenphong or tentdhv like tentdhv
end

exec timNhanvien '4','','','','','',''