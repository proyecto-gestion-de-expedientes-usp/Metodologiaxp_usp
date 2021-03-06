USE [consultoriojur]
GO
/****** Object:  Table [dbo].[Tip_documento]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tip_documento](
	[id_tipdoc] [int] IDENTITY(1,1) NOT NULL,
	[tipdoc_nom] [varchar](35) NOT NULL,
 CONSTRAINT [PK_Tip_documento] PRIMARY KEY CLUSTERED 
(
	[id_tipdoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[pers_id] [int] NOT NULL,
	[pers_nombres] [varchar](20) NOT NULL,
	[pers_apepat] [varchar](25) NOT NULL,
	[pers_apemat] [varchar](25) NOT NULL,
	[pers_ciudad] [varchar](20) NOT NULL,
	[pers_provincia] [varchar](20) NOT NULL,
	[pers_departamento] [varchar](20) NOT NULL,
	[pers_domlegal] [varchar](20) NOT NULL,
	[pers_telefono] [varchar](15) NOT NULL,
	[pers_email] [varchar](30) NOT NULL,
	[id_tipdoc] [int] NOT NULL,
	[pers_numdoc] [numeric](11, 0) NOT NULL,
	[pers_fenaci] [date] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[pers_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Persona]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Persona] as
 SELECT        dbo.Persona.pers_id as ID, 
 dbo.Persona.pers_nombres as NOMBRES, 
dbo.Persona.pers_apepat as APPATERNO, dbo.Persona.pers_apemat as APMATERNO, 
dbo.Tip_documento.tipdoc_nom as TIPDOC, dbo.Persona.pers_numdoc as NUMDOC, 
dbo.Persona.pers_email as EMAIL
FROM            dbo.Persona INNER JOIN
  dbo.Tip_documento ON dbo.Persona.id_tipdoc 
  = dbo.Tip_documento.id_tipdoc
GO
/****** Object:  Table [dbo].[Demandado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demandado](
	[demdo_id] [int] NOT NULL,
	[pers_id] [int] NOT NULL,
	[demdo_registro] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Demandado] PRIMARY KEY CLUSTERED 
(
	[demdo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Demandado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Demandado] as
SELECT  dbo.Demandado.demdo_id AS ID, 
dbo.Demandado.pers_id as ID_PERSONA,
dbo.Persona.pers_nombres as PERSONA, 
dbo.Persona.pers_numdoc as NUM_DOC, 
dbo.Demandado.demdo_registro as REGISTRO
FROM            dbo.Demandado 
INNER JOIN
dbo.Persona ON dbo.Demandado.pers_id = dbo.Persona.pers_id
GO
/****** Object:  Table [dbo].[Demandante]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demandante](
	[demte_id] [int] NOT NULL,
	[pers_id] [int] NOT NULL,
	[demte_registro] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Demandante] PRIMARY KEY CLUSTERED 
(
	[demte_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Demandante]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[View_Demandante] as
SELECT        dbo.Demandante.demte_id as ID, 
dbo.Demandante.pers_id as ID_PERSONA, dbo.Persona.pers_nombres as PERSONA, 
dbo.Persona.pers_numdoc as NUM_DOC, dbo.Demandante.demte_registro as REGISTRO
FROM            dbo.Demandante 
INNER JOIN
dbo.Persona ON dbo.Demandante.pers_id = dbo.Persona.pers_id
GO
/****** Object:  Table [dbo].[Tipo_Abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Abogado](
	[tipb_id] [int] NOT NULL,
	[tipb_def_inc] [varchar](20) NOT NULL,
	[tipb_estado] [varchar](20) NOT NULL,
	[tipb_descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Abogado] PRIMARY KEY CLUSTERED 
(
	[tipb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abogado](
	[ab_id] [int] NOT NULL,
	[id_estabo] [int] NOT NULL,
	[tipb_id] [int] NOT NULL,
	[ab_nombres] [varchar](20) NOT NULL,
	[ab_apellidopat] [varchar](20) NOT NULL,
	[ab_apellidomat] [varchar](20) NOT NULL,
	[ab_dni] [char](8) NOT NULL,
 CONSTRAINT [PK_Abogado] PRIMARY KEY CLUSTERED 
(
	[ab_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Abogado](
	[id_estabo] [int] IDENTITY(1,1) NOT NULL,
	[estabog] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Estado_Abogado] PRIMARY KEY CLUSTERED 
(
	[id_estabo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Abogado] as
SELECT dbo.Abogado.ab_id AS ID, 
dbo.Estado_Abogado.estabog AS ESTADO, 
dbo.Tipo_Abogado.tipb_def_inc AS PARTE, 
dbo.Abogado.ab_nombres AS NOMBRES, 
dbo.Abogado.ab_apellidopat AS APELLIDO_P, 
dbo.Abogado.ab_apellidomat AS APELLIDO_M, 
dbo.Abogado.ab_dni AS DNI
FROM dbo.Abogado 
INNER JOIN
dbo.Estado_Abogado ON dbo.Abogado.id_estabo = 
dbo.Estado_Abogado.id_estabo INNER JOIN
dbo.Tipo_Abogado ON dbo.Abogado.tipb_id = 
dbo.Tipo_Abogado.tipb_id
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[tipusu_id] [int] NOT NULL,
	[tipusu_tipousuario] [varchar](20) NOT NULL,
	[tipusu_descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Tipo_Usuario] PRIMARY KEY CLUSTERED 
(
	[tipusu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Usu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Usu](
	[id_estusu] [int] IDENTITY(1,1) NOT NULL,
	[est_condi] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Estado_Usu] PRIMARY KEY CLUSTERED 
(
	[id_estusu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usu_id] [int] NOT NULL,
	[tipusu_id] [int] NOT NULL,
	[usu_dni] [char](8) NOT NULL,
	[usu_nombres] [varchar](20) NOT NULL,
	[usu_apellidopat] [varchar](20) NOT NULL,
	[usu_apellidomat] [varchar](20) NOT NULL,
	[usu_telefono] [varchar](15) NOT NULL,
	[usu_direccion] [varchar](40) NOT NULL,
	[usu_sexo] [varchar](20) NOT NULL,
	[usu_correo] [varchar](60) NOT NULL,
	[usu_estadocivil] [varchar](20) NOT NULL,
	[usu_fechanac] [date] NULL,
	[usu_ciudad] [varchar](20) NOT NULL,
	[usu_provincia] [varchar](20) NOT NULL,
	[id_estusu] [int] NOT NULL,
	[usu_departamento] [varchar](20) NOT NULL,
	[usu_contraseña] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Usuario]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Usuario] as
SELECT        
dbo.Usuario.usu_id AS ID_USUARIO, 
dbo.Tipo_Usuario.tipusu_tipousuario AS TIPO,
dbo.Usuario.usu_dni AS DNI, 
dbo.Usuario.usu_nombres AS NOMBRES, 
dbo.Usuario.usu_apellidopat AS APELLIDO_P,
 dbo.Usuario.usu_apellidomat AS APELLIDO_M, 
dbo.Usuario.usu_telefono AS TELEFONO, 
dbo.Usuario.usu_direccion AS DIRECCION, 
dbo.Usuario.usu_sexo AS SEXO, 
dbo.Usuario.usu_correo AS CORREO, 
dbo.Usuario.usu_estadocivil AS ESTADO_CIV, 
dbo.Usuario.usu_provincia AS PROVINCIA, 
dbo.Estado_Usu.est_condi AS CONDICION
FROM  dbo.Usuario 
INNER JOIN
 dbo.Tipo_Usuario ON 
 dbo.Usuario.tipusu_id = dbo.Tipo_Usuario.tipusu_id 
 INNER JOIN
 dbo.Estado_Usu ON dbo.Usuario.id_estusu = 
 dbo.Estado_Usu.id_estusu



     
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documento](
	[doc_id] [int] NOT NULL,
	[doc_nombre] [varchar](100) NOT NULL,
	[doc_nombrereal] [varchar](100) NOT NULL,
	[doc_documento] [varbinary](max) NOT NULL,
	[doc_fecha] [date] NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[doc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstDocxnom]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDocxnom]
AS
SELECT        doc_nombre, doc_id
FROM            dbo.Documento

GO
/****** Object:  View [dbo].[V_lstDocxnomreal]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDocxnomreal]
AS
SELECT        doc_nombrereal, doc_id
FROM            dbo.Documento

GO
/****** Object:  View [dbo].[V _lsttipousuarioxtipous]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V _lsttipousuarioxtipous]
AS
SELECT        tipusu_tipousuario, tipusu_id
FROM            dbo.Tipo_Usuario

GO
/****** Object:  View [dbo].[V_lsttipousuarioxdescripcion]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipousuarioxdescripcion]
AS
SELECT        tipusu_tipousuario, tipusu_descripcion, tipusu_id
FROM            dbo.Tipo_Usuario

GO
/****** Object:  View [dbo].[V_lstusuarioxciudad]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxciudad]
AS
SELECT        usu_ciudad, usu_id
FROM            dbo.Usuario

GO
/****** Object:  View [dbo].[V_lstusuarioxprovincia]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxprovincia]
AS
SELECT        usu_id, usu_provincia
FROM            dbo.Usuario

GO
/****** Object:  View [dbo].[V_lstusuarioxdepartamento]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxdepartamento]
AS
SELECT        usu_id, usu_departamento
FROM            dbo.Usuario

GO
/****** Object:  View [dbo].[V_lstpersonaxciudad]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxciudad]
AS
SELECT        pers_id, pers_ciudad
FROM            dbo.Persona

GO
/****** Object:  View [dbo].[V_lstpersonaxprovincia]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxprovincia]
AS
SELECT        pers_id, pers_provincia
FROM            dbo.Persona

GO
/****** Object:  View [dbo].[V_lstpersonaxdepartamento]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxdepartamento]
AS
SELECT        pers_id, pers_departamento
FROM            dbo.Persona

GO
/****** Object:  Table [dbo].[Historial_Juzgado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Juzgado](
	[juzg_id] [int] NOT NULL,
	[juzg_descripcion] [varchar](50) NOT NULL,
	[juzg_fecharecepcion] [date] NULL,
	[juzg_pronunciamiento] [varchar](50) NOT NULL,
	[juzg_fechaderivacion] [date] NULL,
	[juzg_fechaemisionresol] [date] NULL,
	[juzg_fechanotificacion] [date] NULL,
	[juzg_fechasolucion] [date] NULL,
 CONSTRAINT [PK_Historial_Juzgado] PRIMARY KEY CLUSTERED 
(
	[juzg_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstHistdeJuzgxFechSol]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxFechSol]
AS
SELECT        juzg_id, juzg_fechasolucion
FROM            dbo.Historial_Juzgado

GO
/****** Object:  View [dbo].[V_lstHistdeJuzgxFechRec]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxFechRec]
AS
SELECT        juzg_id, juzg_fecharecepcion
FROM            dbo.Historial_Juzgado

GO
/****** Object:  View [dbo].[V_lstHistdeJuzgxdescr]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxdescr]
AS
SELECT        juzg_id, juzg_descripcion
FROM            dbo.Historial_Juzgado

GO
/****** Object:  Table [dbo].[Expediente]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expediente](
	[exp_id] [int] NOT NULL,
	[movexp_id] [int] NOT NULL,
	[juzg_id] [int] NOT NULL,
	[doc_id] [int] NOT NULL,
	[exp_nrosentencia] [varchar](30) NOT NULL,
	[exp_expediente] [varchar](30) NOT NULL,
	[exp_secrejuzg] [varchar](30) NOT NULL,
	[exp_fechainicio] [date] NULL,
	[exp_materia] [varchar](30) NOT NULL,
	[exp_resolucionnro] [varchar](30) NOT NULL,
	[exp_ciudad] [varchar](30) NOT NULL,
	[exp_fecha] [date] NULL,
	[exp_vistos] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Expediente] PRIMARY KEY CLUSTERED 
(
	[exp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstExpxnumero]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstExpxnumero]
AS
SELECT        exp_id, exp_resolucionnro
FROM            dbo.Expediente

GO
/****** Object:  View [dbo].[V_lstExpxmateria]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstExpxmateria]
AS
SELECT        exp_id, exp_materia
FROM            dbo.Expediente

GO
/****** Object:  View [dbo].[V_lsttipAbxestado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipAbxestado]
AS
SELECT        tipb_id, tipb_estado
FROM            dbo.Tipo_Abogado

GO
/****** Object:  View [dbo].[V_lsttipAbxdef-inc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipAbxdef-inc]
AS
SELECT        tipb_id, tipb_def_inc
FROM            dbo.Tipo_Abogado

GO
/****** Object:  View [dbo].[V_lsttipdemxreg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipdemxreg]
AS
SELECT        demdo_id, demdo_registro
FROM            dbo.Demandado

GO
/****** Object:  Table [dbo].[Movimiento_Expediente]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento_Expediente](
	[movexp_id] [int] NOT NULL,
	[ab_id] [int] NOT NULL,
	[usu_id] [int] NOT NULL,
	[demte_id] [int] NOT NULL,
	[demdo_id] [int] NOT NULL,
	[anexo_id] [int] NOT NULL,
	[movexp_asunto] [varchar](30) NOT NULL,
	[movexp_fechaing] [date] NULL,
	[movexp_estado] [varchar](20) NOT NULL,
	[movexp_progreso] [varchar](250) NOT NULL,
	[movexp_cantfolios] [varchar](10) NOT NULL,
	[movexp_descripcion] [varchar](50) NOT NULL,
	[movexp_nro_exp] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Movimiento_Expediente] PRIMARY KEY CLUSTERED 
(
	[movexp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstxfechaing]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxfechaing]
AS
SELECT        movexp_id, movexp_fechaing
FROM            dbo.Movimiento_Expediente

GO
/****** Object:  View [dbo].[V_lstxestado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxestado]
AS
SELECT        movexp_id, movexp_estado
FROM            dbo.Movimiento_Expediente

GO
/****** Object:  View [dbo].[V_lstxprogreso]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxprogreso]
AS
SELECT        movexp_id, movexp_progreso
FROM            dbo.Movimiento_Expediente

GO
/****** Object:  View [dbo].[V_lstxapellidospat]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxapellidospat]
AS
SELECT        ab_id, ab_apellidopat
FROM            dbo.Abogado

GO
/****** Object:  View [dbo].[V_lstxdni]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxdni]
AS
SELECT        ab_id, ab_dni
FROM            dbo.Abogado

GO
/****** Object:  View [dbo].[V_lstxnombres]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxnombres]
AS
SELECT        ab_id, ab_nombres
FROM            dbo.Abogado

GO
/****** Object:  Table [dbo].[Anexos]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anexos](
	[anexo_id] [int] IDENTITY(1,1) NOT NULL,
	[anexo_nombre] [varchar](100) NOT NULL,
	[anexo_nombrereal] [varchar](100) NOT NULL,
	[anexo_documento] [varbinary](max) NOT NULL,
	[anexo_fecha] [date] NOT NULL,
 CONSTRAINT [PK_Anexos] PRIMARY KEY CLUSTERED 
(
	[anexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstanxnombre]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstanxnombre]
AS
SELECT        anexo_id, anexo_nombre
FROM            dbo.Anexos

GO
/****** Object:  View [dbo].[V_lstdemxreg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstdemxreg]
AS
SELECT        demte_id, demte_registro
FROM            dbo.Demandante

GO
/****** Object:  View [dbo].[V_lstestusuxcond]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstestusuxcond]
AS
SELECT        id_estusu, est_condi
FROM            dbo.Estado_Usu

GO
/****** Object:  View [dbo].[V_lstestabg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstestabg]
AS
SELECT        estabog, id_estabo
FROM            dbo.Estado_Abogado

GO
/****** Object:  View [dbo].[V_lsttipdocxnom]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipdocxnom]
AS
SELECT        id_tipdoc, tipdoc_nom
FROM            dbo.Tip_documento

GO
/****** Object:  View [dbo].[V_lstdocxexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstdocxexp]
AS
SELECT        dbo.Expediente.doc_id, dbo.Expediente.exp_nrosentencia, dbo.Expediente.exp_expediente, dbo.Expediente.exp_secrejuzg, dbo.Expediente.exp_fechainicio, dbo.Expediente.exp_materia, dbo.Expediente.exp_resolucionnro, 
                         dbo.Expediente.exp_ciudad, dbo.Expediente.exp_fecha, dbo.Expediente.exp_vistos
FROM            dbo.Documento INNER JOIN
                         dbo.Expediente ON dbo.Documento.doc_id = dbo.Expediente.doc_id

GO
/****** Object:  View [dbo].[V_lsttipuxusu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipuxusu]
AS
SELECT        dbo.Usuario.tipusu_id, dbo.Usuario.usu_dni, dbo.Usuario.usu_nombres, dbo.Usuario.usu_apellidopat, dbo.Usuario.usu_apellidomat, dbo.Usuario.usu_telefono, dbo.Usuario.usu_direccion, dbo.Usuario.usu_sexo, 
                         dbo.Usuario.usu_correo, dbo.Usuario.usu_estadocivil, dbo.Usuario.usu_fechanac, dbo.Usuario.usu_ciudad, dbo.Usuario.usu_provincia, dbo.Usuario.usu_departamento
FROM            dbo.Tipo_Usuario INNER JOIN
                         dbo.Usuario ON dbo.Tipo_Usuario.tipusu_id = dbo.Usuario.tipusu_id

GO
/****** Object:  View [dbo].[V_lstuserxmovexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstuserxmovexp]
AS
SELECT        dbo.Movimiento_Expediente.usu_id, dbo.Movimiento_Expediente.movexp_asunto, dbo.Movimiento_Expediente.movexp_fechaing, dbo.Movimiento_Expediente.movexp_estado, dbo.Movimiento_Expediente.movexp_progreso, 
                         dbo.Movimiento_Expediente.movexp_cantfolios, dbo.Movimiento_Expediente.movexp_descripcion
FROM            dbo.Usuario INNER JOIN
                         dbo.Movimiento_Expediente ON dbo.Usuario.usu_id = dbo.Movimiento_Expediente.usu_id

GO
/****** Object:  View [dbo].[V_lstperxtipdoc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstperxtipdoc]
AS
SELECT        dbo.Persona.pers_id, dbo.Tip_documento.tipdoc_nom, dbo.Persona.pers_nombres, dbo.Persona.pers_apepat,dbo.Persona.pers_apemat, dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.pers_numdoc
FROM            dbo.Persona INNER JOIN
                         dbo.Tip_documento ON dbo.Persona.id_tipdoc = dbo.Tip_documento.id_tipdoc

GO
/****** Object:  View [dbo].[V_lstjuzgxexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstjuzgxexp]
AS
SELECT        dbo.Expediente.juzg_id, dbo.Expediente.exp_nrosentencia, dbo.Expediente.exp_expediente, dbo.Expediente.exp_secrejuzg, dbo.Expediente.exp_fechainicio, dbo.Expediente.exp_materia, dbo.Expediente.exp_resolucionnro, 
                         dbo.Historial_Juzgado.juzg_descripcion, dbo.Historial_Juzgado.juzg_fecharecepcion, dbo.Historial_Juzgado.juzg_pronunciamiento, dbo.Historial_Juzgado.juzg_fechaderivacion, dbo.Historial_Juzgado.juzg_fechanotificacion, 
                         dbo.Historial_Juzgado.juzg_fechaemisionresol, dbo.Historial_Juzgado.juzg_fechasolucion
FROM            dbo.Historial_Juzgado INNER JOIN
                         dbo.Expediente ON dbo.Historial_Juzgado.juzg_id = dbo.Expediente.juzg_id

GO
/****** Object:  View [dbo].[V_lstexpxmovexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstexpxmovexp]
AS
SELECT        dbo.Expediente.exp_id, dbo.Movimiento_Expediente.movexp_id, dbo.Movimiento_Expediente.movexp_asunto, dbo.Movimiento_Expediente.movexp_fechaing, dbo.Movimiento_Expediente.movexp_estado, 
                         dbo.Movimiento_Expediente.movexp_progreso, dbo.Movimiento_Expediente.movexp_descripcion, dbo.Expediente.exp_nrosentencia, dbo.Expediente.exp_expediente, dbo.Expediente.exp_secrejuzg, 
                         dbo.Expediente.exp_materia, dbo.Expediente.exp_fechainicio
FROM            dbo.Expediente INNER JOIN
                         dbo.Movimiento_Expediente ON dbo.Expediente.movexp_id = dbo.Movimiento_Expediente.movexp_id

GO
/****** Object:  View [dbo].[V_lstexpxhistjuzg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstexpxhistjuzg]
AS
SELECT        dbo.Expediente.exp_id, dbo.Historial_Juzgado.juzg_descripcion, dbo.Historial_Juzgado.juzg_fecharecepcion, dbo.Historial_Juzgado.juzg_pronunciamiento, dbo.Historial_Juzgado.juzg_fechaderivacion, 
                         dbo.Historial_Juzgado.juzg_fechaemisionresol, dbo.Historial_Juzgado.juzg_fechanotificacion, dbo.Historial_Juzgado.juzg_fechasolucion
FROM            dbo.Expediente INNER JOIN
                         dbo.Historial_Juzgado ON dbo.Expediente.juzg_id = dbo.Historial_Juzgado.juzg_id

GO
/****** Object:  View [dbo].[V_lsttipabxabo]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipabxabo]
AS
SELECT        dbo.Tipo_Abogado.tipb_id, dbo.Tipo_Abogado.tipb_def_inc, dbo.Tipo_Abogado.tipb_descripcion, dbo.Abogado.ab_nombres, dbo.Abogado.ab_apellidopat, dbo.Abogado.ab_apellidomat, dbo.Abogado.ab_dni
FROM            dbo.Tipo_Abogado INNER JOIN
                         dbo.Abogado ON dbo.Tipo_Abogado.tipb_id = dbo.Abogado.tipb_id

GO
/****** Object:  View [dbo].[V_lstDemxPers]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDemxPers]
AS
SELECT        dbo.Demandado.demdo_id, dbo.Persona.pers_nombres,pers_apepat,pers_apemat, dbo.Persona.pers_ciudad, dbo.Persona.pers_provincia, dbo.Persona.pers_departamento, dbo.Persona.pers_domlegal, 
                         dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.id_tipdoc, dbo.Persona.pers_numdoc
FROM            dbo.Demandado INNER JOIN
                         dbo.Persona ON dbo.Demandado.pers_id = dbo.Persona.pers_id

GO
/****** Object:  View [dbo].[V_lstmovexpxexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstmovexpxexp]
AS
SELECT        dbo.Movimiento_Expediente.movexp_id, dbo.Movimiento_Expediente.movexp_asunto, dbo.Movimiento_Expediente.movexp_fechaing, dbo.Movimiento_Expediente.movexp_estado, 
                         dbo.Movimiento_Expediente.movexp_progreso, dbo.Movimiento_Expediente.movexp_cantfolios, dbo.Movimiento_Expediente.movexp_descripcion, dbo.Expediente.exp_nrosentencia, dbo.Expediente.exp_expediente, 
                         dbo.Expediente.exp_fechainicio, dbo.Expediente.exp_secrejuzg
FROM            dbo.Movimiento_Expediente INNER JOIN
                         dbo.Expediente ON dbo.Movimiento_Expediente.movexp_id = dbo.Expediente.movexp_id

GO
/****** Object:  View [dbo].[V_lstabogxestabog]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstabogxestabog]
AS
SELECT        dbo.Abogado.ab_id, dbo.Abogado.ab_nombres, dbo.Abogado.ab_apellidopat, dbo.Abogado.ab_apellidomat, dbo.Abogado.ab_dni, dbo.Estado_Abogado.estabog
FROM            dbo.Abogado INNER JOIN
                         dbo.Estado_Abogado ON dbo.Abogado.id_estabo = dbo.Estado_Abogado.id_estabo

GO
/****** Object:  View [dbo].[V_lstanexmovexp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstanexmovexp]
AS
SELECT        dbo.Anexos.anexo_id, dbo.Anexos.anexo_nombre, dbo.Movimiento_Expediente.movexp_asunto, dbo.Movimiento_Expediente.movexp_fechaing, dbo.Movimiento_Expediente.movexp_estado, 
                         dbo.Movimiento_Expediente.movexp_progreso, dbo.Movimiento_Expediente.movexp_cantfolios, dbo.Movimiento_Expediente.movexp_descripcion
FROM            dbo.Anexos INNER JOIN
                         dbo.Movimiento_Expediente ON dbo.Anexos.anexo_id = dbo.Movimiento_Expediente.anexo_id

GO
/****** Object:  View [dbo].[V_lstDemtexPers]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDemtexPers]
AS
SELECT        dbo.Demandante.demte_id, dbo.Persona.pers_nombres,pers_apepat,pers_apemat, dbo.Persona.pers_ciudad, dbo.Persona.pers_provincia, dbo.Persona.pers_departamento, dbo.Persona.pers_domlegal, 
                         dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.pers_numdoc
FROM            dbo.Demandante INNER JOIN
                         dbo.Persona ON dbo.Demandante.pers_id = dbo.Persona.pers_id

GO
INSERT [dbo].[Persona] ([pers_id], [pers_nombres], [pers_apepat], [pers_apemat], [pers_ciudad], [pers_provincia], [pers_departamento], [pers_domlegal], [pers_telefono], [pers_email], [id_tipdoc], [pers_numdoc], [pers_fenaci]) VALUES (1, N'a', N'a', N'a', N'a', N'a', N'a', N'a', N'1', N'a', 1, CAST(23 AS Numeric(11, 0)), CAST(N'2017-11-20' AS Date))
SET IDENTITY_INSERT [dbo].[Tip_documento] ON 

INSERT [dbo].[Tip_documento] ([id_tipdoc], [tipdoc_nom]) VALUES (1, N'a')
SET IDENTITY_INSERT [dbo].[Tip_documento] OFF
ALTER TABLE [dbo].[Anexos] ADD  CONSTRAINT [DF_anexo_fecha]  DEFAULT (getdate()) FOR [anexo_fecha]
GO
ALTER TABLE [dbo].[Documento] ADD  CONSTRAINT [DF_doc_fecha]  DEFAULT (getdate()) FOR [doc_fecha]
GO
ALTER TABLE [dbo].[Movimiento_Expediente] ADD  CONSTRAINT [DF_movexp_fechaing]  DEFAULT (getdate()) FOR [movexp_fechaing]
GO
ALTER TABLE [dbo].[Abogado]  WITH CHECK ADD  CONSTRAINT [FK_Abogado_Estado_Abogado] FOREIGN KEY([id_estabo])
REFERENCES [dbo].[Estado_Abogado] ([id_estabo])
GO
ALTER TABLE [dbo].[Abogado] CHECK CONSTRAINT [FK_Abogado_Estado_Abogado]
GO
ALTER TABLE [dbo].[Abogado]  WITH CHECK ADD  CONSTRAINT [FK_Abogado_Tipo_Abogado] FOREIGN KEY([tipb_id])
REFERENCES [dbo].[Tipo_Abogado] ([tipb_id])
GO
ALTER TABLE [dbo].[Abogado] CHECK CONSTRAINT [FK_Abogado_Tipo_Abogado]
GO
ALTER TABLE [dbo].[Demandado]  WITH CHECK ADD  CONSTRAINT [FK_Demandado_Persona] FOREIGN KEY([pers_id])
REFERENCES [dbo].[Persona] ([pers_id])
GO
ALTER TABLE [dbo].[Demandado] CHECK CONSTRAINT [FK_Demandado_Persona]
GO
ALTER TABLE [dbo].[Demandante]  WITH CHECK ADD  CONSTRAINT [FK_Demandante_Persona] FOREIGN KEY([pers_id])
REFERENCES [dbo].[Persona] ([pers_id])
GO
ALTER TABLE [dbo].[Demandante] CHECK CONSTRAINT [FK_Demandante_Persona]
GO
ALTER TABLE [dbo].[Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Expediente_Documento] FOREIGN KEY([doc_id])
REFERENCES [dbo].[Documento] ([doc_id])
GO
ALTER TABLE [dbo].[Expediente] CHECK CONSTRAINT [FK_Expediente_Documento]
GO
ALTER TABLE [dbo].[Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Expediente_Historial_Juzgado] FOREIGN KEY([juzg_id])
REFERENCES [dbo].[Historial_Juzgado] ([juzg_id])
GO
ALTER TABLE [dbo].[Expediente] CHECK CONSTRAINT [FK_Expediente_Historial_Juzgado]
GO
ALTER TABLE [dbo].[Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Expediente_Movimiento_Expediente] FOREIGN KEY([movexp_id])
REFERENCES [dbo].[Movimiento_Expediente] ([movexp_id])
GO
ALTER TABLE [dbo].[Expediente] CHECK CONSTRAINT [FK_Expediente_Movimiento_Expediente]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Abogado] FOREIGN KEY([ab_id])
REFERENCES [dbo].[Abogado] ([ab_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Abogado]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Abogado1] FOREIGN KEY([ab_id])
REFERENCES [dbo].[Abogado] ([ab_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Abogado1]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Anexos] FOREIGN KEY([anexo_id])
REFERENCES [dbo].[Anexos] ([anexo_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Anexos]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Demandado] FOREIGN KEY([demdo_id])
REFERENCES [dbo].[Demandado] ([demdo_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Demandado]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Demandante] FOREIGN KEY([demte_id])
REFERENCES [dbo].[Demandante] ([demte_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Demandante]
GO
ALTER TABLE [dbo].[Movimiento_Expediente]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Expediente_Usuario] FOREIGN KEY([usu_id])
REFERENCES [dbo].[Usuario] ([usu_id])
GO
ALTER TABLE [dbo].[Movimiento_Expediente] CHECK CONSTRAINT [FK_Movimiento_Expediente_Usuario]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Tip_documento] FOREIGN KEY([id_tipdoc])
REFERENCES [dbo].[Tip_documento] ([id_tipdoc])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Tip_documento]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Estado_Usu] FOREIGN KEY([id_estusu])
REFERENCES [dbo].[Estado_Usu] ([id_estusu])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Estado_Usu]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Tipo_Usuario] FOREIGN KEY([tipusu_id])
REFERENCES [dbo].[Tipo_Usuario] ([tipusu_id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Tipo_Usuario]
GO
ALTER TABLE [dbo].[Expediente]  WITH CHECK ADD  CONSTRAINT [CHK_exp_fechainicio] CHECK  (([exp_fechainicio]<=getdate()))
GO
ALTER TABLE [dbo].[Expediente] CHECK CONSTRAINT [CHK_exp_fechainicio]
GO
ALTER TABLE [dbo].[Historial_Juzgado]  WITH CHECK ADD  CONSTRAINT [CHK_juzg_fechaderivacion] CHECK  (([juzg_fechaderivacion]<=getdate()))
GO
ALTER TABLE [dbo].[Historial_Juzgado] CHECK CONSTRAINT [CHK_juzg_fechaderivacion]
GO
ALTER TABLE [dbo].[Historial_Juzgado]  WITH CHECK ADD  CONSTRAINT [CHK_juzg_fechaemisionresol] CHECK  (([juzg_fechaemisionresol]<=getdate()))
GO
ALTER TABLE [dbo].[Historial_Juzgado] CHECK CONSTRAINT [CHK_juzg_fechaemisionresol]
GO
ALTER TABLE [dbo].[Historial_Juzgado]  WITH CHECK ADD  CONSTRAINT [CHK_juzg_fechanotificacion] CHECK  (([juzg_fechanotificacion]<=getdate()))
GO
ALTER TABLE [dbo].[Historial_Juzgado] CHECK CONSTRAINT [CHK_juzg_fechanotificacion]
GO
ALTER TABLE [dbo].[Historial_Juzgado]  WITH CHECK ADD  CONSTRAINT [CHK_juzg_fecharecepcion] CHECK  (([juzg_fecharecepcion]<=getdate()))
GO
ALTER TABLE [dbo].[Historial_Juzgado] CHECK CONSTRAINT [CHK_juzg_fecharecepcion]
GO
ALTER TABLE [dbo].[Historial_Juzgado]  WITH CHECK ADD  CONSTRAINT [CHK_juzg_fechasolucion] CHECK  (([juzg_fechasolucion]<=getdate()))
GO
ALTER TABLE [dbo].[Historial_Juzgado] CHECK CONSTRAINT [CHK_juzg_fechasolucion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CHK_usu_fechanac] CHECK  (([usu_fechanac]<=getdate()))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CHK_usu_fechanac]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_abogado]
(
 @ab_id int,
 @tipb_id int,
 @ab_nombres varchar(30),
 @ab_apellidopat varchar(30),
 @ab_apellidomat varchar(30),
@id_estabo int,
 @ab_dni char(8)
) 
as
update Abogado set @tipb_id = tipb_id, @ab_nombres = ab_nombres, @ab_apellidopat = ab_apellidopat, @ab_apellidomat = ab_apellidomat,
 @id_estabo = id_estabo, @ab_dni = ab_dni
where @ab_id = ab_id





GO
/****** Object:  StoredProcedure [dbo].[actualizar_doc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_doc]
(
@doc_id int,
 @doc_nombre varchar(100),
 @doc_nombrereal varchar(100),
 @doc_documento varbinary(max),
 @doc_fecha date

) 
as
update Documento set @doc_nombre = doc_nombre, @doc_nombrereal = doc_nombrereal, @doc_fecha = doc_fecha
where @doc_id = doc_id


GO
/****** Object:  StoredProcedure [dbo].[actualizar_Estabog]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Estabog]
(
@id_estabo int,
@estabog varchar(20)
) 
as
update Estado_Abogado set  @estabog = estabog
where @id_estabo = id_estabo

GO
/****** Object:  StoredProcedure [dbo].[actualizar_Estusu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Estusu]
(
@id_estusu int,
@est_condi varchar(20)
) 
as
update Estado_Usu set  @est_condi = est_condi
where @id_estusu = id_estusu

GO
/****** Object:  StoredProcedure [dbo].[actualizar_exp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_exp]
(
 @exp_id int,
 @movexp int,
 @juzg_id int,
 @doc int,
 @exp_nrosentencia varchar(30),
 @exp_expediente varchar(30),
 @exp_secrejuzg varchar(30),
 @exp_fechainicio date,
 @exp_materia varchar(30),
 @exp_resolucionnro varchar(30),
 @exp_ciudad varchar(30),
 @exp_fecha varchar(30),
 @exp_vistos varchar(30)
) 
as
update Expediente set @movexp = movexp_id, @juzg_id = juzg_id, @doc = doc_id, @exp_nrosentencia = exp_nrosentencia,
 @exp_expediente = exp_expediente, @exp_secrejuzg = exp_secrejuzg, @exp_fechainicio = exp_fechainicio, @exp_materia = exp_materia, @exp_resolucionnro = exp_resolucionnro, @exp_ciudad = exp_ciudad,@exp_fecha=exp_fecha,@exp_vistos= exp_vistos
where @exp_id = exp_id





GO
/****** Object:  StoredProcedure [dbo].[actualizar_HisJuz]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_HisJuz]
(
@juzg_id int,
 @juzg_descripcion varchar(50),
 @juzg_fecharecepcion date,
 @juzg_pronunciamiento varchar(50),
 @juzg_fechaderivacion date,
 @juzg_fechaemisionresol date,
 @juzg_fechanotificacion date,
 @juzg_fechasolucion date


) 
as
update Historial_Juzgado set  @juzg_descripcion = juzg_descripcion, @juzg_fecharecepcion = juzg_fecharecepcion, @juzg_pronunciamiento = juzg_pronunciamiento,
@juzg_fechaderivacion = juzg_fechaderivacion, @juzg_fechanotificacion = juzg_fechanotificacion,@juzg_fechasolucion = juzg_fechasolucion
where @juzg_id = juzg_id



GO
/****** Object:  StoredProcedure [dbo].[actualizar_MovExp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_MovExp]
(
 @movexp_id int,
 @ab_id int,
 @usu_id int,
 @demte_id int,
 @demdo_id int,
 @anexo_id int,
 @movexp_asunto varchar(30),
 @movexp_fechaing date,
 @movexp_estado varchar(20),
 @movexp_progreso varchar(30),
 @movexp_cantfolios varchar(50),
 @movexp_descripcion varchar(50)
) 
as
update Movimiento_Expediente set  @ab_id = ab_id, @usu_id = usu_id, @demte_id = demte_id,
 @demdo_id = demdo_id, @anexo_id = anexo_id, @movexp_asunto = movexp_asunto, @movexp_fechaing = movexp_fechaing, @movexp_estado = movexp_estado, 
 @movexp_progreso = movexp_progreso,@movexp_cantfolios=movexp_cantfolios,@movexp_descripcion= movexp_descripcion
where @movexp_id = movexp_id

GO
/****** Object:  StoredProcedure [dbo].[actualizar_pers]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_pers]
(
 @pers_id int,
 @pers_nombres varchar(20),
 @pers_apepat varchar(25),
 @pers_apemat varchar(25),
 @pers_ciudad varchar(20),
 @pers_provincia varchar(20),
 @pers_departamento varchar(20),
 
 @pers_domlegal varchar(20),
 @pers_telefono varchar(13),
 @pers_email varchar(30),
 @id_tipdoc int,
 @pers_numdoc numeric(11,0),
 @pers_fenaci date
 
) 
as
update Persona set @pers_nombres = pers_nombres,@pers_apepat = @pers_apepat,@pers_apemat = @pers_apemat, @pers_ciudad = pers_ciudad, @pers_provincia = pers_provincia,
 @pers_departamento = pers_departamento, @pers_domlegal = pers_domlegal, @pers_telefono = pers_telefono, @pers_email = pers_email, 
 @id_tipdoc = id_tipdoc,@pers_numdoc=pers_numdoc,@pers_fenaci=@pers_fenaci
where @pers_id = pers_id 
GO
/****** Object:  StoredProcedure [dbo].[actualizar_TipAbg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_TipAbg]
(
  @tipb_id int,
 @tipb_def_inc varchar(20),
 @tipb_estado varchar(20),
 @tipb_descripcion varchar(50)
) 
as
update Tipo_Abogado set  @tipb_def_inc = tipb_def_inc, @tipb_estado = tipb_estado, @tipb_descripcion = tipb_descripcion 
where @tipb_id = tipb_id



GO
/****** Object:  StoredProcedure [dbo].[actualizar_Tipodoc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Tipodoc]
(
@id_tipdoc int,
@tipdoc_nom varchar(35)
) 
as
update Tip_documento set  @tipdoc_nom = @tipdoc_nom
where @id_tipdoc = @id_tipdoc

GO
/****** Object:  StoredProcedure [dbo].[actualizar_TipUsu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_TipUsu]
(
 @tipusu_id int,
 @tipusu_tipousuario varchar(20),
 @tipusu_descripcion varchar(20)
) 
as
update Tipo_Usuario set  @tipusu_tipousuario = tipusu_tipousuario, @tipusu_descripcion = tipusu_descripcion
where @tipusu_id = tipusu_id



GO
/****** Object:  StoredProcedure [dbo].[actualizar_Usu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Usu]
(
@usu_id int,
 @tipusu_id int,
 @usu_dni char(8),
 @usu_nombres varchar(20),
 @usu_apellidopat varchar(20),
 @usu_apellidomat varchar(20),
 @usu_telefono varchar(15),
 @usu_direccion varchar(40),
 @usu_sexo varchar(20),
 @usu_correo varchar(20),
 @usu_estadocivil varchar(15),
 @usu_fechanac date,
 @usu_ciudad varchar(20),
 @usu_provincia varchar(20),
 @id_estusu int,
 @usu_departamento varchar(20)
) 
as
update Usuario set  @tipusu_id = tipusu_id, @usu_dni = usu_dni, @usu_nombres = usu_nombres,
 @usu_apellidopat = usu_apellidopat, @usu_apellidomat = usu_apellidomat, @usu_telefono = usu_telefono,
  @usu_direccion = usu_direccion, @usu_sexo = usu_sexo, @usu_correo = usu_correo,@usu_estadocivil=usu_estadocivil,@usu_fechanac= usu_fechanac,
  @usu_ciudad= usu_ciudad,@usu_provincia= usu_provincia,@id_estusu= @id_estusu, @usu_departamento = usu_departamento
where @usu_id = usu_id

GO
/****** Object:  StoredProcedure [dbo].[ActualizarAnexos]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ActualizarAnexos]
(
 @id_anexo int,
 @anexo_nombre varchar(100),
 @anexo_nombrereal varchar(100),
 @anexo_documento varbinary(max),
 @anexo_fecha date
) 
as
update Anexos set @anexo_nombre = anexo_nombre, @anexo_nombrereal = anexo_nombrereal, @anexo_documento = anexo_documento, @anexo_fecha = anexo_fecha
where @id_anexo = anexo_id





GO
/****** Object:  StoredProcedure [dbo].[insertar_Abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Abogado]

( @ab_id int,
 @tipb_id int,
 @ab_nombres varchar(30),
 @ab_apellidopat varchar(30),
 @ab_apellidomat varchar(30),
 @ab_estado varchar(30),
 @ab_dni char(8)
 

 )
AS
begin
 insert into Abogado(ab_id, [tipb_id], [ab_nombres], [ab_apellidopat], [ab_apellidomat], [id_estabo], [ab_dni])
  values (@ab_id, @tipb_id, @ab_nombres, @ab_apellidopat, @ab_apellidomat,@ab_estado, @ab_dni)
end





GO
/****** Object:  StoredProcedure [dbo].[insertar_doc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_doc]

(@doc_id int,
 @doc_nombre varchar(100),
 @doc_nombrereal varchar(100),
 @doc_documento varbinary(max),
 @doc_fecha date


 )
AS
begin
 insert into Documento([doc_id], [doc_nombre], [doc_nombrereal], [doc_documento], [doc_fecha])
  values (@doc_id, @doc_nombre, @doc_nombrereal, @doc_documento, @doc_fecha)
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_Estabog]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Estabog]

( @id_estabo int,
 @estabog varchar(20)
 )
AS
begin
 insert into Estado_Abogado([id_estabo], [estabog])
  values (@id_estabo, @estabog)
End

GO
/****** Object:  StoredProcedure [dbo].[insertar_Estusu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Estusu]

( @id_estusu int,
 @est_condi varchar(20)
 )
AS
begin
 insert into Estado_Usu([id_estusu], [est_condi])
  values (@id_estusu, @est_condi)
End

GO
/****** Object:  StoredProcedure [dbo].[insertar_exp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_exp]

( @exp_id int,
 @movexp int,
 @juzg_id int,
 @doc int,
 @exp_nrosentencia varchar(30),
 @exp_expediente varchar(30),
 @exp_secrejuzg varchar(30),
 @exp_fechainicio date,
 @exp_materia varchar(30),
 @exp_resolucionnro varchar(30),
 @exp_ciudad varchar(30),
 @exp_fecha varchar(30),
 @exp_vistos varchar(30)

 )
AS
begin
 insert into Expediente([exp_id], [movexp_id], [juzg_id], [doc_id], [exp_nrosentencia], [exp_expediente], [exp_secrejuzg], [exp_fechainicio], [exp_materia], [exp_resolucionnro], [exp_ciudad], [exp_fecha], [exp_vistos]) values (@exp_id, @movexp, @juzg_id, @doc, @exp_nrosentencia,@exp_expediente, @exp_secrejuzg, @exp_fechainicio, @exp_materia,@exp_resolucionnro,@exp_ciudad,@exp_fecha,@exp_vistos)
end





GO
/****** Object:  StoredProcedure [dbo].[insertar_HisJuz]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_HisJuz]

(@juzg_id int,
 @juzg_descripcion varchar(50),
 @juzg_fecharecepcion date,
 @juzg_pronunciamiento varchar(50),
 @juzg_fechaderivacion date,
 @juzg_fechaemisionresol date,
 @juzg_fechanotificacion date,
 @juzg_fechasolucion date


 )
AS
begin
 insert into Historial_Juzgado([juzg_id], [juzg_descripcion], [juzg_fecharecepcion], [juzg_pronunciamiento], [juzg_fechaderivacion],[juzg_fechaemisionresol],
 [juzg_fechanotificacion],[juzg_fechasolucion])
  values (@juzg_id, @juzg_descripcion, @juzg_fecharecepcion, @juzg_pronunciamiento, @juzg_fechaderivacion,@juzg_fechaemisionresol,@juzg_fechanotificacion,@juzg_fechasolucion)
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_MovExp]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_MovExp]

( @movexp_id int,
 @ab_id int,
 @usu_id int,
 @demte_id int,
 @demdo_id int,
 @anexo_id int,
 @movexp_asunto varchar(30),
 @movexp_fechaing date,
 @movexp_estado varchar(20),
 @movexp_progreso varchar(250),
 @movexp_cantfolios varchar(10),
 @movexp_descripcion varchar(50)

 )
AS
begin
 insert into Movimiento_Expediente([movexp_id], [ab_id], [usu_id], [demte_id], 
 [demdo_id], [anexo_id], [movexp_asunto], [movexp_fechaing], [movexp_estado], [movexp_progreso], [movexp_cantfolios], [movexp_descripcion])
  values (@ab_id, @usu_id, @demte_id, @usu_id, @demdo_id,@anexo_id, @movexp_asunto, @movexp_fechaing, @movexp_estado,@movexp_progreso,@movexp_cantfolios,@movexp_descripcion)
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_Persona]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Persona]

(@pers_id int,
 @pers_nombres varchar(20),
 @pers_apepat varchar(25),
 @pers_apemat varchar(25),
 @pers_ciudad varchar(20),
 @pers_provincia varchar(20),
 @pers_departamento varchar(20),
 
 @pers_domlegal varchar(20),
 @pers_telefono varchar(13),
 @pers_email varchar(30),
 @id_tipdoc int,
 @pers_numdoc numeric(11,0),
 @pers_fenaci date

 )
AS
begin
 insert into Persona(pers_id, pers_nombres,pers_apepat,pers_apemat, pers_ciudad, pers_provincia, 
 pers_departamento,  pers_domlegal, pers_telefono, pers_email, id_tipdoc, pers_numdoc,pers_fenaci)
  values (@pers_id, @pers_nombres,@pers_apepat,@pers_apemat, @pers_ciudad, @pers_provincia, @pers_departamento, @pers_domlegal, @pers_telefono, 
  @pers_email,@id_tipdoc,@pers_numdoc,@pers_fenaci)
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_TipAbg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_TipAbg]

( @tipb_id int,
 @tipb_def_inc varchar(20),
 @tipb_estado varchar(20),
 @tipb_descripcion varchar(50)

 )
AS
begin
 insert into Tipo_Abogado([tipb_id], [tipb_def_inc], [tipb_estado], [tipb_descripcion])
  values (@tipb_id, @tipb_def_inc, @tipb_estado, @tipb_descripcion)
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_Tipodoc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Tipodoc]

( @id_tipdoc int,
 @tipdoc_nom varchar(35)
 )
AS
begin
 insert into Tip_documento([id_tipdoc], [tipdoc_nom])
  
  values (@id_tipdoc, @tipdoc_nom )
End

GO
/****** Object:  StoredProcedure [dbo].[insertar_TipUsu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_TipUsu]

( @tipusu_id int,
 @tipusu_tipousuario varchar(20),
 @tipusu_descripcion varchar(20)

 )
AS
begin
 insert into Tipo_Usuario([tipusu_id], [tipusu_tipousuario], [tipusu_descripcion])
  values (@tipusu_id, @tipusu_tipousuario, @tipusu_descripcion)
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_Usu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Usu]

( @usu_id int,
 @tipusu_id int,
 @usu_dni char(8),
 @usu_nombres varchar(20),
 @usu_apellidopat varchar(20),
 @usu_apellidomat varchar(20),
 @usu_telefono varchar(15),
 @usu_direccion varchar(40),
 @usu_sexo varchar(20),
 @usu_correo varchar(20),
 @usu_estadocivil varchar(15),
 @usu_fechanac date,
 @usu_ciudad varchar(20),
 @usu_provincia varchar(20),
 @id_estusu int,
 @usu_departamento varchar(20),
 @usu_contraseña varchar(30)

 )
AS
begin
 insert into Usuario([usu_id], [tipusu_id], [usu_dni], [usu_nombres], [usu_apellidopat], 
 [usu_apellidomat], [usu_telefono], [usu_direccion], [usu_sexo], [usu_correo], [usu_estadocivil], [usu_fechanac], [usu_ciudad], 
 [usu_provincia],  id_estusu , [usu_departamento],usu_contraseña)
  values (@usu_id, @tipusu_id, @usu_dni, @usu_nombres, @usu_apellidopat,@usu_apellidomat, @usu_telefono, @usu_direccion, @usu_sexo,
  @usu_correo,@usu_estadocivil,@usu_fechanac,@usu_ciudad, @usu_provincia, @id_estusu, @usu_departamento,@usu_contraseña)
End

GO
/****** Object:  StoredProcedure [dbo].[InsertarAnexos]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[InsertarAnexos]

( @id_anexo int,
 @anexo_nombre varchar(100),
 @anexo_nombrereal varchar(100),
 @anexo_documento varbinary(max),
 @anexo_fecha date
 )
AS
begin
 insert into Anexos([anexo_id], [anexo_nombre], [anexo_nombrereal], [anexo_documento], [anexo_fecha]) values (@id_anexo, @anexo_nombre, @anexo_nombrereal, @anexo_documento, @anexo_fecha)
end





GO
/****** Object:  StoredProcedure [dbo].[NuevaContrasena]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[NuevaContrasena]

           @correo varchar (60),
            @contrasena char(30)

                AS

              UPDATE Usuario SET usu_contraseña=@contrasena

              FROM Usuario 
               WHERE usu_correo=@correo

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_demandado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_demandado]

@demdo_id int,
 @pers_id int,
  @demdo_registro varchar(20)
as
begin
update Demandado
set pers_id=@pers_id , demdo_registro=@demdo_registro
where Demandado.demdo_id=@demdo_id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_demandante]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_actualizar_demandante]

@demte_id int,
 @pers_id int,
  @demte_registro varchar(20)
as
begin
update Demandante
set pers_id=@pers_id , demte_registro=@demte_registro
where Demandante.demte_id=@demte_id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_estadoabog]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_estadoabog]

@id_estabo int,
@estabog  varchar(20)

as
begin
update Estado_Abogado
set estabog=@estabog
where Estado_Abogado.id_estabo=@id_estabo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_estadousu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_estadousu]

@id_estusu int,
@est_condi varchar(20)

as
begin
update Estado_Usu
set est_condi=@est_condi
where Estado_Usu.id_estusu=@id_estusu
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_expediente]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_expediente]

@exp_id  int,
@movexp_id  int,
@juzg_id  int,
@doc_id  int,
@exp_nrosentencia  varchar(30),
@exp_expediente varchar(30),
@exp_secrejuzg varchar(30),
@exp_fechainicio date,
@exp_materia varchar(30),
@exp_resolucionnro varchar(30),
@exp_ciudad varchar(30),
@exp_fecha date,
@exp_vistos varchar(30)
as
begin
update Expediente
set exp_id=@exp_id , 
movexp_id=@movexp_id,
juzg_id=@juzg_id,
doc_id=@doc_id,
exp_nrosentencia=@exp_nrosentencia,
exp_expediente=@exp_expediente,
exp_secrejuzg=@exp_secrejuzg,
exp_fechainicio=@exp_fechainicio,
exp_materia=@exp_materia,
exp_resolucionnro=@exp_resolucionnro,
exp_ciudad=@exp_ciudad,
exp_fecha=@exp_fecha,
exp_vistos=@exp_vistos
where Expediente.exp_id=@exp_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_historialjuzg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_historialjuzg]

@juzg_id     int,
@juzg_descripcion varchar(50),
@juzg_fecharecepcion date,
@juzg_pronunciamiento varchar(50),
@juzg_fechaderivacion date,
@juzg_fechaemisionresol date,
@juzg_fechanotificacion date,
@juzg_fechasolucion date
as
begin
update Historial_Juzgado
set juzg_id=@juzg_id , juzg_descripcion=@juzg_descripcion,
juzg_fecharecepcion=@juzg_fecharecepcion,
juzg_pronunciamiento=@juzg_pronunciamiento,
juzg_fechaderivacion=@juzg_fechaderivacion,
juzg_fechaemisionresol=@juzg_fechaemisionresol,
juzg_fechanotificacion=@juzg_fechanotificacion,
juzg_fechasolucion=@juzg_fechasolucion
where Historial_Juzgado.juzg_id=@juzg_id
end


GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_tipo_abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_tipo_abogado]

@tipb_id  int,
@tipb_def_inc varchar(20),
@tipb_estado varchar(20),
@tipb_descripcion varchar(50)
as
begin
update Tipo_Abogado
set tipb_id=@tipb_id , tipb_def_inc=@tipb_def_inc ,tipb_estado=@tipb_estado,
tipb_descripcion=@tipb_descripcion
where Tipo_Abogado.tipb_id=@tipb_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_tipo_usuario]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_tipo_usuario]

@tipusu_id int,
@tipusu_tipousuario varchar(20),
@tipusu_descripcion varchar(30)
as
begin
update Tipo_Usuario
set tipusu_id=@tipusu_id, tipusu_tipousuario=@tipusu_tipousuario,
tipusu_descripcion=@tipusu_descripcion

where Tipo_Usuario.tipusu_id=@tipusu_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_tipodoc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar_tipodoc]

@id_tipdoc int,
@tipdoc_nom  varchar(35)

as
begin
update Tip_documento
set tipdoc_nom=@tipdoc_nom
where Tip_documento.id_tipdoc=@id_tipdoc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_demandado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_demandado]
( 
@demdo_id    int,
@pers_id     int ,
@demdo_registro varchar(20)
 )
AS
begin
insert into Demandado([demdo_id], [pers_id] , [demdo_registro] ) 
values (@demdo_id , @pers_id , @demdo_registro)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_demandante]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_demandante]
( 
@demte_id     int,
@pers_id     int ,
@demte_registro varchar(20)
 )
AS
begin
insert into Demandante([demte_id ], [pers_id] , [demte_registro] ) 
values (@demte_id  , @pers_id , @demte_registro)
End

GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_estadoabog]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_estadoabog]
( 
@estabog  varchar(20)
 )
AS
begin
 insert into Estado_Abogado( [estabog])
  values ( @estabog)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_estadousu]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_estadousu]
( 
@est_condi  varchar(20)
 )
AS
begin
 insert into Estado_Usu( [est_condi])
  values ( @est_condi)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_expediente]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE Procedure [dbo].[sp_insertar_expediente]
( 
@exp_id  int,
@movexp_id  int,
@juzg_id  int,
@doc_id  int,
@exp_nrosentencia  varchar(30),
@exp_expediente varchar(30),
@exp_secrejuzg varchar(30),
@exp_fechainicio date,
@exp_materia varchar(30),
@exp_resolucionnro varchar(30),
@exp_ciudad varchar(30),
@exp_fecha date,
@exp_vistos varchar(30)
 )
AS
begin
insert into Expediente([exp_id], [movexp_id] , 
[juzg_id] ,[doc_id],
[exp_nrosentencia],[exp_expediente],
[exp_secrejuzg],[exp_fechainicio],[exp_materia]
,[exp_resolucionnro],[exp_ciudad],[exp_fecha],
[exp_vistos]) 

values (@exp_id, @movexp_id , 
@juzg_id,@doc_id,
@exp_nrosentencia,@exp_expediente
,@exp_secrejuzg,@exp_fechainicio,@exp_materia
,@exp_resolucionnro,@exp_ciudad,@exp_fecha,@exp_vistos
)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_historialjuzg]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE Procedure [dbo].[sp_insertar_historialjuzg]
( 
@juzg_id     int,
@juzg_descripcion varchar(50),
@juzg_fecharecepcion date,
@juzg_pronunciamiento varchar(50),
@juzg_fechaderivacion date,
@juzg_fechaemisionresol date,
@juzg_fechanotificacion date,
@juzg_fechasolucion date
 )
AS
begin
insert into Historial_Juzgado([juzg_id], [juzg_descripcion] , 
[juzg_fecharecepcion] ,[juzg_pronunciamiento],
[juzg_fechaderivacion],[juzg_fechaemisionresol],
[juzg_fechanotificacion],[juzg_fechasolucion]) 
values (@juzg_id, @juzg_descripcion , 
@juzg_fecharecepcion,@juzg_pronunciamiento,
@juzg_fechaderivacion,@juzg_fechaemisionresol
,@juzg_fechanotificacion,@juzg_fechasolucion
)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_tipo_abogado]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_tipo_abogado]
( 
@tipb_id  int,
@tipb_def_inc varchar(20),
@tipb_estado varchar(20),
@tipb_descripcion varchar(50)
 )
AS
begin
 insert into Tipo_Abogado( [tipb_id],[tipb_def_inc],[tipb_estado],
 [tipb_descripcion])
  values ( @tipb_id,@tipb_def_inc,@tipb_estado,@tipb_descripcion)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_tipo_usuario]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_tipo_usuario]
( 
@tipusu_id int,
@tipusu_tipousuario varchar(20),
@tipusu_descripcion varchar(30)

 )
AS
begin
 insert into Tipo_Usuario( [tipusu_id],[tipusu_tipousuario],[tipusu_descripcion])

  values ( @tipusu_id ,@tipusu_tipousuario,@tipusu_descripcion)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_tipodoc]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_insertar_tipodoc]
( 
@tipdoc_nom  varchar(35)
 )
AS
begin
 insert into Tip_documento( [tipdoc_nom])
  values ( @tipdoc_nom)
End
GO
/****** Object:  StoredProcedure [dbo].[ValidarCorreo]    Script Date: 10/07/2019 1:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ValidarCorreo]

                      @correo varchar(60)

                      AS

                     SELECT * FROM Usuario WHERE @correo=usu_correo


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona'
GO
