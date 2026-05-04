-- ============================================================
-- SECCIÓN 1: TABLAS BASE (sin dependencias)
-- ============================================================

-- Tabla: pais
IF OBJECT_ID('pais', 'U') IS NOT NULL DROP TABLE pais;
CREATE TABLE pais (
    IdPais        INT          NOT NULL IDENTITY(1,1),
    Nombre_Pais   VARCHAR(100) NOT NULL,
    CONSTRAINT PK_pais          PRIMARY KEY (IdPais),
    CONSTRAINT UQ_pais_nombre   UNIQUE (Nombre_Pais)
);
GO

-- Tabla: genero
IF OBJECT_ID('genero', 'U') IS NOT NULL DROP TABLE genero;
CREATE TABLE genero (
    IdGenero      INT         NOT NULL IDENTITY(1,1),
    Nombre_Genero VARCHAR(20) NOT NULL,
    CONSTRAINT PK_genero        PRIMARY KEY (IdGenero),
    CONSTRAINT UQ_genero_nombre UNIQUE (Nombre_Genero)
);
GO

-- Tabla: tipo_documento
IF OBJECT_ID('tipo_documento', 'U') IS NOT NULL DROP TABLE tipo_documento;
CREATE TABLE tipo_documento (
    IdTipo_Documento INT         NOT NULL IDENTITY(1,1),
    Nombre_Tipo_Doc  VARCHAR(70) NOT NULL,
    Estado           TINYINT     NOT NULL DEFAULT 1,
    CONSTRAINT PK_tipo_documento        PRIMARY KEY (IdTipo_Documento),
    CONSTRAINT UQ_tipo_documento_nombre UNIQUE (Nombre_Tipo_Doc)
);
GO

-- Tabla: profesion
IF OBJECT_ID('profesion', 'U') IS NOT NULL DROP TABLE profesion;
CREATE TABLE profesion (
    IdProfesion      INT          NOT NULL IDENTITY(1,1),
    Nombre_Profesion VARCHAR(60)  NOT NULL,
    Descripcion      VARCHAR(150) NULL,
    Estado           TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_profesion        PRIMARY KEY (IdProfesion),
    CONSTRAINT UQ_profesion_nombre UNIQUE (Nombre_Profesion)
);
GO

-- Tabla: cargo
IF OBJECT_ID('cargo', 'U') IS NOT NULL DROP TABLE cargo;
CREATE TABLE cargo (
    IdCargo     INT          NOT NULL IDENTITY(1,1),
    Nombre_Cargo VARCHAR(70) NOT NULL,
    Descripcion  VARCHAR(150) NULL,
    Estado       TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_cargo PRIMARY KEY (IdCargo)
);
GO

-- Tabla: modalidad
IF OBJECT_ID('modalidad', 'U') IS NOT NULL DROP TABLE modalidad;
CREATE TABLE modalidad (
    IdModalidad      INT         NOT NULL IDENTITY(1,1),
    Nombre_Modalidad VARCHAR(60) NOT NULL,
    Estado           TINYINT     NOT NULL DEFAULT 1,
    CONSTRAINT PK_modalidad        PRIMARY KEY (IdModalidad),
    CONSTRAINT UQ_modalidad_nombre UNIQUE (Nombre_Modalidad)
);
GO

-- Tabla: tipo_contrato
IF OBJECT_ID('tipo_contrato', 'U') IS NOT NULL DROP TABLE tipo_contrato;
CREATE TABLE tipo_contrato (
    IdTipo_Contrato INT         NOT NULL IDENTITY(1,1),
    Nombre_Contrato VARCHAR(60) NOT NULL,
    Estado          TINYINT     NOT NULL DEFAULT 1,
    CONSTRAINT PK_tipo_contrato        PRIMARY KEY (IdTipo_Contrato),
    CONSTRAINT UQ_tipo_contrato_nombre UNIQUE (Nombre_Contrato)
);
GO

-- Tabla: rol
IF OBJECT_ID('rol', 'U') IS NOT NULL DROP TABLE rol;
CREATE TABLE rol (
    IdRol       INT          NOT NULL IDENTITY(1,1),
    Nombre_Rol  VARCHAR(45)  NOT NULL,
    Descripcion VARCHAR(150) NOT NULL,
    Estado      TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_rol        PRIMARY KEY (IdRol),
    CONSTRAINT UQ_rol_nombre UNIQUE (Nombre_Rol)
);
GO

-- Tabla: sede
IF OBJECT_ID('sede', 'U') IS NOT NULL DROP TABLE sede;
CREATE TABLE sede (
    IdSede      INT          NOT NULL IDENTITY(1,1),
    Nombre_Sede VARCHAR(100) NOT NULL,
    Direccion   VARCHAR(150) NOT NULL,
    Estado      TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_sede PRIMARY KEY (IdSede)
);
GO

-- ============================================================
-- SECCIÓN 2: TABLAS GEOGRÁFICAS
-- ============================================================

-- Tabla: departamento
IF OBJECT_ID('departamento', 'U') IS NOT NULL DROP TABLE departamento;
CREATE TABLE departamento (
    IdDepartamento      INT          NOT NULL IDENTITY(1,1),
    Nombre_Departamento VARCHAR(100) NOT NULL,
    IdPais              INT          NOT NULL,
    CONSTRAINT PK_departamento        PRIMARY KEY (IdDepartamento),
    CONSTRAINT UQ_dep_nombre_pais     UNIQUE (Nombre_Departamento, IdPais),
    CONSTRAINT FK_departamento_pais   FOREIGN KEY (IdPais) REFERENCES pais(IdPais)
);
GO

-- Tabla: provincia
IF OBJECT_ID('provincia', 'U') IS NOT NULL DROP TABLE provincia;
CREATE TABLE provincia (
    IdProvincia      INT          NOT NULL IDENTITY(1,1),
    Nombre_Provincia VARCHAR(100) NOT NULL,
    IdDepartamento   INT          NOT NULL,
    CONSTRAINT PK_provincia          PRIMARY KEY (IdProvincia),
    CONSTRAINT UQ_prov_nombre_dep    UNIQUE (Nombre_Provincia, IdDepartamento),
    CONSTRAINT FK_provincia_dep      FOREIGN KEY (IdDepartamento) REFERENCES departamento(IdDepartamento)
);
GO

-- Tabla: distrito
IF OBJECT_ID('distrito', 'U') IS NOT NULL DROP TABLE distrito;
CREATE TABLE distrito (
    IdDistrito      INT          NOT NULL IDENTITY(1,1),
    Nombre_Distrito VARCHAR(100) NOT NULL,
    IdProvincia     INT          NOT NULL,
    CONSTRAINT PK_distrito          PRIMARY KEY (IdDistrito),
    CONSTRAINT UQ_dist_nombre_prov  UNIQUE (Nombre_Distrito, IdProvincia),
    CONSTRAINT FK_distrito_prov     FOREIGN KEY (IdProvincia) REFERENCES provincia(IdProvincia)
);
GO

-- ============================================================
-- SECCIÓN 3: TABLAS PRINCIPALES
-- ============================================================

-- Tabla: empleado
IF OBJECT_ID('empleado', 'U') IS NOT NULL DROP TABLE empleado;
CREATE TABLE empleado (
    IdEmpleado       INT          NOT NULL IDENTITY(1,1),
    Numero_Documento VARCHAR(15)  NOT NULL,
    Nombres          VARCHAR(100) NOT NULL,
    Apellidos        VARCHAR(100) NOT NULL,
    Fecha_Nacimiento DATE         NOT NULL,
    Fecha_Ingreso    DATE         NOT NULL,
    Direccion_Actual VARCHAR(150) NULL,
    Telefono1        VARCHAR(20)  NULL,
    Telefono2        VARCHAR(20)  NULL,
    Correo1          VARCHAR(100) NOT NULL,
    Correo2          VARCHAR(100) NULL,
    Observaciones    VARCHAR(200) NULL,
    IdTipo_Documento INT          NOT NULL,
    IdGenero         INT          NOT NULL,
    IdProfesion      INT          NOT NULL,
    IdDistrito       INT          NOT NULL,
    Estado           TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_empleado               PRIMARY KEY (IdEmpleado),
    CONSTRAINT UQ_empleado_doc           UNIQUE (Numero_Documento),
    CONSTRAINT UQ_empleado_correo        UNIQUE (Correo1),
    CONSTRAINT FK_empleado_tipodoc       FOREIGN KEY (IdTipo_Documento) REFERENCES tipo_documento(IdTipo_Documento),
    CONSTRAINT FK_empleado_genero        FOREIGN KEY (IdGenero)         REFERENCES genero(IdGenero),
    CONSTRAINT FK_empleado_profesion     FOREIGN KEY (IdProfesion)      REFERENCES profesion(IdProfesion),
    CONSTRAINT FK_empleado_distrito      FOREIGN KEY (IdDistrito)       REFERENCES distrito(IdDistrito)
);
GO

-- Tabla: contrato
IF OBJECT_ID('contrato', 'U') IS NOT NULL DROP TABLE contrato;
CREATE TABLE contrato (
    IdContrato      INT            NOT NULL IDENTITY(1,1),
    Fecha_Inicio    DATE           NOT NULL,
    Fecha_Fin       DATE           NOT NULL,
    Salario         DECIMAL(10,2)  NOT NULL,
    Detalles        VARCHAR(150)   NULL,
    Observaciones   VARCHAR(150)   NULL,
    IdEmpleado      INT            NOT NULL,
    IdSede          INT            NOT NULL,
    IdModalidad     INT            NOT NULL,
    IdTipo_Contrato INT            NOT NULL,
    IdCargo         INT            NOT NULL,
    Estado          TINYINT        NOT NULL DEFAULT 1,
    CONSTRAINT PK_contrato            PRIMARY KEY (IdContrato),
    CONSTRAINT FK_contrato_empleado   FOREIGN KEY (IdEmpleado)      REFERENCES empleado(IdEmpleado),
    CONSTRAINT FK_contrato_sede       FOREIGN KEY (IdSede)          REFERENCES sede(IdSede),
    CONSTRAINT FK_contrato_modalidad  FOREIGN KEY (IdModalidad)     REFERENCES modalidad(IdModalidad),
    CONSTRAINT FK_contrato_tipocon    FOREIGN KEY (IdTipo_Contrato) REFERENCES tipo_contrato(IdTipo_Contrato),
    CONSTRAINT FK_contrato_cargo      FOREIGN KEY (IdCargo)         REFERENCES cargo(IdCargo)
);
GO

-- Tabla: pagos
IF OBJECT_ID('pagos', 'U') IS NOT NULL DROP TABLE pagos;
CREATE TABLE pagos (
    IdPagos             INT           NOT NULL IDENTITY(1,1),
    Periodo_Inicio      DATE          NOT NULL,
    Periodo_Fin         DATE          NOT NULL,
    Fecha_Pago          DATE          NOT NULL,
    Sueldo_Base         DECIMAL(10,2) NOT NULL,
    Horas_Extras        DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Bonificaciones      DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Comisiones          DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Asignacion_Familiar DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Total_Ingresos      DECIMAL(10,2) NOT NULL,
    Otros_Descuentos    DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Total_Descuentos    DECIMAL(10,2) NOT NULL,
    Neto_Pagar          DECIMAL(10,2) NOT NULL,
    IdEmpleado          INT           NOT NULL,
    Estado              TINYINT       NOT NULL DEFAULT 1,
    CONSTRAINT PK_pagos          PRIMARY KEY (IdPagos),
    CONSTRAINT FK_pagos_empleado FOREIGN KEY (IdEmpleado) REFERENCES empleado(IdEmpleado)
);
GO

-- Tabla: usuario
IF OBJECT_ID('usuario', 'U') IS NOT NULL DROP TABLE usuario;
CREATE TABLE usuario (
    IdUsuario INT          NOT NULL IDENTITY(1,1),
    Username  VARCHAR(60)  NOT NULL,
    Password  VARCHAR(250) NOT NULL,
    IdRol     INT          NOT NULL,
    Estado    TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_usuario        PRIMARY KEY (IdUsuario),
    CONSTRAINT UQ_usuario_user   UNIQUE (Username),
    CONSTRAINT FK_usuario_rol    FOREIGN KEY (IdRol) REFERENCES rol(IdRol)
);
GO

-- Tabla: vacaciones
IF OBJECT_ID('vacaciones', 'U') IS NOT NULL DROP TABLE vacaciones;
CREATE TABLE vacaciones (
    IdVacaciones INT          NOT NULL IDENTITY(1,1),
    Fecha_Inicio DATE         NOT NULL,
    Fecha_Fin    DATE         NOT NULL,
    Dias_Totales INT          NOT NULL,
    Observaciones VARCHAR(200) NULL,
    IdEmpleado   INT          NOT NULL,
    Estado       TINYINT      NOT NULL DEFAULT 1,
    CONSTRAINT PK_vacaciones          PRIMARY KEY (IdVacaciones),
    CONSTRAINT FK_vacaciones_empleado FOREIGN KEY (IdEmpleado) REFERENCES empleado(IdEmpleado)
);
GO
