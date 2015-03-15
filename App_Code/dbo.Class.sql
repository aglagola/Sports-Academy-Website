CREATE TABLE [dbo].[Class] (
    [ClassID]           INT            NOT NULL,
    [Class]             NVARCHAR (50)  NULL,
    [Class_Date]        NVARCHAR (50)  NULL,
    [Class_Days]        NVARCHAR (50)  NULL,
    [Class_Time]        NVARCHAR (50)  NULL,
    [Class_Description] NVARCHAR (MAX) NULL,
    [InstructorID]         INT  NULL,
    PRIMARY KEY CLUSTERED ([ClassID] ASC)
);

