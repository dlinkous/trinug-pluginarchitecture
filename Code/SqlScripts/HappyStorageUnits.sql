USE [HappyStorage]
GO

/****** Object:  Table [dbo].[Units]    Script Date: 11/29/2017 1:32:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Units](
	[UnitNumber] [varchar](100) NOT NULL,
	[Length] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[IsClimateControlled] [bit] NOT NULL,
	[IsVehicleAccessible] [bit] NOT NULL,
	[PricePerMonth] [decimal](38, 2) NOT NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[UnitNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


