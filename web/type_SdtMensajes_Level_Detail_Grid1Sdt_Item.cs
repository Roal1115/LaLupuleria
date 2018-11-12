/*
               File: type_SdtMensajes_Level_Detail_Grid1Sdt_Item
        Description: Mensajes_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:17:40.40
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
   public class SdtMensajes_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtMensajes_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = "";
      }

      public SdtMensajes_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("MateriasId", gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasid, false);
         AddObjectProperty("MateriasProfCorreo", gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo, false);
         return  ;
      }

      [  SoapElement( ElementName = "MateriasId" )]
      [  XmlElement( ElementName = "MateriasId"   )]
      public short gxTpr_Materiasid
      {
         get {
            return gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasid ;
         }

         set {
            gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasid = value;
            SetDirty("Materiasid");
         }

      }

      [  SoapElement( ElementName = "MateriasProfCorreo" )]
      [  XmlElement( ElementName = "MateriasProfCorreo"   )]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo ;
         }

         set {
            gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = value;
            SetDirty("Materiasprofcorreo");
         }

      }

      public void initialize( )
      {
         gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = "";
         return  ;
      }

      protected short gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasid ;
      protected String gxTv_SdtMensajes_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo ;
   }

   [DataContract(Name = @"Mensajes_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtMensajes_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtMensajes_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "MateriasId" , Order = 0 )]
      public Nullable<short> gxTpr_Materiasid
      {
         get {
            return sdt.gxTpr_Materiasid ;
         }

         set {
            sdt.gxTpr_Materiasid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "MateriasProfCorreo" , Order = 1 )]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return sdt.gxTpr_Materiasprofcorreo ;
         }

         set {
            sdt.gxTpr_Materiasprofcorreo = value;
         }

      }

      public SdtMensajes_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtMensajes_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtMensajes_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
