
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 14:07:46
-- Generated from EDMX file: D:\Faculty\TSP.NET\MyPhotos\MyPhotos\MyPhotosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MediaCharacteristic_Media]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaCharacteristic] DROP CONSTRAINT [FK_MediaCharacteristic_Media];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaCharacteristic_Characteristic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaCharacteristic] DROP CONSTRAINT [FK_MediaCharacteristic_Characteristic];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaCharValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharValues] DROP CONSTRAINT [FK_MediaCharValue];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacteristicCharValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharValues] DROP CONSTRAINT [FK_CharacteristicCharValue];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Media]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Media];
GO
IF OBJECT_ID(N'[dbo].[Characteristics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Characteristics];
GO
IF OBJECT_ID(N'[dbo].[CharValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharValues];
GO
IF OBJECT_ID(N'[dbo].[MediaCharacteristic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaCharacteristic];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(10)  NOT NULL,
    [AbsPath] nvarchar(1024)  NOT NULL,
    [Deleted] nvarchar(max)  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL
);
GO

-- Creating table 'Characteristics'
CREATE TABLE [dbo].[Characteristics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL,
    [Type] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'CharValues'
CREATE TABLE [dbo].[CharValues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [CharacteristicId] int  NOT NULL,
    [Media_Id] int  NOT NULL
);
GO

-- Creating table 'MediaCharacteristic'
CREATE TABLE [dbo].[MediaCharacteristic] (
    [Media_Id] int  NOT NULL,
    [Characteristics_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Characteristics'
ALTER TABLE [dbo].[Characteristics]
ADD CONSTRAINT [PK_Characteristics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CharValues'
ALTER TABLE [dbo].[CharValues]
ADD CONSTRAINT [PK_CharValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Media_Id], [Characteristics_Id] in table 'MediaCharacteristic'
ALTER TABLE [dbo].[MediaCharacteristic]
ADD CONSTRAINT [PK_MediaCharacteristic]
    PRIMARY KEY CLUSTERED ([Media_Id], [Characteristics_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Media_Id] in table 'MediaCharacteristic'
ALTER TABLE [dbo].[MediaCharacteristic]
ADD CONSTRAINT [FK_MediaCharacteristic_Media]
    FOREIGN KEY ([Media_Id])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Characteristics_Id] in table 'MediaCharacteristic'
ALTER TABLE [dbo].[MediaCharacteristic]
ADD CONSTRAINT [FK_MediaCharacteristic_Characteristic]
    FOREIGN KEY ([Characteristics_Id])
    REFERENCES [dbo].[Characteristics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaCharacteristic_Characteristic'
CREATE INDEX [IX_FK_MediaCharacteristic_Characteristic]
ON [dbo].[MediaCharacteristic]
    ([Characteristics_Id]);
GO

-- Creating foreign key on [Media_Id] in table 'CharValues'
ALTER TABLE [dbo].[CharValues]
ADD CONSTRAINT [FK_MediaCharValue]
    FOREIGN KEY ([Media_Id])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaCharValue'
CREATE INDEX [IX_FK_MediaCharValue]
ON [dbo].[CharValues]
    ([Media_Id]);
GO

-- Creating foreign key on [CharacteristicId] in table 'CharValues'
ALTER TABLE [dbo].[CharValues]
ADD CONSTRAINT [FK_CharacteristicCharValue]
    FOREIGN KEY ([CharacteristicId])
    REFERENCES [dbo].[Characteristics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacteristicCharValue'
CREATE INDEX [IX_FK_CharacteristicCharValue]
ON [dbo].[CharValues]
    ([CharacteristicId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------