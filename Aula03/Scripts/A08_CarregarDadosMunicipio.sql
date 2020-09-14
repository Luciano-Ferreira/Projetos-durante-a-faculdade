BULK
INSERT tbIBGEMunicipios
FROM 'C:/Users/Luciano/source/repos/Aula03/Scripts/A04_Municipios.CSV'
WITH
(CODEPAGE='ACP',
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO

SELECT *
FROM tbIBGEMunicipios;