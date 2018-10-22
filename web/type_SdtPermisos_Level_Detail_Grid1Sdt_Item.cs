/*
               File: type_SdtPermisos_Level_Detail_Grid1Sdt_Item
        Description: Permisos_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.37
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
   public class SdtPermisos_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtPermisos_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai = DateTime.MinValue;
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf = DateTime.MinValue;
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia = "";
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo = "";
      }

      public SdtPermisos_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("Diai", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("Diaf", sDateCnv, false);
         AddObjectProperty("Check1", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check1, false);
         AddObjectProperty("Check2", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check2, false);
         AddObjectProperty("Check3", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check3, false);
         AddObjectProperty("Check4", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check4, false);
         AddObjectProperty("Check5", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check5, false);
         AddObjectProperty("Familia", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Familia, false);
         AddObjectProperty("Afamilia", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia, false);
         AddObjectProperty("Motivo", gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo, false);
         return  ;
      }

      [  SoapElement( ElementName = "Diai" )]
      [  XmlElement( ElementName = "Diai"  , IsNullable=true )]
      public string gxTpr_Diai_Nullable
      {
         get {
            if ( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai = DateTime.MinValue;
            else
               gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Diai
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai = value;
            SetDirty("Diai");
         }

      }

      [  SoapElement( ElementName = "Diaf" )]
      [  XmlElement( ElementName = "Diaf"  , IsNullable=true )]
      public string gxTpr_Diaf_Nullable
      {
         get {
            if ( gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf = DateTime.MinValue;
            else
               gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Diaf
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf = value;
            SetDirty("Diaf");
         }

      }

      [  SoapElement( ElementName = "Check1" )]
      [  XmlElement( ElementName = "Check1"   )]
      public bool gxTpr_Check1
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check1 ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check1 = value;
            SetDirty("Check1");
         }

      }

      [  SoapElement( ElementName = "Check2" )]
      [  XmlElement( ElementName = "Check2"   )]
      public bool gxTpr_Check2
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check2 ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check2 = value;
            SetDirty("Check2");
         }

      }

      [  SoapElement( ElementName = "Check3" )]
      [  XmlElement( ElementName = "Check3"   )]
      public bool gxTpr_Check3
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check3 ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check3 = value;
            SetDirty("Check3");
         }

      }

      [  SoapElement( ElementName = "Check4" )]
      [  XmlElement( ElementName = "Check4"   )]
      public bool gxTpr_Check4
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check4 ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check4 = value;
            SetDirty("Check4");
         }

      }

      [  SoapElement( ElementName = "Check5" )]
      [  XmlElement( ElementName = "Check5"   )]
      public bool gxTpr_Check5
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check5 ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check5 = value;
            SetDirty("Check5");
         }

      }

      [  SoapElement( ElementName = "Familia" )]
      [  XmlElement( ElementName = "Familia"   )]
      public int gxTpr_Familia
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Familia ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Familia = value;
            SetDirty("Familia");
         }

      }

      [  SoapElement( ElementName = "Afamilia" )]
      [  XmlElement( ElementName = "Afamilia"   )]
      public String gxTpr_Afamilia
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia = value;
            SetDirty("Afamilia");
         }

      }

      [  SoapElement( ElementName = "Motivo" )]
      [  XmlElement( ElementName = "Motivo"   )]
      public String gxTpr_Motivo
      {
         get {
            return gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo ;
         }

         set {
            gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo = value;
            SetDirty("Motivo");
         }

      }

      public void initialize( )
      {
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai = DateTime.MinValue;
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf = DateTime.MinValue;
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia = "";
         gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo = "";
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected int gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Familia ;
      protected String gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Afamilia ;
      protected String gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Motivo ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diai ;
      protected DateTime gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Diaf ;
      protected bool gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check1 ;
      protected bool gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check2 ;
      protected bool gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check3 ;
      protected bool gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check4 ;
      protected bool gxTv_SdtPermisos_Level_Detail_Grid1Sdt_Item_Check5 ;
   }

   [DataContract(Name = @"Permisos_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtPermisos_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtPermisos_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Diai" , Order = 0 )]
      public String gxTpr_Diai
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Diai) ;
         }

         set {
            sdt.gxTpr_Diai = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "Diaf" , Order = 1 )]
      public String gxTpr_Diaf
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Diaf) ;
         }

         set {
            sdt.gxTpr_Diaf = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "Check1" , Order = 2 )]
      public bool gxTpr_Check1
      {
         get {
            return sdt.gxTpr_Check1 ;
         }

         set {
            sdt.gxTpr_Check1 = value;
         }

      }

      [DataMember( Name = "Check2" , Order = 3 )]
      public bool gxTpr_Check2
      {
         get {
            return sdt.gxTpr_Check2 ;
         }

         set {
            sdt.gxTpr_Check2 = value;
         }

      }

      [DataMember( Name = "Check3" , Order = 4 )]
      public bool gxTpr_Check3
      {
         get {
            return sdt.gxTpr_Check3 ;
         }

         set {
            sdt.gxTpr_Check3 = value;
         }

      }

      [DataMember( Name = "Check4" , Order = 5 )]
      public bool gxTpr_Check4
      {
         get {
            return sdt.gxTpr_Check4 ;
         }

         set {
            sdt.gxTpr_Check4 = value;
         }

      }

      [DataMember( Name = "Check5" , Order = 6 )]
      public bool gxTpr_Check5
      {
         get {
            return sdt.gxTpr_Check5 ;
         }

         set {
            sdt.gxTpr_Check5 = value;
         }

      }

      [DataMember( Name = "Familia" , Order = 7 )]
      public Nullable<int> gxTpr_Familia
      {
         get {
            return sdt.gxTpr_Familia ;
         }

         set {
            sdt.gxTpr_Familia = (int)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Afamilia" , Order = 8 )]
      public String gxTpr_Afamilia
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Afamilia) ;
         }

         set {
            sdt.gxTpr_Afamilia = value;
         }

      }

      [DataMember( Name = "Motivo" , Order = 9 )]
      public String gxTpr_Motivo
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Motivo) ;
         }

         set {
            sdt.gxTpr_Motivo = value;
         }

      }

      public SdtPermisos_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtPermisos_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtPermisos_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
