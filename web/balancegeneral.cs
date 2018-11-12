/*
               File: BalanceGeneral
        Description: Balance General
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:14.90
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
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class balancegeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public balancegeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public balancegeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_BalanceId )
      {
         this.A7BalanceId = aP0_BalanceId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbBalanceName = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( nGotPars == 0 )
            {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A7BalanceId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A7BalanceId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else
               {
                  if ( ! IsValidAjaxCall( false) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxfirstwebparm = gxfirstwebparm_bkp;
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0N2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "BalanceGeneral";
               context.Gx_err = 0;
               /* Using cursor H000N3 */
               pr_default.execute(0, new Object[] {A7BalanceId});
               if ( (pr_default.getStatus(0) != 101) )
               {
                  A32BalanceTotalAbono = H000N3_A32BalanceTotalAbono[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
                  n32BalanceTotalAbono = H000N3_n32BalanceTotalAbono[0];
               }
               else
               {
                  A32BalanceTotalAbono = 0;
                  n32BalanceTotalAbono = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               }
               pr_default.close(0);
               WS0N2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Balance General") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?201810111852157", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("balancegeneral.aspx") + "?" + UrlEncode("" +A7BalanceId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA7BalanceId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA7BalanceId), 4, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm0N2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("balancegeneral.js", "?2018101118521514", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BalanceGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Balance General" ;
      }

      protected void WB0N0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "balancegeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Modificar", bttBtnupdate_Jsonclick, 7, "Modificar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110n1_client"+"'", TempTags, "", 2, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Eliminar", bttBtndelete_Jsonclick, 7, "Eliminar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120n1_client"+"'", TempTags, "", 2, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBalanceCredit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceCredit_Internalname, "Credito", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceCredit_Internalname, StringUtil.LTrim( StringUtil.NToC( A24BalanceCredit, 14, 2, ",", "")), ((edtBalanceCredit_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A24BalanceCredit, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A24BalanceCredit, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceCredit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBalanceCredit_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtBalanceDateMade_Internalname, "Fecha Creada", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBalanceDateMade_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBalanceDateMade_Internalname, context.localUtil.Format(A27BalanceDateMade, "99/99/99"), context.localUtil.Format( A27BalanceDateMade, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceDateMade_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBalanceDateMade_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBalanceDateMade_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBalanceDateMade_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtBalanceMonths_Internalname, "Meses", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceMonths_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28BalanceMonths), 4, 0, ",", "")), ((edtBalanceMonths_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A28BalanceMonths), "ZZZ9")) : context.localUtil.Format( (decimal)(A28BalanceMonths), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceMonths_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBalanceMonths_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_label_element( context, cmbBalanceName_Internalname, "Contrato", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBalanceName, cmbBalanceName_Internalname, StringUtil.RTrim( A29BalanceName), 1, cmbBalanceName_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbBalanceName.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BalanceGeneral.htm");
            cmbBalanceName.CurrentValue = StringUtil.RTrim( A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBalanceName_Internalname, "Values", (String)(cmbBalanceName.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, edtUsersId_Internalname, "Clientes Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), ((edtUsersId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")) : context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtUsersId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtBalanceTotalAbono_Internalname, "Total Abono", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceTotalAbono_Internalname, StringUtil.LTrim( StringUtil.NToC( A32BalanceTotalAbono, 14, 2, ",", "")), ((edtBalanceTotalAbono_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A32BalanceTotalAbono, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A32BalanceTotalAbono, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceTotalAbono_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBalanceTotalAbono_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtBalanceSaldo_Internalname, "Saldo al Dia", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceSaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A34BalanceSaldo, 14, 2, ",", "")), ((edtBalanceSaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A34BalanceSaldo, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A34BalanceSaldo, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceSaldo_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBalanceSaldo_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_BalanceGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceId_Internalname, "Balance Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7BalanceId), 4, 0, ",", "")), ((edtBalanceId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9")) : context.localUtil.Format( (decimal)(A7BalanceId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceId_Jsonclick, 0, "Attribute", "", "", "", "", edtBalanceId_Visible, edtBalanceId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersName_Internalname, "Clientes Nombre Usuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtUsersName_Internalname, StringUtil.RTrim( A4UsersName), StringUtil.RTrim( context.localUtil.Format( A4UsersName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersName_Jsonclick, 0, "Attribute", "", "", "", "", edtUsersName_Visible, edtUsersName_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBalanceLastLine_Internalname, "Balance Last Line", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBalanceLastLine_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30BalanceLastLine), 4, 0, ",", "")), ((edtBalanceLastLine_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A30BalanceLastLine), "ZZZ9")) : context.localUtil.Format( (decimal)(A30BalanceLastLine), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBalanceLastLine_Jsonclick, 0, "Attribute", "", "", "", "", edtBalanceLastLine_Visible, edtBalanceLastLine_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BalanceGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Balance General", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0N0( ) ;
            }
         }
      }

      protected void WS0N2( )
      {
         START0N2( ) ;
         EVT0N2( ) ;
      }

      protected void EVT0N2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130N2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140N2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0N2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0N2( ) ;
            }
         }
      }

      protected void PA0N2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbBalanceName.ItemCount > 0 )
         {
            A29BalanceName = cmbBalanceName.getValidValue(A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29BalanceName", A29BalanceName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBalanceName.CurrentValue = StringUtil.RTrim( A29BalanceName);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBalanceName_Internalname, "Values", cmbBalanceName.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0N2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "BalanceGeneral";
         context.Gx_err = 0;
      }

      protected void RF0N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000N5 */
            pr_default.execute(1, new Object[] {A7BalanceId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A30BalanceLastLine = H000N5_A30BalanceLastLine[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
               A4UsersName = H000N5_A4UsersName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
               A3UsersId = H000N5_A3UsersId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
               A29BalanceName = H000N5_A29BalanceName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29BalanceName", A29BalanceName);
               A28BalanceMonths = H000N5_A28BalanceMonths[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
               A27BalanceDateMade = H000N5_A27BalanceDateMade[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
               A32BalanceTotalAbono = H000N5_A32BalanceTotalAbono[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               n32BalanceTotalAbono = H000N5_n32BalanceTotalAbono[0];
               A24BalanceCredit = H000N5_A24BalanceCredit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
               A4UsersName = H000N5_A4UsersName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
               A32BalanceTotalAbono = H000N5_A32BalanceTotalAbono[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
               n32BalanceTotalAbono = H000N5_n32BalanceTotalAbono[0];
               A34BalanceSaldo = (decimal)(A24BalanceCredit-A32BalanceTotalAbono);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
               /* Execute user event: Load */
               E140N2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            WB0N0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0N2( )
      {
      }

      protected void STRUP0N0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "BalanceGeneral";
         context.Gx_err = 0;
         /* Using cursor H000N7 */
         pr_default.execute(2, new Object[] {A7BalanceId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A32BalanceTotalAbono = H000N7_A32BalanceTotalAbono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            n32BalanceTotalAbono = H000N7_n32BalanceTotalAbono[0];
         }
         else
         {
            A32BalanceTotalAbono = 0;
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
         }
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130N2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A24BalanceCredit = context.localUtil.CToN( cgiGet( edtBalanceCredit_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24BalanceCredit", StringUtil.LTrim( StringUtil.Str( A24BalanceCredit, 10, 2)));
            A27BalanceDateMade = context.localUtil.CToD( cgiGet( edtBalanceDateMade_Internalname), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27BalanceDateMade", context.localUtil.Format(A27BalanceDateMade, "99/99/99"));
            A28BalanceMonths = (short)(context.localUtil.CToN( cgiGet( edtBalanceMonths_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A28BalanceMonths", StringUtil.LTrim( StringUtil.Str( (decimal)(A28BalanceMonths), 4, 0)));
            cmbBalanceName.CurrentValue = cgiGet( cmbBalanceName_Internalname);
            A29BalanceName = cgiGet( cmbBalanceName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29BalanceName", A29BalanceName);
            A3UsersId = (short)(context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A32BalanceTotalAbono = context.localUtil.CToN( cgiGet( edtBalanceTotalAbono_Internalname), ",", ".");
            n32BalanceTotalAbono = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32BalanceTotalAbono", StringUtil.LTrim( StringUtil.Str( A32BalanceTotalAbono, 10, 2)));
            A34BalanceSaldo = context.localUtil.CToN( cgiGet( edtBalanceSaldo_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34BalanceSaldo", StringUtil.LTrim( StringUtil.Str( A34BalanceSaldo, 10, 2)));
            A4UsersName = cgiGet( edtUsersName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
            A30BalanceLastLine = (short)(context.localUtil.CToN( cgiGet( edtBalanceLastLine_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A30BalanceLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A30BalanceLastLine), 4, 0)));
            /* Read saved values. */
            wcpOA7BalanceId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA7BalanceId"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E130N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130N2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E140N2( )
      {
         /* Load Routine */
         edtBalanceId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBalanceId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceId_Visible), 5, 0)), true);
         edtUsersName_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUsersName_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersName_Visible), 5, 0)), true);
         edtBalanceLastLine_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBalanceLastLine_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBalanceLastLine_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Balance";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "BalanceId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6BalanceId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "Verbo2"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A7BalanceId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0N2( ) ;
         WS0N2( ) ;
         WE0N2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA7BalanceId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0N2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "balancegeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0N2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A7BalanceId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
         }
         wcpOA7BalanceId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA7BalanceId"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( A7BalanceId != wcpOA7BalanceId ) ) )
         {
            setjustcreated();
         }
         wcpOA7BalanceId = A7BalanceId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA7BalanceId = cgiGet( sPrefix+"A7BalanceId_CTRL");
         if ( StringUtil.Len( sCtrlA7BalanceId) > 0 )
         {
            A7BalanceId = (short)(context.localUtil.CToN( cgiGet( sCtrlA7BalanceId), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7BalanceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7BalanceId), 4, 0)));
         }
         else
         {
            A7BalanceId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A7BalanceId_PARM"), ",", "."));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0N2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0N2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0N2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A7BalanceId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7BalanceId), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA7BalanceId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A7BalanceId_CTRL", StringUtil.RTrim( sCtrlA7BalanceId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0N2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118521688", true);
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
         context.AddJavascriptSource("balancegeneral.js", "?2018101118521689", false);
         /* End function include_jscripts */
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
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtBalanceCredit_Internalname = sPrefix+"BALANCECREDIT";
         edtBalanceDateMade_Internalname = sPrefix+"BALANCEDATEMADE";
         edtBalanceMonths_Internalname = sPrefix+"BALANCEMONTHS";
         cmbBalanceName_Internalname = sPrefix+"BALANCENAME";
         edtUsersId_Internalname = sPrefix+"USERSID";
         edtBalanceTotalAbono_Internalname = sPrefix+"BALANCETOTALABONO";
         edtBalanceSaldo_Internalname = sPrefix+"BALANCESALDO";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         edtBalanceId_Internalname = sPrefix+"BALANCEID";
         edtUsersName_Internalname = sPrefix+"USERSNAME";
         edtBalanceLastLine_Internalname = sPrefix+"BALANCELASTLINE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBalanceLastLine_Jsonclick = "";
         edtBalanceLastLine_Enabled = 0;
         edtBalanceLastLine_Visible = 1;
         edtUsersName_Jsonclick = "";
         edtUsersName_Enabled = 0;
         edtUsersName_Visible = 1;
         edtBalanceId_Jsonclick = "";
         edtBalanceId_Enabled = 0;
         edtBalanceId_Visible = 1;
         edtBalanceSaldo_Jsonclick = "";
         edtBalanceSaldo_Enabled = 0;
         edtBalanceTotalAbono_Jsonclick = "";
         edtBalanceTotalAbono_Enabled = 0;
         edtUsersId_Jsonclick = "";
         edtUsersId_Enabled = 0;
         cmbBalanceName_Jsonclick = "";
         cmbBalanceName.Enabled = 0;
         edtBalanceMonths_Jsonclick = "";
         edtBalanceMonths_Enabled = 0;
         edtBalanceDateMade_Jsonclick = "";
         edtBalanceDateMade_Enabled = 0;
         edtBalanceCredit_Jsonclick = "";
         edtBalanceCredit_Enabled = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E110N1',iparms:[{av:'A7BalanceId',fld:'BALANCEID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120N1',iparms:[{av:'A7BalanceId',fld:'BALANCEID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV13Pgmname = "";
         scmdbuf = "";
         H000N3_A32BalanceTotalAbono = new decimal[1] ;
         H000N3_n32BalanceTotalAbono = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A27BalanceDateMade = DateTime.MinValue;
         A29BalanceName = "";
         A4UsersName = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         H000N5_A7BalanceId = new short[1] ;
         H000N5_A30BalanceLastLine = new short[1] ;
         H000N5_A4UsersName = new String[] {""} ;
         H000N5_A3UsersId = new short[1] ;
         H000N5_A29BalanceName = new String[] {""} ;
         H000N5_A28BalanceMonths = new short[1] ;
         H000N5_A27BalanceDateMade = new DateTime[] {DateTime.MinValue} ;
         H000N5_A32BalanceTotalAbono = new decimal[1] ;
         H000N5_n32BalanceTotalAbono = new bool[] {false} ;
         H000N5_A24BalanceCredit = new decimal[1] ;
         H000N7_A32BalanceTotalAbono = new decimal[1] ;
         H000N7_n32BalanceTotalAbono = new bool[] {false} ;
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA7BalanceId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.balancegeneral__default(),
            new Object[][] {
                new Object[] {
               H000N3_A32BalanceTotalAbono, H000N3_n32BalanceTotalAbono
               }
               , new Object[] {
               H000N5_A7BalanceId, H000N5_A30BalanceLastLine, H000N5_A4UsersName, H000N5_A3UsersId, H000N5_A29BalanceName, H000N5_A28BalanceMonths, H000N5_A27BalanceDateMade, H000N5_A32BalanceTotalAbono, H000N5_n32BalanceTotalAbono, H000N5_A24BalanceCredit
               }
               , new Object[] {
               H000N7_A32BalanceTotalAbono, H000N7_n32BalanceTotalAbono
               }
            }
         );
         AV13Pgmname = "BalanceGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "BalanceGeneral";
         context.Gx_err = 0;
      }

      private short A7BalanceId ;
      private short wcpOA7BalanceId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A28BalanceMonths ;
      private short A3UsersId ;
      private short A30BalanceLastLine ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6BalanceId ;
      private short nGXWrapped ;
      private int edtBalanceCredit_Enabled ;
      private int edtBalanceDateMade_Enabled ;
      private int edtBalanceMonths_Enabled ;
      private int edtUsersId_Enabled ;
      private int edtBalanceTotalAbono_Enabled ;
      private int edtBalanceSaldo_Enabled ;
      private int edtBalanceId_Enabled ;
      private int edtBalanceId_Visible ;
      private int edtUsersName_Visible ;
      private int edtUsersName_Enabled ;
      private int edtBalanceLastLine_Enabled ;
      private int edtBalanceLastLine_Visible ;
      private int idxLst ;
      private decimal A32BalanceTotalAbono ;
      private decimal A24BalanceCredit ;
      private decimal A34BalanceSaldo ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV13Pgmname ;
      private String scmdbuf ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtBalanceCredit_Internalname ;
      private String edtBalanceCredit_Jsonclick ;
      private String edtBalanceDateMade_Internalname ;
      private String edtBalanceDateMade_Jsonclick ;
      private String edtBalanceMonths_Internalname ;
      private String edtBalanceMonths_Jsonclick ;
      private String cmbBalanceName_Internalname ;
      private String A29BalanceName ;
      private String cmbBalanceName_Jsonclick ;
      private String edtUsersId_Internalname ;
      private String edtUsersId_Jsonclick ;
      private String edtBalanceTotalAbono_Internalname ;
      private String edtBalanceTotalAbono_Jsonclick ;
      private String edtBalanceSaldo_Internalname ;
      private String edtBalanceSaldo_Jsonclick ;
      private String edtBalanceId_Internalname ;
      private String edtBalanceId_Jsonclick ;
      private String edtUsersName_Internalname ;
      private String A4UsersName ;
      private String edtUsersName_Jsonclick ;
      private String edtBalanceLastLine_Internalname ;
      private String edtBalanceLastLine_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sCtrlA7BalanceId ;
      private DateTime A27BalanceDateMade ;
      private bool entryPointCalled ;
      private bool n32BalanceTotalAbono ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBalanceName ;
      private IDataStoreProvider pr_default ;
      private decimal[] H000N3_A32BalanceTotalAbono ;
      private bool[] H000N3_n32BalanceTotalAbono ;
      private short[] H000N5_A7BalanceId ;
      private short[] H000N5_A30BalanceLastLine ;
      private String[] H000N5_A4UsersName ;
      private short[] H000N5_A3UsersId ;
      private String[] H000N5_A29BalanceName ;
      private short[] H000N5_A28BalanceMonths ;
      private DateTime[] H000N5_A27BalanceDateMade ;
      private decimal[] H000N5_A32BalanceTotalAbono ;
      private bool[] H000N5_n32BalanceTotalAbono ;
      private decimal[] H000N5_A24BalanceCredit ;
      private decimal[] H000N7_A32BalanceTotalAbono ;
      private bool[] H000N7_n32BalanceTotalAbono ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class balancegeneral__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000N3 ;
          prmH000N3 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000N5 ;
          prmH000N5 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000N7 ;
          prmH000N7 = new Object[] {
          new Object[] {"@BalanceId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000N3", "SELECT COALESCE( T1.[BalanceTotalAbono], 0) AS BalanceTotalAbono FROM (SELECT SUM([HistoryAbono]) AS BalanceTotalAbono, [BalanceId] FROM [BalanceHistory] WITH (NOLOCK) GROUP BY [BalanceId] ) T1 WHERE T1.[BalanceId] = @BalanceId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N3,1,0,true,true )
             ,new CursorDef("H000N5", "SELECT T1.[BalanceId], T1.[BalanceLastLine], T2.[UsersName], T1.[UsersId], T1.[BalanceName], T1.[BalanceMonths], T1.[BalanceDateMade], COALESCE( T3.[BalanceTotalAbono], 0) AS BalanceTotalAbono, T1.[BalanceCredit] FROM (([Balance] T1 WITH (NOLOCK) INNER JOIN [Users] T2 WITH (NOLOCK) ON T2.[UsersId] = T1.[UsersId]) LEFT JOIN (SELECT SUM([HistoryAbono]) AS BalanceTotalAbono, [BalanceId] FROM [BalanceHistory] WITH (NOLOCK) GROUP BY [BalanceId] ) T3 ON T3.[BalanceId] = T1.[BalanceId]) WHERE T1.[BalanceId] = @BalanceId ORDER BY T1.[BalanceId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N5,1,0,true,true )
             ,new CursorDef("H000N7", "SELECT COALESCE( T1.[BalanceTotalAbono], 0) AS BalanceTotalAbono FROM (SELECT SUM([HistoryAbono]) AS BalanceTotalAbono, [BalanceId] FROM [BalanceHistory] WITH (NOLOCK) GROUP BY [BalanceId] ) T1 WHERE T1.[BalanceId] = @BalanceId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N7,1,0,true,true )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(9) ;
                return;
             case 2 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
       }
    }

 }

}
