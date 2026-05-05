CREATE OR ALTER VIEW vw_Empleados
AS
SELECT
    E.IdEmpleado,
    E.Numero_Documento,
    TD.Nombre_Tipo_Doc         AS TipoDocumento,
    E.Apellidos,
    E.Nombres,
    G.Nombre_Genero            AS Genero,
    E.Fecha_Nacimiento,
    E.Fecha_Ingreso,
    P.Nombre_Profesion         AS Profesion,
    DI.Nombre_Distrito         AS Distrito,
    PR.Nombre_Provincia        AS Provincia,
    DP.Nombre_Departamento     AS Departamento,
    E.Direccion_Actual,
    E.Telefono1,
    E.Telefono2,
    E.Correo1,
    E.Correo2,
    E.Observaciones,
    E.Estado
FROM empleado E
INNER JOIN tipo_documento TD ON E.IdTipo_Documento = TD.IdTipo_Documento
INNER JOIN genero          G  ON E.IdGenero         = G.IdGenero
INNER JOIN profesion       P  ON E.IdProfesion      = P.IdProfesion
INNER JOIN distrito        DI ON E.IdDistrito       = DI.IdDistrito
INNER JOIN provincia       PR ON DI.IdProvincia     = PR.IdProvincia
INNER JOIN departamento    DP ON PR.IdDepartamento  = DP.IdDepartamento
WHERE E.Estado = 1;
GO

/* LLAMAR A LA VISTA */
SELECT * FROM vw_Empleados;
GO
