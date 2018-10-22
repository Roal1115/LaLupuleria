/*
               File: type_SdtPushTestMain_Level_Detail_Grid1Sdt_Item
        Description: PushTestMain_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.45
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
   public class SdtPushTestMain_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtPushTestMain_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname = "";
      }

      public SdtPushTestMain_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("GroupId", gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupid, false);
         AddObjectProperty("Groupname", gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname, false);
         AddObjectProperty("Issuscribed", gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Issuscribed, false);
         return  ;
      }

      [  SoapElement( ElementName = "GroupId" )]
      [  XmlElement( ElementName = "GroupId"   )]
      public short gxTpr_Groupid
      {
         get {
            return gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupid ;
         }

         set {
            gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupid = value;
            SetDirty("Groupid");
         }

      }

      [  SoapElement( ElementName = "Groupname" )]
      [  XmlElement( ElementName = "Groupname"   )]
      public String gxTpr_Groupname
      {
         get {
            return gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname ;
         }

         set {
            gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname = value;
            SetDirty("Groupname");
         }

      }

      [  SoapElement( ElementName = "Issuscribed" )]
      [  XmlElement( ElementName = "Issuscribed"   )]
      public bool gxTpr_Issuscribed
      {
         get {
            return gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Issuscribed ;
         }

         set {
            gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Issuscribed = value;
            SetDirty("Issuscribed");
         }

      }

      public void initialize( )
      {
         gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname = "";
         return  ;
      }

      protected short gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupid ;
      protected String gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Groupname ;
      protected bool gxTv_SdtPushTestMain_Level_Detail_Grid1Sdt_Item_Issuscribed ;
   }

   [DataContract(Name = @"PushTestMain_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtPushTestMain_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtPushTestMain_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "GroupId" , Order = 0 )]
      public Nullable<short> gxTpr_Groupid
      {
         get {
            return sdt.gxTpr_Groupid ;
         }

         set {
            sdt.gxTpr_Groupid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Groupname" , Order = 1 )]
      public String gxTpr_Groupname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Groupname) ;
         }

         set {
            sdt.gxTpr_Groupname = value;
         }

      }

      [DataMember( Name = "Issuscribed" , Order = 2 )]
      public bool gxTpr_Issuscribed
      {
         get {
            return sdt.gxTpr_Issuscribed ;
         }

         set {
            sdt.gxTpr_Issuscribed = value;
         }

      }

      public SdtPushTestMain_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtPushTestMain_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtPushTestMain_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
