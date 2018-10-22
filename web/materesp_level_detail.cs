/*
               File: MaterEsp_Level_Detail
        Description: MaterEsp_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:35.27
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
   public class materesp_level_detail : GXProcedure
   {
      public materesp_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public materesp_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersBusiness ,
                           short aP1_UsersId ,
                           short aP2_MateriaSel ,
                           int aP3_gxid ,
                           out SdtMaterEsp_Level_DetailSdt aP4_GXM1MaterEsp_Level_DetailSdt )
      {
         this.AV6UsersBusiness = aP0_UsersBusiness;
         this.AV7UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV9gxid = aP3_gxid;
         this.AV12GXM1MaterEsp_Level_DetailSdt = new SdtMaterEsp_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP4_GXM1MaterEsp_Level_DetailSdt=this.AV12GXM1MaterEsp_Level_DetailSdt;
      }

      public SdtMaterEsp_Level_DetailSdt executeUdp( String aP0_UsersBusiness ,
                                                     short aP1_UsersId ,
                                                     short aP2_MateriaSel ,
                                                     int aP3_gxid )
      {
         this.AV6UsersBusiness = aP0_UsersBusiness;
         this.AV7UsersId = aP1_UsersId;
         this.AV5MateriaSel = aP2_MateriaSel;
         this.AV9gxid = aP3_gxid;
         this.AV12GXM1MaterEsp_Level_DetailSdt = new SdtMaterEsp_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP4_GXM1MaterEsp_Level_DetailSdt=this.AV12GXM1MaterEsp_Level_DetailSdt;
         return AV12GXM1MaterEsp_Level_DetailSdt ;
      }

      public void executeSubmit( String aP0_UsersBusiness ,
                                 short aP1_UsersId ,
                                 short aP2_MateriaSel ,
                                 int aP3_gxid ,
                                 out SdtMaterEsp_Level_DetailSdt aP4_GXM1MaterEsp_Level_DetailSdt )
      {
         materesp_level_detail objmateresp_level_detail;
         objmateresp_level_detail = new materesp_level_detail();
         objmateresp_level_detail.AV6UsersBusiness = aP0_UsersBusiness;
         objmateresp_level_detail.AV7UsersId = aP1_UsersId;
         objmateresp_level_detail.AV5MateriaSel = aP2_MateriaSel;
         objmateresp_level_detail.AV9gxid = aP3_gxid;
         objmateresp_level_detail.AV12GXM1MaterEsp_Level_DetailSdt = new SdtMaterEsp_Level_DetailSdt(context) ;
         objmateresp_level_detail.context.SetSubmitInitialConfig(context);
         objmateresp_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmateresp_level_detail);
         aP4_GXM1MaterEsp_Level_DetailSdt=this.AV12GXM1MaterEsp_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((materesp_level_detail)stateInfo).executePrivate();
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
            Gxwebsession.Set(Gxids+"gxvar_Promedio", StringUtil.Str( (decimal)(AV8Promedio), 3, 0));
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7UsersId ;
      private short AV5MateriaSel ;
      private short AV8Promedio ;
      private int AV9gxid ;
      private String AV6UsersBusiness ;
      private String Gxids ;
      private SdtMaterEsp_Level_DetailSdt aP4_GXM1MaterEsp_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtMaterEsp_Level_DetailSdt AV12GXM1MaterEsp_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.materesp_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class materesp_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?UsersBusiness={UsersBusiness}&UsersId={UsersId}&MateriaSel={MateriaSel}&gxid={gxid}")]
      public SdtMaterEsp_Level_DetailSdt_RESTInterface execute( String UsersBusiness ,
                                                                short UsersId ,
                                                                short MateriaSel ,
                                                                String gxid )
      {
         SdtMaterEsp_Level_DetailSdt_RESTInterface GXM1MaterEsp_Level_DetailSdt = new SdtMaterEsp_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("materesp_level_detail") )
            {
               return null ;
            }
            materesp_level_detail worker = new materesp_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtMaterEsp_Level_DetailSdt gxrGXM1MaterEsp_Level_DetailSdt = GXM1MaterEsp_Level_DetailSdt.sdt ;
            worker.execute(UsersBusiness,UsersId,MateriaSel,gxrgxid,out gxrGXM1MaterEsp_Level_DetailSdt );
            worker.cleanup( );
            GXM1MaterEsp_Level_DetailSdt = new SdtMaterEsp_Level_DetailSdt_RESTInterface(gxrGXM1MaterEsp_Level_DetailSdt) ;
            return GXM1MaterEsp_Level_DetailSdt ;
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
