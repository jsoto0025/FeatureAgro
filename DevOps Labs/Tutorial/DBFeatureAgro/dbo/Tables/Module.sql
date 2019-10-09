CREATE TABLE [dbo].[Module] (
    [ModuleId]     INT           IDENTITY (1, 1) NOT NULL,
    [NameMod]      NVARCHAR (50) NOT NULL,
    [PlantingDate] DATE          NULL,
    [TotalPlants]  INT           NULL,
    [DeathPlants]  INT           NULL,
    CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED ([ModuleId] ASC)
);

