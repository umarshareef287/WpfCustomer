USE [WPF_CUSTOMER]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 31-08-2024 21:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Type] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Mobile] [varchar](20) NULL,
	[Telephone] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Name], [Type], [Category], [Address], [Mobile], [Telephone], [Fax]) VALUES (1, N'Umar Shareef', N'New', N'Good', N'Suncity, Hyderabad. India', N'8978617853', N'123456789', N'987654321')
INSERT [dbo].[Customers] ([ID], [Name], [Type], [Category], [Address], [Mobile], [Telephone], [Fax]) VALUES (2, N'Arzaan Shareef', N'Old', N'Good', N'Mehdipatnam, Hyderabad. India', N'8106274316', N'123456789', N'987654321')
INSERT [dbo].[Customers] ([ID], [Name], [Type], [Category], [Address], [Mobile], [Telephone], [Fax]) VALUES (3, N'Shaik Naseer', N'New', N'Bad', N'Malaz, Saudi', N'8978617853', N'123456789', N'987654321')
INSERT [dbo].[Customers] ([ID], [Name], [Type], [Category], [Address], [Mobile], [Telephone], [Fax]) VALUES (4, N'Ahmed', N'New', N'Average', N'Chennai, India', N'9959400442', N'123456789', N'987654321')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
