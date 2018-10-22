/*
               File: Materia_Level_Detail_Grid1
        Description: Materia_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:29.77
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
   public class materia_level_detail_grid1 : GXProcedure
   {
      public materia_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public materia_level_detail_grid1( IGxContext context )
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
                           out GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         this.AV7UsersBusiness = aP0_UsersBusiness;
         this.AV6UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV9start = aP3_start;
         this.AV10count = aP4_count;
         this.AV8gxid = aP5_gxid;
         this.AV11GXM2RootCol = new GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV11GXM2RootCol;
      }

      public GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> executeUdp( String aP0_UsersBusiness ,
                                                                                 short aP1_UsersId ,
                                                                                 short aP2_MateriaSel ,
                                                                                 long aP3_start ,
                                                                                 long aP4_count ,
                                                                                 int aP5_gxid )
      {
         this.AV7UsersBusiness = aP0_UsersBusiness;
         this.AV6UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV9start = aP3_start;
         this.AV10count = aP4_count;
         this.AV8gxid = aP5_gxid;
         this.AV11GXM2RootCol = new GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV11GXM2RootCol;
         return AV11GXM2RootCol ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 short aP1_UsersId ,
                                 short aP2_MateriaSel ,
                                 long aP3_start ,
                                 long aP4_count ,
                                 int aP5_gxid ,
                                 out GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         materia_level_detail_grid1 objmateria_level_detail_grid1;
         objmateria_level_detail_grid1 = new materia_level_detail_grid1();
         objmateria_level_detail_grid1.AV7UsersBusiness = aP0_UsersBusiness;
         objmateria_level_detail_grid1.AV6UsersId = aP1_UsersId;
         objmateria_level_detail_grid1.AV5MateriaSel = aP2_MateriaSel;
         objmateria_level_detail_grid1.AV9start = aP3_start;
         objmateria_level_detail_grid1.AV10count = aP4_count;
         objmateria_level_detail_grid1.AV8gxid = aP5_gxid;
         objmateria_level_detail_grid1.AV11GXM2RootCol = new GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objmateria_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objmateria_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmateria_level_detail_grid1);
         aP6_GXM2RootCol=this.AV11GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((materia_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV9start);
         GXPagingTo2 = (int)(AV10count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11MateriasId = P00002_A11MateriasId[0];
            A48MateriasNombre = P00002_A48MateriasNombre[0];
            A52MateriasProfCorreo = P00002_A52MateriasProfCorreo[0];
            A51MateriasProfesor = P00002_A51MateriasProfesor[0];
            AV12GXM1Materia_Level_Detail_Grid1Sdt = new SdtMateria_Level_Detail_Grid1Sdt_Item(context);
            AV11GXM2RootCol.Add(AV12GXM1Materia_Level_Detail_Grid1Sdt, 0);
            AV12GXM1Materia_Level_Detail_Grid1Sdt.gxTpr_Materiasid = A11MateriasId;
            AV12GXM1Materia_Level_Detail_Grid1Sdt.gxTpr_Materiasnombre = A48MateriasNombre;
            AV12GXM1Materia_Level_Detail_Grid1Sdt.gxTpr_Materiasprofcorreo = A52MateriasProfCorreo;
            AV12GXM1Materia_Level_Detail_Grid1Sdt.gxTpr_Materiasprofesor = A51MateriasProfesor;
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
         P00002_A48MateriasNombre = new String[] {""} ;
         P00002_A52MateriasProfCorreo = new String[] {""} ;
         P00002_A51MateriasProfesor = new String[] {""} ;
         A48MateriasNombre = "";
         A52MateriasProfCorreo = "";
         A51MateriasProfesor = "";
         AV12GXM1Materia_Level_Detail_Grid1Sdt = new SdtMateria_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.materia_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A11MateriasId, P00002_A48MateriasNombre, P00002_A52MateriasProfCorreo, P00002_A51MateriasProfesor
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV6UsersId ;
      private short AV5MateriaSel ;
      private short A11MateriasId ;
      private int AV8gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV9start ;
      private long AV10count ;
      private String AV7UsersBusiness ;
      private String scmdbuf ;
      private String A48MateriasNombre ;
      private String A51MateriasProfesor ;
      private String A52MateriasProfCorreo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A11MateriasId ;
      private String[] P00002_A48MateriasNombre ;
      private String[] P00002_A52MateriasProfCorreo ;
      private String[] P00002_A51MateriasProfesor ;
      private GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> aP6_GXM2RootCol ;
      private GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> AV11GXM2RootCol ;
      private SdtMateria_Level_Detail_Grid1Sdt_Item AV12GXM1Materia_Level_Detail_Grid1Sdt ;
   }

   public class materia_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT [MateriasId], [MateriasNombre], [MateriasProfCorreo], [MateriasProfesor] FROM [Materias] WITH (NOLOCK) ORDER BY [MateriasId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.materia_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class materia_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsersBusiness={UsersBusiness}&UsersId={UsersId}&MateriaSel={MateriaSel}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String UsersBusiness ,
                                                                                             short UsersId ,
                                                                                             short MateriaSel ,
                                                                                             String start ,
                                                                                             String count ,
                                                                                             String gxid )
    {
       GxGenericCollection<SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("materia_level_detail_grid1") )
          {
             return null ;
          }
          materia_level_detail_grid1 worker = new materia_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtMateria_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(UsersBusiness,UsersId,MateriaSel,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtMateria_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
