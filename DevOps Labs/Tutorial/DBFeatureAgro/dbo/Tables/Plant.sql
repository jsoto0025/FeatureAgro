CREATE TABLE [dbo].[Plant] (
    [PlantId]   INT IDENTITY (1, 1) NOT NULL,
    [PlantType] INT NOT NULL,
    [IsAlive]   BIT CONSTRAINT [DF_Plant_IsAlive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Plant] PRIMARY KEY CLUSTERED ([PlantId] ASC),
    CONSTRAINT [FK_Plant_PlantType] FOREIGN KEY ([PlantType]) REFERENCES [dbo].[PlantType] ([PlantTypeId])
);

