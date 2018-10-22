/*
               File: type_SdtGroup
        Description: Group
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:40.38
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
   [XmlRoot(ElementName = "Group" )]
   [XmlType(TypeName =  "Group" , Namespace = "Verbo2" )]
   [Serializable]
   public class SdtGroup : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGroup( )
      {
      }

      public SdtGroup( IGxContext context )
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

      public void Load( short AV6GroupId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV6GroupId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"GroupId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Group");
         metadata.Set("BT", "Group");
         metadata.Set("PK", "[ \"GroupId\" ]");
         metadata.Set("PKAssigned", "[ \"GroupId\" ]");
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
         state.Add("gxTpr_Groupid_Z");
         state.Add("gxTpr_Groupname_Z");
         state.Add("gxTpr_Groupdescription_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtGroup sdt ;
         sdt = (SdtGroup)(source);
         gxTv_SdtGroup_Groupid = sdt.gxTv_SdtGroup_Groupid ;
         gxTv_SdtGroup_Groupname = sdt.gxTv_SdtGroup_Groupname ;
         gxTv_SdtGroup_Groupdescription = sdt.gxTv_SdtGroup_Groupdescription ;
         gxTv_SdtGroup_Mode = sdt.gxTv_SdtGroup_Mode ;
         gxTv_SdtGroup_Initialized = sdt.gxTv_SdtGroup_Initialized ;
         gxTv_SdtGroup_Groupid_Z = sdt.gxTv_SdtGroup_Groupid_Z ;
         gxTv_SdtGroup_Groupname_Z = sdt.gxTv_SdtGroup_Groupname_Z ;
         gxTv_SdtGroup_Groupdescription_Z = sdt.gxTv_SdtGroup_Groupdescription_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("GroupId", gxTv_SdtGroup_Groupid, false);
         AddObjectProperty("GroupName", gxTv_SdtGroup_Groupname, false);
         AddObjectProperty("GroupDescription", gxTv_SdtGroup_Groupdescription, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtGroup_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtGroup_Initialized, false);
            AddObjectProperty("GroupId_Z", gxTv_SdtGroup_Groupid_Z, false);
            AddObjectProperty("GroupName_Z", gxTv_SdtGroup_Groupname_Z, false);
            AddObjectProperty("GroupDescription_Z", gxTv_SdtGroup_Groupdescription_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtGroup sdt )
      {
         if ( sdt.IsDirty("GroupId") )
         {
            gxTv_SdtGroup_Groupid = sdt.gxTv_SdtGroup_Groupid ;
         }
         if ( sdt.IsDirty("GroupName") )
         {
            gxTv_SdtGroup_Groupname = sdt.gxTv_SdtGroup_Groupname ;
         }
         if ( sdt.IsDirty("GroupDescription") )
         {
            gxTv_SdtGroup_Groupdescription = sdt.gxTv_SdtGroup_Groupdescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "GroupId" )]
      [  XmlElement( ElementName = "GroupId"   )]
      public short gxTpr_Groupid
      {
         get {
            return gxTv_SdtGroup_Groupid ;
         }

         set {
            if ( gxTv_SdtGroup_Groupid != value )
            {
               gxTv_SdtGroup_Mode = "INS";
               this.gxTv_SdtGroup_Groupid_Z_SetNull( );
               this.gxTv_SdtGroup_Groupname_Z_SetNull( );
               this.gxTv_SdtGroup_Groupdescription_Z_SetNull( );
            }
            gxTv_SdtGroup_Groupid = value;
            SetDirty("Groupid");
         }

      }

      [  SoapElement( ElementName = "GroupName" )]
      [  XmlElement( ElementName = "GroupName"   )]
      public String gxTpr_Groupname
      {
         get {
            return gxTv_SdtGroup_Groupname ;
         }

         set {
            gxTv_SdtGroup_Groupname = value;
            SetDirty("Groupname");
         }

      }

      [  SoapElement( ElementName = "GroupDescription" )]
      [  XmlElement( ElementName = "GroupDescription"   )]
      public String gxTpr_Groupdescription
      {
         get {
            return gxTv_SdtGroup_Groupdescription ;
         }

         set {
            gxTv_SdtGroup_Groupdescription = value;
            SetDirty("Groupdescription");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtGroup_Mode ;
         }

         set {
            gxTv_SdtGroup_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtGroup_Mode_SetNull( )
      {
         gxTv_SdtGroup_Mode = "";
         return  ;
      }

      public bool gxTv_SdtGroup_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtGroup_Initialized ;
         }

         set {
            gxTv_SdtGroup_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtGroup_Initialized_SetNull( )
      {
         gxTv_SdtGroup_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtGroup_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GroupId_Z" )]
      [  XmlElement( ElementName = "GroupId_Z"   )]
      public short gxTpr_Groupid_Z
      {
         get {
            return gxTv_SdtGroup_Groupid_Z ;
         }

         set {
            gxTv_SdtGroup_Groupid_Z = value;
            SetDirty("Groupid_Z");
         }

      }

      public void gxTv_SdtGroup_Groupid_Z_SetNull( )
      {
         gxTv_SdtGroup_Groupid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtGroup_Groupid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GroupName_Z" )]
      [  XmlElement( ElementName = "GroupName_Z"   )]
      public String gxTpr_Groupname_Z
      {
         get {
            return gxTv_SdtGroup_Groupname_Z ;
         }

         set {
            gxTv_SdtGroup_Groupname_Z = value;
            SetDirty("Groupname_Z");
         }

      }

      public void gxTv_SdtGroup_Groupname_Z_SetNull( )
      {
         gxTv_SdtGroup_Groupname_Z = "";
         return  ;
      }

      public bool gxTv_SdtGroup_Groupname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GroupDescription_Z" )]
      [  XmlElement( ElementName = "GroupDescription_Z"   )]
      public String gxTpr_Groupdescription_Z
      {
         get {
            return gxTv_SdtGroup_Groupdescription_Z ;
         }

         set {
            gxTv_SdtGroup_Groupdescription_Z = value;
            SetDirty("Groupdescription_Z");
         }

      }

      public void gxTv_SdtGroup_Groupdescription_Z_SetNull( )
      {
         gxTv_SdtGroup_Groupdescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtGroup_Groupdescription_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtGroup_Groupname = "";
         gxTv_SdtGroup_Groupdescription = "";
         gxTv_SdtGroup_Mode = "";
         gxTv_SdtGroup_Groupname_Z = "";
         gxTv_SdtGroup_Groupdescription_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "group", "GeneXus.Programs.group_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtGroup_Groupid ;
      private short gxTv_SdtGroup_Initialized ;
      private short gxTv_SdtGroup_Groupid_Z ;
      private String gxTv_SdtGroup_Groupname ;
      private String gxTv_SdtGroup_Groupdescription ;
      private String gxTv_SdtGroup_Mode ;
      private String gxTv_SdtGroup_Groupname_Z ;
      private String gxTv_SdtGroup_Groupdescription_Z ;
   }

   [DataContract(Name = @"Group", Namespace = "Verbo2")]
   public class SdtGroup_RESTInterface : GxGenericCollectionItem<SdtGroup>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGroup_RESTInterface( ) : base()
      {
      }

      public SdtGroup_RESTInterface( SdtGroup psdt ) : base(psdt)
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

      [DataMember( Name = "GroupDescription" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Groupdescription
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Groupdescription) ;
         }

         set {
            sdt.gxTpr_Groupdescription = value;
         }

      }

      public SdtGroup sdt
      {
         get {
            return (SdtGroup)Sdt ;
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
            sdt = new SdtGroup() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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
