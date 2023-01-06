USE [students_db]
GO

/****** Object:  Table [dbo].[course]    Script Date: 05/01/2023 22:01:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[course](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_course_1] PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[student_details]    Script Date: 05/01/2023 22:01:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[student_details](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[student_name] [varchar](50) NOT NULL,
	[department] [varchar](50) NOT NULL,
	[teacher_id] [int] NOT NULL,
	[course_id] [int] NOT NULL,
 CONSTRAINT [PK_student_details] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[teacher]    Script Date: 05/01/2023 22:01:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[teacher](
	[t_id] [int] IDENTITY(1,1) NOT NULL,
	[teacher_name] [varchar](50) NOT NULL,
	[teacher_subject] [varchar](50) NOT NULL,
 CONSTRAINT [PK_teacher] PRIMARY KEY CLUSTERED 
(
	[t_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[student_details]  WITH CHECK ADD  CONSTRAINT [FK_student_details_course] FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([c_id])
GO

ALTER TABLE [dbo].[student_details] CHECK CONSTRAINT [FK_student_details_course]
GO

ALTER TABLE [dbo].[student_details]  WITH CHECK ADD  CONSTRAINT [FK_student_details_student_details] FOREIGN KEY([student_id])
REFERENCES [dbo].[student_details] ([student_id])
GO

ALTER TABLE [dbo].[student_details] CHECK CONSTRAINT [FK_student_details_student_details]
GO

ALTER TABLE [dbo].[student_details]  WITH CHECK ADD  CONSTRAINT [FK_student_details_student_details1] FOREIGN KEY([student_id])
REFERENCES [dbo].[student_details] ([student_id])
GO

ALTER TABLE [dbo].[student_details] CHECK CONSTRAINT [FK_student_details_student_details1]
GO

ALTER TABLE [dbo].[student_details]  WITH CHECK ADD  CONSTRAINT [FK_student_details_teacher] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[teacher] ([t_id])
GO

ALTER TABLE [dbo].[student_details] CHECK CONSTRAINT [FK_student_details_teacher]
GO


