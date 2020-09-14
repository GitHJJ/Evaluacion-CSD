USE EVALUACION

SELECT PuestoID, SUM(EmpresaID) AS TipoEmpresa
FROM dbo.TblPuestos
GROUP BY PuestoID