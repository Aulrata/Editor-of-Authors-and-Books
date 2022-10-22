CREATE TABLE [dbo].[Books] (
    [BookID]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [YearOfIssue] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([BookID] ASC)
);

