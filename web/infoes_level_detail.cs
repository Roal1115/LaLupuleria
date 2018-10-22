/*
               File: InfoEs_Level_Detail
        Description: InfoEs_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:17:40.13
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
   public class infoes_level_detail : GXProcedure
   {
      public infoes_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public infoes_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_Userbusiness ,
                           decimal aP1_Userid ,
                           int aP2_gxid ,
                           out SdtInfoEs_Level_DetailSdt aP3_GXM1InfoEs_Level_DetailSdt )
      {
         this.AV9Userbusiness = aP0_Userbusiness;
         this.AV10Userid = aP1_Userid;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM1InfoEs_Level_DetailSdt = new SdtInfoEs_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1InfoEs_Level_DetailSdt=this.AV8GXM1InfoEs_Level_DetailSdt;
      }

      public SdtInfoEs_Level_DetailSdt executeUdp( decimal aP0_Userbusiness ,
                                                   decimal aP1_Userid ,
                                                   int aP2_gxid )
      {
         this.AV9Userbusiness = aP0_Userbusiness;
         this.AV10Userid = aP1_Userid;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM1InfoEs_Level_DetailSdt = new SdtInfoEs_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1InfoEs_Level_DetailSdt=this.AV8GXM1InfoEs_Level_DetailSdt;
         return AV8GXM1InfoEs_Level_DetailSdt ;
      }

      public void executeSubmit( decimal aP0_Userbusiness ,
                                 decimal aP1_Userid ,
                                 int aP2_gxid ,
                                 out SdtInfoEs_Level_DetailSdt aP3_GXM1InfoEs_Level_DetailSdt )
      {
         infoes_level_detail objinfoes_level_detail;
         objinfoes_level_detail = new infoes_level_detail();
         objinfoes_level_detail.AV9Userbusiness = aP0_Userbusiness;
         objinfoes_level_detail.AV10Userid = aP1_Userid;
         objinfoes_level_detail.AV5gxid = aP2_gxid;
         objinfoes_level_detail.AV8GXM1InfoEs_Level_DetailSdt = new SdtInfoEs_Level_DetailSdt(context) ;
         objinfoes_level_detail.context.SetSubmitInitialConfig(context);
         objinfoes_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objinfoes_level_detail);
         aP3_GXM1InfoEs_Level_DetailSdt=this.AV8GXM1InfoEs_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((infoes_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV5gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids, "true");
         }
         /* Using cursor P00002 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A40000UsersFotografia_GXI = P00002_A40000UsersFotografia_GXI[0];
            A3UsersId = P00002_A3UsersId[0];
            A43UsersNombre = P00002_A43UsersNombre[0];
            A45UsersCURP = P00002_A45UsersCURP[0];
            A44UsersDireccion = P00002_A44UsersDireccion[0];
            A46UsersFotografia = P00002_A46UsersFotografia[0];
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Usersid = A3UsersId;
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Usersfotografia = A46UsersFotografia;
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Usersfotografia_gxi = A40000UsersFotografia_GXI;
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Usersnombre = A43UsersNombre;
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Userscurp = A45UsersCURP;
            AV8GXM1InfoEs_Level_DetailSdt.gxTpr_Usersdireccion = A44UsersDireccion;
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
         Gxids = "";
         Gxwebsession = context.GetSession();
         scmdbuf = "";
         P00002_A40000UsersFotografia_GXI = new String[] {""} ;
         P00002_A3UsersId = new short[1] ;
         P00002_A43UsersNombre = new String[] {""} ;
         P00002_A45UsersCURP = new String[] {""} ;
         P00002_A44UsersDireccion = new String[] {""} ;
         P00002_A46UsersFotografia = new String[] {""} ;
         A40000UsersFotografia_GXI = "";
         A43UsersNombre = "";
         A45UsersCURP = "";
         A44UsersDireccion = "";
         A46UsersFotografia = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.infoes_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A40000UsersFotografia_GXI, P00002_A3UsersId, P00002_A43UsersNombre, P00002_A45UsersCURP, P00002_A44UsersDireccion, P00002_A46UsersFotografia
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3UsersId ;
      private int AV5gxid ;
      private decimal AV9Userbusiness ;
      private decimal AV10Userid ;
      private String Gxids ;
      private String scmdbuf ;
      private String A45UsersCURP ;
      private String A40000UsersFotografia_GXI ;
      private String A43UsersNombre ;
      private String A44UsersDireccion ;
      private String A46UsersFotografia ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00002_A40000UsersFotografia_GXI ;
      private short[] P00002_A3UsersId ;
      private String[] P00002_A43UsersNombre ;
      private String[] P00002_A45UsersCURP ;
      private String[] P00002_A44UsersDireccion ;
      private String[] P00002_A46UsersFotografia ;
      private SdtInfoEs_Level_DetailSdt aP3_GXM1InfoEs_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtInfoEs_Level_DetailSdt AV8GXM1InfoEs_Level_DetailSdt ;
   }

   public class infoes_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT TOP 1 [UsersFotografia_GXI], [UsersId], [UsersNombre], [UsersCURP], [UsersDireccion], [UsersFotografia] FROM [Users] WITH (NOLOCK) ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 18) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(1)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.infoes_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class infoes_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?Userbusiness={Userbusiness}&Userid={Userid}&gxid={gxid}")]
    public SdtInfoEs_Level_DetailSdt_RESTInterface execute( String Userbusiness ,
                                                            String Userid ,
                                                            String gxid )
    {
       SdtInfoEs_Level_DetailSdt_RESTInterface GXM1InfoEs_Level_DetailSdt = new SdtInfoEs_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("infoes_level_detail") )
          {
             return null ;
          }
          infoes_level_detail worker = new infoes_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          decimal gxrUserbusiness ;
          gxrUserbusiness = NumberUtil.Val( (String)(Userbusiness), ".");
          decimal gxrUserid ;
          gxrUserid = NumberUtil.Val( (String)(Userid), ".");
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtInfoEs_Level_DetailSdt gxrGXM1InfoEs_Level_DetailSdt = GXM1InfoEs_Level_DetailSdt.sdt ;
          worker.execute(gxrUserbusiness,gxrUserid,gxrgxid,out gxrGXM1InfoEs_Level_DetailSdt );
          worker.cleanup( );
          GXM1InfoEs_Level_DetailSdt = new SdtInfoEs_Level_DetailSdt_RESTInterface(gxrGXM1InfoEs_Level_DetailSdt) ;
          return GXM1InfoEs_Level_DetailSdt ;
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
