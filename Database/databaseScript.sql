USE [DevbaseDatabaseChallenge]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22.11.2020 23:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22.11.2020 23:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [nvarchar](max) NOT NULL,
	[productUnitPrice] [int] NOT NULL,
	[productStockQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201122184022_Initial', N'5.0.0')
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (4, N'Asus Bilgisayar', 4500, 700)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (5, N'Casper Bilgisayar', 7800, 112)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (6, N'Iphone Telefon', 8500, 100)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (7, N'Samsung Telefon', 7800, 122)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (8, N'Samsung Galaxy', 7800, 4500)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (9, N'Xioami Mi Band 5', 2500, 450)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (10, N'Baymak Kombi', 8000, 500)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (11, N'Logitech Mouse', 300, 95)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (13, N'Huawei P20', 2800, 140)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (14, N'Huawei PSmart', 3000, 600)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (15, N'Iphone X', 9999, 444)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (16, N'AUC Monitör', 4500, 122)
INSERT [dbo].[Products] ([productID], [productName], [productUnitPrice], [productStockQuantity]) VALUES (17, N'Logitech Kulaklık', 4000, 140)
SET IDENTITY_INSERT [dbo].[Products] OFF
