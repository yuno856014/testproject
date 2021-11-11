USE [master]
GO
/****** Object:  Database [StudentManagement]    Script Date: 11/11/2021 16:59:54 ******/
CREATE DATABASE [StudentManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StudentManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StudentManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StudentManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StudentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StudentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManagement] SET QUERY_STORE = OFF
GO
USE [StudentManagement]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BellNotification]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BellNotification](
	[Id] [int] NOT NULL,
	[DateCreated] [datetime] NULL,
	[IsRead] [bit] NULL,
	[NotifiId] [int] NULL,
 CONSTRAINT [PK_BellNotification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[Activities] [nvarchar](250) NULL,
	[Act] [nvarchar](250) NULL,
	[PowerExerted] [nvarchar](250) NULL,
	[PowerDev] [nvarchar](250) NULL,
	[Think] [nchar](10) NULL,
	[ListEventId] [int] NULL,
	[SchoolYear] [nvarchar](250) NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListEvents]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListEvents](
	[ListEventId] [int] IDENTITY(1,1) NOT NULL,
	[ListEventName] [nvarchar](250) NULL,
	[Icon] [nvarchar](250) NULL,
 CONSTRAINT [PK_ListEvents] PRIMARY KEY CLUSTERED 
(
	[ListEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessagesId] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](500) NULL,
	[Timestamp] [date] NULL,
	[EventId] [int] NULL,
	[UserId] [nvarchar](450) NULL,
	[SkillId] [int] NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[MessagesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchoolYears]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolYears](
	[SchoolYearId] [int] IDENTITY(1,1) NOT NULL,
	[SchoolYearName] [nvarchar](250) NULL,
 CONSTRAINT [PK_SchoolYears] PRIMARY KEY CLUSTERED 
(
	[SchoolYearId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[SkillId] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](250) NULL,
	[Style] [nvarchar](250) NULL,
	[Tags] [nvarchar](50) NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[SkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[Phone] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[CreateDate] [date] NULL,
	[LastLogin] [date] NULL,
	[Avatar] [nvarchar](250) NULL,
	[ScholasticId] [int] NULL,
	[ParentId] [int] NULL,
	[bellNotifiId] [int] NULL,
	[UserName] [nvarchar](250) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](250) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserSchoolYears]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSchoolYears](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[ScholYearId] [int] NULL,
 CONSTRAINT [PK_UserSchoolYears] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 11/11/2021 16:59:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211111042114_UpdateIdentity', N'5.0.12')
GO
SET IDENTITY_INSERT [dbo].[ListEvents] ON 

INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (1, N'Swimmer', N'fas fa-swimmer')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (2, N'Football', N'fas fa-futbol')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (3, N'Baseball Ball', N'fas fa-baseball-ball')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (4, N'Volleyball Ball', N'fas fa-volleyball-ball')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (5, N'Sing', N'fas fa-microphone')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (6, N'Read', N'fas fa-book')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (7, N'Chess', N'fas fa-chess-knight')
INSERT [dbo].[ListEvents] ([ListEventId], [ListEventName], [Icon]) VALUES (8, N'Table Tennis', N'fas fa-table-tennis
')
SET IDENTITY_INSERT [dbo].[ListEvents] OFF
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'001', N'Student', N'Student', NULL)
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'002', N'Teacher', N'Teacher', NULL)
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'003', N'Family', N'Family', NULL)
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'004', N'Doctor', N'Dotor', NULL)
GO
SET IDENTITY_INSERT [dbo].[SchoolYears] ON 

INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (1, N'Class 1')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (2, N'Class 2')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (3, N'Class 3')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (4, N'Class 4')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (5, N'Class 5')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (6, N'Class 6')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (7, N'Class 7')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (8, N'Class 8')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (9, N'Class 9')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (10, N'Class 10')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (11, N'Class 11')
INSERT [dbo].[SchoolYears] ([SchoolYearId], [SchoolYearName]) VALUES (12, N'Class 12')
SET IDENTITY_INSERT [dbo].[SchoolYears] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (1, N'Independence', N'#f44336', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (2, N'Encourage', N'#e91e63', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (3, N'Practical', N'#9c27b0', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (4, N'ProblemDetection', N'#ff5722', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (5, N'Make a Plan', N'#2196f3', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (6, N'Creation', N'#00bcd4', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (7, N'Communicate', N'#009688', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (8, N'Listen', N'#8bc34a', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (9, N'Flexible', N'#607d8b', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (10, N'Grasp The Situation', N'#795548', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (11, N'Discipline', N'#009688', N'#')
INSERT [dbo].[Skills] ([SkillId], [SkillName], [Style], [Tags]) VALUES (12, N'Stress Management', N'#9e9e9e', N'#')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'001', N'001')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'002', N'002')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'003', N'003')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'004', N'004')
GO
INSERT [dbo].[Users] ([Id], [Phone], [Active], [CreateDate], [LastLogin], [Avatar], [ScholasticId], [ParentId], [bellNotifiId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'001', NULL, NULL, NULL, NULL, N'/images/student.png', NULL, NULL, NULL, N'xuanthanh', N'XUANTHANH', N'xuanthanh@gmail.com', N'xuanthanh@gmail.com', 0, N'AQAAAAEAACcQAAAAEPaVi3SnVI7dPGv1FHRL33kWVTczIwMKBgPorlOMMC45bnU9/rR5D4ZjA2ej2dRXrQ==', N'010e52b7-90c1-471c-8af8-5cea09069e7c', N'110bd236-a2f9-43bf-bb8d-eb14c3bc8b46', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[Users] ([Id], [Phone], [Active], [CreateDate], [LastLogin], [Avatar], [ScholasticId], [ParentId], [bellNotifiId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'002', NULL, NULL, NULL, NULL, N'/images/teacher.png', NULL, NULL, NULL, N'teacher', N'TEACHER', N'teacher@gmail.com', N'teacher@gmail.com', 0, N'AQAAAAEAACcQAAAAEPaVi3SnVI7dPGv1FHRL33kWVTczIwMKBgPorlOMMC45bnU9/rR5D4ZjA2ej2dRXrQ==', N'010e52b7-90c1-471c-8af8-5cea09069e7c', N'110bd236-a2f9-43bf-bb8d-eb14c3bc8b46', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[Users] ([Id], [Phone], [Active], [CreateDate], [LastLogin], [Avatar], [ScholasticId], [ParentId], [bellNotifiId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'003', NULL, NULL, NULL, NULL, N'/images/dad.png', NULL, NULL, NULL, N'family', N'FAMILY', N'family@gmail.com', N'family@gmail.com', 0, N'AQAAAAEAACcQAAAAEPaVi3SnVI7dPGv1FHRL33kWVTczIwMKBgPorlOMMC45bnU9/rR5D4ZjA2ej2dRXrQ==', N'010e52b7-90c1-471c-8af8-5cea09069e7c', N'110bd236-a2f9-43bf-bb8d-eb14c3bc8b46', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[Users] ([Id], [Phone], [Active], [CreateDate], [LastLogin], [Avatar], [ScholasticId], [ParentId], [bellNotifiId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'004', NULL, NULL, NULL, NULL, N'/images/doctor.png', NULL, NULL, NULL, N'doctor', N'DOCTOR', N'doctor@gmail.com', N'doctor@gmail.com', 0, N'AQAAAAEAACcQAAAAEPaVi3SnVI7dPGv1FHRL33kWVTczIwMKBgPorlOMMC45bnU9/rR5D4ZjA2ej2dRXrQ==', N'010e52b7-90c1-471c-8af8-5cea09069e7c', N'110bd236-a2f9-43bf-bb8d-eb14c3bc8b46', NULL, 0, 0, NULL, 0, 0)
GO
/****** Object:  Index [IX_BellNotification_NotifiId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_BellNotification_NotifiId] ON [dbo].[BellNotification]
(
	[NotifiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_ListEventId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Events_ListEventId] ON [dbo].[Events]
(
	[ListEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Events_UserId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Events_UserId] ON [dbo].[Events]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Messages_EventId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Messages_EventId] ON [dbo].[Messages]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Messages_SkillId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Messages_SkillId] ON [dbo].[Messages]
(
	[SkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Messages_UserId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Messages_UserId] ON [dbo].[Messages]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [dbo].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 11/11/2021 16:59:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[Roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [dbo].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogins_UserId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserLogins_UserId] ON [dbo].[UserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[Users]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_bellNotifiId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_Users_bellNotifiId] ON [dbo].[Users]
(
	[bellNotifiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 11/11/2021 16:59:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[Users]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserSchoolYears_ScholYearId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserSchoolYears_ScholYearId] ON [dbo].[UserSchoolYears]
(
	[ScholYearId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserSchoolYears_UserId]    Script Date: 11/11/2021 16:59:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserSchoolYears_UserId] ON [dbo].[UserSchoolYears]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BellNotification]  WITH CHECK ADD  CONSTRAINT [FK_BellNotification_Messages] FOREIGN KEY([NotifiId])
REFERENCES [dbo].[Messages] ([MessagesId])
GO
ALTER TABLE [dbo].[BellNotification] CHECK CONSTRAINT [FK_BellNotification_Messages]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_ListEvents] FOREIGN KEY([ListEventId])
REFERENCES [dbo].[ListEvents] ([ListEventId])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_ListEvents]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Users]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Events] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([EventId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Events]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Skills] FOREIGN KEY([SkillId])
REFERENCES [dbo].[Skills] ([SkillId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Skills]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Users]
GO
ALTER TABLE [dbo].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [dbo].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_BellNotification] FOREIGN KEY([bellNotifiId])
REFERENCES [dbo].[BellNotification] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_BellNotification]
GO
ALTER TABLE [dbo].[UserSchoolYears]  WITH CHECK ADD  CONSTRAINT [FK_UserSchoolYears_SchoolYears] FOREIGN KEY([ScholYearId])
REFERENCES [dbo].[SchoolYears] ([SchoolYearId])
GO
ALTER TABLE [dbo].[UserSchoolYears] CHECK CONSTRAINT [FK_UserSchoolYears_SchoolYears]
GO
ALTER TABLE [dbo].[UserSchoolYears]  WITH CHECK ADD  CONSTRAINT [FK_UserSchoolYears_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserSchoolYears] CHECK CONSTRAINT [FK_UserSchoolYears_Users]
GO
ALTER TABLE [dbo].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [StudentManagement] SET  READ_WRITE 
GO
