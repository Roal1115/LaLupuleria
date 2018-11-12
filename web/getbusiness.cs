/*
               File: GetBusiness
        Description: Get Business
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:40.65
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
   public class getbusiness : GXProcedure
   {
      public getbusiness( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public getbusiness( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersName ,
                           out String aP1_UsersBusiness )
      {
         this.AV8UsersName = aP0_UsersName;
         this.AV9UsersBusiness = "" ;
         initialize();
         executePrivate();
         aP1_UsersBusiness=this.AV9UsersBusiness;
      }

      public String executeUdp( String aP0_UsersName )
      {
         this.AV8UsersName = aP0_UsersName;
         this.AV9UsersBusiness = "" ;
         initialize();
         executePrivate();
         aP1_UsersBusiness=this.AV9UsersBusiness;
         return AV9UsersBusiness ;
      }

      public void executeSubmit( String aP0_UsersName ,
                                 out String aP1_UsersBusiness )
      {
         getbusiness objgetbusiness;
         objgetbusiness = new getbusiness();
         objgetbusiness.AV8UsersName = aP0_UsersName;
         objgetbusiness.AV9UsersBusiness = "" ;
         objgetbusiness.context.SetSubmitInitialConfig(context);
         objgetbusiness.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgetbusiness);
         aP1_UsersBusiness=this.AV9UsersBusiness;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((getbusiness)stateInfo).executePrivate();
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
         /* Using cursor P000I2 */
         pr_default.execute(0, new Object[] {AV8UsersName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4UsersName = P000I2_A4UsersName[0];
            A2UsersBusiness = P000I2_A2UsersBusiness[0];
            A3UsersId = P000I2_A3UsersId[0];
            AV9UsersBusiness = A2UsersBusiness;
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
         P000I2_A4UsersName = new String[] {""} ;
         P000I2_A2UsersBusiness = new String[] {""} ;
         P000I2_A3UsersId = new short[1] ;
         A4UsersName = "";
         A2UsersBusiness = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.getbusiness__default(),
            new Object[][] {
                new Object[] {
               P000I2_A4UsersName, P000I2_A2UsersBusiness, P000I2_A3UsersId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3UsersId ;
      private String AV8UsersName ;
      private String AV9UsersBusiness ;
      private String scmdbuf ;
      private String A4UsersName ;
      private String A2UsersBusiness ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000I2_A4UsersName ;
      private String[] P000I2_A2UsersBusiness ;
      private short[] P000I2_A3UsersId ;
      private String aP1_UsersBusiness ;
   }

   public class getbusiness__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000I2 ;
          prmP000I2 = new Object[] {
          new Object[] {"@AV8UsersName",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000I2", "SELECT [UsersName], [UsersBusiness], [UsersId] FROM [Users] WITH (NOLOCK) WHERE RTRIM(LTRIM([UsersName])) = RTRIM(LTRIM(@AV8UsersName)) ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000I2,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.getbusiness_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class getbusiness_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String UsersName ,
                         out String UsersBusiness )
    {
       UsersBusiness = "" ;
       try
       {
          if ( ! ProcessHeaders("getbusiness") )
          {
             return  ;
          }
          getbusiness worker = new getbusiness(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(UsersName,out UsersBusiness );
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
