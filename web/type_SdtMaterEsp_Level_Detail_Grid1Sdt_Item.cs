/*
               File: type_SdtMaterEsp_Level_Detail_Grid1Sdt_Item
        Description: MaterEsp_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.11
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
   public class SdtMaterEsp_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtMaterEsp_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre = "";
      }

      public SdtMaterEsp_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("CalifasId", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califasid, false);
         AddObjectProperty("MateriasNombre", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre, false);
         AddObjectProperty("Califas1", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas1, false);
         AddObjectProperty("Califas2", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas2, false);
         AddObjectProperty("Califas3", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas3, false);
         AddObjectProperty("Califas4", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas4, false);
         AddObjectProperty("Califas5", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas5, false);
         AddObjectProperty("Califas6", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas6, false);
         AddObjectProperty("Califas7", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas7, false);
         AddObjectProperty("Califas8", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas8, false);
         AddObjectProperty("MateriasId", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasid, false);
         AddObjectProperty("Promedio", gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Promedio, false);
         return  ;
      }

      [  SoapElement( ElementName = "CalifasId" )]
      [  XmlElement( ElementName = "CalifasId"   )]
      public short gxTpr_Califasid
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califasid ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califasid = value;
            SetDirty("Califasid");
         }

      }

      [  SoapElement( ElementName = "MateriasNombre" )]
      [  XmlElement( ElementName = "MateriasNombre"   )]
      public String gxTpr_Materiasnombre
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre = value;
            SetDirty("Materiasnombre");
         }

      }

      [  SoapElement( ElementName = "Califas1" )]
      [  XmlElement( ElementName = "Califas1"   )]
      public short gxTpr_Califas1
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas1 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas1 = value;
            SetDirty("Califas1");
         }

      }

      [  SoapElement( ElementName = "Califas2" )]
      [  XmlElement( ElementName = "Califas2"   )]
      public short gxTpr_Califas2
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas2 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas2 = value;
            SetDirty("Califas2");
         }

      }

      [  SoapElement( ElementName = "Califas3" )]
      [  XmlElement( ElementName = "Califas3"   )]
      public short gxTpr_Califas3
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas3 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas3 = value;
            SetDirty("Califas3");
         }

      }

      [  SoapElement( ElementName = "Califas4" )]
      [  XmlElement( ElementName = "Califas4"   )]
      public short gxTpr_Califas4
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas4 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas4 = value;
            SetDirty("Califas4");
         }

      }

      [  SoapElement( ElementName = "Califas5" )]
      [  XmlElement( ElementName = "Califas5"   )]
      public short gxTpr_Califas5
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas5 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas5 = value;
            SetDirty("Califas5");
         }

      }

      [  SoapElement( ElementName = "Califas6" )]
      [  XmlElement( ElementName = "Califas6"   )]
      public short gxTpr_Califas6
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas6 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas6 = value;
            SetDirty("Califas6");
         }

      }

      [  SoapElement( ElementName = "Califas7" )]
      [  XmlElement( ElementName = "Califas7"   )]
      public short gxTpr_Califas7
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas7 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas7 = value;
            SetDirty("Califas7");
         }

      }

      [  SoapElement( ElementName = "Califas8" )]
      [  XmlElement( ElementName = "Califas8"   )]
      public short gxTpr_Califas8
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas8 ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas8 = value;
            SetDirty("Califas8");
         }

      }

      [  SoapElement( ElementName = "MateriasId" )]
      [  XmlElement( ElementName = "MateriasId"   )]
      public short gxTpr_Materiasid
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasid ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasid = value;
            SetDirty("Materiasid");
         }

      }

      [  SoapElement( ElementName = "Promedio" )]
      [  XmlElement( ElementName = "Promedio"   )]
      public short gxTpr_Promedio
      {
         get {
            return gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Promedio ;
         }

         set {
            gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Promedio = value;
            SetDirty("Promedio");
         }

      }

      public void initialize( )
      {
         gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre = "";
         return  ;
      }

      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califasid ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas1 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas2 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas3 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas4 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas5 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas6 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas7 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Califas8 ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasid ;
      protected short gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Promedio ;
      protected String gxTv_SdtMaterEsp_Level_Detail_Grid1Sdt_Item_Materiasnombre ;
   }

   [DataContract(Name = @"MaterEsp_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtMaterEsp_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtMaterEsp_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CalifasId" , Order = 0 )]
      public Nullable<short> gxTpr_Califasid
      {
         get {
            return sdt.gxTpr_Califasid ;
         }

         set {
            sdt.gxTpr_Califasid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "MateriasNombre" , Order = 1 )]
      public String gxTpr_Materiasnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasnombre) ;
         }

         set {
            sdt.gxTpr_Materiasnombre = value;
         }

      }

      [DataMember( Name = "Califas1" , Order = 2 )]
      public Nullable<short> gxTpr_Califas1
      {
         get {
            return sdt.gxTpr_Califas1 ;
         }

         set {
            sdt.gxTpr_Califas1 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas2" , Order = 3 )]
      public Nullable<short> gxTpr_Califas2
      {
         get {
            return sdt.gxTpr_Califas2 ;
         }

         set {
            sdt.gxTpr_Califas2 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas3" , Order = 4 )]
      public Nullable<short> gxTpr_Califas3
      {
         get {
            return sdt.gxTpr_Califas3 ;
         }

         set {
            sdt.gxTpr_Califas3 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas4" , Order = 5 )]
      public Nullable<short> gxTpr_Califas4
      {
         get {
            return sdt.gxTpr_Califas4 ;
         }

         set {
            sdt.gxTpr_Califas4 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas5" , Order = 6 )]
      public Nullable<short> gxTpr_Califas5
      {
         get {
            return sdt.gxTpr_Califas5 ;
         }

         set {
            sdt.gxTpr_Califas5 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas6" , Order = 7 )]
      public Nullable<short> gxTpr_Califas6
      {
         get {
            return sdt.gxTpr_Califas6 ;
         }

         set {
            sdt.gxTpr_Califas6 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas7" , Order = 8 )]
      public Nullable<short> gxTpr_Califas7
      {
         get {
            return sdt.gxTpr_Califas7 ;
         }

         set {
            sdt.gxTpr_Califas7 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Califas8" , Order = 9 )]
      public Nullable<short> gxTpr_Califas8
      {
         get {
            return sdt.gxTpr_Califas8 ;
         }

         set {
            sdt.gxTpr_Califas8 = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "MateriasId" , Order = 10 )]
      public Nullable<short> gxTpr_Materiasid
      {
         get {
            return sdt.gxTpr_Materiasid ;
         }

         set {
            sdt.gxTpr_Materiasid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Promedio" , Order = 11 )]
      public Nullable<short> gxTpr_Promedio
      {
         get {
            return sdt.gxTpr_Promedio ;
         }

         set {
            sdt.gxTpr_Promedio = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtMaterEsp_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtMaterEsp_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtMaterEsp_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
