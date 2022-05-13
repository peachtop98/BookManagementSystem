CREATE DATABASE [BookDB]
USE [BookDB]
GO
/****** Object:  Table [dbo].[BookTable]    Script Date: 2022/5/13 8:21:24 ******/
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
/****** Object:  Table [dbo].[reader]    Script Date: 2022/5/13 8:21:24 ******/
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
/****** Object:  Table [dbo].[ReaderType]    Script Date: 2022/5/13 8:21:24 ******/
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
/****** Object:  Table [dbo].[register]    Script Date: 2022/5/13 8:21:24 ******/
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
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019001 ', N'kotlin', N'黑马程序员', N'人民邮电出版', CAST(60 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[BookTable] ([bkID], [bkName], [bkAuthor], [bkPress], [bkprice], [bkStatus]) VALUES (N'bk2019002 ', N'java', N'尚硅谷1', N'中信出版社', CAST(60 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'1        ', 12, N'XIANGXIN', N'XX', N'XX', 20)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'2        ', 2, N'腾讯有限', N'120', N'黑马', 10)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'3        ', 0, N'江西应用', N'', N'', 0)
GO
INSERT [dbo].[reader] ([rdID], [rdType], [rdNme], [rdDept], [rdQQ], [rdBorrowQty]) VALUES (N'4        ', 4, N'项鑫', N'富士康', N'阿里巴巴', 0)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (3, N'教师100', 10, 10)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (4, N'教授', 12, 12)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (5, N'家境贫寒的学生', 10, 10)
GO
INSERT [dbo].[ReaderType] ([rdType], [rdTypeName], [canLendQty], [canLendDay]) VALUES (55, N'学生', 10, 1)
GO
SET IDENTITY_INSERT [dbo].[register] ON 
GO
INSERT [dbo].[register] ([Id], [UserName], [Password]) VALUES (1, N'aaa', N'dqwd')
GO
INSERT [dbo].[register] ([Id], [UserName], [Password]) VALUES (2, N'cmlkashkdhas', N'seljflus')
GO
SET IDENTITY_INSERT [dbo].[register] OFF
GO
