CREATE TABLE [dbo].[Rooms]
(
[roomID] [int] NOT NULL IDENTITY(4000, 1),
[roomNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[floorNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[roomType] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[numberOfBeds] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[complimentaryBenefits1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[complimentaryBenefits2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[complimentaryBenefits3] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[roomDescription] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[roomPrice] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[roomAvailability] [bit] NOT NULL CONSTRAINT [DF_Rooms_roomAvailability] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rooms] ADD CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED  ([roomID]) ON [PRIMARY]
GO
