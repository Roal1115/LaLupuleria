/*
               File: GxFullTextSearchReindexer
        Description: No description for object
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 19:1:15.67
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class GxFullTextSearchReindexer
   {
      public static int Reindex( IGxContext context )
      {
         GxSilentTrnSdt obj ;
         IGxSilentTrn trn ;
         bool result ;
         obj = new SdtDevices(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtMaterias(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtGroup(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         return 1 ;
      }

   }

}