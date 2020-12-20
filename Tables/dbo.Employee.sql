CREATE TABLE [dbo].[Employee]
(
[employeeId] [int] NOT NULL IDENTITY(2000, 1),
[employeeFirstName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeLastName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeOtherAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[employeeEmailAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeePhoneNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeEmergencyContact] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeECNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeEC1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[employeeEC1Number] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[employeeEC2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[employeeEC2Number] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[employementPosition] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employeeJoiningDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[employementStatus] [bit] NOT NULL CONSTRAINT [DF_Employee_employementStatus] DEFAULT ((1)),
[employeeLeavingDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED  ([employeeId]) ON [PRIMARY]
GO
