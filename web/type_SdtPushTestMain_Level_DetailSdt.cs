/*
               File: type_SdtPushTestMain_Level_DetailSdt
        Description: PushTestMain_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.43
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
   [XmlRoot(ElementName = "PushTestMain_Level_DetailSdt" )]
   [XmlType(TypeName =  "PushTestMain_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtPushTestMain_Level_DetailSdt : GxUserType
   {
      public SdtPushTestMain_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop = "";
      }

      public SdtPushTestMain_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtPushTestMain_Level_DetailSdt_Gxdynprop ;
   }

   [DataContract(Name = @"PushTestMain_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtPushTestMain_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtPushTestMain_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPushTestMain_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtPushTestMain_Level_DetailSdt_RESTInterface( SdtPushTestMain_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Gxdynprop" , Order = 0 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtPushTestMain_Level_DetailSdt sdt
      {
         get {
            return (SdtPushTestMain_Level_DetailSdt)Sdt ;
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
            sdt = new SdtPushTestMain_Level_DetailSdt() ;
         }
      }

   }

}
