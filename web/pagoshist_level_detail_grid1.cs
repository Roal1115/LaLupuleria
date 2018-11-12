/*
               File: PagosHist_Level_Detail_Grid1
        Description: PagosHist_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:32.95
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
   public class pagoshist_level_detail_grid1 : GXProcedure
   {
      public pagoshist_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public pagoshist_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersBusiness ,
                           short aP1_UsersId ,
                           long aP2_start ,
                           long aP3_count ,
                           int aP4_gxid ,
                           out GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         this.AV5UsersBusiness = aP0_UsersBusiness;
         this.AV6UsersId = aP1_UsersId;
         this.AV8start = aP2_start;
         this.AV9count = aP3_count;
         this.AV7gxid = aP4_gxid;
         this.AV10GXM2RootCol = new GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV10GXM2RootCol;
      }

      public GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> executeUdp( String aP0_UsersBusiness ,
                                                                                   short aP1_UsersId ,
                                                                                   long aP2_start ,
                                                                                   long aP3_count ,
                                                                                   int aP4_gxid )
      {
         this.AV5UsersBusiness = aP0_UsersBusiness;
         this.AV6UsersId = aP1_UsersId;
         this.AV8start = aP2_start;
         this.AV9count = aP3_count;
         this.AV7gxid = aP4_gxid;
         this.AV10GXM2RootCol = new GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV10GXM2RootCol;
         return AV10GXM2RootCol ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 short aP1_UsersId ,
                                 long aP2_start ,
                                 long aP3_count ,
                                 int aP4_gxid ,
                                 out GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         pagoshist_level_detail_grid1 objpagoshist_level_detail_grid1;
         objpagoshist_level_detail_grid1 = new pagoshist_level_detail_grid1();
         objpagoshist_level_detail_grid1.AV5UsersBusiness = aP0_UsersBusiness;
         objpagoshist_level_detail_grid1.AV6UsersId = aP1_UsersId;
         objpagoshist_level_detail_grid1.AV8start = aP2_start;
         objpagoshist_level_detail_grid1.AV9count = aP3_count;
         objpagoshist_level_detail_grid1.AV7gxid = aP4_gxid;
         objpagoshist_level_detail_grid1.AV10GXM2RootCol = new GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objpagoshist_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objpagoshist_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpagoshist_level_detail_grid1);
         aP5_GXM2RootCol=this.AV10GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pagoshist_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV8start);
         GXPagingTo2 = (int)(AV9count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {AV6UsersId, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3UsersId = P00002_A3UsersId[0];
            A14DineroId = P00002_A14DineroId[0];
            A64DineroTotal = P00002_A64DineroTotal[0];
            A63DineroAbono = P00002_A63DineroAbono[0];
            A62DineroPago = P00002_A62DineroPago[0];
            A61DineroBalance = (decimal)(A62DineroPago+A63DineroAbono);
            A65DineroNuevo = (decimal)(A64DineroTotal-A61DineroBalance);
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt = new SdtPagosHist_Level_Detail_Grid1Sdt_Item(context);
            AV10GXM2RootCol.Add(AV11GXM1PagosHist_Level_Detail_Grid1Sdt, 0);
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt.gxTpr_Dineroid = A14DineroId;
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt.gxTpr_Dinerototal = A64DineroTotal;
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt.gxTpr_Dinerobalance = A61DineroBalance;
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt.gxTpr_Dineroabono = A63DineroAbono;
            AV11GXM1PagosHist_Level_Detail_Grid1Sdt.gxTpr_Dineronuevo = A65DineroNuevo;
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
         P00002_A3UsersId = new short[1] ;
         P00002_A14DineroId = new short[1] ;
         P00002_A64DineroTotal = new decimal[1] ;
         P00002_A63DineroAbono = new decimal[1] ;
         P00002_A62DineroPago = new decimal[1] ;
         AV11GXM1PagosHist_Level_Detail_Grid1Sdt = new SdtPagosHist_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pagoshist_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A3UsersId, P00002_A14DineroId, P00002_A64DineroTotal, P00002_A63DineroAbono, P00002_A62DineroPago
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV6UsersId ;
      private short A3UsersId ;
      private short A14DineroId ;
      private int AV7gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV8start ;
      private long AV9count ;
      private decimal A64DineroTotal ;
      private decimal A63DineroAbono ;
      private decimal A62DineroPago ;
      private decimal A61DineroBalance ;
      private decimal A65DineroNuevo ;
      private String AV5UsersBusiness ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A3UsersId ;
      private short[] P00002_A14DineroId ;
      private decimal[] P00002_A64DineroTotal ;
      private decimal[] P00002_A63DineroAbono ;
      private decimal[] P00002_A62DineroPago ;
      private GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> aP5_GXM2RootCol ;
      private GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> AV10GXM2RootCol ;
      private SdtPagosHist_Level_Detail_Grid1Sdt_Item AV11GXM1PagosHist_Level_Detail_Grid1Sdt ;
   }

   public class pagoshist_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV6UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [UsersId], [DineroId], [DineroTotal], [DineroAbono], [DineroPago] FROM [Dinero] WITH (NOLOCK) WHERE [UsersId] = @AV6UsersId ORDER BY [UsersId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.pagoshist_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class pagoshist_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsersBusiness={UsersBusiness}&UsersId={UsersId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String UsersBusiness ,
                                                                                               short UsersId ,
                                                                                               String start ,
                                                                                               String count ,
                                                                                               String gxid )
    {
       GxGenericCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("pagoshist_level_detail_grid1") )
          {
             return null ;
          }
          pagoshist_level_detail_grid1 worker = new pagoshist_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(UsersBusiness,UsersId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
