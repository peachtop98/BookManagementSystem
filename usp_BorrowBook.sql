USE [BookDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_BorrowBook]    Script Date: 2022/5/13 14:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_BorrowBook]
@rdID char(9),
@bkID char(9)
as
--判断有没有这本书
if not exists (select * from BookTable where @bkID in (select bkID from BookTable))
begin
raiserror('图书馆没有该书， 借阅失败',16,1)WITH NOWAIT
return
end
--判断有没有这个读者 ID
if not exists (select * from reader where @rdID in (select rdID from reader))
begin
raiserror('图书馆没有该读者， 借阅失败',16,1)WITH NOWAIT
return
end
--判断书是否在馆
declare @bkStatus int
select @bkStatus = bkStatus from BookTable where bkID = @bkID
if @bkStatus = 0
begin
raiserror('该书不在馆， 无法借阅',16,1)WITH NOWAIT
return
end
--判断该读者的借书数量是否达到最大借书数量
declare @rdBorrowQty int,@canLendQty int
select @rdBorrowQty = rdBorrowQty from Reader where rdID = @rdID
select @canLendQty = canLendQty from ReaderType where rdType = (select rdType
from reader where rdID = @rdID)
if @rdBorrowQty = @canLendQty
begin
raiserror('抱歉！ 你所借书的数量已经达到最大借书数量！ 借阅失败！ ',16,1)WITH
NOWAIT
return
end
--借书开始（ 1.修改书的在馆状态， 2.修改读者的借书数量， 3.向借书表 Borrow 中插入数据）
update BookTable set bkStatus = 0 where bkID = @bkID
update reader set rdBorrowQty = rdBorrowQty + 1 where rdID = @rdID

declare @canLendDay int
select @canLendDay = canLendDay from ReaderType where rdType = (select rdType
from reader where rdID = @rdID)--通过rdID查到类型（rdType）进一步查到可借天数，将可借天数传给@canLendDay

declare @rdName varchar(50)
select @rdName = rdNme from reader where rdID = @rdID  --将名字传过去
insert into Borrow values(@rdID,@bkID,GETDATE(),DATEADD(dd,@canLendDay,GETDATE()),@rdName)