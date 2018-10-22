/*
               File: Pago
        Description: Pago
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:48.7
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
   public class pago : GXProcedure
   {
      public pago( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public pago( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_UsersId ,
                           ref decimal aP1_pago ,
                           ref String aP2_BalanceName )
      {
         this.AV13UsersId = aP0_UsersId;
         this.AV12pago = aP1_pago;
         this.AV9BalanceName = aP2_BalanceName;
         initialize();
         executePrivate();
         aP0_UsersId=this.AV13UsersId;
         aP1_pago=this.AV12pago;
         aP2_BalanceName=this.AV9BalanceName;
      }

      public String executeUdp( ref short aP0_UsersId ,
                                ref decimal aP1_pago )
      {
         this.AV13UsersId = aP0_UsersId;
         this.AV12pago = aP1_pago;
         this.AV9BalanceName = aP2_BalanceName;
         initialize();
         executePrivate();
         aP0_UsersId=this.AV13UsersId;
         aP1_pago=this.AV12pago;
         aP2_BalanceName=this.AV9BalanceName;
         return AV9BalanceName ;
      }

      public void executeSubmit( ref short aP0_UsersId ,
                                 ref decimal aP1_pago ,
                                 ref String aP2_BalanceName )
      {
         pago objpago;
         objpago = new pago();
         objpago.AV13UsersId = aP0_UsersId;
         objpago.AV12pago = aP1_pago;
         objpago.AV9BalanceName = aP2_BalanceName;
         objpago.context.SetSubmitInitialConfig(context);
         objpago.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpago);
         aP0_UsersId=this.AV13UsersId;
         aP1_pago=this.AV12pago;
         aP2_BalanceName=this.AV9BalanceName;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pago)stateInfo).executePrivate();
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
         /* Using cursor P000M2 */
         pr_default.execute(0, new Object[] {AV13UsersId, AV9BalanceName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7BalanceId = P000M2_A7BalanceId[0];
            A29BalanceName = P000M2_A29BalanceName[0];
            A3UsersId = P000M2_A3UsersId[0];
            /* Optimized group. */
            /* Using cursor P000M3 */
            pr_default.execute(1, new Object[] {A7BalanceId});
            cV10counter = P000M3_AV10counter[0];
            pr_default.close(1);
            AV10counter = (short)(AV10counter+cV10counter*1);
            /* End optimized group. */
            AV10counter = (short)(AV10counter+1);
            /* Using cursor P000M4 */
            pr_default.execute(2, new Object[] {A7BalanceId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A26HistoryType = P000M4_A26HistoryType[0];
               A25HistoryDate = P000M4_A25HistoryDate[0];
               A33HistoryAbono = P000M4_A33HistoryAbono[0];
               A8HistoryId = P000M4_A8HistoryId[0];
               /*
                  INSERT RECORD ON TABLE BalanceHistory

               */
               W8HistoryId = A8HistoryId;
               W25HistoryDate = A25HistoryDate;
               W33HistoryAbono = A33HistoryAbono;
               W26HistoryType = A26HistoryType;
               A8HistoryId = AV10counter;
               A25HistoryDate = Gx_date;
               A33HistoryAbono = AV12pago;
               A26HistoryType = 1;
               /* Using cursor P000M5 */
               pr_default.execute(3, new Object[] {A7BalanceId, A8HistoryId, A33HistoryAbono, A25HistoryDate, A26HistoryType});
               pr_default.close(3);
               dsDefault.SmartCacheProvider.SetUpdated("BalanceHistory") ;
               if ( (pr_default.getStatus(3) == 1) )
               {
                  context.Gx_err = 1;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
               }
               else
               {
                  context.Gx_err = 0;
                  Gx_emsg = "";
               }
               A8HistoryId = W8HistoryId;
               A25HistoryDate = W25HistoryDate;
               A33HistoryAbono = W33HistoryAbono;
               A26HistoryType = W26HistoryType;
               /* End Insert */
               pr_default.readNext(2);
            }
            pr_default.close(2);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV10counter = 1;
         /* Using cursor P000M6 */
         pr_default.execute(4, new Object[] {AV13UsersId});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A9MonederoElectronicoId = P000M6_A9MonederoElectronicoId[0];
            A3UsersId = P000M6_A3UsersId[0];
            /* Optimized group. */
            /* Using cursor P000M7 */
            pr_default.execute(5, new Object[] {A9MonederoElectronicoId});
            cV10counter = P000M7_AV10counter[0];
            pr_default.close(5);
            AV10counter = (short)(AV10counter+cV10counter*1);
            /* End optimized group. */
            /* Using cursor P000M8 */
            pr_default.execute(6, new Object[] {A9MonederoElectronicoId});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A39MovimientosTipoMonto = P000M8_A39MovimientosTipoMonto[0];
               A38MovimientosCantidad = P000M8_A38MovimientosCantidad[0];
               A41MovimientosFecha = P000M8_A41MovimientosFecha[0];
               A10MovimientosId = P000M8_A10MovimientosId[0];
               /*
                  INSERT RECORD ON TABLE MonederoElectronicoMovimientos

               */
               W10MovimientosId = A10MovimientosId;
               W41MovimientosFecha = A41MovimientosFecha;
               W38MovimientosCantidad = A38MovimientosCantidad;
               W39MovimientosTipoMonto = A39MovimientosTipoMonto;
               A10MovimientosId = AV10counter;
               A41MovimientosFecha = Gx_date;
               A38MovimientosCantidad = AV12pago;
               A39MovimientosTipoMonto = 1;
               /* Using cursor P000M9 */
               pr_default.execute(7, new Object[] {A9MonederoElectronicoId, A10MovimientosId, A41MovimientosFecha, A38MovimientosCantidad, A39MovimientosTipoMonto});
               pr_default.close(7);
               dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronicoMovimientos") ;
               if ( (pr_default.getStatus(7) == 1) )
               {
                  context.Gx_err = 1;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
               }
               else
               {
                  context.Gx_err = 0;
                  Gx_emsg = "";
               }
               A10MovimientosId = W10MovimientosId;
               A41MovimientosFecha = W41MovimientosFecha;
               A38MovimientosCantidad = W38MovimientosCantidad;
               A39MovimientosTipoMonto = W39MovimientosTipoMonto;
               /* End Insert */
               pr_default.readNext(6);
            }
            pr_default.close(6);
            pr_default.readNext(4);
         }
         pr_default.close(4);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("pago",pr_default);
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
         P000M2_A7BalanceId = new short[1] ;
         P000M2_A29BalanceName = new String[] {""} ;
         P000M2_A3UsersId = new short[1] ;
         A29BalanceName = "";
         P000M3_AV10counter = new short[1] ;
         P000M4_A7BalanceId = new short[1] ;
         P000M4_A26HistoryType = new short[1] ;
         P000M4_A25HistoryDate = new DateTime[] {DateTime.MinValue} ;
         P000M4_A33HistoryAbono = new decimal[1] ;
         P000M4_A8HistoryId = new short[1] ;
         A25HistoryDate = DateTime.MinValue;
         W25HistoryDate = DateTime.MinValue;
         Gx_date = DateTime.MinValue;
         Gx_emsg = "";
         P000M6_A9MonederoElectronicoId = new short[1] ;
         P000M6_A3UsersId = new short[1] ;
         P000M7_AV10counter = new short[1] ;
         P000M8_A9MonederoElectronicoId = new short[1] ;
         P000M8_A39MovimientosTipoMonto = new short[1] ;
         P000M8_A38MovimientosCantidad = new decimal[1] ;
         P000M8_A41MovimientosFecha = new DateTime[] {DateTime.MinValue} ;
         P000M8_A10MovimientosId = new short[1] ;
         A41MovimientosFecha = DateTime.MinValue;
         W41MovimientosFecha = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pago__default(),
            new Object[][] {
                new Object[] {
               P000M2_A7BalanceId, P000M2_A29BalanceName, P000M2_A3UsersId
               }
               , new Object[] {
               P000M3_AV10counter
               }
               , new Object[] {
               P000M4_A7BalanceId, P000M4_A26HistoryType, P000M4_A25HistoryDate, P000M4_A33HistoryAbono, P000M4_A8HistoryId
               }
               , new Object[] {
               }
               , new Object[] {
               P000M6_A9MonederoElectronicoId, P000M6_A3UsersId
               }
               , new Object[] {
               P000M7_AV10counter
               }
               , new Object[] {
               P000M8_A9MonederoElectronicoId, P000M8_A39MovimientosTipoMonto, P000M8_A38MovimientosCantidad, P000M8_A41MovimientosFecha, P000M8_A10MovimientosId
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short AV13UsersId ;
      private short A7BalanceId ;
      private short A3UsersId ;
      private short cV10counter ;
      private short AV10counter ;
      private short A26HistoryType ;
      private short A8HistoryId ;
      private short W8HistoryId ;
      private short W26HistoryType ;
      private short A9MonederoElectronicoId ;
      private short A39MovimientosTipoMonto ;
      private short A10MovimientosId ;
      private short W10MovimientosId ;
      private short W39MovimientosTipoMonto ;
      private int GX_INS5 ;
      private int GX_INS7 ;
      private decimal AV12pago ;
      private decimal A33HistoryAbono ;
      private decimal W33HistoryAbono ;
      private decimal A38MovimientosCantidad ;
      private decimal W38MovimientosCantidad ;
      private String AV9BalanceName ;
      private String scmdbuf ;
      private String A29BalanceName ;
      private String Gx_emsg ;
      private DateTime A25HistoryDate ;
      private DateTime W25HistoryDate ;
      private DateTime Gx_date ;
      private DateTime A41MovimientosFecha ;
      private DateTime W41MovimientosFecha ;
      private IGxDataStore dsDefault ;
      private short aP0_UsersId ;
      private decimal aP1_pago ;
      private String aP2_BalanceName ;
      private IDataStoreProvider pr_default ;
      private short[] P000M2_A7BalanceId ;
      private String[] P000M2_A29BalanceName ;
      private short[] P000M2_A3UsersId ;
      private short[] P000M3_AV10counter ;
      private short[] P000M4_A7BalanceId ;
      private short[] P000M4_A26HistoryType ;
      private DateTime[] P000M4_A25HistoryDate ;
      private decimal[] P000M4_A33HistoryAbono ;
      private short[] P000M4_A8HistoryId ;
      private short[] P000M6_A9MonederoElectronicoId ;
      private short[] P000M6_A3UsersId ;
      private short[] P000M7_AV10counter ;
      private short[] P000M8_A9MonederoElectronicoId ;
      private short[] P000M8_A39MovimientosTipoMonto ;
      private decimal[] P000M8_A38MovimientosCantidad ;
      private DateTime[] P000M8_A41MovimientosFecha ;
      private short[] P000M8_A10MovimientosId ;
   }

   public class pago__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000M2 ;
          prmP000M2 = new Object[] {
          new Object[] {"@AV13UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9BalanceName",SqlDbType.Char,20,0}
          } ;
          Object[] prmP000M3 ;
          prmP000M3 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M4 ;
          prmP000M4 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M5 ;
          prmP000M5 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryAbono",SqlDbType.Decimal,10,2} ,
          new Object[] {"@HistoryDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@HistoryType",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M6 ;
          prmP000M6 = new Object[] {
          new Object[] {"@AV13UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M7 ;
          prmP000M7 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M8 ;
          prmP000M8 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000M9 ;
          prmP000M9 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientosCantidad",SqlDbType.Decimal,10,2} ,
          new Object[] {"@MovimientosTipoMonto",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000M2", "SELECT [BalanceId], [BalanceName], [UsersId] FROM [Balance] WITH (NOLOCK) WHERE ([UsersId] = @AV13UsersId) AND (@AV9BalanceName = RTRIM(LTRIM([BalanceName]))) ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M2,100,0,true,false )
             ,new CursorDef("P000M3", "SELECT COUNT(*) FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M3,1,0,true,false )
             ,new CursorDef("P000M4", "SELECT [BalanceId], [HistoryType], [HistoryDate], [HistoryAbono], [HistoryId] FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId ORDER BY [BalanceId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M4,100,0,true,false )
             ,new CursorDef("P000M5", "INSERT INTO [BalanceHistory]([BalanceId], [HistoryId], [HistoryAbono], [HistoryDate], [HistoryType]) VALUES(@BalanceId, @HistoryId, @HistoryAbono, @HistoryDate, @HistoryType)", GxErrorMask.GX_NOMASK,prmP000M5)
             ,new CursorDef("P000M6", "SELECT [MonederoElectronicoId], [UsersId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE [UsersId] = @AV13UsersId ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M6,100,0,true,false )
             ,new CursorDef("P000M7", "SELECT COUNT(*) FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M7,1,0,true,false )
             ,new CursorDef("P000M8", "SELECT [MonederoElectronicoId], [MovimientosTipoMonto], [MovimientosCantidad], [MovimientosFecha], [MovimientosId] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId ORDER BY [MonederoElectronicoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M8,100,0,true,false )
             ,new CursorDef("P000M9", "INSERT INTO [MonederoElectronicoMovimientos]([MonederoElectronicoId], [MovimientosId], [MovimientosFecha], [MovimientosCantidad], [MovimientosTipoMonto]) VALUES(@MonederoElectronicoId, @MovimientosId, @MovimientosFecha, @MovimientosCantidad, @MovimientosTipoMonto)", GxErrorMask.GX_NOMASK,prmP000M9)
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.pago_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class pago_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( ref short UsersId ,
                         ref String pago ,
                         ref String BalanceName )
    {
       try
       {
          if ( ! ProcessHeaders("pago") )
          {
             return  ;
          }
          pago worker = new pago(context) ;
          worker.IsMain = RunAsMain ;
          decimal gxrpago ;
          gxrpago = NumberUtil.Val( (String)(pago), ".");
          worker.execute(ref UsersId,ref gxrpago,ref BalanceName );
          worker.cleanup( );
          pago = StringUtil.LTrim( StringUtil.Str( gxrpago, 10, 2)) ;
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
