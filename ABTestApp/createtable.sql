SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Note] [varchar](50) NULL,
	[USD] [decimal](18, 4) NULL,
	[GBP] [decimal](18, 4) NULL,
	[EUR] [decimal](18, 4) NULL,
	[CZK] [decimal](18, 4) NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
