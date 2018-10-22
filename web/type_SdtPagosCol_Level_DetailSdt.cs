/*
               File: type_SdtPagosCol_Level_DetailSdt
        Description: PagosCol_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.28
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
   [XmlRoot(ElementName = "PagosCol_Level_DetailSdt" )]
   [XmlType(TypeName =  "PagosCol_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtPagosCol_Level_DetailSdt : GxUserType
   {
      public SdtPagosCol_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj = "";
         gxTv_SdtPagosCol_Level_DetailSdt_Nombre = "";
      }

      public SdtPagosCol_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Tipotarj", gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj, false);
         AddObjectProperty("Nombre", gxTv_SdtPagosCol_Level_DetailSdt_Nombre, false);
         AddObjectProperty("Tarjeta", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtPagosCol_Level_DetailSdt_Tarjeta), 16, 0)), false);
         AddObjectProperty("Fechames", gxTv_SdtPagosCol_Level_DetailSdt_Fechames, false);
         AddObjectProperty("Fechaano", gxTv_SdtPagosCol_Level_DetailSdt_Fechaano, false);
         AddObjectProperty("Validationkey", gxTv_SdtPagosCol_Level_DetailSdt_Validationkey, false);
         return  ;
      }

      [  SoapElement( ElementName = "Tipotarj" )]
      [  XmlElement( ElementName = "Tipotarj"   )]
      public String gxTpr_Tipotarj
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj = value;
            SetDirty("Tipotarj");
         }

      }

      [  SoapElement( ElementName = "Nombre" )]
      [  XmlElement( ElementName = "Nombre"   )]
      public String gxTpr_Nombre
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Nombre ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Nombre = value;
            SetDirty("Nombre");
         }

      }

      [  SoapElement( ElementName = "Tarjeta" )]
      [  XmlElement( ElementName = "Tarjeta"   )]
      public long gxTpr_Tarjeta
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Tarjeta ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Tarjeta = value;
            SetDirty("Tarjeta");
         }

      }

      [  SoapElement( ElementName = "Fechames" )]
      [  XmlElement( ElementName = "Fechames"   )]
      public short gxTpr_Fechames
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Fechames ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Fechames = value;
            SetDirty("Fechames");
         }

      }

      [  SoapElement( ElementName = "Fechaano" )]
      [  XmlElement( ElementName = "Fechaano"   )]
      public short gxTpr_Fechaano
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Fechaano ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Fechaano = value;
            SetDirty("Fechaano");
         }

      }

      [  SoapElement( ElementName = "Validationkey" )]
      [  XmlElement( ElementName = "Validationkey"   )]
      public short gxTpr_Validationkey
      {
         get {
            return gxTv_SdtPagosCol_Level_DetailSdt_Validationkey ;
         }

         set {
            gxTv_SdtPagosCol_Level_DetailSdt_Validationkey = value;
            SetDirty("Validationkey");
         }

      }

      public void initialize( )
      {
         gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj = "";
         gxTv_SdtPagosCol_Level_DetailSdt_Nombre = "";
         return  ;
      }

      protected short gxTv_SdtPagosCol_Level_DetailSdt_Fechames ;
      protected short gxTv_SdtPagosCol_Level_DetailSdt_Fechaano ;
      protected short gxTv_SdtPagosCol_Level_DetailSdt_Validationkey ;
      protected long gxTv_SdtPagosCol_Level_DetailSdt_Tarjeta ;
      protected String gxTv_SdtPagosCol_Level_DetailSdt_Tipotarj ;
      protected String gxTv_SdtPagosCol_Level_DetailSdt_Nombre ;
   }

   [DataContract(Name = @"PagosCol_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtPagosCol_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtPagosCol_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPagosCol_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtPagosCol_Level_DetailSdt_RESTInterface( SdtPagosCol_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Tipotarj" , Order = 0 )]
      public String gxTpr_Tipotarj
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Tipotarj) ;
         }

         set {
            sdt.gxTpr_Tipotarj = value;
         }

      }

      [DataMember( Name = "Nombre" , Order = 1 )]
      public String gxTpr_Nombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Nombre) ;
         }

         set {
            sdt.gxTpr_Nombre = value;
         }

      }

      [DataMember( Name = "Tarjeta" , Order = 2 )]
      public String gxTpr_Tarjeta
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Tarjeta), 16, 0)) ;
         }

         set {
            sdt.gxTpr_Tarjeta = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Fechames" , Order = 3 )]
      public Nullable<short> gxTpr_Fechames
      {
         get {
            return sdt.gxTpr_Fechames ;
         }

         set {
            sdt.gxTpr_Fechames = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Fechaano" , Order = 4 )]
      public Nullable<short> gxTpr_Fechaano
      {
         get {
            return sdt.gxTpr_Fechaano ;
         }

         set {
            sdt.gxTpr_Fechaano = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Validationkey" , Order = 5 )]
      public Nullable<short> gxTpr_Validationkey
      {
         get {
            return sdt.gxTpr_Validationkey ;
         }

         set {
            sdt.gxTpr_Validationkey = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtPagosCol_Level_DetailSdt sdt
      {
         get {
            return (SdtPagosCol_Level_DetailSdt)Sdt ;
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
            sdt = new SdtPagosCol_Level_DetailSdt() ;
         }
      }

   }

}
