CREATE TABLE [dbo].[logIn]
(
[Id] [int] NOT NULL IDENTITY(1000, 1),
[Username] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Password] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[logIn] ADD CONSTRAINT [PK_logIn] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
