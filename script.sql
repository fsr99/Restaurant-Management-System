USE [FinalDB]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/20/2023 11:27:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeID] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodMenu]    Script Date: 12/20/2023 11:27:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodMenu](
	[ItemName] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/20/2023 11:27:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ItemName] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmployeeName], [EmployeeID]) VALUES (N'Farhan', N'22-47979-2')
INSERT [dbo].[Employee] ([EmployeeName], [EmployeeID]) VALUES (N'Akash', N'21-45114-2')
INSERT [dbo].[Employee] ([EmployeeName], [EmployeeID]) VALUES (N'Naorin', N'18-38538-2')
INSERT [dbo].[Employee] ([EmployeeName], [EmployeeID]) VALUES (N'Sadik', N'11111')
GO
INSERT [dbo].[FoodMenu] ([ItemName], [Price]) VALUES (N'Coffee', CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[FoodMenu] ([ItemName], [Price]) VALUES (N'Tea', CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[FoodMenu] ([ItemName], [Price]) VALUES (N'Tea', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[FoodMenu] ([ItemName], [Price]) VALUES (N'Biryani', CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Orders] ([ItemName], [Price]) VALUES (N'Coffee', CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[Orders] ([ItemName], [Price]) VALUES (N'Burger', CAST(150.00 AS Decimal(18, 2)))
GO
