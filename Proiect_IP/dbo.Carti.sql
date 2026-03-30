CREATE TABLE [dbo].[Carti]
(
	[ISBN] NUMERIC NOT NULL PRIMARY KEY, 
    [Titlu] NCHAR(100) NOT NULL, 
    [Autor] NCHAR(100) NOT NULL, 
    [Editura] NCHAR(40) NOT NULL, 
    [Gen] NCHAR(40) NOT NULL, 
    [Status] NCHAR(40) NULL, 
    [Nr_exemplare] NUMERIC NULL
)
