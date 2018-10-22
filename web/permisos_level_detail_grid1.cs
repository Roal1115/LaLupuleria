/*
               File: Permisos_Level_Detail_Grid1
        Description: Permisos_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:31.45
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
   public class permisos_level_detail_grid1 : GXProcedure
   {
      public permisos_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public permisos_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_start ,
                           long aP1_count ,
                           int aP2_gxid ,
                           out GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> aP3_GXM3RootCol )
      {
         this.AV19start = aP0_start;
         this.AV20count = aP1_count;
         this.AV16gxid = aP2_gxid;
         this.AV22GXM3RootCol = new GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM3RootCol=this.AV22GXM3RootCol;
      }

      public GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_start ,
                                                                                  long aP1_count ,
                                                                                  int aP2_gxid )
      {
         this.AV19start = aP0_start;
         this.AV20count = aP1_count;
         this.AV16gxid = aP2_gxid;
         this.AV22GXM3RootCol = new GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM3RootCol=this.AV22GXM3RootCol;
         return AV22GXM3RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> aP3_GXM3RootCol )
      {
         permisos_level_detail_grid1 objpermisos_level_detail_grid1;
         objpermisos_level_detail_grid1 = new permisos_level_detail_grid1();
         objpermisos_level_detail_grid1.AV19start = aP0_start;
         objpermisos_level_detail_grid1.AV20count = aP1_count;
         objpermisos_level_detail_grid1.AV16gxid = aP2_gxid;
         objpermisos_level_detail_grid1.AV22GXM3RootCol = new GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objpermisos_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objpermisos_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpermisos_level_detail_grid1);
         aP3_GXM3RootCol=this.AV22GXM3RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((permisos_level_detail_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV16gxid), 8, 0);
         AV6DiaI = context.localUtil.CToD( Gxwebsession.Get(Gxids+"gxvar_Diai"), 2);
         AV21GXV1SkipCount = (int)(-(AV19start));
         AV21GXV1SkipCount = (int)(AV21GXV1SkipCount+1);
         if ( AV21GXV1SkipCount > 0 )
         {
            AV23GXM2Permisos_Level_Detail_Grid1Sdt = new SdtPermisos_Level_Detail_Grid1Sdt_Item(context);
            AV22GXM3RootCol.Add(AV23GXM2Permisos_Level_Detail_Grid1Sdt, 0);
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Diai = AV6DiaI;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Diaf = AV8DiaF;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Check1 = AV11check1;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Check2 = AV12check2;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Check3 = AV13check3;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Check4 = AV14check4;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Check5 = AV15check5;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Familia = AV7Familia;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Afamilia = AV9AFamilia;
            AV23GXM2Permisos_Level_Detail_Grid1Sdt.gxTpr_Motivo = AV5motivo;
         }
         Gxwebsession.Set(Gxids+"gxvar_Diai", context.localUtil.DToC( AV6DiaI, 2, "/"));
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
         AV6DiaI = DateTime.MinValue;
         Gxwebsession = context.GetSession();
         AV23GXM2Permisos_Level_Detail_Grid1Sdt = new SdtPermisos_Level_Detail_Grid1Sdt_Item(context);
         AV8DiaF = DateTime.MinValue;
         AV9AFamilia = "";
         AV5motivo = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV16gxid ;
      private int AV21GXV1SkipCount ;
      private int AV7Familia ;
      private long AV19start ;
      private long AV20count ;
      private String Gxids ;
      private String AV9AFamilia ;
      private String AV5motivo ;
      private DateTime AV6DiaI ;
      private DateTime AV8DiaF ;
      private bool AV11check1 ;
      private bool AV12check2 ;
      private bool AV13check3 ;
      private bool AV14check4 ;
      private bool AV15check5 ;
      private GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> aP3_GXM3RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> AV22GXM3RootCol ;
      private SdtPermisos_Level_Detail_Grid1Sdt_Item AV23GXM2Permisos_Level_Detail_Grid1Sdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.permisos_level_detail_grid1_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class permisos_level_detail_grid1_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
      public GxGenericCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String start ,
                                                                                                String count ,
                                                                                                String gxid )
      {
         GxGenericCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM3RootCol = new GxGenericCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
         try
         {
            if ( ! ProcessHeaders("permisos_level_detail_grid1") )
            {
               return null ;
            }
            permisos_level_detail_grid1 worker = new permisos_level_detail_grid1(context) ;
            worker.IsMain = RunAsMain ;
            long gxrstart ;
            gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
            long gxrcount ;
            gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item> gxrGXM3RootCol = new GXBaseCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item>() ;
            worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM3RootCol );
            worker.cleanup( );
            GXM3RootCol = new GxGenericCollection<SdtPermisos_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM3RootCol) ;
            return GXM3RootCol ;
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
