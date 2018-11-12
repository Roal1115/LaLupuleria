/*
               File: type_SdtOrganizations_Level_Detail_Grid2Sdt_Item
        Description: Organizations_Level_Detail_Grid2Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:11:49.38
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
   [XmlRoot(ElementName = "Item" )]
   [XmlType(TypeName =  "Item" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtOrganizations_Level_Detail_Grid2Sdt_Item : GxUserType
   {
      public SdtOrganizations_Level_Detail_Grid2Sdt_Item( )
      {
         /* Constructor for serialization */
      }

      public SdtOrganizations_Level_Detail_Grid2Sdt_Item( IGxContext context )
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

   [DataContract(Name = @"Organizations_Level_Detail_Grid2Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtOrganizations_Level_Detail_Grid2Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtOrganizations_Level_Detail_Grid2Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtOrganizations_Level_Detail_Grid2Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtOrganizations_Level_Detail_Grid2Sdt_Item_RESTInterface( SdtOrganizations_Level_Detail_Grid2Sdt_Item psdt ) : base(psdt)
      {
      }

      public SdtOrganizations_Level_Detail_Grid2Sdt_Item sdt
      {
         get {
            return (SdtOrganizations_Level_Detail_Grid2Sdt_Item)Sdt ;
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
            sdt = new SdtOrganizations_Level_Detail_Grid2Sdt_Item() ;
         }
      }

   }

}
