CREATE TABLE [dbo].[BookAuthor]
(
    [BookId] UNIQUEIDENTIFIER
        NOT NULL,
    [AuthorId] UNIQUEIDENTIFIER
        NOT NULL,
    CONSTRAINT [FK_BookAuthorBookID] FOREIGN KEY ([BookId])
        REFERENCES [Book] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_BookAuthorAuthorID] FOREIGN KEY ([AuthorId])
        REFERENCES [Author] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [UC_BookAuthor] UNIQUE ([BookId], [AuthorId])
)