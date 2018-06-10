USE [QuanLyNhanSu]
GO
INSERT [dbo].[phongban] ([maphong], [tenphong], [matruongphong]) VALUES (N'PKD', N'Phòng kinh doanh', N'nv001')
INSERT [dbo].[phongban] ([maphong], [tenphong], [matruongphong]) VALUES (N'PKT', N'Phòng kĩ thuật', N'nv004')
INSERT [dbo].[phongban] ([maphong], [tenphong], [matruongphong]) VALUES (N'PNC', N'Phòng nghiên cứu', N'nv002')
INSERT [dbo].[phongban] ([maphong], [tenphong], [matruongphong]) VALUES (N'PQLNS', N'Phòng quản lý nhân sự', N'nv005')
INSERT [dbo].[phongban] ([maphong], [tenphong], [matruongphong]) VALUES (N'PTC', N'Phòng tài chính', N'nv009')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (1, N'Trung cấp')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (2, N'Cao đẳng')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (3, N'Đại học')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (4, N'Cao học')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (5, N'Thạc sĩ')
INSERT [dbo].[trinhdohocvan] ([matdhv], [tentdhv]) VALUES (6, N'Tiến sĩ')
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv001', N'Tiến Chung', N'0000000001', N'', N'abcxyz', CAST(N'1997-05-02' AS Date), N'PKT', 3)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv002', N'Phạm Hồng Sơn', N'0000000002', N'', N'ghiklnm', CAST(N'1997-10-09' AS Date), N'PKT', 3)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv003', N'Đặng Đức Trung', N'0000000003', N'01237741050', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 3)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv004', N'Thằng số 4', N'0000000004', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 4)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv005', N'Thằng số 5', N'0000000005', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 2)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv006', N'Thằng số 6', N'0000000006', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 2)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv007', N'Thằng số 7', N'0000000007', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 1)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv008', N'Thằng số 8', N'0000000008', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 1)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv009', N'Thằng số 9', N'0000000009', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 4)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv010', N'Thằng số 10', N'0000000010', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 5)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv011', N'Thằng số 11', N'0000000011', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 5)
INSERT [dbo].[thongtincanhan] ([manv], [tennv], [cmnd], [sdt], [diachi], [ngaysinh], [maphong], [tdhv]) VALUES (N'nv012', N'Thằng số 12', N'0000000012', N'', N'Số 2 hẻm ....', CAST(N'1997-04-05' AS Date), N'PKT', 6)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv001', 20000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv002', 30000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv003', 10000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv004', 7000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv005', 5000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv006', 10000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv007', 9000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv008', 2000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv009', 60000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv010', 1000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv011', 9000000)
INSERT [dbo].[luong] ([manv], [luong]) VALUES (N'nv012', 3000000)

----xoa toan bo du lieu trong database
--EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 
--GO 

--EXEC sp_MSForEachTable 'DELETE FROM ?' 
--GO 

---- enable referential integrity again 
--EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL' 
--GO
