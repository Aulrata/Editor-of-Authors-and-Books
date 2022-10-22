CREATE TABLE [dbo].[Authors] (
    [AuthorID]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (MAX) NOT NULL,
    [LastName]   NVARCHAR (MAX) NOT NULL,
    [MiddleName] NVARCHAR (MAX) NOT NULL,
    [Birthday]   DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Authors] PRIMARY KEY CLUSTERED ([AuthorID] ASC)
);

