/*
               File: SchoolInfo_Level_Detail
        Description: SchoolInfo_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 19:6:44.38
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
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class schoolinfo_level_detail : GXProcedure
   {
      public schoolinfo_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public schoolinfo_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSchoolInfo_Level_DetailSdt aP1_GXM1SchoolInfo_Level_DetailSdt )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SchoolInfo_Level_DetailSdt = new SdtSchoolInfo_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SchoolInfo_Level_DetailSdt=this.AV6GXM1SchoolInfo_Level_DetailSdt;
      }

      public SdtSchoolInfo_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SchoolInfo_Level_DetailSdt = new SdtSchoolInfo_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SchoolInfo_Level_DetailSdt=this.AV6GXM1SchoolInfo_Level_DetailSdt;
         return AV6GXM1SchoolInfo_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSchoolInfo_Level_DetailSdt aP1_GXM1SchoolInfo_Level_DetailSdt )
      {
         schoolinfo_level_detail objschoolinfo_level_detail;
         objschoolinfo_level_detail = new schoolinfo_level_detail();
         objschoolinfo_level_detail.AV5gxid = aP0_gxid;
         objschoolinfo_level_detail.AV6GXM1SchoolInfo_Level_DetailSdt = new SdtSchoolInfo_Level_DetailSdt(context) ;
         objschoolinfo_level_detail.context.SetSubmitInitialConfig(context);
         objschoolinfo_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objschoolinfo_level_detail);
         aP1_GXM1SchoolInfo_Level_DetailSdt=this.AV6GXM1SchoolInfo_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((schoolinfo_level_detail)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P00002 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A40000SchoolInfoTrsImagen_GXI = P00002_A40000SchoolInfoTrsImagen_GXI[0];
            A74SchoolInfoTrsId = P00002_A74SchoolInfoTrsId[0];
            A75SchoolInfoTrsNombre = P00002_A75SchoolInfoTrsNombre[0];
            A76SchoolInfoTrsSolgan = P00002_A76SchoolInfoTrsSolgan[0];
            A77SchoolInfoTrsAddress = P00002_A77SchoolInfoTrsAddress[0];
            A78SchoolInfoTrsPhone = P00002_A78SchoolInfoTrsPhone[0];
            A79SchoolInfoTrsImagen = P00002_A79SchoolInfoTrsImagen[0];
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsid = A74SchoolInfoTrsId;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsimagen = A79SchoolInfoTrsImagen;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsimagen_gxi = A40000SchoolInfoTrsImagen_GXI;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsnombre = A75SchoolInfoTrsNombre;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrssolgan = A76SchoolInfoTrsSolgan;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsaddress = A77SchoolInfoTrsAddress;
            AV6GXM1SchoolInfo_Level_DetailSdt.gxTpr_Schoolinfotrsphone = A78SchoolInfoTrsPhone;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00002_A40000SchoolInfoTrsImagen_GXI = new String[] {""} ;
         P00002_A74SchoolInfoTrsId = new short[1] ;
         P00002_A75SchoolInfoTrsNombre = new String[] {""} ;
         P00002_A76SchoolInfoTrsSolgan = new String[] {""} ;
         P00002_A77SchoolInfoTrsAddress = new String[] {""} ;
         P00002_A78SchoolInfoTrsPhone = new String[] {""} ;
         P00002_A79SchoolInfoTrsImagen = new String[] {""} ;
         A40000SchoolInfoTrsImagen_GXI = "";
         A75SchoolInfoTrsNombre = "";
         A76SchoolInfoTrsSolgan = "";
         A77SchoolInfoTrsAddress = "";
         A78SchoolInfoTrsPhone = "";
         A79SchoolInfoTrsImagen = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.schoolinfo_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A40000SchoolInfoTrsImagen_GXI, P00002_A74SchoolInfoTrsId, P00002_A75SchoolInfoTrsNombre, P00002_A76SchoolInfoTrsSolgan, P00002_A77SchoolInfoTrsAddress, P00002_A78SchoolInfoTrsPhone, P00002_A79SchoolInfoTrsImagen
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A74SchoolInfoTrsId ;
      private int AV5gxid ;
      private String scmdbuf ;
      private String A75SchoolInfoTrsNombre ;
      private String A76SchoolInfoTrsSolgan ;
      private String A78SchoolInfoTrsPhone ;
      private String A40000SchoolInfoTrsImagen_GXI ;
      private String A77SchoolInfoTrsAddress ;
      private String A79SchoolInfoTrsImagen ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00002_A40000SchoolInfoTrsImagen_GXI ;
      private short[] P00002_A74SchoolInfoTrsId ;
      private String[] P00002_A75SchoolInfoTrsNombre ;
      private String[] P00002_A76SchoolInfoTrsSolgan ;
      private String[] P00002_A77SchoolInfoTrsAddress ;
      private String[] P00002_A78SchoolInfoTrsPhone ;
      private String[] P00002_A79SchoolInfoTrsImagen ;
      private SdtSchoolInfo_Level_DetailSdt aP1_GXM1SchoolInfo_Level_DetailSdt ;
      private SdtSchoolInfo_Level_DetailSdt AV6GXM1SchoolInfo_Level_DetailSdt ;
   }

   public class schoolinfo_level_detail__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT TOP 1 [SchoolInfoTrsImagen_GXI], [SchoolInfoTrsId], [SchoolInfoTrsNombre], [SchoolInfoTrsSolgan], [SchoolInfoTrsAddress], [SchoolInfoTrsPhone], [SchoolInfoTrsImagen] FROM [SchoolInfoTrs] WITH (NOLOCK) ORDER BY [SchoolInfoTrsId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getMultimediaUri(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 200) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(1)) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.schoolinfo_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class schoolinfo_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?gxid={gxid}")]
    public SdtSchoolInfo_Level_DetailSdt_RESTInterface execute( String gxid )
    {
       SdtSchoolInfo_Level_DetailSdt_RESTInterface GXM1SchoolInfo_Level_DetailSdt = new SdtSchoolInfo_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("schoolinfo_level_detail") )
          {
             return null ;
          }
          schoolinfo_level_detail worker = new schoolinfo_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSchoolInfo_Level_DetailSdt gxrGXM1SchoolInfo_Level_DetailSdt = GXM1SchoolInfo_Level_DetailSdt.sdt ;
          worker.execute(gxrgxid,out gxrGXM1SchoolInfo_Level_DetailSdt );
          worker.cleanup( );
          GXM1SchoolInfo_Level_DetailSdt = new SdtSchoolInfo_Level_DetailSdt_RESTInterface(gxrGXM1SchoolInfo_Level_DetailSdt) ;
          return GXM1SchoolInfo_Level_DetailSdt ;
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

 }

}
