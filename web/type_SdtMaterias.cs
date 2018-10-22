/*
               File: type_SdtMaterias
        Description: Materias
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:36.48
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Materias" )]
   [XmlType(TypeName =  "Materias" , Namespace = "Verbo2" )]
   [Serializable]
   public class SdtMaterias : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMaterias( )
      {
      }

      public SdtMaterias( IGxContext context )
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

      public void Load( short AV11MateriasId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV11MateriasId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"MateriasId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Materias");
         metadata.Set("BT", "Materias");
         metadata.Set("PK", "[ \"MateriasId\" ]");
         metadata.Set("PKAssigned", "[ \"MateriasId\" ]");
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
         state.Add("gxTpr_Materiasid_Z");
         state.Add("gxTpr_Materiasnombre_Z");
         state.Add("gxTpr_Materiasdescripcion_Z");
         state.Add("gxTpr_Materiasprofesor_Z");
         state.Add("gxTpr_Materiasprofcorreo_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtMaterias sdt ;
         sdt = (SdtMaterias)(source);
         gxTv_SdtMaterias_Materiasid = sdt.gxTv_SdtMaterias_Materiasid ;
         gxTv_SdtMaterias_Materiasnombre = sdt.gxTv_SdtMaterias_Materiasnombre ;
         gxTv_SdtMaterias_Materiasdescripcion = sdt.gxTv_SdtMaterias_Materiasdescripcion ;
         gxTv_SdtMaterias_Materiasprofesor = sdt.gxTv_SdtMaterias_Materiasprofesor ;
         gxTv_SdtMaterias_Materiasprofcorreo = sdt.gxTv_SdtMaterias_Materiasprofcorreo ;
         gxTv_SdtMaterias_Mode = sdt.gxTv_SdtMaterias_Mode ;
         gxTv_SdtMaterias_Initialized = sdt.gxTv_SdtMaterias_Initialized ;
         gxTv_SdtMaterias_Materiasid_Z = sdt.gxTv_SdtMaterias_Materiasid_Z ;
         gxTv_SdtMaterias_Materiasnombre_Z = sdt.gxTv_SdtMaterias_Materiasnombre_Z ;
         gxTv_SdtMaterias_Materiasdescripcion_Z = sdt.gxTv_SdtMaterias_Materiasdescripcion_Z ;
         gxTv_SdtMaterias_Materiasprofesor_Z = sdt.gxTv_SdtMaterias_Materiasprofesor_Z ;
         gxTv_SdtMaterias_Materiasprofcorreo_Z = sdt.gxTv_SdtMaterias_Materiasprofcorreo_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("MateriasId", gxTv_SdtMaterias_Materiasid, false);
         AddObjectProperty("MateriasNombre", gxTv_SdtMaterias_Materiasnombre, false);
         AddObjectProperty("MateriasDescripcion", gxTv_SdtMaterias_Materiasdescripcion, false);
         AddObjectProperty("MateriasProfesor", gxTv_SdtMaterias_Materiasprofesor, false);
         AddObjectProperty("MateriasProfCorreo", gxTv_SdtMaterias_Materiasprofcorreo, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtMaterias_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtMaterias_Initialized, false);
            AddObjectProperty("MateriasId_Z", gxTv_SdtMaterias_Materiasid_Z, false);
            AddObjectProperty("MateriasNombre_Z", gxTv_SdtMaterias_Materiasnombre_Z, false);
            AddObjectProperty("MateriasDescripcion_Z", gxTv_SdtMaterias_Materiasdescripcion_Z, false);
            AddObjectProperty("MateriasProfesor_Z", gxTv_SdtMaterias_Materiasprofesor_Z, false);
            AddObjectProperty("MateriasProfCorreo_Z", gxTv_SdtMaterias_Materiasprofcorreo_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtMaterias sdt )
      {
         if ( sdt.IsDirty("MateriasId") )
         {
            gxTv_SdtMaterias_Materiasid = sdt.gxTv_SdtMaterias_Materiasid ;
         }
         if ( sdt.IsDirty("MateriasNombre") )
         {
            gxTv_SdtMaterias_Materiasnombre = sdt.gxTv_SdtMaterias_Materiasnombre ;
         }
         if ( sdt.IsDirty("MateriasDescripcion") )
         {
            gxTv_SdtMaterias_Materiasdescripcion = sdt.gxTv_SdtMaterias_Materiasdescripcion ;
         }
         if ( sdt.IsDirty("MateriasProfesor") )
         {
            gxTv_SdtMaterias_Materiasprofesor = sdt.gxTv_SdtMaterias_Materiasprofesor ;
         }
         if ( sdt.IsDirty("MateriasProfCorreo") )
         {
            gxTv_SdtMaterias_Materiasprofcorreo = sdt.gxTv_SdtMaterias_Materiasprofcorreo ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "MateriasId" )]
      [  XmlElement( ElementName = "MateriasId"   )]
      public short gxTpr_Materiasid
      {
         get {
            return gxTv_SdtMaterias_Materiasid ;
         }

         set {
            if ( gxTv_SdtMaterias_Materiasid != value )
            {
               gxTv_SdtMaterias_Mode = "INS";
               this.gxTv_SdtMaterias_Materiasid_Z_SetNull( );
               this.gxTv_SdtMaterias_Materiasnombre_Z_SetNull( );
               this.gxTv_SdtMaterias_Materiasdescripcion_Z_SetNull( );
               this.gxTv_SdtMaterias_Materiasprofesor_Z_SetNull( );
               this.gxTv_SdtMaterias_Materiasprofcorreo_Z_SetNull( );
            }
            gxTv_SdtMaterias_Materiasid = value;
            SetDirty("Materiasid");
         }

      }

      [  SoapElement( ElementName = "MateriasNombre" )]
      [  XmlElement( ElementName = "MateriasNombre"   )]
      public String gxTpr_Materiasnombre
      {
         get {
            return gxTv_SdtMaterias_Materiasnombre ;
         }

         set {
            gxTv_SdtMaterias_Materiasnombre = value;
            SetDirty("Materiasnombre");
         }

      }

      [  SoapElement( ElementName = "MateriasDescripcion" )]
      [  XmlElement( ElementName = "MateriasDescripcion"   )]
      public String gxTpr_Materiasdescripcion
      {
         get {
            return gxTv_SdtMaterias_Materiasdescripcion ;
         }

         set {
            gxTv_SdtMaterias_Materiasdescripcion = value;
            SetDirty("Materiasdescripcion");
         }

      }

      [  SoapElement( ElementName = "MateriasProfesor" )]
      [  XmlElement( ElementName = "MateriasProfesor"   )]
      public String gxTpr_Materiasprofesor
      {
         get {
            return gxTv_SdtMaterias_Materiasprofesor ;
         }

         set {
            gxTv_SdtMaterias_Materiasprofesor = value;
            SetDirty("Materiasprofesor");
         }

      }

      [  SoapElement( ElementName = "MateriasProfCorreo" )]
      [  XmlElement( ElementName = "MateriasProfCorreo"   )]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return gxTv_SdtMaterias_Materiasprofcorreo ;
         }

         set {
            gxTv_SdtMaterias_Materiasprofcorreo = value;
            SetDirty("Materiasprofcorreo");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtMaterias_Mode ;
         }

         set {
            gxTv_SdtMaterias_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtMaterias_Mode_SetNull( )
      {
         gxTv_SdtMaterias_Mode = "";
         return  ;
      }

      public bool gxTv_SdtMaterias_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtMaterias_Initialized ;
         }

         set {
            gxTv_SdtMaterias_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtMaterias_Initialized_SetNull( )
      {
         gxTv_SdtMaterias_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtMaterias_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "MateriasId_Z" )]
      [  XmlElement( ElementName = "MateriasId_Z"   )]
      public short gxTpr_Materiasid_Z
      {
         get {
            return gxTv_SdtMaterias_Materiasid_Z ;
         }

         set {
            gxTv_SdtMaterias_Materiasid_Z = value;
            SetDirty("Materiasid_Z");
         }

      }

      public void gxTv_SdtMaterias_Materiasid_Z_SetNull( )
      {
         gxTv_SdtMaterias_Materiasid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtMaterias_Materiasid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "MateriasNombre_Z" )]
      [  XmlElement( ElementName = "MateriasNombre_Z"   )]
      public String gxTpr_Materiasnombre_Z
      {
         get {
            return gxTv_SdtMaterias_Materiasnombre_Z ;
         }

         set {
            gxTv_SdtMaterias_Materiasnombre_Z = value;
            SetDirty("Materiasnombre_Z");
         }

      }

      public void gxTv_SdtMaterias_Materiasnombre_Z_SetNull( )
      {
         gxTv_SdtMaterias_Materiasnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtMaterias_Materiasnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "MateriasDescripcion_Z" )]
      [  XmlElement( ElementName = "MateriasDescripcion_Z"   )]
      public String gxTpr_Materiasdescripcion_Z
      {
         get {
            return gxTv_SdtMaterias_Materiasdescripcion_Z ;
         }

         set {
            gxTv_SdtMaterias_Materiasdescripcion_Z = value;
            SetDirty("Materiasdescripcion_Z");
         }

      }

      public void gxTv_SdtMaterias_Materiasdescripcion_Z_SetNull( )
      {
         gxTv_SdtMaterias_Materiasdescripcion_Z = "";
         return  ;
      }

      public bool gxTv_SdtMaterias_Materiasdescripcion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "MateriasProfesor_Z" )]
      [  XmlElement( ElementName = "MateriasProfesor_Z"   )]
      public String gxTpr_Materiasprofesor_Z
      {
         get {
            return gxTv_SdtMaterias_Materiasprofesor_Z ;
         }

         set {
            gxTv_SdtMaterias_Materiasprofesor_Z = value;
            SetDirty("Materiasprofesor_Z");
         }

      }

      public void gxTv_SdtMaterias_Materiasprofesor_Z_SetNull( )
      {
         gxTv_SdtMaterias_Materiasprofesor_Z = "";
         return  ;
      }

      public bool gxTv_SdtMaterias_Materiasprofesor_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "MateriasProfCorreo_Z" )]
      [  XmlElement( ElementName = "MateriasProfCorreo_Z"   )]
      public String gxTpr_Materiasprofcorreo_Z
      {
         get {
            return gxTv_SdtMaterias_Materiasprofcorreo_Z ;
         }

         set {
            gxTv_SdtMaterias_Materiasprofcorreo_Z = value;
            SetDirty("Materiasprofcorreo_Z");
         }

      }

      public void gxTv_SdtMaterias_Materiasprofcorreo_Z_SetNull( )
      {
         gxTv_SdtMaterias_Materiasprofcorreo_Z = "";
         return  ;
      }

      public bool gxTv_SdtMaterias_Materiasprofcorreo_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtMaterias_Materiasnombre = "";
         gxTv_SdtMaterias_Materiasdescripcion = "";
         gxTv_SdtMaterias_Materiasprofesor = "";
         gxTv_SdtMaterias_Materiasprofcorreo = "";
         gxTv_SdtMaterias_Mode = "";
         gxTv_SdtMaterias_Materiasnombre_Z = "";
         gxTv_SdtMaterias_Materiasdescripcion_Z = "";
         gxTv_SdtMaterias_Materiasprofesor_Z = "";
         gxTv_SdtMaterias_Materiasprofcorreo_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "materias", "GeneXus.Programs.materias_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtMaterias_Materiasid ;
      private short gxTv_SdtMaterias_Initialized ;
      private short gxTv_SdtMaterias_Materiasid_Z ;
      private String gxTv_SdtMaterias_Materiasnombre ;
      private String gxTv_SdtMaterias_Materiasdescripcion ;
      private String gxTv_SdtMaterias_Materiasprofesor ;
      private String gxTv_SdtMaterias_Mode ;
      private String gxTv_SdtMaterias_Materiasnombre_Z ;
      private String gxTv_SdtMaterias_Materiasdescripcion_Z ;
      private String gxTv_SdtMaterias_Materiasprofesor_Z ;
      private String gxTv_SdtMaterias_Materiasprofcorreo ;
      private String gxTv_SdtMaterias_Materiasprofcorreo_Z ;
   }

   [DataContract(Name = @"Materias", Namespace = "Verbo2")]
   public class SdtMaterias_RESTInterface : GxGenericCollectionItem<SdtMaterias>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMaterias_RESTInterface( ) : base()
      {
      }

      public SdtMaterias_RESTInterface( SdtMaterias psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "MateriasId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Materiasid
      {
         get {
            return sdt.gxTpr_Materiasid ;
         }

         set {
            sdt.gxTpr_Materiasid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "MateriasNombre" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Materiasnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasnombre) ;
         }

         set {
            sdt.gxTpr_Materiasnombre = value;
         }

      }

      [DataMember( Name = "MateriasDescripcion" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Materiasdescripcion
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasdescripcion) ;
         }

         set {
            sdt.gxTpr_Materiasdescripcion = value;
         }

      }

      [DataMember( Name = "MateriasProfesor" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Materiasprofesor
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasprofesor) ;
         }

         set {
            sdt.gxTpr_Materiasprofesor = value;
         }

      }

      [DataMember( Name = "MateriasProfCorreo" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Materiasprofcorreo
      {
         get {
            return sdt.gxTpr_Materiasprofcorreo ;
         }

         set {
            sdt.gxTpr_Materiasprofcorreo = value;
         }

      }

      public SdtMaterias sdt
      {
         get {
            return (SdtMaterias)Sdt ;
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
            sdt = new SdtMaterias() ;
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

   [DataContract(Name = @"Materias", Namespace = "Verbo2")]
   public class SdtMaterias_RESTLInterface : GxGenericCollectionItem<SdtMaterias>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMaterias_RESTLInterface( ) : base()
      {
      }

      public SdtMaterias_RESTLInterface( SdtMaterias psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "MateriasNombre" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Materiasnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Materiasnombre) ;
         }

         set {
            sdt.gxTpr_Materiasnombre = value;
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtMaterias sdt
      {
         get {
            return (SdtMaterias)Sdt ;
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
            sdt = new SdtMaterias() ;
         }
      }

   }

}
