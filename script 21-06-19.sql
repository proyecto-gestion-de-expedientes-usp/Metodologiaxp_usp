USE [alquiler]
GO
/****** Object:  Table [dbo].[Comprobante]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobante](
	[idComprobante] [int] IDENTITY(1,1) NOT NULL,
	[Mes] [int] NOT NULL,
	[Periodo] [int] NOT NULL,
	[idTipocbte] [char](2) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[numero] [int] NOT NULL,
	[idContrato] [int] NOT NULL,
	[total] [decimal](10, 2) NULL,
	[fecEmision] [date] NULL,
	[fecVencimiento] [date] NULL,
	[pagado] [decimal](10, 2) NOT NULL,
	[Saldo] [decimal](10, 2) NULL,
 CONSTRAINT [PK_comprobante] PRIMARY KEY CLUSTERED 
(
	[idComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComprobanteConcepto]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobanteConcepto](
	[idConcepto] [int] NOT NULL,
	[idComprobante] [int] NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_comprobanteconcepto] PRIMARY KEY CLUSTERED 
(
	[idConcepto] ASC,
	[idComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Concepto]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concepto](
	[idConcepto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NULL,
	[fijo] [char](1) NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_concepto] PRIMARY KEY CLUSTERED 
(
	[idConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContratoAlquiler]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContratoAlquiler](
	[idContrato] [int] IDENTITY(1,1) NOT NULL,
	[idOficina] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[fecInicio] [date] NOT NULL,
	[fecFin] [date] NOT NULL,
	[estado] [char](1) NOT NULL,
	[fecreg] [datetime] NOT NULL,
	[idMoneda] [int] NOT NULL,
 CONSTRAINT [PK_contratoalquiler] PRIMARY KEY CLUSTERED 
(
	[idContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[idDireccion] [int] IDENTITY(1,1) NOT NULL,
	[idPersona] [int] NOT NULL,
	[valor] [varchar](100) NULL,
	[idUbigeo] [char](6) NOT NULL,
 CONSTRAINT [PK_direccion] PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificio](
	[idEdificio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[nroPisos] [int] NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
	[idUbigeo] [char](6) NOT NULL,
 CONSTRAINT [PK_edificio] PRIMARY KEY CLUSTERED 
(
	[idEdificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[Periodo] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[FechaApertura] [datetime] NULL,
	[FechaCierre] [datetime] NULL,
	[importeSoles] [decimal](12, 2) NULL,
	[importeDolares] [decimal](12, 2) NULL,
	[estado] [char](1) NULL,
 CONSTRAINT [PK_facturacion] PRIMARY KEY CLUSTERED 
(
	[Periodo] ASC,
	[Mes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacturacionDetalle]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturacionDetalle](
	[Periodo] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[idContrato] [int] NOT NULL,
	[idConcepto] [int] NOT NULL,
	[fecreg] [datetime] NULL,
	[importe] [decimal](10, 2) NULL,
 CONSTRAINT [PK_facturaciondetalle] PRIMARY KEY CLUSTERED 
(
	[Periodo] ASC,
	[Mes] ASC,
	[idContrato] ASC,
	[idConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Incidencia]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incidencia](
	[idIncidencia] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[descripcion] [varchar](100) NULL,
	[importeTotal] [decimal](10, 2) NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_incidencia] PRIMARY KEY CLUSTERED 
(
	[idIncidencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IncidenciaOficina]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncidenciaOficina](
	[idIncidencia] [int] NOT NULL,
	[idContrato] [int] NOT NULL,
	[importe] [char](18) NULL,
 CONSTRAINT [PK_incidenciaoficina] PRIMARY KEY CLUSTERED 
(
	[idIncidencia] ASC,
	[idContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedioComunicacion]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedioComunicacion](
	[idTmco] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[valor] [varchar](50) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_mediocomunicacion] PRIMARY KEY CLUSTERED 
(
	[idTmco] ASC,
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moneda](
	[idMoneda] [int] NOT NULL,
	[nombre] [varchar](25) NULL,
	[codSunat] [varchar](2) NULL,
	[codInternacional] [varchar](4) NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_moneda] PRIMARY KEY CLUSTERED 
(
	[idMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oficina]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oficina](
	[idOficina] [int] IDENTITY(1,1) NOT NULL,
	[piso] [int] NULL,
	[nro] [int] NULL,
	[idEdificio] [int] NOT NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_oficina] PRIMARY KEY CLUSTERED 
(
	[idOficina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OficinaServicio]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OficinaServicio](
	[idOficina] [int] NOT NULL,
	[idServicio] [int] NOT NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_oficinaservicio] PRIMARY KEY CLUSTERED 
(
	[idOficina] ASC,
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pago]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[idPago] [int] NOT NULL,
	[idTipoMopa] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
	[idPersona] [int] NOT NULL,
	[idMoneda] [int] NOT NULL,
	[idTipoCam] [int] NOT NULL,
 CONSTRAINT [PK_pago] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PagoComprobante]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoComprobante](
	[idPago] [int] NOT NULL,
	[idComprobante] [int] NOT NULL,
	[importe] [decimal](10, 2) NULL,
 CONSTRAINT [PK_pagocomprobante] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC,
	[idComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[tipoPersona] [char](1) NULL,
	[nombres] [varchar](100) NULL,
	[nrodocu] [varchar](11) NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
	[idtipodoide] [int] NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[estado] [char](1) NULL,
	[fecreg] [datetime] NULL,
 CONSTRAINT [PK_servicio] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tarifa]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifa](
	[idTarifa] [int] NOT NULL,
	[idConcepto] [int] NOT NULL,
	[periodo] [int] NULL,
	[importe] [decimal](10, 2) NULL,
	[estado] [char](1) NULL,
 CONSTRAINT [PK_tarifa] PRIMARY KEY CLUSTERED 
(
	[idTarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoCambio]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCambio](
	[idTipoCam] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[importe] [decimal](4, 2) NULL,
 CONSTRAINT [PK_tipocambio] PRIMARY KEY CLUSTERED 
(
	[idTipoCam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoComprobante]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoComprobante](
	[idTipocbte] [char](2) NOT NULL,
	[nombre] [varchar](30) NULL,
	[abreviatura] [varchar](10) NULL,
 CONSTRAINT [PK_tipocomprobante] PRIMARY KEY CLUSTERED 
(
	[idTipocbte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipoDocumentoIdentidad]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDocumentoIdentidad](
	[idtipodoide] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[abreviatura] [varchar](6) NULL,
 CONSTRAINT [PK_tipodocumentoidentidad] PRIMARY KEY CLUSTERED 
(
	[idtipodoide] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoMedioComunicacion]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMedioComunicacion](
	[idTipomeco] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [PK_tipomediocomunicacion] PRIMARY KEY CLUSTERED 
(
	[idTipomeco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoModoPago]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoModoPago](
	[idTipoMopa] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [PK_tipomodopago] PRIMARY KEY CLUSTERED 
(
	[idTipoMopa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ubigeo]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubigeo](
	[idUbigeo] [char](6) NOT NULL,
	[departamento] [varchar](50) NULL,
	[provincia] [varchar](50) NULL,
	[distrito] [varchar](50) NULL,
 CONSTRAINT [PK_ubigeo] PRIMARY KEY CLUSTERED 
(
	[idUbigeo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ContratoAlquiler] ADD  DEFAULT ('getdate()') FOR [fecreg]
GO
ALTER TABLE [dbo].[Comprobante]  WITH CHECK ADD  CONSTRAINT [FK_Comprobante_ContratoAlquiler] FOREIGN KEY([idContrato])
REFERENCES [dbo].[ContratoAlquiler] ([idContrato])
GO
ALTER TABLE [dbo].[Comprobante] CHECK CONSTRAINT [FK_Comprobante_ContratoAlquiler]
GO
ALTER TABLE [dbo].[Comprobante]  WITH CHECK ADD  CONSTRAINT [FK_Comprobante_Facturacion] FOREIGN KEY([Periodo], [Mes])
REFERENCES [dbo].[Facturacion] ([Periodo], [Mes])
GO
ALTER TABLE [dbo].[Comprobante] CHECK CONSTRAINT [FK_Comprobante_Facturacion]
GO
ALTER TABLE [dbo].[Comprobante]  WITH CHECK ADD  CONSTRAINT [FK_Comprobante_TipoComprobante] FOREIGN KEY([idTipocbte])
REFERENCES [dbo].[TipoComprobante] ([idTipocbte])
GO
ALTER TABLE [dbo].[Comprobante] CHECK CONSTRAINT [FK_Comprobante_TipoComprobante]
GO
ALTER TABLE [dbo].[ComprobanteConcepto]  WITH CHECK ADD  CONSTRAINT [FK_ComprobanteConcepto_Comprobante] FOREIGN KEY([idComprobante])
REFERENCES [dbo].[Comprobante] ([idComprobante])
GO
ALTER TABLE [dbo].[ComprobanteConcepto] CHECK CONSTRAINT [FK_ComprobanteConcepto_Comprobante]
GO
ALTER TABLE [dbo].[ComprobanteConcepto]  WITH CHECK ADD  CONSTRAINT [FK_ComprobanteConcepto_Concepto] FOREIGN KEY([idConcepto])
REFERENCES [dbo].[Concepto] ([idConcepto])
GO
ALTER TABLE [dbo].[ComprobanteConcepto] CHECK CONSTRAINT [FK_ComprobanteConcepto_Concepto]
GO
ALTER TABLE [dbo].[ContratoAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_ContratoAlquiler_Moneda] FOREIGN KEY([idMoneda])
REFERENCES [dbo].[Moneda] ([idMoneda])
GO
ALTER TABLE [dbo].[ContratoAlquiler] CHECK CONSTRAINT [FK_ContratoAlquiler_Moneda]
GO
ALTER TABLE [dbo].[ContratoAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_ContratoAlquiler_Oficina] FOREIGN KEY([idOficina])
REFERENCES [dbo].[Oficina] ([idOficina])
GO
ALTER TABLE [dbo].[ContratoAlquiler] CHECK CONSTRAINT [FK_ContratoAlquiler_Oficina]
GO
ALTER TABLE [dbo].[ContratoAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_ContratoAlquiler_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[ContratoAlquiler] CHECK CONSTRAINT [FK_ContratoAlquiler_Persona]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Persona]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Ubigeo] FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[Ubigeo] ([idUbigeo])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Ubigeo]
GO
ALTER TABLE [dbo].[Edificio]  WITH CHECK ADD  CONSTRAINT [FK_Edificio_Ubigeo] FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[Ubigeo] ([idUbigeo])
GO
ALTER TABLE [dbo].[Edificio] CHECK CONSTRAINT [FK_Edificio_Ubigeo]
GO
ALTER TABLE [dbo].[FacturacionDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionDetalle_Concepto] FOREIGN KEY([idConcepto])
REFERENCES [dbo].[Concepto] ([idConcepto])
GO
ALTER TABLE [dbo].[FacturacionDetalle] CHECK CONSTRAINT [FK_FacturacionDetalle_Concepto]
GO
ALTER TABLE [dbo].[FacturacionDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionDetalle_ContratoAlquiler] FOREIGN KEY([idContrato])
REFERENCES [dbo].[ContratoAlquiler] ([idContrato])
GO
ALTER TABLE [dbo].[FacturacionDetalle] CHECK CONSTRAINT [FK_FacturacionDetalle_ContratoAlquiler]
GO
ALTER TABLE [dbo].[FacturacionDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionDetalle_Facturacion] FOREIGN KEY([Periodo], [Mes])
REFERENCES [dbo].[Facturacion] ([Periodo], [Mes])
GO
ALTER TABLE [dbo].[FacturacionDetalle] CHECK CONSTRAINT [FK_FacturacionDetalle_Facturacion]
GO
ALTER TABLE [dbo].[IncidenciaOficina]  WITH CHECK ADD  CONSTRAINT [FK_IncidenciaOficina_ContratoAlquiler] FOREIGN KEY([idContrato])
REFERENCES [dbo].[ContratoAlquiler] ([idContrato])
GO
ALTER TABLE [dbo].[IncidenciaOficina] CHECK CONSTRAINT [FK_IncidenciaOficina_ContratoAlquiler]
GO
ALTER TABLE [dbo].[IncidenciaOficina]  WITH CHECK ADD  CONSTRAINT [FK_IncidenciaOficina_Incidencia] FOREIGN KEY([idIncidencia])
REFERENCES [dbo].[Incidencia] ([idIncidencia])
GO
ALTER TABLE [dbo].[IncidenciaOficina] CHECK CONSTRAINT [FK_IncidenciaOficina_Incidencia]
GO
ALTER TABLE [dbo].[MedioComunicacion]  WITH CHECK ADD  CONSTRAINT [FK_MedioComunicacion_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[MedioComunicacion] CHECK CONSTRAINT [FK_MedioComunicacion_Persona]
GO
ALTER TABLE [dbo].[MedioComunicacion]  WITH CHECK ADD  CONSTRAINT [FK_MedioComunicacion_TipoMedioComunicacion] FOREIGN KEY([idTmco])
REFERENCES [dbo].[TipoMedioComunicacion] ([idTipomeco])
GO
ALTER TABLE [dbo].[MedioComunicacion] CHECK CONSTRAINT [FK_MedioComunicacion_TipoMedioComunicacion]
GO
ALTER TABLE [dbo].[Oficina]  WITH CHECK ADD  CONSTRAINT [FK_Oficina_Edificio] FOREIGN KEY([idEdificio])
REFERENCES [dbo].[Edificio] ([idEdificio])
GO
ALTER TABLE [dbo].[Oficina] CHECK CONSTRAINT [FK_Oficina_Edificio]
GO
ALTER TABLE [dbo].[OficinaServicio]  WITH CHECK ADD  CONSTRAINT [FK_OficinaServicio_Oficina] FOREIGN KEY([idOficina])
REFERENCES [dbo].[Oficina] ([idOficina])
GO
ALTER TABLE [dbo].[OficinaServicio] CHECK CONSTRAINT [FK_OficinaServicio_Oficina]
GO
ALTER TABLE [dbo].[OficinaServicio]  WITH CHECK ADD  CONSTRAINT [FK_OficinaServicio_Servicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO
ALTER TABLE [dbo].[OficinaServicio] CHECK CONSTRAINT [FK_OficinaServicio_Servicio]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Moneda] FOREIGN KEY([idMoneda])
REFERENCES [dbo].[Moneda] ([idMoneda])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_Moneda]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_Persona]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_TipoCambio] FOREIGN KEY([idTipoCam])
REFERENCES [dbo].[TipoCambio] ([idTipoCam])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_TipoCambio]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_TipoModoPago] FOREIGN KEY([idTipoMopa])
REFERENCES [dbo].[TipoModoPago] ([idTipoMopa])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_TipoModoPago]
GO
ALTER TABLE [dbo].[PagoComprobante]  WITH CHECK ADD  CONSTRAINT [FK_PagoComprobante_Comprobante] FOREIGN KEY([idComprobante])
REFERENCES [dbo].[Comprobante] ([idComprobante])
GO
ALTER TABLE [dbo].[PagoComprobante] CHECK CONSTRAINT [FK_PagoComprobante_Comprobante]
GO
ALTER TABLE [dbo].[PagoComprobante]  WITH CHECK ADD  CONSTRAINT [FK_PagoComprobante_Pago] FOREIGN KEY([idPago])
REFERENCES [dbo].[Pago] ([idPago])
GO
ALTER TABLE [dbo].[PagoComprobante] CHECK CONSTRAINT [FK_PagoComprobante_Pago]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_tipoDocumentoIdentidad] FOREIGN KEY([idtipodoide])
REFERENCES [dbo].[tipoDocumentoIdentidad] ([idtipodoide])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_tipoDocumentoIdentidad]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_Concepto] FOREIGN KEY([idConcepto])
REFERENCES [dbo].[Concepto] ([idConcepto])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_Concepto]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_tipmedcom]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[actualizar_tipmedcom]

@idTipomeco int,
@nombre varchar(30)

as
begin
update TipoMedioComunicacion
set nombre=@nombre
where TipoMedioComunicacion.idTipomeco=@idTipomeco
end

GO
/****** Object:  StoredProcedure [dbo].[insertar_Moneda]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[insertar_Moneda]

( 
@idMoneda  int,
@nombre   varchar(25),
@codSunat   varchar(2),
@codInternacional varchar(4),
@estado  char(1),
@fecreg   datetime
 )
AS
begin
insert into Moneda ([idMoneda], [nombre] , [codSunat] , [codInternacional] ,[estado] , [fecreg] ) 

 values (@idMoneda, @nombre , @codSunat, @codInternacional , @estado  , @fecreg  )
 END



GO
/****** Object:  StoredProcedure [dbo].[insertar_Tip_med_com]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertar_Tip_med_com]

( 
 @nombre varchar(30)
 )
AS
begin
 insert into TipoMedioComunicacion( [nombre])
  values ( @nombre)
End



GO
/****** Object:  StoredProcedure [dbo].[sp_cons_registros_Moneda]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_cons_registros_Moneda]
as
SELECT CAST( fecreg AS DATE ) as Dia, COUNT( idMoneda ) as Total_Registros
FROM Moneda
GROUP BY CAST( fecreg AS DATE )



GO
/****** Object:  StoredProcedure [dbo].[sp_cons_TipmedCom]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cons_TipmedCom]
as
select * from TipoMedioComunicacion



GO
/****** Object:  StoredProcedure [dbo].[spbuscar_reporte_fechas_moneda]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spbuscar_reporte_fechas_moneda]
	@FechaInicio datetime,
	@FechaFin datetime
AS
BEGIN
	SELECT
		m.idMoneda, 
		m.nombre ,
		m.codSunat, 
		m.codInternacional, 
		m.estado, 
		m.fecreg 
		
	FROM  
		Moneda m
	WHERE
		m.fecreg BETWEEN @FechaInicio AND @FechaFin
END



GO
/****** Object:  StoredProcedure [dbo].[Update_Moneda]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Update_Moneda]

( 
@idMoneda  int,
@nombre   varchar(25),
@codSunat   varchar(2),
@codInternacional  varchar(4),
@estado  char(1),
@fecreg   datetime
 )
AS
Update Moneda set  @nombre=nombre, @codSunat=codSunat , @codInternacional=codInternacional,
@estado=estado,@fecreg=fecreg
where @idMoneda= idMoneda



GO
/****** Object:  StoredProcedure [dbo].[ver_TipoMedioComunicacion]    Script Date: 21/06/2019 19:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ver_TipoMedioComunicacion]
as
select * From TipoMedioComunicacion



GO
