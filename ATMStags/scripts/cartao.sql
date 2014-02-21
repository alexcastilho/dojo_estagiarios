USE [atmstags_tst]
GO

/****** Object:  Table [dbo].[Cartao]    Script Date: 21/02/2014 15:44:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cartao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataValidade] [datetime] NOT NULL,
 CONSTRAINT [PK_Cartao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


