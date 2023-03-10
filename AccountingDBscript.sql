--CREATE DATABASE SimpleAccount;
--GO
--USE SimpleAccount
--GO


--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ACCOUNTS')=0
--BEGIN
--CREATE TABLE [dbo].[ACCOUNTS](
--	[ACCOUNT_ID] [int] IDENTITY(1,1) NOT NULL,
--	[CONTROL_ACCOUNT_ID] [int] NOT NULL,
--	[ACCOUNT] [nvarchar](90) NULL,
--	[is_deleted] [bit] NULL,
-- CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
--(
--	[ACCOUNT_ID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO


--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ACCOUNTS_CONTROL')=0
--BEGIN
--CREATE TABLE [dbo].[ACCOUNTS_CONTROL](
--	[ID] [int] IDENTITY(1,1) NOT NULL,
--	[SUB_ACCOUNT_ID] [int] NOT NULL,
--	[ACCOUNT_CONTROL] [nvarchar](50) NULL,
-- CONSTRAINT [ACCOUNT_CONTROL] PRIMARY KEY CLUSTERED 
--(
--	[ID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ACCOUNTS_SUB_TYPE')=0
--BEGIN
--CREATE TABLE [dbo].[ACCOUNTS_SUB_TYPE](
--	[ID] [int] IDENTITY(1,1) NOT NULL,
--	[ACCOUNT_ID] [int] NOT NULL,
--	[ACCOUNT_SUB_TYPE] [nvarchar](50) NULL,
-- CONSTRAINT [ACCOUNT_SUB_TYPE] PRIMARY KEY CLUSTERED 
--(
--	[ID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ACCOUNTS_TYPE')=0
--BEGIN
--CREATE TABLE [dbo].[ACCOUNTS_TYPE](
--	[ID] [int] IDENTITY(1,1) NOT NULL,
--	[ACCOUNT_TYPE] [nvarchar](50) NULL,
-- CONSTRAINT [ACCOUNT_TYPE] PRIMARY KEY CLUSTERED 
--(
--	[ID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cash_Bank')=0
--BEGIN
--CREATE TABLE [dbo].[Cash_Bank](
--	[Id] [int] IDENTITY(1,1) NOT NULL,
--	[Cash_type] [nvarchar](50) NULL,
--	[Category] [nchar](10) NULL,
--	[Account_No] [nvarchar](50) NULL,
--	[is_deleted] [bit] NULL,
-- CONSTRAINT [PK_Cash_Bank] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Customers')=0
--BEGIN
--CREATE TABLE [dbo].[Customers](
--	[Cus_id] [int] IDENTITY(1,1) NOT NULL,
--	[Customer_name] [nvarchar](90) NULL,
--	[Phone] [nvarchar](50) NULL,
--	[Address] [nvarchar](150) NULL,
--	[is_deleted] [bit] NULL,
-- CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
--(
--	[Cus_id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO

--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'FIN_JOURNAL')=0
--BEGIN
--CREATE TABLE [dbo].[FIN_JOURNAL](
--	[FID] [int] IDENTITY(1,1) NOT NULL,
--	[FDate] [datetime] NULL,
--	[DR_Account_id] [int] NULL,
--	[CR_Account_id] [int] NULL,
--	[DR_Account_Type] [int] NULL,
--	[CR_Account_Type] [int] NULL,
--	[DESC] [nchar](100) NULL,
--	[FCredit] [decimal](18, 2) NULL,
--	[FDebit] [decimal](18, 2) NULL,
--	[is_deleted] [bit] NULL,
-- CONSTRAINT [PK_FINJOURNAL] PRIMARY KEY CLUSTERED 
--(
--	[FID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO


--IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TFinancials')=0
--BEGIN
--CREATE TABLE [dbo].[TFinancials](
--	[FID] [int] IDENTITY(1,1) NOT NULL,
--	[FDate] [datetime] NULL,
--	[CID] [int] NULL,
--	[Account_id] [int] NULL,
--	[Particular] [nchar](100) NULL,
--	[FCredit] [decimal](18, 2) NULL,
--	[FDebit] [decimal](18, 2) NULL,
--	[T_status] [nchar](10) NULL,
--	[Names] [nvarchar](150) NULL,
--	[Id] [int] NULL,
--	[is_deleted] [bit] NULL,
-- CONSTRAINT [PK_TFinancials] PRIMARY KEY CLUSTERED 
--(
--	[FID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO





INSERT INTO [Accounts_Type] VALUES('Asset');
INSERT INTO [Accounts_Type] VALUES('Liability');
INSERT INTO [Accounts_Type] VALUES('Equity');
INSERT INTO [Accounts_Type] VALUES('Income');
INSERT INTO [Accounts_Type] VALUES('Expense');


INSERT INTO [ACCOUNTS_SUB_TYPE] VALUES(5,'Direct Expenses');
INSERT INTO [ACCOUNTS_SUB_TYPE] VALUES(5,'Indirect Expenses');


INSERT INTO [ACCOUNTS_CONTROL]  VALUES(1,'KKA Expenses Control');
INSERT INTO [ACCOUNTS_CONTROL]  VALUES(1,'MFZ Expenses Control');
INSERT INTO [ACCOUNTS_CONTROL]  VALUES(1,'QF Expenses Control');

INSERT INTO [ACCOUNTS_CONTROL]  VALUES(2,'KKA Expenses Control');
INSERT INTO [ACCOUNTS_CONTROL]  VALUES(2,'MFZ Expenses Control');
INSERT INTO [ACCOUNTS_CONTROL]  VALUES(2,'QF Expenses Control');


