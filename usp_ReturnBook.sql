use BookDB
go
create procedure usp_ReturnBook
@rdID char(9),
@bkID char(9)
as
--�ж���û���Ȿ��
if not exists (select * from BookTable where @bkID in (select bkID from BookTable))
begin
raiserror('ͼ���û�и��飬 ����ʧ��',16,1)WITH NOWAIT
return
end
--�ж���û��������� ID
if not exists (select * from reader where @rdID in (select rdID from reader))
begin
raiserror('ͼ���û�иö��ߣ� ����ʧ��',16,1)WITH NOWAIT
return
end
--�ж����Ƿ��ڹ�
declare @bkStatus int
select @bkStatus = bkStatus from BookTable where bkID = @bkID
if @bkStatus = 1
begin
raiserror('�����ڹݣ� �޷��黯',16,1)WITH NOWAIT
return
end
--���鿪ʼ�� 1.�޸�����ڹ�״̬�� 2.�޸Ķ��ߵĿɽ��������� 3.ɾ�������¼��
update BookTable set bkStatus = 1 where bkID = @bkID
update reader set rdBorrowQty = rdBorrowQty - 1 where rdID = @rdID

DELETE FROM Borrow WHERE rdID = @rdID AND bkID=@bkID;
