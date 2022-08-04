
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/04/2022 02:06:21
-- Generated from EDMX file: C:\Users\shard\source\repos\fit5120\fit5120\Models\MOdel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UVs'
CREATE TABLE [dbo].[UVs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UV_Value] bigint  NOT NULL,
    [Forecast_value] bigint  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Locationname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Information'
CREATE TABLE [dbo].[Information] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Details] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Hazards'
CREATE TABLE [dbo].[Hazards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HazardName] nvarchar(max)  NOT NULL,
    [Details] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UVs'
ALTER TABLE [dbo].[UVs]
ADD CONSTRAINT [PK_UVs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Information'
ALTER TABLE [dbo].[Information]
ADD CONSTRAINT [PK_Information]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hazards'
ALTER TABLE [dbo].[Hazards]
ADD CONSTRAINT [PK_Hazards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------