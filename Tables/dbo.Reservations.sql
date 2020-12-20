CREATE TABLE [dbo].[Reservations]
(
[reservationId] [int] NOT NULL IDENTITY(5000, 1),
[reservedFirstName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedLastName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedEmailAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedPhoneNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedTotalRooms] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedTotalAdults] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedTotalChildren] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedPreference1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedPreference2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedDepartureDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[reservedArrivalDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[questionsComments] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[reservedUsername] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[reservedPassword] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reservations] ADD CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED  ([reservationId]) ON [PRIMARY]
GO
