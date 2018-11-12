/*
               File: Group_BC
        Description: Group
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:39.81
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
   public class group_bc : GXHttpHandler, IGxSilentTrn
   {
      public group_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public group_bc( IGxContext context )
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
         ReadRow0B8( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0B8( ) ;
         standaloneModal( ) ;
         AddRow0B8( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z6GroupId = A6GroupId;
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

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B8( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0B8( ) ;
            }
            else
            {
               CheckExtendedTable0B8( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0B8( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0B8( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z22GroupName = A22GroupName;
            Z31GroupDescription = A31GroupDescription;
         }
         if ( GX_JID == -1 )
         {
            Z6GroupId = A6GroupId;
            Z22GroupName = A22GroupName;
            Z31GroupDescription = A31GroupDescription;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0B8( )
      {
         /* Using cursor BC000B4 */
         pr_default.execute(2, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound8 = 1;
            A22GroupName = BC000B4_A22GroupName[0];
            A31GroupDescription = BC000B4_A31GroupDescription[0];
            ZM0B8( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0B8( ) ;
      }

      protected void OnLoadActions0B8( )
      {
      }

      protected void CheckExtendedTable0B8( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0B8( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0B8( )
      {
         /* Using cursor BC000B5 */
         pr_default.execute(3, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000B3 */
         pr_default.execute(1, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B8( 1) ;
            RcdFound8 = 1;
            A6GroupId = BC000B3_A6GroupId[0];
            A22GroupName = BC000B3_A22GroupName[0];
            A31GroupDescription = BC000B3_A31GroupDescription[0];
            Z6GroupId = A6GroupId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0B8( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey0B8( ) ;
            }
            Gx_mode = sMode8;
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey0B8( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode8;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B8( ) ;
         if ( RcdFound8 == 0 )
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
         CONFIRM_0B0( ) ;
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

      protected void CheckOptimisticConcurrency0B8( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000B2 */
            pr_default.execute(0, new Object[] {A6GroupId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Group"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z22GroupName, BC000B2_A22GroupName[0]) != 0 ) || ( StringUtil.StrCmp(Z31GroupDescription, BC000B2_A31GroupDescription[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Group"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B8( )
      {
         BeforeValidate0B8( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B8( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B8( 0) ;
            CheckOptimisticConcurrency0B8( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B8( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B8( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000B6 */
                     pr_default.execute(4, new Object[] {A22GroupName, A31GroupDescription});
                     A6GroupId = BC000B6_A6GroupId[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("Group") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
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
               Load0B8( ) ;
            }
            EndLevel0B8( ) ;
         }
         CloseExtendedTableCursors0B8( ) ;
      }

      protected void Update0B8( )
      {
         BeforeValidate0B8( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B8( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B8( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B8( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B8( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000B7 */
                     pr_default.execute(5, new Object[] {A22GroupName, A31GroupDescription, A6GroupId});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("Group") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Group"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B8( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
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
            EndLevel0B8( ) ;
         }
         CloseExtendedTableCursors0B8( ) ;
      }

      protected void DeferredUpdate0B8( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0B8( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B8( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B8( ) ;
            AfterConfirm0B8( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B8( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000B8 */
                  pr_default.execute(6, new Object[] {A6GroupId});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("Group") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0B8( ) ;
         Gx_mode = sMode8;
      }

      protected void OnDeleteControls0B8( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000B9 */
            pr_default.execute(7, new Object[] {A6GroupId});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Group"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel0B8( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B8( ) ;
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

      public void ScanKeyStart0B8( )
      {
         /* Using cursor BC000B10 */
         pr_default.execute(8, new Object[] {A6GroupId});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound8 = 1;
            A6GroupId = BC000B10_A6GroupId[0];
            A22GroupName = BC000B10_A22GroupName[0];
            A31GroupDescription = BC000B10_A31GroupDescription[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0B8( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound8 = 0;
         ScanKeyLoad0B8( ) ;
      }

      protected void ScanKeyLoad0B8( )
      {
         sMode8 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound8 = 1;
            A6GroupId = BC000B10_A6GroupId[0];
            A22GroupName = BC000B10_A22GroupName[0];
            A31GroupDescription = BC000B10_A31GroupDescription[0];
         }
         Gx_mode = sMode8;
      }

      protected void ScanKeyEnd0B8( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0B8( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B8( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B8( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B8( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B8( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B8( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B8( )
      {
      }

      protected void send_integrity_lvl_hashes0B8( )
      {
      }

      protected void AddRow0B8( )
      {
         VarsToRow8( bcGroup) ;
      }

      protected void ReadRow0B8( )
      {
         RowToVars8( bcGroup, 1) ;
      }

      protected void InitializeNonKey0B8( )
      {
         A22GroupName = "";
         A31GroupDescription = "";
         Z22GroupName = "";
         Z31GroupDescription = "";
      }

      protected void InitAll0B8( )
      {
         A6GroupId = 0;
         InitializeNonKey0B8( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow8( SdtGroup obj8 )
      {
         obj8.gxTpr_Mode = Gx_mode;
         obj8.gxTpr_Groupname = A22GroupName;
         obj8.gxTpr_Groupdescription = A31GroupDescription;
         obj8.gxTpr_Groupid = A6GroupId;
         obj8.gxTpr_Groupid_Z = Z6GroupId;
         obj8.gxTpr_Groupname_Z = Z22GroupName;
         obj8.gxTpr_Groupdescription_Z = Z31GroupDescription;
         obj8.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow8( SdtGroup obj8 )
      {
         obj8.gxTpr_Groupid = A6GroupId;
         return  ;
      }

      public void RowToVars8( SdtGroup obj8 ,
                              int forceLoad )
      {
         Gx_mode = obj8.gxTpr_Mode;
         A22GroupName = obj8.gxTpr_Groupname;
         A31GroupDescription = obj8.gxTpr_Groupdescription;
         if ( forceLoad == 1 )
         {
            A6GroupId = obj8.gxTpr_Groupid;
         }
         Z6GroupId = obj8.gxTpr_Groupid_Z;
         Z22GroupName = obj8.gxTpr_Groupname_Z;
         Z31GroupDescription = obj8.gxTpr_Groupdescription_Z;
         Gx_mode = obj8.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A6GroupId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0B8( ) ;
         ScanKeyStart0B8( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6GroupId = A6GroupId;
         }
         ZM0B8( -1) ;
         OnLoadActions0B8( ) ;
         AddRow0B8( ) ;
         ScanKeyEnd0B8( ) ;
         if ( RcdFound8 == 0 )
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
         RowToVars8( bcGroup, 0) ;
         ScanKeyStart0B8( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6GroupId = A6GroupId;
         }
         ZM0B8( -1) ;
         OnLoadActions0B8( ) ;
         AddRow0B8( ) ;
         ScanKeyEnd0B8( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0B8( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0B8( ) ;
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A6GroupId != Z6GroupId )
               {
                  A6GroupId = Z6GroupId;
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
                  Update0B8( ) ;
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
                  if ( A6GroupId != Z6GroupId )
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
                        Insert0B8( ) ;
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
                        Insert0B8( ) ;
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
         RowToVars8( bcGroup, 0) ;
         SaveImpl( ) ;
         VarsToRow8( bcGroup) ;
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
         RowToVars8( bcGroup, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0B8( ) ;
         AfterTrn( ) ;
         VarsToRow8( bcGroup) ;
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
            SdtGroup auxBC = new SdtGroup(context) ;
            auxBC.Load(A6GroupId);
            auxBC.UpdateDirties(bcGroup);
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
         RowToVars8( bcGroup, 0) ;
         UpdateImpl( ) ;
         VarsToRow8( bcGroup) ;
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
         RowToVars8( bcGroup, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0B8( ) ;
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
         VarsToRow8( bcGroup) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars8( bcGroup, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0B8( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A6GroupId != Z6GroupId )
            {
               A6GroupId = Z6GroupId;
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
            if ( A6GroupId != Z6GroupId )
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
         pr_default.close(1);
         context.RollbackDataStores("group_bc",pr_default);
         VarsToRow8( bcGroup) ;
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
         Gx_mode = bcGroup.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcGroup.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcGroup )
         {
            bcGroup = (SdtGroup)(sdt);
            if ( StringUtil.StrCmp(bcGroup.gxTpr_Mode, "") == 0 )
            {
               bcGroup.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow8( bcGroup) ;
            }
            else
            {
               RowToVars8( bcGroup, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcGroup.gxTpr_Mode, "") == 0 )
            {
               bcGroup.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars8( bcGroup, 1) ;
         return  ;
      }

      public SdtGroup Group_BC
      {
         get {
            return bcGroup ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z22GroupName = "";
         A22GroupName = "";
         Z31GroupDescription = "";
         A31GroupDescription = "";
         BC000B4_A6GroupId = new short[1] ;
         BC000B4_A22GroupName = new String[] {""} ;
         BC000B4_A31GroupDescription = new String[] {""} ;
         BC000B5_A6GroupId = new short[1] ;
         BC000B3_A6GroupId = new short[1] ;
         BC000B3_A22GroupName = new String[] {""} ;
         BC000B3_A31GroupDescription = new String[] {""} ;
         sMode8 = "";
         BC000B2_A6GroupId = new short[1] ;
         BC000B2_A22GroupName = new String[] {""} ;
         BC000B2_A31GroupDescription = new String[] {""} ;
         BC000B6_A6GroupId = new short[1] ;
         BC000B9_A1DeviceId = new String[] {""} ;
         BC000B9_A6GroupId = new short[1] ;
         BC000B10_A6GroupId = new short[1] ;
         BC000B10_A22GroupName = new String[] {""} ;
         BC000B10_A31GroupDescription = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.group_bc__default(),
            new Object[][] {
                new Object[] {
               BC000B2_A6GroupId, BC000B2_A22GroupName, BC000B2_A31GroupDescription
               }
               , new Object[] {
               BC000B3_A6GroupId, BC000B3_A22GroupName, BC000B3_A31GroupDescription
               }
               , new Object[] {
               BC000B4_A6GroupId, BC000B4_A22GroupName, BC000B4_A31GroupDescription
               }
               , new Object[] {
               BC000B5_A6GroupId
               }
               , new Object[] {
               BC000B6_A6GroupId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000B9_A1DeviceId, BC000B9_A6GroupId
               }
               , new Object[] {
               BC000B10_A6GroupId, BC000B10_A22GroupName, BC000B10_A31GroupDescription
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z6GroupId ;
      private short A6GroupId ;
      private short GX_JID ;
      private short RcdFound8 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String Z22GroupName ;
      private String A22GroupName ;
      private String Z31GroupDescription ;
      private String A31GroupDescription ;
      private String sMode8 ;
      private SdtGroup bcGroup ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC000B4_A6GroupId ;
      private String[] BC000B4_A22GroupName ;
      private String[] BC000B4_A31GroupDescription ;
      private short[] BC000B5_A6GroupId ;
      private short[] BC000B3_A6GroupId ;
      private String[] BC000B3_A22GroupName ;
      private String[] BC000B3_A31GroupDescription ;
      private short[] BC000B2_A6GroupId ;
      private String[] BC000B2_A22GroupName ;
      private String[] BC000B2_A31GroupDescription ;
      private short[] BC000B6_A6GroupId ;
      private String[] BC000B9_A1DeviceId ;
      private short[] BC000B9_A6GroupId ;
      private short[] BC000B10_A6GroupId ;
      private String[] BC000B10_A22GroupName ;
      private String[] BC000B10_A31GroupDescription ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class group_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000B4 ;
          prmBC000B4 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B5 ;
          prmBC000B5 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B3 ;
          prmBC000B3 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B2 ;
          prmBC000B2 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B6 ;
          prmBC000B6 = new Object[] {
          new Object[] {"@GroupName",SqlDbType.Char,20,0} ,
          new Object[] {"@GroupDescription",SqlDbType.Char,250,0}
          } ;
          Object[] prmBC000B7 ;
          prmBC000B7 = new Object[] {
          new Object[] {"@GroupName",SqlDbType.Char,20,0} ,
          new Object[] {"@GroupDescription",SqlDbType.Char,250,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B8 ;
          prmBC000B8 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B9 ;
          prmBC000B9 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000B10 ;
          prmBC000B10 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000B2", "SELECT [GroupId], [GroupName], [GroupDescription] FROM [Group] WITH (UPDLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B2,1,0,true,false )
             ,new CursorDef("BC000B3", "SELECT [GroupId], [GroupName], [GroupDescription] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B3,1,0,true,false )
             ,new CursorDef("BC000B4", "SELECT TM1.[GroupId], TM1.[GroupName], TM1.[GroupDescription] FROM [Group] TM1 WITH (NOLOCK) WHERE TM1.[GroupId] = @GroupId ORDER BY TM1.[GroupId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B4,100,0,true,false )
             ,new CursorDef("BC000B5", "SELECT [GroupId] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B5,1,0,true,false )
             ,new CursorDef("BC000B6", "INSERT INTO [Group]([GroupName], [GroupDescription]) VALUES(@GroupName, @GroupDescription); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000B6)
             ,new CursorDef("BC000B7", "UPDATE [Group] SET [GroupName]=@GroupName, [GroupDescription]=@GroupDescription  WHERE [GroupId] = @GroupId", GxErrorMask.GX_NOMASK,prmBC000B7)
             ,new CursorDef("BC000B8", "DELETE FROM [Group]  WHERE [GroupId] = @GroupId", GxErrorMask.GX_NOMASK,prmBC000B8)
             ,new CursorDef("BC000B9", "SELECT TOP 1 [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B9,1,0,true,true )
             ,new CursorDef("BC000B10", "SELECT TM1.[GroupId], TM1.[GroupName], TM1.[GroupDescription] FROM [Group] TM1 WITH (NOLOCK) WHERE TM1.[GroupId] = @GroupId ORDER BY TM1.[GroupId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B10,100,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 250) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 250) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 250) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 250) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
