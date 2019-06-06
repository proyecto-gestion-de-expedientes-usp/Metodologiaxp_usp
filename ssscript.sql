USE [consultoriojur]
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 30/05/2019 18:51:47 ******/
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
/****** Object:  View [dbo].[V_lstDocxnom]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDocxnom]
AS
SELECT        doc_nombre, doc_id
FROM            dbo.Documento
GO
/****** Object:  View [dbo].[V_lstDocxnomreal]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDocxnomreal]
AS
SELECT        doc_nombrereal, doc_id
FROM            dbo.Documento
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V _lsttipousuarioxtipous]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V _lsttipousuarioxtipous]
AS
SELECT        tipusu_tipousuario, tipusu_id
FROM            dbo.Tipo_Usuario
GO
/****** Object:  View [dbo].[V_lsttipousuarioxdescripcion]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipousuarioxdescripcion]
AS
SELECT        tipusu_tipousuario, tipusu_descripcion, tipusu_id
FROM            dbo.Tipo_Usuario
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/05/2019 18:51:48 ******/
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
	[usu_estadocivil] [varchar](15) NOT NULL,
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
/****** Object:  View [dbo].[V_lstusuarioxciudad]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxciudad]
AS
SELECT        usu_ciudad, usu_id
FROM            dbo.Usuario
GO
/****** Object:  View [dbo].[V_lstusuarioxprovincia]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxprovincia]
AS
SELECT        usu_id, usu_provincia
FROM            dbo.Usuario
GO
/****** Object:  View [dbo].[V_lstusuarioxdepartamento]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstusuarioxdepartamento]
AS
SELECT        usu_id, usu_departamento
FROM            dbo.Usuario
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[pers_id] [int] NOT NULL,
	[pers_nombres] [varchar](20) NOT NULL,
	[pers_ciudad] [varchar](20) NOT NULL,
	[pers_provincia] [varchar](20) NOT NULL,
	[pers_departamento] [varchar](20) NOT NULL,
	[pers_ubigeo] [varchar](20) NOT NULL,
	[pers_domlegal] [varchar](20) NOT NULL,
	[pers_telefono] [varchar](15) NOT NULL,
	[pers_email] [varchar](30) NOT NULL,
	[id_tipdoc] [int] NOT NULL,
	[pers_numdoc] [numeric](11, 0) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[pers_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstpersonaxciudad]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxciudad]
AS
SELECT        pers_id, pers_ciudad
FROM            dbo.Persona
GO
/****** Object:  View [dbo].[V_lstpersonaxprovincia]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxprovincia]
AS
SELECT        pers_id, pers_provincia
FROM            dbo.Persona
GO
/****** Object:  View [dbo].[V_lstpersonaxdepartamento]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstpersonaxdepartamento]
AS
SELECT        pers_id, pers_departamento
FROM            dbo.Persona
GO
/****** Object:  Table [dbo].[Historial_Juzgado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstHistdeJuzgxFechSol]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxFechSol]
AS
SELECT        juzg_id, juzg_fechasolucion
FROM            dbo.Historial_Juzgado
GO
/****** Object:  View [dbo].[V_lstHistdeJuzgxFechRec]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxFechRec]
AS
SELECT        juzg_id, juzg_fecharecepcion
FROM            dbo.Historial_Juzgado
GO
/****** Object:  View [dbo].[V_lstHistdeJuzgxdescr]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstHistdeJuzgxdescr]
AS
SELECT        juzg_id, juzg_descripcion
FROM            dbo.Historial_Juzgado
GO
/****** Object:  Table [dbo].[Expediente]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstExpxnumero]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstExpxnumero]
AS
SELECT        exp_id, exp_resolucionnro
FROM            dbo.Expediente
GO
/****** Object:  View [dbo].[V_lstExpxmateria]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstExpxmateria]
AS
SELECT        exp_id, exp_materia
FROM            dbo.Expediente
GO
/****** Object:  Table [dbo].[Tipo_Abogado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lsttipAbxestado]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipAbxestado]
AS
SELECT        tipb_id, tipb_estado
FROM            dbo.Tipo_Abogado
GO
/****** Object:  View [dbo].[V_lsttipAbxdef-inc]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipAbxdef-inc]
AS
SELECT        tipb_id, tipb_def_inc
FROM            dbo.Tipo_Abogado
GO
/****** Object:  Table [dbo].[Demandado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lsttipdemxreg]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipdemxreg]
AS
SELECT        demdo_id, demdo_registro
FROM            dbo.Demandado
GO
/****** Object:  Table [dbo].[Movimiento_Expediente]    Script Date: 30/05/2019 18:51:48 ******/
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
 CONSTRAINT [PK_Movimiento_Expediente] PRIMARY KEY CLUSTERED 
(
	[movexp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstxfechaing]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxfechaing]
AS
SELECT        movexp_id, movexp_fechaing
FROM            dbo.Movimiento_Expediente
GO
/****** Object:  View [dbo].[V_lstxestado]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxestado]
AS
SELECT        movexp_id, movexp_estado
FROM            dbo.Movimiento_Expediente
GO
/****** Object:  View [dbo].[V_lstxprogreso]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxprogreso]
AS
SELECT        movexp_id, movexp_progreso
FROM            dbo.Movimiento_Expediente
GO
/****** Object:  Table [dbo].[Abogado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstxapellidospat]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxapellidospat]
AS
SELECT        ab_id, ab_apellidopat
FROM            dbo.Abogado
GO
/****** Object:  View [dbo].[V_lstxdni]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxdni]
AS
SELECT        ab_id, ab_dni
FROM            dbo.Abogado
GO
/****** Object:  View [dbo].[V_lstxnombres]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstxnombres]
AS
SELECT        ab_id, ab_nombres
FROM            dbo.Abogado
GO
/****** Object:  Table [dbo].[Anexos]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anexos](
	[anexo_id] [int] NOT NULL,
	[anexo_nombre] [varchar](100) NOT NULL,
	[anexo_nombrereal] [varchar](100) NOT NULL,
	[anexo_documento] [varbinary](max) NOT NULL,
	[anexo_fecha] [date] NULL,
 CONSTRAINT [PK_Anexos] PRIMARY KEY CLUSTERED 
(
	[anexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_lstanxnombre]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstanxnombre]
AS
SELECT        anexo_id, anexo_nombre
FROM            dbo.Anexos
GO
/****** Object:  Table [dbo].[Demandante]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstdemxreg]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstdemxreg]
AS
SELECT        demte_id, demte_registro
FROM            dbo.Demandante
GO
/****** Object:  Table [dbo].[Estado_Usu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstestusuxcond]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstestusuxcond]
AS
SELECT        id_estusu, est_condi
FROM            dbo.Estado_Usu
GO
/****** Object:  Table [dbo].[Estado_Abogado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstestabg]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstestabg]
AS
SELECT        estabog, id_estabo
FROM            dbo.Estado_Abogado
GO
/****** Object:  Table [dbo].[Tip_documento]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lsttipdocxnom]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lsttipdocxnom]
AS
SELECT        id_tipdoc, tipdoc_nom
FROM            dbo.Tip_documento
GO
/****** Object:  View [dbo].[V_lstdocxexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lsttipuxusu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstuserxmovexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstperxtipdoc]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstperxtipdoc]
AS
SELECT        dbo.Persona.pers_id, dbo.Tip_documento.tipdoc_nom, dbo.Persona.pers_nombres, dbo.Persona.pers_ubigeo, dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.pers_numdoc
FROM            dbo.Persona INNER JOIN
                         dbo.Tip_documento ON dbo.Persona.id_tipdoc = dbo.Tip_documento.id_tipdoc
GO
/****** Object:  View [dbo].[V_lstjuzgxexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstexpxmovexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstexpxhistjuzg]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lsttipabxabo]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstDemxPers]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDemxPers]
AS
SELECT        dbo.Demandado.demdo_id, dbo.Persona.pers_nombres, dbo.Persona.pers_ciudad, dbo.Persona.pers_provincia, dbo.Persona.pers_departamento, dbo.Persona.pers_ubigeo, dbo.Persona.pers_domlegal, 
                         dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.id_tipdoc, dbo.Persona.pers_numdoc
FROM            dbo.Demandado INNER JOIN
                         dbo.Persona ON dbo.Demandado.pers_id = dbo.Persona.pers_id
GO
/****** Object:  View [dbo].[V_lstmovexpxexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstabogxestabog]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstanexmovexp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  View [dbo].[V_lstDemtexPers]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_lstDemtexPers]
AS
SELECT        dbo.Demandante.demte_id, dbo.Persona.pers_nombres, dbo.Persona.pers_ciudad, dbo.Persona.pers_provincia, dbo.Persona.pers_departamento, dbo.Persona.pers_ubigeo, dbo.Persona.pers_domlegal, 
                         dbo.Persona.pers_telefono, dbo.Persona.pers_email, dbo.Persona.pers_numdoc
FROM            dbo.Demandante INNER JOIN
                         dbo.Persona ON dbo.Demandante.pers_id = dbo.Persona.pers_id
GO
SET IDENTITY_INSERT [dbo].[Estado_Usu] ON 

INSERT [dbo].[Estado_Usu] ([id_estusu], [est_condi]) VALUES (1, N'activo')
INSERT [dbo].[Estado_Usu] ([id_estusu], [est_condi]) VALUES (2, N'Inhabilitado')
INSERT [dbo].[Estado_Usu] ([id_estusu], [est_condi]) VALUES (3, N'Egresado ')
SET IDENTITY_INSERT [dbo].[Estado_Usu] OFF
INSERT [dbo].[Persona] ([pers_id], [pers_nombres], [pers_ciudad], [pers_provincia], [pers_departamento], [pers_ubigeo], [pers_domlegal], [pers_telefono], [pers_email], [id_tipdoc], [pers_numdoc]) VALUES (1, N'ddfrwfref', N'rger', N'gregre', N'grgrg', N'rgeg', N'rgeg', N'rgegg', N'rgegeg', 1, CAST(71054288 AS Numeric(11, 0)))
SET IDENTITY_INSERT [dbo].[Tip_documento] ON 

INSERT [dbo].[Tip_documento] ([id_tipdoc], [tipdoc_nom]) VALUES (1, N'dni')
SET IDENTITY_INSERT [dbo].[Tip_documento] OFF
INSERT [dbo].[Tipo_Usuario] ([tipusu_id], [tipusu_tipousuario], [tipusu_descripcion]) VALUES (1, N'abogado', N'por contrato')
INSERT [dbo].[Usuario] ([usu_id], [tipusu_id], [usu_dni], [usu_nombres], [usu_apellidopat], [usu_apellidomat], [usu_telefono], [usu_direccion], [usu_sexo], [usu_correo], [usu_estadocivil], [usu_fechanac], [usu_ciudad], [usu_provincia], [id_estusu], [usu_departamento], [usu_contraseña]) VALUES (1, 1, N'70169852', N'nessir', N'aroni', N'alvarez', N'942283926', N'prolongacion jose olaya mz19 lt6', N'masculino', N'NessirxD@gmail.com', N'soltero', CAST(N'1996-03-26' AS Date), N'chimbote', N'santa', 1, N'ancash', N'681872                        ')
INSERT [dbo].[Usuario] ([usu_id], [tipusu_id], [usu_dni], [usu_nombres], [usu_apellidopat], [usu_apellidomat], [usu_telefono], [usu_direccion], [usu_sexo], [usu_correo], [usu_estadocivil], [usu_fechanac], [usu_ciudad], [usu_provincia], [id_estusu], [usu_departamento], [usu_contraseña]) VALUES (2, 1, N'48873349', N'Esteban', N'Vasquez', N'Carrillo', N'932278750', N'urb paseo del mar mz P4 lte 19', N'Masculino', N'xteban96.xv@gmail.com', N'Soltero', CAST(N'1996-10-22' AS Date), N'Chimbote', N'Santa', 1, N'Ancash', N'142191                        ')
INSERT [dbo].[Usuario] ([usu_id], [tipusu_id], [usu_dni], [usu_nombres], [usu_apellidopat], [usu_apellidomat], [usu_telefono], [usu_direccion], [usu_sexo], [usu_correo], [usu_estadocivil], [usu_fechanac], [usu_ciudad], [usu_provincia], [id_estusu], [usu_departamento], [usu_contraseña]) VALUES (3, 1, N'71054288', N'Eber Anibal', N'Cribillero', N'Benitez', N'937019118', N'16 de diciembre P.J', N'Masculino', N'eber.cb.96@gmail.com', N'Soltero', CAST(N'1996-09-15' AS Date), N'Chimbote', N'Santa', 1, N'Ancash', N'eloycito96')
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_ab_dni]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_ab_dni] ON [dbo].[Abogado]
(
	[ab_dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_exp_expediente]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_exp_expediente] ON [dbo].[Expediente]
(
	[exp_expediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_exp_nrosentencia]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_exp_nrosentencia] ON [dbo].[Expediente]
(
	[exp_nrosentencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_exp_resolucionnro]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_exp_resolucionnro] ON [dbo].[Expediente]
(
	[exp_resolucionnro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [I_num_doc]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_num_doc] ON [dbo].[Persona]
(
	[pers_numdoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_pers_email]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_pers_email] ON [dbo].[Persona]
(
	[pers_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_pers_telefono]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_pers_telefono] ON [dbo].[Persona]
(
	[pers_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_usu_correo]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_usu_correo] ON [dbo].[Usuario]
(
	[usu_correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_usu_dni]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_usu_dni] ON [dbo].[Usuario]
(
	[usu_dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_usu_telefono]    Script Date: 30/05/2019 18:51:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [I_usu_telefono] ON [dbo].[Usuario]
(
	[usu_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
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
/****** Object:  StoredProcedure [dbo].[actualizar_abogado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_demandado]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create procedure [dbo].[actualizar_demandado]
(
@demdo_id int,
 @pers_id int,
 @demdo_registro varchar(20)
 
) 
as
update Demandado set @pers_id = pers_id, @demdo_registro = demdo_registro

where @demdo_id = demdo_id


GO
/****** Object:  StoredProcedure [dbo].[actualizar_demandante]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[actualizar_demandante]
(
@demte_id int,
 @pers_id int,
 @demte_registro varchar(20)
 
) 
as
update Demandante set @pers_id = pers_id, @demte_registro = demte_registro

where @demte_id = demte_id


GO
/****** Object:  StoredProcedure [dbo].[actualizar_doc]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_Estabog]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_Estusu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_exp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_HisJuz]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_MovExp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_pers]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_pers]
(
 @pers_id int,
 @pers_nombres varchar(20),
 @pers_ciudad varchar(20),
 @pers_provincia varchar(20),
 @pers_departamento varchar(20),
 @pers_ubigeo varchar(20),
 @pers_domlegal varchar(20),
 @pers_telefono varchar(13),
 @pers_email varchar(30),
 @id_tipdoc int,
 @pers_numdoc numeric(11,0)
 
) 
as
update Persona set @pers_nombres = pers_nombres, @pers_ciudad = pers_ciudad, @pers_provincia = pers_provincia,
 @pers_departamento = pers_departamento, @pers_ubigeo = pers_ubigeo, @pers_domlegal = pers_domlegal, @pers_telefono = pers_telefono, @pers_email = pers_email, 
 @id_tipdoc = id_tipdoc,@pers_numdoc=pers_numdoc
where @pers_id = pers_id 

GO
/****** Object:  StoredProcedure [dbo].[actualizar_TipAbg]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_Tipodoc]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_TipUsu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizar_Usu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ActualizarAnexos]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Abogado]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_demandado]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_demandado]

( @demdo_id int,
 @pers_id int,
 @demdo_registro int
)
AS
begin
 insert into Demandado([demdo_id], [pers_id], [demdo_registro] ) values (@demdo_id, @pers_id, @demdo_registro)
end




GO
/****** Object:  StoredProcedure [dbo].[insertar_demandante]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[insertar_demandante]

( @demte_id int,
 @pers_id int,
 @demte_registro varchar(20)
)
AS
begin
 insert into Demandante(demte_id, [pers_id], demte_registro ) values (@demte_id, @pers_id, @demte_registro)
end


GO
/****** Object:  StoredProcedure [dbo].[insertar_doc]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Estabog]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Estusu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_exp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_HisJuz]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_MovExp]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Persona]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[insertar_Persona]

(@pers_id int,
 @pers_nombres varchar(20),
 @pers_ciudad varchar(20),
 @pers_provincia varchar(20),
 @pers_departamento varchar(20),
 @pers_ubigeo varchar(20),
 @pers_domlegal varchar(20),
 @pers_telefono varchar(13),
 @pers_email varchar(30),
 @id_tipdoc int,
 @pers_numdoc numeric(11,0)


 )
AS
begin
 insert into Persona(pers_id, pers_nombres, pers_ciudad, pers_provincia, 
 pers_departamento, pers_ubigeo, pers_domlegal, pers_telefono, pers_email, id_tipdoc, pers_numdoc)
  values (@pers_id, @pers_nombres, @pers_ciudad, @pers_provincia, @pers_departamento,@pers_ubigeo, @pers_domlegal, @pers_telefono, 
  @pers_email,@id_tipdoc,@pers_numdoc)
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_TipAbg]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Tipodoc]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_TipUsu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_Usu]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarAnexos]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[NuevaContrasena]    Script Date: 30/05/2019 18:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ValidarCorreo]    Script Date: 30/05/2019 18:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ValidarCorreo]

                      @correo varchar(60)

                      AS

                     SELECT * FROM Usuario WHERE @correo=usu_correo
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombres completos del abogado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Abogado', @level2type=N'COLUMN',@level2name=N'ab_nombres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido paterno del abogado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Abogado', @level2type=N'COLUMN',@level2name=N'ab_apellidopat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido materno del abogado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Abogado', @level2type=N'COLUMN',@level2name=N'ab_apellidomat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Documento nacional de identidad del abogado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Abogado', @level2type=N'COLUMN',@level2name=N'ab_dni'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información detallada del abogado sea interno (consultorio) o externo (contratado) que atenderá el caso ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Abogado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del anexo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Anexos', @level2type=N'COLUMN',@level2name=N'anexo_nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del anexo en formato predeterminado(Word,excel,pdf,jpg,png,etc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Anexos', @level2type=N'COLUMN',@level2name=N'anexo_nombrereal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Atributo que almacena el tipo de formato del anexo predeterminado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Anexos', @level2type=N'COLUMN',@level2name=N'anexo_documento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha del anexo registrado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Anexos', @level2type=N'COLUMN',@level2name=N'anexo_fecha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos del anexo generado por los usuarios del consultorio jurídico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Anexos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Filtro de registro basado en normas de etica para solo atender a una parte siendo demandante o demandado.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Demandado', @level2type=N'COLUMN',@level2name=N'demdo_registro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos de la Persona Demandada' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Demandado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Filtro de registro basado en normas de etica para solo atender a una parte siendo demandante o demandado.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Demandante', @level2type=N'COLUMN',@level2name=N'demte_registro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos de la Persona que demanda a otra persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Demandante'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del documento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'doc_nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del documento en formato predeterminado(Word,excel,pdf,jpg,png,etc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'doc_nombrereal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Atributo que almacena el tipo de formato del documento predeterminado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'doc_documento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha del documento registrado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'doc_fecha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos del documento del consultorio jurídico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado o condiciòn en el que se encuentra el abogado , sea en actividad , suspendido ,etc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado_Abogado', @level2type=N'COLUMN',@level2name=N'estabog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado en el que se encuentra el Abogado que trabaja en el Consultorio Jurídico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado_Abogado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado o condición en el que el usuario se encuentra participando en el sistema (‘activo’ ‘inactivo’ , ‘suspendido’ , etc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado_Usu', @level2type=N'COLUMN',@level2name=N'est_condi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado en el que se encuentra el Usuario que trabaja en el Consultorio Jurídico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado_Usu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de sentencia único dado por el Poder Judicial' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_nrosentencia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número único que se le da a un expediente , està conformado por números y letras' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_expediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos de la secretaria a cargo de redactar y entregar el expediente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_secrejuzg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en que se inicia la demanda o denuncia judicial inicio de proceso' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_fechainicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificación de rama de derecho sea laboral , penal , familia , civil .' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_materia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Establece un número que varía por avance del proceso de una acción jurídica.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_resolucionnro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ciudad donde se lleva el proceso jurídico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_ciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en tiempo real en el que se entrega el expediente .' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_fecha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción de vistos que se observaron en el expediente ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente', @level2type=N'COLUMN',@level2name=N'exp_vistos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información oficial generada de un expediente existente en el poder judicial .' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Juzgado de la corte superior de Justicia (juzgado penal , civil , laboral , familia )' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha recibida de un documento que va a generar un expediente (el expediente consta de varios documentos)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_fecharecepcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Documento (resolución) que emite el juez  con la admisión a trámite o rechazo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_pronunciamiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de la ejecución de lo ordenado o lo resuelto por el juzgado de primera instancia.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_fechaderivacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha emitida luego de una audiencia (puede pasar a una segunda etapa y se dirige a otro juzgado de rango superior)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_fechaemisionresol'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de notificación que se hace conocer a las partes de la decisión del juez .' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_fechanotificacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en la que se ordenada el cumplimiento de una resolución judicial ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado', @level2type=N'COLUMN',@level2name=N'juzg_fechasolucion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Historial de documentos derivados al juzgado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Historial_Juzgado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Situación por la cual hubo un movimiento de expediente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_asunto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en el que se ha reportado la ejecuciòn del caso plasmado en el expediente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_fechaing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado en el que se encuentra el expediente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripciòn del avance en el que se encuentra el caso descrito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_progreso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cantidad de folios de documentos presentados en el caso descrito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_cantfolios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción del caso a desarrollarse ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente', @level2type=N'COLUMN',@level2name=N'movexp_descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información generada en el consultorio por los usuarios administrativos o practicantes que atienden un caso en especifico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimiento_Expediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_nombres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ciudad de nacimiento de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_ciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Provincia de Nacimiento de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_provincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Departamento de nacimiento de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_departamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ubicación geográfica presente de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_ubigeo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción de la ubicación del domicilio legal de la persona ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_domlegal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número telefónico de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_telefono'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Correo electrónico de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de documento nacional de identidad o extranjería ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'pers_numdoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos de la persona especialmente natural o jurídica' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de documento sea nacional o de extranjería de la persona natural o juridica' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tip_documento', @level2type=N'COLUMN',@level2name=N'tipdoc_nom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Documento siendo de extranjería o nacional ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tip_documento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Parte acusadora o defensora' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Abogado', @level2type=N'COLUMN',@level2name=N'tipb_def_inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripciòn del estado del abogado, sea activo o no activo laborando en el consultorio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Abogado', @level2type=N'COLUMN',@level2name=N'tipb_estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripciòn de la parte interna o externa del consultorio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Abogado', @level2type=N'COLUMN',@level2name=N'tipb_descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de abogado defensor o abogado del inculpado sea del consultorio o contratado externamente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Abogado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Se indica el tipo de usuario por ejemplo (‘practicante’,’contratado’,’administrador’)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Usuario', @level2type=N'COLUMN',@level2name=N'tipusu_tipousuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Se indica el tiempo de contrato o tiempo de prácticas que va a desarrollar el usuario en el consultorio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Usuario', @level2type=N'COLUMN',@level2name=N'tipusu_descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos del Tipo de Usuario que asesorará a los clientes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo_Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Documento nacional de identidad del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_dni'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombres del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_nombres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido paterno del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_apellidopat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido materno del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_apellidomat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nùmero telefónico del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_telefono'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Direcciòn del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_direccion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Género de Sexo del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_sexo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Correo electrónico del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_correo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado civil del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_estadocivil'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de nacimiento del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_fechanac'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ciudad de nacimiento del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_ciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Provincia de nacimiento del Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_provincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Departamento de nacimiento del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'usu_departamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Datos del usuario  que asesora a los clientes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 152
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V _lsttipousuarioxtipous'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V _lsttipousuarioxtipous'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Estado_Abogado"
            Begin Extent = 
               Top = 10
               Left = 322
               Bottom = 170
               Right = 524
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstabogxestabog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstabogxestabog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Anexos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 219
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 14
               Left = 409
               Bottom = 219
               Right = 606
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstanexmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstanexmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Anexos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstanxnombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstanxnombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Demandante"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 175
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 212
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDemtexPers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDemtexPers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Demandado"
            Begin Extent = 
               Top = 14
               Left = 0
               Bottom = 157
               Right = 185
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 191
               Right = 439
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDemxPers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDemxPers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Demandante"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstdemxreg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstdemxreg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Documento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 10
               Left = 407
               Bottom = 219
               Right = 592
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstdocxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstdocxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Documento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDocxnom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDocxnom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Documento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDocxnomreal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstDocxnomreal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Estado_Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstestabg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstestabg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Estado_Usu"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 124
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstestusuxcond'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstestusuxcond'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Historial_Juzgado"
            Begin Extent = 
               Top = 15
               Left = 411
               Bottom = 205
               Right = 623
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstexpxhistjuzg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstexpxhistjuzg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstExpxmateria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstExpxmateria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[6] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 301
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 20
               Left = 398
               Bottom = 214
               Right = 595
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstexpxmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstexpxmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstExpxnumero'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstExpxnumero'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Historial_Juzgado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxdescr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxdescr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Historial_Juzgado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxFechRec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxFechRec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Historial_Juzgado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 152
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxFechSol'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstHistdeJuzgxFechSol'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Historial_Juzgado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 215
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 6
               Left = 458
               Bottom = 211
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstjuzgxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstjuzgxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 219
               Right = 291
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Expediente"
            Begin Extent = 
               Top = 26
               Left = 424
               Bottom = 219
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstmovexpxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstmovexpxexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxdepartamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxdepartamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxprovincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstpersonaxprovincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 217
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tip_documento"
            Begin Extent = 
               Top = 22
               Left = 505
               Bottom = 174
               Right = 675
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstperxtipdoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstperxtipdoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 189
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Abogado"
            Begin Extent = 
               Top = 14
               Left = 397
               Bottom = 182
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipabxabo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipabxabo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipAbxdef-inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipAbxdef-inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipAbxestado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipAbxestado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Demandado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipdemxreg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipdemxreg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tip_documento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipdocxnom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipdocxnom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipousuarioxdescripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipousuarioxdescripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tipo_Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 8
               Left = 437
               Bottom = 138
               Right = 625
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipuxusu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lsttipuxusu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 11
               Left = 397
               Bottom = 141
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstuserxmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstuserxmovexp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 216
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 8
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 12
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxdepartamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxdepartamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxprovincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstusuarioxprovincia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxapellidospat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxapellidospat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxdni'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxdni'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxestado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxestado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 198
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxfechaing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxfechaing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Abogado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxnombres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxnombres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movimiento_Expediente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxprogreso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_lstxprogreso'
GO
