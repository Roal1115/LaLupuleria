/*
               File: AddRemoveDeviceFromGroup
        Description: Add Remove Device From Group
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:57.24
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
   public class addremovedevicefromgroup : GXProcedure
   {
      public addremovedevicefromgroup( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public addremovedevicefromgroup( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( bool aP0_GroupSelected ,
                           String aP1_DeviceId ,
                           short aP2_GroupId ,
                           String aP3_GroupName ,
                           out GXBaseCollection<SdtMessages_Message> aP4_OutMessages )
      {
         this.AV16GroupSelected = aP0_GroupSelected;
         this.AV13DeviceId = aP1_DeviceId;
         this.AV8GroupId = aP2_GroupId;
         this.AV9GroupName = aP3_GroupName;
         this.AV19OutMessages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         initialize();
         executePrivate();
         aP4_OutMessages=this.AV19OutMessages;
      }

      public GXBaseCollection<SdtMessages_Message> executeUdp( bool aP0_GroupSelected ,
                                                               String aP1_DeviceId ,
                                                               short aP2_GroupId ,
                                                               String aP3_GroupName )
      {
         this.AV16GroupSelected = aP0_GroupSelected;
         this.AV13DeviceId = aP1_DeviceId;
         this.AV8GroupId = aP2_GroupId;
         this.AV9GroupName = aP3_GroupName;
         this.AV19OutMessages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         initialize();
         executePrivate();
         aP4_OutMessages=this.AV19OutMessages;
         return AV19OutMessages ;
      }

      public void executeSubmit( bool aP0_GroupSelected ,
                                 String aP1_DeviceId ,
                                 short aP2_GroupId ,
                                 String aP3_GroupName ,
                                 out GXBaseCollection<SdtMessages_Message> aP4_OutMessages )
      {
         addremovedevicefromgroup objaddremovedevicefromgroup;
         objaddremovedevicefromgroup = new addremovedevicefromgroup();
         objaddremovedevicefromgroup.AV16GroupSelected = aP0_GroupSelected;
         objaddremovedevicefromgroup.AV13DeviceId = aP1_DeviceId;
         objaddremovedevicefromgroup.AV8GroupId = aP2_GroupId;
         objaddremovedevicefromgroup.AV9GroupName = aP3_GroupName;
         objaddremovedevicefromgroup.AV19OutMessages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         objaddremovedevicefromgroup.context.SetSubmitInitialConfig(context);
         objaddremovedevicefromgroup.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objaddremovedevicefromgroup);
         aP4_OutMessages=this.AV19OutMessages;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((addremovedevicefromgroup)stateInfo).executePrivate();
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
         AV18NotificationConfiguration.gxTpr_Applicationid = "PushTestMain";
         AV17groupsnames.Clear();
         AV17groupsnames.Add(AV9GroupName, 0);
         context.StatusMessage( "Id device-->"+AV13DeviceId+"<--" );
         AV11Device.Load(AV13DeviceId);
         if ( AV16GroupSelected )
         {
            AV12DeviceGroup = new SdtDevices_Group(context);
            AV12DeviceGroup.gxTpr_Groupid = AV8GroupId;
            AV11Device.gxTpr_Group.Add(AV12DeviceGroup, 0);
            new GeneXus.Core.genexus.common.notifications.adddevicegroups(context ).execute(  AV18NotificationConfiguration,  AV11Device.gxTpr_Devicetoken,  AV17groupsnames, out  AV19OutMessages, out  AV10IsSuccess) ;
         }
         else
         {
            AV11Device.gxTpr_Group.RemoveByKey(AV8GroupId) ;
            new GeneXus.Core.genexus.common.notifications.removedevicegroups(context ).execute(  AV18NotificationConfiguration,  AV11Device.gxTpr_Devicetoken,  AV17groupsnames, out  AV19OutMessages, out  AV10IsSuccess) ;
         }
         AV11Device.Save();
         if ( AV11Device.Success() && AV10IsSuccess )
         {
            context.CommitDataStores("addremovedevicefromgroup",pr_default);
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
         AV18NotificationConfiguration = new GeneXus.Core.genexus.common.notifications.SdtConfiguration(context);
         AV17groupsnames = new GxSimpleCollection<String>();
         AV11Device = new SdtDevices(context);
         AV12DeviceGroup = new SdtDevices_Group(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.addremovedevicefromgroup__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8GroupId ;
      private String AV9GroupName ;
      private bool AV16GroupSelected ;
      private bool AV10IsSuccess ;
      private String AV13DeviceId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private GXBaseCollection<SdtMessages_Message> aP4_OutMessages ;
      private GxSimpleCollection<String> AV17groupsnames ;
      private GXBaseCollection<SdtMessages_Message> AV19OutMessages ;
      private SdtDevices AV11Device ;
      private SdtDevices_Group AV12DeviceGroup ;
      private GeneXus.Core.genexus.common.notifications.SdtConfiguration AV18NotificationConfiguration ;
   }

   public class addremovedevicefromgroup__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
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
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.addremovedevicefromgroup_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class addremovedevicefromgroup_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( bool GroupSelected ,
                         String DeviceId ,
                         short GroupId ,
                         String GroupName ,
                         out GxGenericCollection<SdtMessages_Message_RESTInterface> OutMessages )
    {
       OutMessages = new GxGenericCollection<SdtMessages_Message_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("addremovedevicefromgroup") )
          {
             return  ;
          }
          addremovedevicefromgroup worker = new addremovedevicefromgroup(context) ;
          worker.IsMain = RunAsMain ;
          GXBaseCollection<SdtMessages_Message> gxrOutMessages = new GXBaseCollection<SdtMessages_Message>() ;
          worker.execute(GroupSelected,DeviceId,GroupId,GroupName,out gxrOutMessages );
          worker.cleanup( );
          OutMessages = new GxGenericCollection<SdtMessages_Message_RESTInterface>(gxrOutMessages) ;
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
