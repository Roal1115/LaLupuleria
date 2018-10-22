/*
               File: type_SdtPermisos_Level_DetailSdt
        Description: Permisos_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.35
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
   [XmlRoot(ElementName = "Permisos_Level_DetailSdt" )]
   [XmlType(TypeName =  "Permisos_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtPermisos_Level_DetailSdt : GxUserType
   {
      public SdtPermisos_Level_DetailSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtPermisos_Level_DetailSdt( IGxContext context )
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

   [DataContract(Name = @"Permisos_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtPermisos_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtPermisos_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPermisos_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtPermisos_Level_DetailSdt_RESTInterface( SdtPermisos_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      public SdtPermisos_Level_DetailSdt sdt
      {
         get {
            return (SdtPermisos_Level_DetailSdt)Sdt ;
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
            sdt = new SdtPermisos_Level_DetailSdt() ;
         }
      }

   }

}
