CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(MAX) NOT NULL, 
    [PasswordSalt] VARBINARY(MAX) NOT NULL, 
    [Admin] NVARCHAR(50) NOT NULL
)