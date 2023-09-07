﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [RainbowSchool] (
    [Id] int NOT NULL IDENTITY,
    [StudentName] nvarchar(max) NOT NULL,
    [Subject] nvarchar(max) NOT NULL,
    [SubjectMarks] float NOT NULL,
    CONSTRAINT [PK_RainbowSchool] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230906190001_FirstMig', N'7.0.10');
GO

COMMIT;
GO

