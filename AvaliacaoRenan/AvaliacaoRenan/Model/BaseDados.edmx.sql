
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2017 09:04:27
-- Generated from EDMX file: C:\Users\Aluno\Source\Repos\MY_Asp.Net_Aulas\AvaliacaoRenan\AvaliacaoRenan\Model\BaseDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LojaPowerFodds];
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

-- Creating table 'Suplementos'
CREATE TABLE [dbo].[Suplementos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Forma] nvarchar(10)  NOT NULL,
    [Origem] nvarchar(11)  NOT NULL,
    [Ativo] bit  NOT NULL,
    [Marca_Id] int  NOT NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Suplementos'
ALTER TABLE [dbo].[Suplementos]
ADD CONSTRAINT [PK_Suplementos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Marca_Id] in table 'Suplementos'
ALTER TABLE [dbo].[Suplementos]
ADD CONSTRAINT [FK_SuplementoMarca]
    FOREIGN KEY ([Marca_Id])
    REFERENCES [dbo].[Marcas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SuplementoMarca'
CREATE INDEX [IX_FK_SuplementoMarca]
ON [dbo].[Suplementos]
    ([Marca_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------