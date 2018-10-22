/*
               File: Balance
        Description: Balance
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:6.9
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
   public class balance : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_16( A3UsersId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridbalance_history") == 0 )
         {
            nRC_GXsfl_73 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_73_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_73_idx = GetNextPar( );
            A30BalanceLastLine = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridbalance_history_newrow( ) ;
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
               AV7BalanceId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BalanceId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBALANCEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BalanceId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Balance", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBalanceCredit_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public balance( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public balance( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_BalanceId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BalanceId = aP1_BalanceId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBalanceName = new GXCombobox();
         cmbHistoryType = new GXCombobox();
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
         if ( cmbBalanceName.ItemCount > 0 )
         {
            A29BalanceName = cmbBalanceName.getValidValue(A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBalanceName.CurrentValue = StringUtil.RTrim( A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBalanceName_Internalname, "Values", cmbBalanceName.ToJavascriptSource(), true);
         }
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Balance", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Balance.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Balance.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceCredit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceCredit_Internalname, "Credito", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBalanceCredit_Internalname, StringUtil.LTrim( StringUtil.NToC( A24BalanceCredit, 14, 2, ",", "")), ((edtBalanceCredit_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A24BalanceCredit, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A24BalanceCredit, "$ Z,ZZZ,ZZZ.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceCredit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBalanceCredit_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceDateMade_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceDateMade_Internalname, "Fecha Creada", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBalanceDateMade_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBalanceDateMade_Internalname, context.localUtil.Format(A27BalanceDateMade, "99/99/99"), context.localUtil.Format( A27BalanceDateMade, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceDateMade_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBalanceDateMade_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Balance.htm");
            GxWebStd.gx_bitmap( context, edtBalanceDateMade_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBalanceDateMade_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Balance.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceMonths_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceMonths_Internalname, "Meses", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBalanceMonths_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28BalanceMonths), 4, 0, ",", "")), ((edtBalanceMonths_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A28BalanceMonths), "ZZZ9")) : context.localUtil.Format( (decimal)(A28BalanceMonths), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceMonths_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBalanceMonths_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBalanceName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBalanceName_Internalname, "Contrato", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBalanceName, cmbBalanceName_Internalname, StringUtil.RTrim( A29BalanceName), 1, cmbBalanceName_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbBalanceName.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_Balance.htm");
            cmbBalanceName.CurrentValue = StringUtil.RTrim( A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBalanceName_Internalname, "Values", (String)(cmbBalanceName.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersId_Internalname, "Clientes Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_Balance.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceTotalAbono_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceTotalAbono_Internalname, "Total Abono", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceTotalAbono_Internalname, StringUtil.LTrim( StringUtil.NToC( A32BalanceTotalAbono, 14, 2, ",", "")), ((edtBalanceTotalAbono_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A32BalanceTotalAbono, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A32BalanceTotalAbono, "$ Z,ZZZ,ZZZ.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceTotalAbono_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBalanceTotalAbono_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceSaldo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceSaldo_Internalname, "Saldo al Dia", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceSaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A34BalanceSaldo, 14, 2, ",", "")), ((edtBalanceSaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A34BalanceSaldo, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A34BalanceSaldo, "$ Z,ZZZ,ZZZ.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceSaldo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBalanceSaldo_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHistorytable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlehistory_Internalname, "Historial", "", "", lblTitlehistory_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridbalance_history( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Balance.htm");
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

      protected void gxdraw_Gridbalance_history( )
      {
         /*  Grid Control  */
         Gridbalance_historyContainer.AddObjectProperty("GridName", "Gridbalance_history");
         Gridbalance_historyContainer.AddObjectProperty("Header", subGridbalance_history_Header);
         Gridbalance_historyContainer.AddObjectProperty("Class", "Grid");
         Gridbalance_historyContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Backcolorstyle), 1, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("CmpContext", "");
         Gridbalance_historyContainer.AddObjectProperty("InMasterPage", "false");
         Gridbalance_historyColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbalance_historyColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8HistoryId), 4, 0, ".", "")));
         Gridbalance_historyColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryId_Enabled), 5, 0, ".", "")));
         Gridbalance_historyContainer.AddColumnProperties(Gridbalance_historyColumn);
         Gridbalance_historyColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbalance_historyColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A33HistoryAbono, 14, 2, ".", "")));
         Gridbalance_historyColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryAbono_Enabled), 5, 0, ".", "")));
         Gridbalance_historyContainer.AddColumnProperties(Gridbalance_historyColumn);
         Gridbalance_historyColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbalance_historyColumn.AddObjectProperty("Value", context.localUtil.Format(A25HistoryDate, "99/99/99"));
         Gridbalance_historyColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryDate_Enabled), 5, 0, ".", "")));
         Gridbalance_historyContainer.AddColumnProperties(Gridbalance_historyColumn);
         Gridbalance_historyColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbalance_historyColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HistoryType), 4, 0, ".", "")));
         Gridbalance_historyColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbHistoryType.Enabled), 5, 0, ".", "")));
         Gridbalance_historyContainer.AddColumnProperties(Gridbalance_historyColumn);
         Gridbalance_historyContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Selectedindex), 4, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Allowselection), 1, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Selectioncolor), 9, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Allowhovering), 1, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Hoveringcolor), 9, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Allowcollapsing), 1, 0, ".", "")));
         Gridbalance_historyContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbalance_history_Collapsed), 1, 0, ".", "")));
         nGXsfl_73_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount5 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_5 = 1;
               ScanStart035( ) ;
               while ( RcdFound5 != 0 )
               {
                  init_level_properties5( ) ;
                  getByPrimaryKey035( ) ;
                  AddRow035( ) ;
                  ScanNext035( ) ;
               }
               ScanEnd035( ) ;
               nBlankRcdCount5 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B30BalanceLastLine = A30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            B32BalanceTotalAbono = A32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            standaloneNotModal035( ) ;
            standaloneModal035( ) ;
            sMode5 = Gx_mode;
            while ( nGXsfl_73_idx < nRC_GXsfl_73 )
            {
               bGXsfl_73_Refreshing = true;
               ReadRow035( ) ;
               edtHistoryId_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryId_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtHistoryAbono_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYABONO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryAbono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryAbono_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtHistoryDate_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYDATE_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryDate_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               cmbHistoryType.Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYTYPE_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistoryType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistoryType.Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               if ( ( nRcdExists_5 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal035( ) ;
               }
               SendRow035( ) ;
               bGXsfl_73_Refreshing = false;
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A30BalanceLastLine = B30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            A32BalanceTotalAbono = B32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount5 = 5;
            nRcdExists_5 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart035( ) ;
               while ( RcdFound5 != 0 )
               {
                  sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_735( ) ;
                  init_level_properties5( ) ;
                  standaloneNotModal035( ) ;
                  getByPrimaryKey035( ) ;
                  standaloneModal035( ) ;
                  AddRow035( ) ;
                  ScanNext035( ) ;
               }
               ScanEnd035( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode5 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_735( ) ;
            InitAll035( ) ;
            init_level_properties5( ) ;
            B30BalanceLastLine = A30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            B32BalanceTotalAbono = A32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            standaloneNotModal035( ) ;
            standaloneModal035( ) ;
            nRcdExists_5 = 0;
            nIsMod_5 = 0;
            nRcdDeleted_5 = 0;
            nBlankRcdCount5 = (short)(nBlankRcdUsr5+nBlankRcdCount5);
            fRowAdded = 0;
            while ( nBlankRcdCount5 > 0 )
            {
               AddRow035( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtHistoryAbono_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount5 = (short)(nBlankRcdCount5-1);
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A30BalanceLastLine = B30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            A32BalanceTotalAbono = B32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridbalance_historyContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridbalance_history", Gridbalance_historyContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridbalance_historyContainerData", Gridbalance_historyContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridbalance_historyContainerData"+"V", Gridbalance_historyContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridbalance_historyContainerData"+"V"+"\" value='"+Gridbalance_historyContainer.GridValuesHidden()+"'/>") ;
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
         E11032 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBalanceCredit_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBalanceCredit_Internalname), ",", ".") > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BALANCECREDIT");
                  AnyError = 1;
                  GX_FocusControl = edtBalanceCredit_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A24BalanceCredit = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
               }
               else
               {
                  A24BalanceCredit = context.localUtil.CToN( cgiGet( edtBalanceCredit_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtBalanceDateMade_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Balance Fecha Creada"}), 1, "BALANCEDATEMADE");
                  AnyError = 1;
                  GX_FocusControl = edtBalanceDateMade_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A27BalanceDateMade = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
               }
               else
               {
                  A27BalanceDateMade = context.localUtil.CToD( cgiGet( edtBalanceDateMade_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtBalanceMonths_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBalanceMonths_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BALANCEMONTHS");
                  AnyError = 1;
                  GX_FocusControl = edtBalanceMonths_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A28BalanceMonths = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
               }
               else
               {
                  A28BalanceMonths = (short)(context.localUtil.CToN( cgiGet( edtBalanceMonths_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
               }
               cmbBalanceName.Name = cmbBalanceName_Internalname;
               cmbBalanceName.CurrentValue = cgiGet( cmbBalanceName_Internalname);
               A29BalanceName = cgiGet( cmbBalanceName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USERSID");
                  AnyError = 1;
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A3UsersId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
               }
               else
               {
                  A3UsersId = (short)(context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
               }
               A32BalanceTotalAbono = context.localUtil.CToN( cgiGet( edtBalanceTotalAbono_Internalname), ",", ".");
               n32BalanceTotalAbono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               A34BalanceSaldo = context.localUtil.CToN( cgiGet( edtBalanceSaldo_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
               /* Read saved values. */
               Z7BalanceId = (short)(context.localUtil.CToN( cgiGet( "Z7BalanceId"), ",", "."));
               Z24BalanceCredit = context.localUtil.CToN( cgiGet( "Z24BalanceCredit"), ",", ".");
               Z27BalanceDateMade = context.localUtil.CToD( cgiGet( "Z27BalanceDateMade"), 0);
               Z28BalanceMonths = (short)(context.localUtil.CToN( cgiGet( "Z28BalanceMonths"), ",", "."));
               Z29BalanceName = cgiGet( "Z29BalanceName");
               Z30BalanceLastLine = (short)(context.localUtil.CToN( cgiGet( "Z30BalanceLastLine"), ",", "."));
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               A30BalanceLastLine = (short)(context.localUtil.CToN( cgiGet( "Z30BalanceLastLine"), ",", "."));
               O30BalanceLastLine = (short)(context.localUtil.CToN( cgiGet( "O30BalanceLastLine"), ",", "."));
               O32BalanceTotalAbono = context.localUtil.CToN( cgiGet( "O32BalanceTotalAbono"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_73 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_73"), ",", "."));
               N3UsersId = (short)(context.localUtil.CToN( cgiGet( "N3UsersId"), ",", "."));
               AV7BalanceId = (short)(context.localUtil.CToN( cgiGet( "vBALANCEID"), ",", "."));
               A7BalanceId = (short)(context.localUtil.CToN( cgiGet( "BALANCEID"), ",", "."));
               AV11Insert_UsersId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_USERSID"), ",", "."));
               A30BalanceLastLine = (short)(context.localUtil.CToN( cgiGet( "BALANCELASTLINE"), ",", "."));
               A4UsersName = cgiGet( "USERSNAME");
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Balance";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("balance:[SecurityCheckFailed value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
                  GXUtil.WriteLog("balance:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("balance:[SecurityCheckFailed value for]"+"BalanceId:"+context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9"));
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
                  A7BalanceId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
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
                     sMode4 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode4;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound4 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
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
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12032 ();
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
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll034( ) ;
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
            DisableAttributes034( ) ;
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

      protected void CONFIRM_030( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls034( ) ;
            }
            else
            {
               CheckExtendedTable034( ) ;
               CloseExtendedTableCursors034( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode4 = Gx_mode;
            CONFIRM_035( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode4;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_035( )
      {
         s30BalanceLastLine = O30BalanceLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         s32BalanceTotalAbono = O32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         s34BalanceSaldo = O34BalanceSaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow035( ) ;
            if ( ( nRcdExists_5 != 0 ) || ( nIsMod_5 != 0 ) )
            {
               GetKey035( ) ;
               if ( ( nRcdExists_5 == 0 ) && ( nRcdDeleted_5 == 0 ) )
               {
                  if ( RcdFound5 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate035( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable035( ) ;
                        CloseExtendedTableCursors035( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O30BalanceLastLine = A30BalanceLastLine;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                        O32BalanceTotalAbono = A32BalanceTotalAbono;
                        n32BalanceTotalAbono = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                        O34BalanceSaldo = A34BalanceSaldo;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
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
                  if ( RcdFound5 != 0 )
                  {
                     if ( nRcdDeleted_5 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey035( ) ;
                        Load035( ) ;
                        BeforeValidate035( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls035( ) ;
                           O30BalanceLastLine = A30BalanceLastLine;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                           O32BalanceTotalAbono = A32BalanceTotalAbono;
                           n32BalanceTotalAbono = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                           O34BalanceSaldo = A34BalanceSaldo;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_5 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate035( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable035( ) ;
                              CloseExtendedTableCursors035( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O30BalanceLastLine = A30BalanceLastLine;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                              O32BalanceTotalAbono = A32BalanceTotalAbono;
                              n32BalanceTotalAbono = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                              O34BalanceSaldo = A34BalanceSaldo;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_5 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            ChangePostValue( edtHistoryId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8HistoryId), 4, 0, ",", ""))) ;
            ChangePostValue( edtHistoryAbono_Internalname, StringUtil.LTrim( StringUtil.NToC( A33HistoryAbono, 14, 2, ",", ""))) ;
            ChangePostValue( edtHistoryDate_Internalname, context.localUtil.Format(A25HistoryDate, "99/99/99")) ;
            ChangePostValue( cmbHistoryType_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HistoryType), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z8HistoryId_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8HistoryId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33HistoryAbono_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z33HistoryAbono, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z25HistoryDate_"+sGXsfl_73_idx, context.localUtil.DToC( Z25HistoryDate, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z26HistoryType_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26HistoryType), 4, 0, ",", ""))) ;
            ChangePostValue( "T33HistoryAbono_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( O33HistoryAbono, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ",", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "HISTORYID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYABONO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryAbono_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYDATE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryDate_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYTYPE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbHistoryType.Enabled), 5, 0, ".", ""))) ;
            }
         }
         O30BalanceLastLine = s30BalanceLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         O32BalanceTotalAbono = s32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         O34BalanceSaldo = s34BalanceSaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
         AV11Insert_UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_UsersId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "UsersId") == 0 )
               {
                  AV11Insert_UsersId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_UsersId), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwbalance.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z24BalanceCredit = T00035_A24BalanceCredit[0];
               Z27BalanceDateMade = T00035_A27BalanceDateMade[0];
               Z28BalanceMonths = T00035_A28BalanceMonths[0];
               Z29BalanceName = T00035_A29BalanceName[0];
               Z30BalanceLastLine = T00035_A30BalanceLastLine[0];
               Z3UsersId = T00035_A3UsersId[0];
            }
            else
            {
               Z24BalanceCredit = A24BalanceCredit;
               Z27BalanceDateMade = A27BalanceDateMade;
               Z28BalanceMonths = A28BalanceMonths;
               Z29BalanceName = A29BalanceName;
               Z30BalanceLastLine = A30BalanceLastLine;
               Z3UsersId = A3UsersId;
            }
         }
         if ( GX_JID == -15 )
         {
            Z7BalanceId = A7BalanceId;
            Z24BalanceCredit = A24BalanceCredit;
            Z27BalanceDateMade = A27BalanceDateMade;
            Z28BalanceMonths = A28BalanceMonths;
            Z29BalanceName = A29BalanceName;
            Z30BalanceLastLine = A30BalanceLastLine;
            Z3UsersId = A3UsersId;
            Z32BalanceTotalAbono = A32BalanceTotalAbono;
            Z4UsersName = A4UsersName;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USERSID"+"'), id:'"+"USERSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BalanceId) )
         {
            A7BalanceId = AV7BalanceId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
         }
         /* Using cursor T00038 */
         pr_default.execute(5, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            A32BalanceTotalAbono = T00038_A32BalanceTotalAbono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            n32BalanceTotalAbono = T00038_n32BalanceTotalAbono[0];
         }
         else
         {
            A32BalanceTotalAbono = 0;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         O32BalanceTotalAbono = A32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         pr_default.close(5);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_UsersId) )
         {
            edtUsersId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         }
         else
         {
            edtUsersId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_UsersId) )
         {
            A3UsersId = AV11Insert_UsersId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV14Pgmname = "Balance";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T00036 */
            pr_default.execute(4, new Object[] {A3UsersId});
            A4UsersName = T00036_A4UsersName[0];
            pr_default.close(4);
         }
      }

      protected void Load034( )
      {
         /* Using cursor T000310 */
         pr_default.execute(6, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound4 = 1;
            A24BalanceCredit = T000310_A24BalanceCredit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
            A27BalanceDateMade = T000310_A27BalanceDateMade[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
            A28BalanceMonths = T000310_A28BalanceMonths[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
            A29BalanceName = T000310_A29BalanceName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
            A4UsersName = T000310_A4UsersName[0];
            A30BalanceLastLine = T000310_A30BalanceLastLine[0];
            A3UsersId = T000310_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A32BalanceTotalAbono = T000310_A32BalanceTotalAbono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            n32BalanceTotalAbono = T000310_n32BalanceTotalAbono[0];
            ZM034( -15) ;
         }
         pr_default.close(6);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
         O32BalanceTotalAbono = A32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         AV14Pgmname = "Balance";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
      }

      protected void CheckExtendedTable034( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV14Pgmname = "Balance";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         if ( ! ( (DateTime.MinValue==A27BalanceDateMade) || ( A27BalanceDateMade >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Balance Fecha Creada fuera de rango", "OutOfRange", 1, "BALANCEDATEMADE");
            AnyError = 1;
            GX_FocusControl = edtBalanceDateMade_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A4UsersName = T00036_A4UsersName[0];
         pr_default.close(4);
         A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
      }

      protected void CloseExtendedTableCursors034( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_16( short A3UsersId )
      {
         /* Using cursor T000311 */
         pr_default.execute(7, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A4UsersName = T000311_A4UsersName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4UsersName))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(7);
      }

      protected void GetKey034( )
      {
         /* Using cursor T000312 */
         pr_default.execute(8, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM034( 15) ;
            RcdFound4 = 1;
            A7BalanceId = T00035_A7BalanceId[0];
            A24BalanceCredit = T00035_A24BalanceCredit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
            A27BalanceDateMade = T00035_A27BalanceDateMade[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
            A28BalanceMonths = T00035_A28BalanceMonths[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
            A29BalanceName = T00035_A29BalanceName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
            A30BalanceLastLine = T00035_A30BalanceLastLine[0];
            A3UsersId = T00035_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            O30BalanceLastLine = A30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            Z7BalanceId = A7BalanceId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load034( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey034( ) ;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey034( ) ;
         if ( RcdFound4 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0;
         /* Using cursor T000313 */
         pr_default.execute(9, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000313_A7BalanceId[0] < A7BalanceId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000313_A7BalanceId[0] > A7BalanceId ) ) )
            {
               A7BalanceId = T000313_A7BalanceId[0];
               RcdFound4 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T000314 */
         pr_default.execute(10, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000314_A7BalanceId[0] > A7BalanceId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000314_A7BalanceId[0] < A7BalanceId ) ) )
            {
               A7BalanceId = T000314_A7BalanceId[0];
               RcdFound4 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey034( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A30BalanceLastLine = O30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            A32BalanceTotalAbono = O32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            A34BalanceSaldo = O34BalanceSaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
            GX_FocusControl = edtBalanceCredit_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert034( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A7BalanceId != Z7BalanceId )
               {
                  A7BalanceId = Z7BalanceId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A30BalanceLastLine = O30BalanceLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                  A32BalanceTotalAbono = O32BalanceTotalAbono;
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  A34BalanceSaldo = O34BalanceSaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBalanceCredit_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A30BalanceLastLine = O30BalanceLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                  A32BalanceTotalAbono = O32BalanceTotalAbono;
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  A34BalanceSaldo = O34BalanceSaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                  Update034( ) ;
                  GX_FocusControl = edtBalanceCredit_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A7BalanceId != Z7BalanceId )
               {
                  /* Insert record */
                  A30BalanceLastLine = O30BalanceLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                  A32BalanceTotalAbono = O32BalanceTotalAbono;
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  A34BalanceSaldo = O34BalanceSaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                  GX_FocusControl = edtBalanceCredit_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert034( ) ;
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
                     A30BalanceLastLine = O30BalanceLastLine;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                     A32BalanceTotalAbono = O32BalanceTotalAbono;
                     n32BalanceTotalAbono = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                     A34BalanceSaldo = O34BalanceSaldo;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                     GX_FocusControl = edtBalanceCredit_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert034( ) ;
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
         if ( A7BalanceId != Z7BalanceId )
         {
            A7BalanceId = Z7BalanceId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "");
            AnyError = 1;
         }
         else
         {
            A30BalanceLastLine = O30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            A32BalanceTotalAbono = O32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            A34BalanceSaldo = O34BalanceSaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBalanceCredit_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00034 */
            pr_default.execute(2, new Object[] {A7BalanceId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Balance"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(2) == 101) || ( Z24BalanceCredit != T00034_A24BalanceCredit[0] ) || ( Z27BalanceDateMade != T00034_A27BalanceDateMade[0] ) || ( Z28BalanceMonths != T00034_A28BalanceMonths[0] ) || ( StringUtil.StrCmp(Z29BalanceName, T00034_A29BalanceName[0]) != 0 ) || ( Z30BalanceLastLine != T00034_A30BalanceLastLine[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z3UsersId != T00034_A3UsersId[0] ) )
            {
               if ( Z24BalanceCredit != T00034_A24BalanceCredit[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"BalanceCredit");
                  GXUtil.WriteLogRaw("Old: ",Z24BalanceCredit);
                  GXUtil.WriteLogRaw("Current: ",T00034_A24BalanceCredit[0]);
               }
               if ( Z27BalanceDateMade != T00034_A27BalanceDateMade[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"BalanceDateMade");
                  GXUtil.WriteLogRaw("Old: ",Z27BalanceDateMade);
                  GXUtil.WriteLogRaw("Current: ",T00034_A27BalanceDateMade[0]);
               }
               if ( Z28BalanceMonths != T00034_A28BalanceMonths[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"BalanceMonths");
                  GXUtil.WriteLogRaw("Old: ",Z28BalanceMonths);
                  GXUtil.WriteLogRaw("Current: ",T00034_A28BalanceMonths[0]);
               }
               if ( StringUtil.StrCmp(Z29BalanceName, T00034_A29BalanceName[0]) != 0 )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"BalanceName");
                  GXUtil.WriteLogRaw("Old: ",Z29BalanceName);
                  GXUtil.WriteLogRaw("Current: ",T00034_A29BalanceName[0]);
               }
               if ( Z30BalanceLastLine != T00034_A30BalanceLastLine[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"BalanceLastLine");
                  GXUtil.WriteLogRaw("Old: ",Z30BalanceLastLine);
                  GXUtil.WriteLogRaw("Current: ",T00034_A30BalanceLastLine[0]);
               }
               if ( Z3UsersId != T00034_A3UsersId[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"UsersId");
                  GXUtil.WriteLogRaw("Old: ",Z3UsersId);
                  GXUtil.WriteLogRaw("Current: ",T00034_A3UsersId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Balance"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM034( 0) ;
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000315 */
                     pr_default.execute(11, new Object[] {A24BalanceCredit, A27BalanceDateMade, A28BalanceMonths, A29BalanceName, A30BalanceLastLine, A3UsersId});
                     A7BalanceId = T000315_A7BalanceId[0];
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Balance") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel034( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption030( ) ;
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
               Load034( ) ;
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void Update034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000316 */
                     pr_default.execute(12, new Object[] {A24BalanceCredit, A27BalanceDateMade, A28BalanceMonths, A29BalanceName, A30BalanceLastLine, A3UsersId, A7BalanceId});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Balance") ;
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Balance"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel034( ) ;
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
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
      }

      protected void delete( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls034( ) ;
            AfterConfirm034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete034( ) ;
               if ( AnyError == 0 )
               {
                  A30BalanceLastLine = O30BalanceLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                  A32BalanceTotalAbono = O32BalanceTotalAbono;
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  A34BalanceSaldo = O34BalanceSaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                  ScanStart035( ) ;
                  while ( RcdFound5 != 0 )
                  {
                     getByPrimaryKey035( ) ;
                     Delete035( ) ;
                     ScanNext035( ) ;
                     O30BalanceLastLine = A30BalanceLastLine;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
                     O32BalanceTotalAbono = A32BalanceTotalAbono;
                     n32BalanceTotalAbono = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                     O34BalanceSaldo = A34BalanceSaldo;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
                  }
                  ScanEnd035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000317 */
                     pr_default.execute(13, new Object[] {A7BalanceId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Balance") ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel034( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Balance";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000318 */
            pr_default.execute(14, new Object[] {A3UsersId});
            A4UsersName = T000318_A4UsersName[0];
            pr_default.close(14);
            A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         }
      }

      protected void ProcessNestedLevel035( )
      {
         s30BalanceLastLine = O30BalanceLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         s32BalanceTotalAbono = O32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         s34BalanceSaldo = O34BalanceSaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow035( ) ;
            if ( ( nRcdExists_5 != 0 ) || ( nIsMod_5 != 0 ) )
            {
               standaloneNotModal035( ) ;
               GetKey035( ) ;
               if ( ( nRcdExists_5 == 0 ) && ( nRcdDeleted_5 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert035( ) ;
               }
               else
               {
                  if ( RcdFound5 != 0 )
                  {
                     if ( ( nRcdDeleted_5 != 0 ) && ( nRcdExists_5 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete035( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_5 != 0 ) && ( nRcdExists_5 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update035( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_5 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               O30BalanceLastLine = A30BalanceLastLine;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
               O32BalanceTotalAbono = A32BalanceTotalAbono;
               n32BalanceTotalAbono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               O34BalanceSaldo = A34BalanceSaldo;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
            }
            ChangePostValue( edtHistoryId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8HistoryId), 4, 0, ",", ""))) ;
            ChangePostValue( edtHistoryAbono_Internalname, StringUtil.LTrim( StringUtil.NToC( A33HistoryAbono, 14, 2, ",", ""))) ;
            ChangePostValue( edtHistoryDate_Internalname, context.localUtil.Format(A25HistoryDate, "99/99/99")) ;
            ChangePostValue( cmbHistoryType_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HistoryType), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z8HistoryId_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8HistoryId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33HistoryAbono_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z33HistoryAbono, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z25HistoryDate_"+sGXsfl_73_idx, context.localUtil.DToC( Z25HistoryDate, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z26HistoryType_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26HistoryType), 4, 0, ",", ""))) ;
            ChangePostValue( "T33HistoryAbono_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( O33HistoryAbono, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ",", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "HISTORYID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYABONO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryAbono_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYDATE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryDate_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HISTORYTYPE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbHistoryType.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll035( ) ;
         if ( AnyError != 0 )
         {
            O30BalanceLastLine = s30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            O32BalanceTotalAbono = s32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            O34BalanceSaldo = s34BalanceSaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         }
         nRcdExists_5 = 0;
         nIsMod_5 = 0;
         nRcdDeleted_5 = 0;
      }

      protected void ProcessLevel034( )
      {
         /* Save parent mode. */
         sMode4 = Gx_mode;
         ProcessNestedLevel035( ) ;
         if ( AnyError != 0 )
         {
            O30BalanceLastLine = s30BalanceLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            O32BalanceTotalAbono = s32BalanceTotalAbono;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            O34BalanceSaldo = s34BalanceSaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000319 */
         pr_default.execute(15, new Object[] {A30BalanceLastLine, A7BalanceId});
         pr_default.close(15);
         dsDefault.SmartCacheProvider.SetUpdated("Balance") ;
      }

      protected void EndLevel034( )
      {
         pr_default.close(2);
         if ( AnyError == 0 )
         {
            BeforeComplete034( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            context.CommitDataStores("balance",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
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
            pr_default.close(14);
            context.RollbackDataStores("balance",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart034( )
      {
         /* Scan By routine */
         /* Using cursor T000320 */
         pr_default.execute(16);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound4 = 1;
            A7BalanceId = T000320_A7BalanceId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext034( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound4 = 1;
            A7BalanceId = T000320_A7BalanceId[0];
         }
      }

      protected void ScanEnd034( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate034( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes034( )
      {
         edtBalanceCredit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBalanceCredit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceCredit_Enabled), 5, 0)), true);
         edtBalanceDateMade_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBalanceDateMade_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceDateMade_Enabled), 5, 0)), true);
         edtBalanceMonths_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBalanceMonths_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceMonths_Enabled), 5, 0)), true);
         cmbBalanceName.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBalanceName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBalanceName.Enabled), 5, 0)), true);
         edtUsersId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         edtBalanceTotalAbono_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBalanceTotalAbono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceTotalAbono_Enabled), 5, 0)), true);
         edtBalanceSaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBalanceSaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceSaldo_Enabled), 5, 0)), true);
      }

      protected void ZM035( short GX_JID )
      {
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z33HistoryAbono = T00033_A33HistoryAbono[0];
               Z25HistoryDate = T00033_A25HistoryDate[0];
               Z26HistoryType = T00033_A26HistoryType[0];
            }
            else
            {
               Z33HistoryAbono = A33HistoryAbono;
               Z25HistoryDate = A25HistoryDate;
               Z26HistoryType = A26HistoryType;
            }
         }
         if ( GX_JID == -18 )
         {
            Z7BalanceId = A7BalanceId;
            Z8HistoryId = A8HistoryId;
            Z33HistoryAbono = A33HistoryAbono;
            Z25HistoryDate = A25HistoryDate;
            Z26HistoryType = A26HistoryType;
         }
      }

      protected void standaloneNotModal035( )
      {
         edtHistoryId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryId_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
      }

      protected void standaloneModal035( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A30BalanceLastLine = (short)(O30BalanceLastLine+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A8HistoryId = A30BalanceLastLine;
         }
      }

      protected void Load035( )
      {
         /* Using cursor T000321 */
         pr_default.execute(17, new Object[] {A7BalanceId, A8HistoryId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound5 = 1;
            A33HistoryAbono = T000321_A33HistoryAbono[0];
            A25HistoryDate = T000321_A25HistoryDate[0];
            A26HistoryType = T000321_A26HistoryType[0];
            ZM035( -18) ;
         }
         pr_default.close(17);
         OnLoadActions035( ) ;
      }

      protected void OnLoadActions035( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono);
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono-O33HistoryAbono);
               n32BalanceTotalAbono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono-O33HistoryAbono);
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               }
            }
         }
         A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
      }

      protected void CheckExtendedTable035( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal035( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono);
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono-O33HistoryAbono);
               n32BalanceTotalAbono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono-O33HistoryAbono);
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               }
            }
         }
         A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         if ( ! ( (DateTime.MinValue==A25HistoryDate) || ( A25HistoryDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "HISTORYDATE_" + sGXsfl_73_idx;
            GX_msglist.addItem("Campo Historial Fecha fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtHistoryDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors035( )
      {
      }

      protected void enableDisable035( )
      {
      }

      protected void GetKey035( )
      {
         /* Using cursor T000322 */
         pr_default.execute(18, new Object[] {A7BalanceId, A8HistoryId});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey035( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A7BalanceId, A8HistoryId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM035( 18) ;
            RcdFound5 = 1;
            InitializeNonKey035( ) ;
            A8HistoryId = T00033_A8HistoryId[0];
            A33HistoryAbono = T00033_A33HistoryAbono[0];
            A25HistoryDate = T00033_A25HistoryDate[0];
            A26HistoryType = T00033_A26HistoryType[0];
            O33HistoryAbono = A33HistoryAbono;
            Z7BalanceId = A7BalanceId;
            Z8HistoryId = A8HistoryId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load035( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey035( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal035( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes035( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A7BalanceId, A8HistoryId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BalanceHistory"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z33HistoryAbono != T00032_A33HistoryAbono[0] ) || ( Z25HistoryDate != T00032_A25HistoryDate[0] ) || ( Z26HistoryType != T00032_A26HistoryType[0] ) )
            {
               if ( Z33HistoryAbono != T00032_A33HistoryAbono[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"HistoryAbono");
                  GXUtil.WriteLogRaw("Old: ",Z33HistoryAbono);
                  GXUtil.WriteLogRaw("Current: ",T00032_A33HistoryAbono[0]);
               }
               if ( Z25HistoryDate != T00032_A25HistoryDate[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"HistoryDate");
                  GXUtil.WriteLogRaw("Old: ",Z25HistoryDate);
                  GXUtil.WriteLogRaw("Current: ",T00032_A25HistoryDate[0]);
               }
               if ( Z26HistoryType != T00032_A26HistoryType[0] )
               {
                  GXUtil.WriteLog("balance:[seudo value changed for attri]"+"HistoryType");
                  GXUtil.WriteLogRaw("Old: ",Z26HistoryType);
                  GXUtil.WriteLogRaw("Current: ",T00032_A26HistoryType[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BalanceHistory"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM035( 0) ;
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000323 */
                     pr_default.execute(19, new Object[] {A7BalanceId, A8HistoryId, A33HistoryAbono, A25HistoryDate, A26HistoryType});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("BalanceHistory") ;
                     if ( (pr_default.getStatus(19) == 1) )
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
               Load035( ) ;
            }
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void Update035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000324 */
                     pr_default.execute(20, new Object[] {A33HistoryAbono, A25HistoryDate, A26HistoryType, A7BalanceId, A8HistoryId});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("BalanceHistory") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BalanceHistory"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate035( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey035( ) ;
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
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void DeferredUpdate035( )
      {
      }

      protected void Delete035( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls035( ) ;
            AfterConfirm035( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete035( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000325 */
                  pr_default.execute(21, new Object[] {A7BalanceId, A8HistoryId});
                  pr_default.close(21);
                  dsDefault.SmartCacheProvider.SetUpdated("BalanceHistory") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel035( ) ;
         Gx_mode = sMode5;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls035( )
      {
         standaloneModal035( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono);
               n32BalanceTotalAbono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono+A33HistoryAbono-O33HistoryAbono);
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A32BalanceTotalAbono = (decimal)(O32BalanceTotalAbono-O33HistoryAbono);
                     n32BalanceTotalAbono = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  }
               }
            }
            A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         }
      }

      protected void EndLevel035( )
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

      public void ScanStart035( )
      {
         /* Scan By routine */
         /* Using cursor T000326 */
         pr_default.execute(22, new Object[] {A7BalanceId});
         RcdFound5 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound5 = 1;
            A8HistoryId = T000326_A8HistoryId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext035( )
      {
         /* Scan next routine */
         pr_default.readNext(22);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound5 = 1;
            A8HistoryId = T000326_A8HistoryId[0];
         }
      }

      protected void ScanEnd035( )
      {
         pr_default.close(22);
      }

      protected void AfterConfirm035( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert035( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate035( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete035( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete035( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate035( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes035( )
      {
         edtHistoryId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryId_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtHistoryAbono_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryAbono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryAbono_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtHistoryDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryDate_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         cmbHistoryType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistoryType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistoryType.Enabled), 5, 0)), !bGXsfl_73_Refreshing);
      }

      protected void send_integrity_lvl_hashes035( )
      {
      }

      protected void send_integrity_lvl_hashes034( )
      {
      }

      protected void SubsflControlProps_735( )
      {
         edtHistoryId_Internalname = "HISTORYID_"+sGXsfl_73_idx;
         edtHistoryAbono_Internalname = "HISTORYABONO_"+sGXsfl_73_idx;
         edtHistoryDate_Internalname = "HISTORYDATE_"+sGXsfl_73_idx;
         cmbHistoryType_Internalname = "HISTORYTYPE_"+sGXsfl_73_idx;
      }

      protected void SubsflControlProps_fel_735( )
      {
         edtHistoryId_Internalname = "HISTORYID_"+sGXsfl_73_fel_idx;
         edtHistoryAbono_Internalname = "HISTORYABONO_"+sGXsfl_73_fel_idx;
         edtHistoryDate_Internalname = "HISTORYDATE_"+sGXsfl_73_fel_idx;
         cmbHistoryType_Internalname = "HISTORYTYPE_"+sGXsfl_73_fel_idx;
      }

      protected void AddRow035( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_735( ) ;
         SendRow035( ) ;
      }

      protected void SendRow035( )
      {
         Gridbalance_historyRow = GXWebRow.GetNew(context);
         if ( subGridbalance_history_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridbalance_history_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridbalance_history_Class, "") != 0 )
            {
               subGridbalance_history_Linesclass = subGridbalance_history_Class+"Odd";
            }
         }
         else if ( subGridbalance_history_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridbalance_history_Backstyle = 0;
            subGridbalance_history_Backcolor = subGridbalance_history_Allbackcolor;
            if ( StringUtil.StrCmp(subGridbalance_history_Class, "") != 0 )
            {
               subGridbalance_history_Linesclass = subGridbalance_history_Class+"Uniform";
            }
         }
         else if ( subGridbalance_history_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridbalance_history_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridbalance_history_Class, "") != 0 )
            {
               subGridbalance_history_Linesclass = subGridbalance_history_Class+"Odd";
            }
            subGridbalance_history_Backcolor = (int)(0x0);
         }
         else if ( subGridbalance_history_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridbalance_history_Backstyle = 1;
            if ( ((int)(((nGXsfl_73_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridbalance_history_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridbalance_history_Class, "") != 0 )
               {
                  subGridbalance_history_Linesclass = subGridbalance_history_Class+"Odd";
               }
            }
            else
            {
               subGridbalance_history_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridbalance_history_Class, "") != 0 )
               {
                  subGridbalance_history_Linesclass = subGridbalance_history_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridbalance_historyRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHistoryId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8HistoryId), 4, 0, ",", "")),((edtHistoryId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8HistoryId), "ZZZ9")) : context.localUtil.Format( (decimal)(A8HistoryId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHistoryId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtHistoryId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridbalance_historyRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHistoryAbono_Internalname,StringUtil.LTrim( StringUtil.NToC( A33HistoryAbono, 14, 2, ",", "")),((edtHistoryAbono_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A33HistoryAbono, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A33HistoryAbono, "$ Z,ZZZ,ZZZ.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHistoryAbono_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtHistoryAbono_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"Currency",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridbalance_historyRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHistoryDate_Internalname,context.localUtil.Format(A25HistoryDate, "99/99/99"),context.localUtil.Format( A25HistoryDate, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHistoryDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtHistoryDate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_73_idx + "',73)\"";
         if ( ( cmbHistoryType.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "HISTORYTYPE_" + sGXsfl_73_idx;
            cmbHistoryType.Name = GXCCtl;
            cmbHistoryType.WebTags = "";
            cmbHistoryType.addItem("1", "A Tiempo", 0);
            cmbHistoryType.addItem("2", "Tarde", 0);
            if ( cmbHistoryType.ItemCount > 0 )
            {
               A26HistoryType = (short)(NumberUtil.Val( cmbHistoryType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A26HistoryType), 4, 0))), "."));
            }
         }
         /* ComboBox */
         Gridbalance_historyRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbHistoryType,(String)cmbHistoryType_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A26HistoryType), 4, 0)),(short)1,(String)cmbHistoryType_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,cmbHistoryType.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"",(String)"",(bool)true});
         cmbHistoryType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A26HistoryType), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistoryType_Internalname, "Values", (String)(cmbHistoryType.ToJavascriptSource()), !bGXsfl_73_Refreshing);
         context.httpAjaxContext.ajax_sending_grid_row(Gridbalance_historyRow);
         send_integrity_lvl_hashes035( ) ;
         GXCCtl = "Z8HistoryId_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8HistoryId), 4, 0, ",", "")));
         GXCCtl = "Z33HistoryAbono_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z33HistoryAbono, 10, 2, ",", "")));
         GXCCtl = "Z25HistoryDate_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z25HistoryDate, 0, "/"));
         GXCCtl = "Z26HistoryType_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26HistoryType), 4, 0, ",", "")));
         GXCCtl = "O33HistoryAbono_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O33HistoryAbono, 10, 2, ",", "")));
         GXCCtl = "nRcdDeleted_5_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_5_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ",", "")));
         GXCCtl = "nIsMod_5_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_73_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vBALANCEID_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BalanceId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "HISTORYID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HISTORYABONO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryAbono_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HISTORYDATE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHistoryDate_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HISTORYTYPE_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbHistoryType.Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridbalance_historyContainer.AddRow(Gridbalance_historyRow);
      }

      protected void ReadRow035( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_735( ) ;
         edtHistoryId_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtHistoryAbono_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYABONO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtHistoryDate_Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYDATE_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         cmbHistoryType.Enabled = (int)(context.localUtil.CToN( cgiGet( "HISTORYTYPE_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         A8HistoryId = (short)(context.localUtil.CToN( cgiGet( edtHistoryId_Internalname), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtHistoryAbono_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtHistoryAbono_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "HISTORYABONO_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtHistoryAbono_Internalname;
            wbErr = true;
            A33HistoryAbono = 0;
         }
         else
         {
            A33HistoryAbono = context.localUtil.CToN( cgiGet( edtHistoryAbono_Internalname), ",", ".");
         }
         if ( context.localUtil.VCDate( cgiGet( edtHistoryDate_Internalname), 2) == 0 )
         {
            GXCCtl = "HISTORYDATE_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Historial Fecha"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtHistoryDate_Internalname;
            wbErr = true;
            A25HistoryDate = DateTime.MinValue;
         }
         else
         {
            A25HistoryDate = context.localUtil.CToD( cgiGet( edtHistoryDate_Internalname), 2);
         }
         cmbHistoryType.Name = cmbHistoryType_Internalname;
         cmbHistoryType.CurrentValue = cgiGet( cmbHistoryType_Internalname);
         A26HistoryType = (short)(NumberUtil.Val( cgiGet( cmbHistoryType_Internalname), "."));
         GXCCtl = "Z8HistoryId_" + sGXsfl_73_idx;
         Z8HistoryId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z33HistoryAbono_" + sGXsfl_73_idx;
         Z33HistoryAbono = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "Z25HistoryDate_" + sGXsfl_73_idx;
         Z25HistoryDate = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "Z26HistoryType_" + sGXsfl_73_idx;
         Z26HistoryType = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O33HistoryAbono_" + sGXsfl_73_idx;
         O33HistoryAbono = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "nRcdDeleted_5_" + sGXsfl_73_idx;
         nRcdDeleted_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_5_" + sGXsfl_73_idx;
         nRcdExists_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_5_" + sGXsfl_73_idx;
         nIsMod_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtHistoryId_Enabled = edtHistoryId_Enabled;
      }

      protected void ConfirmValues030( )
      {
         nGXsfl_73_idx = 0;
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_735( ) ;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_735( ) ;
            ChangePostValue( "Z8HistoryId_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z8HistoryId_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z8HistoryId_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z33HistoryAbono_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z33HistoryAbono_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z33HistoryAbono_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z25HistoryDate_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z25HistoryDate_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z25HistoryDate_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z26HistoryType_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z26HistoryType_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z26HistoryType_"+sGXsfl_73_idx) ;
         }
         ChangePostValue( "O33HistoryAbono", cgiGet( "T33HistoryAbono")) ;
         DeletePostValue( "T33HistoryAbono") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118521253", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("balance.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BalanceId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Balance";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("balance:[SendSecurityCheck value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
         GXUtil.WriteLog("balance:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("balance:[SendSecurityCheck value for]"+"BalanceId:"+context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z7BalanceId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7BalanceId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z24BalanceCredit", StringUtil.LTrim( StringUtil.NToC( Z24BalanceCredit, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z27BalanceDateMade", context.localUtil.DToC( Z27BalanceDateMade, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z28BalanceMonths", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28BalanceMonths), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z29BalanceName", StringUtil.RTrim( Z29BalanceName));
         GxWebStd.gx_hidden_field( context, "Z30BalanceLastLine", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30BalanceLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O30BalanceLastLine", StringUtil.LTrim( StringUtil.NToC( (decimal)(O30BalanceLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O32BalanceTotalAbono", StringUtil.LTrim( StringUtil.NToC( O32BalanceTotalAbono, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_73", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_73_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBALANCEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BalanceId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBALANCEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BalanceId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "BALANCEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7BalanceId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "BALANCELASTLINE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A30BalanceLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USERSNAME", StringUtil.RTrim( A4UsersName));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
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
         return formatLink("balance.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BalanceId) ;
      }

      public override String GetPgmname( )
      {
         return "Balance" ;
      }

      public override String GetPgmdesc( )
      {
         return "Balance" ;
      }

      protected void InitializeNonKey034( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         A34BalanceSaldo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
         A24BalanceCredit = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
         A27BalanceDateMade = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
         A28BalanceMonths = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
         A29BalanceName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
         A4UsersName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
         A30BalanceLastLine = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         O30BalanceLastLine = A30BalanceLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
         O32BalanceTotalAbono = A32BalanceTotalAbono;
         n32BalanceTotalAbono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         Z24BalanceCredit = 0;
         Z27BalanceDateMade = DateTime.MinValue;
         Z28BalanceMonths = 0;
         Z29BalanceName = "";
         Z30BalanceLastLine = 0;
         Z3UsersId = 0;
      }

      protected void InitAll034( )
      {
         A7BalanceId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey035( )
      {
         A33HistoryAbono = 0;
         A25HistoryDate = DateTime.MinValue;
         A26HistoryType = 0;
         O33HistoryAbono = A33HistoryAbono;
         Z33HistoryAbono = 0;
         Z25HistoryDate = DateTime.MinValue;
         Z26HistoryType = 0;
      }

      protected void InitAll035( )
      {
         A8HistoryId = 0;
         InitializeNonKey035( ) ;
      }

      protected void StandaloneModalInsert035( )
      {
         A30BalanceLastLine = i30BalanceLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118521296", true);
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
         context.AddJavascriptSource("balance.js", "?2018101118521297", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties5( )
      {
         edtHistoryId_Enabled = defedtHistoryId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistoryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistoryId_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
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
         edtBalanceCredit_Internalname = "BALANCECREDIT";
         edtBalanceDateMade_Internalname = "BALANCEDATEMADE";
         edtBalanceMonths_Internalname = "BALANCEMONTHS";
         cmbBalanceName_Internalname = "BALANCENAME";
         edtUsersId_Internalname = "USERSID";
         edtBalanceTotalAbono_Internalname = "BALANCETOTALABONO";
         edtBalanceSaldo_Internalname = "BALANCESALDO";
         lblTitlehistory_Internalname = "TITLEHISTORY";
         edtHistoryId_Internalname = "HISTORYID";
         edtHistoryAbono_Internalname = "HISTORYABONO";
         edtHistoryDate_Internalname = "HISTORYDATE";
         cmbHistoryType_Internalname = "HISTORYTYPE";
         divHistorytable_Internalname = "HISTORYTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_3_Internalname = "PROMPT_3";
         subGridbalance_history_Internalname = "GRIDBALANCE_HISTORY";
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
         Form.Caption = "Balance";
         cmbHistoryType_Jsonclick = "";
         edtHistoryDate_Jsonclick = "";
         edtHistoryAbono_Jsonclick = "";
         edtHistoryId_Jsonclick = "";
         subGridbalance_history_Class = "Grid";
         subGridbalance_history_Backcolorstyle = 0;
         subGridbalance_history_Allowcollapsing = 0;
         subGridbalance_history_Allowselection = 0;
         cmbHistoryType.Enabled = 1;
         edtHistoryDate_Enabled = 1;
         edtHistoryAbono_Enabled = 1;
         edtHistoryId_Enabled = 0;
         subGridbalance_history_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtBalanceSaldo_Jsonclick = "";
         edtBalanceSaldo_Enabled = 0;
         edtBalanceTotalAbono_Jsonclick = "";
         edtBalanceTotalAbono_Enabled = 0;
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         edtUsersId_Jsonclick = "";
         edtUsersId_Enabled = 1;
         cmbBalanceName_Jsonclick = "";
         cmbBalanceName.Enabled = 1;
         edtBalanceMonths_Jsonclick = "";
         edtBalanceMonths_Enabled = 1;
         edtBalanceDateMade_Jsonclick = "";
         edtBalanceDateMade_Enabled = 1;
         edtBalanceCredit_Jsonclick = "";
         edtBalanceCredit_Enabled = 1;
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

      protected void gxnrGridbalance_history_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_735( ) ;
         while ( nGXsfl_73_idx <= nRC_GXsfl_73 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal035( ) ;
            standaloneModal035( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow035( ) ;
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_735( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridbalance_historyContainer));
         /* End function gxnrGridbalance_history_newrow */
      }

      protected void init_web_controls( )
      {
         cmbBalanceName.Name = "BALANCENAME";
         cmbBalanceName.WebTags = "";
         cmbBalanceName.addItem("Credito Personal", "Credito Personal", 0);
         cmbBalanceName.addItem("Credito PYME", "Credito PYME", 0);
         cmbBalanceName.addItem("Credito Automotriz", "Credito Automotriz", 0);
         cmbBalanceName.addItem("Credito Inmobiliario", "Credito Inmobiliario", 0);
         if ( cmbBalanceName.ItemCount > 0 )
         {
            A29BalanceName = cmbBalanceName.getValidValue(A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BalanceName", A29BalanceName);
         }
         GXCCtl = "HISTORYTYPE_" + sGXsfl_73_idx;
         cmbHistoryType.Name = GXCCtl;
         cmbHistoryType.WebTags = "";
         cmbHistoryType.addItem("1", "A Tiempo", 0);
         cmbHistoryType.addItem("2", "Tarde", 0);
         if ( cmbHistoryType.ItemCount > 0 )
         {
            A26HistoryType = (short)(NumberUtil.Val( cmbHistoryType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A26HistoryType), 4, 0))), "."));
         }
         /* End function init_web_controls */
      }

      public void Valid_Usersid( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A3UsersId = GX_Parm1;
         A4UsersName = GX_Parm2;
         /* Using cursor T000318 */
         pr_default.execute(14, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
         }
         A4UsersName = T000318_A4UsersName[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A4UsersName = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A4UsersName));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BalanceId',fld:'vBALANCEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BalanceId',fld:'vBALANCEID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_UsersId',fld:'vINSERT_USERSID',pic:'ZZZ9'},{av:'A7BalanceId',fld:'BALANCEID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z27BalanceDateMade = DateTime.MinValue;
         Z29BalanceName = "";
         Z25HistoryDate = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A29BalanceName = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A27BalanceDateMade = DateTime.MinValue;
         sImgUrl = "";
         lblTitlehistory_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridbalance_historyContainer = new GXWebGrid( context);
         Gridbalance_historyColumn = new GXWebColumn();
         A25HistoryDate = DateTime.MinValue;
         sMode5 = "";
         sStyleString = "";
         A4UsersName = "";
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode4 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z4UsersName = "";
         T00038_A32BalanceTotalAbono = new decimal[1] ;
         T00038_n32BalanceTotalAbono = new bool[] {false} ;
         T00036_A4UsersName = new String[] {""} ;
         T000310_A7BalanceId = new short[1] ;
         T000310_A24BalanceCredit = new decimal[1] ;
         T000310_A27BalanceDateMade = new DateTime[] {DateTime.MinValue} ;
         T000310_A28BalanceMonths = new short[1] ;
         T000310_A29BalanceName = new String[] {""} ;
         T000310_A4UsersName = new String[] {""} ;
         T000310_A30BalanceLastLine = new short[1] ;
         T000310_A3UsersId = new short[1] ;
         T000310_A32BalanceTotalAbono = new decimal[1] ;
         T000310_n32BalanceTotalAbono = new bool[] {false} ;
         T000311_A4UsersName = new String[] {""} ;
         T000312_A7BalanceId = new short[1] ;
         T00035_A7BalanceId = new short[1] ;
         T00035_A24BalanceCredit = new decimal[1] ;
         T00035_A27BalanceDateMade = new DateTime[] {DateTime.MinValue} ;
         T00035_A28BalanceMonths = new short[1] ;
         T00035_A29BalanceName = new String[] {""} ;
         T00035_A30BalanceLastLine = new short[1] ;
         T00035_A3UsersId = new short[1] ;
         T000313_A7BalanceId = new short[1] ;
         T000314_A7BalanceId = new short[1] ;
         T00034_A7BalanceId = new short[1] ;
         T00034_A24BalanceCredit = new decimal[1] ;
         T00034_A27BalanceDateMade = new DateTime[] {DateTime.MinValue} ;
         T00034_A28BalanceMonths = new short[1] ;
         T00034_A29BalanceName = new String[] {""} ;
         T00034_A30BalanceLastLine = new short[1] ;
         T00034_A3UsersId = new short[1] ;
         T000315_A7BalanceId = new short[1] ;
         T000318_A4UsersName = new String[] {""} ;
         T000320_A7BalanceId = new short[1] ;
         T000321_A7BalanceId = new short[1] ;
         T000321_A8HistoryId = new short[1] ;
         T000321_A33HistoryAbono = new decimal[1] ;
         T000321_A25HistoryDate = new DateTime[] {DateTime.MinValue} ;
         T000321_A26HistoryType = new short[1] ;
         GXCCtl = "";
         T000322_A7BalanceId = new short[1] ;
         T000322_A8HistoryId = new short[1] ;
         T00033_A7BalanceId = new short[1] ;
         T00033_A8HistoryId = new short[1] ;
         T00033_A33HistoryAbono = new decimal[1] ;
         T00033_A25HistoryDate = new DateTime[] {DateTime.MinValue} ;
         T00033_A26HistoryType = new short[1] ;
         T00032_A7BalanceId = new short[1] ;
         T00032_A8HistoryId = new short[1] ;
         T00032_A33HistoryAbono = new decimal[1] ;
         T00032_A25HistoryDate = new DateTime[] {DateTime.MinValue} ;
         T00032_A26HistoryType = new short[1] ;
         T000326_A7BalanceId = new short[1] ;
         T000326_A8HistoryId = new short[1] ;
         Gridbalance_historyRow = new GXWebRow();
         subGridbalance_history_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.balance__default(),
            new Object[][] {
                new Object[] {
               T00032_A7BalanceId, T00032_A8HistoryId, T00032_A33HistoryAbono, T00032_A25HistoryDate, T00032_A26HistoryType
               }
               , new Object[] {
               T00033_A7BalanceId, T00033_A8HistoryId, T00033_A33HistoryAbono, T00033_A25HistoryDate, T00033_A26HistoryType
               }
               , new Object[] {
               T00034_A7BalanceId, T00034_A24BalanceCredit, T00034_A27BalanceDateMade, T00034_A28BalanceMonths, T00034_A29BalanceName, T00034_A30BalanceLastLine, T00034_A3UsersId
               }
               , new Object[] {
               T00035_A7BalanceId, T00035_A24BalanceCredit, T00035_A27BalanceDateMade, T00035_A28BalanceMonths, T00035_A29BalanceName, T00035_A30BalanceLastLine, T00035_A3UsersId
               }
               , new Object[] {
               T00036_A4UsersName
               }
               , new Object[] {
               T00038_A32BalanceTotalAbono, T00038_n32BalanceTotalAbono
               }
               , new Object[] {
               T000310_A7BalanceId, T000310_A24BalanceCredit, T000310_A27BalanceDateMade, T000310_A28BalanceMonths, T000310_A29BalanceName, T000310_A4UsersName, T000310_A30BalanceLastLine, T000310_A3UsersId, T000310_A32BalanceTotalAbono, T000310_n32BalanceTotalAbono
               }
               , new Object[] {
               T000311_A4UsersName
               }
               , new Object[] {
               T000312_A7BalanceId
               }
               , new Object[] {
               T000313_A7BalanceId
               }
               , new Object[] {
               T000314_A7BalanceId
               }
               , new Object[] {
               T000315_A7BalanceId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000318_A4UsersName
               }
               , new Object[] {
               }
               , new Object[] {
               T000320_A7BalanceId
               }
               , new Object[] {
               T000321_A7BalanceId, T000321_A8HistoryId, T000321_A33HistoryAbono, T000321_A25HistoryDate, T000321_A26HistoryType
               }
               , new Object[] {
               T000322_A7BalanceId, T000322_A8HistoryId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000326_A7BalanceId, T000326_A8HistoryId
               }
            }
         );
         AV14Pgmname = "Balance";
      }

      private short wcpOAV7BalanceId ;
      private short Z7BalanceId ;
      private short Z28BalanceMonths ;
      private short Z30BalanceLastLine ;
      private short Z3UsersId ;
      private short O30BalanceLastLine ;
      private short nRC_GXsfl_73 ;
      private short nGXsfl_73_idx=1 ;
      private short N3UsersId ;
      private short Z8HistoryId ;
      private short Z26HistoryType ;
      private short nRcdDeleted_5 ;
      private short nRcdExists_5 ;
      private short nIsMod_5 ;
      private short GxWebError ;
      private short A3UsersId ;
      private short A30BalanceLastLine ;
      private short Gx_BScreen ;
      private short AV7BalanceId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A28BalanceMonths ;
      private short subGridbalance_history_Backcolorstyle ;
      private short A8HistoryId ;
      private short A26HistoryType ;
      private short subGridbalance_history_Allowselection ;
      private short subGridbalance_history_Allowhovering ;
      private short subGridbalance_history_Allowcollapsing ;
      private short subGridbalance_history_Collapsed ;
      private short nBlankRcdCount5 ;
      private short RcdFound5 ;
      private short B30BalanceLastLine ;
      private short nBlankRcdUsr5 ;
      private short A7BalanceId ;
      private short AV11Insert_UsersId ;
      private short RcdFound4 ;
      private short s30BalanceLastLine ;
      private short GX_JID ;
      private short subGridbalance_history_Backstyle ;
      private short gxajaxcallmode ;
      private short i30BalanceLastLine ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtBalanceCredit_Enabled ;
      private int edtBalanceDateMade_Enabled ;
      private int edtBalanceMonths_Enabled ;
      private int edtUsersId_Enabled ;
      private int imgprompt_3_Visible ;
      private int edtBalanceTotalAbono_Enabled ;
      private int edtBalanceSaldo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtHistoryId_Enabled ;
      private int edtHistoryAbono_Enabled ;
      private int edtHistoryDate_Enabled ;
      private int subGridbalance_history_Selectedindex ;
      private int subGridbalance_history_Selectioncolor ;
      private int subGridbalance_history_Hoveringcolor ;
      private int fRowAdded ;
      private int AV15GXV1 ;
      private int subGridbalance_history_Backcolor ;
      private int subGridbalance_history_Allbackcolor ;
      private int defedtHistoryId_Enabled ;
      private int idxLst ;
      private long GRIDBALANCE_HISTORY_nFirstRecordOnPage ;
      private decimal Z24BalanceCredit ;
      private decimal O32BalanceTotalAbono ;
      private decimal Z33HistoryAbono ;
      private decimal O33HistoryAbono ;
      private decimal A24BalanceCredit ;
      private decimal A32BalanceTotalAbono ;
      private decimal A34BalanceSaldo ;
      private decimal A33HistoryAbono ;
      private decimal B32BalanceTotalAbono ;
      private decimal s32BalanceTotalAbono ;
      private decimal s34BalanceSaldo ;
      private decimal O34BalanceSaldo ;
      private decimal T33HistoryAbono ;
      private decimal Z32BalanceTotalAbono ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z29BalanceName ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_73_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBalanceCredit_Internalname ;
      private String A29BalanceName ;
      private String cmbBalanceName_Internalname ;
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
      private String edtBalanceCredit_Jsonclick ;
      private String edtBalanceDateMade_Internalname ;
      private String edtBalanceDateMade_Jsonclick ;
      private String edtBalanceMonths_Internalname ;
      private String edtBalanceMonths_Jsonclick ;
      private String cmbBalanceName_Jsonclick ;
      private String edtUsersId_Internalname ;
      private String edtUsersId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_3_Internalname ;
      private String imgprompt_3_Link ;
      private String edtBalanceTotalAbono_Internalname ;
      private String edtBalanceTotalAbono_Jsonclick ;
      private String edtBalanceSaldo_Internalname ;
      private String edtBalanceSaldo_Jsonclick ;
      private String divHistorytable_Internalname ;
      private String lblTitlehistory_Internalname ;
      private String lblTitlehistory_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridbalance_history_Header ;
      private String sMode5 ;
      private String edtHistoryId_Internalname ;
      private String edtHistoryAbono_Internalname ;
      private String edtHistoryDate_Internalname ;
      private String cmbHistoryType_Internalname ;
      private String sStyleString ;
      private String A4UsersName ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode4 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z4UsersName ;
      private String GXCCtl ;
      private String sGXsfl_73_fel_idx="0001" ;
      private String subGridbalance_history_Class ;
      private String subGridbalance_history_Linesclass ;
      private String ROClassString ;
      private String edtHistoryId_Jsonclick ;
      private String edtHistoryAbono_Jsonclick ;
      private String edtHistoryDate_Jsonclick ;
      private String cmbHistoryType_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridbalance_history_Internalname ;
      private DateTime Z27BalanceDateMade ;
      private DateTime Z25HistoryDate ;
      private DateTime A27BalanceDateMade ;
      private DateTime A25HistoryDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n32BalanceTotalAbono ;
      private bool bGXsfl_73_Refreshing=false ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridbalance_historyContainer ;
      private GXWebRow Gridbalance_historyRow ;
      private GXWebColumn Gridbalance_historyColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBalanceName ;
      private GXCombobox cmbHistoryType ;
      private IDataStoreProvider pr_default ;
      private decimal[] T00038_A32BalanceTotalAbono ;
      private bool[] T00038_n32BalanceTotalAbono ;
      private String[] T00036_A4UsersName ;
      private short[] T000310_A7BalanceId ;
      private decimal[] T000310_A24BalanceCredit ;
      private DateTime[] T000310_A27BalanceDateMade ;
      private short[] T000310_A28BalanceMonths ;
      private String[] T000310_A29BalanceName ;
      private String[] T000310_A4UsersName ;
      private short[] T000310_A30BalanceLastLine ;
      private short[] T000310_A3UsersId ;
      private decimal[] T000310_A32BalanceTotalAbono ;
      private bool[] T000310_n32BalanceTotalAbono ;
      private String[] T000311_A4UsersName ;
      private short[] T000312_A7BalanceId ;
      private short[] T00035_A7BalanceId ;
      private decimal[] T00035_A24BalanceCredit ;
      private DateTime[] T00035_A27BalanceDateMade ;
      private short[] T00035_A28BalanceMonths ;
      private String[] T00035_A29BalanceName ;
      private short[] T00035_A30BalanceLastLine ;
      private short[] T00035_A3UsersId ;
      private short[] T000313_A7BalanceId ;
      private short[] T000314_A7BalanceId ;
      private short[] T00034_A7BalanceId ;
      private decimal[] T00034_A24BalanceCredit ;
      private DateTime[] T00034_A27BalanceDateMade ;
      private short[] T00034_A28BalanceMonths ;
      private String[] T00034_A29BalanceName ;
      private short[] T00034_A30BalanceLastLine ;
      private short[] T00034_A3UsersId ;
      private short[] T000315_A7BalanceId ;
      private String[] T000318_A4UsersName ;
      private short[] T000320_A7BalanceId ;
      private short[] T000321_A7BalanceId ;
      private short[] T000321_A8HistoryId ;
      private decimal[] T000321_A33HistoryAbono ;
      private DateTime[] T000321_A25HistoryDate ;
      private short[] T000321_A26HistoryType ;
      private short[] T000322_A7BalanceId ;
      private short[] T000322_A8HistoryId ;
      private short[] T00033_A7BalanceId ;
      private short[] T00033_A8HistoryId ;
      private decimal[] T00033_A33HistoryAbono ;
      private DateTime[] T00033_A25HistoryDate ;
      private short[] T00033_A26HistoryType ;
      private short[] T00032_A7BalanceId ;
      private short[] T00032_A8HistoryId ;
      private decimal[] T00032_A33HistoryAbono ;
      private DateTime[] T00032_A25HistoryDate ;
      private short[] T00032_A26HistoryType ;
      private short[] T000326_A7BalanceId ;
      private short[] T000326_A8HistoryId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class balance__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@BalanceCredit",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BalanceDateMade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BalanceMonths",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BalanceName",SqlDbType.Char,20,0} ,
          new Object[] {"@BalanceLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000316 ;
          prmT000316 = new Object[] {
          new Object[] {"@BalanceCredit",SqlDbType.Decimal,10,2} ,
          new Object[] {"@BalanceDateMade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BalanceMonths",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BalanceName",SqlDbType.Char,20,0} ,
          new Object[] {"@BalanceLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000317 ;
          prmT000317 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000319 ;
          prmT000319 = new Object[] {
          new Object[] {"@BalanceLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000320 ;
          prmT000320 = new Object[] {
          } ;
          Object[] prmT000321 ;
          prmT000321 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000322 ;
          prmT000322 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000323 ;
          prmT000323 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryAbono",SqlDbType.Decimal,10,2} ,
          new Object[] {"@HistoryDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@HistoryType",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000324 ;
          prmT000324 = new Object[] {
          new Object[] {"@HistoryAbono",SqlDbType.Decimal,10,2} ,
          new Object[] {"@HistoryDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@HistoryType",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000325 ;
          prmT000325 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistoryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000326 ;
          prmT000326 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000318 ;
          prmT000318 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [BalanceId], [HistoryId], [HistoryAbono], [HistoryDate], [HistoryType] FROM [BalanceHistory] WITH (UPDLOCK) WHERE [BalanceId] = @BalanceId AND [HistoryId] = @HistoryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [BalanceId], [HistoryId], [HistoryAbono], [HistoryDate], [HistoryType] FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId AND [HistoryId] = @HistoryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT [BalanceId], [BalanceCredit], [BalanceDateMade], [BalanceMonths], [BalanceName], [BalanceLastLine], [UsersId] FROM [Balance] WITH (UPDLOCK) WHERE [BalanceId] = @BalanceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
             ,new CursorDef("T00035", "SELECT [BalanceId], [BalanceCredit], [BalanceDateMade], [BalanceMonths], [BalanceName], [BalanceLastLine], [UsersId] FROM [Balance] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new CursorDef("T00036", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,false )
             ,new CursorDef("T00038", "SELECT COALESCE( T1.[BalanceTotalAbono], 0) AS BalanceTotalAbono FROM (SELECT SUM([HistoryAbono]) AS BalanceTotalAbono, [BalanceId] FROM [BalanceHistory] WITH (UPDLOCK) GROUP BY [BalanceId] ) T1 WHERE T1.[BalanceId] = @BalanceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,false )
             ,new CursorDef("T000310", "SELECT TM1.[BalanceId], TM1.[BalanceCredit], TM1.[BalanceDateMade], TM1.[BalanceMonths], TM1.[BalanceName], T3.[UsersName], TM1.[BalanceLastLine], TM1.[UsersId], COALESCE( T2.[BalanceTotalAbono], 0) AS BalanceTotalAbono FROM (([Balance] TM1 WITH (NOLOCK) LEFT JOIN (SELECT SUM([HistoryAbono]) AS BalanceTotalAbono, [BalanceId] FROM [BalanceHistory] WITH (NOLOCK) GROUP BY [BalanceId] ) T2 ON T2.[BalanceId] = TM1.[BalanceId]) INNER JOIN [Users] T3 WITH (NOLOCK) ON T3.[UsersId] = TM1.[UsersId]) WHERE TM1.[BalanceId] = @BalanceId ORDER BY TM1.[BalanceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,100,0,true,false )
             ,new CursorDef("T000311", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,1,0,true,false )
             ,new CursorDef("T000312", "SELECT [BalanceId] FROM [Balance] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000312,1,0,true,false )
             ,new CursorDef("T000313", "SELECT TOP 1 [BalanceId] FROM [Balance] WITH (NOLOCK) WHERE ( [BalanceId] > @BalanceId) ORDER BY [BalanceId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,1,0,true,true )
             ,new CursorDef("T000314", "SELECT TOP 1 [BalanceId] FROM [Balance] WITH (NOLOCK) WHERE ( [BalanceId] < @BalanceId) ORDER BY [BalanceId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,1,0,true,true )
             ,new CursorDef("T000315", "INSERT INTO [Balance]([BalanceCredit], [BalanceDateMade], [BalanceMonths], [BalanceName], [BalanceLastLine], [UsersId]) VALUES(@BalanceCredit, @BalanceDateMade, @BalanceMonths, @BalanceName, @BalanceLastLine, @UsersId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000315)
             ,new CursorDef("T000316", "UPDATE [Balance] SET [BalanceCredit]=@BalanceCredit, [BalanceDateMade]=@BalanceDateMade, [BalanceMonths]=@BalanceMonths, [BalanceName]=@BalanceName, [BalanceLastLine]=@BalanceLastLine, [UsersId]=@UsersId  WHERE [BalanceId] = @BalanceId", GxErrorMask.GX_NOMASK,prmT000316)
             ,new CursorDef("T000317", "DELETE FROM [Balance]  WHERE [BalanceId] = @BalanceId", GxErrorMask.GX_NOMASK,prmT000317)
             ,new CursorDef("T000318", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000318,1,0,true,false )
             ,new CursorDef("T000319", "UPDATE [Balance] SET [BalanceLastLine]=@BalanceLastLine  WHERE [BalanceId] = @BalanceId", GxErrorMask.GX_NOMASK,prmT000319)
             ,new CursorDef("T000320", "SELECT [BalanceId] FROM [Balance] WITH (NOLOCK) ORDER BY [BalanceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000320,100,0,true,false )
             ,new CursorDef("T000321", "SELECT [BalanceId], [HistoryId], [HistoryAbono], [HistoryDate], [HistoryType] FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId and [HistoryId] = @HistoryId ORDER BY [BalanceId], [HistoryId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000321,11,0,true,false )
             ,new CursorDef("T000322", "SELECT [BalanceId], [HistoryId] FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId AND [HistoryId] = @HistoryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000322,1,0,true,false )
             ,new CursorDef("T000323", "INSERT INTO [BalanceHistory]([BalanceId], [HistoryId], [HistoryAbono], [HistoryDate], [HistoryType]) VALUES(@BalanceId, @HistoryId, @HistoryAbono, @HistoryDate, @HistoryType)", GxErrorMask.GX_NOMASK,prmT000323)
             ,new CursorDef("T000324", "UPDATE [BalanceHistory] SET [HistoryAbono]=@HistoryAbono, [HistoryDate]=@HistoryDate, [HistoryType]=@HistoryType  WHERE [BalanceId] = @BalanceId AND [HistoryId] = @HistoryId", GxErrorMask.GX_NOMASK,prmT000324)
             ,new CursorDef("T000325", "DELETE FROM [BalanceHistory]  WHERE [BalanceId] = @BalanceId AND [HistoryId] = @HistoryId", GxErrorMask.GX_NOMASK,prmT000325)
             ,new CursorDef("T000326", "SELECT [BalanceId], [HistoryId] FROM [BalanceHistory] WITH (NOLOCK) WHERE [BalanceId] = @BalanceId ORDER BY [BalanceId], [HistoryId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000326,11,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 5 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 22 :
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 12 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 20 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
