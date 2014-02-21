USE [atmstags_tst]
GO

/****** Object:  Table [dbo].[Conta]    Script Date: 21/02/2014 15:44:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Conta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Saldo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Conta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


