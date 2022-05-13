use BookDB
go
create procedure usp_ReturnBook
@rdID char(9),
@bkID char(9)
as
--判断有没有这本书
if not exists (select * from BookTable where @bkID in (select bkID from BookTable))
begin
raiserror('图书馆没有该书， 还书失败',16,1)WITH NOWAIT
return
end
--判断有没有这个读者 ID
if not exists (select * from reader where @rdID in (select rdID from reader))
begin
raiserror('图书馆没有该读者， 还书失败',16,1)WITH NOWAIT
return
end
--判断书是否在馆
declare @bkStatus int
select @bkStatus = bkStatus from BookTable where bkID = @bkID
if @bkStatus = 1
begin
raiserror('该书在馆， 无法归化',16,1)WITH NOWAIT
return
end
--借书开始（ 1.修改书的在馆状态， 2.修改读者的可借书数量， 3.删除借书记录）
update BookTable set bkStatus = 1 where bkID = @bkID
update reader set rdBorrowQty = rdBorrowQty - 1 where rdID = @rdID

DELETE FROM Borrow WHERE rdID = @rdID AND bkID=@bkID;
