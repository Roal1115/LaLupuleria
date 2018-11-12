/*
               File: Permisos_Level_Detail
        Description: Permisos_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:31.85
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
   public class permisos_level_detail : GXProcedure
   {
      public permisos_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public permisos_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtPermisos_Level_DetailSdt aP1_GXM1Permisos_Level_DetailSdt )
      {
         this.AV16gxid = aP0_gxid;
         this.AV19GXM1Permisos_Level_DetailSdt = new SdtPermisos_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Permisos_Level_DetailSdt=this.AV19GXM1Permisos_Level_DetailSdt;
      }

      public SdtPermisos_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV16gxid = aP0_gxid;
         this.AV19GXM1Permisos_Level_DetailSdt = new SdtPermisos_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Permisos_Level_DetailSdt=this.AV19GXM1Permisos_Level_DetailSdt;
         return AV19GXM1Permisos_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtPermisos_Level_DetailSdt aP1_GXM1Permisos_Level_DetailSdt )
      {
         permisos_level_detail objpermisos_level_detail;
         objpermisos_level_detail = new permisos_level_detail();
         objpermisos_level_detail.AV16gxid = aP0_gxid;
         objpermisos_level_detail.AV19GXM1Permisos_Level_DetailSdt = new SdtPermisos_Level_DetailSdt(context) ;
         objpermisos_level_detail.context.SetSubmitInitialConfig(context);
         objpermisos_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpermisos_level_detail);
         aP1_GXM1Permisos_Level_DetailSdt=this.AV19GXM1Permisos_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((permisos_level_detail)stateInfo).executePrivate();
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
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            AV6DiaI = DateTimeUtil.Today( context);
            Gxwebsession.Set(Gxids+"gxvar_Diai", context.localUtil.DToC( AV6DiaI, 2, "/"));
            Gxwebsession.Set(Gxids, "true");
         }
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
         AV6DiaI = DateTime.MinValue;
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV16gxid ;
      private String Gxids ;
      private DateTime AV6DiaI ;
      private SdtPermisos_Level_DetailSdt aP1_GXM1Permisos_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtPermisos_Level_DetailSdt AV19GXM1Permisos_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.permisos_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class permisos_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtPermisos_Level_DetailSdt_RESTInterface execute( String gxid )
      {
         SdtPermisos_Level_DetailSdt_RESTInterface GXM1Permisos_Level_DetailSdt = new SdtPermisos_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("permisos_level_detail") )
            {
               return null ;
            }
            permisos_level_detail worker = new permisos_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtPermisos_Level_DetailSdt gxrGXM1Permisos_Level_DetailSdt = GXM1Permisos_Level_DetailSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1Permisos_Level_DetailSdt );
            worker.cleanup( );
            GXM1Permisos_Level_DetailSdt = new SdtPermisos_Level_DetailSdt_RESTInterface(gxrGXM1Permisos_Level_DetailSdt) ;
            return GXM1Permisos_Level_DetailSdt ;
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
