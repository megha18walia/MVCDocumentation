SET IDENTITY_INSERT [dbo].[Movie] ON
INSERT INTO [dbo].[Movie] ([Id], [Movie], [Genere], [ReleaseDate], [Price]) VALUES (1, N'Golmal', N'Comedy', N'2011-12-10 00:00:00', CAST(100 AS Decimal(18, 0)))
INSERT INTO [dbo].[Movie] ([Id], [Movie], [Genere], [ReleaseDate], [Price]) VALUES (2, N'Golmal 2', N'Comedy', N'2012-10-10 00:00:00', CAST(200 AS Decimal(18, 0)))
INSERT INTO [dbo].[Movie] ([Id], [Movie], [Genere], [ReleaseDate], [Price]) VALUES (3, N'Golmal 3', N'Comedy', N'2013-12-15 00:00:00', CAST(300 AS Decimal(18, 0)))
INSERT INTO [dbo].[Movie] ([Id], [Movie], [Genere], [ReleaseDate], [Price]) VALUES (4, N'Golmal 4', N'Comedy', N'2016-10-10 00:00:00', CAST(400 AS Decimal(18, 0)))
INSERT INTO [dbo].[Movie] ([Id], [Movie], [Genere], [ReleaseDate], [Price]) VALUES (1002, N'Padmavati', N'History', N'2017-10-10 00:00:00', CAST(800 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Movie] OFF
