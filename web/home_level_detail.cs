/*
               File: Home_Level_Detail
        Description: Home_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:29:9.79
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
   public class home_level_detail : GXProcedure
   {
      public home_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public home_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersBusiness ,
                           short aP1_UsersId ,
                           int aP2_gxid ,
                           out SdtHome_Level_DetailSdt aP3_GXM1Home_Level_DetailSdt )
      {
         this.AV7UsersBusiness = aP0_UsersBusiness;
         this.AV8UsersId = aP1_UsersId;
         this.AV9gxid = aP2_gxid;
         this.AV12GXM1Home_Level_DetailSdt = new SdtHome_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1Home_Level_DetailSdt=this.AV12GXM1Home_Level_DetailSdt;
      }

      public SdtHome_Level_DetailSdt executeUdp( String aP0_UsersBusiness ,
                                                 short aP1_UsersId ,
                                                 int aP2_gxid )
      {
         this.AV7UsersBusiness = aP0_UsersBusiness;
         this.AV8UsersId = aP1_UsersId;
         this.AV9gxid = aP2_gxid;
         this.AV12GXM1Home_Level_DetailSdt = new SdtHome_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1Home_Level_DetailSdt=this.AV12GXM1Home_Level_DetailSdt;
         return AV12GXM1Home_Level_DetailSdt ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 short aP1_UsersId ,
                                 int aP2_gxid ,
                                 out SdtHome_Level_DetailSdt aP3_GXM1Home_Level_DetailSdt )
      {
         home_level_detail objhome_level_detail;
         objhome_level_detail = new home_level_detail();
         objhome_level_detail.AV7UsersBusiness = aP0_UsersBusiness;
         objhome_level_detail.AV8UsersId = aP1_UsersId;
         objhome_level_detail.AV9gxid = aP2_gxid;
         objhome_level_detail.AV12GXM1Home_Level_DetailSdt = new SdtHome_Level_DetailSdt(context) ;
         objhome_level_detail.context.SetSubmitInitialConfig(context);
         objhome_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objhome_level_detail);
         aP3_GXM1Home_Level_DetailSdt=this.AV12GXM1Home_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((home_level_detail)stateInfo).executePrivate();
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
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids, "true");
         }
         AV12GXM1Home_Level_DetailSdt.gxTpr_Usersbusiness = AV7UsersBusiness;
         AV12GXM1Home_Level_DetailSdt.gxTpr_Usersid = AV8UsersId;
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8UsersId ;
      private int AV9gxid ;
      private String AV7UsersBusiness ;
      private String Gxids ;
      private SdtHome_Level_DetailSdt aP3_GXM1Home_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtHome_Level_DetailSdt AV12GXM1Home_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.home_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class home_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?UsersBusiness={UsersBusiness}&UsersId={UsersId}&gxid={gxid}")]
      public SdtHome_Level_DetailSdt_RESTInterface execute( String UsersBusiness ,
                                                            short UsersId ,
                                                            String gxid )
      {
         SdtHome_Level_DetailSdt_RESTInterface GXM1Home_Level_DetailSdt = new SdtHome_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("home_level_detail") )
            {
               return null ;
            }
            home_level_detail worker = new home_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtHome_Level_DetailSdt gxrGXM1Home_Level_DetailSdt = GXM1Home_Level_DetailSdt.sdt ;
            worker.execute(UsersBusiness,UsersId,gxrgxid,out gxrGXM1Home_Level_DetailSdt );
            worker.cleanup( );
            GXM1Home_Level_DetailSdt = new SdtHome_Level_DetailSdt_RESTInterface(gxrGXM1Home_Level_DetailSdt) ;
            return GXM1Home_Level_DetailSdt ;
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
