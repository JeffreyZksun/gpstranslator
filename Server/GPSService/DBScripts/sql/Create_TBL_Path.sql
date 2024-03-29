USE [GPS]
GO
/****** 对象:  Table [dbo].[Path]    脚本日期: 02/18/2011 22:10:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Path](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Password] [nchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Added_By] [nchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Added_On] [datetime] NULL CONSTRAINT [DF_Path_Added_On]  DEFAULT (getdate()),
	[Modified_By] [nchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Modified_On] [datetime] NULL,
	[Visible] [bit] NOT NULL CONSTRAINT [DF_Path_Visible]  DEFAULT ((1)),
 CONSTRAINT [PK_Path] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
