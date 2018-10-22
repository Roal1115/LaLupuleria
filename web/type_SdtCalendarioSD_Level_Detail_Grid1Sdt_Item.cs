/*
               File: type_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item
        Description: CalendarioSD_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:13.90
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
   public class SdtCalendarioSD_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtCalendarioSD_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre = "";
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate = DateTime.MinValue;
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription = "";
      }

      public SdtCalendarioSD_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("CalendarioId", gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendarioid, false);
         AddObjectProperty("CalendarioMesId", gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesid, false);
         AddObjectProperty("CalendarioMesNombre", gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("CalendarioMesDate", sDateCnv, false);
         AddObjectProperty("CalendarioMesDescription", gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription, false);
         return  ;
      }

      [  SoapElement( ElementName = "CalendarioId" )]
      [  XmlElement( ElementName = "CalendarioId"   )]
      public short gxTpr_Calendarioid
      {
         get {
            return gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendarioid ;
         }

         set {
            gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendarioid = value;
            SetDirty("Calendarioid");
         }

      }

      [  SoapElement( ElementName = "CalendarioMesId" )]
      [  XmlElement( ElementName = "CalendarioMesId"   )]
      public short gxTpr_Calendariomesid
      {
         get {
            return gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesid ;
         }

         set {
            gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesid = value;
            SetDirty("Calendariomesid");
         }

      }

      [  SoapElement( ElementName = "CalendarioMesNombre" )]
      [  XmlElement( ElementName = "CalendarioMesNombre"   )]
      public String gxTpr_Calendariomesnombre
      {
         get {
            return gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre ;
         }

         set {
            gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre = value;
            SetDirty("Calendariomesnombre");
         }

      }

      [  SoapElement( ElementName = "CalendarioMesDate" )]
      [  XmlElement( ElementName = "CalendarioMesDate"  , IsNullable=true )]
      public string gxTpr_Calendariomesdate_Nullable
      {
         get {
            if ( gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate = DateTime.MinValue;
            else
               gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Calendariomesdate
      {
         get {
            return gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate ;
         }

         set {
            gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate = value;
            SetDirty("Calendariomesdate");
         }

      }

      [  SoapElement( ElementName = "CalendarioMesDescription" )]
      [  XmlElement( ElementName = "CalendarioMesDescription"   )]
      public String gxTpr_Calendariomesdescription
      {
         get {
            return gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription ;
         }

         set {
            gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription = value;
            SetDirty("Calendariomesdescription");
         }

      }

      public void initialize( )
      {
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre = "";
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate = DateTime.MinValue;
         gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription = "";
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected short gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendarioid ;
      protected short gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesid ;
      protected String gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesnombre ;
      protected String gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdescription ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_Calendariomesdate ;
   }

   [DataContract(Name = @"CalendarioSD_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtCalendarioSD_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CalendarioId" , Order = 0 )]
      public Nullable<short> gxTpr_Calendarioid
      {
         get {
            return sdt.gxTpr_Calendarioid ;
         }

         set {
            sdt.gxTpr_Calendarioid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CalendarioMesId" , Order = 1 )]
      public Nullable<short> gxTpr_Calendariomesid
      {
         get {
            return sdt.gxTpr_Calendariomesid ;
         }

         set {
            sdt.gxTpr_Calendariomesid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CalendarioMesNombre" , Order = 2 )]
      public String gxTpr_Calendariomesnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Calendariomesnombre) ;
         }

         set {
            sdt.gxTpr_Calendariomesnombre = value;
         }

      }

      [DataMember( Name = "CalendarioMesDate" , Order = 3 )]
      public String gxTpr_Calendariomesdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Calendariomesdate) ;
         }

         set {
            sdt.gxTpr_Calendariomesdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "CalendarioMesDescription" , Order = 4 )]
      public String gxTpr_Calendariomesdescription
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Calendariomesdescription) ;
         }

         set {
            sdt.gxTpr_Calendariomesdescription = value;
         }

      }

      public SdtCalendarioSD_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtCalendarioSD_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtCalendarioSD_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
