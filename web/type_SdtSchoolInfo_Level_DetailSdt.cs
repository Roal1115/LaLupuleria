/*
               File: type_SdtSchoolInfo_Level_DetailSdt
        Description: SchoolInfo_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 19:6:46.45
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
   [XmlRoot(ElementName = "SchoolInfo_Level_DetailSdt" )]
   [XmlType(TypeName =  "SchoolInfo_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSchoolInfo_Level_DetailSdt : GxUserType
   {
      public SdtSchoolInfo_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone = "";
      }

      public SdtSchoolInfo_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("SchoolInfoTrsId", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsid, false);
         AddObjectProperty("SchoolInfoTrsImagen", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen, false);
         AddObjectProperty("SchoolInfoTrsImagen_GXI", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi, false);
         AddObjectProperty("SchoolInfoTrsNombre", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre, false);
         AddObjectProperty("SchoolInfoTrsSolgan", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan, false);
         AddObjectProperty("SchoolInfoTrsAddress", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress, false);
         AddObjectProperty("SchoolInfoTrsPhone", gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone, false);
         return  ;
      }

      [  SoapElement( ElementName = "SchoolInfoTrsId" )]
      [  XmlElement( ElementName = "SchoolInfoTrsId"   )]
      public short gxTpr_Schoolinfotrsid
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsid ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsid = value;
            SetDirty("Schoolinfotrsid");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsImagen" )]
      [  XmlElement( ElementName = "SchoolInfoTrsImagen"   )]
      [GxUpload()]
      public String gxTpr_Schoolinfotrsimagen
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen = value;
            SetDirty("Schoolinfotrsimagen");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsImagen_GXI" )]
      [  XmlElement( ElementName = "SchoolInfoTrsImagen_GXI"   )]
      public String gxTpr_Schoolinfotrsimagen_gxi
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi = value;
            SetDirty("Schoolinfotrsimagen_gxi");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsNombre" )]
      [  XmlElement( ElementName = "SchoolInfoTrsNombre"   )]
      public String gxTpr_Schoolinfotrsnombre
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre = value;
            SetDirty("Schoolinfotrsnombre");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsSolgan" )]
      [  XmlElement( ElementName = "SchoolInfoTrsSolgan"   )]
      public String gxTpr_Schoolinfotrssolgan
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan = value;
            SetDirty("Schoolinfotrssolgan");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsAddress" )]
      [  XmlElement( ElementName = "SchoolInfoTrsAddress"   )]
      public String gxTpr_Schoolinfotrsaddress
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress = value;
            SetDirty("Schoolinfotrsaddress");
         }

      }

      [  SoapElement( ElementName = "SchoolInfoTrsPhone" )]
      [  XmlElement( ElementName = "SchoolInfoTrsPhone"   )]
      public String gxTpr_Schoolinfotrsphone
      {
         get {
            return gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone ;
         }

         set {
            gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone = value;
            SetDirty("Schoolinfotrsphone");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress = "";
         gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone = "";
         return  ;
      }

      protected short gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsid ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsnombre ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrssolgan ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsphone ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen_gxi ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsaddress ;
      protected String gxTv_SdtSchoolInfo_Level_DetailSdt_Schoolinfotrsimagen ;
   }

   [DataContract(Name = @"SchoolInfo_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSchoolInfo_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSchoolInfo_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSchoolInfo_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSchoolInfo_Level_DetailSdt_RESTInterface( SdtSchoolInfo_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SchoolInfoTrsId" , Order = 0 )]
      public Nullable<short> gxTpr_Schoolinfotrsid
      {
         get {
            return sdt.gxTpr_Schoolinfotrsid ;
         }

         set {
            sdt.gxTpr_Schoolinfotrsid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SchoolInfoTrsImagen" , Order = 1 )]
      [GxUpload()]
      public String gxTpr_Schoolinfotrsimagen
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Schoolinfotrsimagen)) ? PathUtil.RelativeURL( sdt.gxTpr_Schoolinfotrsimagen) : StringUtil.RTrim( sdt.gxTpr_Schoolinfotrsimagen_gxi)) ;
         }

         set {
            sdt.gxTpr_Schoolinfotrsimagen = value;
         }

      }

      [DataMember( Name = "SchoolInfoTrsNombre" , Order = 2 )]
      public String gxTpr_Schoolinfotrsnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Schoolinfotrsnombre) ;
         }

         set {
            sdt.gxTpr_Schoolinfotrsnombre = value;
         }

      }

      [DataMember( Name = "SchoolInfoTrsSolgan" , Order = 3 )]
      public String gxTpr_Schoolinfotrssolgan
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Schoolinfotrssolgan) ;
         }

         set {
            sdt.gxTpr_Schoolinfotrssolgan = value;
         }

      }

      [DataMember( Name = "SchoolInfoTrsAddress" , Order = 4 )]
      public String gxTpr_Schoolinfotrsaddress
      {
         get {
            return sdt.gxTpr_Schoolinfotrsaddress ;
         }

         set {
            sdt.gxTpr_Schoolinfotrsaddress = value;
         }

      }

      [DataMember( Name = "SchoolInfoTrsPhone" , Order = 5 )]
      public String gxTpr_Schoolinfotrsphone
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Schoolinfotrsphone) ;
         }

         set {
            sdt.gxTpr_Schoolinfotrsphone = value;
         }

      }

      public SdtSchoolInfo_Level_DetailSdt sdt
      {
         get {
            return (SdtSchoolInfo_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSchoolInfo_Level_DetailSdt() ;
         }
      }

   }

}
