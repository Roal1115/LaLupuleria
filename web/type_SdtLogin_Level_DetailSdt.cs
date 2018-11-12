/*
               File: type_SdtLogin_Level_DetailSdt
        Description: Login_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:16:33.30
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
   [XmlRoot(ElementName = "Login_Level_DetailSdt" )]
   [XmlType(TypeName =  "Login_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtLogin_Level_DetailSdt : GxUserType
   {
      public SdtLogin_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtLogin_Level_DetailSdt_Usersname = "";
         gxTv_SdtLogin_Level_DetailSdt_Userspassword = "";
      }

      public SdtLogin_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Usersname", gxTv_SdtLogin_Level_DetailSdt_Usersname, false);
         AddObjectProperty("Userspassword", gxTv_SdtLogin_Level_DetailSdt_Userspassword, false);
         return  ;
      }

      [  SoapElement( ElementName = "Usersname" )]
      [  XmlElement( ElementName = "Usersname"   )]
      public String gxTpr_Usersname
      {
         get {
            return gxTv_SdtLogin_Level_DetailSdt_Usersname ;
         }

         set {
            gxTv_SdtLogin_Level_DetailSdt_Usersname = value;
            SetDirty("Usersname");
         }

      }

      [  SoapElement( ElementName = "Userspassword" )]
      [  XmlElement( ElementName = "Userspassword"   )]
      public String gxTpr_Userspassword
      {
         get {
            return gxTv_SdtLogin_Level_DetailSdt_Userspassword ;
         }

         set {
            gxTv_SdtLogin_Level_DetailSdt_Userspassword = value;
            SetDirty("Userspassword");
         }

      }

      public void initialize( )
      {
         gxTv_SdtLogin_Level_DetailSdt_Usersname = "";
         gxTv_SdtLogin_Level_DetailSdt_Userspassword = "";
         return  ;
      }

      protected String gxTv_SdtLogin_Level_DetailSdt_Usersname ;
      protected String gxTv_SdtLogin_Level_DetailSdt_Userspassword ;
   }

   [DataContract(Name = @"Login_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtLogin_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtLogin_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtLogin_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtLogin_Level_DetailSdt_RESTInterface( SdtLogin_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Usersname" , Order = 0 )]
      public String gxTpr_Usersname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Usersname) ;
         }

         set {
            sdt.gxTpr_Usersname = value;
         }

      }

      [DataMember( Name = "Userspassword" , Order = 1 )]
      public String gxTpr_Userspassword
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Userspassword) ;
         }

         set {
            sdt.gxTpr_Userspassword = value;
         }

      }

      public SdtLogin_Level_DetailSdt sdt
      {
         get {
            return (SdtLogin_Level_DetailSdt)Sdt ;
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
            sdt = new SdtLogin_Level_DetailSdt() ;
         }
      }

   }

}
