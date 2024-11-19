USE [BiblioDB]
GO



CREATE TABLE [Adherent](
	[CodeA] [varchar](4) NOT NULL,
	[NomA] [varchar](100) NULL,
	[Adresse] [varchar](200) NULL,
	[DateInscription] [datetime] NULL,
 CONSTRAINT [PK_Adherent] PRIMARY KEY  ([CodeA] )
) 
GO


