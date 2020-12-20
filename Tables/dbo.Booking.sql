CREATE TABLE [dbo].[Booking]
(
[BookingId] [int] NULL,
[FirstName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[LastName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[EmailAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[PhoneNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RoomAssigned1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RoomAssigned2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RoomAssigned3] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RoomAssigned4] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ArrivalDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[DepartureDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[PaymentComplete] [bit] NOT NULL CONSTRAINT [DF_Booking_PaymentComplete] DEFAULT ((0)),
[CheckOut] [bit] NOT NULL CONSTRAINT [DF_Booking_CheckOut] DEFAULT ((0))
) ON [PRIMARY]
GO
