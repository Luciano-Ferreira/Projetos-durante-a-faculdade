BULK
INSERT tbUF
FROM 'C:/Users/Luciano/source/repos/Aula03/Scripts/A03_UF.CSV'
WITH
(
CODEPAGE='ACP',
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO

SELECT *
FROM tbUF;

