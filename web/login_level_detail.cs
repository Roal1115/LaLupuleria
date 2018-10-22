/*
               File: Login_Level_Detail
        Description: Login_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:26.4
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
   public class login_level_detail : GXProcedure
   {
      public login_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public login_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtLogin_Level_DetailSdt aP1_GXM1Login_Level_DetailSdt )
      {
         this.AV15gxid = aP0_gxid;
         this.AV19GXM1Login_Level_DetailSdt = new SdtLogin_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Login_Level_DetailSdt=this.AV19GXM1Login_Level_DetailSdt;
      }

      public SdtLogin_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV15gxid = aP0_gxid;
         this.AV19GXM1Login_Level_DetailSdt = new SdtLogin_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Login_Level_DetailSdt=this.AV19GXM1Login_Level_DetailSdt;
         return AV19GXM1Login_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtLogin_Level_DetailSdt aP1_GXM1Login_Level_DetailSdt )
      {
         login_level_detail objlogin_level_detail;
         objlogin_level_detail = new login_level_detail();
         objlogin_level_detail.AV15gxid = aP0_gxid;
         objlogin_level_detail.AV19GXM1Login_Level_DetailSdt = new SdtLogin_Level_DetailSdt(context) ;
         objlogin_level_detail.context.SetSubmitInitialConfig(context);
         objlogin_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlogin_level_detail);
         aP1_GXM1Login_Level_DetailSdt=this.AV19GXM1Login_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((login_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV15gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Textblock1\",\"Caption\",\"" + StringUtil.JSONEncode( "Login") + "\"]";
            Gxwebsession.Set(Gxids, "true");
         }
         AV19GXM1Login_Level_DetailSdt.gxTpr_Usersname = AV7UsersName;
         AV19GXM1Login_Level_DetailSdt.gxTpr_Userspassword = AV8UsersPassword;
         AV19GXM1Login_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         Gxdynprop = "";
         AV7UsersName = "";
         AV8UsersPassword = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV15gxid ;
      private String Gxids ;
      private String AV7UsersName ;
      private String AV8UsersPassword ;
      private String Gxdynprop ;
      private SdtLogin_Level_DetailSdt aP1_GXM1Login_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtLogin_Level_DetailSdt AV19GXM1Login_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.login_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class login_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtLogin_Level_DetailSdt_RESTInterface execute( String gxid )
      {
         SdtLogin_Level_DetailSdt_RESTInterface GXM1Login_Level_DetailSdt = new SdtLogin_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("login_level_detail") )
            {
               return null ;
            }
            login_level_detail worker = new login_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtLogin_Level_DetailSdt gxrGXM1Login_Level_DetailSdt = GXM1Login_Level_DetailSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1Login_Level_DetailSdt );
            worker.cleanup( );
            GXM1Login_Level_DetailSdt = new SdtLogin_Level_DetailSdt_RESTInterface(gxrGXM1Login_Level_DetailSdt) ;
            return GXM1Login_Level_DetailSdt ;
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
