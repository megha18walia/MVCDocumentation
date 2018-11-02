USE [Movies]
GO

/****** Object: Table [dbo].[Movie] Script Date: 11/1/2018 4:00:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Movie];


GO
CREATE TABLE [dbo].[Movie] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Movie]       VARCHAR (50) NULL,
    [Genere]      VARCHAR (50) NULL,
    [ReleaseDate] DATETIME     NULL,
    [Price]       DECIMAL (18) NULL
);


