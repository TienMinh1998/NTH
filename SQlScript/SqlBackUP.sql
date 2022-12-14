USE [DATN]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 21/09/2022 07:16:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Age] [bigint] NULL,
	[Address] [varchar](250) NULL,
	[AcountName] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

INSERT [dbo].[tbl_user] ([Id], [Name], [Age], [Address], [AcountName], [PassWord]) VALUES (1, N'CristianoRonalDo', 37, N' Portugal', N'admin', N'admin')
INSERT [dbo].[tbl_user] ([Id], [Name], [Age], [Address], [AcountName], [PassWord]) VALUES (2, N'Messi', 35, N'Aggentina', N'admin1', N'admin1')
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
GO
