/*
               File: Gx0071
        Description: Selection List Movimientos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:9.56
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
   public class gx0071 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0071( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0071( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_pMonederoElectronicoId ,
                           out short aP1_pMovimientosId )
      {
         this.AV10pMonederoElectronicoId = aP0_pMonederoElectronicoId;
         this.AV11pMovimientosId = 0 ;
         executePrivate();
         aP1_pMovimientosId=this.AV11pMovimientosId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCmovimientostipomonto = new GXCombobox();
         cmbMovimientosTipoMonto = new GXCombobox();
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
               nRC_GXsfl_54 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_54_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_54_idx = GetNextPar( );
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
               AV6cMovimientosId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cMovimientosFecha = context.localUtil.ParseDateParm( GetNextPar( ));
               AV8cMovimientosCantidad = NumberUtil.Val( GetNextPar( ), ".");
               AV9cMovimientosTipoMonto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10pMonederoElectronicoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
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
               AV10pMonederoElectronicoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pMonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pMonederoElectronicoId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pMovimientosId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pMovimientosId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pMovimientosId), 4, 0)));
               }
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
         PA1H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1H2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201810111853963", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0071.aspx") + "?" + UrlEncode("" +AV10pMonederoElectronicoId) + "," + UrlEncode("" +AV11pMovimientosId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cMovimientosId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOSFECHA", context.localUtil.Format(AV7cMovimientosFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOSCANTIDAD", StringUtil.LTrim( StringUtil.NToC( AV8cMovimientosCantidad, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOSTIPOMONTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cMovimientosTipoMonto), 4, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_54", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_54), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPMONEDEROELECTRONICOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pMonederoElectronicoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPMOVIMIENTOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pMovimientosId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSIDFILTERCONTAINER_Class", StringUtil.RTrim( divMovimientosidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSFECHAFILTERCONTAINER_Class", StringUtil.RTrim( divMovimientosfechafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSCANTIDADFILTERCONTAINER_Class", StringUtil.RTrim( divMovimientoscantidadfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSTIPOMONTOFILTERCONTAINER_Class", StringUtil.RTrim( divMovimientostipomontofiltercontainer_Class));
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
            WE1H2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1H2( ) ;
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
         return formatLink("gx0071.aspx") + "?" + UrlEncode("" +AV10pMonederoElectronicoId) + "," + UrlEncode("" +AV11pMovimientosId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0071" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Movimientos" ;
      }

      protected void WB1H0( )
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
            GxWebStd.gx_div_start( context, divMovimientosidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divMovimientosidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmovimientosidfilter_Internalname, "Movimientos Id", "", "", lblLblmovimientosidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmovimientosid_Internalname, "Movimientos Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmovimientosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cMovimientosId), 4, 0, ",", "")), ((edtavCmovimientosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cMovimientosId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cMovimientosId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmovimientosid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCmovimientosid_Visible, edtavCmovimientosid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divMovimientosfechafiltercontainer_Internalname, 1, 0, "px", 0, "px", divMovimientosfechafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmovimientosfechafilter_Internalname, "Movimientos Fecha", "", "", lblLblmovimientosfechafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121h1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmovimientosfecha_Internalname, "Movimientos Fecha", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_54_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCmovimientosfecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCmovimientosfecha_Internalname, context.localUtil.Format(AV7cMovimientosFecha, "99/99/99"), context.localUtil.Format( AV7cMovimientosFecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmovimientosfecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCmovimientosfecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0071.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divMovimientoscantidadfiltercontainer_Internalname, 1, 0, "px", 0, "px", divMovimientoscantidadfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmovimientoscantidadfilter_Internalname, "Movimientos Cantidad", "", "", lblLblmovimientoscantidadfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmovimientoscantidad_Internalname, "Movimientos Cantidad", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmovimientoscantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cMovimientosCantidad, 14, 2, ",", "")), ((edtavCmovimientoscantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cMovimientosCantidad, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( AV8cMovimientosCantidad, "$ Z,ZZZ,ZZZ.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmovimientoscantidad_Jsonclick, 0, "Attribute", "", "", "", "", edtavCmovimientoscantidad_Visible, edtavCmovimientoscantidad_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divMovimientostipomontofiltercontainer_Internalname, 1, 0, "px", 0, "px", divMovimientostipomontofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmovimientostipomontofilter_Internalname, "Movimientos Tipo Monto", "", "", lblLblmovimientostipomontofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCmovimientostipomonto_Internalname, "Movimientos Tipo Monto", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_54_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCmovimientostipomonto, cmbavCmovimientostipomonto_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0)), 1, cmbavCmovimientostipomonto_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCmovimientostipomonto.Visible, cmbavCmovimientostipomonto.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_Gx0071.htm");
            cmbavCmovimientostipomonto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCmovimientostipomonto_Internalname, "Values", (String)(cmbavCmovimientostipomonto.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(54), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e151h1_client"+"'", TempTags, "", 2, "HLP_Gx0071.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"54\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Monto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Monedero Electronico Id") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A41MovimientosFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtMovimientosFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39MovimientosTipoMonto), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9MonederoElectronicoId), 4, 0, ".", "")));
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
         if ( wbEnd == 54 )
         {
            wbEnd = 0;
            nRC_GXsfl_54 = (short)(nGXsfl_54_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(54), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0071.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 54 )
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

      protected void START1H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List Movimientos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1H0( ) ;
      }

      protected void WS1H2( )
      {
         START1H2( ) ;
         EVT1H2( ) ;
      }

      protected void EVT1H2( )
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
                              nGXsfl_54_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
                              SubsflControlProps_542( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_54_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A10MovimientosId = (short)(context.localUtil.CToN( cgiGet( edtMovimientosId_Internalname), ",", "."));
                              A41MovimientosFecha = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtMovimientosFecha_Internalname), 0));
                              A38MovimientosCantidad = context.localUtil.CToN( cgiGet( edtMovimientosCantidad_Internalname), ",", ".");
                              cmbMovimientosTipoMonto.Name = cmbMovimientosTipoMonto_Internalname;
                              cmbMovimientosTipoMonto.CurrentValue = cgiGet( cmbMovimientosTipoMonto_Internalname);
                              A39MovimientosTipoMonto = (short)(NumberUtil.Val( cgiGet( cmbMovimientosTipoMonto_Internalname), "."));
                              A9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( edtMonederoElectronicoId_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E161H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E171H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cmovimientosid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSID"), ",", ".") != Convert.ToDecimal( AV6cMovimientosId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmovimientosfecha Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCMOVIMIENTOSFECHA"), 0) != AV7cMovimientosFecha )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmovimientoscantidad Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSCANTIDAD"), ",", ".") != AV8cMovimientosCantidad )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmovimientostipomonto Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSTIPOMONTO"), ",", ".") != Convert.ToDecimal( AV9cMovimientosTipoMonto )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E181H2 ();
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

      protected void WE1H2( )
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

      protected void PA1H2( )
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
         SubsflControlProps_542( ) ;
         while ( nGXsfl_54_idx <= nRC_GXsfl_54 )
         {
            sendrow_542( ) ;
            nGXsfl_54_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_54_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_54_idx+1));
            sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
            SubsflControlProps_542( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cMovimientosId ,
                                        DateTime AV7cMovimientosFecha ,
                                        decimal AV8cMovimientosCantidad ,
                                        short AV9cMovimientosTipoMonto ,
                                        short AV10pMonederoElectronicoId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1H2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_MOVIMIENTOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A10MovimientosId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ".", "")));
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
         if ( cmbavCmovimientostipomonto.ItemCount > 0 )
         {
            AV9cMovimientosTipoMonto = (short)(NumberUtil.Val( cmbavCmovimientostipomonto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientosTipoMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCmovimientostipomonto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCmovimientostipomonto_Internalname, "Values", cmbavCmovimientostipomonto.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1H2( ) ;
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

      protected void RF1H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 54;
         nGXsfl_54_idx = 1;
         sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
         SubsflControlProps_542( ) ;
         bGXsfl_54_Refreshing = true;
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
            SubsflControlProps_542( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cMovimientosFecha ,
                                                 AV8cMovimientosCantidad ,
                                                 AV9cMovimientosTipoMonto ,
                                                 A41MovimientosFecha ,
                                                 A38MovimientosCantidad ,
                                                 A39MovimientosTipoMonto ,
                                                 AV10pMonederoElectronicoId ,
                                                 AV6cMovimientosId ,
                                                 A9MonederoElectronicoId } ,
                                                 new int[]{
                                                 TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H001H2 */
            pr_default.execute(0, new Object[] {AV10pMonederoElectronicoId, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_54_idx = 1;
            sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
            SubsflControlProps_542( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A9MonederoElectronicoId = H001H2_A9MonederoElectronicoId[0];
               A39MovimientosTipoMonto = H001H2_A39MovimientosTipoMonto[0];
               A38MovimientosCantidad = H001H2_A38MovimientosCantidad[0];
               A41MovimientosFecha = H001H2_A41MovimientosFecha[0];
               A10MovimientosId = H001H2_A10MovimientosId[0];
               /* Execute user event: Load */
               E171H2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 54;
            WB1H0( ) ;
         }
         bGXsfl_54_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_MOVIMIENTOSID"+"_"+sGXsfl_54_idx, GetSecureSignedToken( sGXsfl_54_idx, context.localUtil.Format( (decimal)(A10MovimientosId), "ZZZ9"), context));
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
                                              AV7cMovimientosFecha ,
                                              AV8cMovimientosCantidad ,
                                              AV9cMovimientosTipoMonto ,
                                              A41MovimientosFecha ,
                                              A38MovimientosCantidad ,
                                              A39MovimientosTipoMonto ,
                                              AV10pMonederoElectronicoId ,
                                              AV6cMovimientosId ,
                                              A9MonederoElectronicoId } ,
                                              new int[]{
                                              TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H001H3 */
         pr_default.execute(1, new Object[] {AV10pMonederoElectronicoId, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto});
         GRID1_nRecordCount = H001H3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cMovimientosId, AV7cMovimientosFecha, AV8cMovimientosCantidad, AV9cMovimientosTipoMonto, AV10pMonederoElectronicoId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E161H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmovimientosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmovimientosid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMOVIMIENTOSID");
               GX_FocusControl = edtavCmovimientosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cMovimientosId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cMovimientosId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cMovimientosId), 4, 0)));
            }
            else
            {
               AV6cMovimientosId = (short)(context.localUtil.CToN( cgiGet( edtavCmovimientosid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cMovimientosId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cMovimientosId), 4, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCmovimientosfecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Movimientos Fecha"}), 1, "vCMOVIMIENTOSFECHA");
               GX_FocusControl = edtavCmovimientosfecha_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cMovimientosFecha = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cMovimientosFecha", context.localUtil.Format(AV7cMovimientosFecha, "99/99/99"));
            }
            else
            {
               AV7cMovimientosFecha = context.localUtil.CToD( cgiGet( edtavCmovimientosfecha_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cMovimientosFecha", context.localUtil.Format(AV7cMovimientosFecha, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmovimientoscantidad_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmovimientoscantidad_Internalname), ",", ".") > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMOVIMIENTOSCANTIDAD");
               GX_FocusControl = edtavCmovimientoscantidad_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cMovimientosCantidad = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientosCantidad", StringUtil.LTrim( StringUtil.Str( AV8cMovimientosCantidad, 10, 2)));
            }
            else
            {
               AV8cMovimientosCantidad = context.localUtil.CToN( cgiGet( edtavCmovimientoscantidad_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientosCantidad", StringUtil.LTrim( StringUtil.Str( AV8cMovimientosCantidad, 10, 2)));
            }
            cmbavCmovimientostipomonto.Name = cmbavCmovimientostipomonto_Internalname;
            cmbavCmovimientostipomonto.CurrentValue = cgiGet( cmbavCmovimientostipomonto_Internalname);
            AV9cMovimientosTipoMonto = (short)(NumberUtil.Val( cgiGet( cmbavCmovimientostipomonto_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientosTipoMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0)));
            /* Read saved values. */
            nRC_GXsfl_54 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_54"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSID"), ",", ".") != Convert.ToDecimal( AV6cMovimientosId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vCMOVIMIENTOSFECHA"), 2) != AV7cMovimientosFecha )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSCANTIDAD"), ",", ".") != AV8cMovimientosCantidad )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOSTIPOMONTO"), ",", ".") != Convert.ToDecimal( AV9cMovimientosTipoMonto )) )
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
         E161H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E161H2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Movimientos", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV12ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E171H2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV15Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_542( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_54_Refreshing )
         {
            context.DoAjaxLoad(54, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E181H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E181H2( )
      {
         /* Enter Routine */
         AV11pMovimientosId = A10MovimientosId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pMovimientosId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pMovimientosId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV11pMovimientosId});
         context.setWebReturnParmsMetadata(new Object[] {"AV11pMovimientosId"});
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
         AV10pMonederoElectronicoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pMonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pMonederoElectronicoId), 4, 0)));
         AV11pMovimientosId = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pMovimientosId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pMovimientosId), 4, 0)));
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
         PA1H2( ) ;
         WS1H2( ) ;
         WE1H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118531059", true);
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
         context.AddJavascriptSource("gx0071.js", "?2018101118531059", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_542( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_54_idx;
         edtMovimientosId_Internalname = "MOVIMIENTOSID_"+sGXsfl_54_idx;
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA_"+sGXsfl_54_idx;
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD_"+sGXsfl_54_idx;
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO_"+sGXsfl_54_idx;
         edtMonederoElectronicoId_Internalname = "MONEDEROELECTRONICOID_"+sGXsfl_54_idx;
      }

      protected void SubsflControlProps_fel_542( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_54_fel_idx;
         edtMovimientosId_Internalname = "MOVIMIENTOSID_"+sGXsfl_54_fel_idx;
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA_"+sGXsfl_54_fel_idx;
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD_"+sGXsfl_54_fel_idx;
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO_"+sGXsfl_54_fel_idx;
         edtMonederoElectronicoId_Internalname = "MONEDEROELECTRONICOID_"+sGXsfl_54_fel_idx;
      }

      protected void sendrow_542( )
      {
         SubsflControlProps_542( ) ;
         WB1H0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_54_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_54_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_54_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_54_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV15Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A10MovimientosId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientosId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtMovimientosFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosFecha_Internalname, "Link", edtMovimientosFecha_Link, !bGXsfl_54_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosFecha_Internalname,context.localUtil.Format(A41MovimientosFecha, "99/99/99"),context.localUtil.Format( A41MovimientosFecha, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtMovimientosFecha_Link,(String)"",(String)"",(String)"",(String)edtMovimientosFecha_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ",", "")),context.localUtil.Format( A38MovimientosCantidad, "$ Z,ZZZ,ZZZ.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientosCantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)0,(bool)true,(String)"Currency",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbMovimientosTipoMonto.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "MOVIMIENTOSTIPOMONTO_" + sGXsfl_54_idx;
               cmbMovimientosTipoMonto.Name = GXCCtl;
               cmbMovimientosTipoMonto.WebTags = "";
               cmbMovimientosTipoMonto.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "Elige tipo de Movimiento", 0);
               cmbMovimientosTipoMonto.addItem("1", "Retiro", 0);
               cmbMovimientosTipoMonto.addItem("2", "Deposito", 0);
               if ( cmbMovimientosTipoMonto.ItemCount > 0 )
               {
                  A39MovimientosTipoMonto = (short)(NumberUtil.Val( cmbMovimientosTipoMonto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbMovimientosTipoMonto,(String)cmbMovimientosTipoMonto_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0)),(short)1,(String)cmbMovimientosTipoMonto_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbMovimientosTipoMonto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientosTipoMonto_Internalname, "Values", (String)(cmbMovimientosTipoMonto.ToJavascriptSource()), !bGXsfl_54_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMonederoElectronicoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A9MonederoElectronicoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMonederoElectronicoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)0,(bool)true,(String)"AutoId",(String)"right",(bool)false});
            send_integrity_lvl_hashes1H2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_54_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_54_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_54_idx+1));
            sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
            SubsflControlProps_542( ) ;
         }
         /* End function sendrow_542 */
      }

      protected void init_web_controls( )
      {
         cmbavCmovimientostipomonto.Name = "vCMOVIMIENTOSTIPOMONTO";
         cmbavCmovimientostipomonto.WebTags = "";
         cmbavCmovimientostipomonto.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "Elige tipo de Movimiento", 0);
         cmbavCmovimientostipomonto.addItem("1", "Retiro", 0);
         cmbavCmovimientostipomonto.addItem("2", "Deposito", 0);
         if ( cmbavCmovimientostipomonto.ItemCount > 0 )
         {
            AV9cMovimientosTipoMonto = (short)(NumberUtil.Val( cmbavCmovimientostipomonto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientosTipoMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovimientosTipoMonto), 4, 0)));
         }
         GXCCtl = "MOVIMIENTOSTIPOMONTO_" + sGXsfl_54_idx;
         cmbMovimientosTipoMonto.Name = GXCCtl;
         cmbMovimientosTipoMonto.WebTags = "";
         cmbMovimientosTipoMonto.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "Elige tipo de Movimiento", 0);
         cmbMovimientosTipoMonto.addItem("1", "Retiro", 0);
         cmbMovimientosTipoMonto.addItem("2", "Deposito", 0);
         if ( cmbMovimientosTipoMonto.ItemCount > 0 )
         {
            A39MovimientosTipoMonto = (short)(NumberUtil.Val( cmbMovimientosTipoMonto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblmovimientosidfilter_Internalname = "LBLMOVIMIENTOSIDFILTER";
         edtavCmovimientosid_Internalname = "vCMOVIMIENTOSID";
         divMovimientosidfiltercontainer_Internalname = "MOVIMIENTOSIDFILTERCONTAINER";
         lblLblmovimientosfechafilter_Internalname = "LBLMOVIMIENTOSFECHAFILTER";
         edtavCmovimientosfecha_Internalname = "vCMOVIMIENTOSFECHA";
         divMovimientosfechafiltercontainer_Internalname = "MOVIMIENTOSFECHAFILTERCONTAINER";
         lblLblmovimientoscantidadfilter_Internalname = "LBLMOVIMIENTOSCANTIDADFILTER";
         edtavCmovimientoscantidad_Internalname = "vCMOVIMIENTOSCANTIDAD";
         divMovimientoscantidadfiltercontainer_Internalname = "MOVIMIENTOSCANTIDADFILTERCONTAINER";
         lblLblmovimientostipomontofilter_Internalname = "LBLMOVIMIENTOSTIPOMONTOFILTER";
         cmbavCmovimientostipomonto_Internalname = "vCMOVIMIENTOSTIPOMONTO";
         divMovimientostipomontofiltercontainer_Internalname = "MOVIMIENTOSTIPOMONTOFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtMovimientosId_Internalname = "MOVIMIENTOSID";
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA";
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD";
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO";
         edtMonederoElectronicoId_Internalname = "MONEDEROELECTRONICOID";
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
         edtMonederoElectronicoId_Jsonclick = "";
         cmbMovimientosTipoMonto_Jsonclick = "";
         edtMovimientosCantidad_Jsonclick = "";
         edtMovimientosFecha_Jsonclick = "";
         edtMovimientosId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtMovimientosFecha_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         cmbavCmovimientostipomonto_Jsonclick = "";
         cmbavCmovimientostipomonto.Enabled = 1;
         cmbavCmovimientostipomonto.Visible = 1;
         edtavCmovimientoscantidad_Jsonclick = "";
         edtavCmovimientoscantidad_Enabled = 1;
         edtavCmovimientoscantidad_Visible = 1;
         edtavCmovimientosfecha_Jsonclick = "";
         edtavCmovimientosfecha_Enabled = 1;
         edtavCmovimientosid_Jsonclick = "";
         edtavCmovimientosid_Enabled = 1;
         edtavCmovimientosid_Visible = 1;
         divMovimientostipomontofiltercontainer_Class = "AdvancedContainerItem";
         divMovimientoscantidadfiltercontainer_Class = "AdvancedContainerItem";
         divMovimientosfechafiltercontainer_Class = "AdvancedContainerItem";
         divMovimientosidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Movimientos";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cMovimientosId',fld:'vCMOVIMIENTOSID',pic:'ZZZ9'},{av:'AV7cMovimientosFecha',fld:'vCMOVIMIENTOSFECHA',pic:''},{av:'AV8cMovimientosCantidad',fld:'vCMOVIMIENTOSCANTIDAD',pic:'$ Z,ZZZ,ZZZ.99'},{av:'cmbavCmovimientostipomonto'},{av:'AV9cMovimientosTipoMonto',fld:'vCMOVIMIENTOSTIPOMONTO',pic:'ZZZ9'},{av:'AV10pMonederoElectronicoId',fld:'vPMONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E151H1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLMOVIMIENTOSIDFILTER.CLICK","{handler:'E111H1',iparms:[{av:'divMovimientosidfiltercontainer_Class',ctrl:'MOVIMIENTOSIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMOVIMIENTOSIDFILTER.CLICK",",oparms:[{av:'divMovimientosidfiltercontainer_Class',ctrl:'MOVIMIENTOSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmovimientosid_Visible',ctrl:'vCMOVIMIENTOSID',prop:'Visible'}]}");
         setEventMetadata("LBLMOVIMIENTOSFECHAFILTER.CLICK","{handler:'E121H1',iparms:[{av:'divMovimientosfechafiltercontainer_Class',ctrl:'MOVIMIENTOSFECHAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMOVIMIENTOSFECHAFILTER.CLICK",",oparms:[{av:'divMovimientosfechafiltercontainer_Class',ctrl:'MOVIMIENTOSFECHAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLMOVIMIENTOSCANTIDADFILTER.CLICK","{handler:'E131H1',iparms:[{av:'divMovimientoscantidadfiltercontainer_Class',ctrl:'MOVIMIENTOSCANTIDADFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMOVIMIENTOSCANTIDADFILTER.CLICK",",oparms:[{av:'divMovimientoscantidadfiltercontainer_Class',ctrl:'MOVIMIENTOSCANTIDADFILTERCONTAINER',prop:'Class'},{av:'edtavCmovimientoscantidad_Visible',ctrl:'vCMOVIMIENTOSCANTIDAD',prop:'Visible'}]}");
         setEventMetadata("LBLMOVIMIENTOSTIPOMONTOFILTER.CLICK","{handler:'E141H1',iparms:[{av:'divMovimientostipomontofiltercontainer_Class',ctrl:'MOVIMIENTOSTIPOMONTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMOVIMIENTOSTIPOMONTOFILTER.CLICK",",oparms:[{av:'divMovimientostipomontofiltercontainer_Class',ctrl:'MOVIMIENTOSTIPOMONTOFILTERCONTAINER',prop:'Class'},{av:'cmbavCmovimientostipomonto'}]}");
         setEventMetadata("ENTER","{handler:'E181H2',iparms:[{av:'A10MovimientosId',fld:'MOVIMIENTOSID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV11pMovimientosId',fld:'vPMOVIMIENTOSID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cMovimientosId',fld:'vCMOVIMIENTOSID',pic:'ZZZ9'},{av:'AV7cMovimientosFecha',fld:'vCMOVIMIENTOSFECHA',pic:''},{av:'AV8cMovimientosCantidad',fld:'vCMOVIMIENTOSCANTIDAD',pic:'$ Z,ZZZ,ZZZ.99'},{av:'cmbavCmovimientostipomonto'},{av:'AV9cMovimientosTipoMonto',fld:'vCMOVIMIENTOSTIPOMONTO',pic:'ZZZ9'},{av:'AV10pMonederoElectronicoId',fld:'vPMONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cMovimientosId',fld:'vCMOVIMIENTOSID',pic:'ZZZ9'},{av:'AV7cMovimientosFecha',fld:'vCMOVIMIENTOSFECHA',pic:''},{av:'AV8cMovimientosCantidad',fld:'vCMOVIMIENTOSCANTIDAD',pic:'$ Z,ZZZ,ZZZ.99'},{av:'cmbavCmovimientostipomonto'},{av:'AV9cMovimientosTipoMonto',fld:'vCMOVIMIENTOSTIPOMONTO',pic:'ZZZ9'},{av:'AV10pMonederoElectronicoId',fld:'vPMONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cMovimientosId',fld:'vCMOVIMIENTOSID',pic:'ZZZ9'},{av:'AV7cMovimientosFecha',fld:'vCMOVIMIENTOSFECHA',pic:''},{av:'AV8cMovimientosCantidad',fld:'vCMOVIMIENTOSCANTIDAD',pic:'$ Z,ZZZ,ZZZ.99'},{av:'cmbavCmovimientostipomonto'},{av:'AV9cMovimientosTipoMonto',fld:'vCMOVIMIENTOSTIPOMONTO',pic:'ZZZ9'},{av:'AV10pMonederoElectronicoId',fld:'vPMONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cMovimientosId',fld:'vCMOVIMIENTOSID',pic:'ZZZ9'},{av:'AV7cMovimientosFecha',fld:'vCMOVIMIENTOSFECHA',pic:''},{av:'AV8cMovimientosCantidad',fld:'vCMOVIMIENTOSCANTIDAD',pic:'$ Z,ZZZ,ZZZ.99'},{av:'cmbavCmovimientostipomonto'},{av:'AV9cMovimientosTipoMonto',fld:'vCMOVIMIENTOSTIPOMONTO',pic:'ZZZ9'},{av:'AV10pMonederoElectronicoId',fld:'vPMONEDEROELECTRONICOID',pic:'ZZZ9'}]");
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
         AV7cMovimientosFecha = DateTime.MinValue;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblmovimientosidfilter_Jsonclick = "";
         TempTags = "";
         lblLblmovimientosfechafilter_Jsonclick = "";
         lblLblmovimientoscantidadfilter_Jsonclick = "";
         lblLblmovimientostipomontofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A41MovimientosFecha = DateTime.MinValue;
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         scmdbuf = "";
         H001H2_A9MonederoElectronicoId = new short[1] ;
         H001H2_A39MovimientosTipoMonto = new short[1] ;
         H001H2_A38MovimientosCantidad = new decimal[1] ;
         H001H2_A41MovimientosFecha = new DateTime[] {DateTime.MinValue} ;
         H001H2_A10MovimientosId = new short[1] ;
         H001H3_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0071__default(),
            new Object[][] {
                new Object[] {
               H001H2_A9MonederoElectronicoId, H001H2_A39MovimientosTipoMonto, H001H2_A38MovimientosCantidad, H001H2_A41MovimientosFecha, H001H2_A10MovimientosId
               }
               , new Object[] {
               H001H3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10pMonederoElectronicoId ;
      private short wcpOAV10pMonederoElectronicoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_54 ;
      private short nGXsfl_54_idx=1 ;
      private short GRID1_nEOF ;
      private short AV6cMovimientosId ;
      private short AV9cMovimientosTipoMonto ;
      private short AV11pMovimientosId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A10MovimientosId ;
      private short A39MovimientosTipoMonto ;
      private short A9MonederoElectronicoId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCmovimientosid_Enabled ;
      private int edtavCmovimientosid_Visible ;
      private int edtavCmovimientosfecha_Enabled ;
      private int edtavCmovimientoscantidad_Enabled ;
      private int edtavCmovimientoscantidad_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
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
      private decimal AV8cMovimientosCantidad ;
      private decimal A38MovimientosCantidad ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divMovimientosidfiltercontainer_Class ;
      private String divMovimientosfechafiltercontainer_Class ;
      private String divMovimientoscantidadfiltercontainer_Class ;
      private String divMovimientostipomontofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_54_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divMovimientosidfiltercontainer_Internalname ;
      private String lblLblmovimientosidfilter_Internalname ;
      private String lblLblmovimientosidfilter_Jsonclick ;
      private String edtavCmovimientosid_Internalname ;
      private String TempTags ;
      private String edtavCmovimientosid_Jsonclick ;
      private String divMovimientosfechafiltercontainer_Internalname ;
      private String lblLblmovimientosfechafilter_Internalname ;
      private String lblLblmovimientosfechafilter_Jsonclick ;
      private String edtavCmovimientosfecha_Internalname ;
      private String edtavCmovimientosfecha_Jsonclick ;
      private String divMovimientoscantidadfiltercontainer_Internalname ;
      private String lblLblmovimientoscantidadfilter_Internalname ;
      private String lblLblmovimientoscantidadfilter_Jsonclick ;
      private String edtavCmovimientoscantidad_Internalname ;
      private String edtavCmovimientoscantidad_Jsonclick ;
      private String divMovimientostipomontofiltercontainer_Internalname ;
      private String lblLblmovimientostipomontofilter_Internalname ;
      private String lblLblmovimientostipomontofilter_Jsonclick ;
      private String cmbavCmovimientostipomonto_Internalname ;
      private String cmbavCmovimientostipomonto_Jsonclick ;
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
      private String edtMovimientosFecha_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtMovimientosId_Internalname ;
      private String edtMovimientosFecha_Internalname ;
      private String edtMovimientosCantidad_Internalname ;
      private String cmbMovimientosTipoMonto_Internalname ;
      private String edtMonederoElectronicoId_Internalname ;
      private String scmdbuf ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_54_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtMovimientosId_Jsonclick ;
      private String edtMovimientosFecha_Jsonclick ;
      private String edtMovimientosCantidad_Jsonclick ;
      private String GXCCtl ;
      private String cmbMovimientosTipoMonto_Jsonclick ;
      private String edtMonederoElectronicoId_Jsonclick ;
      private DateTime AV7cMovimientosFecha ;
      private DateTime A41MovimientosFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_54_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV15Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCmovimientostipomonto ;
      private GXCombobox cmbMovimientosTipoMonto ;
      private IDataStoreProvider pr_default ;
      private short[] H001H2_A9MonederoElectronicoId ;
      private short[] H001H2_A39MovimientosTipoMonto ;
      private decimal[] H001H2_A38MovimientosCantidad ;
      private DateTime[] H001H2_A41MovimientosFecha ;
      private short[] H001H2_A10MovimientosId ;
      private long[] H001H3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP1_pMovimientosId ;
      private GXWebForm Form ;
   }

   public class gx0071__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001H2( IGxContext context ,
                                             DateTime AV7cMovimientosFecha ,
                                             decimal AV8cMovimientosCantidad ,
                                             short AV9cMovimientosTipoMonto ,
                                             DateTime A41MovimientosFecha ,
                                             decimal A38MovimientosCantidad ,
                                             short A39MovimientosTipoMonto ,
                                             short AV10pMonederoElectronicoId ,
                                             short AV6cMovimientosId ,
                                             short A9MonederoElectronicoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [8] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [MonederoElectronicoId], [MovimientosTipoMonto], [MovimientosCantidad], [MovimientosFecha], [MovimientosId]";
         sFromString = " FROM [MonederoElectronicoMovimientos] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([MonederoElectronicoId] = @AV10pMonederoElectronicoId and [MovimientosId] >= @AV6cMovimientosId)";
         if ( ! (DateTime.MinValue==AV7cMovimientosFecha) )
         {
            sWhereString = sWhereString + " and ([MovimientosFecha] >= @AV7cMovimientosFecha)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cMovimientosCantidad) )
         {
            sWhereString = sWhereString + " and ([MovimientosCantidad] >= @AV8cMovimientosCantidad)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV9cMovimientosTipoMonto) )
         {
            sWhereString = sWhereString + " and ([MovimientosTipoMonto] >= @AV9cMovimientosTipoMonto)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [MonederoElectronicoId], [MovimientosId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001H3( IGxContext context ,
                                             DateTime AV7cMovimientosFecha ,
                                             decimal AV8cMovimientosCantidad ,
                                             short AV9cMovimientosTipoMonto ,
                                             DateTime A41MovimientosFecha ,
                                             decimal A38MovimientosCantidad ,
                                             short A39MovimientosTipoMonto ,
                                             short AV10pMonederoElectronicoId ,
                                             short AV6cMovimientosId ,
                                             short A9MonederoElectronicoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [MonederoElectronicoMovimientos] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([MonederoElectronicoId] = @AV10pMonederoElectronicoId and [MovimientosId] >= @AV6cMovimientosId)";
         if ( ! (DateTime.MinValue==AV7cMovimientosFecha) )
         {
            sWhereString = sWhereString + " and ([MovimientosFecha] >= @AV7cMovimientosFecha)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cMovimientosCantidad) )
         {
            sWhereString = sWhereString + " and ([MovimientosCantidad] >= @AV8cMovimientosCantidad)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV9cMovimientosTipoMonto) )
         {
            sWhereString = sWhereString + " and ([MovimientosTipoMonto] >= @AV9cMovimientosTipoMonto)";
         }
         else
         {
            GXv_int3[4] = 1;
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
                     return conditional_H001H2(context, (DateTime)dynConstraints[0] , (decimal)dynConstraints[1] , (short)dynConstraints[2] , (DateTime)dynConstraints[3] , (decimal)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] );
               case 1 :
                     return conditional_H001H3(context, (DateTime)dynConstraints[0] , (decimal)dynConstraints[1] , (short)dynConstraints[2] , (DateTime)dynConstraints[3] , (decimal)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] );
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
          Object[] prmH001H2 ;
          prmH001H2 = new Object[] {
          new Object[] {"@AV10pMonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cMovimientosId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cMovimientosFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cMovimientosCantidad",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV9cMovimientosTipoMonto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001H3 ;
          prmH001H3 = new Object[] {
          new Object[] {"@AV10pMonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cMovimientosId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cMovimientosFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cMovimientosCantidad",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV9cMovimientosTipoMonto",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001H2,11,0,false,false )
             ,new CursorDef("H001H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001H3,1,0,false,false )
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
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                return;
       }
    }

 }

}
