/*
               File: type_SdtDevices_Group
        Description: Devices
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:53.10
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
   [XmlRoot(ElementName = "Devices.Group" )]
   [XmlType(TypeName =  "Devices.Group" , Namespace = "Verbo2" )]
   [Serializable]
   public class SdtDevices_Group : GxSilentTrnSdt, IGxSilentTrnGridItem
   {
      public SdtDevices_Group( )
      {
      }

      public SdtDevices_Group( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
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

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"GroupId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Group");
         metadata.Set("BT", "DevicesGroup");
         metadata.Set("PK", "[ \"GroupId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"DeviceId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"GroupId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Modified");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Groupid_Z");
         state.Add("gxTpr_Groupname_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtDevices_Group sdt ;
         sdt = (SdtDevices_Group)(source);
         gxTv_SdtDevices_Group_Groupid = sdt.gxTv_SdtDevices_Group_Groupid ;
         gxTv_SdtDevices_Group_Groupname = sdt.gxTv_SdtDevices_Group_Groupname ;
         gxTv_SdtDevices_Group_Mode = sdt.gxTv_SdtDevices_Group_Mode ;
         gxTv_SdtDevices_Group_Modified = sdt.gxTv_SdtDevices_Group_Modified ;
         gxTv_SdtDevices_Group_Initialized = sdt.gxTv_SdtDevices_Group_Initialized ;
         gxTv_SdtDevices_Group_Groupid_Z = sdt.gxTv_SdtDevices_Group_Groupid_Z ;
         gxTv_SdtDevices_Group_Groupname_Z = sdt.gxTv_SdtDevices_Group_Groupname_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("GroupId", gxTv_SdtDevices_Group_Groupid, false);
         AddObjectProperty("GroupName", gxTv_SdtDevices_Group_Groupname, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtDevices_Group_Mode, false);
            AddObjectProperty("Modified", gxTv_SdtDevices_Group_Modified, false);
            AddObjectProperty("Initialized", gxTv_SdtDevices_Group_Initialized, false);
            AddObjectProperty("GroupId_Z", gxTv_SdtDevices_Group_Groupid_Z, false);
            AddObjectProperty("GroupName_Z", gxTv_SdtDevices_Group_Groupname_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtDevices_Group sdt )
      {
         if ( sdt.IsDirty("GroupId") )
         {
            gxTv_SdtDevices_Group_Groupid = sdt.gxTv_SdtDevices_Group_Groupid ;
         }
         if ( sdt.IsDirty("GroupName") )
         {
            gxTv_SdtDevices_Group_Groupname = sdt.gxTv_SdtDevices_Group_Groupname ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "GroupId" )]
      [  XmlElement( ElementName = "GroupId"   )]
      public short gxTpr_Groupid
      {
         get {
            return gxTv_SdtDevices_Group_Groupid ;
         }

         set {
            gxTv_SdtDevices_Group_Groupid = value;
            gxTv_SdtDevices_Group_Modified = 1;
            SetDirty("Groupid");
         }

      }

      [  SoapElement( ElementName = "GroupName" )]
      [  XmlElement( ElementName = "GroupName"   )]
      public String gxTpr_Groupname
      {
         get {
            return gxTv_SdtDevices_Group_Groupname ;
         }

         set {
            gxTv_SdtDevices_Group_Groupname = value;
            gxTv_SdtDevices_Group_Modified = 1;
            SetDirty("Groupname");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtDevices_Group_Mode ;
         }

         set {
            gxTv_SdtDevices_Group_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtDevices_Group_Mode_SetNull( )
      {
         gxTv_SdtDevices_Group_Mode = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Group_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Modified" )]
      [  XmlElement( ElementName = "Modified"   )]
      public short gxTpr_Modified
      {
         get {
            return gxTv_SdtDevices_Group_Modified ;
         }

         set {
            gxTv_SdtDevices_Group_Modified = value;
            SetDirty("Modified");
         }

      }

      public void gxTv_SdtDevices_Group_Modified_SetNull( )
      {
         gxTv_SdtDevices_Group_Modified = 0;
         return  ;
      }

      public bool gxTv_SdtDevices_Group_Modified_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtDevices_Group_Initialized ;
         }

         set {
            gxTv_SdtDevices_Group_Initialized = value;
            gxTv_SdtDevices_Group_Modified = 1;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtDevices_Group_Initialized_SetNull( )
      {
         gxTv_SdtDevices_Group_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtDevices_Group_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GroupId_Z" )]
      [  XmlElement( ElementName = "GroupId_Z"   )]
      public short gxTpr_Groupid_Z
      {
         get {
            return gxTv_SdtDevices_Group_Groupid_Z ;
         }

         set {
            gxTv_SdtDevices_Group_Groupid_Z = value;
            gxTv_SdtDevices_Group_Modified = 1;
            SetDirty("Groupid_Z");
         }

      }

      public void gxTv_SdtDevices_Group_Groupid_Z_SetNull( )
      {
         gxTv_SdtDevices_Group_Groupid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDevices_Group_Groupid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GroupName_Z" )]
      [  XmlElement( ElementName = "GroupName_Z"   )]
      public String gxTpr_Groupname_Z
      {
         get {
            return gxTv_SdtDevices_Group_Groupname_Z ;
         }

         set {
            gxTv_SdtDevices_Group_Groupname_Z = value;
            gxTv_SdtDevices_Group_Modified = 1;
            SetDirty("Groupname_Z");
         }

      }

      public void gxTv_SdtDevices_Group_Groupname_Z_SetNull( )
      {
         gxTv_SdtDevices_Group_Groupname_Z = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Group_Groupname_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtDevices_Group_Groupname = "";
         gxTv_SdtDevices_Group_Mode = "";
         gxTv_SdtDevices_Group_Groupname_Z = "";
         return  ;
      }

      private short gxTv_SdtDevices_Group_Groupid ;
      private short gxTv_SdtDevices_Group_Modified ;
      private short gxTv_SdtDevices_Group_Initialized ;
      private short gxTv_SdtDevices_Group_Groupid_Z ;
      private String gxTv_SdtDevices_Group_Groupname ;
      private String gxTv_SdtDevices_Group_Mode ;
      private String gxTv_SdtDevices_Group_Groupname_Z ;
   }

   [DataContract(Name = @"Devices.Group", Namespace = "Verbo2")]
   public class SdtDevices_Group_RESTInterface : GxGenericCollectionItem<SdtDevices_Group>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtDevices_Group_RESTInterface( ) : base()
      {
      }

      public SdtDevices_Group_RESTInterface( SdtDevices_Group psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "GroupId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Groupid
      {
         get {
            return sdt.gxTpr_Groupid ;
         }

         set {
            sdt.gxTpr_Groupid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "GroupName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Groupname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Groupname) ;
         }

         set {
            sdt.gxTpr_Groupname = value;
         }

      }

      public SdtDevices_Group sdt
      {
         get {
            return (SdtDevices_Group)Sdt ;
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
            sdt = new SdtDevices_Group() ;
         }
      }

   }

}
