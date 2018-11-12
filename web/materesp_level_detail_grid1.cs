/*
               File: MaterEsp_Level_Detail_Grid1
        Description: MaterEsp_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:34.78
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
   public class materesp_level_detail_grid1 : GXProcedure
   {
      public materesp_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public materesp_level_detail_grid1( IGxContext context )
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
                           short aP2_MateriaSel ,
                           long aP3_start ,
                           long aP4_count ,
                           int aP5_gxid ,
                           out GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         this.AV6UsersBusiness = aP0_UsersBusiness;
         this.AV7UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV12start = aP3_start;
         this.AV13count = aP4_count;
         this.AV9gxid = aP5_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV14GXM2RootCol;
      }

      public GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> executeUdp( String aP0_UsersBusiness ,
                                                                                  short aP1_UsersId ,
                                                                                  short aP2_MateriaSel ,
                                                                                  long aP3_start ,
                                                                                  long aP4_count ,
                                                                                  int aP5_gxid )
      {
         this.AV6UsersBusiness = aP0_UsersBusiness;
         this.AV7UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV12start = aP3_start;
         this.AV13count = aP4_count;
         this.AV9gxid = aP5_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV14GXM2RootCol;
         return AV14GXM2RootCol ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 short aP1_UsersId ,
                                 short aP2_MateriaSel ,
                                 long aP3_start ,
                                 long aP4_count ,
                                 int aP5_gxid ,
                                 out GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         materesp_level_detail_grid1 objmateresp_level_detail_grid1;
         objmateresp_level_detail_grid1 = new materesp_level_detail_grid1();
         objmateresp_level_detail_grid1.AV6UsersBusiness = aP0_UsersBusiness;
         objmateresp_level_detail_grid1.AV7UsersId = aP1_UsersId;
         objmateresp_level_detail_grid1.AV5MateriaSel = aP2_MateriaSel;
         objmateresp_level_detail_grid1.AV12start = aP3_start;
         objmateresp_level_detail_grid1.AV13count = aP4_count;
         objmateresp_level_detail_grid1.AV9gxid = aP5_gxid;
         objmateresp_level_detail_grid1.AV14GXM2RootCol = new GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objmateresp_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objmateresp_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmateresp_level_detail_grid1);
         aP6_GXM2RootCol=this.AV14GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((materesp_level_detail_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV9gxid), 8, 0);
         AV8Promedio = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Promedio"), "."));
         GXPagingFrom2 = (int)(AV12start);
         GXPagingTo2 = (int)(AV13count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {AV5MateriaSel, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11MateriasId = P00002_A11MateriasId[0];
            A60Califas8 = P00002_A60Califas8[0];
            A59Califas7 = P00002_A59Califas7[0];
            A58Califas6 = P00002_A58Califas6[0];
            A57Califas5 = P00002_A57Califas5[0];
            A56Califas4 = P00002_A56Califas4[0];
            A55Califas3 = P00002_A55Califas3[0];
            A54Califas2 = P00002_A54Califas2[0];
            A53Califas1 = P00002_A53Califas1[0];
            A13CalifasId = P00002_A13CalifasId[0];
            A48MateriasNombre = P00002_A48MateriasNombre[0];
            A48MateriasNombre = P00002_A48MateriasNombre[0];
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt = new SdtMaterEsp_Level_Detail_Grid1Sdt_Item(context);
            AV14GXM2RootCol.Add(AV15GXM1MaterEsp_Level_Detail_Grid1Sdt, 0);
            AV8Promedio = (short)((A53Califas1+A54Califas2+A55Califas3+A56Califas4+A57Califas5+A58Califas6+A59Califas7+A60Califas8)/ (decimal)(8));
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califasid = A13CalifasId;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Materiasnombre = A48MateriasNombre;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas1 = A53Califas1;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas2 = A54Califas2;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas3 = A55Califas3;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas4 = A56Califas4;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas5 = A57Califas5;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas6 = A58Califas6;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas7 = A59Califas7;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Califas8 = A60Califas8;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Materiasid = A11MateriasId;
            AV15GXM1MaterEsp_Level_Detail_Grid1Sdt.gxTpr_Promedio = AV8Promedio;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Promedio", StringUtil.Str( (decimal)(AV8Promedio), 3, 0));
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
         P00002_A11MateriasId = new short[1] ;
         P00002_A60Califas8 = new short[1] ;
         P00002_A59Califas7 = new short[1] ;
         P00002_A58Califas6 = new short[1] ;
         P00002_A57Califas5 = new short[1] ;
         P00002_A56Califas4 = new short[1] ;
         P00002_A55Califas3 = new short[1] ;
         P00002_A54Califas2 = new short[1] ;
         P00002_A53Califas1 = new short[1] ;
         P00002_A13CalifasId = new short[1] ;
         P00002_A48MateriasNombre = new String[] {""} ;
         A48MateriasNombre = "";
         AV15GXM1MaterEsp_Level_Detail_Grid1Sdt = new SdtMaterEsp_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.materesp_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A11MateriasId, P00002_A60Califas8, P00002_A59Califas7, P00002_A58Califas6, P00002_A57Califas5, P00002_A56Califas4, P00002_A55Califas3, P00002_A54Califas2, P00002_A53Califas1, P00002_A13CalifasId,
               P00002_A48MateriasNombre
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7UsersId ;
      private short AV5MateriaSel ;
      private short AV8Promedio ;
      private short A11MateriasId ;
      private short A60Califas8 ;
      private short A59Califas7 ;
      private short A58Califas6 ;
      private short A57Califas5 ;
      private short A56Califas4 ;
      private short A55Califas3 ;
      private short A54Califas2 ;
      private short A53Califas1 ;
      private short A13CalifasId ;
      private int AV9gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV12start ;
      private long AV13count ;
      private String AV6UsersBusiness ;
      private String Gxids ;
      private String scmdbuf ;
      private String A48MateriasNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A11MateriasId ;
      private short[] P00002_A60Califas8 ;
      private short[] P00002_A59Califas7 ;
      private short[] P00002_A58Califas6 ;
      private short[] P00002_A57Califas5 ;
      private short[] P00002_A56Califas4 ;
      private short[] P00002_A55Califas3 ;
      private short[] P00002_A54Califas2 ;
      private short[] P00002_A53Califas1 ;
      private short[] P00002_A13CalifasId ;
      private String[] P00002_A48MateriasNombre ;
      private GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> AV14GXM2RootCol ;
      private SdtMaterEsp_Level_Detail_Grid1Sdt_Item AV15GXM1MaterEsp_Level_Detail_Grid1Sdt ;
   }

   public class materesp_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV5MateriaSel",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[MateriasId], T1.[Califas8], T1.[Califas7], T1.[Califas6], T1.[Califas5], T1.[Califas4], T1.[Califas3], T1.[Califas2], T1.[Califas1], T1.[CalifasId], T2.[MateriasNombre] FROM ([Califas] T1 WITH (NOLOCK) INNER JOIN [Materias] T2 WITH (NOLOCK) ON T2.[MateriasId] = T1.[MateriasId]) WHERE T1.[MateriasId] = @AV5MateriaSel ORDER BY T1.[MateriasId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 20) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.materesp_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class materesp_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsersBusiness={UsersBusiness}&UsersId={UsersId}&MateriaSel={MateriaSel}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String UsersBusiness ,
                                                                                              short UsersId ,
                                                                                              short MateriaSel ,
                                                                                              String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("materesp_level_detail_grid1") )
          {
             return null ;
          }
          materesp_level_detail_grid1 worker = new materesp_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(UsersBusiness,UsersId,MateriaSel,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtMaterEsp_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
