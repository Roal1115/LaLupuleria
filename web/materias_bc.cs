/*
               File: Materias_BC
        Description: Materias
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:35.32
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class materias_bc : GXHttpHandler, IGxSilentTrn
   {
      public materias_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public materias_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtMaterias> GetAll( int Start ,
                                                 int Count )
      {
         GXPagingFrom9 = Start;
         GXPagingTo9 = Count;
         /* Using cursor BC00084 */
         pr_default.execute(2, new Object[] {GXPagingFrom9, GXPagingTo9});
         RcdFound9 = 0;
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound9 = 1;
            A11MateriasId = BC00084_A11MateriasId[0];
            A48MateriasNombre = BC00084_A48MateriasNombre[0];
            A50MateriasDescripcion = BC00084_A50MateriasDescripcion[0];
            A51MateriasProfesor = BC00084_A51MateriasProfesor[0];
            A52MateriasProfCorreo = BC00084_A52MateriasProfCorreo[0];
         }
         bcMaterias = new SdtMaterias(context);
         gx_restcollection.Clear();
         while ( RcdFound9 != 0 )
         {
            OnLoadActions089( ) ;
            AddRow089( ) ;
            gx_sdt_item = (SdtMaterias)(bcMaterias.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(2);
            RcdFound9 = 0;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(2) != 101) )
            {
               RcdFound9 = 1;
               A11MateriasId = BC00084_A11MateriasId[0];
               A48MateriasNombre = BC00084_A48MateriasNombre[0];
               A50MateriasDescripcion = BC00084_A50MateriasDescripcion[0];
               A51MateriasProfesor = BC00084_A51MateriasProfesor[0];
               A52MateriasProfCorreo = BC00084_A52MateriasProfCorreo[0];
            }
            Gx_mode = sMode9;
         }
         pr_default.close(2);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM089( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow089( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey089( ) ;
         standaloneModal( ) ;
         AddRow089( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z11MateriasId = A11MateriasId;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls089( ) ;
            }
            else
            {
               CheckExtendedTable089( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors089( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12082( )
      {
         /* Start Routine */
      }

      protected void E11082( )
      {
         /* After Trn Routine */
      }

      protected void ZM089( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z48MateriasNombre = A48MateriasNombre;
            Z50MateriasDescripcion = A50MateriasDescripcion;
            Z51MateriasProfesor = A51MateriasProfesor;
            Z52MateriasProfCorreo = A52MateriasProfCorreo;
         }
         if ( GX_JID == -2 )
         {
            Z11MateriasId = A11MateriasId;
            Z48MateriasNombre = A48MateriasNombre;
            Z50MateriasDescripcion = A50MateriasDescripcion;
            Z51MateriasProfesor = A51MateriasProfesor;
            Z52MateriasProfCorreo = A52MateriasProfCorreo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load089( )
      {
         /* Using cursor BC00085 */
         pr_default.execute(3, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound9 = 1;
            A48MateriasNombre = BC00085_A48MateriasNombre[0];
            A50MateriasDescripcion = BC00085_A50MateriasDescripcion[0];
            A51MateriasProfesor = BC00085_A51MateriasProfesor[0];
            A52MateriasProfCorreo = BC00085_A52MateriasProfCorreo[0];
            ZM089( -2) ;
         }
         pr_default.close(3);
         OnLoadActions089( ) ;
      }

      protected void OnLoadActions089( )
      {
      }

      protected void CheckExtendedTable089( )
      {
         standaloneModal( ) ;
         if ( ! ( GxRegex.IsMatch(A52MateriasProfCorreo,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") ) )
         {
            GX_msglist.addItem("El valor de Materias Prof Correo no coincide con el patrón especificado", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors089( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey089( )
      {
         /* Using cursor BC00086 */
         pr_default.execute(4, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00083 */
         pr_default.execute(1, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM089( 2) ;
            RcdFound9 = 1;
            A11MateriasId = BC00083_A11MateriasId[0];
            A48MateriasNombre = BC00083_A48MateriasNombre[0];
            A50MateriasDescripcion = BC00083_A50MateriasDescripcion[0];
            A51MateriasProfesor = BC00083_A51MateriasProfesor[0];
            A52MateriasProfCorreo = BC00083_A52MateriasProfCorreo[0];
            Z11MateriasId = A11MateriasId;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load089( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey089( ) ;
            }
            Gx_mode = sMode9;
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey089( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode9;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey089( ) ;
         if ( RcdFound9 == 0 )
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
         CONFIRM_080( ) ;
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

      protected void CheckOptimisticConcurrency089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00082 */
            pr_default.execute(0, new Object[] {A11MateriasId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Materias"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z48MateriasNombre, BC00082_A48MateriasNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z50MateriasDescripcion, BC00082_A50MateriasDescripcion[0]) != 0 ) || ( StringUtil.StrCmp(Z51MateriasProfesor, BC00082_A51MateriasProfesor[0]) != 0 ) || ( StringUtil.StrCmp(Z52MateriasProfCorreo, BC00082_A52MateriasProfCorreo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Materias"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM089( 0) ;
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00087 */
                     pr_default.execute(5, new Object[] {A48MateriasNombre, A50MateriasDescripcion, A51MateriasProfesor, A52MateriasProfCorreo});
                     A11MateriasId = BC00087_A11MateriasId[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("Materias") ;
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
               Load089( ) ;
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void Update089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00088 */
                     pr_default.execute(6, new Object[] {A48MateriasNombre, A50MateriasDescripcion, A51MateriasProfesor, A52MateriasProfCorreo, A11MateriasId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Materias") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Materias"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate089( ) ;
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
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void DeferredUpdate089( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls089( ) ;
            AfterConfirm089( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete089( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00089 */
                  pr_default.execute(7, new Object[] {A11MateriasId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("Materias") ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel089( ) ;
         Gx_mode = sMode9;
      }

      protected void OnDeleteControls089( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000810 */
            pr_default.execute(8, new Object[] {A11MateriasId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Califas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete089( ) ;
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

      public void ScanKeyStart089( )
      {
         /* Scan By routine */
         /* Using cursor BC000811 */
         pr_default.execute(9, new Object[] {A11MateriasId});
         RcdFound9 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound9 = 1;
            A11MateriasId = BC000811_A11MateriasId[0];
            A48MateriasNombre = BC000811_A48MateriasNombre[0];
            A50MateriasDescripcion = BC000811_A50MateriasDescripcion[0];
            A51MateriasProfesor = BC000811_A51MateriasProfesor[0];
            A52MateriasProfCorreo = BC000811_A52MateriasProfCorreo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext089( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound9 = 0;
         ScanKeyLoad089( ) ;
      }

      protected void ScanKeyLoad089( )
      {
         sMode9 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound9 = 1;
            A11MateriasId = BC000811_A11MateriasId[0];
            A48MateriasNombre = BC000811_A48MateriasNombre[0];
            A50MateriasDescripcion = BC000811_A50MateriasDescripcion[0];
            A51MateriasProfesor = BC000811_A51MateriasProfesor[0];
            A52MateriasProfCorreo = BC000811_A52MateriasProfCorreo[0];
         }
         Gx_mode = sMode9;
      }

      protected void ScanKeyEnd089( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm089( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert089( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate089( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete089( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete089( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate089( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes089( )
      {
      }

      protected void send_integrity_lvl_hashes089( )
      {
      }

      protected void AddRow089( )
      {
         VarsToRow9( bcMaterias) ;
      }

      protected void ReadRow089( )
      {
         RowToVars9( bcMaterias, 1) ;
      }

      protected void InitializeNonKey089( )
      {
         A48MateriasNombre = "";
         A50MateriasDescripcion = "";
         A51MateriasProfesor = "";
         A52MateriasProfCorreo = "";
         Z48MateriasNombre = "";
         Z50MateriasDescripcion = "";
         Z51MateriasProfesor = "";
         Z52MateriasProfCorreo = "";
      }

      protected void InitAll089( )
      {
         A11MateriasId = 0;
         InitializeNonKey089( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow9( SdtMaterias obj9 )
      {
         obj9.gxTpr_Mode = Gx_mode;
         obj9.gxTpr_Materiasnombre = A48MateriasNombre;
         obj9.gxTpr_Materiasdescripcion = A50MateriasDescripcion;
         obj9.gxTpr_Materiasprofesor = A51MateriasProfesor;
         obj9.gxTpr_Materiasprofcorreo = A52MateriasProfCorreo;
         obj9.gxTpr_Materiasid = A11MateriasId;
         obj9.gxTpr_Materiasid_Z = Z11MateriasId;
         obj9.gxTpr_Materiasnombre_Z = Z48MateriasNombre;
         obj9.gxTpr_Materiasdescripcion_Z = Z50MateriasDescripcion;
         obj9.gxTpr_Materiasprofesor_Z = Z51MateriasProfesor;
         obj9.gxTpr_Materiasprofcorreo_Z = Z52MateriasProfCorreo;
         obj9.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow9( SdtMaterias obj9 )
      {
         obj9.gxTpr_Materiasid = A11MateriasId;
         return  ;
      }

      public void RowToVars9( SdtMaterias obj9 ,
                              int forceLoad )
      {
         Gx_mode = obj9.gxTpr_Mode;
         A48MateriasNombre = obj9.gxTpr_Materiasnombre;
         A50MateriasDescripcion = obj9.gxTpr_Materiasdescripcion;
         A51MateriasProfesor = obj9.gxTpr_Materiasprofesor;
         A52MateriasProfCorreo = obj9.gxTpr_Materiasprofcorreo;
         A11MateriasId = obj9.gxTpr_Materiasid;
         Z11MateriasId = obj9.gxTpr_Materiasid_Z;
         Z48MateriasNombre = obj9.gxTpr_Materiasnombre_Z;
         Z50MateriasDescripcion = obj9.gxTpr_Materiasdescripcion_Z;
         Z51MateriasProfesor = obj9.gxTpr_Materiasprofesor_Z;
         Z52MateriasProfCorreo = obj9.gxTpr_Materiasprofcorreo_Z;
         Gx_mode = obj9.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A11MateriasId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey089( ) ;
         ScanKeyStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z11MateriasId = A11MateriasId;
         }
         ZM089( -2) ;
         OnLoadActions089( ) ;
         AddRow089( ) ;
         ScanKeyEnd089( ) ;
         if ( RcdFound9 == 0 )
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
         RowToVars9( bcMaterias, 0) ;
         ScanKeyStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z11MateriasId = A11MateriasId;
         }
         ZM089( -2) ;
         OnLoadActions089( ) ;
         AddRow089( ) ;
         ScanKeyEnd089( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey089( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert089( ) ;
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( A11MateriasId != Z11MateriasId )
               {
                  A11MateriasId = Z11MateriasId;
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
                  Update089( ) ;
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
                  if ( A11MateriasId != Z11MateriasId )
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
                        Insert089( ) ;
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
                        Insert089( ) ;
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
         RowToVars9( bcMaterias, 0) ;
         SaveImpl( ) ;
         VarsToRow9( bcMaterias) ;
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
         RowToVars9( bcMaterias, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert089( ) ;
         AfterTrn( ) ;
         VarsToRow9( bcMaterias) ;
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
            SdtMaterias auxBC = new SdtMaterias(context) ;
            auxBC.Load(A11MateriasId);
            auxBC.UpdateDirties(bcMaterias);
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
         RowToVars9( bcMaterias, 0) ;
         UpdateImpl( ) ;
         VarsToRow9( bcMaterias) ;
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
         RowToVars9( bcMaterias, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert089( ) ;
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
         VarsToRow9( bcMaterias) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars9( bcMaterias, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey089( ) ;
         if ( RcdFound9 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A11MateriasId != Z11MateriasId )
            {
               A11MateriasId = Z11MateriasId;
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
            if ( A11MateriasId != Z11MateriasId )
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
         context.RollbackDataStores("materias_bc",pr_default);
         VarsToRow9( bcMaterias) ;
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
         Gx_mode = bcMaterias.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcMaterias.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcMaterias )
         {
            bcMaterias = (SdtMaterias)(sdt);
            if ( StringUtil.StrCmp(bcMaterias.gxTpr_Mode, "") == 0 )
            {
               bcMaterias.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow9( bcMaterias) ;
            }
            else
            {
               RowToVars9( bcMaterias, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcMaterias.gxTpr_Mode, "") == 0 )
            {
               bcMaterias.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars9( bcMaterias, 1) ;
         return  ;
      }

      public SdtMaterias Materias_BC
      {
         get {
            return bcMaterias ;
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
         BC00084_A11MateriasId = new short[1] ;
         BC00084_A48MateriasNombre = new String[] {""} ;
         BC00084_A50MateriasDescripcion = new String[] {""} ;
         BC00084_A51MateriasProfesor = new String[] {""} ;
         BC00084_A52MateriasProfCorreo = new String[] {""} ;
         A48MateriasNombre = "";
         A50MateriasDescripcion = "";
         A51MateriasProfesor = "";
         A52MateriasProfCorreo = "";
         gx_restcollection = new GXBCCollection<SdtMaterias>( context, "Materias", "Verbo2");
         sMode9 = "";
         Gx_mode = "";
         Z48MateriasNombre = "";
         Z50MateriasDescripcion = "";
         Z51MateriasProfesor = "";
         Z52MateriasProfCorreo = "";
         BC00085_A11MateriasId = new short[1] ;
         BC00085_A48MateriasNombre = new String[] {""} ;
         BC00085_A50MateriasDescripcion = new String[] {""} ;
         BC00085_A51MateriasProfesor = new String[] {""} ;
         BC00085_A52MateriasProfCorreo = new String[] {""} ;
         BC00086_A11MateriasId = new short[1] ;
         BC00083_A11MateriasId = new short[1] ;
         BC00083_A48MateriasNombre = new String[] {""} ;
         BC00083_A50MateriasDescripcion = new String[] {""} ;
         BC00083_A51MateriasProfesor = new String[] {""} ;
         BC00083_A52MateriasProfCorreo = new String[] {""} ;
         BC00082_A11MateriasId = new short[1] ;
         BC00082_A48MateriasNombre = new String[] {""} ;
         BC00082_A50MateriasDescripcion = new String[] {""} ;
         BC00082_A51MateriasProfesor = new String[] {""} ;
         BC00082_A52MateriasProfCorreo = new String[] {""} ;
         BC00087_A11MateriasId = new short[1] ;
         BC000810_A13CalifasId = new short[1] ;
         BC000811_A11MateriasId = new short[1] ;
         BC000811_A48MateriasNombre = new String[] {""} ;
         BC000811_A50MateriasDescripcion = new String[] {""} ;
         BC000811_A51MateriasProfesor = new String[] {""} ;
         BC000811_A52MateriasProfCorreo = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.materias_bc__default(),
            new Object[][] {
                new Object[] {
               BC00082_A11MateriasId, BC00082_A48MateriasNombre, BC00082_A50MateriasDescripcion, BC00082_A51MateriasProfesor, BC00082_A52MateriasProfCorreo
               }
               , new Object[] {
               BC00083_A11MateriasId, BC00083_A48MateriasNombre, BC00083_A50MateriasDescripcion, BC00083_A51MateriasProfesor, BC00083_A52MateriasProfCorreo
               }
               , new Object[] {
               BC00084_A11MateriasId, BC00084_A48MateriasNombre, BC00084_A50MateriasDescripcion, BC00084_A51MateriasProfesor, BC00084_A52MateriasProfCorreo
               }
               , new Object[] {
               BC00085_A11MateriasId, BC00085_A48MateriasNombre, BC00085_A50MateriasDescripcion, BC00085_A51MateriasProfesor, BC00085_A52MateriasProfCorreo
               }
               , new Object[] {
               BC00086_A11MateriasId
               }
               , new Object[] {
               BC00087_A11MateriasId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000810_A13CalifasId
               }
               , new Object[] {
               BC000811_A11MateriasId, BC000811_A48MateriasNombre, BC000811_A50MateriasDescripcion, BC000811_A51MateriasProfesor, BC000811_A52MateriasProfCorreo
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12082 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound9 ;
      private short A11MateriasId ;
      private short Z11MateriasId ;
      private short GX_JID ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom9 ;
      private int GXPagingTo9 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String A48MateriasNombre ;
      private String A50MateriasDescripcion ;
      private String A51MateriasProfesor ;
      private String sMode9 ;
      private String Gx_mode ;
      private String Z48MateriasNombre ;
      private String Z50MateriasDescripcion ;
      private String Z51MateriasProfesor ;
      private String A52MateriasProfCorreo ;
      private String Z52MateriasProfCorreo ;
      private GXBCCollection<SdtMaterias> gx_restcollection ;
      private SdtMaterias bcMaterias ;
      private SdtMaterias gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00084_A11MateriasId ;
      private String[] BC00084_A48MateriasNombre ;
      private String[] BC00084_A50MateriasDescripcion ;
      private String[] BC00084_A51MateriasProfesor ;
      private String[] BC00084_A52MateriasProfCorreo ;
      private short[] BC00085_A11MateriasId ;
      private String[] BC00085_A48MateriasNombre ;
      private String[] BC00085_A50MateriasDescripcion ;
      private String[] BC00085_A51MateriasProfesor ;
      private String[] BC00085_A52MateriasProfCorreo ;
      private short[] BC00086_A11MateriasId ;
      private short[] BC00083_A11MateriasId ;
      private String[] BC00083_A48MateriasNombre ;
      private String[] BC00083_A50MateriasDescripcion ;
      private String[] BC00083_A51MateriasProfesor ;
      private String[] BC00083_A52MateriasProfCorreo ;
      private short[] BC00082_A11MateriasId ;
      private String[] BC00082_A48MateriasNombre ;
      private String[] BC00082_A50MateriasDescripcion ;
      private String[] BC00082_A51MateriasProfesor ;
      private String[] BC00082_A52MateriasProfCorreo ;
      private short[] BC00087_A11MateriasId ;
      private short[] BC000810_A13CalifasId ;
      private short[] BC000811_A11MateriasId ;
      private String[] BC000811_A48MateriasNombre ;
      private String[] BC000811_A50MateriasDescripcion ;
      private String[] BC000811_A51MateriasProfesor ;
      private String[] BC000811_A52MateriasProfCorreo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class materias_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00084 ;
          prmBC00084 = new Object[] {
          new Object[] {"@GXPagingFrom9",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo9",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00085 ;
          prmBC00085 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00086 ;
          prmBC00086 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00083 ;
          prmBC00083 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00082 ;
          prmBC00082 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00087 ;
          prmBC00087 = new Object[] {
          new Object[] {"@MateriasNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@MateriasDescripcion",SqlDbType.Char,200,0} ,
          new Object[] {"@MateriasProfesor",SqlDbType.Char,50,0} ,
          new Object[] {"@MateriasProfCorreo",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmBC00088 ;
          prmBC00088 = new Object[] {
          new Object[] {"@MateriasNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@MateriasDescripcion",SqlDbType.Char,200,0} ,
          new Object[] {"@MateriasProfesor",SqlDbType.Char,50,0} ,
          new Object[] {"@MateriasProfCorreo",SqlDbType.VarChar,100,0} ,
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00089 ;
          prmBC00089 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000810 ;
          prmBC000810 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000811 ;
          prmBC000811 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00082", "SELECT [MateriasId], [MateriasNombre], [MateriasDescripcion], [MateriasProfesor], [MateriasProfCorreo] FROM [Materias] WITH (UPDLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00082,1,0,true,false )
             ,new CursorDef("BC00083", "SELECT [MateriasId], [MateriasNombre], [MateriasDescripcion], [MateriasProfesor], [MateriasProfCorreo] FROM [Materias] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00083,1,0,true,false )
             ,new CursorDef("BC00084", "SELECT TM1.[MateriasId], TM1.[MateriasNombre], TM1.[MateriasDescripcion], TM1.[MateriasProfesor], TM1.[MateriasProfCorreo] FROM [Materias] TM1 WITH (NOLOCK) ORDER BY TM1.[MateriasId]  OFFSET @GXPagingFrom9 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo9 > 0 THEN @GXPagingTo9 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00084,100,0,true,false )
             ,new CursorDef("BC00085", "SELECT TM1.[MateriasId], TM1.[MateriasNombre], TM1.[MateriasDescripcion], TM1.[MateriasProfesor], TM1.[MateriasProfCorreo] FROM [Materias] TM1 WITH (NOLOCK) WHERE TM1.[MateriasId] = @MateriasId ORDER BY TM1.[MateriasId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00085,100,0,true,false )
             ,new CursorDef("BC00086", "SELECT [MateriasId] FROM [Materias] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00086,1,0,true,false )
             ,new CursorDef("BC00087", "INSERT INTO [Materias]([MateriasNombre], [MateriasDescripcion], [MateriasProfesor], [MateriasProfCorreo]) VALUES(@MateriasNombre, @MateriasDescripcion, @MateriasProfesor, @MateriasProfCorreo); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00087)
             ,new CursorDef("BC00088", "UPDATE [Materias] SET [MateriasNombre]=@MateriasNombre, [MateriasDescripcion]=@MateriasDescripcion, [MateriasProfesor]=@MateriasProfesor, [MateriasProfCorreo]=@MateriasProfCorreo  WHERE [MateriasId] = @MateriasId", GxErrorMask.GX_NOMASK,prmBC00088)
             ,new CursorDef("BC00089", "DELETE FROM [Materias]  WHERE [MateriasId] = @MateriasId", GxErrorMask.GX_NOMASK,prmBC00089)
             ,new CursorDef("BC000810", "SELECT TOP 1 [CalifasId] FROM [Califas] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000810,1,0,true,true )
             ,new CursorDef("BC000811", "SELECT TM1.[MateriasId], TM1.[MateriasNombre], TM1.[MateriasDescripcion], TM1.[MateriasProfesor], TM1.[MateriasProfCorreo] FROM [Materias] TM1 WITH (NOLOCK) WHERE TM1.[MateriasId] = @MateriasId ORDER BY TM1.[MateriasId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000811,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.materias_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class materias_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA11MateriasId}")]
    public SdtMaterias_RESTInterface Load( string sA11MateriasId )
    {
       try
       {
          short A11MateriasId ;
          A11MateriasId = (short)(NumberUtil.Val( (String)(sA11MateriasId), "."));
          SdtMaterias worker = new SdtMaterias(context) ;
          SdtMaterias_RESTInterface worker_interface = new SdtMaterias_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA11MateriasId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A11MateriasId);
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "DELETE" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA11MateriasId}")]
    public SdtMaterias_RESTInterface Delete( string sA11MateriasId )
    {
       try
       {
          short A11MateriasId ;
          A11MateriasId = (short)(NumberUtil.Val( (String)(sA11MateriasId), "."));
          SdtMaterias worker = new SdtMaterias(context) ;
          SdtMaterias_RESTInterface worker_interface = new SdtMaterias_RESTInterface (worker);
          worker.Load(A11MateriasId);
          worker.Delete();
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             (( GXHttpHandler )worker.trn).context.CommitDataStores();
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA11MateriasId}")]
    public SdtMaterias_RESTInterface Insert( string sA11MateriasId ,
                                             SdtMaterias_RESTInterface entity )
    {
       try
       {
          short A11MateriasId ;
          A11MateriasId = (short)(NumberUtil.Val( (String)(sA11MateriasId), "."));
          SdtMaterias worker = new SdtMaterias(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtMaterias_RESTInterface worker_interface = new SdtMaterias_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Materiasid = A11MateriasId;
          if ( gxcheck )
          {
             worker.Check();
          }
          else
          {
             if ( gxinsertorupdate )
             {
                worker.InsertOrUpdate();
             }
             else
             {
                worker.Save();
             }
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             if ( ! gxcheck )
             {
                (( GXHttpHandler )worker.trn).context.CommitDataStores();
                SetStatusCode(System.Net.HttpStatusCode.Created);
             }
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "PUT" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA11MateriasId}")]
    public SdtMaterias_RESTInterface Update( string sA11MateriasId ,
                                             SdtMaterias_RESTInterface entity )
    {
       try
       {
          short A11MateriasId ;
          A11MateriasId = (short)(NumberUtil.Val( (String)(sA11MateriasId), "."));
          SdtMaterias worker = new SdtMaterias(context) ;
          SdtMaterias_RESTInterface worker_interface = new SdtMaterias_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A11MateriasId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Materiasid = A11MateriasId;
             if ( gxcheck )
             {
                worker.Check();
             }
             else
             {
                worker.Save();
             }
             ((GXHttpHandler)worker.trn).IsMain = true ;
             if ( worker.Success() )
             {
                if ( ! gxcheck )
                {
                   (( GXHttpHandler )worker.trn).context.CommitDataStores();
                }
                SetMessages(worker.trn.GetMessages());
                worker.trn.cleanup( );
                worker_interface.Hash = null;
                return worker_interface ;
             }
             else
             {
                worker.trn.cleanup( );
                ErrorCheck(worker.trn);
                return null ;
             }
          }
          else
          {
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Materias"}) );
          }
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
