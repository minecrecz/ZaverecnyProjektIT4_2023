CREATE TABLE [dbo].[UserRoles] (
    [IdRole]   INT          IDENTITY (1, 1) NOT NULL,
    [RoleName] VARCHAR (50) NOT NULL,
    [IdUser]   INT          NOT NULL
);
