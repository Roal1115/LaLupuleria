/*
               File: PushTestMain_Level_Detail
        Description: PushTestMain_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:29.1
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
   public class pushtestmain_level_detail : GXProcedure
   {
      public pushtestmain_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public pushtestmain_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersBusiness ,
                           String aP1_DeviceId ,
                           int aP2_gxid ,
                           out SdtPushTestMain_Level_DetailSdt aP3_GXM2PushTestMain_Level_DetailSdt )
      {
         this.AV11UsersBusiness = aP0_UsersBusiness;
         this.AV7DeviceId = aP1_DeviceId;
         this.AV12gxid = aP2_gxid;
         this.AV17GXM2PushTestMain_Level_DetailSdt = new SdtPushTestMain_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2PushTestMain_Level_DetailSdt=this.AV17GXM2PushTestMain_Level_DetailSdt;
      }

      public SdtPushTestMain_Level_DetailSdt executeUdp( String aP0_UsersBusiness ,
                                                         String aP1_DeviceId ,
                                                         int aP2_gxid )
      {
         this.AV11UsersBusiness = aP0_UsersBusiness;
         this.AV7DeviceId = aP1_DeviceId;
         this.AV12gxid = aP2_gxid;
         this.AV17GXM2PushTestMain_Level_DetailSdt = new SdtPushTestMain_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2PushTestMain_Level_DetailSdt=this.AV17GXM2PushTestMain_Level_DetailSdt;
         return AV17GXM2PushTestMain_Level_DetailSdt ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 String aP1_DeviceId ,
                                 int aP2_gxid ,
                                 out SdtPushTestMain_Level_DetailSdt aP3_GXM2PushTestMain_Level_DetailSdt )
      {
         pushtestmain_level_detail objpushtestmain_level_detail;
         objpushtestmain_level_detail = new pushtestmain_level_detail();
         objpushtestmain_level_detail.AV11UsersBusiness = aP0_UsersBusiness;
         objpushtestmain_level_detail.AV7DeviceId = aP1_DeviceId;
         objpushtestmain_level_detail.AV12gxid = aP2_gxid;
         objpushtestmain_level_detail.AV17GXM2PushTestMain_Level_DetailSdt = new SdtPushTestMain_Level_DetailSdt(context) ;
         objpushtestmain_level_detail.context.SetSubmitInitialConfig(context);
         objpushtestmain_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpushtestmain_level_detail);
         aP3_GXM2PushTestMain_Level_DetailSdt=this.AV17GXM2PushTestMain_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pushtestmain_level_detail)stateInfo).executePrivate();
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
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxdynprop1 = AV11UsersBusiness;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Textblock1\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            new loadingsolution(context ).execute( ) ;
            Gxwebsession.Set(Gxids+"gxvar_Groupname", AV8GroupName);
            Gxwebsession.Set(Gxids+"gxvar_Issuscribed", StringUtil.BoolToStr( AV6isSuscribed));
            Gxwebsession.Set(Gxids, "true");
         }
         AV17GXM2PushTestMain_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
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
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV8GroupName = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV12gxid ;
      private String AV11UsersBusiness ;
      private String Gxids ;
      private String Gxdynprop1 ;
      private String AV8GroupName ;
      private bool AV6isSuscribed ;
      private String AV7DeviceId ;
      private String Gxdynprop ;
      private SdtPushTestMain_Level_DetailSdt aP3_GXM2PushTestMain_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtPushTestMain_Level_DetailSdt AV17GXM2PushTestMain_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.pushtestmain_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class pushtestmain_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?UsersBusiness={UsersBusiness}&DeviceId={DeviceId}&gxid={gxid}")]
      public SdtPushTestMain_Level_DetailSdt_RESTInterface execute( String UsersBusiness ,
                                                                    String DeviceId ,
                                                                    String gxid )
      {
         SdtPushTestMain_Level_DetailSdt_RESTInterface GXM2PushTestMain_Level_DetailSdt = new SdtPushTestMain_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("pushtestmain_level_detail") )
            {
               return null ;
            }
            pushtestmain_level_detail worker = new pushtestmain_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtPushTestMain_Level_DetailSdt gxrGXM2PushTestMain_Level_DetailSdt = GXM2PushTestMain_Level_DetailSdt.sdt ;
            worker.execute(UsersBusiness,DeviceId,gxrgxid,out gxrGXM2PushTestMain_Level_DetailSdt );
            worker.cleanup( );
            GXM2PushTestMain_Level_DetailSdt = new SdtPushTestMain_Level_DetailSdt_RESTInterface(gxrGXM2PushTestMain_Level_DetailSdt) ;
            return GXM2PushTestMain_Level_DetailSdt ;
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
