USE [GPS]
GO
/****** 对象:  Table [dbo].[PathDetail]    脚本日期: 02/18/2011 22:11:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PathDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GPSSentence] [nvarchar](max) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Added_By] [nchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Added_On] [datetime] NULL CONSTRAINT [DF_PathDetail_Added_On]  DEFAULT (getdate()),
	[PathID] [int] NOT NULL,
 CONSTRAINT [PK_PathDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
