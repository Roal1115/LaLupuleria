/*
               File: type_SdtHome_Level_DetailSdt
        Description: Home_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:29:9.86
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
   [XmlRoot(ElementName = "Home_Level_DetailSdt" )]
   [XmlType(TypeName =  "Home_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtHome_Level_DetailSdt : GxUserType
   {
      public SdtHome_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtHome_Level_DetailSdt_Usersbusiness = "";
      }

      public SdtHome_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Usersbusiness", gxTv_SdtHome_Level_DetailSdt_Usersbusiness, false);
         AddObjectProperty("Usersid", gxTv_SdtHome_Level_DetailSdt_Usersid, false);
         return  ;
      }

      [  SoapElement( ElementName = "Usersbusiness" )]
      [  XmlElement( ElementName = "Usersbusiness"   )]
      public String gxTpr_Usersbusiness
      {
         get {
            return gxTv_SdtHome_Level_DetailSdt_Usersbusiness ;
         }

         set {
            gxTv_SdtHome_Level_DetailSdt_Usersbusiness = value;
            SetDirty("Usersbusiness");
         }

      }

      [  SoapElement( ElementName = "Usersid" )]
      [  XmlElement( ElementName = "Usersid"   )]
      public short gxTpr_Usersid
      {
         get {
            return gxTv_SdtHome_Level_DetailSdt_Usersid ;
         }

         set {
            gxTv_SdtHome_Level_DetailSdt_Usersid = value;
            SetDirty("Usersid");
         }

      }

      public void initialize( )
      {
         gxTv_SdtHome_Level_DetailSdt_Usersbusiness = "";
         return  ;
      }

      protected short gxTv_SdtHome_Level_DetailSdt_Usersid ;
      protected String gxTv_SdtHome_Level_DetailSdt_Usersbusiness ;
   }

   [DataContract(Name = @"Home_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtHome_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtHome_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtHome_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtHome_Level_DetailSdt_RESTInterface( SdtHome_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Usersbusiness" , Order = 0 )]
      public String gxTpr_Usersbusiness
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Usersbusiness) ;
         }

         set {
            sdt.gxTpr_Usersbusiness = value;
         }

      }

      [DataMember( Name = "Usersid" , Order = 1 )]
      public Nullable<short> gxTpr_Usersid
      {
         get {
            return sdt.gxTpr_Usersid ;
         }

         set {
            sdt.gxTpr_Usersid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtHome_Level_DetailSdt sdt
      {
         get {
            return (SdtHome_Level_DetailSdt)Sdt ;
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
            sdt = new SdtHome_Level_DetailSdt() ;
         }
      }

   }

}
