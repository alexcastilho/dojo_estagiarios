USE [atmstags_tst]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 21/02/2014 15:44:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sobrenome] [varchar](50) NOT NULL,
	[CPF] [varchar](11) NOT NULL,
	[RG] [varchar](11) NOT NULL,
	[Idade] [int] NOT NULL,
	[IdCartao] [int] NOT NULL,
	[IdConta] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cartao] FOREIGN KEY([IdCartao])
REFERENCES [dbo].[Cartao] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cartao]
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Conta] FOREIGN KEY([IdConta])
REFERENCES [dbo].[Conta] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Conta]
GO


