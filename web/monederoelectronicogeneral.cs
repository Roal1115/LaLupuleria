/*
               File: MonederoElectronicoGeneral
        Description: Monedero Electronico General
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:18.36
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
   public class monederoelectronicogeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public monederoelectronicogeneral( )
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

      public monederoelectronicogeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_MonederoElectronicoId )
      {
         this.A9MonederoElectronicoId = aP0_MonederoElectronicoId;
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
                  A9MonederoElectronicoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A9MonederoElectronicoId});
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
            PA0R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "MonederoElectronicoGeneral";
               context.Gx_err = 0;
               /* Using cursor H000R3 */
               pr_default.execute(0, new Object[] {A9MonederoElectronicoId});
               if ( (pr_default.getStatus(0) != 101) )
               {
                  A40MonederoElectronicoRetiros = H000R3_A40MonederoElectronicoRetiros[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
               }
               else
               {
                  A40MonederoElectronicoRetiros = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
               }
               pr_default.close(0);
               /* Using cursor H000R5 */
               pr_default.execute(1, new Object[] {A9MonederoElectronicoId});
               if ( (pr_default.getStatus(1) != 101) )
               {
                  A37MonederoElectronicoDepositos = H000R5_A37MonederoElectronicoDepositos[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
               }
               else
               {
                  A37MonederoElectronicoDepositos = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
               }
               pr_default.close(1);
               A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
               WS0R2( ) ;
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
            context.SendWebValue( "Monedero Electronico General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118521855", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("monederoelectronicogeneral.aspx") + "?" + UrlEncode("" +A9MonederoElectronicoId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA9MonederoElectronicoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA9MonederoElectronicoId), 4, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm0R2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("monederoelectronicogeneral.js", "?2018101118521860", false);
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
         return "MonederoElectronicoGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Monedero Electronico General" ;
      }

      protected void WB0R0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "monederoelectronicogeneral.aspx");
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
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Modificar", bttBtnupdate_Jsonclick, 7, "Modificar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110r1_client"+"'", TempTags, "", 2, "HLP_MonederoElectronicoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Eliminar", bttBtndelete_Jsonclick, 7, "Eliminar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120r1_client"+"'", TempTags, "", 2, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMonederoElectronicoApertura_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMonederoElectronicoApertura_Internalname, "Electronico Apertura", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtMonederoElectronicoApertura_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicoApertura_Internalname, context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"), context.localUtil.Format( A35MonederoElectronicoApertura, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicoApertura_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtMonederoElectronicoApertura_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MonederoElectronicoGeneral.htm");
            GxWebStd.gx_bitmap( context, edtMonederoElectronicoApertura_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtMonederoElectronicoApertura_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersId_Internalname, "Clientes Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), ((edtUsersId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")) : context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtUsersId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_MonederoElectronicoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMonederoElectronicosaldo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMonederoElectronicosaldo_Internalname, "Electronicosaldo", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicosaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A36MonederoElectronicosaldo, 14, 2, ",", "")), ((edtMonederoElectronicosaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A36MonederoElectronicosaldo, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A36MonederoElectronicosaldo, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicosaldo_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtMonederoElectronicosaldo_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtMonederoElectronicoId_Internalname, "Monedero Electronico Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9MonederoElectronicoId), 4, 0, ",", "")), ((edtMonederoElectronicoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicoId_Jsonclick, 0, "Attribute", "", "", "", "", edtMonederoElectronicoId_Visible, edtMonederoElectronicoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtMonederoElectronicoDepositos_Internalname, "Monedero Electronico Depositos", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicoDepositos_Internalname, StringUtil.LTrim( StringUtil.NToC( A37MonederoElectronicoDepositos, 14, 2, ",", "")), ((edtMonederoElectronicoDepositos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A37MonederoElectronicoDepositos, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A37MonederoElectronicoDepositos, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicoDepositos_Jsonclick, 0, "Attribute", "", "", "", "", edtMonederoElectronicoDepositos_Visible, edtMonederoElectronicoDepositos_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtMonederoElectronicoRetiros_Internalname, "Monedero Electronico Retiros", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicoRetiros_Internalname, StringUtil.LTrim( StringUtil.NToC( A40MonederoElectronicoRetiros, 14, 2, ",", "")), ((edtMonederoElectronicoRetiros_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A40MonederoElectronicoRetiros, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A40MonederoElectronicoRetiros, "$ Z,ZZZ,ZZZ.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicoRetiros_Jsonclick, 0, "Attribute", "", "", "", "", edtMonederoElectronicoRetiros_Visible, edtMonederoElectronicoRetiros_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtMovimientosLastLine_Internalname, "Movimientos Last Line", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMovimientosLastLine_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42MovimientosLastLine), 4, 0, ",", "")), ((edtMovimientosLastLine_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A42MovimientosLastLine), "ZZZ9")) : context.localUtil.Format( (decimal)(A42MovimientosLastLine), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMovimientosLastLine_Jsonclick, 0, "Attribute", "", "", "", "", edtMovimientosLastLine_Visible, edtMovimientosLastLine_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MonederoElectronicoGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsersName_Internalname, StringUtil.RTrim( A4UsersName), StringUtil.RTrim( context.localUtil.Format( A4UsersName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersName_Jsonclick, 0, "Attribute", "", "", "", "", edtUsersName_Visible, edtUsersName_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MonederoElectronicoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Monedero Electronico General", 0) ;
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
               STRUP0R0( ) ;
            }
         }
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
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

      protected void WE0R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0R2( ) ;
            }
         }
      }

      protected void PA0R2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "MonederoElectronicoGeneral";
         context.Gx_err = 0;
      }

      protected void RF0R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000R8 */
            pr_default.execute(2, new Object[] {A9MonederoElectronicoId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A4UsersName = H000R8_A4UsersName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
               A42MovimientosLastLine = H000R8_A42MovimientosLastLine[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
               A3UsersId = H000R8_A3UsersId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
               A35MonederoElectronicoApertura = H000R8_A35MonederoElectronicoApertura[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
               A40MonederoElectronicoRetiros = H000R8_A40MonederoElectronicoRetiros[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
               A37MonederoElectronicoDepositos = H000R8_A37MonederoElectronicoDepositos[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
               A4UsersName = H000R8_A4UsersName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
               A40MonederoElectronicoRetiros = H000R8_A40MonederoElectronicoRetiros[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
               A37MonederoElectronicoDepositos = H000R8_A37MonederoElectronicoDepositos[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
               /* Execute user event: Load */
               E140R2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            WB0R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0R2( )
      {
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "MonederoElectronicoGeneral";
         context.Gx_err = 0;
         /* Using cursor H000R10 */
         pr_default.execute(3, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40MonederoElectronicoRetiros = H000R10_A40MonederoElectronicoRetiros[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
         }
         else
         {
            A40MonederoElectronicoRetiros = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
         }
         pr_default.close(3);
         /* Using cursor H000R12 */
         pr_default.execute(4, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            A37MonederoElectronicoDepositos = H000R12_A37MonederoElectronicoDepositos[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
         }
         else
         {
            A37MonederoElectronicoDepositos = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
         }
         pr_default.close(4);
         A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130R2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A35MonederoElectronicoApertura = context.localUtil.CToD( cgiGet( edtMonederoElectronicoApertura_Internalname), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
            A3UsersId = (short)(context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A36MonederoElectronicosaldo = context.localUtil.CToN( cgiGet( edtMonederoElectronicosaldo_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
            A37MonederoElectronicoDepositos = context.localUtil.CToN( cgiGet( edtMonederoElectronicoDepositos_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
            A40MonederoElectronicoRetiros = context.localUtil.CToN( cgiGet( edtMonederoElectronicoRetiros_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
            A42MovimientosLastLine = (short)(context.localUtil.CToN( cgiGet( edtMovimientosLastLine_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            A4UsersName = cgiGet( edtUsersName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4UsersName", A4UsersName);
            /* Read saved values. */
            wcpOA9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA9MonederoElectronicoId"), ",", "."));
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
         E130R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130R2( )
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

      protected void E140R2( )
      {
         /* Load Routine */
         edtMonederoElectronicoId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMonederoElectronicoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicoId_Visible), 5, 0)), true);
         edtMonederoElectronicoDepositos_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMonederoElectronicoDepositos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicoDepositos_Visible), 5, 0)), true);
         edtMonederoElectronicoRetiros_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMonederoElectronicoRetiros_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicoRetiros_Visible), 5, 0)), true);
         edtMovimientosLastLine_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMovimientosLastLine_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosLastLine_Visible), 5, 0)), true);
         edtUsersName_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUsersName_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersName_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "MonederoElectronico";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "MonederoElectronicoId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6MonederoElectronicoId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "Verbo2"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A9MonederoElectronicoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
         sCtrlA9MonederoElectronicoId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0R2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "monederoelectronicogeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0R2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A9MonederoElectronicoId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
         }
         wcpOA9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA9MonederoElectronicoId"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( A9MonederoElectronicoId != wcpOA9MonederoElectronicoId ) ) )
         {
            setjustcreated();
         }
         wcpOA9MonederoElectronicoId = A9MonederoElectronicoId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA9MonederoElectronicoId = cgiGet( sPrefix+"A9MonederoElectronicoId_CTRL");
         if ( StringUtil.Len( sCtrlA9MonederoElectronicoId) > 0 )
         {
            A9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( sCtrlA9MonederoElectronicoId), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
         }
         else
         {
            A9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A9MonederoElectronicoId_PARM"), ",", "."));
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
         PA0R2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0R2( ) ;
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
         WS0R2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A9MonederoElectronicoId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9MonederoElectronicoId), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA9MonederoElectronicoId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A9MonederoElectronicoId_CTRL", StringUtil.RTrim( sCtrlA9MonederoElectronicoId));
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
         WE0R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201810111852204", true);
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
         context.AddJavascriptSource("monederoelectronicogeneral.js", "?201810111852205", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtMonederoElectronicoApertura_Internalname = sPrefix+"MONEDEROELECTRONICOAPERTURA";
         edtUsersId_Internalname = sPrefix+"USERSID";
         edtMonederoElectronicosaldo_Internalname = sPrefix+"MONEDEROELECTRONICOSALDO";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         edtMonederoElectronicoId_Internalname = sPrefix+"MONEDEROELECTRONICOID";
         edtMonederoElectronicoDepositos_Internalname = sPrefix+"MONEDEROELECTRONICODEPOSITOS";
         edtMonederoElectronicoRetiros_Internalname = sPrefix+"MONEDEROELECTRONICORETIROS";
         edtMovimientosLastLine_Internalname = sPrefix+"MOVIMIENTOSLASTLINE";
         edtUsersName_Internalname = sPrefix+"USERSNAME";
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
         edtUsersName_Jsonclick = "";
         edtUsersName_Enabled = 0;
         edtUsersName_Visible = 1;
         edtMovimientosLastLine_Jsonclick = "";
         edtMovimientosLastLine_Enabled = 0;
         edtMovimientosLastLine_Visible = 1;
         edtMonederoElectronicoRetiros_Jsonclick = "";
         edtMonederoElectronicoRetiros_Enabled = 0;
         edtMonederoElectronicoRetiros_Visible = 1;
         edtMonederoElectronicoDepositos_Jsonclick = "";
         edtMonederoElectronicoDepositos_Enabled = 0;
         edtMonederoElectronicoDepositos_Visible = 1;
         edtMonederoElectronicoId_Jsonclick = "";
         edtMonederoElectronicoId_Enabled = 0;
         edtMonederoElectronicoId_Visible = 1;
         edtMonederoElectronicosaldo_Jsonclick = "";
         edtMonederoElectronicosaldo_Enabled = 0;
         edtUsersId_Jsonclick = "";
         edtUsersId_Enabled = 0;
         edtMonederoElectronicoApertura_Jsonclick = "";
         edtMonederoElectronicoApertura_Enabled = 0;
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
         setEventMetadata("'DOUPDATE'","{handler:'E110R1',iparms:[{av:'A9MonederoElectronicoId',fld:'MONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120R1',iparms:[{av:'A9MonederoElectronicoId',fld:'MONEDEROELECTRONICOID',pic:'ZZZ9'}]");
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
         H000R3_A40MonederoElectronicoRetiros = new decimal[1] ;
         H000R5_A37MonederoElectronicoDepositos = new decimal[1] ;
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
         A35MonederoElectronicoApertura = DateTime.MinValue;
         A4UsersName = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         H000R8_A9MonederoElectronicoId = new short[1] ;
         H000R8_A4UsersName = new String[] {""} ;
         H000R8_A42MovimientosLastLine = new short[1] ;
         H000R8_A3UsersId = new short[1] ;
         H000R8_A35MonederoElectronicoApertura = new DateTime[] {DateTime.MinValue} ;
         H000R8_A40MonederoElectronicoRetiros = new decimal[1] ;
         H000R8_A37MonederoElectronicoDepositos = new decimal[1] ;
         H000R10_A40MonederoElectronicoRetiros = new decimal[1] ;
         H000R12_A37MonederoElectronicoDepositos = new decimal[1] ;
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA9MonederoElectronicoId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.monederoelectronicogeneral__default(),
            new Object[][] {
                new Object[] {
               H000R3_A40MonederoElectronicoRetiros
               }
               , new Object[] {
               H000R5_A37MonederoElectronicoDepositos
               }
               , new Object[] {
               H000R8_A9MonederoElectronicoId, H000R8_A4UsersName, H000R8_A42MovimientosLastLine, H000R8_A3UsersId, H000R8_A35MonederoElectronicoApertura, H000R8_A40MonederoElectronicoRetiros, H000R8_A37MonederoElectronicoDepositos
               }
               , new Object[] {
               H000R10_A40MonederoElectronicoRetiros
               }
               , new Object[] {
               H000R12_A37MonederoElectronicoDepositos
               }
            }
         );
         AV13Pgmname = "MonederoElectronicoGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "MonederoElectronicoGeneral";
         context.Gx_err = 0;
      }

      private short A9MonederoElectronicoId ;
      private short wcpOA9MonederoElectronicoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A3UsersId ;
      private short A42MovimientosLastLine ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6MonederoElectronicoId ;
      private short nGXWrapped ;
      private int edtMonederoElectronicoApertura_Enabled ;
      private int edtUsersId_Enabled ;
      private int edtMonederoElectronicosaldo_Enabled ;
      private int edtMonederoElectronicoId_Enabled ;
      private int edtMonederoElectronicoId_Visible ;
      private int edtMonederoElectronicoDepositos_Enabled ;
      private int edtMonederoElectronicoDepositos_Visible ;
      private int edtMonederoElectronicoRetiros_Enabled ;
      private int edtMonederoElectronicoRetiros_Visible ;
      private int edtMovimientosLastLine_Enabled ;
      private int edtMovimientosLastLine_Visible ;
      private int edtUsersName_Visible ;
      private int edtUsersName_Enabled ;
      private int idxLst ;
      private decimal A40MonederoElectronicoRetiros ;
      private decimal A37MonederoElectronicoDepositos ;
      private decimal A36MonederoElectronicosaldo ;
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
      private String edtMonederoElectronicoApertura_Internalname ;
      private String edtMonederoElectronicoApertura_Jsonclick ;
      private String edtUsersId_Internalname ;
      private String edtUsersId_Jsonclick ;
      private String edtMonederoElectronicosaldo_Internalname ;
      private String edtMonederoElectronicosaldo_Jsonclick ;
      private String edtMonederoElectronicoId_Internalname ;
      private String edtMonederoElectronicoId_Jsonclick ;
      private String edtMonederoElectronicoDepositos_Internalname ;
      private String edtMonederoElectronicoDepositos_Jsonclick ;
      private String edtMonederoElectronicoRetiros_Internalname ;
      private String edtMonederoElectronicoRetiros_Jsonclick ;
      private String edtMovimientosLastLine_Internalname ;
      private String edtMovimientosLastLine_Jsonclick ;
      private String edtUsersName_Internalname ;
      private String A4UsersName ;
      private String edtUsersName_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sCtrlA9MonederoElectronicoId ;
      private DateTime A35MonederoElectronicoApertura ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] H000R3_A40MonederoElectronicoRetiros ;
      private decimal[] H000R5_A37MonederoElectronicoDepositos ;
      private short[] H000R8_A9MonederoElectronicoId ;
      private String[] H000R8_A4UsersName ;
      private short[] H000R8_A42MovimientosLastLine ;
      private short[] H000R8_A3UsersId ;
      private DateTime[] H000R8_A35MonederoElectronicoApertura ;
      private decimal[] H000R8_A40MonederoElectronicoRetiros ;
      private decimal[] H000R8_A37MonederoElectronicoDepositos ;
      private decimal[] H000R10_A40MonederoElectronicoRetiros ;
      private decimal[] H000R12_A37MonederoElectronicoDepositos ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class monederoelectronicogeneral__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000R3 ;
          prmH000R3 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000R5 ;
          prmH000R5 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000R8 ;
          prmH000R8 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000R10 ;
          prmH000R10 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000R12 ;
          prmH000R12 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000R3", "SELECT COALESCE( T1.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoRetiros FROM (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R3,1,0,true,true )
             ,new CursorDef("H000R5", "SELECT COALESCE( T1.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoDepositos FROM (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R5,1,0,true,true )
             ,new CursorDef("H000R8", "SELECT T1.[MonederoElectronicoId], T2.[UsersName], T1.[MovimientosLastLine], T1.[UsersId], T1.[MonederoElectronicoApertura], COALESCE( T3.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoRetiros, COALESCE( T4.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoDepositos FROM ((([MonederoElectronico] T1 WITH (NOLOCK) INNER JOIN [Users] T2 WITH (NOLOCK) ON T2.[UsersId] = T1.[UsersId]) LEFT JOIN (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T3 ON T3.[MonederoElectronicoId] = T1.[MonederoElectronicoId]) LEFT JOIN (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T4 ON T4.[MonederoElectronicoId] = T1.[MonederoElectronicoId]) WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ORDER BY T1.[MonederoElectronicoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R8,1,0,true,true )
             ,new CursorDef("H000R10", "SELECT COALESCE( T1.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoRetiros FROM (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R10,1,0,true,true )
             ,new CursorDef("H000R12", "SELECT COALESCE( T1.[MonederoElectronicoRetiros], 0) AS MonederoElectronicoDepositos FROM (SELECT [MonederoElectronicoId], SUM([MovimientosCantidad]) AS MonederoElectronicoRetiros FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R12,1,0,true,true )
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
                return;
             case 1 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                return;
             case 3 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                return;
             case 4 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
