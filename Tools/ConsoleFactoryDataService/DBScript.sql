/****** Object:  StoredProcedure [dbo].[DAH_User_Delete]    Script Date: 23-04-2017 00:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DAH_User_Delete]
@Id int
as
begin
	set nocount on;
	delete from [User]
	where Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[DAH_User_GetAll]    Script Date: 23-04-2017 00:15:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DAH_User_GetAll]
as
begin
	set nocount on;
	select * from [User]
end
GO
/****** Object:  StoredProcedure [dbo].[DAH_User_Insert]    Script Date: 23-04-2017 00:15:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DAH_User_Insert]
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Dob datetime,
@IsActive bit
as
begin
	set nocount on;
	insert into [User](FirstName, LastName, Dob, IsActive)
	values(@FirstName, @LastName, @Dob, @IsActive)

	select @@IDENTITY
end
GO
/****** Object:  StoredProcedure [dbo].[DAH_User_Scalar]    Script Date: 23-04-2017 00:15:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DAH_User_Scalar]
as
begin
	set nocount on;
	select COUNT(Id) as Id from [User]
end
GO
/****** Object:  StoredProcedure [dbo].[DAH_User_Update]    Script Date: 23-04-2017 00:15:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DAH_User_Update]
@Id int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Dob datetime
as
begin
	set nocount on;
	update [User]
	set FirstName=@FirstName, 
		LastName=@LastName, 
		Dob = @Dob
	where id = @Id
end
GO
/****** Object:  Table [dbo].[User]    Script Date: 23-04-2017 00:15:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Dob] [datetime] NULL,
	[IsActive] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

create procedure DAH_User_GetById
@Id int
as
begin
	set nocount on;

	select * from [User]
	where id = @Id
end
GO
