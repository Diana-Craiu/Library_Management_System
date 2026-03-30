USE [IPdataBase]
GO

/****** Object:  Table [dbo].[Carti]    Script Date: 12.05.2023 13:42:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Carti](
	[ISBN] [numeric](18, 0) NOT NULL,
	[Titlu] [nchar](100) NOT NULL,
	[Autor] [nchar](100) NULL,
	[Gen] [nchar](30) NOT NULL,
	[Editura] [nchar](30) NULL,
	[Nr_exemplare] [numeric](18, 0) NULL,
	[Status] [numeric](18, 0) NULL
) ON [PRIMARY]
GO


