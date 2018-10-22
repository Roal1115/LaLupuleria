/*
               File: type_SdtDevices
        Description: Devices
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:52.15
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
   [XmlRoot(ElementName = "Devices" )]
   [XmlType(TypeName =  "Devices" , Namespace = "Verbo2" )]
   [Serializable]
   public class SdtDevices : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtDevices( )
      {
      }

      public SdtDevices( IGxContext context )
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

      public void Load( String AV1DeviceId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV1DeviceId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"DeviceId", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Devices");
         metadata.Set("BT", "Devices");
         metadata.Set("PK", "[ \"DeviceId\" ]");
         metadata.Set("Levels", "[ \"Group\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Deviceid_Z");
         state.Add("gxTpr_Devicetype_Z");
         state.Add("gxTpr_Devicetoken_Z");
         state.Add("gxTpr_Devicename_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtDevices sdt ;
         sdt = (SdtDevices)(source);
         gxTv_SdtDevices_Deviceid = sdt.gxTv_SdtDevices_Deviceid ;
         gxTv_SdtDevices_Devicetype = sdt.gxTv_SdtDevices_Devicetype ;
         gxTv_SdtDevices_Devicetoken = sdt.gxTv_SdtDevices_Devicetoken ;
         gxTv_SdtDevices_Devicename = sdt.gxTv_SdtDevices_Devicename ;
         gxTv_SdtDevices_Group = sdt.gxTv_SdtDevices_Group ;
         gxTv_SdtDevices_Mode = sdt.gxTv_SdtDevices_Mode ;
         gxTv_SdtDevices_Initialized = sdt.gxTv_SdtDevices_Initialized ;
         gxTv_SdtDevices_Deviceid_Z = sdt.gxTv_SdtDevices_Deviceid_Z ;
         gxTv_SdtDevices_Devicetype_Z = sdt.gxTv_SdtDevices_Devicetype_Z ;
         gxTv_SdtDevices_Devicetoken_Z = sdt.gxTv_SdtDevices_Devicetoken_Z ;
         gxTv_SdtDevices_Devicename_Z = sdt.gxTv_SdtDevices_Devicename_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("DeviceId", gxTv_SdtDevices_Deviceid, false);
         AddObjectProperty("DeviceType", gxTv_SdtDevices_Devicetype, false);
         AddObjectProperty("DeviceToken", gxTv_SdtDevices_Devicetoken, false);
         AddObjectProperty("DeviceName", gxTv_SdtDevices_Devicename, false);
         if ( gxTv_SdtDevices_Group != null )
         {
            AddObjectProperty("Group", gxTv_SdtDevices_Group, includeState);
         }
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtDevices_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtDevices_Initialized, false);
            AddObjectProperty("DeviceId_Z", gxTv_SdtDevices_Deviceid_Z, false);
            AddObjectProperty("DeviceType_Z", gxTv_SdtDevices_Devicetype_Z, false);
            AddObjectProperty("DeviceToken_Z", gxTv_SdtDevices_Devicetoken_Z, false);
            AddObjectProperty("DeviceName_Z", gxTv_SdtDevices_Devicename_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtDevices sdt )
      {
         if ( sdt.IsDirty("DeviceId") )
         {
            gxTv_SdtDevices_Deviceid = sdt.gxTv_SdtDevices_Deviceid ;
         }
         if ( sdt.IsDirty("DeviceType") )
         {
            gxTv_SdtDevices_Devicetype = sdt.gxTv_SdtDevices_Devicetype ;
         }
         if ( sdt.IsDirty("DeviceToken") )
         {
            gxTv_SdtDevices_Devicetoken = sdt.gxTv_SdtDevices_Devicetoken ;
         }
         if ( sdt.IsDirty("DeviceName") )
         {
            gxTv_SdtDevices_Devicename = sdt.gxTv_SdtDevices_Devicename ;
         }
         if ( gxTv_SdtDevices_Group != null )
         {
            GXBCLevelCollection<SdtDevices_Group> newCollectionGroup = sdt.gxTpr_Group ;
            SdtDevices_Group currItemGroup ;
            SdtDevices_Group newItemGroup ;
            short idx = 1 ;
            while ( idx <= newCollectionGroup.Count )
            {
               newItemGroup = ((SdtDevices_Group)newCollectionGroup.Item(idx));
               currItemGroup = gxTv_SdtDevices_Group.GetByKey(newItemGroup.gxTpr_Groupid);
               if ( StringUtil.StrCmp(currItemGroup.gxTpr_Mode, "UPD") == 0 )
               {
                  currItemGroup.UpdateDirties(newItemGroup);
                  if ( StringUtil.StrCmp(newItemGroup.gxTpr_Mode, "DLT") == 0 )
                  {
                     currItemGroup.gxTpr_Mode = "DLT";
                  }
                  currItemGroup.gxTpr_Modified = 1;
               }
               else
               {
                  gxTv_SdtDevices_Group.Add(newItemGroup, 0);
               }
               idx = (short)(idx+1);
            }
         }
         return  ;
      }

      [  SoapElement( ElementName = "DeviceId" )]
      [  XmlElement( ElementName = "DeviceId"   )]
      public String gxTpr_Deviceid
      {
         get {
            return gxTv_SdtDevices_Deviceid ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtDevices_Deviceid, value) != 0 )
            {
               gxTv_SdtDevices_Mode = "INS";
               this.gxTv_SdtDevices_Deviceid_Z_SetNull( );
               this.gxTv_SdtDevices_Devicetype_Z_SetNull( );
               this.gxTv_SdtDevices_Devicetoken_Z_SetNull( );
               this.gxTv_SdtDevices_Devicename_Z_SetNull( );
               if ( gxTv_SdtDevices_Group != null )
               {
                  GXBCLevelCollection<SdtDevices_Group> collectionGroup = gxTv_SdtDevices_Group ;
                  SdtDevices_Group currItemGroup ;
                  short idx = 1 ;
                  while ( idx <= collectionGroup.Count )
                  {
                     currItemGroup = ((SdtDevices_Group)collectionGroup.Item(idx));
                     currItemGroup.gxTpr_Mode = "INS";
                     currItemGroup.gxTpr_Modified = 1;
                     idx = (short)(idx+1);
                  }
               }
            }
            gxTv_SdtDevices_Deviceid = value;
            SetDirty("Deviceid");
         }

      }

      [  SoapElement( ElementName = "DeviceType" )]
      [  XmlElement( ElementName = "DeviceType"   )]
      public short gxTpr_Devicetype
      {
         get {
            return gxTv_SdtDevices_Devicetype ;
         }

         set {
            gxTv_SdtDevices_Devicetype = value;
            SetDirty("Devicetype");
         }

      }

      [  SoapElement( ElementName = "DeviceToken" )]
      [  XmlElement( ElementName = "DeviceToken"   )]
      public String gxTpr_Devicetoken
      {
         get {
            return gxTv_SdtDevices_Devicetoken ;
         }

         set {
            gxTv_SdtDevices_Devicetoken = value;
            SetDirty("Devicetoken");
         }

      }

      [  SoapElement( ElementName = "DeviceName" )]
      [  XmlElement( ElementName = "DeviceName"   )]
      public String gxTpr_Devicename
      {
         get {
            return gxTv_SdtDevices_Devicename ;
         }

         set {
            gxTv_SdtDevices_Devicename = value;
            SetDirty("Devicename");
         }

      }

      [  SoapElement( ElementName = "Group" )]
      [  XmlArray( ElementName = "Group"  )]
      [  XmlArrayItemAttribute( ElementName= "Devices.Group"  , IsNullable=false)]
      public GXBCLevelCollection<SdtDevices_Group> gxTpr_Group_GXBCLevelCollection
      {
         get {
            if ( gxTv_SdtDevices_Group == null )
            {
               gxTv_SdtDevices_Group = new GXBCLevelCollection<SdtDevices_Group>( context, "Devices.Group", "Verbo2");
            }
            return gxTv_SdtDevices_Group ;
         }

         set {
            if ( gxTv_SdtDevices_Group == null )
            {
               gxTv_SdtDevices_Group = new GXBCLevelCollection<SdtDevices_Group>( context, "Devices.Group", "Verbo2");
            }
            gxTv_SdtDevices_Group = value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public GXBCLevelCollection<SdtDevices_Group> gxTpr_Group
      {
         get {
            if ( gxTv_SdtDevices_Group == null )
            {
               gxTv_SdtDevices_Group = new GXBCLevelCollection<SdtDevices_Group>( context, "Devices.Group", "Verbo2");
            }
            return gxTv_SdtDevices_Group ;
         }

         set {
            gxTv_SdtDevices_Group = value;
            SetDirty("Group");
         }

      }

      public void gxTv_SdtDevices_Group_SetNull( )
      {
         gxTv_SdtDevices_Group = null;
         return  ;
      }

      public bool gxTv_SdtDevices_Group_IsNull( )
      {
         if ( gxTv_SdtDevices_Group == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtDevices_Mode ;
         }

         set {
            gxTv_SdtDevices_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtDevices_Mode_SetNull( )
      {
         gxTv_SdtDevices_Mode = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtDevices_Initialized ;
         }

         set {
            gxTv_SdtDevices_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtDevices_Initialized_SetNull( )
      {
         gxTv_SdtDevices_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtDevices_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DeviceId_Z" )]
      [  XmlElement( ElementName = "DeviceId_Z"   )]
      public String gxTpr_Deviceid_Z
      {
         get {
            return gxTv_SdtDevices_Deviceid_Z ;
         }

         set {
            gxTv_SdtDevices_Deviceid_Z = value;
            SetDirty("Deviceid_Z");
         }

      }

      public void gxTv_SdtDevices_Deviceid_Z_SetNull( )
      {
         gxTv_SdtDevices_Deviceid_Z = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Deviceid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DeviceType_Z" )]
      [  XmlElement( ElementName = "DeviceType_Z"   )]
      public short gxTpr_Devicetype_Z
      {
         get {
            return gxTv_SdtDevices_Devicetype_Z ;
         }

         set {
            gxTv_SdtDevices_Devicetype_Z = value;
            SetDirty("Devicetype_Z");
         }

      }

      public void gxTv_SdtDevices_Devicetype_Z_SetNull( )
      {
         gxTv_SdtDevices_Devicetype_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDevices_Devicetype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DeviceToken_Z" )]
      [  XmlElement( ElementName = "DeviceToken_Z"   )]
      public String gxTpr_Devicetoken_Z
      {
         get {
            return gxTv_SdtDevices_Devicetoken_Z ;
         }

         set {
            gxTv_SdtDevices_Devicetoken_Z = value;
            SetDirty("Devicetoken_Z");
         }

      }

      public void gxTv_SdtDevices_Devicetoken_Z_SetNull( )
      {
         gxTv_SdtDevices_Devicetoken_Z = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Devicetoken_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DeviceName_Z" )]
      [  XmlElement( ElementName = "DeviceName_Z"   )]
      public String gxTpr_Devicename_Z
      {
         get {
            return gxTv_SdtDevices_Devicename_Z ;
         }

         set {
            gxTv_SdtDevices_Devicename_Z = value;
            SetDirty("Devicename_Z");
         }

      }

      public void gxTv_SdtDevices_Devicename_Z_SetNull( )
      {
         gxTv_SdtDevices_Devicename_Z = "";
         return  ;
      }

      public bool gxTv_SdtDevices_Devicename_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtDevices_Deviceid = "";
         gxTv_SdtDevices_Devicetoken = "";
         gxTv_SdtDevices_Devicename = "";
         gxTv_SdtDevices_Mode = "";
         gxTv_SdtDevices_Deviceid_Z = "";
         gxTv_SdtDevices_Devicetoken_Z = "";
         gxTv_SdtDevices_Devicename_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "devices", "GeneXus.Programs.devices_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtDevices_Devicetype ;
      private short gxTv_SdtDevices_Initialized ;
      private short gxTv_SdtDevices_Devicetype_Z ;
      private String gxTv_SdtDevices_Mode ;
      private String gxTv_SdtDevices_Deviceid ;
      private String gxTv_SdtDevices_Devicetoken ;
      private String gxTv_SdtDevices_Devicename ;
      private String gxTv_SdtDevices_Deviceid_Z ;
      private String gxTv_SdtDevices_Devicetoken_Z ;
      private String gxTv_SdtDevices_Devicename_Z ;
      private GXBCLevelCollection<SdtDevices_Group> gxTv_SdtDevices_Group=null ;
   }

   [DataContract(Name = @"Devices", Namespace = "Verbo2")]
   public class SdtDevices_RESTInterface : GxGenericCollectionItem<SdtDevices>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtDevices_RESTInterface( ) : base()
      {
      }

      public SdtDevices_RESTInterface( SdtDevices psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "DeviceId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Deviceid
      {
         get {
            return sdt.gxTpr_Deviceid ;
         }

         set {
            sdt.gxTpr_Deviceid = value;
         }

      }

      [DataMember( Name = "DeviceType" , Order = 1 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Devicetype
      {
         get {
            return sdt.gxTpr_Devicetype ;
         }

         set {
            sdt.gxTpr_Devicetype = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DeviceToken" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Devicetoken
      {
         get {
            return sdt.gxTpr_Devicetoken ;
         }

         set {
            sdt.gxTpr_Devicetoken = value;
         }

      }

      [DataMember( Name = "DeviceName" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Devicename
      {
         get {
            return sdt.gxTpr_Devicename ;
         }

         set {
            sdt.gxTpr_Devicename = value;
         }

      }

      [DataMember( Name = "Group" , Order = 4 )]
      public GxGenericCollection<SdtDevices_Group_RESTInterface> gxTpr_Group
      {
         get {
            return new GxGenericCollection<SdtDevices_Group_RESTInterface>(sdt.gxTpr_Group) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Group);
         }

      }

      public SdtDevices sdt
      {
         get {
            return (SdtDevices)Sdt ;
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
            sdt = new SdtDevices() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 5 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
