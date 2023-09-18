
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/26/2023 11:25:38
-- Generated from EDMX file: D:\José\Visual Studio\desktop system\ProyectoSistema\ModeloDatos\Entidad relación.edmx
-- --------------------------------------------------
Create database Sistema_Venta
ON  PRIMARY 
( 
	NAME = 'Sistema_Venta_DATA', 
	FILENAME = 'C:\BDS\Sistema_Venta_DATA.MDF', 
	SIZE = 10240KB,
	MAXSIZE = 102400KB, 
	FILEGROWTH = 10240KB 
)
	
LOG ON

( 
	NAME = 'Sistema_Venta_LOG', 
	FILENAME = 'C:\BDS\Sistema_Venta_LOG.LDF',
	SIZE = 10240KB,
	MAXSIZE = 102400KB,
	FILEGROWTH = 50%
)
GO

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sistema_Venta];
GO
IF SCHEMA_ID(N'SI4V') IS NULL EXECUTE(N'CREATE SCHEMA [SI4V]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[SI4V].[FK_DetalleFacCompra_FacturaCompra]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[DetalleFacCompra] DROP CONSTRAINT [FK_DetalleFacCompra_FacturaCompra];
GO
IF OBJECT_ID(N'[SI4V].[FK_DetalleFacCompra_Producto]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[DetalleFacCompra] DROP CONSTRAINT [FK_DetalleFacCompra_Producto];
GO
IF OBJECT_ID(N'[SI4V].[FK_DetalleFacVenta_FacturaVenta]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[DetalleFacVenta] DROP CONSTRAINT [FK_DetalleFacVenta_FacturaVenta];
GO
IF OBJECT_ID(N'[SI4V].[FK_DetalleFacVenta_Producto]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[DetalleFacVenta] DROP CONSTRAINT [FK_DetalleFacVenta_Producto];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaCompra_Proveedor]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaCompra] DROP CONSTRAINT [FK_FacturaCompra_Proveedor];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaCompra_TipoEntrada]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaCompra] DROP CONSTRAINT [FK_FacturaCompra_TipoEntrada];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaCompra_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaCompra] DROP CONSTRAINT [FK_FacturaCompra_Usuario];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaVenta_Cliente]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaVenta] DROP CONSTRAINT [FK_FacturaVenta_Cliente];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaVenta_TipoSalida]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaVenta] DROP CONSTRAINT [FK_FacturaVenta_TipoSalida];
GO
IF OBJECT_ID(N'[SI4V].[FK_FacturaVenta_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[FacturaVenta] DROP CONSTRAINT [FK_FacturaVenta_Usuario];
GO
IF OBJECT_ID(N'[SI4V].[FK_Permiso_Rol]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[Permiso] DROP CONSTRAINT [FK_Permiso_Rol];
GO
IF OBJECT_ID(N'[SI4V].[FK_Producto_Categoria]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[Producto] DROP CONSTRAINT [FK_Producto_Categoria];
GO
IF OBJECT_ID(N'[SI4V].[FK_Usuario_Rol]', 'F') IS NOT NULL
    ALTER TABLE [SI4V].[Usuario] DROP CONSTRAINT [FK_Usuario_Rol];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[SI4V].[Categoria]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Categoria];
GO
IF OBJECT_ID(N'[SI4V].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Cliente];
GO
IF OBJECT_ID(N'[SI4V].[DetalleFacCompra]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[DetalleFacCompra];
GO
IF OBJECT_ID(N'[SI4V].[DetalleFacVenta]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[DetalleFacVenta];
GO
IF OBJECT_ID(N'[SI4V].[FacturaCompra]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[FacturaCompra];
GO
IF OBJECT_ID(N'[SI4V].[FacturaVenta]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[FacturaVenta];
GO
IF OBJECT_ID(N'[SI4V].[Permiso]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Permiso];
GO
IF OBJECT_ID(N'[SI4V].[Producto]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Producto];
GO
IF OBJECT_ID(N'[SI4V].[Proveedor]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Proveedor];
GO
IF OBJECT_ID(N'[SI4V].[Rol]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Rol];
GO
IF OBJECT_ID(N'[SI4V].[TipoEntrada]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[TipoEntrada];
GO
IF OBJECT_ID(N'[SI4V].[TipoSalida]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[TipoSalida];
GO
IF OBJECT_ID(N'[SI4V].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [SI4V].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categoria'
CREATE TABLE [SI4V].[Categoria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Nombre] varchar(10)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [Estado] bit  NOT NULL,
    [FechaCreacion] datetime  NULL
);
GO

-- Creating table 'Cliente'
CREATE TABLE [SI4V].[Cliente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Nombres] varchar(50)  NOT NULL,
    [Apellido1] varchar(50)  NOT NULL,
    [Apellido2] varchar(50)  NULL,
    [Correo] varchar(50)  NULL,
    [Telefono] varchar(50)  NULL,
    [Estado] bit  NOT NULL,
    [Fechacreacion] datetime  NULL
);
GO

-- Creating table 'DetalleFacCompra'
CREATE TABLE [SI4V].[DetalleFacCompra] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [PrecioVenta] decimal(10,2)  NOT NULL,
    [PrecioCompra] decimal(10,2)  NOT NULL,
    [MontoTotal] decimal(10,2)  NOT NULL,
    [FechaCreacion] datetime  NULL,
    [ProductoId] int  NOT NULL,
    [FacturaCompraId] int  NOT NULL
);
GO

-- Creating table 'DetalleFacVenta'
CREATE TABLE [SI4V].[DetalleFacVenta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrecioVenta] decimal(10,2)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Subtotal] decimal(10,2)  NOT NULL,
    [FechaCreacion] datetime  NULL,
    [ProductoId] int  NOT NULL,
    [FacturaVentaId] int  NOT NULL
);
GO

-- Creating table 'FacturaCompra'
CREATE TABLE [SI4V].[FacturaCompra] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [MontoTotal] decimal(10,2)  NOT NULL,
    [FechaCompra] datetime  NULL,
    [ProveedorId] int  NOT NULL,
    [UsuarioId] int  NOT NULL,
    [TipoEntradaId] int  NOT NULL
);
GO

-- Creating table 'FacturaVenta'
CREATE TABLE [SI4V].[FacturaVenta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [NombreClente] varchar(50)  NULL,
    [MontoPago] decimal(10,2)  NOT NULL,
    [MontoCambio] decimal(10,2)  NOT NULL,
    [MontoTotal] decimal(10,2)  NOT NULL,
    [FechaVenta] datetime  NULL,
    [ClienteId] int  NOT NULL,
    [UsuarioId] int  NOT NULL,
    [TipoSalidaId] int  NOT NULL
);
GO

-- Creating table 'Permiso'
CREATE TABLE [SI4V].[Permiso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdRol] int  NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Fehacreacion] datetime  NULL
);
GO

-- Creating table 'Producto'
CREATE TABLE [SI4V].[Producto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [PrecioCompra] decimal(10,2)  NOT NULL,
    [PrecioVenta] decimal(10,2)  NOT NULL,
	[Stock] int  NOT NULL,
    [Estado] bit  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Proveedor'
CREATE TABLE [SI4V].[Proveedor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [RazónSocial] varchar(50)  NOT NULL,
    [Correo] varchar(50)  NULL,
    [Telefono] varchar(50)  NULL,
    [Estado] bit  NULL,
    [Fechacreacion] datetime  NULL
);
GO

-- Creating table 'Rol'
CREATE TABLE [SI4V].[Rol] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [Fehacreacion] datetime  NULL
);
GO

-- Creating table 'TipoEntrada'
CREATE TABLE [SI4V].[TipoEntrada] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [FechaEntrada] datetime  NULL
);
GO

-- Creating table 'TipoSalida'
CREATE TABLE [SI4V].[TipoSalida] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [FechaSalida] datetime  NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [SI4V].[Usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(10)  NOT NULL,
    [NombreCompleto] varchar(50)  NOT NULL,
    [Clave] varchar(50)  NOT NULL,
    [Correo] varchar(50)  NULL,
    [IdRol] int  NOT NULL,
    [Estado] bit  NULL,
    [Fechacreacion] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categoria'
ALTER TABLE [SI4V].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cliente'
ALTER TABLE [SI4V].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleFacCompra'
ALTER TABLE [SI4V].[DetalleFacCompra]
ADD CONSTRAINT [PK_DetalleFacCompra]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleFacVenta'
ALTER TABLE [SI4V].[DetalleFacVenta]
ADD CONSTRAINT [PK_DetalleFacVenta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FacturaCompra'
ALTER TABLE [SI4V].[FacturaCompra]
ADD CONSTRAINT [PK_FacturaCompra]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FacturaVenta'
ALTER TABLE [SI4V].[FacturaVenta]
ADD CONSTRAINT [PK_FacturaVenta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permiso'
ALTER TABLE [SI4V].[Permiso]
ADD CONSTRAINT [PK_Permiso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Producto'
ALTER TABLE [SI4V].[Producto]
ADD CONSTRAINT [PK_Producto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proveedor'
ALTER TABLE [SI4V].[Proveedor]
ADD CONSTRAINT [PK_Proveedor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rol'
ALTER TABLE [SI4V].[Rol]
ADD CONSTRAINT [PK_Rol]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoEntrada'
ALTER TABLE [SI4V].[TipoEntrada]
ADD CONSTRAINT [PK_TipoEntrada]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoSalida'
ALTER TABLE [SI4V].[TipoSalida]
ADD CONSTRAINT [PK_TipoSalida]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuario'
ALTER TABLE [SI4V].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoriaId] in table 'Producto'
ALTER TABLE [SI4V].[Producto]
ADD CONSTRAINT [FK_Producto_Categoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [SI4V].[Categoria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Producto_Categoria'
CREATE INDEX [IX_FK_Producto_Categoria]
ON [SI4V].[Producto]
    ([CategoriaId]);
GO

-- Creating foreign key on [ClienteId] in table 'FacturaVenta'
ALTER TABLE [sI4V].[FacturaVenta]
ADD CONSTRAINT [FK_FacturaVenta_Cliente]
    FOREIGN KEY ([ClienteId])
    REFERENCES [SI4V].[Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaVenta_Cliente'
CREATE INDEX [IX_FK_FacturaVenta_Cliente]
ON [SI4V].[FacturaVenta]
    ([ClienteId]);
GO

-- Creating foreign key on [FacturaCompraId] in table 'DetalleFacCompra'
ALTER TABLE [SI4V].[DetalleFacCompra]
ADD CONSTRAINT [FK_DetalleFacCompra_FacturaCompra]
    FOREIGN KEY ([FacturaCompraId])
    REFERENCES [SI4V].[FacturaCompra]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleFacCompra_FacturaCompra'
CREATE INDEX [IX_FK_DetalleFacCompra_FacturaCompra]
ON [SI4V].[DetalleFacCompra]
    ([FacturaCompraId]);
GO

-- Creating foreign key on [ProductoId] in table 'DetalleFacCompra'
ALTER TABLE [SI4V].[DetalleFacCompra]
ADD CONSTRAINT [FK_DetalleFacCompra_Producto]
    FOREIGN KEY ([ProductoId])
    REFERENCES [SI4V].[Producto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleFacCompra_Producto'
CREATE INDEX [IX_FK_DetalleFacCompra_Producto]
ON [SI4V].[DetalleFacCompra]
    ([ProductoId]);
GO

-- Creating foreign key on [FacturaVentaId] in table 'DetalleFacVenta'
ALTER TABLE [SI4V].[DetalleFacVenta]
ADD CONSTRAINT [FK_DetalleFacVenta_FacturaVenta]
    FOREIGN KEY ([FacturaVentaId])
    REFERENCES [SI4V].[FacturaVenta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleFacVenta_FacturaVenta'
CREATE INDEX [IX_FK_DetalleFacVenta_FacturaVenta]
ON [SI4V].[DetalleFacVenta]
    ([FacturaVentaId]);
GO

-- Creating foreign key on [ProductoId] in table 'DetalleFacVenta'
ALTER TABLE [SI4V].[DetalleFacVenta]
ADD CONSTRAINT [FK_DetalleFacVenta_Producto]
    FOREIGN KEY ([ProductoId])
    REFERENCES [SI4V].[Producto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleFacVenta_Producto'
CREATE INDEX [IX_FK_DetalleFacVenta_Producto]
ON [SI4V].[DetalleFacVenta]
    ([ProductoId]);
GO

-- Creating foreign key on [ProveedorId] in table 'FacturaCompra'
ALTER TABLE [SI4V].[FacturaCompra]
ADD CONSTRAINT [FK_FacturaCompra_Proveedor]
    FOREIGN KEY ([ProveedorId])
    REFERENCES [SI4V].[Proveedor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaCompra_Proveedor'
CREATE INDEX [IX_FK_FacturaCompra_Proveedor]
ON [SI4V].[FacturaCompra]
    ([ProveedorId]);
GO

-- Creating foreign key on [TipoEntradaId] in table 'FacturaCompra'
ALTER TABLE [SI4V].[FacturaCompra]
ADD CONSTRAINT [FK_FacturaCompra_TipoEntrada]
    FOREIGN KEY ([TipoEntradaId])
    REFERENCES [SI4V].[TipoEntrada]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaCompra_TipoEntrada'
CREATE INDEX [IX_FK_FacturaCompra_TipoEntrada]
ON [SI4V].[FacturaCompra]
    ([TipoEntradaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'FacturaCompra'
ALTER TABLE [SI4V].[FacturaCompra]
ADD CONSTRAINT [FK_FacturaCompra_Usuario]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [SI4V].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaCompra_Usuario'
CREATE INDEX [IX_FK_FacturaCompra_Usuario]
ON [SI4V].[FacturaCompra]
    ([UsuarioId]);
GO

-- Creating foreign key on [TipoSalidaId] in table 'FacturaVenta'
ALTER TABLE [SI4V].[FacturaVenta]
ADD CONSTRAINT [FK_FacturaVenta_TipoSalida]
    FOREIGN KEY ([TipoSalidaId])
    REFERENCES [SI4V].[TipoSalida]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaVenta_TipoSalida'
CREATE INDEX [IX_FK_FacturaVenta_TipoSalida]
ON [SI4V].[FacturaVenta]
    ([TipoSalidaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'FacturaVenta'
ALTER TABLE [SI4V].[FacturaVenta]
ADD CONSTRAINT [FK_FacturaVenta_Usuario]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [SI4V].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaVenta_Usuario'
CREATE INDEX [IX_FK_FacturaVenta_Usuario]
ON [SI4V].[FacturaVenta]
    ([UsuarioId]);
GO

-- Creating foreign key on [IdRol] in table 'Permiso'
ALTER TABLE [SI4V].[Permiso]
ADD CONSTRAINT [FK_Permiso_Rol]
    FOREIGN KEY ([IdRol])
    REFERENCES [SI4V].[Rol]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Permiso_Rol'
CREATE INDEX [IX_FK_Permiso_Rol]
ON [SI4V].[Permiso]
    ([IdRol]);
GO

-- Creating foreign key on [IdRol] in table 'Usuario'
ALTER TABLE [SI4V].[Usuario]
ADD CONSTRAINT [FK_Usuario_Rol]
    FOREIGN KEY ([IdRol])
    REFERENCES [SI4V].[Rol]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuario_Rol'
CREATE INDEX [IX_FK_Usuario_Rol]
ON [SI4V].[Usuario]
    ([IdRol]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------