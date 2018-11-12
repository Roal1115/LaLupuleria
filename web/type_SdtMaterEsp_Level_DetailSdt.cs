/*
               File: type_SdtMaterEsp_Level_DetailSdt
        Description: MaterEsp_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.9
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "MaterEsp_Level_DetailSdt" )]
   [XmlType(TypeName =  "MaterEsp_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtMaterEsp_Level_DetailSdt : GxUserType
   {
      public SdtMaterEsp_Level_DetailSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtMaterEsp_Level_DetailSdt( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         return  ;
      }

      public void initialize( )
      {
         return  ;
      }

   }

   [DataContract(Name = @"MaterEsp_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtMaterEsp_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtMaterEsp_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMaterEsp_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtMaterEsp_Level_DetailSdt_RESTInterface( SdtMaterEsp_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      public SdtMaterEsp_Level_DetailSdt sdt
      {
         get {
            return (SdtMaterEsp_Level_DetailSdt)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtMaterEsp_Level_DetailSdt() ;
         }
      }

   }

}
