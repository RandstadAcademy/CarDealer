
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/19/2017 14:23:25
-- Generated from EDMX file: C:\CarDealer\CarDealer\CarDealer.DataLayer\CarDealerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarDealer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarModelManifacture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarModels] DROP CONSTRAINT [FK_CarModelManifacture];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CarModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarModels];
GO
IF OBJECT_ID(N'[dbo].[Manifactures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Manifactures];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CarModels'
CREATE TABLE [dbo].[CarModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ModelName] nvarchar(max)  NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [Year] int  NOT NULL,
    [CarDoor] tinyint  NOT NULL,
    [Km] int  NULL,
    [IsUsed] bit  NOT NULL,
    [ManifactureId] int  NOT NULL
);
GO

-- Creating table 'Manifactures'
CREATE TABLE [dbo].[Manifactures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Website] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CarModels'
ALTER TABLE [dbo].[CarModels]
ADD CONSTRAINT [PK_CarModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Manifactures'
ALTER TABLE [dbo].[Manifactures]
ADD CONSTRAINT [PK_Manifactures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManifactureId] in table 'CarModels'
ALTER TABLE [dbo].[CarModels]
ADD CONSTRAINT [FK_CarModelManifacture]
    FOREIGN KEY ([ManifactureId])
    REFERENCES [dbo].[Manifactures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarModelManifacture'
CREATE INDEX [IX_FK_CarModelManifacture]
ON [dbo].[CarModels]
    ([ManifactureId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------