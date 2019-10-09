CREATE TABLE [dbo].[PlantType] (
    [PlantTypeId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)  NOT NULL,
    [VarietyPlant] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_PlantType] PRIMARY KEY CLUSTERED ([PlantTypeId] ASC)
);

