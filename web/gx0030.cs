/*
               File: Gx0030
        Description: Selection List  T4
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:4.66
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gx0030 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0030( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pUsersId )
      {
         this.AV12pUsersId = 0 ;
         executePrivate();
         aP0_pUsersId=this.AV12pUsersId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCusersbusiness = new GXCombobox();
         cmbUsersBusiness = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cUsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cUsersName = GetNextPar( );
               AV8cUsersPassword = GetNextPar( );
               AV9cUsersBusiness = GetNextPar( );
               AV10cUsersCURP = GetNextPar( );
               AV11cUsersMatricula = (int)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
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
               AV12pUsersId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsersId), 4, 0)));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA1F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1F2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?201810111853480", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV12pUsersId)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSNAME", StringUtil.RTrim( AV7cUsersName));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSPASSWORD", StringUtil.RTrim( AV8cUsersPassword));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSBUSINESS", StringUtil.RTrim( AV9cUsersBusiness));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSCURP", StringUtil.RTrim( AV10cUsersCURP));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSERSMATRICULA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cUsersMatricula), 8, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pUsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "USERSIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsersidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USERSNAMEFILTERCONTAINER_Class", StringUtil.RTrim( divUsersnamefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USERSPASSWORDFILTERCONTAINER_Class", StringUtil.RTrim( divUserspasswordfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USERSBUSINESSFILTERCONTAINER_Class", StringUtil.RTrim( divUsersbusinessfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USERSCURPFILTERCONTAINER_Class", StringUtil.RTrim( divUserscurpfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USERSMATRICULAFILTERCONTAINER_Class", StringUtil.RTrim( divUsersmatriculafiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1F2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1F2( ) ;
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
         return formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV12pUsersId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0030" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List  T4" ;
      }

      protected void WB1F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUsersidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsersidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusersidfilter_Internalname, "Clientes Id", "", "", lblLblusersidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusersid_Internalname, "Clientes Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusersid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsersId), 4, 0, ",", "")), ((edtavCusersid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cUsersId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cUsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusersid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusersid_Visible, edtavCusersid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsersnamefiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsersnamefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusersnamefilter_Internalname, "Clientes Nombre Usuario", "", "", lblLblusersnamefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusersname_Internalname, "Clientes Nombre Usuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusersname_Internalname, StringUtil.RTrim( AV7cUsersName), StringUtil.RTrim( context.localUtil.Format( AV7cUsersName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusersname_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusersname_Visible, edtavCusersname_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUserspasswordfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUserspasswordfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbluserspasswordfilter_Internalname, "Clientes Contrasenia", "", "", lblLbluserspasswordfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCuserspassword_Internalname, "Clientes Contrasenia", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCuserspassword_Internalname, StringUtil.RTrim( AV8cUsersPassword), StringUtil.RTrim( context.localUtil.Format( AV8cUsersPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCuserspassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavCuserspassword_Visible, edtavCuserspassword_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsersbusinessfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsersbusinessfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusersbusinessfilter_Internalname, "Clientes Empresa", "", "", lblLblusersbusinessfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCusersbusiness_Internalname, "Clientes Empresa", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCusersbusiness, cmbavCusersbusiness_Internalname, StringUtil.RTrim( AV9cUsersBusiness), 1, cmbavCusersbusiness_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavCusersbusiness.Visible, cmbavCusersbusiness.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_Gx0030.htm");
            cmbavCusersbusiness.CurrentValue = StringUtil.RTrim( AV9cUsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusersbusiness_Internalname, "Values", (String)(cmbavCusersbusiness.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUserscurpfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUserscurpfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbluserscurpfilter_Internalname, "Users CURP", "", "", lblLbluserscurpfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCuserscurp_Internalname, "Users CURP", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCuserscurp_Internalname, StringUtil.RTrim( AV10cUsersCURP), StringUtil.RTrim( context.localUtil.Format( AV10cUsersCURP, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCuserscurp_Jsonclick, 0, "Attribute", "", "", "", "", edtavCuserscurp_Visible, edtavCuserscurp_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsersmatriculafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsersmatriculafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusersmatriculafilter_Internalname, "Users Matricula", "", "", lblLblusersmatriculafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusersmatricula_Internalname, "Users Matricula", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusersmatricula_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cUsersMatricula), 8, 0, ",", "")), ((edtavCusersmatricula_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cUsersMatricula), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11cUsersMatricula), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusersmatricula_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusersmatricula_Visible, edtavCusersmatricula_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e171f1_client"+"'", TempTags, "", 2, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Contrasenia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "CURP") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fotografia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Matricula") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4UsersName));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtUsersName_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A5UsersPassword));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A2UsersBusiness));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A45UsersCURP));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( A46UsersFotografia));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A47UsersMatricula), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List  T4", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1F0( ) ;
      }

      protected void WS1F2( )
      {
         START1F2( ) ;
         EVT1F2( ) ;
      }

      protected void EVT1F2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A3UsersId = (short)(context.localUtil.CToN( cgiGet( edtUsersId_Internalname), ",", "."));
                              A4UsersName = cgiGet( edtUsersName_Internalname);
                              A5UsersPassword = cgiGet( edtUsersPassword_Internalname);
                              cmbUsersBusiness.Name = cmbUsersBusiness_Internalname;
                              cmbUsersBusiness.CurrentValue = cgiGet( cmbUsersBusiness_Internalname);
                              A2UsersBusiness = cgiGet( cmbUsersBusiness_Internalname);
                              A45UsersCURP = cgiGet( edtUsersCURP_Internalname);
                              A46UsersFotografia = cgiGet( edtUsersFotografia_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
                              A47UsersMatricula = (int)(context.localUtil.CToN( cgiGet( edtUsersMatricula_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E181F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E191F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cusersid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSERSID"), ",", ".") != Convert.ToDecimal( AV6cUsersId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusersname Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSNAME"), AV7cUsersName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cuserspassword Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSPASSWORD"), AV8cUsersPassword) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusersbusiness Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSBUSINESS"), AV9cUsersBusiness) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cuserscurp Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSCURP"), AV10cUsersCURP) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusersmatricula Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSERSMATRICULA"), ",", ".") != Convert.ToDecimal( AV11cUsersMatricula )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E201F2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1F2( )
      {
         if ( nDonePA == 0 )
         {
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cUsersId ,
                                        String AV7cUsersName ,
                                        String AV8cUsersPassword ,
                                        String AV9cUsersBusiness ,
                                        String AV10cUsersCURP ,
                                        int AV11cUsersMatricula )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1F2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USERSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ".", "")));
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
         if ( cmbavCusersbusiness.ItemCount > 0 )
         {
            AV9cUsersBusiness = cmbavCusersbusiness.getValidValue(AV9cUsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsersBusiness", AV9cUsersBusiness);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCusersbusiness.CurrentValue = StringUtil.RTrim( AV9cUsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusersbusiness_Internalname, "Values", cmbavCusersbusiness.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cUsersName ,
                                                 AV8cUsersPassword ,
                                                 AV9cUsersBusiness ,
                                                 AV10cUsersCURP ,
                                                 AV11cUsersMatricula ,
                                                 A4UsersName ,
                                                 A5UsersPassword ,
                                                 A2UsersBusiness ,
                                                 A45UsersCURP ,
                                                 A47UsersMatricula ,
                                                 AV6cUsersId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                                 TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cUsersName = StringUtil.PadR( StringUtil.RTrim( AV7cUsersName), 20, "%");
            lV8cUsersPassword = StringUtil.PadR( StringUtil.RTrim( AV8cUsersPassword), 20, "%");
            lV9cUsersBusiness = StringUtil.PadR( StringUtil.RTrim( AV9cUsersBusiness), 20, "%");
            lV10cUsersCURP = StringUtil.PadR( StringUtil.RTrim( AV10cUsersCURP), 18, "%");
            /* Using cursor H001F2 */
            pr_default.execute(0, new Object[] {AV6cUsersId, lV7cUsersName, lV8cUsersPassword, lV9cUsersBusiness, lV10cUsersCURP, AV11cUsersMatricula, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A47UsersMatricula = H001F2_A47UsersMatricula[0];
               A40000UsersFotografia_GXI = H001F2_A40000UsersFotografia_GXI[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
               A45UsersCURP = H001F2_A45UsersCURP[0];
               A2UsersBusiness = H001F2_A2UsersBusiness[0];
               A5UsersPassword = H001F2_A5UsersPassword[0];
               A4UsersName = H001F2_A4UsersName[0];
               A3UsersId = H001F2_A3UsersId[0];
               A46UsersFotografia = H001F2_A46UsersFotografia[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
               /* Execute user event: Load */
               E191F2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB1F0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1F2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USERSID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9"), context));
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cUsersName ,
                                              AV8cUsersPassword ,
                                              AV9cUsersBusiness ,
                                              AV10cUsersCURP ,
                                              AV11cUsersMatricula ,
                                              A4UsersName ,
                                              A5UsersPassword ,
                                              A2UsersBusiness ,
                                              A45UsersCURP ,
                                              A47UsersMatricula ,
                                              AV6cUsersId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.SHORT
                                              }
         } ) ;
         lV7cUsersName = StringUtil.PadR( StringUtil.RTrim( AV7cUsersName), 20, "%");
         lV8cUsersPassword = StringUtil.PadR( StringUtil.RTrim( AV8cUsersPassword), 20, "%");
         lV9cUsersBusiness = StringUtil.PadR( StringUtil.RTrim( AV9cUsersBusiness), 20, "%");
         lV10cUsersCURP = StringUtil.PadR( StringUtil.RTrim( AV10cUsersCURP), 18, "%");
         /* Using cursor H001F3 */
         pr_default.execute(1, new Object[] {AV6cUsersId, lV7cUsersName, lV8cUsersPassword, lV9cUsersBusiness, lV10cUsersCURP, AV11cUsersMatricula});
         GRID1_nRecordCount = H001F3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsersId, AV7cUsersName, AV8cUsersPassword, AV9cUsersBusiness, AV10cUsersCURP, AV11cUsersMatricula) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E181F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusersid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusersid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSERSID");
               GX_FocusControl = edtavCusersid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cUsersId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsersId), 4, 0)));
            }
            else
            {
               AV6cUsersId = (short)(context.localUtil.CToN( cgiGet( edtavCusersid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsersId), 4, 0)));
            }
            AV7cUsersName = cgiGet( edtavCusersname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsersName", AV7cUsersName);
            AV8cUsersPassword = cgiGet( edtavCuserspassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsersPassword", AV8cUsersPassword);
            cmbavCusersbusiness.Name = cmbavCusersbusiness_Internalname;
            cmbavCusersbusiness.CurrentValue = cgiGet( cmbavCusersbusiness_Internalname);
            AV9cUsersBusiness = cgiGet( cmbavCusersbusiness_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsersBusiness", AV9cUsersBusiness);
            AV10cUsersCURP = cgiGet( edtavCuserscurp_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsersCURP", AV10cUsersCURP);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusersmatricula_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusersmatricula_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSERSMATRICULA");
               GX_FocusControl = edtavCusersmatricula_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cUsersMatricula = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cUsersMatricula), 8, 0)));
            }
            else
            {
               AV11cUsersMatricula = (int)(context.localUtil.CToN( cgiGet( edtavCusersmatricula_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cUsersMatricula), 8, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSERSID"), ",", ".") != Convert.ToDecimal( AV6cUsersId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSNAME"), AV7cUsersName) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSPASSWORD"), AV8cUsersPassword) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSBUSINESS"), AV9cUsersBusiness) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSERSCURP"), AV10cUsersCURP) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSERSMATRICULA"), ",", ".") != Convert.ToDecimal( AV11cUsersMatricula )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E181F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E181F2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", " T4", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E191F2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E201F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E201F2( )
      {
         /* Enter Routine */
         AV12pUsersId = A3UsersId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsersId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV12pUsersId});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pUsersId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pUsersId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsersId), 4, 0)));
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
         PA1F2( ) ;
         WS1F2( ) ;
         WE1F2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201810111853663", true);
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
         context.AddJavascriptSource("gx0030.js", "?201810111853664", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtUsersId_Internalname = "USERSID_"+sGXsfl_74_idx;
         edtUsersName_Internalname = "USERSNAME_"+sGXsfl_74_idx;
         edtUsersPassword_Internalname = "USERSPASSWORD_"+sGXsfl_74_idx;
         cmbUsersBusiness_Internalname = "USERSBUSINESS_"+sGXsfl_74_idx;
         edtUsersCURP_Internalname = "USERSCURP_"+sGXsfl_74_idx;
         edtUsersFotografia_Internalname = "USERSFOTOGRAFIA_"+sGXsfl_74_idx;
         edtUsersMatricula_Internalname = "USERSMATRICULA_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtUsersId_Internalname = "USERSID_"+sGXsfl_74_fel_idx;
         edtUsersName_Internalname = "USERSNAME_"+sGXsfl_74_fel_idx;
         edtUsersPassword_Internalname = "USERSPASSWORD_"+sGXsfl_74_fel_idx;
         cmbUsersBusiness_Internalname = "USERSBUSINESS_"+sGXsfl_74_fel_idx;
         edtUsersCURP_Internalname = "USERSCURP_"+sGXsfl_74_fel_idx;
         edtUsersFotografia_Internalname = "USERSFOTOGRAFIA_"+sGXsfl_74_fel_idx;
         edtUsersMatricula_Internalname = "USERSMATRICULA_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB1F0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)(((nGXsfl_74_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsersId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"AutoId",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtUsersName_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersName_Internalname, "Link", edtUsersName_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersName_Internalname,StringUtil.RTrim( A4UsersName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtUsersName_Link,(String)"",(String)"",(String)"",(String)edtUsersName_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersPassword_Internalname,StringUtil.RTrim( A5UsersPassword),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsersPassword_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbUsersBusiness.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "USERSBUSINESS_" + sGXsfl_74_idx;
               cmbUsersBusiness.Name = GXCCtl;
               cmbUsersBusiness.WebTags = "";
               cmbUsersBusiness.addItem("", "(Ninguno)", 0);
               cmbUsersBusiness.addItem("Credi OK", "Credi OK", 0);
               cmbUsersBusiness.addItem("Prexa", "Prexa", 0);
               cmbUsersBusiness.addItem("GDM3", "GDM3", 0);
               if ( cmbUsersBusiness.ItemCount > 0 )
               {
                  A2UsersBusiness = cmbUsersBusiness.getValidValue(A2UsersBusiness);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbUsersBusiness,(String)cmbUsersBusiness_Internalname,StringUtil.RTrim( A2UsersBusiness),(short)1,(String)cmbUsersBusiness_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbUsersBusiness.CurrentValue = StringUtil.RTrim( A2UsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsersBusiness_Internalname, "Values", (String)(cmbUsersBusiness.ToJavascriptSource()), !bGXsfl_74_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersCURP_Internalname,StringUtil.RTrim( A45UsersCURP),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsersCURP_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A46UsersFotografia_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000UsersFotografia_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.PathToRelativeUrl( A46UsersFotografia));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersFotografia_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A46UsersFotografia_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsersMatricula_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A47UsersMatricula), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A47UsersMatricula), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsersMatricula_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes1F2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         cmbavCusersbusiness.Name = "vCUSERSBUSINESS";
         cmbavCusersbusiness.WebTags = "";
         cmbavCusersbusiness.addItem("", "(Ninguno)", 0);
         cmbavCusersbusiness.addItem("Credi OK", "Credi OK", 0);
         cmbavCusersbusiness.addItem("Prexa", "Prexa", 0);
         cmbavCusersbusiness.addItem("GDM3", "GDM3", 0);
         if ( cmbavCusersbusiness.ItemCount > 0 )
         {
            AV9cUsersBusiness = cmbavCusersbusiness.getValidValue(AV9cUsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsersBusiness", AV9cUsersBusiness);
         }
         GXCCtl = "USERSBUSINESS_" + sGXsfl_74_idx;
         cmbUsersBusiness.Name = GXCCtl;
         cmbUsersBusiness.WebTags = "";
         cmbUsersBusiness.addItem("", "(Ninguno)", 0);
         cmbUsersBusiness.addItem("Credi OK", "Credi OK", 0);
         cmbUsersBusiness.addItem("Prexa", "Prexa", 0);
         cmbUsersBusiness.addItem("GDM3", "GDM3", 0);
         if ( cmbUsersBusiness.ItemCount > 0 )
         {
            A2UsersBusiness = cmbUsersBusiness.getValidValue(A2UsersBusiness);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblusersidfilter_Internalname = "LBLUSERSIDFILTER";
         edtavCusersid_Internalname = "vCUSERSID";
         divUsersidfiltercontainer_Internalname = "USERSIDFILTERCONTAINER";
         lblLblusersnamefilter_Internalname = "LBLUSERSNAMEFILTER";
         edtavCusersname_Internalname = "vCUSERSNAME";
         divUsersnamefiltercontainer_Internalname = "USERSNAMEFILTERCONTAINER";
         lblLbluserspasswordfilter_Internalname = "LBLUSERSPASSWORDFILTER";
         edtavCuserspassword_Internalname = "vCUSERSPASSWORD";
         divUserspasswordfiltercontainer_Internalname = "USERSPASSWORDFILTERCONTAINER";
         lblLblusersbusinessfilter_Internalname = "LBLUSERSBUSINESSFILTER";
         cmbavCusersbusiness_Internalname = "vCUSERSBUSINESS";
         divUsersbusinessfiltercontainer_Internalname = "USERSBUSINESSFILTERCONTAINER";
         lblLbluserscurpfilter_Internalname = "LBLUSERSCURPFILTER";
         edtavCuserscurp_Internalname = "vCUSERSCURP";
         divUserscurpfiltercontainer_Internalname = "USERSCURPFILTERCONTAINER";
         lblLblusersmatriculafilter_Internalname = "LBLUSERSMATRICULAFILTER";
         edtavCusersmatricula_Internalname = "vCUSERSMATRICULA";
         divUsersmatriculafiltercontainer_Internalname = "USERSMATRICULAFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtUsersId_Internalname = "USERSID";
         edtUsersName_Internalname = "USERSNAME";
         edtUsersPassword_Internalname = "USERSPASSWORD";
         cmbUsersBusiness_Internalname = "USERSBUSINESS";
         edtUsersCURP_Internalname = "USERSCURP";
         edtUsersFotografia_Internalname = "USERSFOTOGRAFIA";
         edtUsersMatricula_Internalname = "USERSMATRICULA";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtUsersMatricula_Jsonclick = "";
         edtUsersCURP_Jsonclick = "";
         cmbUsersBusiness_Jsonclick = "";
         edtUsersPassword_Jsonclick = "";
         edtUsersName_Jsonclick = "";
         edtUsersId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtUsersName_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCusersmatricula_Jsonclick = "";
         edtavCusersmatricula_Enabled = 1;
         edtavCusersmatricula_Visible = 1;
         edtavCuserscurp_Jsonclick = "";
         edtavCuserscurp_Enabled = 1;
         edtavCuserscurp_Visible = 1;
         cmbavCusersbusiness_Jsonclick = "";
         cmbavCusersbusiness.Enabled = 1;
         cmbavCusersbusiness.Visible = 1;
         edtavCuserspassword_Jsonclick = "";
         edtavCuserspassword_Enabled = 1;
         edtavCuserspassword_Visible = 1;
         edtavCusersname_Jsonclick = "";
         edtavCusersname_Enabled = 1;
         edtavCusersname_Visible = 1;
         edtavCusersid_Jsonclick = "";
         edtavCusersid_Enabled = 1;
         edtavCusersid_Visible = 1;
         divUsersmatriculafiltercontainer_Class = "AdvancedContainerItem";
         divUserscurpfiltercontainer_Class = "AdvancedContainerItem";
         divUsersbusinessfiltercontainer_Class = "AdvancedContainerItem";
         divUserspasswordfiltercontainer_Class = "AdvancedContainerItem";
         divUsersnamefiltercontainer_Class = "AdvancedContainerItem";
         divUsersidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List  T4";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cUsersId',fld:'vCUSERSID',pic:'ZZZ9'},{av:'AV7cUsersName',fld:'vCUSERSNAME',pic:''},{av:'AV8cUsersPassword',fld:'vCUSERSPASSWORD',pic:''},{av:'cmbavCusersbusiness'},{av:'AV9cUsersBusiness',fld:'vCUSERSBUSINESS',pic:''},{av:'AV10cUsersCURP',fld:'vCUSERSCURP',pic:''},{av:'AV11cUsersMatricula',fld:'vCUSERSMATRICULA',pic:'ZZZZZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E171F1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLUSERSIDFILTER.CLICK","{handler:'E111F1',iparms:[{av:'divUsersidfiltercontainer_Class',ctrl:'USERSIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSIDFILTER.CLICK",",oparms:[{av:'divUsersidfiltercontainer_Class',ctrl:'USERSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusersid_Visible',ctrl:'vCUSERSID',prop:'Visible'}]}");
         setEventMetadata("LBLUSERSNAMEFILTER.CLICK","{handler:'E121F1',iparms:[{av:'divUsersnamefiltercontainer_Class',ctrl:'USERSNAMEFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSNAMEFILTER.CLICK",",oparms:[{av:'divUsersnamefiltercontainer_Class',ctrl:'USERSNAMEFILTERCONTAINER',prop:'Class'},{av:'edtavCusersname_Visible',ctrl:'vCUSERSNAME',prop:'Visible'}]}");
         setEventMetadata("LBLUSERSPASSWORDFILTER.CLICK","{handler:'E131F1',iparms:[{av:'divUserspasswordfiltercontainer_Class',ctrl:'USERSPASSWORDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSPASSWORDFILTER.CLICK",",oparms:[{av:'divUserspasswordfiltercontainer_Class',ctrl:'USERSPASSWORDFILTERCONTAINER',prop:'Class'},{av:'edtavCuserspassword_Visible',ctrl:'vCUSERSPASSWORD',prop:'Visible'}]}");
         setEventMetadata("LBLUSERSBUSINESSFILTER.CLICK","{handler:'E141F1',iparms:[{av:'divUsersbusinessfiltercontainer_Class',ctrl:'USERSBUSINESSFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSBUSINESSFILTER.CLICK",",oparms:[{av:'divUsersbusinessfiltercontainer_Class',ctrl:'USERSBUSINESSFILTERCONTAINER',prop:'Class'},{av:'cmbavCusersbusiness'}]}");
         setEventMetadata("LBLUSERSCURPFILTER.CLICK","{handler:'E151F1',iparms:[{av:'divUserscurpfiltercontainer_Class',ctrl:'USERSCURPFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSCURPFILTER.CLICK",",oparms:[{av:'divUserscurpfiltercontainer_Class',ctrl:'USERSCURPFILTERCONTAINER',prop:'Class'},{av:'edtavCuserscurp_Visible',ctrl:'vCUSERSCURP',prop:'Visible'}]}");
         setEventMetadata("LBLUSERSMATRICULAFILTER.CLICK","{handler:'E161F1',iparms:[{av:'divUsersmatriculafiltercontainer_Class',ctrl:'USERSMATRICULAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLUSERSMATRICULAFILTER.CLICK",",oparms:[{av:'divUsersmatriculafiltercontainer_Class',ctrl:'USERSMATRICULAFILTERCONTAINER',prop:'Class'},{av:'edtavCusersmatricula_Visible',ctrl:'vCUSERSMATRICULA',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E201F2',iparms:[{av:'A3UsersId',fld:'USERSID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV12pUsersId',fld:'vPUSERSID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cUsersId',fld:'vCUSERSID',pic:'ZZZ9'},{av:'AV7cUsersName',fld:'vCUSERSNAME',pic:''},{av:'AV8cUsersPassword',fld:'vCUSERSPASSWORD',pic:''},{av:'cmbavCusersbusiness'},{av:'AV9cUsersBusiness',fld:'vCUSERSBUSINESS',pic:''},{av:'AV10cUsersCURP',fld:'vCUSERSCURP',pic:''},{av:'AV11cUsersMatricula',fld:'vCUSERSMATRICULA',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cUsersId',fld:'vCUSERSID',pic:'ZZZ9'},{av:'AV7cUsersName',fld:'vCUSERSNAME',pic:''},{av:'AV8cUsersPassword',fld:'vCUSERSPASSWORD',pic:''},{av:'cmbavCusersbusiness'},{av:'AV9cUsersBusiness',fld:'vCUSERSBUSINESS',pic:''},{av:'AV10cUsersCURP',fld:'vCUSERSCURP',pic:''},{av:'AV11cUsersMatricula',fld:'vCUSERSMATRICULA',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cUsersId',fld:'vCUSERSID',pic:'ZZZ9'},{av:'AV7cUsersName',fld:'vCUSERSNAME',pic:''},{av:'AV8cUsersPassword',fld:'vCUSERSPASSWORD',pic:''},{av:'cmbavCusersbusiness'},{av:'AV9cUsersBusiness',fld:'vCUSERSBUSINESS',pic:''},{av:'AV10cUsersCURP',fld:'vCUSERSCURP',pic:''},{av:'AV11cUsersMatricula',fld:'vCUSERSMATRICULA',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cUsersId',fld:'vCUSERSID',pic:'ZZZ9'},{av:'AV7cUsersName',fld:'vCUSERSNAME',pic:''},{av:'AV8cUsersPassword',fld:'vCUSERSPASSWORD',pic:''},{av:'cmbavCusersbusiness'},{av:'AV9cUsersBusiness',fld:'vCUSERSBUSINESS',pic:''},{av:'AV10cUsersCURP',fld:'vCUSERSCURP',pic:''},{av:'AV11cUsersMatricula',fld:'vCUSERSMATRICULA',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
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
         AV7cUsersName = "";
         AV8cUsersPassword = "";
         AV9cUsersBusiness = "";
         AV10cUsersCURP = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblusersidfilter_Jsonclick = "";
         TempTags = "";
         lblLblusersnamefilter_Jsonclick = "";
         lblLbluserspasswordfilter_Jsonclick = "";
         lblLblusersbusinessfilter_Jsonclick = "";
         lblLbluserscurpfilter_Jsonclick = "";
         lblLblusersmatriculafilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A4UsersName = "";
         A5UsersPassword = "";
         A2UsersBusiness = "";
         A45UsersCURP = "";
         A46UsersFotografia = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         A40000UsersFotografia_GXI = "";
         scmdbuf = "";
         lV7cUsersName = "";
         lV8cUsersPassword = "";
         lV9cUsersBusiness = "";
         lV10cUsersCURP = "";
         H001F2_A47UsersMatricula = new int[1] ;
         H001F2_A40000UsersFotografia_GXI = new String[] {""} ;
         H001F2_A45UsersCURP = new String[] {""} ;
         H001F2_A2UsersBusiness = new String[] {""} ;
         H001F2_A5UsersPassword = new String[] {""} ;
         H001F2_A4UsersName = new String[] {""} ;
         H001F2_A3UsersId = new short[1] ;
         H001F2_A46UsersFotografia = new String[] {""} ;
         H001F3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0030__default(),
            new Object[][] {
                new Object[] {
               H001F2_A47UsersMatricula, H001F2_A40000UsersFotografia_GXI, H001F2_A45UsersCURP, H001F2_A2UsersBusiness, H001F2_A5UsersPassword, H001F2_A4UsersName, H001F2_A3UsersId, H001F2_A46UsersFotografia
               }
               , new Object[] {
               H001F3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short GRID1_nEOF ;
      private short AV6cUsersId ;
      private short AV12pUsersId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A3UsersId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV11cUsersMatricula ;
      private int edtavCusersid_Enabled ;
      private int edtavCusersid_Visible ;
      private int edtavCusersname_Visible ;
      private int edtavCusersname_Enabled ;
      private int edtavCuserspassword_Visible ;
      private int edtavCuserspassword_Enabled ;
      private int edtavCuserscurp_Visible ;
      private int edtavCuserscurp_Enabled ;
      private int edtavCusersmatricula_Enabled ;
      private int edtavCusersmatricula_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A47UsersMatricula ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divUsersidfiltercontainer_Class ;
      private String divUsersnamefiltercontainer_Class ;
      private String divUserspasswordfiltercontainer_Class ;
      private String divUsersbusinessfiltercontainer_Class ;
      private String divUserscurpfiltercontainer_Class ;
      private String divUsersmatriculafiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String AV7cUsersName ;
      private String AV8cUsersPassword ;
      private String AV9cUsersBusiness ;
      private String AV10cUsersCURP ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divUsersidfiltercontainer_Internalname ;
      private String lblLblusersidfilter_Internalname ;
      private String lblLblusersidfilter_Jsonclick ;
      private String edtavCusersid_Internalname ;
      private String TempTags ;
      private String edtavCusersid_Jsonclick ;
      private String divUsersnamefiltercontainer_Internalname ;
      private String lblLblusersnamefilter_Internalname ;
      private String lblLblusersnamefilter_Jsonclick ;
      private String edtavCusersname_Internalname ;
      private String edtavCusersname_Jsonclick ;
      private String divUserspasswordfiltercontainer_Internalname ;
      private String lblLbluserspasswordfilter_Internalname ;
      private String lblLbluserspasswordfilter_Jsonclick ;
      private String edtavCuserspassword_Internalname ;
      private String edtavCuserspassword_Jsonclick ;
      private String divUsersbusinessfiltercontainer_Internalname ;
      private String lblLblusersbusinessfilter_Internalname ;
      private String lblLblusersbusinessfilter_Jsonclick ;
      private String cmbavCusersbusiness_Internalname ;
      private String cmbavCusersbusiness_Jsonclick ;
      private String divUserscurpfiltercontainer_Internalname ;
      private String lblLbluserscurpfilter_Internalname ;
      private String lblLbluserscurpfilter_Jsonclick ;
      private String edtavCuserscurp_Internalname ;
      private String edtavCuserscurp_Jsonclick ;
      private String divUsersmatriculafiltercontainer_Internalname ;
      private String lblLblusersmatriculafilter_Internalname ;
      private String lblLblusersmatriculafilter_Jsonclick ;
      private String edtavCusersmatricula_Internalname ;
      private String edtavCusersmatricula_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String A4UsersName ;
      private String edtUsersName_Link ;
      private String A5UsersPassword ;
      private String A2UsersBusiness ;
      private String A45UsersCURP ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUsersId_Internalname ;
      private String edtUsersName_Internalname ;
      private String edtUsersPassword_Internalname ;
      private String cmbUsersBusiness_Internalname ;
      private String edtUsersCURP_Internalname ;
      private String edtUsersFotografia_Internalname ;
      private String edtUsersMatricula_Internalname ;
      private String scmdbuf ;
      private String lV7cUsersName ;
      private String lV8cUsersPassword ;
      private String lV9cUsersBusiness ;
      private String lV10cUsersCURP ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtUsersId_Jsonclick ;
      private String edtUsersName_Jsonclick ;
      private String edtUsersPassword_Jsonclick ;
      private String GXCCtl ;
      private String cmbUsersBusiness_Jsonclick ;
      private String edtUsersCURP_Jsonclick ;
      private String edtUsersMatricula_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private bool A46UsersFotografia_IsBlob ;
      private String AV16Linkselection_GXI ;
      private String A40000UsersFotografia_GXI ;
      private String AV5LinkSelection ;
      private String A46UsersFotografia ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCusersbusiness ;
      private GXCombobox cmbUsersBusiness ;
      private IDataStoreProvider pr_default ;
      private int[] H001F2_A47UsersMatricula ;
      private String[] H001F2_A40000UsersFotografia_GXI ;
      private String[] H001F2_A45UsersCURP ;
      private String[] H001F2_A2UsersBusiness ;
      private String[] H001F2_A5UsersPassword ;
      private String[] H001F2_A4UsersName ;
      private short[] H001F2_A3UsersId ;
      private String[] H001F2_A46UsersFotografia ;
      private long[] H001F3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pUsersId ;
      private GXWebForm Form ;
   }

   public class gx0030__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001F2( IGxContext context ,
                                             String AV7cUsersName ,
                                             String AV8cUsersPassword ,
                                             String AV9cUsersBusiness ,
                                             String AV10cUsersCURP ,
                                             int AV11cUsersMatricula ,
                                             String A4UsersName ,
                                             String A5UsersPassword ,
                                             String A2UsersBusiness ,
                                             String A45UsersCURP ,
                                             int A47UsersMatricula ,
                                             short AV6cUsersId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [UsersMatricula], [UsersFotografia_GXI], [UsersCURP], [UsersBusiness], [UsersPassword], [UsersName], [UsersId], [UsersFotografia]";
         sFromString = " FROM [Users] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([UsersId] >= @AV6cUsersId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cUsersName)) )
         {
            sWhereString = sWhereString + " and ([UsersName] like @lV7cUsersName)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cUsersPassword)) )
         {
            sWhereString = sWhereString + " and ([UsersPassword] like @lV8cUsersPassword)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cUsersBusiness)) )
         {
            sWhereString = sWhereString + " and ([UsersBusiness] like @lV9cUsersBusiness)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cUsersCURP)) )
         {
            sWhereString = sWhereString + " and ([UsersCURP] like @lV10cUsersCURP)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cUsersMatricula) )
         {
            sWhereString = sWhereString + " and ([UsersMatricula] >= @AV11cUsersMatricula)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [UsersId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001F3( IGxContext context ,
                                             String AV7cUsersName ,
                                             String AV8cUsersPassword ,
                                             String AV9cUsersBusiness ,
                                             String AV10cUsersCURP ,
                                             int AV11cUsersMatricula ,
                                             String A4UsersName ,
                                             String A5UsersPassword ,
                                             String A2UsersBusiness ,
                                             String A45UsersCURP ,
                                             int A47UsersMatricula ,
                                             short AV6cUsersId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Users] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([UsersId] >= @AV6cUsersId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cUsersName)) )
         {
            sWhereString = sWhereString + " and ([UsersName] like @lV7cUsersName)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cUsersPassword)) )
         {
            sWhereString = sWhereString + " and ([UsersPassword] like @lV8cUsersPassword)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cUsersBusiness)) )
         {
            sWhereString = sWhereString + " and ([UsersBusiness] like @lV9cUsersBusiness)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cUsersCURP)) )
         {
            sWhereString = sWhereString + " and ([UsersCURP] like @lV10cUsersCURP)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cUsersMatricula) )
         {
            sWhereString = sWhereString + " and ([UsersMatricula] >= @AV11cUsersMatricula)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001F2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (int)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H001F3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (int)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001F2 ;
          prmH001F2 = new Object[] {
          new Object[] {"@AV6cUsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cUsersName",SqlDbType.Char,20,0} ,
          new Object[] {"@lV8cUsersPassword",SqlDbType.Char,20,0} ,
          new Object[] {"@lV9cUsersBusiness",SqlDbType.Char,20,0} ,
          new Object[] {"@lV10cUsersCURP",SqlDbType.Char,18,0} ,
          new Object[] {"@AV11cUsersMatricula",SqlDbType.Int,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001F3 ;
          prmH001F3 = new Object[] {
          new Object[] {"@AV6cUsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cUsersName",SqlDbType.Char,20,0} ,
          new Object[] {"@lV8cUsersPassword",SqlDbType.Char,20,0} ,
          new Object[] {"@lV9cUsersBusiness",SqlDbType.Char,20,0} ,
          new Object[] {"@lV10cUsersCURP",SqlDbType.Char,18,0} ,
          new Object[] {"@AV11cUsersMatricula",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F2,11,0,false,false )
             ,new CursorDef("H001F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F3,1,0,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 18) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(2)) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                return;
       }
    }

 }

}
