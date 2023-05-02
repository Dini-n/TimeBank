/****** Object:  Table [dbo].[Categories]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NOT NULL,
	[idCategory] [smallint] NOT NULL,
	[group] [bit] NULL,
	[minGroup] [smallint] NULL,
	[maxGroup] [smallint] NULL,
	[approved] [bit] NULL,
	[amountPeopleOffered] [smallint] NULL,
	[date] [nchar](10) NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberCategory]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberCategory](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[idMember] [smallint] NOT NULL,
	[idCategory] [smallint] NOT NULL,
	[place] [nchar](30) NULL,
	[possibilityComeCustomerHome] [bit] NULL,
	[experienceYears] [smallint] NULL,
	[restrictionsDescription] [nchar](30) NULL,
 CONSTRAINT [PK_MemberCategory] PRIMARY KEY CLUSTERED 
(
	[idMember] ASC,
	[idCategory] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [nchar](40) NOT NULL,
	[password] [nchar](8) NOT NULL,
	[mail] [nchar](40) NULL,
	[phone] [nchar](10) NOT NULL,
	[address] [nchar](50) NULL,
	[yearBorn] [date] NULL,
	[gender] [bit] NULL,
	[remainingHours] [time](7) NULL,
	[active] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[giverID] [smallint] NOT NULL,
	[categoryID] [smallint] NOT NULL,
	[date] [date] NOT NULL,
	[hour] [time](7) NOT NULL,
	[note] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportsDetails]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportsDetails](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[reportID] [smallint] NOT NULL,
	[memberID] [smallint] NOT NULL,
	[receiverApproved] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WaitingList]    Script Date: 2/3/2023 12:18:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WaitingList](
	[id] [smallint] NOT NULL,
	[idMember] [smallint] NULL,
	[idCategory] [smallint] NULL,
	[expiryDate] [date] NULL,
 CONSTRAINT [PK_WaitingList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
