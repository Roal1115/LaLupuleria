/*
               File: LoadingSolution
        Description: Loading Solution
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:41.47
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class loadingsolution : GXProcedure
   {
      public loadingsolution( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public loadingsolution( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         loadingsolution objloadingsolution;
         objloadingsolution = new loadingsolution();
         objloadingsolution.context.SetSubmitInitialConfig(context);
         objloadingsolution.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloadingsolution);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadingsolution)stateInfo).executePrivate();
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
         AV8DeviceId = new GeneXus.Core.genexus.client.SdtClientInformation(context).gxTpr_Id;
         /* Using cursor P000J2 */
         pr_default.execute(0, new Object[] {AV8DeviceId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1DeviceId = P000J2_A1DeviceId[0];
            A21DeviceName = P000J2_A21DeviceName[0];
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A21DeviceName)) )
            {
               AV9DeviceName = StringUtil.Trim( A21DeviceName);
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9DeviceName)) )
         {
            /* Optimized UPDATE. */
            /* Using cursor P000J3 */
            pr_default.execute(1, new Object[] {AV9DeviceName, AV8DeviceId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
            /* End optimized UPDATE. */
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("loadingsolution",pr_default);
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
         AV8DeviceId = "";
         scmdbuf = "";
         P000J2_A1DeviceId = new String[] {""} ;
         P000J2_A21DeviceName = new String[] {""} ;
         A1DeviceId = "";
         A21DeviceName = "";
         AV9DeviceName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.loadingsolution__default(),
            new Object[][] {
                new Object[] {
               P000J2_A1DeviceId, P000J2_A21DeviceName
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String scmdbuf ;
      private String AV8DeviceId ;
      private String A1DeviceId ;
      private String A21DeviceName ;
      private String AV9DeviceName ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000J2_A1DeviceId ;
      private String[] P000J2_A21DeviceName ;
   }

   public class loadingsolution__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000J2 ;
          prmP000J2 = new Object[] {
          new Object[] {"@AV8DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmP000J3 ;
          prmP000J3 = new Object[] {
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0} ,
          new Object[] {"@AV8DeviceId",SqlDbType.VarChar,128,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000J2", "SELECT [DeviceId], [DeviceName] FROM [Devices] WITH (NOLOCK) WHERE [DeviceId] = @AV8DeviceId ORDER BY [DeviceId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J2,1,0,false,true )
             ,new CursorDef("P000J3", "UPDATE [Devices] SET [DeviceName]=@DeviceName  WHERE [DeviceId] = @AV8DeviceId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000J3)
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
