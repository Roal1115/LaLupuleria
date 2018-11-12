/*
               File: type_SdtHome_Level_Detail_Grid1Sdt_Item
        Description: Home_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:29:9.87
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
   public class SdtHome_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtHome_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
      }

      public SdtHome_Level_Detail_Grid1Sdt_Item( IGxContext context )
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

   [DataContract(Name = @"Home_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtHome_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtHome_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtHome_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtHome_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtHome_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      public SdtHome_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtHome_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtHome_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
