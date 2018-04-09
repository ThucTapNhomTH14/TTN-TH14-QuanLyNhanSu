use QuanLyNhanSu
go

create proc deleteNhanSu(@nhansu_id varchar(20))
as
begin
	delete from thongtincanhan
	where thongtincanhan.manv=@nhansu_id

	delete from luong
	where luong.manv = @nhansu_id
end