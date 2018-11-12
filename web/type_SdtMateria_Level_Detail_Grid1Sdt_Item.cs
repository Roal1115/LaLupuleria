/*
               File: type_SdtMateria_Level_Detail_Grid1Sdt_Item
        Description: Materia_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.19
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
   public class SdtMateria_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtMateria_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre = "";
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = "";
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor = "";
      }

      public SdtMateria_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("MateriasId", gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasid, false);
         AddObjectProperty("MateriasNombre", gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre, false);
         AddObjectProperty("MateriasProfCorreo", gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo, false);
         AddObjectProperty("MateriasProfesor", gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor, false);
         return  ;
      }

      [  SoapElement( ElementName = "MateriasId" )]
      [  XmlElement( ElementName = "MateriasId"   )]
      public short gxTpr_Materiasid
      {
         get {
            return gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasid ;
         }

         set {
            gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasid = value;
            SetDirty("Materiasid");
         }

      }

      [  SoapElement( ElementName = "MateriasNombre" )]
      [  XmlElement( ElementName = "MateriasNombre"   )]
      public String gxTpr_Materiasnombre
      {
         get {
            return gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre ;
         }

         set {
            gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre = value;
            SetDirty("Materiasnombre");
         }

      }

      [  SoapElement( ElementName = "MateriasProfCorreo" )]
      [  XmlElement( ElementName = "MateriasProfCorreo"   )]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo ;
         }

         set {
            gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = value;
            SetDirty("Materiasprofcorreo");
         }

      }

      [  SoapElement( ElementName = "MateriasProfesor" )]
      [  XmlElement( ElementName = "MateriasProfesor"   )]
      public String gxTpr_Materiasprofesor
      {
         get {
            return gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor ;
         }

         set {
            gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor = value;
            SetDirty("Materiasprofesor");
         }

      }

      public void initialize( )
      {
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre = "";
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo = "";
         gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor = "";
         return  ;
      }

      protected short gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasid ;
      protected String gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasnombre ;
      protected String gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofesor ;
      protected String gxTv_SdtMateria_Level_Detail_Grid1Sdt_Item_Materiasprofcorreo ;
   }

   [DataContract(Name = @"Materia_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtMateria_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtMateria_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
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

      [DataMember( Name = "MateriasProfCorreo" , Order = 2 )]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return sdt.gxTpr_Materiasprofcorreo ;
         }

         set {
            sdt.gxTpr_Materiasprofcorreo = value;
         }

      }

      [DataMember( Name = "MateriasProfesor" , Order = 3 )]
      public String gxTpr_Materiasprofesor
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasprofesor) ;
         }

         set {
            sdt.gxTpr_Materiasprofesor = value;
         }

      }

      public SdtMateria_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtMateria_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtMateria_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
