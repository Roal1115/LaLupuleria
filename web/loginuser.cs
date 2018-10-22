/*
               File: LoginUser
        Description: Login User
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:41.18
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
   public class loginuser : GXProcedure
   {
      public loginuser( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public loginuser( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsersName ,
                           String aP1_UsersPassword ,
                           out bool aP2_islogged )
      {
         this.AV9UsersName = aP0_UsersName;
         this.AV10UsersPassword = aP1_UsersPassword;
         this.AV8islogged = false ;
         initialize();
         executePrivate();
         aP2_islogged=this.AV8islogged;
      }

      public bool executeUdp( String aP0_UsersName ,
                              String aP1_UsersPassword )
      {
         this.AV9UsersName = aP0_UsersName;
         this.AV10UsersPassword = aP1_UsersPassword;
         this.AV8islogged = false ;
         initialize();
         executePrivate();
         aP2_islogged=this.AV8islogged;
         return AV8islogged ;
      }

      public void executeSubmit( String aP0_UsersName ,
                                 String aP1_UsersPassword ,
                                 out bool aP2_islogged )
      {
         loginuser objloginuser;
         objloginuser = new loginuser();
         objloginuser.AV9UsersName = aP0_UsersName;
         objloginuser.AV10UsersPassword = aP1_UsersPassword;
         objloginuser.AV8islogged = false ;
         objloginuser.context.SetSubmitInitialConfig(context);
         objloginuser.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloginuser);
         aP2_islogged=this.AV8islogged;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loginuser)stateInfo).executePrivate();
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
         AV8islogged = false;
         /* Using cursor P000H2 */
         pr_default.execute(0, new Object[] {AV9UsersName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4UsersName = P000H2_A4UsersName[0];
            A5UsersPassword = P000H2_A5UsersPassword[0];
            A3UsersId = P000H2_A3UsersId[0];
            if ( StringUtil.StrCmp(StringUtil.Trim( A5UsersPassword), StringUtil.Trim( AV10UsersPassword)) == 0 )
            {
               AV8islogged = true;
            }
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
         P000H2_A4UsersName = new String[] {""} ;
         P000H2_A5UsersPassword = new String[] {""} ;
         P000H2_A3UsersId = new short[1] ;
         A4UsersName = "";
         A5UsersPassword = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.loginuser__default(),
            new Object[][] {
                new Object[] {
               P000H2_A4UsersName, P000H2_A5UsersPassword, P000H2_A3UsersId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3UsersId ;
      private String AV9UsersName ;
      private String AV10UsersPassword ;
      private String scmdbuf ;
      private String A4UsersName ;
      private String A5UsersPassword ;
      private bool AV8islogged ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000H2_A4UsersName ;
      private String[] P000H2_A5UsersPassword ;
      private short[] P000H2_A3UsersId ;
      private bool aP2_islogged ;
   }

   public class loginuser__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000H2 ;
          prmP000H2 = new Object[] {
          new Object[] {"@AV9UsersName",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000H2", "SELECT [UsersName], [UsersPassword], [UsersId] FROM [Users] WITH (NOLOCK) WHERE RTRIM(LTRIM([UsersName])) = RTRIM(LTRIM(@AV9UsersName)) ORDER BY [UsersId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H2,100,0,false,false )
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

 [ServiceContract(Namespace = "GeneXus.Programs.loginuser_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class loginuser_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String UsersName ,
                         String UsersPassword ,
                         out bool islogged )
    {
       islogged = false ;
       try
       {
          if ( ! ProcessHeaders("loginuser") )
          {
             return  ;
          }
          loginuser worker = new loginuser(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(UsersName,UsersPassword,out islogged );
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
