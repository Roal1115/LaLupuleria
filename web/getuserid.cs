/*
               File: GetUserId
        Description: Get User Id
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:41.74
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
   public class getuserid : GXProcedure
   {
      public getuserid( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public getuserid( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersName ,
                           out short aP1_UsersId )
      {
         this.AV9UsersName = aP0_UsersName;
         this.AV8UsersId = 0 ;
         initialize();
         executePrivate();
         aP1_UsersId=this.AV8UsersId;
      }

      public short executeUdp( String aP0_UsersName )
      {
         this.AV9UsersName = aP0_UsersName;
         this.AV8UsersId = 0 ;
         initialize();
         executePrivate();
         aP1_UsersId=this.AV8UsersId;
         return AV8UsersId ;
      }

      public void executeSubmit( String aP0_UsersName ,
                                 out short aP1_UsersId )
      {
         getuserid objgetuserid;
         objgetuserid = new getuserid();
         objgetuserid.AV9UsersName = aP0_UsersName;
         objgetuserid.AV8UsersId = 0 ;
         objgetuserid.context.SetSubmitInitialConfig(context);
         objgetuserid.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgetuserid);
         aP1_UsersId=this.AV8UsersId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((getuserid)stateInfo).executePrivate();
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
         /* Using cursor P000L2 */
         pr_default.execute(0, new Object[] {AV9UsersName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4UsersName = P000L2_A4UsersName[0];
            A3UsersId = P000L2_A3UsersId[0];
            AV8UsersId = A3UsersId;
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
         P000L2_A4UsersName = new String[] {""} ;
         P000L2_A3UsersId = new short[1] ;
         A4UsersName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.getuserid__default(),
            new Object[][] {
                new Object[] {
               P000L2_A4UsersName, P000L2_A3UsersId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8UsersId ;
      private short A3UsersId ;
      private String AV9UsersName ;
      private String scmdbuf ;
      private String A4UsersName ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000L2_A4UsersName ;
      private short[] P000L2_A3UsersId ;
      private short aP1_UsersId ;
   }

   public class getuserid__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000L2 ;
          prmP000L2 = new Object[] {
          new Object[] {"@AV9UsersName",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000L2", "SELECT [UsersName], [UsersId] FROM [Users] WITH (NOLOCK) WHERE RTRIM(LTRIM([UsersName])) = RTRIM(LTRIM(@AV9UsersName)) ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L2,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.getuserid_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class getuserid_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String UsersName ,
                         out short UsersId )
    {
       UsersId = 0 ;
       try
       {
          if ( ! ProcessHeaders("getuserid") )
          {
             return  ;
          }
          getuserid worker = new getuserid(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(UsersName,out UsersId );
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
