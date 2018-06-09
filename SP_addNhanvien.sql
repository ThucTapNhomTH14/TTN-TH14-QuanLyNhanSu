use QuanLyNhanSu
go

create or alter proc addNhanvien(
@tennv nvarchar(50),
@cmnd varchar(10),
@sdt varchar(11),
@diachi nvarchar(100),
@ngaysinh date,
@tenphong nvarchar(50),
@tentdhv nvarchar(10)
)
as begin
declare @manv varchar(10) = 'nv1'
declare @i int = 1
while exists (select manv from thongtincanhan where manv = @manv)
begin
select @i = @i +1
select @manv = 'nv'+ convert(varchar(10),@i)
end
insert into thongtincanhan
values(@manv, @tennv, @cmnd, @sdt, @diachi, @ngaysinh, @tenphong, @tentdhv)
end
go

exec addNhanvien N'a', N'', N'', N'','', N'PKT', 1
select * from thongtincanhan