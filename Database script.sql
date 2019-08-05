USE [TTDB]
GO
/****** Object:  Table [dbo].[Artists]    Script Date: 5/08/2019 5:12:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists](
	[IdArtist] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](40) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[StartDate] [date] NOT NULL,
	[Email] [nchar](30) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Address] [nchar](40) NOT NULL,
 CONSTRAINT [PK__Persons__A5D4E15B6243526F] PRIMARY KEY CLUSTERED 
(
	[IdArtist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artists_Categories]    Script Date: 5/08/2019 5:12:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists_Categories](
	[IdArtist] [int] NOT NULL,
	[IdCategory] [int] NOT NULL,
	[Observation] [text] NULL,
 CONSTRAINT [PK_Person_Category] PRIMARY KEY CLUSTERED 
(
	[IdArtist] ASC,
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/08/2019 5:12:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[IdCategory] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](25) NOT NULL,
	[Details] [text] NOT NULL,
 CONSTRAINT [PK__Category__CBD747061D2A7AFE] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Artists_Categories]  WITH CHECK ADD  CONSTRAINT [FK__Person_Ca__IdCat__3B75D760] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Categories] ([IdCategory])
GO
ALTER TABLE [dbo].[Artists_Categories] CHECK CONSTRAINT [FK__Person_Ca__IdCat__3B75D760]
GO
ALTER TABLE [dbo].[Artists_Categories]  WITH CHECK ADD  CONSTRAINT [FK__Person_Ca__IdPer__3A81B327] FOREIGN KEY([IdArtist])
REFERENCES [dbo].[Artists] ([IdArtist])
GO
ALTER TABLE [dbo].[Artists_Categories] CHECK CONSTRAINT [FK__Person_Ca__IdPer__3A81B327]
GO
