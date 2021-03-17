USE [master]
GO
/****** Object:  Database [Escalas-Metodista]    Script Date: 16/03/2021 22:06:42 ******/
CREATE DATABASE [Escalas-Metodista]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Escalas-Metodista', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Escalas-Metodista.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Escalas-Metodista_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Escalas-Metodista_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Escalas-Metodista] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Escalas-Metodista].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Escalas-Metodista] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET ARITHABORT OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Escalas-Metodista] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Escalas-Metodista] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Escalas-Metodista] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Escalas-Metodista] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Escalas-Metodista] SET  MULTI_USER 
GO
ALTER DATABASE [Escalas-Metodista] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Escalas-Metodista] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Escalas-Metodista] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Escalas-Metodista] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Escalas-Metodista] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Escalas-Metodista] SET QUERY_STORE = OFF
GO
USE [Escalas-Metodista]
GO
/****** Object:  Table [dbo].[Data]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Data](
	[idData] [int] IDENTITY(1,1) NOT NULL,
	[descricaoData] [date] NOT NULL,
 CONSTRAINT [PK_Data] PRIMARY KEY CLUSTERED 
(
	[idData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Data_Escala]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Data_Escala](
	[idData_fk] [int] NOT NULL,
	[idEscala_fk] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escala]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escala](
	[idEscala] [int] IDENTITY(1,1) NOT NULL,
	[nomeEscala] [varchar](50) NOT NULL,
	[dataInicio] [date] NOT NULL,
	[dataFim] [date] NOT NULL,
	[tipoEscala_fk] [int] NOT NULL,
	[intervalo_fk] [int] NOT NULL,
	[usuarioCriador] [int] NOT NULL,
 CONSTRAINT [PK_Escala] PRIMARY KEY CLUSTERED 
(
	[idEscala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcao]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcao](
	[idFuncao] [int] IDENTITY(1,1) NOT NULL,
	[descricaoFuncao] [varchar](40) NOT NULL,
 CONSTRAINT [PK_Funcao] PRIMARY KEY CLUSTERED 
(
	[idFuncao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Intervalo]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intervalo](
	[idIntervalo] [int] IDENTITY(1,1) NOT NULL,
	[descricaoIntervalo] [nchar](10) NULL,
 CONSTRAINT [PK_Intervalo] PRIMARY KEY CLUSTERED 
(
	[idIntervalo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Observacao]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Observacao](
	[idObservacao] [int] IDENTITY(1,1) NOT NULL,
	[textoObservacao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Observacao] PRIMARY KEY CLUSTERED 
(
	[idObservacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Observacao_Escala]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Observacao_Escala](
	[idObservacao_fk] [int] NOT NULL,
	[idEscala_fk] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[idPessoa] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobrenome] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[senha] [varchar](30) NOT NULL,
	[tipoUsuario_fk] [int] NOT NULL,
	[funcaoPrincipal_fk] [int] NOT NULL,
	[funcaoSecundaria_fk] [int] NULL,
	[dataCadastro] [date] NOT NULL,
	[status] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[idPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa_Escala]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa_Escala](
	[idPessoa_fk] [int] NOT NULL,
	[idEscala_fk] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubFuncao]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubFuncao](
	[idSubFuncao] [int] IDENTITY(1,1) NOT NULL,
	[idFuncao_fk] [int] NOT NULL,
	[descricao] [varchar](40) NOT NULL,
 CONSTRAINT [PK_SubFuncao] PRIMARY KEY CLUSTERED 
(
	[idSubFuncao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEscala]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEscala](
	[idTipoEscala] [int] IDENTITY(1,1) NOT NULL,
	[descricaoTipoEscala] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TipoEscala] PRIMARY KEY CLUSTERED 
(
	[idTipoEscala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 16/03/2021 22:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[idTipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TipoUsuario] PRIMARY KEY CLUSTERED 
(
	[idTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Funcao] ON 

INSERT [dbo].[Funcao] ([idFuncao], [descricaoFuncao]) VALUES (1, N'LOUVOR')
INSERT [dbo].[Funcao] ([idFuncao], [descricaoFuncao]) VALUES (2, N'COMUNICAÇÃO')
INSERT [dbo].[Funcao] ([idFuncao], [descricaoFuncao]) VALUES (3, N'LIMPEZA/LANCHE')
INSERT [dbo].[Funcao] ([idFuncao], [descricaoFuncao]) VALUES (4, N'SALINHA')
SET IDENTITY_INSERT [dbo].[Funcao] OFF
SET IDENTITY_INSERT [dbo].[Intervalo] ON 

INSERT [dbo].[Intervalo] ([idIntervalo], [descricaoIntervalo]) VALUES (1, N'Diária    ')
INSERT [dbo].[Intervalo] ([idIntervalo], [descricaoIntervalo]) VALUES (2, N'Semanal   ')
INSERT [dbo].[Intervalo] ([idIntervalo], [descricaoIntervalo]) VALUES (3, N'Mensal    ')
INSERT [dbo].[Intervalo] ([idIntervalo], [descricaoIntervalo]) VALUES (4, N'Trimestral')
SET IDENTITY_INSERT [dbo].[Intervalo] OFF
SET IDENTITY_INSERT [dbo].[Pessoa] ON 

INSERT [dbo].[Pessoa] ([idPessoa], [nome], [sobrenome], [email], [senha], [tipoUsuario_fk], [funcaoPrincipal_fk], [funcaoSecundaria_fk], [dataCadastro], [status]) VALUES (1, N'Matheus ', N'Pimentel', N'mat@mat.com', N'mat123', 1, 1, 2, CAST(N'2021-02-24' AS Date), N'Ativo')
INSERT [dbo].[Pessoa] ([idPessoa], [nome], [sobrenome], [email], [senha], [tipoUsuario_fk], [funcaoPrincipal_fk], [funcaoSecundaria_fk], [dataCadastro], [status]) VALUES (2, N'Itamar ', N'Júnior', N'itamar@itamar.com', N'itamar123', 2, 2, NULL, CAST(N'2021-03-07' AS Date), N'Ativo')
SET IDENTITY_INSERT [dbo].[Pessoa] OFF
SET IDENTITY_INSERT [dbo].[SubFuncao] ON 

INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (1, 1, N'GUITARRA')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (2, 1, N' VIOLÃO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (3, 2, N'STORIES')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (4, 2, N' VÍDEO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (5, 1, N'BATERIA')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (6, 1, N'TECLADO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (7, 1, N'VOZ (BACK)')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (8, 1, N'VOZ (MINISTRANTE)')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (9, 1, N'BAIXO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (10, 1, N'PERCURSSÃO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (11, 1, N'MÍDIA/SOM')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (12, 2, N'IMAGEM')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (13, 2, N'EDIÇÃO')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (14, 2, N'LEGENDA/PUBLIC')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (15, 2, N'ENTREVISTA')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (16, 4, N'CRIANÇAS - 0 A 4 ANOS')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (17, 4, N'CRIANÇAS - 4 A 7 ANOS')
INSERT [dbo].[SubFuncao] ([idSubFuncao], [idFuncao_fk], [descricao]) VALUES (18, 4, N'CRIANÇAS - 8 A 11 ANOS')
SET IDENTITY_INSERT [dbo].[SubFuncao] OFF
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([idTipoUsuario], [descricao]) VALUES (1, N'Administrador')
INSERT [dbo].[TipoUsuario] ([idTipoUsuario], [descricao]) VALUES (2, N'Padrão')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
ALTER TABLE [dbo].[Data_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Data_Escala_Data] FOREIGN KEY([idData_fk])
REFERENCES [dbo].[Data] ([idData])
GO
ALTER TABLE [dbo].[Data_Escala] CHECK CONSTRAINT [FK_Data_Escala_Data]
GO
ALTER TABLE [dbo].[Data_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Data_Escala_Escala] FOREIGN KEY([idEscala_fk])
REFERENCES [dbo].[Escala] ([idEscala])
GO
ALTER TABLE [dbo].[Data_Escala] CHECK CONSTRAINT [FK_Data_Escala_Escala]
GO
ALTER TABLE [dbo].[Escala]  WITH CHECK ADD  CONSTRAINT [FK_Escala_Intervalo] FOREIGN KEY([intervalo_fk])
REFERENCES [dbo].[Intervalo] ([idIntervalo])
GO
ALTER TABLE [dbo].[Escala] CHECK CONSTRAINT [FK_Escala_Intervalo]
GO
ALTER TABLE [dbo].[Escala]  WITH CHECK ADD  CONSTRAINT [FK_Escala_TipoEscala] FOREIGN KEY([tipoEscala_fk])
REFERENCES [dbo].[TipoEscala] ([idTipoEscala])
GO
ALTER TABLE [dbo].[Escala] CHECK CONSTRAINT [FK_Escala_TipoEscala]
GO
ALTER TABLE [dbo].[Observacao_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Observacao_Escala_Escala] FOREIGN KEY([idEscala_fk])
REFERENCES [dbo].[Escala] ([idEscala])
GO
ALTER TABLE [dbo].[Observacao_Escala] CHECK CONSTRAINT [FK_Observacao_Escala_Escala]
GO
ALTER TABLE [dbo].[Observacao_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Observacao_Escala_Observacao] FOREIGN KEY([idObservacao_fk])
REFERENCES [dbo].[Observacao] ([idObservacao])
GO
ALTER TABLE [dbo].[Observacao_Escala] CHECK CONSTRAINT [FK_Observacao_Escala_Observacao]
GO
ALTER TABLE [dbo].[Pessoa]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_SubFuncao] FOREIGN KEY([funcaoPrincipal_fk])
REFERENCES [dbo].[SubFuncao] ([idSubFuncao])
GO
ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [FK_Pessoa_SubFuncao]
GO
ALTER TABLE [dbo].[Pessoa]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_SubFuncao1] FOREIGN KEY([funcaoSecundaria_fk])
REFERENCES [dbo].[SubFuncao] ([idSubFuncao])
GO
ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [FK_Pessoa_SubFuncao1]
GO
ALTER TABLE [dbo].[Pessoa]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_TipoUsuario] FOREIGN KEY([tipoUsuario_fk])
REFERENCES [dbo].[TipoUsuario] ([idTipoUsuario])
GO
ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [FK_Pessoa_TipoUsuario]
GO
ALTER TABLE [dbo].[Pessoa_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_Escala_Escala] FOREIGN KEY([idEscala_fk])
REFERENCES [dbo].[Escala] ([idEscala])
GO
ALTER TABLE [dbo].[Pessoa_Escala] CHECK CONSTRAINT [FK_Pessoa_Escala_Escala]
GO
ALTER TABLE [dbo].[Pessoa_Escala]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_Escala_Pessoa] FOREIGN KEY([idPessoa_fk])
REFERENCES [dbo].[Pessoa] ([idPessoa])
GO
ALTER TABLE [dbo].[Pessoa_Escala] CHECK CONSTRAINT [FK_Pessoa_Escala_Pessoa]
GO
ALTER TABLE [dbo].[SubFuncao]  WITH CHECK ADD  CONSTRAINT [FK_SubFuncao_Funcao] FOREIGN KEY([idFuncao_fk])
REFERENCES [dbo].[Funcao] ([idFuncao])
GO
ALTER TABLE [dbo].[SubFuncao] CHECK CONSTRAINT [FK_SubFuncao_Funcao]
GO
USE [master]
GO
ALTER DATABASE [Escalas-Metodista] SET  READ_WRITE 
GO
