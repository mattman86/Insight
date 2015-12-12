USE [Insight]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 8/21/2014 10:56:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[Position] [nvarchar](15) NULL,
	[Address1] [nvarchar](50) NULL,
	[Address2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](15) NULL,
	[Zip] [int] NULL,
	[MobilePhone] [nvarchar](15) NULL,
	[HomePhone] [nvarchar](15) NULL,
	[WorkPhone] [nvarchar](15) NULL,
	[Wage] [money] NULL,
	[Active] [bit] NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


