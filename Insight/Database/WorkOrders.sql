USE [Insight]
GO

/****** Object:  Table [dbo].[WorkOrders]    Script Date: 8/21/2014 10:57:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkOrders](
	[WorkOrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[Title] [nvarchar](200) NULL,
	[Description] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[Open] [bit] NULL,
	[Completed] [bit] NULL,
 CONSTRAINT [PK_WorkOrders] PRIMARY KEY CLUSTERED 
(
	[WorkOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


