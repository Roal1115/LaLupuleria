/*
               File: Devices_BC
        Description: Devices
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:49.67
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class devices_bc : GXHttpHandler, IGxSilentTrn
   {
      public devices_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public devices_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z1DeviceId = A1DeviceId;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode;
            CONFIRM_012( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode1;
               IsConfirmed = 1;
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
         }
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_2_idx = 0;
         while ( nGXsfl_2_idx < bcDevices.gxTpr_Group.Count )
         {
            ReadRow012( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound2 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        if ( AnyError == 0 )
                        {
                           ZM012( 3) ;
                        }
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1;
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                     {
                        Gx_mode = "DLT";
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls012( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              if ( AnyError == 0 )
                              {
                                 ZM012( 3) ;
                              }
                              CloseExtendedTableCursors012( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               VarsToRow2( ((SdtDevices_Group)bcDevices.gxTpr_Group.Item(nGXsfl_2_idx))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void E12012( )
      {
         /* Start Routine */
      }

      protected void E11012( )
      {
         /* After Trn Routine */
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z19DeviceType = A19DeviceType;
            Z20DeviceToken = A20DeviceToken;
            Z21DeviceName = A21DeviceName;
         }
         if ( GX_JID == -1 )
         {
            Z1DeviceId = A1DeviceId;
            Z19DeviceType = A19DeviceType;
            Z20DeviceToken = A20DeviceToken;
            Z21DeviceName = A21DeviceName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load011( )
      {
         /* Using cursor BC00017 */
         pr_default.execute(5, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
            A19DeviceType = BC00017_A19DeviceType[0];
            A20DeviceToken = BC00017_A20DeviceToken[0];
            A21DeviceName = BC00017_A21DeviceName[0];
            ZM011( -1) ;
         }
         pr_default.close(5);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00018 */
         pr_default.execute(6, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00016 */
         pr_default.execute(4, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM011( 1) ;
            RcdFound1 = 1;
            A1DeviceId = BC00016_A1DeviceId[0];
            A19DeviceType = BC00016_A19DeviceType[0];
            A20DeviceToken = BC00016_A20DeviceToken[0];
            A21DeviceName = BC00016_A21DeviceName[0];
            Z1DeviceId = A1DeviceId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_010( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00015 */
            pr_default.execute(3, new Object[] {A1DeviceId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Devices"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z19DeviceType != BC00015_A19DeviceType[0] ) || ( StringUtil.StrCmp(Z20DeviceToken, BC00015_A20DeviceToken[0]) != 0 ) || ( StringUtil.StrCmp(Z21DeviceName, BC00015_A21DeviceName[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Devices"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00019 */
                     pr_default.execute(7, new Object[] {A1DeviceId, A19DeviceType, A20DeviceToken, A21DeviceName});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000110 */
                     pr_default.execute(8, new Object[] {A19DeviceType, A20DeviceToken, A21DeviceName, A1DeviceId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Devices"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  ScanKeyStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanKeyNext012( ) ;
                  }
                  ScanKeyEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000111 */
                     pr_default.execute(9, new Object[] {A1DeviceId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_2_idx = 0;
         while ( nGXsfl_2_idx < bcDevices.gxTpr_Group.Count )
         {
            ReadRow012( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound2 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
               {
                  Gx_mode = "INS";
                  Insert012( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                  {
                     Gx_mode = "DLT";
                     Delete012( ) ;
                  }
                  else
                  {
                     Gx_mode = "UPD";
                     Update012( ) ;
                  }
               }
            }
            KeyVarsToRow2( ((SdtDevices_Group)bcDevices.gxTpr_Group.Item(nGXsfl_2_idx))) ;
         }
         if ( AnyError == 0 )
         {
            /* Batch update SDT rows */
            nGXsfl_2_idx = 0;
            while ( nGXsfl_2_idx < bcDevices.gxTpr_Group.Count )
            {
               ReadRow012( ) ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                  }
                  else
                  {
                     Gx_mode = "UPD";
                  }
               }
               /* Update SDT row */
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  bcDevices.gxTpr_Group.RemoveElement(nGXsfl_2_idx);
                  nGXsfl_2_idx = (short)(nGXsfl_2_idx-1);
               }
               else
               {
                  Gx_mode = "UPD";
                  getByPrimaryKey012( ) ;
                  VarsToRow2( ((SdtDevices_Group)bcDevices.gxTpr_Group.Item(nGXsfl_2_idx))) ;
               }
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll012( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         Gxremove2 = 0;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel012( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         /* ' Update level parameters */
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart011( )
      {
         /* Scan By routine */
         /* Using cursor BC000112 */
         pr_default.execute(10, new Object[] {A1DeviceId});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A1DeviceId = BC000112_A1DeviceId[0];
            A19DeviceType = BC000112_A19DeviceType[0];
            A20DeviceToken = BC000112_A20DeviceToken[0];
            A21DeviceName = BC000112_A21DeviceName[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A1DeviceId = BC000112_A1DeviceId[0];
            A19DeviceType = BC000112_A19DeviceType[0];
            A20DeviceToken = BC000112_A20DeviceToken[0];
            A21DeviceName = BC000112_A21DeviceName[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z22GroupName = A22GroupName;
         }
         if ( GX_JID == -2 )
         {
            Z1DeviceId = A1DeviceId;
            Z6GroupId = A6GroupId;
            Z22GroupName = A22GroupName;
         }
      }

      protected void standaloneNotModal012( )
      {
      }

      protected void standaloneModal012( )
      {
      }

      protected void Load012( )
      {
         /* Using cursor BC000113 */
         pr_default.execute(11, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound2 = 1;
            A22GroupName = BC000113_A22GroupName[0];
            ZM012( -2) ;
         }
         pr_default.close(11);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         Gx_BScreen = 1;
         standaloneModal012( ) ;
         Gx_BScreen = 0;
         /* Using cursor BC00014 */
         pr_default.execute(2, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Group Id'.", "ForeignKeyNotFound", 1, "GROUPID");
            AnyError = 1;
         }
         A22GroupName = BC00014_A22GroupName[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors012( )
      {
         pr_default.close(2);
      }

      protected void enableDisable012( )
      {
      }

      protected void GetKey012( )
      {
         /* Using cursor BC000114 */
         pr_default.execute(12, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(12);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM012( 2) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A6GroupId = BC00013_A6GroupId[0];
            Z1DeviceId = A1DeviceId;
            Z6GroupId = A6GroupId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal012( ) ;
            Load012( ) ;
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal012( ) ;
            Gx_mode = sMode2;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes012( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {A1DeviceId, A6GroupId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DevicesGroup"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"DevicesGroup"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000115 */
                     pr_default.execute(13, new Object[] {A1DeviceId, A6GroupId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("DevicesGroup") ;
                     if ( (pr_default.getStatus(13) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [DevicesGroup] */
                     DeferredUpdate012( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey012( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT";
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls012( ) ;
            AfterConfirm012( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete012( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000116 */
                  pr_default.execute(14, new Object[] {A1DeviceId, A6GroupId});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("DevicesGroup") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel012( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000117 */
            pr_default.execute(15, new Object[] {A6GroupId});
            A22GroupName = BC000117_A22GroupName[0];
            pr_default.close(15);
         }
      }

      protected void EndLevel012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart012( )
      {
         /* Scan By routine */
         /* Using cursor BC000118 */
         pr_default.execute(16, new Object[] {A1DeviceId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
            A22GroupName = BC000118_A22GroupName[0];
            A6GroupId = BC000118_A6GroupId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound2 = 0;
         ScanKeyLoad012( ) ;
      }

      protected void ScanKeyLoad012( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
            A22GroupName = BC000118_A22GroupName[0];
            A6GroupId = BC000118_A6GroupId[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd012( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes012( )
      {
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bcDevices) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bcDevices, 1) ;
      }

      protected void AddRow012( )
      {
         SdtDevices_Group obj2 ;
         obj2 = new SdtDevices_Group(context);
         VarsToRow2( obj2) ;
         bcDevices.gxTpr_Group.Add(obj2, 0);
         obj2.gxTpr_Mode = "UPD";
         obj2.gxTpr_Modified = 0;
      }

      protected void ReadRow012( )
      {
         nGXsfl_2_idx = (short)(nGXsfl_2_idx+1);
         RowToVars2( ((SdtDevices_Group)bcDevices.gxTpr_Group.Item(nGXsfl_2_idx)), 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A19DeviceType = 0;
         A20DeviceToken = "";
         A21DeviceName = "";
         Z19DeviceType = 0;
         Z20DeviceToken = "";
         Z21DeviceName = "";
      }

      protected void InitAll011( )
      {
         A1DeviceId = "";
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey012( )
      {
         A22GroupName = "";
      }

      protected void InitAll012( )
      {
         A6GroupId = 0;
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
      {
      }

      public void VarsToRow1( SdtDevices obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Devicetype = A19DeviceType;
         obj1.gxTpr_Devicetoken = A20DeviceToken;
         obj1.gxTpr_Devicename = A21DeviceName;
         obj1.gxTpr_Deviceid = A1DeviceId;
         obj1.gxTpr_Deviceid_Z = Z1DeviceId;
         obj1.gxTpr_Devicetype_Z = Z19DeviceType;
         obj1.gxTpr_Devicetoken_Z = Z20DeviceToken;
         obj1.gxTpr_Devicename_Z = Z21DeviceName;
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( SdtDevices obj1 )
      {
         obj1.gxTpr_Deviceid = A1DeviceId;
         return  ;
      }

      public void RowToVars1( SdtDevices obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         if ( forceLoad == 1 )
         {
            A19DeviceType = obj1.gxTpr_Devicetype;
         }
         if ( forceLoad == 1 )
         {
            A20DeviceToken = obj1.gxTpr_Devicetoken;
         }
         if ( forceLoad == 1 )
         {
            A21DeviceName = obj1.gxTpr_Devicename;
         }
         if ( forceLoad == 1 )
         {
            A1DeviceId = obj1.gxTpr_Deviceid;
         }
         Z1DeviceId = obj1.gxTpr_Deviceid_Z;
         Z19DeviceType = obj1.gxTpr_Devicetype_Z;
         Z20DeviceToken = obj1.gxTpr_Devicetoken_Z;
         Z21DeviceName = obj1.gxTpr_Devicename_Z;
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void VarsToRow2( SdtDevices_Group obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Groupname = A22GroupName;
         obj2.gxTpr_Groupid = A6GroupId;
         obj2.gxTpr_Groupid_Z = Z6GroupId;
         obj2.gxTpr_Groupname_Z = Z22GroupName;
         obj2.gxTpr_Modified = nIsMod_2;
         return  ;
      }

      public void KeyVarsToRow2( SdtDevices_Group obj2 )
      {
         obj2.gxTpr_Groupid = A6GroupId;
         return  ;
      }

      public void RowToVars2( SdtDevices_Group obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A22GroupName = obj2.gxTpr_Groupname;
         A6GroupId = obj2.gxTpr_Groupid;
         Z6GroupId = obj2.gxTpr_Groupid_Z;
         Z22GroupName = obj2.gxTpr_Groupname_Z;
         nIsMod_2 = obj2.gxTpr_Modified;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1DeviceId = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1DeviceId = A1DeviceId;
         }
         ZM011( -1) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         bcDevices.gxTpr_Group.ClearCollection();
         if ( RcdFound1 == 1 )
         {
            ScanKeyStart012( ) ;
            nGXsfl_2_idx = 1;
            while ( RcdFound2 != 0 )
            {
               Z1DeviceId = A1DeviceId;
               Z6GroupId = A6GroupId;
               ZM012( -2) ;
               OnLoadActions012( ) ;
               nRcdExists_2 = 1;
               nIsMod_2 = 0;
               AddRow012( ) ;
               nGXsfl_2_idx = (short)(nGXsfl_2_idx+1);
               ScanKeyNext012( ) ;
            }
            ScanKeyEnd012( ) ;
         }
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars1( bcDevices, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1DeviceId = A1DeviceId;
         }
         ZM011( -1) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         bcDevices.gxTpr_Group.ClearCollection();
         if ( RcdFound1 == 1 )
         {
            ScanKeyStart012( ) ;
            nGXsfl_2_idx = 1;
            while ( RcdFound2 != 0 )
            {
               Z1DeviceId = A1DeviceId;
               Z6GroupId = A6GroupId;
               ZM012( -2) ;
               OnLoadActions012( ) ;
               nRcdExists_2 = 1;
               nIsMod_2 = 0;
               AddRow012( ) ;
               nGXsfl_2_idx = (short)(nGXsfl_2_idx+1);
               ScanKeyNext012( ) ;
            }
            ScanKeyEnd012( ) ;
         }
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
               {
                  A1DeviceId = Z1DeviceId;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update011( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert011( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert011( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars1( bcDevices, 0) ;
         SaveImpl( ) ;
         VarsToRow1( bcDevices) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars1( bcDevices, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         AfterTrn( ) ;
         VarsToRow1( bcDevices) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtDevices auxBC = new SdtDevices(context) ;
            auxBC.Load(A1DeviceId);
            auxBC.UpdateDirties(bcDevices);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars1( bcDevices, 0) ;
         UpdateImpl( ) ;
         VarsToRow1( bcDevices) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars1( bcDevices, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow1( bcDevices) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bcDevices, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
            {
               A1DeviceId = Z1DeviceId;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(4);
         pr_default.close(1);
         pr_default.close(15);
         context.RollbackDataStores("devices_bc",pr_default);
         VarsToRow1( bcDevices) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcDevices.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcDevices.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcDevices )
         {
            bcDevices = (SdtDevices)(sdt);
            if ( StringUtil.StrCmp(bcDevices.gxTpr_Mode, "") == 0 )
            {
               bcDevices.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bcDevices) ;
            }
            else
            {
               RowToVars1( bcDevices, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcDevices.gxTpr_Mode, "") == 0 )
            {
               bcDevices.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bcDevices, 1) ;
         return  ;
      }

      public SdtDevices Devices_BC
      {
         get {
            return bcDevices ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(15);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z1DeviceId = "";
         A1DeviceId = "";
         sMode1 = "";
         Z20DeviceToken = "";
         A20DeviceToken = "";
         Z21DeviceName = "";
         A21DeviceName = "";
         BC00017_A1DeviceId = new String[] {""} ;
         BC00017_A19DeviceType = new short[1] ;
         BC00017_A20DeviceToken = new String[] {""} ;
         BC00017_A21DeviceName = new String[] {""} ;
         BC00018_A1DeviceId = new String[] {""} ;
         BC00016_A1DeviceId = new String[] {""} ;
         BC00016_A19DeviceType = new short[1] ;
         BC00016_A20DeviceToken = new String[] {""} ;
         BC00016_A21DeviceName = new String[] {""} ;
         BC00015_A1DeviceId = new String[] {""} ;
         BC00015_A19DeviceType = new short[1] ;
         BC00015_A20DeviceToken = new String[] {""} ;
         BC00015_A21DeviceName = new String[] {""} ;
         BC000112_A1DeviceId = new String[] {""} ;
         BC000112_A19DeviceType = new short[1] ;
         BC000112_A20DeviceToken = new String[] {""} ;
         BC000112_A21DeviceName = new String[] {""} ;
         Z22GroupName = "";
         A22GroupName = "";
         BC000113_A1DeviceId = new String[] {""} ;
         BC000113_A22GroupName = new String[] {""} ;
         BC000113_A6GroupId = new short[1] ;
         BC00014_A22GroupName = new String[] {""} ;
         BC000114_A1DeviceId = new String[] {""} ;
         BC000114_A6GroupId = new short[1] ;
         BC00013_A1DeviceId = new String[] {""} ;
         BC00013_A6GroupId = new short[1] ;
         sMode2 = "";
         BC00012_A1DeviceId = new String[] {""} ;
         BC00012_A6GroupId = new short[1] ;
         BC000117_A22GroupName = new String[] {""} ;
         BC000118_A1DeviceId = new String[] {""} ;
         BC000118_A22GroupName = new String[] {""} ;
         BC000118_A6GroupId = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.devices_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A1DeviceId, BC00012_A6GroupId
               }
               , new Object[] {
               BC00013_A1DeviceId, BC00013_A6GroupId
               }
               , new Object[] {
               BC00014_A22GroupName
               }
               , new Object[] {
               BC00015_A1DeviceId, BC00015_A19DeviceType, BC00015_A20DeviceToken, BC00015_A21DeviceName
               }
               , new Object[] {
               BC00016_A1DeviceId, BC00016_A19DeviceType, BC00016_A20DeviceToken, BC00016_A21DeviceName
               }
               , new Object[] {
               BC00017_A1DeviceId, BC00017_A19DeviceType, BC00017_A20DeviceToken, BC00017_A21DeviceName
               }
               , new Object[] {
               BC00018_A1DeviceId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000112_A1DeviceId, BC000112_A19DeviceType, BC000112_A20DeviceToken, BC000112_A21DeviceName
               }
               , new Object[] {
               BC000113_A1DeviceId, BC000113_A22GroupName, BC000113_A6GroupId
               }
               , new Object[] {
               BC000114_A1DeviceId, BC000114_A6GroupId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000117_A22GroupName
               }
               , new Object[] {
               BC000118_A1DeviceId, BC000118_A22GroupName, BC000118_A6GroupId
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12012 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short nGXsfl_2_idx=1 ;
      private short nIsMod_2 ;
      private short RcdFound2 ;
      private short GX_JID ;
      private short Z19DeviceType ;
      private short A19DeviceType ;
      private short RcdFound1 ;
      private short nRcdExists_2 ;
      private short Gxremove2 ;
      private short Z6GroupId ;
      private short A6GroupId ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode1 ;
      private String Z22GroupName ;
      private String A22GroupName ;
      private String sMode2 ;
      private String Z1DeviceId ;
      private String A1DeviceId ;
      private String Z20DeviceToken ;
      private String A20DeviceToken ;
      private String Z21DeviceName ;
      private String A21DeviceName ;
      private SdtDevices bcDevices ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00017_A1DeviceId ;
      private short[] BC00017_A19DeviceType ;
      private String[] BC00017_A20DeviceToken ;
      private String[] BC00017_A21DeviceName ;
      private String[] BC00018_A1DeviceId ;
      private String[] BC00016_A1DeviceId ;
      private short[] BC00016_A19DeviceType ;
      private String[] BC00016_A20DeviceToken ;
      private String[] BC00016_A21DeviceName ;
      private String[] BC00015_A1DeviceId ;
      private short[] BC00015_A19DeviceType ;
      private String[] BC00015_A20DeviceToken ;
      private String[] BC00015_A21DeviceName ;
      private String[] BC000112_A1DeviceId ;
      private short[] BC000112_A19DeviceType ;
      private String[] BC000112_A20DeviceToken ;
      private String[] BC000112_A21DeviceName ;
      private String[] BC000113_A1DeviceId ;
      private String[] BC000113_A22GroupName ;
      private short[] BC000113_A6GroupId ;
      private String[] BC00014_A22GroupName ;
      private String[] BC000114_A1DeviceId ;
      private short[] BC000114_A6GroupId ;
      private String[] BC00013_A1DeviceId ;
      private short[] BC00013_A6GroupId ;
      private String[] BC00012_A1DeviceId ;
      private short[] BC00012_A6GroupId ;
      private String[] BC000117_A22GroupName ;
      private String[] BC000118_A1DeviceId ;
      private String[] BC000118_A22GroupName ;
      private short[] BC000118_A6GroupId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class devices_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00017 ;
          prmBC00017 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC00018 ;
          prmBC00018 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC00016 ;
          prmBC00016 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC00015 ;
          prmBC00015 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC00019 ;
          prmBC00019 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceType",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC000110 ;
          prmBC000110 = new Object[] {
          new Object[] {"@DeviceType",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC000111 ;
          prmBC000111 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC000112 ;
          prmBC000112 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmBC000113 ;
          prmBC000113 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00014 ;
          prmBC00014 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000114 ;
          prmBC000114 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00013 ;
          prmBC00013 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00012 ;
          prmBC00012 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000115 ;
          prmBC000115 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000116 ;
          prmBC000116 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000117 ;
          prmBC000117 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000118 ;
          prmBC000118 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00012", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (UPDLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1,0,true,false )
             ,new CursorDef("BC00013", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1,0,true,false )
             ,new CursorDef("BC00014", "SELECT [GroupName] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,1,0,true,false )
             ,new CursorDef("BC00015", "SELECT [DeviceId], [DeviceType], [DeviceToken], [DeviceName] FROM [Devices] WITH (UPDLOCK) WHERE [DeviceId] = @DeviceId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,1,0,true,false )
             ,new CursorDef("BC00016", "SELECT [DeviceId], [DeviceType], [DeviceToken], [DeviceName] FROM [Devices] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00016,1,0,true,false )
             ,new CursorDef("BC00017", "SELECT TM1.[DeviceId], TM1.[DeviceType], TM1.[DeviceToken], TM1.[DeviceName] FROM [Devices] TM1 WITH (NOLOCK) WHERE TM1.[DeviceId] = @DeviceId ORDER BY TM1.[DeviceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00017,100,0,true,false )
             ,new CursorDef("BC00018", "SELECT [DeviceId] FROM [Devices] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00018,1,0,true,false )
             ,new CursorDef("BC00019", "INSERT INTO [Devices]([DeviceId], [DeviceType], [DeviceToken], [DeviceName]) VALUES(@DeviceId, @DeviceType, @DeviceToken, @DeviceName)", GxErrorMask.GX_NOMASK,prmBC00019)
             ,new CursorDef("BC000110", "UPDATE [Devices] SET [DeviceType]=@DeviceType, [DeviceToken]=@DeviceToken, [DeviceName]=@DeviceName  WHERE [DeviceId] = @DeviceId", GxErrorMask.GX_NOMASK,prmBC000110)
             ,new CursorDef("BC000111", "DELETE FROM [Devices]  WHERE [DeviceId] = @DeviceId", GxErrorMask.GX_NOMASK,prmBC000111)
             ,new CursorDef("BC000112", "SELECT TM1.[DeviceId], TM1.[DeviceType], TM1.[DeviceToken], TM1.[DeviceName] FROM [Devices] TM1 WITH (NOLOCK) WHERE TM1.[DeviceId] = @DeviceId ORDER BY TM1.[DeviceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000112,100,0,true,false )
             ,new CursorDef("BC000113", "SELECT T1.[DeviceId], T2.[GroupName], T1.[GroupId] FROM ([DevicesGroup] T1 WITH (NOLOCK) INNER JOIN [Group] T2 WITH (NOLOCK) ON T2.[GroupId] = T1.[GroupId]) WHERE T1.[DeviceId] = @DeviceId and T1.[GroupId] = @GroupId ORDER BY T1.[DeviceId], T1.[GroupId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000113,11,0,true,false )
             ,new CursorDef("BC000114", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000114,1,0,true,false )
             ,new CursorDef("BC000115", "INSERT INTO [DevicesGroup]([DeviceId], [GroupId]) VALUES(@DeviceId, @GroupId)", GxErrorMask.GX_NOMASK,prmBC000115)
             ,new CursorDef("BC000116", "DELETE FROM [DevicesGroup]  WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId", GxErrorMask.GX_NOMASK,prmBC000116)
             ,new CursorDef("BC000117", "SELECT [GroupName] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000117,1,0,true,false )
             ,new CursorDef("BC000118", "SELECT T1.[DeviceId], T2.[GroupName], T1.[GroupId] FROM ([DevicesGroup] T1 WITH (NOLOCK) INNER JOIN [Group] T2 WITH (NOLOCK) ON T2.[GroupId] = T1.[GroupId]) WHERE T1.[DeviceId] = @DeviceId ORDER BY T1.[DeviceId], T1.[GroupId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000118,11,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
