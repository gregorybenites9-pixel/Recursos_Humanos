-- ============================================================
-- SOFBE – VISTAS Y PROCEDURES CON VALIDACIONES DE FORMATO
-- Tabla: empleado  |  Base de datos: recursos_h
-- Motor: SQL Server
-- ============================================================

USE recursos_h;
GO



-- ============================================================
-- SECCIÓN 2: PROCEDURE DE BÚSQUEDA
-- ============================================================

CREATE OR ALTER PROCEDURE SOFBE_BuscarEmpleado
(
    @TextoBusqueda VARCHAR(100) = NULL
)
AS
BEGIN
    SELECT *
    FROM vw_Empleados
    WHERE
        (@TextoBusqueda IS NULL OR @TextoBusqueda = '')
        OR (Apellidos + ' ' + Nombres) LIKE '%' + @TextoBusqueda + '%'
        OR Nombres                      LIKE '%' + @TextoBusqueda + '%'
        OR Apellidos                    LIKE '%' + @TextoBusqueda + '%'
        OR Numero_Documento             LIKE '%' + @TextoBusqueda + '%'
        OR Correo1                      LIKE '%' + @TextoBusqueda + '%';
END
GO

/* LLAMAR AL PROCEDURE DE BÚSQUEDA */
EXEC SOFBE_BuscarEmpleado 'Castillo';
GO


-- ============================================================
-- SECCIÓN 3: PROCEDURE PARA INSERTAR EMPLEADO
-- ============================================================

CREATE OR ALTER PROCEDURE SOFBE_InsertarEmpleado
(
    @IdTipo_Documento INT,
    @Numero_Documento VARCHAR(15),
    @Nombres          VARCHAR(100),
    @Apellidos        VARCHAR(100),
    @IdGenero         INT,
    @IdProfesion      INT,
    @IdDistrito       INT,
    @Fecha_Nacimiento DATE,
    @Fecha_Ingreso    DATE,
    @Direccion_Actual VARCHAR(150) = NULL,
    @Telefono1        VARCHAR(20)  = NULL,
    @Telefono2        VARCHAR(20)  = NULL,
    @Correo1          VARCHAR(100),
    @Correo2          VARCHAR(100) = NULL,
    @Observaciones    VARCHAR(200) = NULL
)
AS
BEGIN
    BEGIN TRY

        -- ------------------------------------------------
        -- VALIDACIONES DE EXISTENCIA EN CATÁLOGOS
        -- ------------------------------------------------

        IF NOT EXISTS (SELECT 1 FROM tipo_documento WHERE IdTipo_Documento = @IdTipo_Documento AND Estado = 1)
        BEGIN
            SELECT 'ERROR: Tipo de documento no válido o inactivo'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM genero WHERE IdGenero = @IdGenero)
        BEGIN
            SELECT 'ERROR: Género no válido'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM profesion WHERE IdProfesion = @IdProfesion AND Estado = 1)
        BEGIN
            SELECT 'ERROR: Profesión no válida o inactiva'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM distrito WHERE IdDistrito = @IdDistrito)
        BEGIN
            SELECT 'ERROR: Distrito no válido'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Número de Documento
        -- ------------------------------------------------

        -- DNI: exactamente 8 dígitos numéricos
        IF @IdTipo_Documento = 1
        BEGIN
            IF LEN(@Numero_Documento) <> 8 OR @Numero_Documento NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: El DNI debe tener exactamente 8 dígitos numéricos'; RETURN;
            END
        END

        -- Carnet de Extranjería: entre 9 y 12 caracteres alfanuméricos
        IF @IdTipo_Documento = 2
        BEGIN
            IF LEN(@Numero_Documento) NOT BETWEEN 9 AND 12
            BEGIN
                SELECT 'ERROR: El Carnet de Extranjería debe tener entre 9 y 12 caracteres'; RETURN;
            END
        END

        -- Pasaporte: entre 6 y 12 caracteres alfanuméricos
        IF @IdTipo_Documento = 3
        BEGIN
            IF LEN(@Numero_Documento) NOT BETWEEN 6 AND 12
            BEGIN
                SELECT 'ERROR: El Pasaporte debe tener entre 6 y 12 caracteres'; RETURN;
            END
        END

        -- PTP: exactamente 9 dígitos numéricos
        IF @IdTipo_Documento = 4
        BEGIN
            IF LEN(@Numero_Documento) <> 9 OR @Numero_Documento NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: El PTP debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Nombres y Apellidos
        -- ------------------------------------------------

        IF LEN(LTRIM(RTRIM(@Nombres))) < 2
        BEGIN
            SELECT 'ERROR: El campo Nombres es obligatorio y debe tener al menos 2 caracteres'; RETURN;
        END

        IF LEN(LTRIM(RTRIM(@Apellidos))) < 2
        BEGIN
            SELECT 'ERROR: El campo Apellidos es obligatorio y debe tener al menos 2 caracteres'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Correo
        -- ------------------------------------------------

        -- Correo1 obligatorio y debe contener @ y al menos un punto después del @
        IF @Correo1 IS NULL OR LEN(LTRIM(RTRIM(@Correo1))) = 0
        BEGIN
            SELECT 'ERROR: El correo principal (Correo1) es obligatorio'; RETURN;
        END

        IF CHARINDEX('@', @Correo1) = 0
        BEGIN
            SELECT 'ERROR: Correo1 debe contener el símbolo @'; RETURN;
        END

        IF CHARINDEX('.', @Correo1, CHARINDEX('@', @Correo1)) = 0
        BEGIN
            SELECT 'ERROR: Correo1 debe tener un dominio válido (ej: usuario@dominio.com)'; RETURN;
        END

        -- Correo2 opcional, pero si se ingresa debe ser válido
        IF @Correo2 IS NOT NULL AND LEN(LTRIM(RTRIM(@Correo2))) > 0
        BEGIN
            IF CHARINDEX('@', @Correo2) = 0
            BEGIN
                SELECT 'ERROR: Correo2 debe contener el símbolo @'; RETURN;
            END
            IF CHARINDEX('.', @Correo2, CHARINDEX('@', @Correo2)) = 0
            BEGIN
                SELECT 'ERROR: Correo2 debe tener un dominio válido (ej: usuario@dominio.com)'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Teléfono
        -- ------------------------------------------------

        -- Telefono1 opcional, pero si se ingresa debe tener 9 dígitos numéricos
        IF @Telefono1 IS NOT NULL AND LEN(LTRIM(RTRIM(@Telefono1))) > 0
        BEGIN
            IF LEN(@Telefono1) <> 9 OR @Telefono1 NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: Telefono1 debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        -- Telefono2 opcional, misma regla
        IF @Telefono2 IS NOT NULL AND LEN(LTRIM(RTRIM(@Telefono2))) > 0
        BEGIN
            IF LEN(@Telefono2) <> 9 OR @Telefono2 NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: Telefono2 debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FECHA
        -- ------------------------------------------------

        -- Fecha de nacimiento: debe ser mayor de 18 años
        IF DATEDIFF(YEAR, @Fecha_Nacimiento, GETDATE()) < 18
        BEGIN
            SELECT 'ERROR: El empleado debe ser mayor de 18 años'; RETURN;
        END

        -- Fecha de ingreso: no puede ser futura
        IF @Fecha_Ingreso > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'ERROR: La fecha de ingreso no puede ser una fecha futura'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE UNICIDAD
        -- ------------------------------------------------

        IF EXISTS (SELECT 1 FROM empleado WHERE Numero_Documento = @Numero_Documento)
        BEGIN
            SELECT 'ERROR: El número de documento ya está registrado'; RETURN;
        END

        IF EXISTS (SELECT 1 FROM empleado WHERE Correo1 = @Correo1)
        BEGIN
            SELECT 'ERROR: El correo principal ya está registrado'; RETURN;
        END

        IF @Telefono1 IS NOT NULL AND EXISTS (SELECT 1 FROM empleado WHERE Telefono1 = @Telefono1)
        BEGIN
            SELECT 'ERROR: El teléfono principal ya está registrado'; RETURN;
        END

        -- ------------------------------------------------
        -- INSERTAR
        -- ------------------------------------------------

        INSERT INTO empleado
        (
            IdTipo_Documento, Numero_Documento, Nombres, Apellidos,
            Fecha_Nacimiento, Fecha_Ingreso, Direccion_Actual,
            Telefono1, Telefono2, Correo1, Correo2,
            Observaciones, IdGenero, IdProfesion, IdDistrito, Estado
        )
        VALUES
        (
            @IdTipo_Documento, @Numero_Documento, @Nombres, @Apellidos,
            @Fecha_Nacimiento, @Fecha_Ingreso, @Direccion_Actual,
            @Telefono1, @Telefono2, @Correo1, @Correo2,
            @Observaciones, @IdGenero, @IdProfesion, @IdDistrito, 1
        );

        SELECT 'Empleado registrado correctamente';

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END
GO

/* LLAMAR AL PROCEDURE INSERTAR */
EXEC SOFBE_InsertarEmpleado
    @IdTipo_Documento = 1,
    @Numero_Documento = '74123456',
    @Nombres          = 'Carlos Alberto',
    @Apellidos        = 'Rojas Mendoza',
    @IdGenero         = 1,
    @IdProfesion      = 3,
    @IdDistrito       = 5,
    @Fecha_Nacimiento = '1990-05-20',
    @Fecha_Ingreso    = '2025-01-15',
    @Direccion_Actual = 'Av. Los Pinos 350, Nuevo Chimbote',
    @Telefono1        = '955123456',
    @Telefono2        = NULL,
    @Correo1          = 'carlos.rojas@senati.pe',
    @Correo2          = NULL,
    @Observaciones    = 'Nuevo empleado administrativo';
GO


-- ============================================================
-- SECCIÓN 4: PROCEDURE PARA MODIFICAR EMPLEADO
-- ============================================================

CREATE OR ALTER PROCEDURE SOFBE_ModificarEmpleado
(
    @IdEmpleado       INT,
    @IdTipo_Documento INT,
    @Numero_Documento VARCHAR(15),
    @Nombres          VARCHAR(100),
    @Apellidos        VARCHAR(100),
    @IdGenero         INT,
    @IdProfesion      INT,
    @IdDistrito       INT,
    @Fecha_Nacimiento DATE,
    @Fecha_Ingreso    DATE,
    @Direccion_Actual VARCHAR(150) = NULL,
    @Telefono1        VARCHAR(20)  = NULL,
    @Telefono2        VARCHAR(20)  = NULL,
    @Correo1          VARCHAR(100),
    @Correo2          VARCHAR(100) = NULL,
    @Observaciones    VARCHAR(200) = NULL
)
AS
BEGIN
    BEGIN TRY

        -- ------------------------------------------------
        -- VALIDAR EXISTENCIA DEL EMPLEADO
        -- ------------------------------------------------

        IF NOT EXISTS (SELECT 1 FROM empleado WHERE IdEmpleado = @IdEmpleado)
        BEGIN
            SELECT 'ERROR: El empleado no existe'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE CATÁLOGOS
        -- ------------------------------------------------

        IF NOT EXISTS (SELECT 1 FROM tipo_documento WHERE IdTipo_Documento = @IdTipo_Documento AND Estado = 1)
        BEGIN
            SELECT 'ERROR: Tipo de documento no válido o inactivo'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM genero WHERE IdGenero = @IdGenero)
        BEGIN
            SELECT 'ERROR: Género no válido'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM profesion WHERE IdProfesion = @IdProfesion AND Estado = 1)
        BEGIN
            SELECT 'ERROR: Profesión no válida o inactiva'; RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM distrito WHERE IdDistrito = @IdDistrito)
        BEGIN
            SELECT 'ERROR: Distrito no válido'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Número de Documento
        -- ------------------------------------------------

        IF @IdTipo_Documento = 1
        BEGIN
            IF LEN(@Numero_Documento) <> 8 OR @Numero_Documento NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: El DNI debe tener exactamente 8 dígitos numéricos'; RETURN;
            END
        END

        IF @IdTipo_Documento = 2
        BEGIN
            IF LEN(@Numero_Documento) NOT BETWEEN 9 AND 12
            BEGIN
                SELECT 'ERROR: El Carnet de Extranjería debe tener entre 9 y 12 caracteres'; RETURN;
            END
        END

        IF @IdTipo_Documento = 3
        BEGIN
            IF LEN(@Numero_Documento) NOT BETWEEN 6 AND 12
            BEGIN
                SELECT 'ERROR: El Pasaporte debe tener entre 6 y 12 caracteres'; RETURN;
            END
        END

        IF @IdTipo_Documento = 4
        BEGIN
            IF LEN(@Numero_Documento) <> 9 OR @Numero_Documento NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: El PTP debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Nombres y Apellidos
        -- ------------------------------------------------

        IF LEN(LTRIM(RTRIM(@Nombres))) < 2
        BEGIN
            SELECT 'ERROR: El campo Nombres debe tener al menos 2 caracteres'; RETURN;
        END

        IF LEN(LTRIM(RTRIM(@Apellidos))) < 2
        BEGIN
            SELECT 'ERROR: El campo Apellidos debe tener al menos 2 caracteres'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Correo
        -- ------------------------------------------------

        IF @Correo1 IS NULL OR LEN(LTRIM(RTRIM(@Correo1))) = 0
        BEGIN
            SELECT 'ERROR: El correo principal (Correo1) es obligatorio'; RETURN;
        END

        IF CHARINDEX('@', @Correo1) = 0
        BEGIN
            SELECT 'ERROR: Correo1 debe contener el símbolo @'; RETURN;
        END

        IF CHARINDEX('.', @Correo1, CHARINDEX('@', @Correo1)) = 0
        BEGIN
            SELECT 'ERROR: Correo1 debe tener un dominio válido (ej: usuario@dominio.com)'; RETURN;
        END

        IF @Correo2 IS NOT NULL AND LEN(LTRIM(RTRIM(@Correo2))) > 0
        BEGIN
            IF CHARINDEX('@', @Correo2) = 0
            BEGIN
                SELECT 'ERROR: Correo2 debe contener el símbolo @'; RETURN;
            END
            IF CHARINDEX('.', @Correo2, CHARINDEX('@', @Correo2)) = 0
            BEGIN
                SELECT 'ERROR: Correo2 debe tener un dominio válido (ej: usuario@dominio.com)'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FORMATO: Teléfono
        -- ------------------------------------------------

        IF @Telefono1 IS NOT NULL AND LEN(LTRIM(RTRIM(@Telefono1))) > 0
        BEGIN
            IF LEN(@Telefono1) <> 9 OR @Telefono1 NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: Telefono1 debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        IF @Telefono2 IS NOT NULL AND LEN(LTRIM(RTRIM(@Telefono2))) > 0
        BEGIN
            IF LEN(@Telefono2) <> 9 OR @Telefono2 NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            BEGIN
                SELECT 'ERROR: Telefono2 debe tener exactamente 9 dígitos numéricos'; RETURN;
            END
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE FECHA
        -- ------------------------------------------------

        IF DATEDIFF(YEAR, @Fecha_Nacimiento, GETDATE()) < 18
        BEGIN
            SELECT 'ERROR: El empleado debe ser mayor de 18 años'; RETURN;
        END

        IF @Fecha_Ingreso > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'ERROR: La fecha de ingreso no puede ser una fecha futura'; RETURN;
        END

        -- ------------------------------------------------
        -- VALIDACIONES DE UNICIDAD (excluyendo el mismo empleado)
        -- ------------------------------------------------

        IF EXISTS (SELECT 1 FROM empleado WHERE Numero_Documento = @Numero_Documento AND IdEmpleado <> @IdEmpleado)
        BEGIN
            SELECT 'ERROR: El número de documento ya está registrado en otro empleado'; RETURN;
        END

        IF EXISTS (SELECT 1 FROM empleado WHERE Correo1 = @Correo1 AND IdEmpleado <> @IdEmpleado)
        BEGIN
            SELECT 'ERROR: El correo principal ya está registrado en otro empleado'; RETURN;
        END

        IF @Telefono1 IS NOT NULL AND EXISTS (SELECT 1 FROM empleado WHERE Telefono1 = @Telefono1 AND IdEmpleado <> @IdEmpleado)
        BEGIN
            SELECT 'ERROR: El teléfono principal ya está registrado en otro empleado'; RETURN;
        END

        -- ------------------------------------------------
        -- ACTUALIZAR
        -- ------------------------------------------------

        UPDATE empleado SET
            IdTipo_Documento = @IdTipo_Documento,
            Numero_Documento = @Numero_Documento,
            Nombres          = @Nombres,
            Apellidos        = @Apellidos,
            IdGenero         = @IdGenero,
            IdProfesion      = @IdProfesion,
            IdDistrito       = @IdDistrito,
            Fecha_Nacimiento = @Fecha_Nacimiento,
            Fecha_Ingreso    = @Fecha_Ingreso,
            Direccion_Actual = @Direccion_Actual,
            Telefono1        = @Telefono1,
            Telefono2        = @Telefono2,
            Correo1          = @Correo1,
            Correo2          = @Correo2,
            Observaciones    = @Observaciones
        WHERE IdEmpleado = @IdEmpleado;

        SELECT 'Empleado actualizado correctamente';

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END
GO

/* LLAMAR AL PROCEDURE MODIFICAR */
EXEC SOFBE_ModificarEmpleado
    @IdEmpleado       = 1,
    @IdTipo_Documento = 1,
    @Numero_Documento = '71234501',
    @Nombres          = 'Valeria Fernanda',
    @Apellidos        = 'Castillo Ramos Modificado',
    @IdGenero         = 2,
    @IdProfesion      = 5,
    @IdDistrito       = 5,
    @Fecha_Nacimiento = '1995-03-14',
    @Fecha_Ingreso    = '2024-05-01',
    @Direccion_Actual = 'Urb. Bellamar Mz. D Lt. 20',
    @Telefono1        = '944112233',
    @Telefono2        = '911223344',
    @Correo1          = 'valeria.castillo@senati.pe',
    @Correo2          = 'vfc.personal@gmail.com',
    @Observaciones    = 'Actualización de dirección y teléfono secundario';
GO


-- ============================================================
-- SECCIÓN 5: PROCEDURE PARA ELIMINAR EMPLEADO (BAJA LÓGICA)
-- ============================================================

CREATE OR ALTER PROCEDURE SOFBE_EliminarEmpleado
(
    @IdEmpleado INT
)
AS
BEGIN
    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM empleado WHERE IdEmpleado = @IdEmpleado)
        BEGIN
            SELECT 'ERROR: El empleado no existe'; RETURN;
        END

        IF EXISTS (SELECT 1 FROM empleado WHERE IdEmpleado = @IdEmpleado AND Estado = 0)
        BEGIN
            SELECT 'ERROR: El empleado ya se encuentra inactivo'; RETURN;
        END

        UPDATE empleado
        SET Estado = 0
        WHERE IdEmpleado = @IdEmpleado;

        SELECT 'Empleado desactivado correctamente';

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END
GO

/* LLAMAR AL PROCEDURE ELIMINAR */
EXEC SOFBE_EliminarEmpleado @IdEmpleado = 5;
GO

/* VERIFICAR CON LA VISTA */
SELECT * FROM vw_Empleados;
GO

/*PROCEDIMIENTO PARA CASCADA*/

-- ══════════════════════════════════════════════════════════════════════
-- STORED PROCEDURES - CASCADA UBICACIÓN GEOGRÁFICA
-- SQL Server  |  Base de datos: recursos_H
-- Flujo: País → Departamento → Provincia → Distrito
-- ══════════════════════════════════════════════════════════════════════

USE recursos_H;
GO

-- ══════════════════════════════════════════════════════════════════════
-- 1. OBTENER TODOS LOS PAÍSES
--    Úsalo al cargar el formulario para llenar el primer combo
-- ══════════════════════════════════════════════════════════════════════
CREATE OR ALTER PROCEDURE SOFBE_ObtenerPaises
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdPais,
        Nombre_Pais
    FROM pais
    ORDER BY Nombre_Pais ASC;
END;
GO

-- Prueba
EXEC SOFBE_ObtenerPaises;
GO

-- ══════════════════════════════════════════════════════════════════════
-- 2. OBTENER DEPARTAMENTOS POR PAÍS
--    Llámalo cuando el usuario seleccione un País en el combo
-- ══════════════════════════════════════════════════════════════════════
CREATE OR ALTER PROCEDURE SOFBE_ObtenerDepartamentosPorPais
    @IdPais INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM pais WHERE IdPais = @IdPais)
    BEGIN
        RAISERROR('Error: El país con Id %d no existe.', 16, 1, @IdPais);
        RETURN;
    END

    SELECT
        IdDepartamento,
        Nombre_Departamento
    FROM departamento
    WHERE IdPais = @IdPais
    ORDER BY Nombre_Departamento ASC;
END;
GO

-- Prueba
EXEC SOFBE_ObtenerDepartamentosPorPais @IdPais = 1;
GO

-- ══════════════════════════════════════════════════════════════════════
-- 3. OBTENER PROVINCIAS POR DEPARTAMENTO
--    Llámalo cuando el usuario seleccione un Departamento en el combo
-- ══════════════════════════════════════════════════════════════════════
CREATE OR ALTER PROCEDURE SOFBE_ObtenerProvinciasPorDepartamento
    @IdDepartamento INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM departamento WHERE IdDepartamento = @IdDepartamento)
    BEGIN
        RAISERROR('Error: El departamento con Id %d no existe.', 16, 1, @IdDepartamento);
        RETURN;
    END

    SELECT
        IdProvincia,
        Nombre_Provincia
    FROM provincia
    WHERE IdDepartamento = @IdDepartamento
    ORDER BY Nombre_Provincia ASC;
END;
GO

-- Prueba
EXEC SOFBE_ObtenerProvinciasPorDepartamento @IdDepartamento = 1;
GO

-- ══════════════════════════════════════════════════════════════════════
-- 4. OBTENER DISTRITOS POR PROVINCIA
--    Llámalo cuando el usuario seleccione una Provincia en el combo
-- ══════════════════════════════════════════════════════════════════════
CREATE OR ALTER PROCEDURE SOFBE_ObtenerDistritosPorProvincia
    @IdProvincia INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM provincia WHERE IdProvincia = @IdProvincia)
    BEGIN
        RAISERROR('Error: La provincia con Id %d no existe.', 16, 1, @IdProvincia);
        RETURN;
    END

    SELECT
        IdDistrito,
        Nombre_Distrito
    FROM distrito
    WHERE IdProvincia = @IdProvincia
    ORDER BY Nombre_Distrito ASC;
END;
GO

-- Prueba
EXEC SOFBE_ObtenerDistritosPorProvincia @IdProvincia = 1;
GO

-- ══════════════════════════════════════════════════════════════════════
-- 5. BONUS: OBTENER UBICACIÓN COMPLETA DE UN EMPLEADO
--    Útil para el modo EDITAR: carga los 4 combos ya preseleccionados
-- ══════════════════════════════════════════════════════════════════════
CREATE OR ALTER PROCEDURE SOFBE_ObtenerUbicacionEmpleado
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM empleado WHERE IdEmpleado = @IdEmpleado)
    BEGIN
        RAISERROR('Error: El empleado con Id %d no existe.', 16, 1, @IdEmpleado);
        RETURN;
    END

    SELECT
        -- PAÍS
        pa.IdPais,
        pa.Nombre_Pais,

        -- DEPARTAMENTO
        dep.IdDepartamento,
        dep.Nombre_Departamento,

        -- PROVINCIA
        pro.IdProvincia,
        pro.Nombre_Provincia,

        -- DISTRITO
        dis.IdDistrito,
        dis.Nombre_Distrito

    FROM empleado           emp
    INNER JOIN distrito     dis ON emp.IdDistrito       = dis.IdDistrito
    INNER JOIN provincia    pro ON dis.IdProvincia      = pro.IdProvincia
    INNER JOIN departamento dep ON pro.IdDepartamento   = dep.IdDepartamento
    INNER JOIN pais         pa  ON dep.IdPais           = pa.IdPais

    WHERE emp.IdEmpleado = @IdEmpleado;
END;
GO

-- Prueba
EXEC SOFBE_ObtenerUbicacionEmpleado @IdEmpleado = 1;
GO

-- ══════════════════════════════════════════════════════════════════════
-- FIN
-- ══════════════════════════════════════════════════════════════════════
