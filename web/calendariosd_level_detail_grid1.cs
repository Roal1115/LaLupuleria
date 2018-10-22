/*
               File: CalendarioSD_Level_Detail_Grid1
        Description: CalendarioSD_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:30.12
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
   public class calendariosd_level_detail_grid1 : GXProcedure
   {
      public calendariosd_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public calendariosd_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_start ,
                           long aP1_count ,
                           int aP2_gxid ,
                           out GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         this.AV6start = aP0_start;
         this.AV7count = aP1_count;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM2RootCol = new GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
      }

      public GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_start ,
                                                                                      long aP1_count ,
                                                                                      int aP2_gxid )
      {
         this.AV6start = aP0_start;
         this.AV7count = aP1_count;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM2RootCol = new GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
         return AV8GXM2RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         calendariosd_level_detail_grid1 objcalendariosd_level_detail_grid1;
         objcalendariosd_level_detail_grid1 = new calendariosd_level_detail_grid1();
         objcalendariosd_level_detail_grid1.AV6start = aP0_start;
         objcalendariosd_level_detail_grid1.AV7count = aP1_count;
         objcalendariosd_level_detail_grid1.AV5gxid = aP2_gxid;
         objcalendariosd_level_detail_grid1.AV8GXM2RootCol = new GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objcalendariosd_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objcalendariosd_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objcalendariosd_level_detail_grid1);
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calendariosd_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV6start);
         GXPagingTo2 = (int)(AV7count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A16CalendarioId = P00002_A16CalendarioId[0];
            A17CalendarioMesId = P00002_A17CalendarioMesId[0];
            A69CalendarioMesNombre = P00002_A69CalendarioMesNombre[0];
            A70CalendarioMesDate = P00002_A70CalendarioMesDate[0];
            A71CalendarioMesDescription = P00002_A71CalendarioMesDescription[0];
            A69CalendarioMesNombre = P00002_A69CalendarioMesNombre[0];
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt = new SdtCalendarioSD_Level_Detail_Grid1Sdt_Item(context);
            AV8GXM2RootCol.Add(AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt, 0);
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt.gxTpr_Calendarioid = A16CalendarioId;
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt.gxTpr_Calendariomesid = A17CalendarioMesId;
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt.gxTpr_Calendariomesnombre = A69CalendarioMesNombre;
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt.gxTpr_Calendariomesdate = A70CalendarioMesDate;
            AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt.gxTpr_Calendariomesdescription = A71CalendarioMesDescription;
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
         P00002_A16CalendarioId = new short[1] ;
         P00002_A17CalendarioMesId = new short[1] ;
         P00002_A69CalendarioMesNombre = new String[] {""} ;
         P00002_A70CalendarioMesDate = new DateTime[] {DateTime.MinValue} ;
         P00002_A71CalendarioMesDescription = new String[] {""} ;
         A69CalendarioMesNombre = "";
         A70CalendarioMesDate = DateTime.MinValue;
         A71CalendarioMesDescription = "";
         AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt = new SdtCalendarioSD_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calendariosd_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A16CalendarioId, P00002_A17CalendarioMesId, P00002_A69CalendarioMesNombre, P00002_A70CalendarioMesDate, P00002_A71CalendarioMesDescription
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A16CalendarioId ;
      private short A17CalendarioMesId ;
      private int AV5gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV6start ;
      private long AV7count ;
      private String scmdbuf ;
      private String A69CalendarioMesNombre ;
      private String A71CalendarioMesDescription ;
      private DateTime A70CalendarioMesDate ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A16CalendarioId ;
      private short[] P00002_A17CalendarioMesId ;
      private String[] P00002_A69CalendarioMesNombre ;
      private DateTime[] P00002_A70CalendarioMesDate ;
      private String[] P00002_A71CalendarioMesDescription ;
      private GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol ;
      private GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> AV8GXM2RootCol ;
      private SdtCalendarioSD_Level_Detail_Grid1Sdt_Item AV9GXM1CalendarioSD_Level_Detail_Grid1Sdt ;
   }

   public class calendariosd_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[CalendarioId], T1.[CalendarioMesId], T2.[CalendarioMesNombre], T1.[CalendarioMesDate], T1.[CalendarioMesDescription] FROM ([CalendarioCalendarioMes] T1 WITH (NOLOCK) INNER JOIN [Calendario] T2 WITH (NOLOCK) ON T2.[CalendarioId] = T1.[CalendarioId]) ORDER BY T1.[CalendarioId], T1.[CalendarioMesId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 250) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.calendariosd_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class calendariosd_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String start ,
                                                                                                  String count ,
                                                                                                  String gxid )
    {
       GxGenericCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("calendariosd_level_detail_grid1") )
          {
             return null ;
          }
          calendariosd_level_detail_grid1 worker = new calendariosd_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtCalendarioSD_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
