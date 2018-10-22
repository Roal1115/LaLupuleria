/*
               File: NotificationsRegistrationHandler
        Description: Notifications Registration Handler
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:35.70
       Program type: Main program
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
   public class anotificationsregistrationhandler : GXProcedure
   {
      public anotificationsregistrationhandler( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public anotificationsregistrationhandler( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_DeviceType ,
                           String aP1_DeviceId ,
                           String aP2_DeviceToken ,
                           String aP3_DeviceName )
      {
         this.AV11DeviceType = aP0_DeviceType;
         this.AV8DeviceId = aP1_DeviceId;
         this.AV10DeviceToken = aP2_DeviceToken;
         this.AV9DeviceName = aP3_DeviceName;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_DeviceType ,
                                 String aP1_DeviceId ,
                                 String aP2_DeviceToken ,
                                 String aP3_DeviceName )
      {
         anotificationsregistrationhandler objanotificationsregistrationhandler;
         objanotificationsregistrationhandler = new anotificationsregistrationhandler();
         objanotificationsregistrationhandler.AV11DeviceType = aP0_DeviceType;
         objanotificationsregistrationhandler.AV8DeviceId = aP1_DeviceId;
         objanotificationsregistrationhandler.AV10DeviceToken = aP2_DeviceToken;
         objanotificationsregistrationhandler.AV9DeviceName = aP3_DeviceName;
         objanotificationsregistrationhandler.context.SetSubmitInitialConfig(context);
         objanotificationsregistrationhandler.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objanotificationsregistrationhandler);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((anotificationsregistrationhandler)stateInfo).executePrivate();
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
         context.StatusMessage( StringUtil.Trim( AV10DeviceToken) );
         AV14GXLvl7 = 0;
         /* Optimized UPDATE. */
         /* Using cursor P000A2 */
         String AV9DeviceName21Aux ;
         AV9DeviceName21Aux = AV9DeviceName;
         String AV10DeviceToken20Aux ;
         AV10DeviceToken20Aux = AV10DeviceToken;
         pr_default.execute(0, new Object[] {AV9DeviceName21Aux, AV10DeviceToken20Aux, AV8DeviceId, AV11DeviceType});
         if ( (pr_default.getStatus(0) != 101) )
         {
            AV14GXLvl7 = 1;
         }
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
         /* End optimized UPDATE. */
         if ( AV14GXLvl7 == 0 )
         {
            /*
               INSERT RECORD ON TABLE Devices

            */
            A19DeviceType = AV11DeviceType;
            A1DeviceId = AV8DeviceId;
            A20DeviceToken = AV10DeviceToken;
            A21DeviceName = AV9DeviceName;
            /* Using cursor P000A3 */
            pr_default.execute(1, new Object[] {A1DeviceId, A19DeviceType, A20DeviceToken, A21DeviceName});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("notificationsregistrationhandler",pr_default);
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
         A21DeviceName = "";
         A20DeviceToken = "";
         A1DeviceId = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.anotificationsregistrationhandler__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11DeviceType ;
      private short AV14GXLvl7 ;
      private short A19DeviceType ;
      private int GX_INS1 ;
      private String AV8DeviceId ;
      private String AV10DeviceToken ;
      private String AV9DeviceName ;
      private String Gx_emsg ;
      private String A21DeviceName ;
      private String A20DeviceToken ;
      private String A1DeviceId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class anotificationsregistrationhandler__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000A2 ;
          prmP000A2 = new Object[] {
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV8DeviceId",SqlDbType.Char,128,0} ,
          new Object[] {"@AV11DeviceType",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP000A3 ;
          prmP000A3 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceType",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000A2", "UPDATE [Devices] SET [DeviceName]=@DeviceName, [DeviceToken]=@DeviceToken  WHERE ([DeviceId] = @AV8DeviceId) AND ([DeviceType] = @AV11DeviceType)", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000A2)
             ,new CursorDef("P000A3", "INSERT INTO [Devices]([DeviceId], [DeviceType], [DeviceToken], [DeviceName]) VALUES(@DeviceId, @DeviceType, @DeviceToken, @DeviceName)", GxErrorMask.GX_NOMASK,prmP000A3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.notificationsregistrationhandler_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class notificationsregistrationhandler_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( short DeviceType ,
                         String DeviceId ,
                         String DeviceToken ,
                         String DeviceName )
    {
       try
       {
          if ( ! ProcessHeaders("notificationsregistrationhandler") )
          {
             return  ;
          }
          anotificationsregistrationhandler worker = new anotificationsregistrationhandler(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DeviceType,DeviceId,DeviceToken,DeviceName );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
