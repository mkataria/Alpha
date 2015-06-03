USE [Alpha]
GO

If exists (select 1 from sys.tables where name = 'Currencies')
	drop table Rates


/****** Object:  Table [dbo].[Rates]    Script Date: 04/15/2015 19:15:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Currencies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Currency1] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Currencies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

