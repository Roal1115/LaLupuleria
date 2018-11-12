/*
               File: Mensajes_Level_Detail_Grid1
        Description: Mensajes_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:11:49.11
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
   public class mensajes_level_detail_grid1 : GXProcedure
   {
      public mensajes_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public mensajes_level_detail_grid1( IGxContext context )
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
                           out GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         this.AV8start = aP0_start;
         this.AV9count = aP1_count;
         this.AV7gxid = aP2_gxid;
         this.AV10GXM2RootCol = new GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV10GXM2RootCol;
      }

      public GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_start ,
                                                                                  long aP1_count ,
                                                                                  int aP2_gxid )
      {
         this.AV8start = aP0_start;
         this.AV9count = aP1_count;
         this.AV7gxid = aP2_gxid;
         this.AV10GXM2RootCol = new GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV10GXM2RootCol;
         return AV10GXM2RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         mensajes_level_detail_grid1 objmensajes_level_detail_grid1;
         objmensajes_level_detail_grid1 = new mensajes_level_detail_grid1();
         objmensajes_level_detail_grid1.AV8start = aP0_start;
         objmensajes_level_detail_grid1.AV9count = aP1_count;
         objmensajes_level_detail_grid1.AV7gxid = aP2_gxid;
         objmensajes_level_detail_grid1.AV10GXM2RootCol = new GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objmensajes_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objmensajes_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmensajes_level_detail_grid1);
         aP3_GXM2RootCol=this.AV10GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((mensajes_level_detail_grid1)stateInfo).executePrivate();
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
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11MateriasId = P00002_A11MateriasId[0];
            A52MateriasProfCorreo = P00002_A52MateriasProfCorreo[0];
            AV11GXM1Mensajes_Level_Detail_Grid1Sdt = new SdtMensajes_Level_Detail_Grid1Sdt_Item(context);
            AV10GXM2RootCol.Add(AV11GXM1Mensajes_Level_Detail_Grid1Sdt, 0);
            AV11GXM1Mensajes_Level_Detail_Grid1Sdt.gxTpr_Materiasid = A11MateriasId;
            AV11GXM1Mensajes_Level_Detail_Grid1Sdt.gxTpr_Materiasprofcorreo = A52MateriasProfCorreo;
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
         P00002_A11MateriasId = new short[1] ;
         P00002_A52MateriasProfCorreo = new String[] {""} ;
         A52MateriasProfCorreo = "";
         AV11GXM1Mensajes_Level_Detail_Grid1Sdt = new SdtMensajes_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.mensajes_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A11MateriasId, P00002_A52MateriasProfCorreo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A11MateriasId ;
      private int AV7gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV8start ;
      private long AV9count ;
      private String scmdbuf ;
      private String A52MateriasProfCorreo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A11MateriasId ;
      private String[] P00002_A52MateriasProfCorreo ;
      private GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol ;
      private GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> AV10GXM2RootCol ;
      private SdtMensajes_Level_Detail_Grid1Sdt_Item AV11GXM1Mensajes_Level_Detail_Grid1Sdt ;
   }

   public class mensajes_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT [MateriasId], [MateriasProfCorreo] FROM [Materias] WITH (NOLOCK) ORDER BY [MateriasId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.mensajes_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class mensajes_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("mensajes_level_detail_grid1") )
          {
             return null ;
          }
          mensajes_level_detail_grid1 worker = new mensajes_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtMensajes_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
