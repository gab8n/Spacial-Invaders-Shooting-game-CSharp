﻿CREATE TABLE [dbo].[LoginTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Score] INT NULL
)
