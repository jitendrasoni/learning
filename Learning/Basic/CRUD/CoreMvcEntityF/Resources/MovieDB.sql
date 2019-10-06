USE [Movie]
GO

/****** Object:  Table [dbo].[Movie]    Script Date: 10/6/2019 11:30:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movie](
	[Id] [int] NOT NULL,
	[Genre] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ReleaseDate] [datetime2](7) NOT NULL,
	[Title] [nvarchar](max) NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


