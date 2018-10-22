/*
               File: Mensajes_Level_Detail
        Description: Mensajes_Level_Detail
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:11:49.22
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
   public class mensajes_level_detail : GXProcedure
   {
      public mensajes_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public mensajes_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtMensajes_Level_DetailSdt aP1_GXM1Mensajes_Level_DetailSdt )
      {
         this.AV7gxid = aP0_gxid;
         this.AV10GXM1Mensajes_Level_DetailSdt = new SdtMensajes_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Mensajes_Level_DetailSdt=this.AV10GXM1Mensajes_Level_DetailSdt;
      }

      public SdtMensajes_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV7gxid = aP0_gxid;
         this.AV10GXM1Mensajes_Level_DetailSdt = new SdtMensajes_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1Mensajes_Level_DetailSdt=this.AV10GXM1Mensajes_Level_DetailSdt;
         return AV10GXM1Mensajes_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtMensajes_Level_DetailSdt aP1_GXM1Mensajes_Level_DetailSdt )
      {
         mensajes_level_detail objmensajes_level_detail;
         objmensajes_level_detail = new mensajes_level_detail();
         objmensajes_level_detail.AV7gxid = aP0_gxid;
         objmensajes_level_detail.AV10GXM1Mensajes_Level_DetailSdt = new SdtMensajes_Level_DetailSdt(context) ;
         objmensajes_level_detail.context.SetSubmitInitialConfig(context);
         objmensajes_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmensajes_level_detail);
         aP1_GXM1Mensajes_Level_DetailSdt=this.AV10GXM1Mensajes_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((mensajes_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV7gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            AV5Destination = A52MateriasProfCorreo;
            Gxwebsession.Set(Gxids+"gxvar_Destination", AV5Destination);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV5Destination = Gxwebsession.Get(Gxids+"gxvar_Destination");
         }
         AV10GXM1Mensajes_Level_DetailSdt.gxTpr_Destination = AV5Destination;
         AV10GXM1Mensajes_Level_DetailSdt.gxTpr_Subject = AV6Subject;
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
         AV5Destination = "";
         A52MateriasProfCorreo = "";
         AV6Subject = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV7gxid ;
      private String Gxids ;
      private String AV5Destination ;
      private String A52MateriasProfCorreo ;
      private String AV6Subject ;
      private SdtMensajes_Level_DetailSdt aP1_GXM1Mensajes_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtMensajes_Level_DetailSdt AV10GXM1Mensajes_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.mensajes_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class mensajes_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtMensajes_Level_DetailSdt_RESTInterface execute( String gxid )
      {
         SdtMensajes_Level_DetailSdt_RESTInterface GXM1Mensajes_Level_DetailSdt = new SdtMensajes_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("mensajes_level_detail") )
            {
               return null ;
            }
            mensajes_level_detail worker = new mensajes_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtMensajes_Level_DetailSdt gxrGXM1Mensajes_Level_DetailSdt = GXM1Mensajes_Level_DetailSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1Mensajes_Level_DetailSdt );
            worker.cleanup( );
            GXM1Mensajes_Level_DetailSdt = new SdtMensajes_Level_DetailSdt_RESTInterface(gxrGXM1Mensajes_Level_DetailSdt) ;
            return GXM1Mensajes_Level_DetailSdt ;
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
