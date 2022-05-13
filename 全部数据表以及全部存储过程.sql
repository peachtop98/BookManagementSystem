USE [BookDB]
GO
--首先要建一个数据库  BookDB，其次在运行该文件
/****** Object:  Table [dbo].[BookTable]    Script Date: 2022/5/13 15:12:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTable](
	[bkID] [char](10) NOT NULL,
	[bkName] [varchar](50) NOT NULL,
	[bkAuthor] [varchar](50) NULL,
	[bkPress] [varchar](50) NULL,
	[bkprice] [decimal](18, 0) NULL,
	[bkStatus] [int] NULL,
 CONSTRAINT [PK_图书表] PRIMARY KEY CLUSTERED 
(
	[bkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow](
	[rdID] [char](9) NOT NULL,
	[bkID] [char](9) NOT NULL,
	[DateBorrow] [datetime] NULL,
	[DateLendPlan] [datetime] NULL,
	[rdtypename1] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reader]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reader](
	[rdID] [char](9) NOT NULL,
	[rdType] [int] NULL,
	[rdNme] [varchar](25) NULL,
	[rdDept] [varchar](40) NULL,
	[rdQQ] [varchar](25) NULL,
	[rdBorrowQty] [int] NULL,
 CONSTRAINT [PK_读者表] PRIMARY KEY CLUSTERED 
(
	[rdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReaderType]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReaderType](
	[rdType] [int] NOT NULL,
	[rdTypeName] [varchar](20) NULL,
	[canLendQty] [int] NULL,
	[canLendDay] [int] NULL,
 CONSTRAINT [PK_读者类别表] PRIMARY KEY CLUSTERED 
(
	[rdType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[register]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](25) NULL,
	[Password] [nvarchar](25) NULL,
 CONSTRAINT [PK_登录表] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019001 ', N'kotlin', N'黑马程序员', N'人民邮电出版', CAST(60 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019002 ', N'Android移动', N'尚硅谷1', N'中信出版社', CAST(40 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019003 ', N'android企业', N'黑马', N'清华大学出版社', CAST(49 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019004 ', N'Java基础入门', N'传智播客', N'清华大学出版社', CAST(45 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[Borrow] ([rdID], [bkID], [DateBorrow], [DateLendPlan], [rdtypename1]) VALUES (N'rd2019002', N'bk2019001', CAST(N'2022-05-13T15:04:51.963' AS DateTime), CAST(N'2022-06-12T15:04:51.963' AS DateTime), N'连小美')
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'rd2019001', 1, N'江小白', N'计算机科学学院', N'XX', 2)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'rd2019002', 2, N'连小美', N'软件学院', N'黑马', 1)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'rd2019003', 3, N'王蒙', N'管理学院', N'759626', 0)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'rd2019004', 4, N'张思', N'工程学院', N'阿里巴巴', 0)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (1, N'教师', 10, 60)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (2, N'本科生', 2, 30)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (3, N'硕士研究生', 3, 40)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (4, N'博士', 8, 50)
GO
SET IDENTITY_INSERT [dbo].[register] ON 
GO
INSERT [dbo].[register] ([Id], [UserName], [Password]) VALUES (1, N'aaa', N'dqwd')
GO
INSERT [dbo].[register] ([Id], [UserName], [Password]) VALUES (2, N'cmlkashkdhas', N'seljflus')
GO
SET IDENTITY_INSERT [dbo].[register] OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_BorrowBook]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_BorrowBook]
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
from reader where rdID = @rdID)
declare @rdName varchar(50)
select @rdName = rdNme from reader where rdID = @rdID  --将名字传过去
insert into Borrow values(@rdID,@bkID,GETDATE(),DATEADD(dd,@canLendDay,GETDATE()),@rdName)
GO
/****** Object:  StoredProcedure [dbo].[usp_ReturnBook]    Script Date: 2022/5/13 15:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_ReturnBook]
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
raiserror('该书在馆， 无法归还',16,1)WITH NOWAIT
return
end
--借书开始（ 1.修改书的在馆状态， 2.修改读者的可借书数量， 3.删除借书记录）
update BookTable set bkStatus = 1 where bkID = @bkID
update reader set rdBorrowQty = rdBorrowQty - 1 where rdID = @rdID

DELETE FROM Borrow WHERE rdID = @rdID AND bkID=@bkID;
GO
