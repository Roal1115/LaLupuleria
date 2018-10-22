/*
               File: type_SdtInfoEs_Level_DetailSdt
        Description: InfoEs_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:17:40.34
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
   [XmlRoot(ElementName = "InfoEs_Level_DetailSdt" )]
   [XmlType(TypeName =  "InfoEs_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtInfoEs_Level_DetailSdt : GxUserType
   {
      public SdtInfoEs_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Userscurp = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion = "";
      }

      public SdtInfoEs_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("UsersId", gxTv_SdtInfoEs_Level_DetailSdt_Usersid, false);
         AddObjectProperty("UsersFotografia", gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia, false);
         AddObjectProperty("UsersFotografia_GXI", gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi, false);
         AddObjectProperty("UsersNombre", gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre, false);
         AddObjectProperty("UsersCURP", gxTv_SdtInfoEs_Level_DetailSdt_Userscurp, false);
         AddObjectProperty("UsersDireccion", gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsersId" )]
      [  XmlElement( ElementName = "UsersId"   )]
      public short gxTpr_Usersid
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Usersid ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Usersid = value;
            SetDirty("Usersid");
         }

      }

      [  SoapElement( ElementName = "UsersFotografia" )]
      [  XmlElement( ElementName = "UsersFotografia"   )]
      [GxUpload()]
      public String gxTpr_Usersfotografia
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia = value;
            SetDirty("Usersfotografia");
         }

      }

      [  SoapElement( ElementName = "UsersFotografia_GXI" )]
      [  XmlElement( ElementName = "UsersFotografia_GXI"   )]
      public String gxTpr_Usersfotografia_gxi
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi = value;
            SetDirty("Usersfotografia_gxi");
         }

      }

      [  SoapElement( ElementName = "UsersNombre" )]
      [  XmlElement( ElementName = "UsersNombre"   )]
      public String gxTpr_Usersnombre
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre = value;
            SetDirty("Usersnombre");
         }

      }

      [  SoapElement( ElementName = "UsersCURP" )]
      [  XmlElement( ElementName = "UsersCURP"   )]
      public String gxTpr_Userscurp
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Userscurp ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Userscurp = value;
            SetDirty("Userscurp");
         }

      }

      [  SoapElement( ElementName = "UsersDireccion" )]
      [  XmlElement( ElementName = "UsersDireccion"   )]
      public String gxTpr_Usersdireccion
      {
         get {
            return gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion ;
         }

         set {
            gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion = value;
            SetDirty("Usersdireccion");
         }

      }

      public void initialize( )
      {
         gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Userscurp = "";
         gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion = "";
         return  ;
      }

      protected short gxTv_SdtInfoEs_Level_DetailSdt_Usersid ;
      protected String gxTv_SdtInfoEs_Level_DetailSdt_Userscurp ;
      protected String gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia_gxi ;
      protected String gxTv_SdtInfoEs_Level_DetailSdt_Usersnombre ;
      protected String gxTv_SdtInfoEs_Level_DetailSdt_Usersdireccion ;
      protected String gxTv_SdtInfoEs_Level_DetailSdt_Usersfotografia ;
   }

   [DataContract(Name = @"InfoEs_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtInfoEs_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtInfoEs_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtInfoEs_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtInfoEs_Level_DetailSdt_RESTInterface( SdtInfoEs_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsersId" , Order = 0 )]
      public Nullable<short> gxTpr_Usersid
      {
         get {
            return sdt.gxTpr_Usersid ;
         }

         set {
            sdt.gxTpr_Usersid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UsersFotografia" , Order = 1 )]
      [GxUpload()]
      public String gxTpr_Usersfotografia
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Usersfotografia)) ? PathUtil.RelativeURL( sdt.gxTpr_Usersfotografia) : StringUtil.RTrim( sdt.gxTpr_Usersfotografia_gxi)) ;
         }

         set {
            sdt.gxTpr_Usersfotografia = value;
         }

      }

      [DataMember( Name = "UsersNombre" , Order = 2 )]
      public String gxTpr_Usersnombre
      {
         get {
            return sdt.gxTpr_Usersnombre ;
         }

         set {
            sdt.gxTpr_Usersnombre = value;
         }

      }

      [DataMember( Name = "UsersCURP" , Order = 3 )]
      public String gxTpr_Userscurp
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Userscurp) ;
         }

         set {
            sdt.gxTpr_Userscurp = value;
         }

      }

      [DataMember( Name = "UsersDireccion" , Order = 4 )]
      public String gxTpr_Usersdireccion
      {
         get {
            return sdt.gxTpr_Usersdireccion ;
         }

         set {
            sdt.gxTpr_Usersdireccion = value;
         }

      }

      public SdtInfoEs_Level_DetailSdt sdt
      {
         get {
            return (SdtInfoEs_Level_DetailSdt)Sdt ;
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
            sdt = new SdtInfoEs_Level_DetailSdt() ;
         }
      }

   }

}
