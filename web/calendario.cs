/*
               File: Calendario
        Description: Calendario
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:33.33
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
   public class calendario : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcalendario_calendariomes") == 0 )
         {
            nRC_GXsfl_43 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_43_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_43_idx = GetNextPar( );
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridcalendario_calendariomes_newrow( ) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7CalendarioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CalendarioId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCALENDARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CalendarioId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Calendario", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCalendarioMesNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public calendario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public calendario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_CalendarioId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7CalendarioId = aP1_CalendarioId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Calendario", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalendarioMesNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalendarioMesNombre_Internalname, "Mes Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalendarioMesNombre_Internalname, StringUtil.RTrim( A69CalendarioMesNombre), StringUtil.RTrim( context.localUtil.Format( A69CalendarioMesNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalendarioMesNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalendarioMesNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCalendariomestable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlecalendariomes_Internalname, "Calendario Mes", "", "", lblTitlecalendariomes_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridcalendario_calendariomes( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridcalendario_calendariomes( )
      {
         /*  Grid Control  */
         Gridcalendario_calendariomesContainer.AddObjectProperty("GridName", "Gridcalendario_calendariomes");
         Gridcalendario_calendariomesContainer.AddObjectProperty("Header", subGridcalendario_calendariomes_Header);
         Gridcalendario_calendariomesContainer.AddObjectProperty("Class", "Grid");
         Gridcalendario_calendariomesContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Backcolorstyle), 1, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("CmpContext", "");
         Gridcalendario_calendariomesContainer.AddObjectProperty("InMasterPage", "false");
         Gridcalendario_calendariomesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17CalendarioMesId), 4, 0, ".", "")));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesId_Enabled), 5, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddColumnProperties(Gridcalendario_calendariomesColumn);
         Gridcalendario_calendariomesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Value", context.localUtil.Format(A70CalendarioMesDate, "99/99/99"));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDate_Enabled), 5, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddColumnProperties(Gridcalendario_calendariomesColumn);
         Gridcalendario_calendariomesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Value", StringUtil.RTrim( A71CalendarioMesDescription));
         Gridcalendario_calendariomesColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddColumnProperties(Gridcalendario_calendariomesColumn);
         Gridcalendario_calendariomesContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Selectedindex), 4, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Allowselection), 1, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Selectioncolor), 9, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Allowhovering), 1, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Hoveringcolor), 9, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Allowcollapsing), 1, 0, ".", "")));
         Gridcalendario_calendariomesContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcalendario_calendariomes_Collapsed), 1, 0, ".", "")));
         nGXsfl_43_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount15 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_15 = 1;
               ScanStart0915( ) ;
               while ( RcdFound15 != 0 )
               {
                  init_level_properties15( ) ;
                  getByPrimaryKey0915( ) ;
                  AddRow0915( ) ;
                  ScanNext0915( ) ;
               }
               ScanEnd0915( ) ;
               nBlankRcdCount15 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0915( ) ;
            standaloneModal0915( ) ;
            sMode15 = Gx_mode;
            while ( nGXsfl_43_idx < nRC_GXsfl_43 )
            {
               bGXsfl_43_Refreshing = true;
               ReadRow0915( ) ;
               edtCalendarioMesId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESID_"+sGXsfl_43_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
               edtCalendarioMesDate_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESDATE_"+sGXsfl_43_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesDate_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
               edtCalendarioMesDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
               if ( ( nRcdExists_15 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0915( ) ;
               }
               SendRow0915( ) ;
               bGXsfl_43_Refreshing = false;
            }
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount15 = 5;
            nRcdExists_15 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0915( ) ;
               while ( RcdFound15 != 0 )
               {
                  sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_4315( ) ;
                  init_level_properties15( ) ;
                  standaloneNotModal0915( ) ;
                  getByPrimaryKey0915( ) ;
                  standaloneModal0915( ) ;
                  AddRow0915( ) ;
                  ScanNext0915( ) ;
               }
               ScanEnd0915( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode15 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_4315( ) ;
            InitAll0915( ) ;
            init_level_properties15( ) ;
            standaloneNotModal0915( ) ;
            standaloneModal0915( ) ;
            nRcdExists_15 = 0;
            nIsMod_15 = 0;
            nRcdDeleted_15 = 0;
            nBlankRcdCount15 = (short)(nBlankRcdUsr15+nBlankRcdCount15);
            fRowAdded = 0;
            while ( nBlankRcdCount15 > 0 )
            {
               AddRow0915( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtCalendarioMesId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount15 = (short)(nBlankRcdCount15-1);
            }
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridcalendario_calendariomesContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcalendario_calendariomes", Gridcalendario_calendariomesContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcalendario_calendariomesContainerData", Gridcalendario_calendariomesContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcalendario_calendariomesContainerData"+"V", Gridcalendario_calendariomesContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcalendario_calendariomesContainerData"+"V"+"\" value='"+Gridcalendario_calendariomesContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11092 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A69CalendarioMesNombre = cgiGet( edtCalendarioMesNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69CalendarioMesNombre", A69CalendarioMesNombre);
               /* Read saved values. */
               Z16CalendarioId = (short)(context.localUtil.CToN( cgiGet( "Z16CalendarioId"), ",", "."));
               Z69CalendarioMesNombre = cgiGet( "Z69CalendarioMesNombre");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_43 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_43"), ",", "."));
               AV7CalendarioId = (short)(context.localUtil.CToN( cgiGet( "vCALENDARIOID"), ",", "."));
               A16CalendarioId = (short)(context.localUtil.CToN( cgiGet( "CALENDARIOID"), ",", "."));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Calendario";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A16CalendarioId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("calendario:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("calendario:[SecurityCheckFailed value for]"+"CalendarioId:"+context.localUtil.Format( (decimal)(A16CalendarioId), "ZZZ9"));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A16CalendarioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CalendarioId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode14 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode14;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound14 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_090( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11092 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12092 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12092 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0914( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
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

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0914( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_090( )
      {
         BeforeValidate0914( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0914( ) ;
            }
            else
            {
               CheckExtendedTable0914( ) ;
               CloseExtendedTableCursors0914( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode14 = Gx_mode;
            CONFIRM_0915( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode14;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0915( )
      {
         nGXsfl_43_idx = 0;
         while ( nGXsfl_43_idx < nRC_GXsfl_43 )
         {
            ReadRow0915( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               GetKey0915( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0915( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0915( ) ;
                        CloseExtendedTableCursors0915( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "CALENDARIOMESID_" + sGXsfl_43_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtCalendarioMesId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( nRcdDeleted_15 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0915( ) ;
                        Load0915( ) ;
                        BeforeValidate0915( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0915( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_15 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0915( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0915( ) ;
                              CloseExtendedTableCursors0915( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GXCCtl = "CALENDARIOMESID_" + sGXsfl_43_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtCalendarioMesId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCalendarioMesId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17CalendarioMesId), 4, 0, ",", ""))) ;
            ChangePostValue( edtCalendarioMesDate_Internalname, context.localUtil.Format(A70CalendarioMesDate, "99/99/99")) ;
            ChangePostValue( edtCalendarioMesDescription_Internalname, StringUtil.RTrim( A71CalendarioMesDescription)) ;
            ChangePostValue( "ZT_"+"Z17CalendarioMesId_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17CalendarioMesId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z70CalendarioMesDate_"+sGXsfl_43_idx, context.localUtil.DToC( Z70CalendarioMesDate, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z71CalendarioMesDescription_"+sGXsfl_43_idx, StringUtil.RTrim( Z71CalendarioMesDescription)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "CALENDARIOMESID_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CALENDARIOMESDATE_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDate_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption090( )
      {
      }

      protected void E11092( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
      }

      protected void E12092( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcalendario.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0914( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z69CalendarioMesNombre = T00095_A69CalendarioMesNombre[0];
            }
            else
            {
               Z69CalendarioMesNombre = A69CalendarioMesNombre;
            }
         }
         if ( GX_JID == -4 )
         {
            Z16CalendarioId = A16CalendarioId;
            Z69CalendarioMesNombre = A69CalendarioMesNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7CalendarioId) )
         {
            A16CalendarioId = AV7CalendarioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CalendarioId), 4, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load0914( )
      {
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A16CalendarioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound14 = 1;
            A69CalendarioMesNombre = T00096_A69CalendarioMesNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69CalendarioMesNombre", A69CalendarioMesNombre);
            ZM0914( -4) ;
         }
         pr_default.close(4);
         OnLoadActions0914( ) ;
      }

      protected void OnLoadActions0914( )
      {
         AV11Pgmname = "Calendario";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable0914( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV11Pgmname = "Calendario";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors0914( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0914( )
      {
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A16CalendarioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound14 = 1;
         }
         else
         {
            RcdFound14 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A16CalendarioId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0914( 4) ;
            RcdFound14 = 1;
            A16CalendarioId = T00095_A16CalendarioId[0];
            A69CalendarioMesNombre = T00095_A69CalendarioMesNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69CalendarioMesNombre", A69CalendarioMesNombre);
            Z16CalendarioId = A16CalendarioId;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0914( ) ;
            if ( AnyError == 1 )
            {
               RcdFound14 = 0;
               InitializeNonKey0914( ) ;
            }
            Gx_mode = sMode14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound14 = 0;
            InitializeNonKey0914( ) ;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0914( ) ;
         if ( RcdFound14 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound14 = 0;
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A16CalendarioId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00098_A16CalendarioId[0] < A16CalendarioId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00098_A16CalendarioId[0] > A16CalendarioId ) ) )
            {
               A16CalendarioId = T00098_A16CalendarioId[0];
               RcdFound14 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound14 = 0;
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A16CalendarioId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00099_A16CalendarioId[0] > A16CalendarioId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00099_A16CalendarioId[0] < A16CalendarioId ) ) )
            {
               A16CalendarioId = T00099_A16CalendarioId[0];
               RcdFound14 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0914( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtCalendarioMesNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0914( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound14 == 1 )
            {
               if ( A16CalendarioId != Z16CalendarioId )
               {
                  A16CalendarioId = Z16CalendarioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CalendarioId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCalendarioMesNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0914( ) ;
                  GX_FocusControl = edtCalendarioMesNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A16CalendarioId != Z16CalendarioId )
               {
                  /* Insert record */
                  GX_FocusControl = edtCalendarioMesNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0914( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
                     /* Insert record */
                     GX_FocusControl = edtCalendarioMesNombre_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0914( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A16CalendarioId != Z16CalendarioId )
         {
            A16CalendarioId = Z16CalendarioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CalendarioId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "");
            AnyError = 1;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCalendarioMesNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0914( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00094 */
            pr_default.execute(2, new Object[] {A16CalendarioId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z69CalendarioMesNombre, T00094_A69CalendarioMesNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z69CalendarioMesNombre, T00094_A69CalendarioMesNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("calendario:[seudo value changed for attri]"+"CalendarioMesNombre");
                  GXUtil.WriteLogRaw("Old: ",Z69CalendarioMesNombre);
                  GXUtil.WriteLogRaw("Current: ",T00094_A69CalendarioMesNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Calendario"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0914( )
      {
         BeforeValidate0914( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0914( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0914( 0) ;
            CheckOptimisticConcurrency0914( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0914( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0914( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000910 */
                     pr_default.execute(8, new Object[] {A69CalendarioMesNombre});
                     A16CalendarioId = T000910_A16CalendarioId[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Calendario") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0914( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption090( ) ;
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
               Load0914( ) ;
            }
            EndLevel0914( ) ;
         }
         CloseExtendedTableCursors0914( ) ;
      }

      protected void Update0914( )
      {
         BeforeValidate0914( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0914( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0914( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0914( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0914( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000911 */
                     pr_default.execute(9, new Object[] {A69CalendarioMesNombre, A16CalendarioId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Calendario") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0914( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0914( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
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
            }
            EndLevel0914( ) ;
         }
         CloseExtendedTableCursors0914( ) ;
      }

      protected void DeferredUpdate0914( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0914( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0914( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0914( ) ;
            AfterConfirm0914( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0914( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0915( ) ;
                  while ( RcdFound15 != 0 )
                  {
                     getByPrimaryKey0915( ) ;
                     Delete0915( ) ;
                     ScanNext0915( ) ;
                  }
                  ScanEnd0915( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000912 */
                     pr_default.execute(10, new Object[] {A16CalendarioId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Calendario") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
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
            }
         }
         sMode14 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0914( ) ;
         Gx_mode = sMode14;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0914( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Calendario";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void ProcessNestedLevel0915( )
      {
         nGXsfl_43_idx = 0;
         while ( nGXsfl_43_idx < nRC_GXsfl_43 )
         {
            ReadRow0915( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               standaloneNotModal0915( ) ;
               GetKey0915( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0915( ) ;
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( ( nRcdDeleted_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0915( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0915( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GXCCtl = "CALENDARIOMESID_" + sGXsfl_43_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtCalendarioMesId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCalendarioMesId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17CalendarioMesId), 4, 0, ",", ""))) ;
            ChangePostValue( edtCalendarioMesDate_Internalname, context.localUtil.Format(A70CalendarioMesDate, "99/99/99")) ;
            ChangePostValue( edtCalendarioMesDescription_Internalname, StringUtil.RTrim( A71CalendarioMesDescription)) ;
            ChangePostValue( "ZT_"+"Z17CalendarioMesId_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17CalendarioMesId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z70CalendarioMesDate_"+sGXsfl_43_idx, context.localUtil.DToC( Z70CalendarioMesDate, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z71CalendarioMesDescription_"+sGXsfl_43_idx, StringUtil.RTrim( Z71CalendarioMesDescription)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_43_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "CALENDARIOMESID_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CALENDARIOMESDATE_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDate_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0915( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_15 = 0;
         nIsMod_15 = 0;
         nRcdDeleted_15 = 0;
      }

      protected void ProcessLevel0914( )
      {
         /* Save parent mode. */
         sMode14 = Gx_mode;
         ProcessNestedLevel0915( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode14;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0914( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0914( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("calendario",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("calendario",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0914( )
      {
         /* Scan By routine */
         /* Using cursor T000913 */
         pr_default.execute(11);
         RcdFound14 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound14 = 1;
            A16CalendarioId = T000913_A16CalendarioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0914( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound14 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound14 = 1;
            A16CalendarioId = T000913_A16CalendarioId[0];
         }
      }

      protected void ScanEnd0914( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0914( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0914( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0914( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0914( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0914( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0914( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0914( )
      {
         edtCalendarioMesNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesNombre_Enabled), 5, 0)), true);
      }

      protected void ZM0915( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z70CalendarioMesDate = T00093_A70CalendarioMesDate[0];
               Z71CalendarioMesDescription = T00093_A71CalendarioMesDescription[0];
            }
            else
            {
               Z70CalendarioMesDate = A70CalendarioMesDate;
               Z71CalendarioMesDescription = A71CalendarioMesDescription;
            }
         }
         if ( GX_JID == -5 )
         {
            Z16CalendarioId = A16CalendarioId;
            Z17CalendarioMesId = A17CalendarioMesId;
            Z70CalendarioMesDate = A70CalendarioMesDate;
            Z71CalendarioMesDescription = A71CalendarioMesDescription;
         }
      }

      protected void standaloneNotModal0915( )
      {
      }

      protected void standaloneModal0915( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A70CalendarioMesDate) && ( Gx_BScreen == 0 ) )
         {
            A70CalendarioMesDate = DateTimeUtil.Today( context);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtCalendarioMesId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         }
         else
         {
            edtCalendarioMesId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load0915( )
      {
         /* Using cursor T000914 */
         pr_default.execute(12, new Object[] {A16CalendarioId, A17CalendarioMesId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound15 = 1;
            A70CalendarioMesDate = T000914_A70CalendarioMesDate[0];
            A71CalendarioMesDescription = T000914_A71CalendarioMesDescription[0];
            ZM0915( -5) ;
         }
         pr_default.close(12);
         OnLoadActions0915( ) ;
      }

      protected void OnLoadActions0915( )
      {
      }

      protected void CheckExtendedTable0915( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0915( ) ;
         if ( ! ( (DateTime.MinValue==A70CalendarioMesDate) || ( A70CalendarioMesDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "CALENDARIOMESDATE_" + sGXsfl_43_idx;
            GX_msglist.addItem("Campo Calendario Mes Date fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtCalendarioMesDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0915( )
      {
      }

      protected void enableDisable0915( )
      {
      }

      protected void GetKey0915( )
      {
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {A16CalendarioId, A17CalendarioMesId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey0915( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A16CalendarioId, A17CalendarioMesId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0915( 5) ;
            RcdFound15 = 1;
            InitializeNonKey0915( ) ;
            A17CalendarioMesId = T00093_A17CalendarioMesId[0];
            A70CalendarioMesDate = T00093_A70CalendarioMesDate[0];
            A71CalendarioMesDescription = T00093_A71CalendarioMesDescription[0];
            Z16CalendarioId = A16CalendarioId;
            Z17CalendarioMesId = A17CalendarioMesId;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0915( ) ;
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0915( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0915( ) ;
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0915( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0915( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A16CalendarioId, A17CalendarioMesId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CalendarioCalendarioMes"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z70CalendarioMesDate != T00092_A70CalendarioMesDate[0] ) || ( StringUtil.StrCmp(Z71CalendarioMesDescription, T00092_A71CalendarioMesDescription[0]) != 0 ) )
            {
               if ( Z70CalendarioMesDate != T00092_A70CalendarioMesDate[0] )
               {
                  GXUtil.WriteLog("calendario:[seudo value changed for attri]"+"CalendarioMesDate");
                  GXUtil.WriteLogRaw("Old: ",Z70CalendarioMesDate);
                  GXUtil.WriteLogRaw("Current: ",T00092_A70CalendarioMesDate[0]);
               }
               if ( StringUtil.StrCmp(Z71CalendarioMesDescription, T00092_A71CalendarioMesDescription[0]) != 0 )
               {
                  GXUtil.WriteLog("calendario:[seudo value changed for attri]"+"CalendarioMesDescription");
                  GXUtil.WriteLogRaw("Old: ",Z71CalendarioMesDescription);
                  GXUtil.WriteLogRaw("Current: ",T00092_A71CalendarioMesDescription[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CalendarioCalendarioMes"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0915( )
      {
         BeforeValidate0915( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0915( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0915( 0) ;
            CheckOptimisticConcurrency0915( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0915( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0915( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000916 */
                     pr_default.execute(14, new Object[] {A16CalendarioId, A17CalendarioMesId, A70CalendarioMesDate, A71CalendarioMesDescription});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("CalendarioCalendarioMes") ;
                     if ( (pr_default.getStatus(14) == 1) )
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
               Load0915( ) ;
            }
            EndLevel0915( ) ;
         }
         CloseExtendedTableCursors0915( ) ;
      }

      protected void Update0915( )
      {
         BeforeValidate0915( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0915( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0915( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0915( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0915( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000917 */
                     pr_default.execute(15, new Object[] {A70CalendarioMesDate, A71CalendarioMesDescription, A16CalendarioId, A17CalendarioMesId});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("CalendarioCalendarioMes") ;
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CalendarioCalendarioMes"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0915( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0915( ) ;
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
            EndLevel0915( ) ;
         }
         CloseExtendedTableCursors0915( ) ;
      }

      protected void DeferredUpdate0915( )
      {
      }

      protected void Delete0915( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0915( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0915( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0915( ) ;
            AfterConfirm0915( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0915( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000918 */
                  pr_default.execute(16, new Object[] {A16CalendarioId, A17CalendarioMesId});
                  pr_default.close(16);
                  dsDefault.SmartCacheProvider.SetUpdated("CalendarioCalendarioMes") ;
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
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0915( ) ;
         Gx_mode = sMode15;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0915( )
      {
         standaloneModal0915( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0915( )
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

      public void ScanStart0915( )
      {
         /* Scan By routine */
         /* Using cursor T000919 */
         pr_default.execute(17, new Object[] {A16CalendarioId});
         RcdFound15 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound15 = 1;
            A17CalendarioMesId = T000919_A17CalendarioMesId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0915( )
      {
         /* Scan next routine */
         pr_default.readNext(17);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound15 = 1;
            A17CalendarioMesId = T000919_A17CalendarioMesId[0];
         }
      }

      protected void ScanEnd0915( )
      {
         pr_default.close(17);
      }

      protected void AfterConfirm0915( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0915( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0915( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0915( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0915( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0915( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0915( )
      {
         edtCalendarioMesId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtCalendarioMesDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesDate_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtCalendarioMesDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
      }

      protected void send_integrity_lvl_hashes0915( )
      {
      }

      protected void send_integrity_lvl_hashes0914( )
      {
      }

      protected void SubsflControlProps_4315( )
      {
         edtCalendarioMesId_Internalname = "CALENDARIOMESID_"+sGXsfl_43_idx;
         edtCalendarioMesDate_Internalname = "CALENDARIOMESDATE_"+sGXsfl_43_idx;
         edtCalendarioMesDescription_Internalname = "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx;
      }

      protected void SubsflControlProps_fel_4315( )
      {
         edtCalendarioMesId_Internalname = "CALENDARIOMESID_"+sGXsfl_43_fel_idx;
         edtCalendarioMesDate_Internalname = "CALENDARIOMESDATE_"+sGXsfl_43_fel_idx;
         edtCalendarioMesDescription_Internalname = "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_fel_idx;
      }

      protected void AddRow0915( )
      {
         nGXsfl_43_idx = (short)(nGXsfl_43_idx+1);
         sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
         SubsflControlProps_4315( ) ;
         SendRow0915( ) ;
      }

      protected void SendRow0915( )
      {
         Gridcalendario_calendariomesRow = GXWebRow.GetNew(context);
         if ( subGridcalendario_calendariomes_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcalendario_calendariomes_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcalendario_calendariomes_Class, "") != 0 )
            {
               subGridcalendario_calendariomes_Linesclass = subGridcalendario_calendariomes_Class+"Odd";
            }
         }
         else if ( subGridcalendario_calendariomes_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcalendario_calendariomes_Backstyle = 0;
            subGridcalendario_calendariomes_Backcolor = subGridcalendario_calendariomes_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcalendario_calendariomes_Class, "") != 0 )
            {
               subGridcalendario_calendariomes_Linesclass = subGridcalendario_calendariomes_Class+"Uniform";
            }
         }
         else if ( subGridcalendario_calendariomes_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcalendario_calendariomes_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcalendario_calendariomes_Class, "") != 0 )
            {
               subGridcalendario_calendariomes_Linesclass = subGridcalendario_calendariomes_Class+"Odd";
            }
            subGridcalendario_calendariomes_Backcolor = (int)(0x0);
         }
         else if ( subGridcalendario_calendariomes_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcalendario_calendariomes_Backstyle = 1;
            if ( ((int)(((nGXsfl_43_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridcalendario_calendariomes_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcalendario_calendariomes_Class, "") != 0 )
               {
                  subGridcalendario_calendariomes_Linesclass = subGridcalendario_calendariomes_Class+"Odd";
               }
            }
            else
            {
               subGridcalendario_calendariomes_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcalendario_calendariomes_Class, "") != 0 )
               {
                  subGridcalendario_calendariomes_Linesclass = subGridcalendario_calendariomes_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_43_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_43_idx + "',43)\"";
         ROClassString = "Attribute";
         Gridcalendario_calendariomesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCalendarioMesId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17CalendarioMesId), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A17CalendarioMesId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCalendarioMesId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCalendarioMesId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_43_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_43_idx + "',43)\"";
         ROClassString = "Attribute";
         Gridcalendario_calendariomesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCalendarioMesDate_Internalname,context.localUtil.Format(A70CalendarioMesDate, "99/99/99"),context.localUtil.Format( A70CalendarioMesDate, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCalendarioMesDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCalendarioMesDate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_43_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_43_idx + "',43)\"";
         ROClassString = "Attribute";
         Gridcalendario_calendariomesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCalendarioMesDescription_Internalname,StringUtil.RTrim( A71CalendarioMesDescription),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCalendarioMesDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCalendarioMesDescription_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)250,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcalendario_calendariomesRow);
         send_integrity_lvl_hashes0915( ) ;
         GXCCtl = "Z17CalendarioMesId_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17CalendarioMesId), 4, 0, ",", "")));
         GXCCtl = "Z70CalendarioMesDate_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z70CalendarioMesDate, 0, "/"));
         GXCCtl = "Z71CalendarioMesDescription_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z71CalendarioMesDescription));
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_15_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", "")));
         GXCCtl = "nIsMod_15_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_43_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vCALENDARIOID_" + sGXsfl_43_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CalendarioId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "CALENDARIOMESID_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CALENDARIOMESDATE_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDate_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCalendarioMesDescription_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcalendario_calendariomesContainer.AddRow(Gridcalendario_calendariomesRow);
      }

      protected void ReadRow0915( )
      {
         nGXsfl_43_idx = (short)(nGXsfl_43_idx+1);
         sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
         SubsflControlProps_4315( ) ;
         edtCalendarioMesId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESID_"+sGXsfl_43_idx+"Enabled"), ",", "."));
         edtCalendarioMesDate_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESDATE_"+sGXsfl_43_idx+"Enabled"), ",", "."));
         edtCalendarioMesDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "CALENDARIOMESDESCRIPTION_"+sGXsfl_43_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtCalendarioMesId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalendarioMesId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CALENDARIOMESID_" + sGXsfl_43_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtCalendarioMesId_Internalname;
            wbErr = true;
            A17CalendarioMesId = 0;
         }
         else
         {
            A17CalendarioMesId = (short)(context.localUtil.CToN( cgiGet( edtCalendarioMesId_Internalname), ",", "."));
         }
         if ( context.localUtil.VCDate( cgiGet( edtCalendarioMesDate_Internalname), 2) == 0 )
         {
            GXCCtl = "CALENDARIOMESDATE_" + sGXsfl_43_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Calendario Mes Date"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtCalendarioMesDate_Internalname;
            wbErr = true;
            A70CalendarioMesDate = DateTime.MinValue;
         }
         else
         {
            A70CalendarioMesDate = context.localUtil.CToD( cgiGet( edtCalendarioMesDate_Internalname), 2);
         }
         A71CalendarioMesDescription = cgiGet( edtCalendarioMesDescription_Internalname);
         GXCCtl = "Z17CalendarioMesId_" + sGXsfl_43_idx;
         Z17CalendarioMesId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z70CalendarioMesDate_" + sGXsfl_43_idx;
         Z70CalendarioMesDate = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "Z71CalendarioMesDescription_" + sGXsfl_43_idx;
         Z71CalendarioMesDescription = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_43_idx;
         nRcdDeleted_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_15_" + sGXsfl_43_idx;
         nRcdExists_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_15_" + sGXsfl_43_idx;
         nIsMod_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtCalendarioMesId_Enabled = edtCalendarioMesId_Enabled;
      }

      protected void ConfirmValues090( )
      {
         nGXsfl_43_idx = 0;
         sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
         SubsflControlProps_4315( ) ;
         while ( nGXsfl_43_idx < nRC_GXsfl_43 )
         {
            nGXsfl_43_idx = (short)(nGXsfl_43_idx+1);
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
            SubsflControlProps_4315( ) ;
            ChangePostValue( "Z17CalendarioMesId_"+sGXsfl_43_idx, cgiGet( "ZT_"+"Z17CalendarioMesId_"+sGXsfl_43_idx)) ;
            DeletePostValue( "ZT_"+"Z17CalendarioMesId_"+sGXsfl_43_idx) ;
            ChangePostValue( "Z70CalendarioMesDate_"+sGXsfl_43_idx, cgiGet( "ZT_"+"Z70CalendarioMesDate_"+sGXsfl_43_idx)) ;
            DeletePostValue( "ZT_"+"Z70CalendarioMesDate_"+sGXsfl_43_idx) ;
            ChangePostValue( "Z71CalendarioMesDescription_"+sGXsfl_43_idx, cgiGet( "ZT_"+"Z71CalendarioMesDescription_"+sGXsfl_43_idx)) ;
            DeletePostValue( "ZT_"+"Z71CalendarioMesDescription_"+sGXsfl_43_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?2018101118523644", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("calendario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CalendarioId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Calendario";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A16CalendarioId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("calendario:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("calendario:[SendSecurityCheck value for]"+"CalendarioId:"+context.localUtil.Format( (decimal)(A16CalendarioId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z16CalendarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16CalendarioId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z69CalendarioMesNombre", StringUtil.RTrim( Z69CalendarioMesNombre));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_43", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_43_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCALENDARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CalendarioId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCALENDARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CalendarioId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CALENDARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16CalendarioId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("calendario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CalendarioId) ;
      }

      public override String GetPgmname( )
      {
         return "Calendario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Calendario" ;
      }

      protected void InitializeNonKey0914( )
      {
         A69CalendarioMesNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69CalendarioMesNombre", A69CalendarioMesNombre);
         Z69CalendarioMesNombre = "";
      }

      protected void InitAll0914( )
      {
         A16CalendarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16CalendarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CalendarioId), 4, 0)));
         InitializeNonKey0914( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0915( )
      {
         A71CalendarioMesDescription = "";
         A70CalendarioMesDate = DateTimeUtil.Today( context);
         Z70CalendarioMesDate = DateTime.MinValue;
         Z71CalendarioMesDescription = "";
      }

      protected void InitAll0915( )
      {
         A17CalendarioMesId = 0;
         InitializeNonKey0915( ) ;
      }

      protected void StandaloneModalInsert0915( )
      {
         A70CalendarioMesDate = i70CalendarioMesDate;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118523657", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("calendario.js", "?2018101118523658", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties15( )
      {
         edtCalendarioMesId_Enabled = defedtCalendarioMesId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioMesId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioMesId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtCalendarioMesNombre_Internalname = "CALENDARIOMESNOMBRE";
         lblTitlecalendariomes_Internalname = "TITLECALENDARIOMES";
         edtCalendarioMesId_Internalname = "CALENDARIOMESID";
         edtCalendarioMesDate_Internalname = "CALENDARIOMESDATE";
         edtCalendarioMesDescription_Internalname = "CALENDARIOMESDESCRIPTION";
         divCalendariomestable_Internalname = "CALENDARIOMESTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridcalendario_calendariomes_Internalname = "GRIDCALENDARIO_CALENDARIOMES";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Calendario";
         edtCalendarioMesDescription_Jsonclick = "";
         edtCalendarioMesDate_Jsonclick = "";
         edtCalendarioMesId_Jsonclick = "";
         subGridcalendario_calendariomes_Class = "Grid";
         subGridcalendario_calendariomes_Backcolorstyle = 0;
         subGridcalendario_calendariomes_Allowcollapsing = 0;
         subGridcalendario_calendariomes_Allowselection = 0;
         edtCalendarioMesDescription_Enabled = 1;
         edtCalendarioMesDate_Enabled = 1;
         edtCalendarioMesId_Enabled = 1;
         subGridcalendario_calendariomes_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCalendarioMesNombre_Jsonclick = "";
         edtCalendarioMesNombre_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridcalendario_calendariomes_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_4315( ) ;
         while ( nGXsfl_43_idx <= nRC_GXsfl_43 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0915( ) ;
            standaloneModal0915( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0915( ) ;
            nGXsfl_43_idx = (short)(nGXsfl_43_idx+1);
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
            SubsflControlProps_4315( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridcalendario_calendariomesContainer));
         /* End function gxnrGridcalendario_calendariomes_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CalendarioId',fld:'vCALENDARIOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CalendarioId',fld:'vCALENDARIOID',pic:'ZZZ9',hsh:true},{av:'A16CalendarioId',fld:'CALENDARIOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12092',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
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
         pr_default.close(3);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z69CalendarioMesNombre = "";
         Z70CalendarioMesDate = DateTime.MinValue;
         Z71CalendarioMesDescription = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A69CalendarioMesNombre = "";
         lblTitlecalendariomes_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridcalendario_calendariomesContainer = new GXWebGrid( context);
         Gridcalendario_calendariomesColumn = new GXWebColumn();
         A70CalendarioMesDate = DateTime.MinValue;
         A71CalendarioMesDescription = "";
         sMode15 = "";
         sStyleString = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode14 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00096_A16CalendarioId = new short[1] ;
         T00096_A69CalendarioMesNombre = new String[] {""} ;
         T00097_A16CalendarioId = new short[1] ;
         T00095_A16CalendarioId = new short[1] ;
         T00095_A69CalendarioMesNombre = new String[] {""} ;
         T00098_A16CalendarioId = new short[1] ;
         T00099_A16CalendarioId = new short[1] ;
         T00094_A16CalendarioId = new short[1] ;
         T00094_A69CalendarioMesNombre = new String[] {""} ;
         T000910_A16CalendarioId = new short[1] ;
         T000913_A16CalendarioId = new short[1] ;
         T000914_A16CalendarioId = new short[1] ;
         T000914_A17CalendarioMesId = new short[1] ;
         T000914_A70CalendarioMesDate = new DateTime[] {DateTime.MinValue} ;
         T000914_A71CalendarioMesDescription = new String[] {""} ;
         T000915_A16CalendarioId = new short[1] ;
         T000915_A17CalendarioMesId = new short[1] ;
         T00093_A16CalendarioId = new short[1] ;
         T00093_A17CalendarioMesId = new short[1] ;
         T00093_A70CalendarioMesDate = new DateTime[] {DateTime.MinValue} ;
         T00093_A71CalendarioMesDescription = new String[] {""} ;
         T00092_A16CalendarioId = new short[1] ;
         T00092_A17CalendarioMesId = new short[1] ;
         T00092_A70CalendarioMesDate = new DateTime[] {DateTime.MinValue} ;
         T00092_A71CalendarioMesDescription = new String[] {""} ;
         T000919_A16CalendarioId = new short[1] ;
         T000919_A17CalendarioMesId = new short[1] ;
         Gridcalendario_calendariomesRow = new GXWebRow();
         subGridcalendario_calendariomes_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i70CalendarioMesDate = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calendario__default(),
            new Object[][] {
                new Object[] {
               T00092_A16CalendarioId, T00092_A17CalendarioMesId, T00092_A70CalendarioMesDate, T00092_A71CalendarioMesDescription
               }
               , new Object[] {
               T00093_A16CalendarioId, T00093_A17CalendarioMesId, T00093_A70CalendarioMesDate, T00093_A71CalendarioMesDescription
               }
               , new Object[] {
               T00094_A16CalendarioId, T00094_A69CalendarioMesNombre
               }
               , new Object[] {
               T00095_A16CalendarioId, T00095_A69CalendarioMesNombre
               }
               , new Object[] {
               T00096_A16CalendarioId, T00096_A69CalendarioMesNombre
               }
               , new Object[] {
               T00097_A16CalendarioId
               }
               , new Object[] {
               T00098_A16CalendarioId
               }
               , new Object[] {
               T00099_A16CalendarioId
               }
               , new Object[] {
               T000910_A16CalendarioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000913_A16CalendarioId
               }
               , new Object[] {
               T000914_A16CalendarioId, T000914_A17CalendarioMesId, T000914_A70CalendarioMesDate, T000914_A71CalendarioMesDescription
               }
               , new Object[] {
               T000915_A16CalendarioId, T000915_A17CalendarioMesId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000919_A16CalendarioId, T000919_A17CalendarioMesId
               }
            }
         );
         Z70CalendarioMesDate = DateTimeUtil.Today( context);
         A70CalendarioMesDate = DateTimeUtil.Today( context);
         i70CalendarioMesDate = DateTimeUtil.Today( context);
         AV11Pgmname = "Calendario";
      }

      private short wcpOAV7CalendarioId ;
      private short Z16CalendarioId ;
      private short nRC_GXsfl_43 ;
      private short nGXsfl_43_idx=1 ;
      private short Z17CalendarioMesId ;
      private short nRcdDeleted_15 ;
      private short nRcdExists_15 ;
      private short nIsMod_15 ;
      private short GxWebError ;
      private short Gx_BScreen ;
      private short AV7CalendarioId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridcalendario_calendariomes_Backcolorstyle ;
      private short A17CalendarioMesId ;
      private short subGridcalendario_calendariomes_Allowselection ;
      private short subGridcalendario_calendariomes_Allowhovering ;
      private short subGridcalendario_calendariomes_Allowcollapsing ;
      private short subGridcalendario_calendariomes_Collapsed ;
      private short nBlankRcdCount15 ;
      private short RcdFound15 ;
      private short nBlankRcdUsr15 ;
      private short A16CalendarioId ;
      private short RcdFound14 ;
      private short GX_JID ;
      private short subGridcalendario_calendariomes_Backstyle ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtCalendarioMesNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtCalendarioMesId_Enabled ;
      private int edtCalendarioMesDate_Enabled ;
      private int edtCalendarioMesDescription_Enabled ;
      private int subGridcalendario_calendariomes_Selectedindex ;
      private int subGridcalendario_calendariomes_Selectioncolor ;
      private int subGridcalendario_calendariomes_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridcalendario_calendariomes_Backcolor ;
      private int subGridcalendario_calendariomes_Allbackcolor ;
      private int defedtCalendarioMesId_Enabled ;
      private int idxLst ;
      private long GRIDCALENDARIO_CALENDARIOMES_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z69CalendarioMesNombre ;
      private String Z71CalendarioMesDescription ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_43_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCalendarioMesNombre_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String A69CalendarioMesNombre ;
      private String edtCalendarioMesNombre_Jsonclick ;
      private String divCalendariomestable_Internalname ;
      private String lblTitlecalendariomes_Internalname ;
      private String lblTitlecalendariomes_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridcalendario_calendariomes_Header ;
      private String A71CalendarioMesDescription ;
      private String sMode15 ;
      private String edtCalendarioMesId_Internalname ;
      private String edtCalendarioMesDate_Internalname ;
      private String edtCalendarioMesDescription_Internalname ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode14 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_43_fel_idx="0001" ;
      private String subGridcalendario_calendariomes_Class ;
      private String subGridcalendario_calendariomes_Linesclass ;
      private String ROClassString ;
      private String edtCalendarioMesId_Jsonclick ;
      private String edtCalendarioMesDate_Jsonclick ;
      private String edtCalendarioMesDescription_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridcalendario_calendariomes_Internalname ;
      private DateTime Z70CalendarioMesDate ;
      private DateTime A70CalendarioMesDate ;
      private DateTime i70CalendarioMesDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_43_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXWebGrid Gridcalendario_calendariomesContainer ;
      private GXWebRow Gridcalendario_calendariomesRow ;
      private GXWebColumn Gridcalendario_calendariomesColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00096_A16CalendarioId ;
      private String[] T00096_A69CalendarioMesNombre ;
      private short[] T00097_A16CalendarioId ;
      private short[] T00095_A16CalendarioId ;
      private String[] T00095_A69CalendarioMesNombre ;
      private short[] T00098_A16CalendarioId ;
      private short[] T00099_A16CalendarioId ;
      private short[] T00094_A16CalendarioId ;
      private String[] T00094_A69CalendarioMesNombre ;
      private short[] T000910_A16CalendarioId ;
      private short[] T000913_A16CalendarioId ;
      private short[] T000914_A16CalendarioId ;
      private short[] T000914_A17CalendarioMesId ;
      private DateTime[] T000914_A70CalendarioMesDate ;
      private String[] T000914_A71CalendarioMesDescription ;
      private short[] T000915_A16CalendarioId ;
      private short[] T000915_A17CalendarioMesId ;
      private short[] T00093_A16CalendarioId ;
      private short[] T00093_A17CalendarioMesId ;
      private DateTime[] T00093_A70CalendarioMesDate ;
      private String[] T00093_A71CalendarioMesDescription ;
      private short[] T00092_A16CalendarioId ;
      private short[] T00092_A17CalendarioMesId ;
      private DateTime[] T00092_A70CalendarioMesDate ;
      private String[] T00092_A71CalendarioMesDescription ;
      private short[] T000919_A16CalendarioId ;
      private short[] T000919_A17CalendarioMesId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class calendario__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          new Object[] {"@CalendarioMesNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@CalendarioMesNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          } ;
          Object[] prmT000914 ;
          prmT000914 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000915 ;
          prmT000915 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000916 ;
          prmT000916 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CalendarioMesDescription",SqlDbType.Char,250,0}
          } ;
          Object[] prmT000917 ;
          prmT000917 = new Object[] {
          new Object[] {"@CalendarioMesDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CalendarioMesDescription",SqlDbType.Char,250,0} ,
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000918 ;
          prmT000918 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalendarioMesId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000919 ;
          prmT000919 = new Object[] {
          new Object[] {"@CalendarioId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [CalendarioId], [CalendarioMesId], [CalendarioMesDate], [CalendarioMesDescription] FROM [CalendarioCalendarioMes] WITH (UPDLOCK) WHERE [CalendarioId] = @CalendarioId AND [CalendarioMesId] = @CalendarioMesId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [CalendarioId], [CalendarioMesId], [CalendarioMesDate], [CalendarioMesDescription] FROM [CalendarioCalendarioMes] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId AND [CalendarioMesId] = @CalendarioMesId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT [CalendarioId], [CalendarioMesNombre] FROM [Calendario] WITH (UPDLOCK) WHERE [CalendarioId] = @CalendarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
             ,new CursorDef("T00095", "SELECT [CalendarioId], [CalendarioMesNombre] FROM [Calendario] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT TM1.[CalendarioId], TM1.[CalendarioMesNombre] FROM [Calendario] TM1 WITH (NOLOCK) WHERE TM1.[CalendarioId] = @CalendarioId ORDER BY TM1.[CalendarioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,100,0,true,false )
             ,new CursorDef("T00097", "SELECT [CalendarioId] FROM [Calendario] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,false )
             ,new CursorDef("T00098", "SELECT TOP 1 [CalendarioId] FROM [Calendario] WITH (NOLOCK) WHERE ( [CalendarioId] > @CalendarioId) ORDER BY [CalendarioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,true )
             ,new CursorDef("T00099", "SELECT TOP 1 [CalendarioId] FROM [Calendario] WITH (NOLOCK) WHERE ( [CalendarioId] < @CalendarioId) ORDER BY [CalendarioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,true )
             ,new CursorDef("T000910", "INSERT INTO [Calendario]([CalendarioMesNombre]) VALUES(@CalendarioMesNombre); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000910)
             ,new CursorDef("T000911", "UPDATE [Calendario] SET [CalendarioMesNombre]=@CalendarioMesNombre  WHERE [CalendarioId] = @CalendarioId", GxErrorMask.GX_NOMASK,prmT000911)
             ,new CursorDef("T000912", "DELETE FROM [Calendario]  WHERE [CalendarioId] = @CalendarioId", GxErrorMask.GX_NOMASK,prmT000912)
             ,new CursorDef("T000913", "SELECT [CalendarioId] FROM [Calendario] WITH (NOLOCK) ORDER BY [CalendarioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000913,100,0,true,false )
             ,new CursorDef("T000914", "SELECT [CalendarioId], [CalendarioMesId], [CalendarioMesDate], [CalendarioMesDescription] FROM [CalendarioCalendarioMes] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId and [CalendarioMesId] = @CalendarioMesId ORDER BY [CalendarioId], [CalendarioMesId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000914,11,0,true,false )
             ,new CursorDef("T000915", "SELECT [CalendarioId], [CalendarioMesId] FROM [CalendarioCalendarioMes] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId AND [CalendarioMesId] = @CalendarioMesId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000915,1,0,true,false )
             ,new CursorDef("T000916", "INSERT INTO [CalendarioCalendarioMes]([CalendarioId], [CalendarioMesId], [CalendarioMesDate], [CalendarioMesDescription]) VALUES(@CalendarioId, @CalendarioMesId, @CalendarioMesDate, @CalendarioMesDescription)", GxErrorMask.GX_NOMASK,prmT000916)
             ,new CursorDef("T000917", "UPDATE [CalendarioCalendarioMes] SET [CalendarioMesDate]=@CalendarioMesDate, [CalendarioMesDescription]=@CalendarioMesDescription  WHERE [CalendarioId] = @CalendarioId AND [CalendarioMesId] = @CalendarioMesId", GxErrorMask.GX_NOMASK,prmT000917)
             ,new CursorDef("T000918", "DELETE FROM [CalendarioCalendarioMes]  WHERE [CalendarioId] = @CalendarioId AND [CalendarioMesId] = @CalendarioMesId", GxErrorMask.GX_NOMASK,prmT000918)
             ,new CursorDef("T000919", "SELECT [CalendarioId], [CalendarioMesId] FROM [CalendarioCalendarioMes] WITH (NOLOCK) WHERE [CalendarioId] = @CalendarioId ORDER BY [CalendarioId], [CalendarioMesId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000919,11,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 15 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
