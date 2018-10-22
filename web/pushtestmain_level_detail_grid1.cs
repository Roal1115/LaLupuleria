/*
               File: PushTestMain_Level_Detail_Grid1
        Description: PushTestMain_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:28.18
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
   public class pushtestmain_level_detail_grid1 : GXProcedure
   {
      public pushtestmain_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public pushtestmain_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersBusiness ,
                           String aP1_DeviceId ,
                           long aP2_start ,
                           long aP3_count ,
                           int aP4_gxid ,
                           out GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         this.AV11UsersBusiness = aP0_UsersBusiness;
         this.AV7DeviceId = aP1_DeviceId;
         this.AV15start = aP2_start;
         this.AV16count = aP3_count;
         this.AV12gxid = aP4_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV17GXM2RootCol;
      }

      public GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> executeUdp( String aP0_UsersBusiness ,
                                                                                      String aP1_DeviceId ,
                                                                                      long aP2_start ,
                                                                                      long aP3_count ,
                                                                                      int aP4_gxid )
      {
         this.AV11UsersBusiness = aP0_UsersBusiness;
         this.AV7DeviceId = aP1_DeviceId;
         this.AV15start = aP2_start;
         this.AV16count = aP3_count;
         this.AV12gxid = aP4_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV17GXM2RootCol;
         return AV17GXM2RootCol ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 String aP1_DeviceId ,
                                 long aP2_start ,
                                 long aP3_count ,
                                 int aP4_gxid ,
                                 out GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         pushtestmain_level_detail_grid1 objpushtestmain_level_detail_grid1;
         objpushtestmain_level_detail_grid1 = new pushtestmain_level_detail_grid1();
         objpushtestmain_level_detail_grid1.AV11UsersBusiness = aP0_UsersBusiness;
         objpushtestmain_level_detail_grid1.AV7DeviceId = aP1_DeviceId;
         objpushtestmain_level_detail_grid1.AV15start = aP2_start;
         objpushtestmain_level_detail_grid1.AV16count = aP3_count;
         objpushtestmain_level_detail_grid1.AV12gxid = aP4_gxid;
         objpushtestmain_level_detail_grid1.AV17GXM2RootCol = new GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objpushtestmain_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objpushtestmain_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpushtestmain_level_detail_grid1);
         aP5_GXM2RootCol=this.AV17GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pushtestmain_level_detail_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV12gxid), 8, 0);
         AV8GroupName = Gxwebsession.Get(Gxids+"gxvar_Groupname");
         AV6isSuscribed = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Issuscribed"));
         GXPagingIdx2 = 0;
         GXPagingFrom2 = (int)(AV15start);
         GXPagingTo2 = (int)(AV15start+AV16count);
         /* Using cursor P00002 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GXPagingTo2 == GXPagingFrom2 ) || ( GXPagingIdx2 < GXPagingTo2 ) ) )
         {
            BRK002 = false;
            A6GroupId = P00002_A6GroupId[0];
            A22GroupName = P00002_A22GroupName[0];
            GXPagingIdx2 = (int)(GXPagingIdx2+1);
            if ( GXPagingIdx2 > GXPagingFrom2 )
            {
               AV18GXM1PushTestMain_Level_Detail_Grid1Sdt = new SdtPushTestMain_Level_Detail_Grid1Sdt_Item(context);
               while ( (pr_default.getStatus(0) != 101) && ( P00002_A6GroupId[0] == A6GroupId ) )
               {
                  BRK002 = false;
                  A22GroupName = P00002_A22GroupName[0];
                  AV9GroupId = A6GroupId;
                  AV8GroupName = A22GroupName;
                  AV23GXLvl9 = 0;
                  /* Using cursor P00003 */
                  pr_default.execute(1, new Object[] {AV7DeviceId, A6GroupId});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A1DeviceId = P00003_A1DeviceId[0];
                     AV23GXLvl9 = 1;
                     AV6isSuscribed = true;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(1);
                  if ( AV23GXLvl9 == 0 )
                  {
                     AV6isSuscribed = false;
                  }
                  AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Groupid = A6GroupId;
                  AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Groupname = AV8GroupName;
                  AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Issuscribed = AV6isSuscribed;
                  AV17GXM2RootCol.Add(AV18GXM1PushTestMain_Level_Detail_Grid1Sdt, 0);
                  AV18GXM1PushTestMain_Level_Detail_Grid1Sdt = new SdtPushTestMain_Level_Detail_Grid1Sdt_Item(context);
                  BRK002 = true;
                  pr_default.readNext(0);
               }
               AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Groupid = A6GroupId;
               AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Groupname = AV8GroupName;
               AV18GXM1PushTestMain_Level_Detail_Grid1Sdt.gxTpr_Issuscribed = AV6isSuscribed;
            }
            if ( ! BRK002 )
            {
               BRK002 = true;
               pr_default.readNext(0);
            }
         }
         Gxwebsession.Set(Gxids+"gxvar_Groupname", AV8GroupName);
         Gxwebsession.Set(Gxids+"gxvar_Issuscribed", StringUtil.BoolToStr( AV6isSuscribed));
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
         pr_default.close(0);
      }

      public override void initialize( )
      {
         Gxids = "";
         AV8GroupName = "";
         Gxwebsession = context.GetSession();
         scmdbuf = "";
         P00002_A6GroupId = new short[1] ;
         P00002_A22GroupName = new String[] {""} ;
         A22GroupName = "";
         AV18GXM1PushTestMain_Level_Detail_Grid1Sdt = new SdtPushTestMain_Level_Detail_Grid1Sdt_Item(context);
         P00003_A6GroupId = new short[1] ;
         P00003_A1DeviceId = new String[] {""} ;
         A1DeviceId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pushtestmain_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A6GroupId, P00002_A22GroupName
               }
               , new Object[] {
               P00003_A6GroupId, P00003_A1DeviceId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A6GroupId ;
      private short AV9GroupId ;
      private short AV23GXLvl9 ;
      private int AV12gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int GXPagingIdx2 ;
      private long AV15start ;
      private long AV16count ;
      private String AV11UsersBusiness ;
      private String Gxids ;
      private String AV8GroupName ;
      private String scmdbuf ;
      private String A22GroupName ;
      private bool AV6isSuscribed ;
      private bool BRK002 ;
      private String AV7DeviceId ;
      private String A1DeviceId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A6GroupId ;
      private String[] P00002_A22GroupName ;
      private short[] P00003_A6GroupId ;
      private String[] P00003_A1DeviceId ;
      private GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> AV17GXM2RootCol ;
      private SdtPushTestMain_Level_Detail_Grid1Sdt_Item AV18GXM1PushTestMain_Level_Detail_Grid1Sdt ;
   }

   public class pushtestmain_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
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
          Object[] prmP00003 ;
          prmP00003 = new Object[] {
          new Object[] {"@AV7DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [GroupId], [GroupName] FROM [Group] WITH (NOLOCK) ORDER BY [GroupId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
             ,new CursorDef("P00003", "SELECT [GroupId], [DeviceId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @AV7DeviceId and [GroupId] = @GroupId ORDER BY [DeviceId], [GroupId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.pushtestmain_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class pushtestmain_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsersBusiness={UsersBusiness}&DeviceId={DeviceId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String UsersBusiness ,
                                                                                                  String DeviceId ,
                                                                                                  String start ,
                                                                                                  String count ,
                                                                                                  String gxid )
    {
       GxGenericCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("pushtestmain_level_detail_grid1") )
          {
             return null ;
          }
          pushtestmain_level_detail_grid1 worker = new pushtestmain_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(UsersBusiness,DeviceId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtPushTestMain_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
          return GXM2RootCol ;
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
