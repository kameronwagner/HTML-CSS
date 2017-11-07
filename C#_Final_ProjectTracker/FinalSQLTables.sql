CREATE TABLE [dbo].[Employees] (
    [EmployeeID] INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (25) NOT NULL,
    [LastName]   VARCHAR (35) NOT NULL,
    [Title]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

CREATE TABLE [dbo].[Projects] (
    [ProjectID]      INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeID]     INT           NOT NULL,
    [StatusID]       INT           NOT NULL,
    [ProjectName]    VARCHAR (50)  NOT NULL,
    [Description]    VARCHAR (150) NOT NULL,
    [StartDate]      DATE          NOT NULL,
    [EndDate]        DATE          NULL,
    [ProjectManager] VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectID] ASC),
    CONSTRAINT [FK_Projects_Status] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[Status] ([StatusID]),
    CONSTRAINT [FK_Projects_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

CREATE TABLE [dbo].[Status] (
    [StatusID] INT          IDENTITY (1, 1) NOT NULL,
    [Status]   VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([StatusID] ASC),
    CONSTRAINT [CK_Status_Status] CHECK ([Status] like 'pending' OR [Status] like 'underway' OR [Status] like 'delayed' OR [Status] like 'completed')
);

CREATE TABLE [dbo].[Tasks] (
    [TaskID]      INT           IDENTITY (1, 1) NOT NULL,
    [ProjectID]   INT           NOT NULL,
    [StatusID]    INT           NOT NULL,
    [TaskName]    VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    [StartDate]   DATE          NOT NULL,
    [EndDate]     DATE          NULL,
    CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED ([TaskID] ASC),
    CONSTRAINT [FK_Tasks_Status] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[Status] ([StatusID]),
    CONSTRAINT [FK_Tasks_Projects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Projects] ([ProjectID])
);

CREATE TABLE [dbo].[Work] (
    [WorkID]     INT  IDENTITY (1, 1) NOT NULL,
    [TaskID]     INT  NOT NULL,
    [EmployeeID] INT  NOT NULL,
    [Date]       DATE NOT NULL,
    [Hours]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([WorkID] ASC),
    CONSTRAINT [FK_Work_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID]),
    CONSTRAINT [FK_Work_Tasks] FOREIGN KEY ([TaskID]) REFERENCES [dbo].[Tasks] ([TaskID])
);

SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title]) VALUES (1, N'Kameron', N'Wagner', N'Analyst')
INSERT INTO [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title]) VALUES (2, N'Peter', N'Moore', N'Grunt')
INSERT INTO [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title]) VALUES (3, N'Gary', N'Sweet', N'Genius')
INSERT INTO [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title]) VALUES (4, N'Robert', N'Chavez', N'Worker')
INSERT INTO [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title]) VALUES (5, N'Jerry', N'Williams', N'Worker')
SET IDENTITY_INSERT [dbo].[Employees] OFF

SET IDENTITY_INSERT [dbo].[Projects] ON
INSERT INTO [dbo].[Projects] ([ProjectID], [EmployeeID], [StatusID], [ProjectName], [Description], [StartDate], [EndDate], [ProjectManager]) VALUES (1, 1, 1, N'Project Alpha', N'Build stuff', N'2017-01-02', NULL, N'Kameron Wagner')
INSERT INTO [dbo].[Projects] ([ProjectID], [EmployeeID], [StatusID], [ProjectName], [Description], [StartDate], [EndDate], [ProjectManager]) VALUES (2, 1, 4, N'Project Bravo', N'Break Stuff', N'2016-03-05', N'2017-05-12', N'Kameron Wagner')
INSERT INTO [dbo].[Projects] ([ProjectID], [EmployeeID], [StatusID], [ProjectName], [Description], [StartDate], [EndDate], [ProjectManager]) VALUES (3, 2, 2, N'Project Charlie', N'Analyze stuff', N'2017-07-03', NULL, N'Peter Moore')
INSERT INTO [dbo].[Projects] ([ProjectID], [EmployeeID], [StatusID], [ProjectName], [Description], [StartDate], [EndDate], [ProjectManager]) VALUES (4, 3, 3, N'Project Delta', N'Fix Stuff', N'2017-12-22', NULL, N'Gary Sweet')
INSERT INTO [dbo].[Projects] ([ProjectID], [EmployeeID], [StatusID], [ProjectName], [Description], [StartDate], [EndDate], [ProjectManager]) VALUES (5, 4, 4, N'Project Echo', N'Clean stuff', N'2016-06-12', N'2016-08-22', N'Robert Chavez')
SET IDENTITY_INSERT [dbo].[Projects] OFF

SET IDENTITY_INSERT [dbo].[Status] ON
INSERT INTO [dbo].[Status] ([StatusID], [Status]) VALUES (1, N'Pending')
INSERT INTO [dbo].[Status] ([StatusID], [Status]) VALUES (2, N'Underway')
INSERT INTO [dbo].[Status] ([StatusID], [Status]) VALUES (3, N'Delayed')
INSERT INTO [dbo].[Status] ([StatusID], [Status]) VALUES (4, N'Completed')
SET IDENTITY_INSERT [dbo].[Status] OFF

SET IDENTITY_INSERT [dbo].[Tasks] ON
INSERT INTO [dbo].[Tasks] ([TaskID], [ProjectID], [StatusID], [TaskName], [Description], [StartDate], [EndDate]) VALUES (1, 1, 4, N'Alpha-1', N'Build a train track', N'2017-04-02', N'2017-08-05')
INSERT INTO [dbo].[Tasks] ([TaskID], [ProjectID], [StatusID], [TaskName], [Description], [StartDate], [EndDate]) VALUES (2, 3, 1, N'Charlie-1', N'Cost reduction analysis', N'2017-11-03', NULL)
INSERT INTO [dbo].[Tasks] ([TaskID], [ProjectID], [StatusID], [TaskName], [Description], [StartDate], [EndDate]) VALUES (3, 5, 3, N'Echo-1', N'Clean the bathrooms', N'2017-08-23', NULL)
INSERT INTO [dbo].[Tasks] ([TaskID], [ProjectID], [StatusID], [TaskName], [Description], [StartDate], [EndDate]) VALUES (4, 4, 2, N'Delta-1', N'Fix the heater', N'2017-09-17', NULL)
INSERT INTO [dbo].[Tasks] ([TaskID], [ProjectID], [StatusID], [TaskName], [Description], [StartDate], [EndDate]) VALUES (5, 1, 4, N'Alpha-2', N'Build a fish tank', N'2016-02-03', N'2017-05-12')
SET IDENTITY_INSERT [dbo].[Tasks] OFF
