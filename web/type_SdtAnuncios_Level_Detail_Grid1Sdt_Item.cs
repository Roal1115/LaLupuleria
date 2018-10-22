/*
               File: type_SdtAnuncios_Level_Detail_Grid1Sdt_Item
        Description: Anuncios_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:13.86
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
   public class SdtAnuncios_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtAnuncios_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname = "";
         gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles = "";
      }

      public SdtAnuncios_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("AnunciosTrsId", gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsid, false);
         AddObjectProperty("AnunciosTrsName", gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname, false);
         AddObjectProperty("AnunciosTrsDetalles", gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles, false);
         return  ;
      }

      [  SoapElement( ElementName = "AnunciosTrsId" )]
      [  XmlElement( ElementName = "AnunciosTrsId"   )]
      public short gxTpr_Anunciostrsid
      {
         get {
            return gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsid ;
         }

         set {
            gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsid = value;
            SetDirty("Anunciostrsid");
         }

      }

      [  SoapElement( ElementName = "AnunciosTrsName" )]
      [  XmlElement( ElementName = "AnunciosTrsName"   )]
      public String gxTpr_Anunciostrsname
      {
         get {
            return gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname ;
         }

         set {
            gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname = value;
            SetDirty("Anunciostrsname");
         }

      }

      [  SoapElement( ElementName = "AnunciosTrsDetalles" )]
      [  XmlElement( ElementName = "AnunciosTrsDetalles"   )]
      public String gxTpr_Anunciostrsdetalles
      {
         get {
            return gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles ;
         }

         set {
            gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles = value;
            SetDirty("Anunciostrsdetalles");
         }

      }

      public void initialize( )
      {
         gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname = "";
         gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles = "";
         return  ;
      }

      protected short gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsid ;
      protected String gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsname ;
      protected String gxTv_SdtAnuncios_Level_Detail_Grid1Sdt_Item_Anunciostrsdetalles ;
   }

   [DataContract(Name = @"Anuncios_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtAnuncios_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtAnuncios_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtAnuncios_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtAnuncios_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtAnuncios_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "AnunciosTrsId" , Order = 0 )]
      public Nullable<short> gxTpr_Anunciostrsid
      {
         get {
            return sdt.gxTpr_Anunciostrsid ;
         }

         set {
            sdt.gxTpr_Anunciostrsid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "AnunciosTrsName" , Order = 1 )]
      public String gxTpr_Anunciostrsname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Anunciostrsname) ;
         }

         set {
            sdt.gxTpr_Anunciostrsname = value;
         }

      }

      [DataMember( Name = "AnunciosTrsDetalles" , Order = 2 )]
      public String gxTpr_Anunciostrsdetalles
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Anunciostrsdetalles) ;
         }

         set {
            sdt.gxTpr_Anunciostrsdetalles = value;
         }

      }

      public SdtAnuncios_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtAnuncios_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtAnuncios_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
