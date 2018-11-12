/*
               File: SendNotifications
        Description: Send Notifications
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:3.16
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
   public class sendnotifications : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public sendnotifications( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public sendnotifications( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavGroupselected = new GXCheckbox();
         dynavGroupnameid = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vGROUPNAMEID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvGROUPNAMEID1C2( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid_groups") == 0 )
            {
               nRC_GXsfl_19 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_19_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_19_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_groups_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid_groups") == 0 )
            {
               ajax_req_read_hidden_sdt(GetNextPar( ), AV23NotificationConfiguration);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_groups_refresh( AV23NotificationConfiguration) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid_groupsselected") == 0 )
            {
               nRC_GXsfl_58 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_58_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_58_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_groupsselected_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid_groupsselected") == 0 )
            {
               subGrid_groupsselected_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV23NotificationConfiguration);
               AV5DeviceId = GetNextPar( );
               A6GroupId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A22GroupName = GetNextPar( );
               A1DeviceId = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid_devices") == 0 )
            {
               nRC_GXsfl_45 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_45_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_45_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_devices_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid_devices") == 0 )
            {
               subGrid_devices_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV23NotificationConfiguration);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
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

      public override short ExecuteStartEvent( )
      {
         PA1C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1C2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201810111853353", false);
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sendnotifications.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_19", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_19), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_45", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_45), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vNOTIFICATIONCONFIGURATION", AV23NotificationConfiguration);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vNOTIFICATIONCONFIGURATION", AV23NotificationConfiguration);
         }
         GxWebStd.gx_hidden_field( context, "DEVICETOKEN", A20DeviceToken);
         GxWebStd.gx_hidden_field( context, "vDEVICEID", AV5DeviceId);
         GxWebStd.gx_hidden_field( context, "GROUPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6GroupId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGROUP", AV14Group);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGROUP", AV14Group);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vNOTIFICATIONMESSAGE", AV25NotificationMessage);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vNOTIFICATIONMESSAGE", AV25NotificationMessage);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vNOTIFICATIONDELIVERY", AV24NotificationDelivery);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vNOTIFICATIONDELIVERY", AV24NotificationDelivery);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTARGETGROUP", AV27TargetGroup);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTARGETGROUP", AV27TargetGroup);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTARGET", AV8Target);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTARGET", AV8Target);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vSUCCESS", AV26Success);
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nEOF), 1, 0, ",", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
            WE1C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("sendnotifications.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SendNotifications" ;
      }

      public override String GetPgmdesc( )
      {
         return "Send Notifications" ;
      }

      protected void WB1C0( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable9_Internalname, 1, 0, "px", 0, "px", "Container", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable10_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup3_Internalname, "Groups", 1, 0, "px", 0, "px", "Group", "", "HLP_SendNotifications.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup3table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid_groupsContainer.SetWrapped(nGXWrapped);
            if ( Grid_groupsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid_groupsContainer"+"DivS\" data-gxgridid=\"19\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_groups_Internalname, subGrid_groups_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_groups_Backcolorstyle == 0 )
               {
                  subGrid_groups_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_groups_Class) > 0 )
                  {
                     subGrid_groups_Linesclass = subGrid_groups_Class+"Title";
                  }
               }
               else
               {
                  subGrid_groups_Titlebackstyle = 1;
                  if ( subGrid_groups_Backcolorstyle == 1 )
                  {
                     subGrid_groups_Titlebackcolor = subGrid_groups_Allbackcolor;
                     if ( StringUtil.Len( subGrid_groups_Class) > 0 )
                     {
                        subGrid_groups_Linesclass = subGrid_groups_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_groups_Class) > 0 )
                     {
                        subGrid_groups_Linesclass = subGrid_groups_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeAcceptDrag"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Group Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid_groupsContainer.AddObjectProperty("GridName", "Grid_groups");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid_groupsContainer = new GXWebGrid( context);
               }
               else
               {
                  Grid_groupsContainer.Clear();
               }
               Grid_groupsContainer.SetWrapped(nGXWrapped);
               Grid_groupsContainer.AddObjectProperty("GridName", "Grid_groups");
               Grid_groupsContainer.AddObjectProperty("Header", subGrid_groups_Header);
               Grid_groupsContainer.AddObjectProperty("Class", "Grid");
               Grid_groupsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Backcolorstyle), 1, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("CmpContext", "");
               Grid_groupsContainer.AddObjectProperty("InMasterPage", "false");
               Grid_groupsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsColumn.AddObjectProperty("Value", StringUtil.RTrim( A22GroupName));
               Grid_groupsContainer.AddColumnProperties(Grid_groupsColumn);
               Grid_groupsContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Selectedindex), 4, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Allowselection), 1, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Selectioncolor), 9, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Allowhovering), 1, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Hoveringcolor), 9, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Allowcollapsing), 1, 0, ".", "")));
               Grid_groupsContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 19 )
         {
            wbEnd = 0;
            nRC_GXsfl_19 = (short)(nGXsfl_19_idx-1);
            if ( Grid_groupsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid_groupsContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_groups", Grid_groupsContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_groupsContainerData", Grid_groupsContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_groupsContainerData"+"V", Grid_groupsContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_groupsContainerData"+"V"+"\" value='"+Grid_groupsContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, "Add Groups", 1, 0, "px", 0, "px", "Group", "", "HLP_SendNotifications.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TableCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGroupname_Internalname, "Group Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_19_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGroupname_Internalname, StringUtil.RTrim( AV17GroupName), StringUtil.RTrim( context.localUtil.Format( AV17GroupName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Group Name", edtavGroupname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGroupname_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SendNotifications.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttAdd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(19), 2, 0)+","+"null"+");", "Add", bttAdd_Jsonclick, 5, "Add", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ADD\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_SendNotifications.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable11_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Container", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpDevices_Internalname, "Devices", 1, 0, "px", 0, "px", "Group", "", "HLP_SendNotifications.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row TableRow_RowDevices", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid_devicesContainer.SetIsFreestyle(true);
            Grid_devicesContainer.SetWrapped(nGXWrapped);
            if ( Grid_devicesContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid_devicesContainer"+"DivS\" data-gxgridid=\"45\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_devices_Internalname, subGrid_devices_Internalname, "", "FreeStyleGridDevicesGroup", 0, "", "", 1, 2, sStyleString, "", "", 0);
               Grid_devicesContainer.AddObjectProperty("GridName", "Grid_devices");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid_devicesContainer = new GXWebGrid( context);
               }
               else
               {
                  Grid_devicesContainer.Clear();
               }
               Grid_devicesContainer.SetIsFreestyle(true);
               Grid_devicesContainer.SetWrapped(nGXWrapped);
               Grid_devicesContainer.AddObjectProperty("GridName", "Grid_devices");
               Grid_devicesContainer.AddObjectProperty("Header", subGrid_devices_Header);
               Grid_devicesContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGridDevicesGroup"));
               Grid_devicesContainer.AddObjectProperty("Class", "FreeStyleGridDevicesGroup");
               Grid_devicesContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Backcolorstyle), 1, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("CmpContext", "");
               Grid_devicesContainer.AddObjectProperty("InMasterPage", "false");
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesColumn.AddObjectProperty("Value", A1DeviceId);
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_devicesContainer.AddColumnProperties(Grid_devicesColumn);
               Grid_devicesContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Selectedindex), 4, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Allowselection), 1, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Selectioncolor), 9, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Allowhovering), 1, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Hoveringcolor), 9, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Allowcollapsing), 1, 0, ".", "")));
               Grid_devicesContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 45 )
         {
            wbEnd = 0;
            nRC_GXsfl_45 = (short)(nGXsfl_45_idx-1);
            if ( Grid_devicesContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid_devicesContainer.AddObjectProperty("GRID_DEVICES_nEOF", GRID_DEVICES_nEOF);
               Grid_devicesContainer.AddObjectProperty("GRID_DEVICES_nFirstRecordOnPage", GRID_DEVICES_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid_devicesContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_devices", Grid_devicesContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_devicesContainerData", Grid_devicesContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_devicesContainerData"+"V", Grid_devicesContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_devicesContainerData"+"V"+"\" value='"+Grid_devicesContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            context.WriteHtmlText( "<hr/>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            context.WriteHtmlText( "<hr/>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup2_Internalname, "Message", 1, 300, "px", 0, "px", "Group", "", "HLP_SendNotifications.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable5_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavGroupnameid_Internalname, "Group Id", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_19_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavGroupnameid, dynavGroupnameid_Internalname, StringUtil.RTrim( AV15GroupNameId), 1, dynavGroupnameid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynavGroupnameid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "", true, "HLP_SendNotifications.htm");
            dynavGroupnameid.CurrentValue = StringUtil.RTrim( AV15GroupNameId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavGroupnameid_Internalname, "Values", (String)(dynavGroupnameid.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, edtavMessagetitle_Internalname, "Message Title", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_19_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMessagetitle_Internalname, AV22MessageTitle, StringUtil.RTrim( context.localUtil.Format( AV22MessageTitle, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Message Title", edtavMessagetitle_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMessagetitle_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SendNotifications.htm");
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
            GxWebStd.gx_label_element( context, edtavMessagebody_Internalname, "Message Body", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_19_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavMessagebody_Internalname, AV21MessageBody, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", 0, 1, edtavMessagebody_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "Please, write down the message to send..", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SendNotifications.htm");
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
            context.WriteHtmlText( "<hr/>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable6_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSend_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(19), 2, 0)+","+"null"+");", "Send", bttSend_Jsonclick, 5, "Send", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'SEND\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_SendNotifications.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 19 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid_groupsContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid_groupsContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_groups", Grid_groupsContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_groupsContainerData", Grid_groupsContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_groupsContainerData"+"V", Grid_groupsContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_groupsContainerData"+"V"+"\" value='"+Grid_groupsContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         if ( wbEnd == 45 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid_devicesContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid_devicesContainer.AddObjectProperty("GRID_DEVICES_nEOF", GRID_DEVICES_nEOF);
                  Grid_devicesContainer.AddObjectProperty("GRID_DEVICES_nFirstRecordOnPage", GRID_DEVICES_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid_devicesContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_devices", Grid_devicesContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_devicesContainerData", Grid_devicesContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_devicesContainerData"+"V", Grid_devicesContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_devicesContainerData"+"V"+"\" value='"+Grid_devicesContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         if ( wbEnd == 58 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid_groupsselectedContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid_groupsselectedContainer.AddObjectProperty("GRID_GROUPSSELECTED_nEOF", GRID_GROUPSSELECTED_nEOF);
                  Grid_groupsselectedContainer.AddObjectProperty("GRID_GROUPSSELECTED_nFirstRecordOnPage", GRID_GROUPSSELECTED_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid_groupsselectedContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_groupsselected", Grid_groupsselectedContainer);
                  if ( ! isAjaxCallMode( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_groupsselectedContainerData", Grid_groupsselectedContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid_groupsselectedContainerData"+"V", Grid_groupsselectedContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_groupsselectedContainerData"+"V"+"\" value='"+Grid_groupsselectedContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Send Notifications", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1C0( ) ;
      }

      protected void WS1C2( )
      {
         START1C2( ) ;
         EVT1C2( ) ;
      }

      protected void EVT1C2( )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADD'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Add' */
                              E111C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'SEND'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Send' */
                              E121C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID_GROUPSSELECTEDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID_GROUPSSELECTEDPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_groupsselected_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_groupsselected_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_groupsselected_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_groupsselected_lastpage( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID_DEVICESPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID_DEVICESPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_devices_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_devices_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_devices_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_devices_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "GRID_GROUPS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_19_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
                              SubsflControlProps_192( ) ;
                              A22GroupName = cgiGet( edtGroupName_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E131C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID_GROUPS.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E141C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
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
                           else if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_DEVICES.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 24), "GRID_GROUPSSELECTED.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 34), "VGROUPSELECTED.CONTROLVALUECHANGED") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "GRID_GROUPS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_DEVICES.LOAD") == 0 ) )
                           {
                              nGXsfl_45_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
                              SubsflControlProps_453( ) ;
                              A1DeviceId = cgiGet( edtDeviceId_Internalname);
                              GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
                              GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                              GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
                              GRID_GROUPSSELECTED_nEOF = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                              GXCCtl = "nRC_GXsfl_58_" + sGXsfl_45_idx;
                              nRC_GXsfl_58 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "GRID_DEVICES.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E151C3 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                                 sEvtType = StringUtil.Right( sEvt, 4);
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                 if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 24), "GRID_GROUPSSELECTED.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 34), "VGROUPSELECTED.CONTROLVALUECHANGED") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "GRID_GROUPS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_DEVICES.LOAD") == 0 ) )
                                 {
                                    nGXsfl_58_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                    sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
                                    SubsflControlProps_584( ) ;
                                    AV11DeviceIdSelected = cgiGet( edtavDeviceidselected_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeviceidselected_Internalname, AV11DeviceIdSelected);
                                    if ( ( ( context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
                                    {
                                       GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGROUPIDSELECTED");
                                       GX_FocusControl = edtavGroupidselected_Internalname;
                                       context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                       wbErr = true;
                                       AV16GroupIdSelected = 0;
                                       context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupidselected_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GroupIdSelected), 4, 0)));
                                    }
                                    else
                                    {
                                       AV16GroupIdSelected = (short)(context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", "."));
                                       context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupidselected_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GroupIdSelected), 4, 0)));
                                    }
                                    AV12DeviceTokenSelected = cgiGet( edtavDevicetokenselected_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDevicetokenselected_Internalname, AV12DeviceTokenSelected);
                                    AV18GroupNameSelected = cgiGet( edtavGroupnameselected_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupnameselected_Internalname, AV18GroupNameSelected);
                                    AV19GroupSelected = StringUtil.StrToBool( cgiGet( chkavGroupselected_Internalname));
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavGroupselected_Internalname, AV19GroupSelected);
                                    sEvtType = StringUtil.Right( sEvt, 1);
                                    if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                    {
                                       sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                       if ( StringUtil.StrCmp(sEvt, "GRID_GROUPSSELECTED.LOAD") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                          E161C4 ();
                                       }
                                       else if ( StringUtil.StrCmp(sEvt, "VGROUPSELECTED.CONTROLVALUECHANGED") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                          E171C2 ();
                                       }
                                       else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                       }
                                    }
                                    else
                                    {
                                       sEvtType = StringUtil.Right( sEvt, 4);
                                       sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                       if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "GRID_GROUPS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_DEVICES.LOAD") == 0 ) )
                                       {
                                          nGXsfl_19_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                          sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
                                          SubsflControlProps_192( ) ;
                                          A22GroupName = cgiGet( edtGroupName_Internalname);
                                          GXCCtl = "GRID_DEVICES_nFirstRecordOnPage_" + sGXsfl_19_idx;
                                          GRID_DEVICES_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                                          GXCCtl = "GRID_DEVICES_nEOF_" + sGXsfl_19_idx;
                                          GRID_DEVICES_nEOF = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                                          GXCCtl = "nRC_GXsfl_45_" + sGXsfl_19_idx;
                                          nRC_GXsfl_45 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                                          sEvtType = StringUtil.Right( sEvt, 1);
                                          if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                          {
                                             sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                             if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                             {
                                                context.wbHandled = 1;
                                                dynload_actions( ) ;
                                                /* Execute user event: Refresh */
                                                E131C2 ();
                                             }
                                             else if ( StringUtil.StrCmp(sEvt, "GRID_GROUPS.LOAD") == 0 )
                                             {
                                                context.wbHandled = 1;
                                                dynload_actions( ) ;
                                                E141C2 ();
                                             }
                                             else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                             {
                                                context.wbHandled = 1;
                                                if ( ! wbErr )
                                                {
                                                   Rfr0gs = false;
                                                   if ( ! Rfr0gs )
                                                   {
                                                   }
                                                   dynload_actions( ) ;
                                                }
                                                /* No code required for Cancel button. It is implemented as the Reset button. */
                                             }
                                             else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                             {
                                                context.wbHandled = 1;
                                                dynload_actions( ) ;
                                             }
                                          }
                                          else
                                          {
                                             sEvtType = StringUtil.Right( sEvt, 4);
                                             sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                             if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_DEVICES.LOAD") == 0 )
                                             {
                                                nGXsfl_45_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                                sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
                                                SubsflControlProps_453( ) ;
                                                A1DeviceId = cgiGet( edtDeviceId_Internalname);
                                                sEvtType = StringUtil.Right( sEvt, 1);
                                                if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                                {
                                                   sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                                   if ( StringUtil.StrCmp(sEvt, "GRID_DEVICES.LOAD") == 0 )
                                                   {
                                                      context.wbHandled = 1;
                                                      dynload_actions( ) ;
                                                      E151C3 ();
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
                                    }
                                 }
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

      protected void WE1C2( )
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

      protected void PA1C2( )
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavGroupname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvGROUPNAMEID1C2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvGROUPNAMEID_data1C2( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvGROUPNAMEID_html1C2( )
      {
         String gxdynajaxvalue ;
         GXDLVvGROUPNAMEID_data1C2( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavGroupnameid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavGroupnameid.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvGROUPNAMEID_data1C2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("---Choose  a Group---");
         /* Using cursor H001C2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001C2_A22GroupName[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001C2_A22GroupName[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid_groups_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_192( ) ;
         while ( nGXsfl_19_idx <= nRC_GXsfl_19 )
         {
            sendrow_192( ) ;
            nGXsfl_19_idx = (short)(((subGrid_groups_Islastpage==1)&&(nGXsfl_19_idx+1>subGrid_groups_Recordsperpage( )) ? 1 : nGXsfl_19_idx+1));
            sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
            SubsflControlProps_192( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid_groupsContainer));
         /* End function gxnrGrid_groups_newrow */
      }

      protected void gxnrGrid_devices_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_453( ) ;
         while ( nGXsfl_45_idx <= nRC_GXsfl_45 )
         {
            sendrow_453( ) ;
            nGXsfl_45_idx = (short)(((subGrid_devices_Islastpage==1)&&(nGXsfl_45_idx+1>subGrid_devices_Recordsperpage( )) ? 1 : nGXsfl_45_idx+1));
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_453( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid_devicesContainer));
         /* End function gxnrGrid_devices_newrow */
      }

      protected void gxnrGrid_groupsselected_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_584( ) ;
         while ( nGXsfl_58_idx <= nRC_GXsfl_58 )
         {
            sendrow_584( ) ;
            nGXsfl_58_idx = (short)(((subGrid_groupsselected_Islastpage==1)&&(nGXsfl_58_idx+1>subGrid_groupsselected_Recordsperpage( )) ? 1 : nGXsfl_58_idx+1));
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_584( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid_groupsselectedContainer));
         /* End function gxnrGrid_groupsselected_newrow */
      }

      protected void gxgrGrid_groups_refresh( GeneXus.Core.genexus.common.notifications.SdtConfiguration AV23NotificationConfiguration )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID_GROUPS_nCurrentRecord = 0;
         RF1C2( ) ;
         /* End function gxgrGrid_groups_refresh */
      }

      protected void gxgrGrid_groupsselected_refresh( int subGrid_groupsselected_Rows ,
                                                      GeneXus.Core.genexus.common.notifications.SdtConfiguration AV23NotificationConfiguration ,
                                                      String AV5DeviceId ,
                                                      short A6GroupId ,
                                                      String A22GroupName ,
                                                      String A1DeviceId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GXCCtl = "GRID_GROUPSSELECTED_Rows_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Rows), 6, 0, ".", "")));
         /* Execute user event: Refresh */
         E131C2 ();
         GRID_GROUPSSELECTED_nCurrentRecord = 0;
         RF1C4( ) ;
         /* End function gxgrGrid_groupsselected_refresh */
      }

      protected void gxgrGrid_devices_refresh( int subGrid_devices_Rows ,
                                               GeneXus.Core.genexus.common.notifications.SdtConfiguration AV23NotificationConfiguration )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Rows), 6, 0, ".", "")));
         /* Execute user event: Refresh */
         E131C2 ();
         GRID_DEVICES_nCurrentRecord = 0;
         RF1C3( ) ;
         /* End function gxgrGrid_devices_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_GROUPNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A22GroupName, "")), context));
         GxWebStd.gx_hidden_field( context, "GROUPNAME", StringUtil.RTrim( A22GroupName));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvGROUPNAMEID_html1C2( ) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavGroupnameid.ItemCount > 0 )
         {
            AV15GroupNameId = dynavGroupnameid.getValidValue(AV15GroupNameId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GroupNameId", AV15GroupNameId);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavGroupnameid.CurrentValue = StringUtil.RTrim( AV15GroupNameId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavGroupnameid_Internalname, "Values", dynavGroupnameid.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1C2( ) ;
         RF1C3( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGroupnameselected_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGroupnameselected_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGroupnameselected_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
      }

      protected void RF1C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid_groupsContainer.ClearRows();
         }
         wbStart = 19;
         /* Execute user event: Refresh */
         E131C2 ();
         nGXsfl_19_idx = 1;
         sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
         SubsflControlProps_192( ) ;
         bGXsfl_19_Refreshing = true;
         Grid_groupsContainer.AddObjectProperty("GridName", "Grid_groups");
         Grid_groupsContainer.AddObjectProperty("CmpContext", "");
         Grid_groupsContainer.AddObjectProperty("InMasterPage", "false");
         Grid_groupsContainer.AddObjectProperty("Class", "Grid");
         Grid_groupsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid_groupsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid_groupsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groups_Backcolorstyle), 1, 0, ".", "")));
         Grid_groupsContainer.PageSize = subGrid_groups_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_192( ) ;
            /* Using cursor H001C3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A22GroupName = H001C3_A22GroupName[0];
               E141C2 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 19;
            WB1C0( ) ;
         }
         bGXsfl_19_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1C2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_GROUPNAME"+"_"+sGXsfl_19_idx, GetSecureSignedToken( sGXsfl_19_idx, StringUtil.RTrim( context.localUtil.Format( A22GroupName, "")), context));
      }

      protected void RF1C3( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid_devicesContainer.ClearRows();
         }
         wbStart = 45;
         nGXsfl_45_idx = 1;
         sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
         SubsflControlProps_453( ) ;
         bGXsfl_45_Refreshing = true;
         Grid_devicesContainer.AddObjectProperty("GridName", "Grid_devices");
         Grid_devicesContainer.AddObjectProperty("CmpContext", "");
         Grid_devicesContainer.AddObjectProperty("InMasterPage", "false");
         Grid_devicesContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGridDevicesGroup"));
         Grid_devicesContainer.AddObjectProperty("Class", "FreeStyleGridDevicesGroup");
         Grid_devicesContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid_devicesContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid_devicesContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_devices_Backcolorstyle), 1, 0, ".", "")));
         Grid_devicesContainer.PageSize = subGrid_devices_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_453( ) ;
            GXPagingFrom3 = (int)(((10==0) ? 0 : GRID_DEVICES_nFirstRecordOnPage));
            GXPagingTo3 = ((10==0) ? 10000 : subGrid_devices_Recordsperpage( )+1);
            /* Using cursor H001C4 */
            pr_default.execute(2, new Object[] {GXPagingFrom3, GXPagingTo3});
            nGXsfl_45_idx = 1;
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_453( ) ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID_DEVICES_nCurrentRecord < subGrid_devices_Recordsperpage( ) ) ) ) )
            {
               A20DeviceToken = H001C4_A20DeviceToken[0];
               A1DeviceId = H001C4_A1DeviceId[0];
               E151C3 ();
               pr_default.readNext(2);
            }
            GRID_DEVICES_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nEOF), 1, 0, ".", "")));
            pr_default.close(2);
            wbEnd = 45;
            WB1C0( ) ;
         }
         bGXsfl_45_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1C3( )
      {
      }

      protected void RF1C4( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid_groupsselectedContainer.ClearRows();
         }
         wbStart = 58;
         nGXsfl_58_idx = 1;
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
         SubsflControlProps_584( ) ;
         bGXsfl_58_Refreshing = true;
         Grid_groupsselectedContainer.AddObjectProperty("GridName", "Grid_groupsselected");
         Grid_groupsselectedContainer.AddObjectProperty("CmpContext", "");
         Grid_groupsselectedContainer.AddObjectProperty("InMasterPage", "false");
         Grid_groupsselectedContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGridDevicesGroup"));
         Grid_groupsselectedContainer.AddObjectProperty("Class", "FreeStyleGridDevicesGroup");
         Grid_groupsselectedContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid_groupsselectedContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid_groupsselectedContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Backcolorstyle), 1, 0, ".", "")));
         Grid_groupsselectedContainer.PageSize = subGrid_groupsselected_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_584( ) ;
            E161C4 ();
            wbEnd = 58;
            WB1C0( ) ;
         }
         bGXsfl_58_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1C4( )
      {
      }

      protected int subGrid_groups_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_groups_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_groups_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_groups_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_devices_Pagecount( )
      {
         GRID_DEVICES_nRecordCount = subGrid_devices_Recordcount( );
         if ( ((int)((GRID_DEVICES_nRecordCount) % (subGrid_devices_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_DEVICES_nRecordCount/ (decimal)(subGrid_devices_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_DEVICES_nRecordCount/ (decimal)(subGrid_devices_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_devices_Recordcount( )
      {
         /* Using cursor H001C5 */
         pr_default.execute(3);
         GRID_DEVICES_nRecordCount = H001C5_AGRID_DEVICES_nRecordCount[0];
         pr_default.close(3);
         return (int)(GRID_DEVICES_nRecordCount) ;
      }

      protected int subGrid_devices_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid_devices_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_DEVICES_nFirstRecordOnPage/ (decimal)(subGrid_devices_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_devices_firstpage( )
      {
         GRID_DEVICES_nFirstRecordOnPage = 0;
         GRID_DEVICES_IsPaging = 1;
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_devices_nextpage( )
      {
         GRID_DEVICES_nRecordCount = subGrid_devices_Recordcount( );
         if ( ( GRID_DEVICES_nRecordCount >= subGrid_devices_Recordsperpage( ) ) && ( GRID_DEVICES_nEOF == 0 ) )
         {
            GRID_DEVICES_nFirstRecordOnPage = (long)(GRID_DEVICES_nFirstRecordOnPage+subGrid_devices_Recordsperpage( ));
            GRID_DEVICES_IsPaging = 1;
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid_devicesContainer.AddObjectProperty("GRID_DEVICES_nFirstRecordOnPage", GRID_DEVICES_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_DEVICES_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_devices_previouspage( )
      {
         if ( GRID_DEVICES_nFirstRecordOnPage >= subGrid_devices_Recordsperpage( ) )
         {
            GRID_DEVICES_nFirstRecordOnPage = (long)(GRID_DEVICES_nFirstRecordOnPage-subGrid_devices_Recordsperpage( ));
            GRID_DEVICES_IsPaging = 1;
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_devices_lastpage( )
      {
         GRID_DEVICES_IsPaging = 1;
         GRID_DEVICES_nRecordCount = subGrid_devices_Recordcount( );
         if ( GRID_DEVICES_nRecordCount > subGrid_devices_Recordsperpage( ) )
         {
            if ( ((int)((GRID_DEVICES_nRecordCount) % (subGrid_devices_Recordsperpage( )))) == 0 )
            {
               GRID_DEVICES_nFirstRecordOnPage = (long)(GRID_DEVICES_nRecordCount-subGrid_devices_Recordsperpage( ));
            }
            else
            {
               GRID_DEVICES_nFirstRecordOnPage = (long)(GRID_DEVICES_nRecordCount-((int)((GRID_DEVICES_nRecordCount) % (subGrid_devices_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_DEVICES_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_devices_gotopage( int nPageNo )
      {
         GRID_DEVICES_IsPaging = 1;
         if ( nPageNo > 0 )
         {
            GRID_DEVICES_nFirstRecordOnPage = (long)(subGrid_devices_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_DEVICES_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected int subGrid_groupsselected_Pagecount( )
      {
         GRID_GROUPSSELECTED_nRecordCount = subGrid_groupsselected_Recordcount( );
         if ( ((int)((GRID_GROUPSSELECTED_nRecordCount) % (subGrid_groupsselected_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_GROUPSSELECTED_nRecordCount/ (decimal)(subGrid_groupsselected_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_GROUPSSELECTED_nRecordCount/ (decimal)(subGrid_groupsselected_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_groupsselected_Recordcount( )
      {
         return (int)(GRID_GROUPSSELECTED_nFirstRecordOnPage+1) ;
      }

      protected int subGrid_groupsselected_Recordsperpage( )
      {
         return (int)(1*9999) ;
      }

      protected int subGrid_groupsselected_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_GROUPSSELECTED_nFirstRecordOnPage/ (decimal)(subGrid_groupsselected_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_groupsselected_firstpage( )
      {
         GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
         GRID_GROUPSSELECTED_IsPaging = 1;
         GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_groupsselected_nextpage( )
      {
         if ( GRID_GROUPSSELECTED_nEOF == 0 )
         {
            GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(GRID_GROUPSSELECTED_nFirstRecordOnPage+subGrid_groupsselected_Recordsperpage( ));
            GRID_GROUPSSELECTED_IsPaging = 1;
         }
         GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid_groupsselectedContainer.AddObjectProperty("GRID_GROUPSSELECTED_nFirstRecordOnPage", GRID_GROUPSSELECTED_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_GROUPSSELECTED_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_groupsselected_previouspage( )
      {
         if ( GRID_GROUPSSELECTED_nFirstRecordOnPage >= subGrid_groupsselected_Recordsperpage( ) )
         {
            GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(GRID_GROUPSSELECTED_nFirstRecordOnPage-subGrid_groupsselected_Recordsperpage( ));
            GRID_GROUPSSELECTED_IsPaging = 1;
         }
         else
         {
            return 2 ;
         }
         GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_groupsselected_lastpage( )
      {
         subGrid_groupsselected_Islastpage = 1;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_groupsselected_gotopage( int nPageNo )
      {
         GRID_GROUPSSELECTED_IsPaging = 1;
         if ( nPageNo > 0 )
         {
            GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(subGrid_groupsselected_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
         }
         GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_groupsselected_refresh( subGrid_groupsselected_Rows, AV23NotificationConfiguration, AV5DeviceId, A6GroupId, A22GroupName, A1DeviceId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavGroupnameselected_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGroupnameselected_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGroupnameselected_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         GXVvGROUPNAMEID_html1C2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV17GroupName = cgiGet( edtavGroupname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GroupName", AV17GroupName);
            dynavGroupnameid.Name = dynavGroupnameid_Internalname;
            dynavGroupnameid.CurrentValue = cgiGet( dynavGroupnameid_Internalname);
            AV15GroupNameId = cgiGet( dynavGroupnameid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GroupNameId", AV15GroupNameId);
            AV22MessageTitle = cgiGet( edtavMessagetitle_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MessageTitle", AV22MessageTitle);
            AV21MessageBody = cgiGet( edtavMessagebody_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21MessageBody", AV21MessageBody);
            /* Read saved values. */
            nRC_GXsfl_19 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_19"), ",", "."));
            nRC_GXsfl_45 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_45"), ",", "."));
            GRID_DEVICES_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_DEVICES_nFirstRecordOnPage"), ",", "."));
            GRID_DEVICES_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_DEVICES_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E131C2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV23NotificationConfiguration.gxTpr_Applicationid = "PushTestMain";
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23NotificationConfiguration", AV23NotificationConfiguration);
      }

      protected void E171C2( )
      {
         /* Groupselected_Controlvaluechanged Routine */
         new addremovedevicefromgroup(context ).execute(  AV19GroupSelected,  AV11DeviceIdSelected,  AV16GroupIdSelected,  AV18GroupNameSelected, out  AV7OutMessages) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavGroupselected_Internalname, AV19GroupSelected);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeviceidselected_Internalname, AV11DeviceIdSelected);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupidselected_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GroupIdSelected), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupnameselected_Internalname, AV18GroupNameSelected);
         if ( AV7OutMessages.Count == 0 )
         {
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         else
         {
            GX_msglist.addItem(AV7OutMessages.ToJSonString(false));
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23NotificationConfiguration", AV23NotificationConfiguration);
      }

      protected void E111C2( )
      {
         /* 'Add' Routine */
         /* Start For Each Line in Grid_groupsselected */
         GXCCtl = "nRC_GXsfl_58_" + sGXsfl_45_idx;
         nRC_GXsfl_58 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         nGXsfl_58_fel_idx = 0;
         while ( nGXsfl_58_fel_idx < nRC_GXsfl_58 )
         {
            nGXsfl_58_fel_idx = (short)(((subGrid_groupsselected_Islastpage==1)&&(nGXsfl_58_fel_idx+1>subGrid_groupsselected_Recordsperpage( )) ? 1 : nGXsfl_58_fel_idx+1));
            sGXsfl_58_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_fel_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_fel_584( ) ;
            AV11DeviceIdSelected = cgiGet( edtavDeviceidselected_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGROUPIDSELECTED");
               GX_FocusControl = edtavGroupidselected_Internalname;
               wbErr = true;
               AV16GroupIdSelected = 0;
            }
            else
            {
               AV16GroupIdSelected = (short)(context.localUtil.CToN( cgiGet( edtavGroupidselected_Internalname), ",", "."));
            }
            AV12DeviceTokenSelected = cgiGet( edtavDevicetokenselected_Internalname);
            AV18GroupNameSelected = cgiGet( edtavGroupnameselected_Internalname);
            AV19GroupSelected = StringUtil.StrToBool( cgiGet( chkavGroupselected_Internalname));
            /* End For Each Line */
         }
         if ( nGXsfl_58_fel_idx == 0 )
         {
            nGXsfl_58_idx = 1;
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_584( ) ;
         }
         nGXsfl_58_fel_idx = 1;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17GroupName)) )
         {
            AV14Group.gxTpr_Groupname = AV17GroupName;
            AV14Group.Insert();
            if ( AV14Group.Success() )
            {
               context.CommitDataStores("sendnotifications",pr_default);
               AV17GroupName = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GroupName", AV17GroupName);
            }
            gxgrGrid_groups_refresh( AV23NotificationConfiguration) ;
            gxgrGrid_devices_refresh( subGrid_devices_Rows, AV23NotificationConfiguration) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14Group", AV14Group);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23NotificationConfiguration", AV23NotificationConfiguration);
      }

      protected void E121C2( )
      {
         /* 'Send' Routine */
         AV25NotificationMessage.gxTpr_Title.gxTpr_Defaulttext = AV22MessageTitle;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21MessageBody)) )
         {
            AV25NotificationMessage.gxTpr_Text.gxTpr_Defaulttext = AV21MessageBody+" para el grupo "+AV15GroupNameId;
         }
         AV25NotificationMessage.gxTpr_Actions.gxTpr_Defaultaction.gxTpr_Event.gxTpr_Name = "Noti";
         AV25NotificationMessage.gxTpr_Actions.gxTpr_Defaultaction.gxTpr_Event.gxTpr_Parameters.FromJSonString("[{\"Name\":\"message\",\"Value\":\"ejecutando evento desde la noticación\"}]", null);
         AV24NotificationDelivery.gxTpr_Expiration = 3000;
         AV24NotificationDelivery.gxTpr_Priority = "High";
         AV28TargetGroups.Clear();
         AV27TargetGroup.gxTpr_Name = AV15GroupNameId;
         AV28TargetGroups.Add(AV27TargetGroup, 0);
         AV8Target.gxTpr_Targettype = 3;
         AV8Target.gxTpr_Groups = AV28TargetGroups;
         new GeneXus.Core.genexus.common.notifications.sendnotificationtargets(context ).execute(  AV23NotificationConfiguration,  AV8Target,  AV25NotificationMessage,  AV24NotificationDelivery, out  AV7OutMessages, out  AV6IsSuccessful) ;
         if ( ! AV26Success )
         {
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25NotificationMessage", AV25NotificationMessage);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotificationDelivery", AV24NotificationDelivery);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27TargetGroup", AV27TargetGroup);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8Target", AV8Target);
      }

      private void E141C2( )
      {
         /* Grid_groups_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 19;
         }
         sendrow_192( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_19_Refreshing )
         {
            context.DoAjaxLoad(19, Grid_groupsRow);
         }
      }

      private void E151C3( )
      {
         /* Grid_devices_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 58;
         }
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
            GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         }
         else
         {
            GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
         }
         if ( ( subGrid_groupsselected_Islastpage == 1 ) || ( 1 == 0 ) || ( ( GRID_GROUPSSELECTED_nCurrentRecord >= GRID_GROUPSSELECTED_nFirstRecordOnPage ) && ( GRID_GROUPSSELECTED_nCurrentRecord < GRID_GROUPSSELECTED_nFirstRecordOnPage + subGrid_groupsselected_Recordsperpage( ) ) ) )
         {
            sendrow_584( ) ;
            GRID_GROUPSSELECTED_nEOF = 1;
            GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
            GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nEOF), 1, 0, ".", "")));
            if ( ( subGrid_groupsselected_Islastpage == 1 ) && ( ((int)((GRID_GROUPSSELECTED_nCurrentRecord) % (subGrid_groupsselected_Recordsperpage( )))) == 0 ) )
            {
               GRID_GROUPSSELECTED_nFirstRecordOnPage = GRID_GROUPSSELECTED_nCurrentRecord;
            }
         }
         if ( GRID_GROUPSSELECTED_nCurrentRecord >= GRID_GROUPSSELECTED_nFirstRecordOnPage + subGrid_groupsselected_Recordsperpage( ) )
         {
            GRID_GROUPSSELECTED_nEOF = 0;
            GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
            GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nEOF), 1, 0, ".", "")));
         }
         GRID_GROUPSSELECTED_nCurrentRecord = (long)(GRID_GROUPSSELECTED_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_58_Refreshing )
         {
            context.DoAjaxLoad(58, Grid_groupsselectedRow);
         }
         AV5DeviceId = A1DeviceId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DeviceId", AV5DeviceId);
         AV12DeviceTokenSelected = A20DeviceToken;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDevicetokenselected_Internalname, AV12DeviceTokenSelected);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 45;
         }
         sendrow_453( ) ;
         GRID_DEVICES_nCurrentRecord = (long)(GRID_DEVICES_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_45_Refreshing )
         {
            context.DoAjaxLoad(45, Grid_devicesRow);
         }
         /*  Sending Event outputs  */
      }

      private void E161C4( )
      {
         /* Grid_groupsselected_Load Routine */
         edtavGroupidselected_Visible = 0;
         edtavDeviceidselected_Visible = 0;
         edtavDevicetokenselected_Visible = 0;
         /* Using cursor H001C6 */
         pr_default.execute(4);
         while ( (pr_default.getStatus(4) != 101) )
         {
            A6GroupId = H001C6_A6GroupId[0];
            A22GroupName = H001C6_A22GroupName[0];
            AV11DeviceIdSelected = AV5DeviceId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeviceidselected_Internalname, AV11DeviceIdSelected);
            AV16GroupIdSelected = A6GroupId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupidselected_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GroupIdSelected), 4, 0)));
            AV18GroupNameSelected = A22GroupName;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGroupnameselected_Internalname, AV18GroupNameSelected);
            AV33GXLvl25 = 0;
            /* Using cursor H001C7 */
            pr_default.execute(5, new Object[] {AV5DeviceId, A6GroupId});
            nGXsfl_45_idx = 1;
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_453( ) ;
            GRID_DEVICES_nEOF = 0;
            GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nEOF), 1, 0, ".", "")));
            while ( ( (pr_default.getStatus(5) != 101) ) && ( ( ( 10 == 0 ) || ( GRID_DEVICES_nCurrentRecord < GRID_DEVICES_nFirstRecordOnPage + subGrid_devices_Recordsperpage( ) ) ) ) )
            {
               A1DeviceId = H001C7_A1DeviceId[0];
               AV33GXLvl25 = 1;
               AV19GroupSelected = true;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavGroupselected_Internalname, AV19GroupSelected);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            GRID_DEVICES_nEOF = (short)(((pr_default.getStatus(5) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_DEVICES_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_DEVICES_nEOF), 1, 0, ".", "")));
            pr_default.close(5);
            if ( AV33GXLvl25 == 0 )
            {
               AV19GroupSelected = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavGroupselected_Internalname, AV19GroupSelected);
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 58;
            }
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
               GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
            }
            else
            {
               GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
            }
            if ( ( subGrid_groupsselected_Islastpage == 1 ) || ( 1 == 0 ) || ( ( GRID_GROUPSSELECTED_nCurrentRecord >= GRID_GROUPSSELECTED_nFirstRecordOnPage ) && ( GRID_GROUPSSELECTED_nCurrentRecord < GRID_GROUPSSELECTED_nFirstRecordOnPage + subGrid_groupsselected_Recordsperpage( ) ) ) )
            {
               sendrow_584( ) ;
               GRID_GROUPSSELECTED_nEOF = 1;
               GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
               GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nEOF), 1, 0, ".", "")));
               if ( ( subGrid_groupsselected_Islastpage == 1 ) && ( ((int)((GRID_GROUPSSELECTED_nCurrentRecord) % (subGrid_groupsselected_Recordsperpage( )))) == 0 ) )
               {
                  GRID_GROUPSSELECTED_nFirstRecordOnPage = GRID_GROUPSSELECTED_nCurrentRecord;
               }
            }
            if ( GRID_GROUPSSELECTED_nCurrentRecord >= GRID_GROUPSSELECTED_nFirstRecordOnPage + subGrid_groupsselected_Recordsperpage( ) )
            {
               GRID_GROUPSSELECTED_nEOF = 0;
               GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
               GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nEOF), 1, 0, ".", "")));
            }
            GRID_GROUPSSELECTED_nCurrentRecord = (long)(GRID_GROUPSSELECTED_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_58_Refreshing )
            {
               context.DoAjaxLoad(58, Grid_groupsselectedRow);
            }
            pr_default.readNext(4);
         }
         pr_default.close(4);
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA1C2( ) ;
         WS1C2( ) ;
         WE1C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201810111853728", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("sendnotifications.js", "?201810111853729", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_192( )
      {
         edtGroupName_Internalname = "GROUPNAME_"+sGXsfl_19_idx;
      }

      protected void SubsflControlProps_fel_192( )
      {
         edtGroupName_Internalname = "GROUPNAME_"+sGXsfl_19_fel_idx;
      }

      protected void sendrow_192( )
      {
         SubsflControlProps_192( ) ;
         WB1C0( ) ;
         Grid_groupsRow = GXWebRow.GetNew(context,Grid_groupsContainer);
         if ( subGrid_groups_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid_groups_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid_groups_Class, "") != 0 )
            {
               subGrid_groups_Linesclass = subGrid_groups_Class+"Odd";
            }
         }
         else if ( subGrid_groups_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid_groups_Backstyle = 0;
            subGrid_groups_Backcolor = subGrid_groups_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid_groups_Class, "") != 0 )
            {
               subGrid_groups_Linesclass = subGrid_groups_Class+"Uniform";
            }
         }
         else if ( subGrid_groups_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid_groups_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid_groups_Class, "") != 0 )
            {
               subGrid_groups_Linesclass = subGrid_groups_Class+"Odd";
            }
            subGrid_groups_Backcolor = (int)(0x0);
         }
         else if ( subGrid_groups_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid_groups_Backstyle = 1;
            if ( ((int)(((nGXsfl_19_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid_groups_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid_groups_Class, "") != 0 )
               {
                  subGrid_groups_Linesclass = subGrid_groups_Class+"Odd";
               }
            }
            else
            {
               subGrid_groups_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid_groups_Class, "") != 0 )
               {
                  subGrid_groups_Linesclass = subGrid_groups_Class+"Even";
               }
            }
         }
         if ( Grid_groupsContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+"Grid"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_19_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid_groupsContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "AttributeAcceptDrag";
         Grid_groupsRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGroupName_Internalname,StringUtil.RTrim( A22GroupName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtGroupName_Jsonclick,(short)0,(String)"AttributeAcceptDrag",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         send_integrity_lvl_hashes1C2( ) ;
         Grid_groupsContainer.AddRow(Grid_groupsRow);
         nGXsfl_19_idx = (short)(((subGrid_groups_Islastpage==1)&&(nGXsfl_19_idx+1>subGrid_groups_Recordsperpage( )) ? 1 : nGXsfl_19_idx+1));
         sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
         SubsflControlProps_192( ) ;
         /* End function sendrow_192 */
      }

      protected void SubsflControlProps_584( )
      {
         edtavDeviceidselected_Internalname = "vDEVICEIDSELECTED_"+sGXsfl_58_idx;
         edtavGroupidselected_Internalname = "vGROUPIDSELECTED_"+sGXsfl_58_idx;
         edtavDevicetokenselected_Internalname = "vDEVICETOKENSELECTED_"+sGXsfl_58_idx;
         edtavGroupnameselected_Internalname = "vGROUPNAMESELECTED_"+sGXsfl_58_idx;
         chkavGroupselected_Internalname = "vGROUPSELECTED_"+sGXsfl_58_idx;
         subGrid_groups_Internalname = "GRID_GROUPS";
      }

      protected void SubsflControlProps_fel_584( )
      {
         edtavDeviceidselected_Internalname = "vDEVICEIDSELECTED_"+sGXsfl_58_fel_idx;
         edtavGroupidselected_Internalname = "vGROUPIDSELECTED_"+sGXsfl_58_fel_idx;
         edtavDevicetokenselected_Internalname = "vDEVICETOKENSELECTED_"+sGXsfl_58_fel_idx;
         edtavGroupnameselected_Internalname = "vGROUPNAMESELECTED_"+sGXsfl_58_fel_idx;
         chkavGroupselected_Internalname = "vGROUPSELECTED_"+sGXsfl_58_fel_idx;
         subGrid_groups_Internalname = "GRID_GROUPS";
      }

      protected void sendrow_584( )
      {
         SubsflControlProps_584( ) ;
         WB1C0( ) ;
         if ( ( 1 * 9999 == 0 ) || ( nGXsfl_58_idx <= subGrid_groupsselected_Recordsperpage( ) * 9999 ) )
         {
            Grid_groupsselectedRow = GXWebRow.GetNew(context,Grid_groupsselectedContainer);
            if ( subGrid_groupsselected_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_groupsselected_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_groupsselected_Class, "") != 0 )
               {
                  subGrid_groupsselected_Linesclass = subGrid_groupsselected_Class+"Odd";
               }
            }
            else if ( subGrid_groupsselected_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_groupsselected_Backstyle = 0;
               subGrid_groupsselected_Backcolor = subGrid_groupsselected_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_groupsselected_Class, "") != 0 )
               {
                  subGrid_groupsselected_Linesclass = subGrid_groupsselected_Class+"Uniform";
               }
            }
            else if ( subGrid_groupsselected_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_groupsselected_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_groupsselected_Class, "") != 0 )
               {
                  subGrid_groupsselected_Linesclass = subGrid_groupsselected_Class+"Odd";
               }
               subGrid_groupsselected_Backcolor = (int)(0xFFFFFF);
            }
            else if ( subGrid_groupsselected_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_groupsselected_Backstyle = 1;
               if ( ((int)(((nGXsfl_58_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_groupsselected_Backcolor = (int)(0xFFFFFF);
                  if ( StringUtil.StrCmp(subGrid_groupsselected_Class, "") != 0 )
                  {
                     subGrid_groupsselected_Linesclass = subGrid_groupsselected_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_groupsselected_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_groupsselected_Class, "") != 0 )
                  {
                     subGrid_groupsselected_Linesclass = subGrid_groupsselected_Class+"Even";
                  }
               }
            }
            /* Start of Columns property logic. */
            if ( Grid_groupsselectedContainer.GetWrapped() == 1 )
            {
               if ( ( 1 == 0 ) && ( nGXsfl_58_idx == 1 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subGrid_groupsselected_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_58_idx+"\">") ;
               }
               if ( 1 > 0 )
               {
                  if ( ( 1 == 1 ) || ( ((int)((nGXsfl_58_idx) % (1))) - 1 == 0 ) )
                  {
                     context.WriteHtmlText( "<tr"+" class=\""+subGrid_groupsselected_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_58_idx+"\">") ;
                  }
               }
            }
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divGrid3table_Internalname+"_"+sGXsfl_58_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row TableRow_GroupSelected",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 hidden-sm hidden-md hidden-lg",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTable8_Internalname+"_"+sGXsfl_58_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-4",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_groupsselectedRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavDeviceidselected_Internalname,(String)"Device Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
            /* Single line edit */
            TempTags = " " + ((edtavDeviceidselected_Enabled!=0)&&(edtavDeviceidselected_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 66,'',false,'"+sGXsfl_58_idx+"',58)\"" : " ");
            ROClassString = "Attribute";
            Grid_groupsselectedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeviceidselected_Internalname,(String)AV11DeviceIdSelected,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDeviceidselected_Enabled!=0)&&(edtavDeviceidselected_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,66);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDeviceidselected_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavDeviceidselected_Visible,(short)1,(short)0,(String)"text",(String)"",(short)80,(String)"chr",(short)1,(String)"row",(short)128,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-4",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_groupsselectedRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavGroupidselected_Internalname,(String)"Group Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
            /* Single line edit */
            TempTags = " " + ((edtavGroupidselected_Enabled!=0)&&(edtavGroupidselected_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 69,'',false,'"+sGXsfl_58_idx+"',58)\"" : " ");
            ROClassString = "Attribute";
            Grid_groupsselectedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGroupidselected_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16GroupIdSelected), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(AV16GroupIdSelected), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+((edtavGroupidselected_Enabled!=0)&&(edtavGroupidselected_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,69);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGroupidselected_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavGroupidselected_Visible,(short)1,(short)0,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-4",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_groupsselectedRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavDevicetokenselected_Internalname,(String)"Device Token Selected",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
            /* Multiple line edit */
            TempTags = " " + ((edtavDevicetokenselected_Enabled!=0)&&(edtavDevicetokenselected_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 72,'',false,'"+sGXsfl_58_idx+"',58)\"" : " ");
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            Grid_groupsselectedRow.AddColumnProperties("html_textarea", 1, isAjaxCallMode( ), new Object[] {(String)edtavDevicetokenselected_Internalname,(String)AV12DeviceTokenSelected,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDevicetokenselected_Enabled!=0)&&(edtavDevicetokenselected_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,72);\"" : " "),(short)0,(int)edtavDevicetokenselected_Visible,(short)1,(short)0,(short)80,(String)"chr",(short)10,(String)"row",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"1000",(short)-1,(short)0,(String)"",(String)"",(short)-1,(bool)true,(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(short)0});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_groupsselectedRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavGroupnameselected_Internalname,(String)"Group Name Selected",(String)"col-sm-3 AttributeGroupSelectedLabel",(short)0,(bool)true});
            /* Single line edit */
            TempTags = " " + ((edtavGroupnameselected_Enabled!=0)&&(edtavGroupnameselected_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 76,'',false,'"+sGXsfl_58_idx+"',58)\"" : " ");
            ROClassString = "AttributeGroupSelected";
            Grid_groupsselectedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGroupnameselected_Internalname,(String)AV18GroupNameSelected,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavGroupnameselected_Enabled!=0)&&(edtavGroupnameselected_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,76);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGroupnameselected_Jsonclick,(short)0,(String)"AttributeGroupSelected",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtavGroupnameselected_Enabled,(short)0,(String)"text",(String)"",(short)40,(String)"chr",(short)1,(String)"row",(short)40,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_groupsselectedRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_groupsselectedRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)chkavGroupselected_Internalname,(String)"Group Selected",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
            /* Check box */
            TempTags = " " + ((chkavGroupselected.Enabled!=0)&&(chkavGroupselected.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 80,'',false,'"+sGXsfl_58_idx+"',58)\"" : " ");
            ClassString = "Attribute";
            StyleString = "";
            Grid_groupsselectedRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavGroupselected_Internalname,StringUtil.BoolToStr( AV19GroupSelected),(String)"",(String)"Group Selected",(short)1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(80, this, 'true', 'false');gx.evt.onchange(this, event);\" "});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_groupsselectedRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            send_integrity_lvl_hashes1C4( ) ;
            /* End of Columns property logic. */
            Grid_groupsselectedContainer.AddRow(Grid_groupsselectedRow);
            nGXsfl_58_idx = (short)(((subGrid_groupsselected_Islastpage==1)&&(nGXsfl_58_idx+1>subGrid_groupsselected_Recordsperpage( )) ? 1 : nGXsfl_58_idx+1));
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_584( ) ;
         }
         /* End function sendrow_584 */
      }

      protected void SubsflControlProps_453( )
      {
         edtDeviceId_Internalname = "DEVICEID_"+sGXsfl_45_idx;
         subGrid_groupsselected_Internalname = "GRID_GROUPSSELECTED_"+sGXsfl_45_idx;
      }

      protected void SubsflControlProps_fel_453( )
      {
         edtDeviceId_Internalname = "DEVICEID_"+sGXsfl_45_fel_idx;
         subGrid_groupsselected_Internalname = "GRID_GROUPSSELECTED_"+sGXsfl_45_fel_idx;
      }

      protected void sendrow_453( )
      {
         SubsflControlProps_453( ) ;
         WB1C0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_45_idx <= subGrid_devices_Recordsperpage( ) * 1 ) )
         {
            Grid_devicesRow = GXWebRow.GetNew(context,Grid_devicesContainer);
            if ( subGrid_devices_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_devices_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_devices_Class, "") != 0 )
               {
                  subGrid_devices_Linesclass = subGrid_devices_Class+"Odd";
               }
            }
            else if ( subGrid_devices_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_devices_Backstyle = 0;
               subGrid_devices_Backcolor = subGrid_devices_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_devices_Class, "") != 0 )
               {
                  subGrid_devices_Linesclass = subGrid_devices_Class+"Uniform";
               }
            }
            else if ( subGrid_devices_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_devices_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_devices_Class, "") != 0 )
               {
                  subGrid_devices_Linesclass = subGrid_devices_Class+"Odd";
               }
               subGrid_devices_Backcolor = (int)(0xFFFFFF);
            }
            else if ( subGrid_devices_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_devices_Backstyle = 1;
               if ( ((int)(((nGXsfl_45_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_devices_Backcolor = (int)(0xFFFFFF);
                  if ( StringUtil.StrCmp(subGrid_devices_Class, "") != 0 )
                  {
                     subGrid_devices_Linesclass = subGrid_devices_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_devices_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_devices_Class, "") != 0 )
                  {
                     subGrid_devices_Linesclass = subGrid_devices_Class+"Even";
                  }
               }
            }
            /* Start of Columns property logic. */
            if ( Grid_devicesContainer.GetWrapped() == 1 )
            {
               if ( ( 1 == 0 ) && ( nGXsfl_45_idx == 1 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subGrid_devices_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_45_idx+"\">") ;
               }
               if ( 1 > 0 )
               {
                  if ( ( 1 == 1 ) || ( ((int)((nGXsfl_45_idx) % (1))) - 1 == 0 ) )
                  {
                     context.WriteHtmlText( "<tr"+" class=\""+subGrid_devices_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_45_idx+"\">") ;
                  }
               }
            }
            if ( GRID_DEVICES_IsPaging == 0 )
            {
               GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
               GRID_GROUPSSELECTED_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
            }
            else
            {
               GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
            }
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divGrid1table_Internalname+"_"+sGXsfl_45_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTable7_Internalname+"_"+sGXsfl_45_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-3",(String)"left",(String)"Middle",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Attribute/Variable Label */
            Grid_devicesRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtDeviceId_Internalname,(String)"Device Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
            /* Single line edit */
            ROClassString = "Attribute";
            Grid_devicesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDeviceId_Internalname,(String)A1DeviceId,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDeviceId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"text",(String)"",(short)80,(String)"chr",(short)1,(String)"row",(short)128,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"Middle",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-9",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTable2_Internalname+"_"+sGXsfl_45_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /* Div Control */
            Grid_devicesRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 TableCell_DeviceGroup",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
            /*  Child Grid Control  */
            Grid_devicesRow.AddColumnProperties("subfile", -1, isAjaxCallMode( ), new Object[] {(String)"Grid_groupsselectedContainer"});
            if ( isAjaxCallMode( ) )
            {
               Grid_groupsselectedContainer = new GXWebGrid( context);
            }
            else
            {
               Grid_groupsselectedContainer.Clear();
            }
            Grid_groupsselectedContainer.SetIsFreestyle(true);
            Grid_groupsselectedContainer.SetWrapped(nGXWrapped);
            if ( Grid_groupsselectedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid_groupsselectedContainer"+"DivS\" data-gxgridid=\"58\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_groupsselected_Internalname, subGrid_groupsselected_Internalname, "", "FreeStyleGridDevicesGroup", 0, "", "", 1, 2, sStyleString, "", "", 0);
               Grid_groupsselectedContainer.AddObjectProperty("GridName", "Grid_groupsselected");
            }
            else
            {
               Grid_groupsselectedContainer.AddObjectProperty("GridName", "Grid_groupsselected");
               Grid_groupsselectedContainer.AddObjectProperty("Header", subGrid_groupsselected_Header);
               Grid_groupsselectedContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGridDevicesGroup"));
               Grid_groupsselectedContainer.AddObjectProperty("Class", "FreeStyleGridDevicesGroup");
               Grid_groupsselectedContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Backcolorstyle), 1, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("CmpContext", "");
               Grid_groupsselectedContainer.AddObjectProperty("InMasterPage", "false");
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedColumn.AddObjectProperty("Value", AV11DeviceIdSelected);
               Grid_groupsselectedColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDeviceidselected_Visible), 5, 0, ".", "")));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16GroupIdSelected), 4, 0, ".", "")));
               Grid_groupsselectedColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGroupidselected_Visible), 5, 0, ".", "")));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedColumn.AddObjectProperty("Value", AV12DeviceTokenSelected);
               Grid_groupsselectedColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDevicetokenselected_Visible), 5, 0, ".", "")));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedColumn.AddObjectProperty("Value", AV18GroupNameSelected);
               Grid_groupsselectedColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGroupnameselected_Enabled), 5, 0, ".", "")));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid_groupsselectedColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV19GroupSelected));
               Grid_groupsselectedContainer.AddColumnProperties(Grid_groupsselectedColumn);
               Grid_groupsselectedContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Selectedindex), 4, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Allowselection), 1, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Selectioncolor), 9, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Allowhovering), 1, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Hoveringcolor), 9, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Allowcollapsing), 1, 0, ".", "")));
               Grid_groupsselectedContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_groupsselected_Collapsed), 1, 0, ".", "")));
            }
            RF1C4( ) ;
            nRC_GXsfl_58 = (short)(nGXsfl_58_idx-1);
            send_integrity_footer_hashes( ) ;
            GXCCtl = "nRC_GXsfl_58_" + sGXsfl_45_idx;
            GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_58), 4, 0, ",", "")));
            if ( Grid_groupsselectedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid_groupsselectedContainer.AddObjectProperty("GRID_GROUPSSELECTED_nEOF", GRID_GROUPSSELECTED_nEOF);
               Grid_groupsselectedContainer.AddObjectProperty("GRID_GROUPSSELECTED_nFirstRecordOnPage", GRID_GROUPSSELECTED_nFirstRecordOnPage);
               if ( ! isAjaxCallMode( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_groupsselectedContainerData"+"_"+sGXsfl_45_idx, Grid_groupsselectedContainer.ToJavascriptSource());
               }
               if ( isAjaxCallMode( ) )
               {
                  Grid_devicesRow.AddGrid("Grid_groupsselected", Grid_groupsselectedContainer);
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_groupsselectedContainerData"+"V_"+sGXsfl_45_idx, Grid_groupsselectedContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_groupsselectedContainerData"+"V_"+sGXsfl_45_idx+"\" value='"+Grid_groupsselectedContainer.GridValuesHidden()+"'/>") ;
               }
            }
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            Grid_devicesRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
            send_integrity_lvl_hashes1C3( ) ;
            GXCCtl = "GRID_GROUPSSELECTED_nFirstRecordOnPage_" + sGXsfl_45_idx;
            GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nFirstRecordOnPage), 15, 0, ",", "")));
            GXCCtl = "GRID_GROUPSSELECTED_nEOF_" + sGXsfl_45_idx;
            GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_GROUPSSELECTED_nEOF), 1, 0, ",", "")));
            GRID_GROUPSSELECTED_nFirstRecordOnPage = 0;
            GRID_GROUPSSELECTED_nCurrentRecord = 0;
            /* End of Columns property logic. */
            Grid_devicesContainer.AddRow(Grid_devicesRow);
            nGXsfl_45_idx = (short)(((subGrid_devices_Islastpage==1)&&(nGXsfl_45_idx+1>subGrid_devices_Recordsperpage( )) ? 1 : nGXsfl_45_idx+1));
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_453( ) ;
         }
         /* End function sendrow_453 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vGROUPSELECTED_" + sGXsfl_58_idx;
         chkavGroupselected.Name = GXCCtl;
         chkavGroupselected.WebTags = "";
         chkavGroupselected.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGroupselected_Internalname, "TitleCaption", chkavGroupselected.Caption, !bGXsfl_58_Refreshing);
         chkavGroupselected.CheckedValue = "false";
         dynavGroupnameid.Name = "vGROUPNAMEID";
         dynavGroupnameid.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtGroupName_Internalname = "GROUPNAME";
         edtavGroupname_Internalname = "vGROUPNAME";
         bttAdd_Internalname = "ADD";
         divTable1_Internalname = "TABLE1";
         divGroup1table_Internalname = "GROUP1TABLE";
         grpGroup1_Internalname = "GROUP1";
         divGroup3table_Internalname = "GROUP3TABLE";
         grpGroup3_Internalname = "GROUP3";
         divTable10_Internalname = "TABLE10";
         edtDeviceId_Internalname = "DEVICEID";
         edtavDeviceidselected_Internalname = "vDEVICEIDSELECTED";
         edtavGroupidselected_Internalname = "vGROUPIDSELECTED";
         edtavDevicetokenselected_Internalname = "vDEVICETOKENSELECTED";
         divTable8_Internalname = "TABLE8";
         edtavGroupnameselected_Internalname = "vGROUPNAMESELECTED";
         chkavGroupselected_Internalname = "vGROUPSELECTED";
         divGrid3table_Internalname = "GRID3TABLE";
         divTable2_Internalname = "TABLE2";
         divTable7_Internalname = "TABLE7";
         divGrid1table_Internalname = "GRID1TABLE";
         divGroup2table_Internalname = "GROUP2TABLE";
         grpDevices_Internalname = "DEVICES";
         divTable3_Internalname = "TABLE3";
         divTable11_Internalname = "TABLE11";
         divTable9_Internalname = "TABLE9";
         dynavGroupnameid_Internalname = "vGROUPNAMEID";
         edtavMessagetitle_Internalname = "vMESSAGETITLE";
         edtavMessagebody_Internalname = "vMESSAGEBODY";
         divTable5_Internalname = "TABLE5";
         bttSend_Internalname = "SEND";
         divTable6_Internalname = "TABLE6";
         divTable4_Internalname = "TABLE4";
         divGroup2table1_Internalname = "GROUP2TABLE1";
         grpGroup2_Internalname = "GROUP2";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid_groups_Internalname = "GRID_GROUPS";
         subGrid_groupsselected_Internalname = "GRID_GROUPSSELECTED";
         subGrid_devices_Internalname = "GRID_DEVICES";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkavGroupselected.Caption = "Group Selected";
         subGrid_groupsselected_Allowcollapsing = 0;
         edtDeviceId_Jsonclick = "";
         subGrid_devices_Class = "FreeStyleGridDevicesGroup";
         chkavGroupselected.Visible = 1;
         chkavGroupselected.Enabled = 1;
         edtavGroupnameselected_Jsonclick = "";
         edtavGroupnameselected_Visible = 1;
         edtavGroupnameselected_Enabled = 1;
         edtavDevicetokenselected_Visible = 1;
         edtavDevicetokenselected_Enabled = 1;
         edtavGroupidselected_Jsonclick = "";
         edtavGroupidselected_Enabled = 1;
         edtavGroupidselected_Visible = 1;
         edtavDeviceidselected_Jsonclick = "";
         edtavDeviceidselected_Enabled = 1;
         edtavDeviceidselected_Visible = 1;
         subGrid_groupsselected_Class = "FreeStyleGridDevicesGroup";
         edtGroupName_Jsonclick = "";
         subGrid_groupsselected_Backcolorstyle = 0;
         edtavMessagebody_Enabled = 1;
         edtavMessagetitle_Jsonclick = "";
         edtavMessagetitle_Enabled = 1;
         dynavGroupnameid_Jsonclick = "";
         dynavGroupnameid.Enabled = 1;
         subGrid_devices_Allowcollapsing = 0;
         subGrid_devices_Backcolorstyle = 0;
         edtavGroupname_Jsonclick = "";
         edtavGroupname_Enabled = 1;
         subGrid_groups_Allowcollapsing = 0;
         subGrid_groups_Allowselection = 0;
         subGrid_groups_Header = "";
         subGrid_groups_Class = "Grid";
         subGrid_groups_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Send Notifications";
         subGrid_devices_Rows = 10;
         subGrid_groupsselected_Rows = 1;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_GROUPS_nFirstRecordOnPage'},{av:'GRID_GROUPS_nEOF'},{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_DEVICES.LOAD","{handler:'E151C3',iparms:[{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'A20DeviceToken',fld:'DEVICETOKEN',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_DEVICES.LOAD",",oparms:[{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'AV12DeviceTokenSelected',fld:'vDEVICETOKENSELECTED',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_GROUPSSELECTED.LOAD","{handler:'E161C4',iparms:[{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_GROUPSSELECTED.LOAD",",oparms:[{av:'edtavGroupidselected_Visible',ctrl:'vGROUPIDSELECTED',prop:'Visible'},{av:'edtavDeviceidselected_Visible',ctrl:'vDEVICEIDSELECTED',prop:'Visible'},{av:'edtavDevicetokenselected_Visible',ctrl:'vDEVICETOKENSELECTED',prop:'Visible'},{av:'AV11DeviceIdSelected',fld:'vDEVICEIDSELECTED',pic:''},{av:'AV16GroupIdSelected',fld:'vGROUPIDSELECTED',pic:'ZZZ9'},{av:'AV18GroupNameSelected',fld:'vGROUPNAMESELECTED',pic:''},{av:'AV19GroupSelected',fld:'vGROUPSELECTED',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("VGROUPSELECTED.CONTROLVALUECHANGED","{handler:'E171C2',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'AV19GroupSelected',fld:'vGROUPSELECTED',pic:''},{av:'AV11DeviceIdSelected',fld:'vDEVICEIDSELECTED',pic:''},{av:'AV16GroupIdSelected',fld:'vGROUPIDSELECTED',pic:'ZZZ9'},{av:'AV18GroupNameSelected',fld:'vGROUPNAMESELECTED',pic:''},{av:'GRID_GROUPS_nFirstRecordOnPage'},{av:'GRID_GROUPS_nEOF'},{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("VGROUPSELECTED.CONTROLVALUECHANGED",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("'ADD'","{handler:'E111C2',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'GRID_GROUPS_nFirstRecordOnPage'},{av:'GRID_GROUPS_nEOF'},{av:'AV17GroupName',fld:'vGROUPNAME',pic:''},{av:'AV14Group',fld:'vGROUP',pic:''},{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("'ADD'",",oparms:[{av:'AV14Group',fld:'vGROUP',pic:''},{av:'AV17GroupName',fld:'vGROUPNAME',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("'SEND'","{handler:'E121C2',iparms:[{av:'AV22MessageTitle',fld:'vMESSAGETITLE',pic:''},{av:'AV25NotificationMessage',fld:'vNOTIFICATIONMESSAGE',pic:''},{av:'AV21MessageBody',fld:'vMESSAGEBODY',pic:''},{av:'AV24NotificationDelivery',fld:'vNOTIFICATIONDELIVERY',pic:''},{av:'AV27TargetGroup',fld:'vTARGETGROUP',pic:''},{av:'AV8Target',fld:'vTARGET',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'AV26Success',fld:'vSUCCESS',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("'SEND'",",oparms:[{av:'AV25NotificationMessage',fld:'vNOTIFICATIONMESSAGE',pic:''},{av:'AV24NotificationDelivery',fld:'vNOTIFICATIONDELIVERY',pic:''},{av:'AV27TargetGroup',fld:'vTARGETGROUP',pic:''},{av:'AV8Target',fld:'vTARGET',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_DEVICES_FIRSTPAGE","{handler:'subgrid_devices_firstpage',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_DEVICES_FIRSTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_DEVICES_PREVPAGE","{handler:'subgrid_devices_previouspage',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_DEVICES_PREVPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_DEVICES_NEXTPAGE","{handler:'subgrid_devices_nextpage',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_DEVICES_NEXTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_DEVICES_LASTPAGE","{handler:'subgrid_devices_lastpage',iparms:[{av:'GRID_DEVICES_nFirstRecordOnPage'},{av:'GRID_DEVICES_nEOF'},{av:'subGrid_devices_Rows',ctrl:'GRID_DEVICES',prop:'Rows'},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_DEVICES_LASTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_GROUPSSELECTED_FIRSTPAGE","{handler:'subgrid_groupsselected_firstpage',iparms:[{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_GROUPSSELECTED_FIRSTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_GROUPSSELECTED_PREVPAGE","{handler:'subgrid_groupsselected_previouspage',iparms:[{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_GROUPSSELECTED_PREVPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_GROUPSSELECTED_NEXTPAGE","{handler:'subgrid_groupsselected_nextpage',iparms:[{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_GROUPSSELECTED_NEXTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
         setEventMetadata("GRID_GROUPSSELECTED_LASTPAGE","{handler:'subgrid_groupsselected_lastpage',iparms:[{av:'GRID_GROUPSSELECTED_nFirstRecordOnPage'},{av:'GRID_GROUPSSELECTED_nEOF'},{av:'subGrid_groupsselected_Rows',ctrl:'GRID_GROUPSSELECTED',prop:'Rows'},{av:'AV5DeviceId',fld:'vDEVICEID',pic:''},{av:'A6GroupId',fld:'GROUPID',pic:'ZZZ9'},{av:'A22GroupName',fld:'GROUPNAME',pic:'',hsh:true},{av:'A1DeviceId',fld:'DEVICEID',pic:''},{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]");
         setEventMetadata("GRID_GROUPSSELECTED_LASTPAGE",",oparms:[{av:'AV23NotificationConfiguration',fld:'vNOTIFICATIONCONFIGURATION',pic:''},{av:'dynavGroupnameid'},{av:'AV15GroupNameId',fld:'vGROUPNAMEID',pic:''}]}");
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
         AV23NotificationConfiguration = new GeneXus.Core.genexus.common.notifications.SdtConfiguration(context);
         GXKey = "";
         AV5DeviceId = "";
         A22GroupName = "";
         A1DeviceId = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         A20DeviceToken = "";
         AV14Group = new SdtGroup(context);
         AV25NotificationMessage = new GeneXus.Core.genexus.common.notifications.SdtNotification(context);
         AV24NotificationDelivery = new GeneXus.Core.genexus.common.notifications.SdtDelivery(context);
         AV27TargetGroup = new GeneXus.Core.genexus.common.notifications.SdtTarget_Group(context);
         AV8Target = new GeneXus.Core.genexus.common.notifications.SdtTarget(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         Grid_groupsContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_groups_Linesclass = "";
         Grid_groupsColumn = new GXWebColumn();
         TempTags = "";
         AV17GroupName = "";
         bttAdd_Jsonclick = "";
         Grid_devicesContainer = new GXWebGrid( context);
         subGrid_devices_Header = "";
         Grid_devicesColumn = new GXWebColumn();
         AV15GroupNameId = "";
         AV22MessageTitle = "";
         AV21MessageBody = "";
         bttSend_Jsonclick = "";
         Grid_groupsselectedContainer = new GXWebGrid( context);
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV11DeviceIdSelected = "";
         AV12DeviceTokenSelected = "";
         AV18GroupNameSelected = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H001C2_A6GroupId = new short[1] ;
         H001C2_A22GroupName = new String[] {""} ;
         H001C3_A6GroupId = new short[1] ;
         H001C3_A22GroupName = new String[] {""} ;
         H001C4_A20DeviceToken = new String[] {""} ;
         H001C4_A1DeviceId = new String[] {""} ;
         H001C5_AGRID_DEVICES_nRecordCount = new long[1] ;
         AV7OutMessages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV28TargetGroups = new GXBaseCollection<GeneXus.Core.genexus.common.notifications.SdtTarget_Group>( context, "Group", "GeneXus");
         Grid_groupsRow = new GXWebRow();
         Grid_groupsselectedRow = new GXWebRow();
         Grid_devicesRow = new GXWebRow();
         H001C6_A6GroupId = new short[1] ;
         H001C6_A22GroupName = new String[] {""} ;
         H001C7_A6GroupId = new short[1] ;
         H001C7_A1DeviceId = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         subGrid_groupsselected_Linesclass = "";
         subGrid_devices_Linesclass = "";
         subGrid_groupsselected_Header = "";
         Grid_groupsselectedColumn = new GXWebColumn();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sendnotifications__default(),
            new Object[][] {
                new Object[] {
               H001C2_A6GroupId, H001C2_A22GroupName
               }
               , new Object[] {
               H001C3_A6GroupId, H001C3_A22GroupName
               }
               , new Object[] {
               H001C4_A20DeviceToken, H001C4_A1DeviceId
               }
               , new Object[] {
               H001C5_AGRID_DEVICES_nRecordCount
               }
               , new Object[] {
               H001C6_A6GroupId, H001C6_A22GroupName
               }
               , new Object[] {
               H001C7_A6GroupId, H001C7_A1DeviceId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGroupnameselected_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_19 ;
      private short nGXsfl_19_idx=1 ;
      private short nRC_GXsfl_45 ;
      private short GRID_DEVICES_nEOF ;
      private short nRC_GXsfl_58 ;
      private short nGXsfl_58_idx=1 ;
      private short A6GroupId ;
      private short nGXsfl_45_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_groups_Backcolorstyle ;
      private short subGrid_groups_Titlebackstyle ;
      private short subGrid_groups_Allowselection ;
      private short subGrid_groups_Allowhovering ;
      private short subGrid_groups_Allowcollapsing ;
      private short subGrid_groups_Collapsed ;
      private short subGrid_devices_Backcolorstyle ;
      private short subGrid_devices_Allowselection ;
      private short subGrid_devices_Allowhovering ;
      private short subGrid_devices_Allowcollapsing ;
      private short subGrid_devices_Collapsed ;
      private short GRID_GROUPSSELECTED_nEOF ;
      private short AV16GroupIdSelected ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_groupsselected_Backcolorstyle ;
      private short GRID_GROUPS_nEOF ;
      private short nGXsfl_58_fel_idx=1 ;
      private short AV33GXLvl25 ;
      private short subGrid_groups_Backstyle ;
      private short subGrid_groupsselected_Backstyle ;
      private short subGrid_devices_Backstyle ;
      private short subGrid_groupsselected_Allowselection ;
      private short subGrid_groupsselected_Allowhovering ;
      private short subGrid_groupsselected_Allowcollapsing ;
      private short subGrid_groupsselected_Collapsed ;
      private int subGrid_groupsselected_Rows ;
      private int subGrid_devices_Rows ;
      private int subGrid_groups_Titlebackcolor ;
      private int subGrid_groups_Allbackcolor ;
      private int subGrid_groups_Selectedindex ;
      private int subGrid_groups_Selectioncolor ;
      private int subGrid_groups_Hoveringcolor ;
      private int edtavGroupname_Enabled ;
      private int subGrid_devices_Selectedindex ;
      private int subGrid_devices_Selectioncolor ;
      private int subGrid_devices_Hoveringcolor ;
      private int edtavMessagetitle_Enabled ;
      private int edtavMessagebody_Enabled ;
      private int gxdynajaxindex ;
      private int subGrid_groups_Islastpage ;
      private int subGrid_devices_Islastpage ;
      private int subGrid_groupsselected_Islastpage ;
      private int edtavGroupnameselected_Enabled ;
      private int GXPagingFrom3 ;
      private int GXPagingTo3 ;
      private int GRID_DEVICES_IsPaging ;
      private int GRID_GROUPSSELECTED_IsPaging ;
      private int edtavGroupidselected_Visible ;
      private int edtavDeviceidselected_Visible ;
      private int edtavDevicetokenselected_Visible ;
      private int idxLst ;
      private int subGrid_groups_Backcolor ;
      private int subGrid_groupsselected_Backcolor ;
      private int subGrid_groupsselected_Allbackcolor ;
      private int edtavDeviceidselected_Enabled ;
      private int edtavGroupidselected_Enabled ;
      private int edtavDevicetokenselected_Enabled ;
      private int edtavGroupnameselected_Visible ;
      private int subGrid_devices_Backcolor ;
      private int subGrid_devices_Allbackcolor ;
      private int subGrid_groupsselected_Selectedindex ;
      private int subGrid_groupsselected_Selectioncolor ;
      private int subGrid_groupsselected_Hoveringcolor ;
      private long GRID_DEVICES_nFirstRecordOnPage ;
      private long GRID_GROUPSSELECTED_nFirstRecordOnPage ;
      private long GRID_GROUPS_nCurrentRecord ;
      private long GRID_GROUPSSELECTED_nCurrentRecord ;
      private long GRID_DEVICES_nCurrentRecord ;
      private long GRID_GROUPS_nFirstRecordOnPage ;
      private long GRID_DEVICES_nRecordCount ;
      private long GRID_GROUPSSELECTED_nRecordCount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_19_idx="0001" ;
      private String GXKey ;
      private String sGXsfl_58_idx="0001" ;
      private String A22GroupName ;
      private String sGXsfl_45_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable9_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTable10_Internalname ;
      private String grpGroup3_Internalname ;
      private String divGroup3table_Internalname ;
      private String sStyleString ;
      private String subGrid_groups_Internalname ;
      private String subGrid_groups_Class ;
      private String subGrid_groups_Linesclass ;
      private String subGrid_groups_Header ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String divTable1_Internalname ;
      private String edtavGroupname_Internalname ;
      private String TempTags ;
      private String AV17GroupName ;
      private String edtavGroupname_Jsonclick ;
      private String bttAdd_Internalname ;
      private String bttAdd_Jsonclick ;
      private String divTable11_Internalname ;
      private String divTable3_Internalname ;
      private String grpDevices_Internalname ;
      private String divGroup2table_Internalname ;
      private String subGrid_devices_Internalname ;
      private String subGrid_devices_Header ;
      private String grpGroup2_Internalname ;
      private String divGroup2table1_Internalname ;
      private String divTable4_Internalname ;
      private String divTable5_Internalname ;
      private String dynavGroupnameid_Internalname ;
      private String AV15GroupNameId ;
      private String dynavGroupnameid_Jsonclick ;
      private String edtavMessagetitle_Internalname ;
      private String edtavMessagetitle_Jsonclick ;
      private String edtavMessagebody_Internalname ;
      private String divTable6_Internalname ;
      private String bttSend_Internalname ;
      private String bttSend_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtGroupName_Internalname ;
      private String edtDeviceId_Internalname ;
      private String GXCCtl ;
      private String edtavDeviceidselected_Internalname ;
      private String edtavGroupidselected_Internalname ;
      private String edtavDevicetokenselected_Internalname ;
      private String edtavGroupnameselected_Internalname ;
      private String chkavGroupselected_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String sGXsfl_58_fel_idx="0001" ;
      private String sGXsfl_19_fel_idx="0001" ;
      private String ROClassString ;
      private String edtGroupName_Jsonclick ;
      private String subGrid_groupsselected_Class ;
      private String subGrid_groupsselected_Linesclass ;
      private String divGrid3table_Internalname ;
      private String divTable8_Internalname ;
      private String edtavDeviceidselected_Jsonclick ;
      private String edtavGroupidselected_Jsonclick ;
      private String edtavGroupnameselected_Jsonclick ;
      private String subGrid_groupsselected_Internalname ;
      private String sGXsfl_45_fel_idx="0001" ;
      private String subGrid_devices_Class ;
      private String subGrid_devices_Linesclass ;
      private String divGrid1table_Internalname ;
      private String divTable7_Internalname ;
      private String edtDeviceId_Jsonclick ;
      private String divTable2_Internalname ;
      private String subGrid_groupsselected_Header ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV26Success ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool AV19GroupSelected ;
      private bool gxdyncontrolsrefreshing ;
      private bool bGXsfl_58_Refreshing=false ;
      private bool bGXsfl_19_Refreshing=false ;
      private bool bGXsfl_45_Refreshing=false ;
      private bool gx_refresh_fired ;
      private bool AV6IsSuccessful ;
      private String AV5DeviceId ;
      private String A1DeviceId ;
      private String A20DeviceToken ;
      private String AV22MessageTitle ;
      private String AV21MessageBody ;
      private String AV11DeviceIdSelected ;
      private String AV12DeviceTokenSelected ;
      private String AV18GroupNameSelected ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid Grid_groupsContainer ;
      private GXWebGrid Grid_devicesContainer ;
      private GXWebGrid Grid_groupsselectedContainer ;
      private GXWebRow Grid_groupsRow ;
      private GXWebRow Grid_groupsselectedRow ;
      private GXWebRow Grid_devicesRow ;
      private GXWebColumn Grid_groupsColumn ;
      private GXWebColumn Grid_devicesColumn ;
      private GXWebColumn Grid_groupsselectedColumn ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavGroupselected ;
      private GXCombobox dynavGroupnameid ;
      private IDataStoreProvider pr_default ;
      private short[] H001C2_A6GroupId ;
      private String[] H001C2_A22GroupName ;
      private short[] H001C3_A6GroupId ;
      private String[] H001C3_A22GroupName ;
      private String[] H001C4_A20DeviceToken ;
      private String[] H001C4_A1DeviceId ;
      private long[] H001C5_AGRID_DEVICES_nRecordCount ;
      private short[] H001C6_A6GroupId ;
      private String[] H001C6_A22GroupName ;
      private short[] H001C7_A6GroupId ;
      private String[] H001C7_A1DeviceId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<SdtMessages_Message> AV7OutMessages ;
      private GXBaseCollection<GeneXus.Core.genexus.common.notifications.SdtTarget_Group> AV28TargetGroups ;
      private GXWebForm Form ;
      private GeneXus.Core.genexus.common.notifications.SdtTarget AV8Target ;
      private GeneXus.Core.genexus.common.notifications.SdtTarget_Group AV27TargetGroup ;
      private SdtGroup AV14Group ;
      private GeneXus.Core.genexus.common.notifications.SdtConfiguration AV23NotificationConfiguration ;
      private GeneXus.Core.genexus.common.notifications.SdtDelivery AV24NotificationDelivery ;
      private GeneXus.Core.genexus.common.notifications.SdtNotification AV25NotificationMessage ;
   }

   public class sendnotifications__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001C2 ;
          prmH001C2 = new Object[] {
          } ;
          Object[] prmH001C3 ;
          prmH001C3 = new Object[] {
          } ;
          Object[] prmH001C4 ;
          prmH001C4 = new Object[] {
          new Object[] {"@GXPagingFrom3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001C5 ;
          prmH001C5 = new Object[] {
          } ;
          Object[] prmH001C6 ;
          prmH001C6 = new Object[] {
          } ;
          Object[] prmH001C7 ;
          prmH001C7 = new Object[] {
          new Object[] {"@AV5DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001C2", "SELECT [GroupId], [GroupName] FROM [Group] WITH (NOLOCK) ORDER BY [GroupName] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C2,0,0,true,false )
             ,new CursorDef("H001C3", "SELECT [GroupId], [GroupName] FROM [Group] WITH (NOLOCK) ORDER BY [GroupId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C3,11,0,true,false )
             ,new CursorDef("H001C4", "SELECT [DeviceToken], [DeviceId] FROM [Devices] WITH (NOLOCK) ORDER BY [DeviceId]  OFFSET @GXPagingFrom3 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo3 > 0 THEN @GXPagingTo3 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C4,11,0,true,false )
             ,new CursorDef("H001C5", "SELECT COUNT(*) FROM [Devices] WITH (NOLOCK) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C5,1,0,true,false )
             ,new CursorDef("H001C6", "SELECT [GroupId], [GroupName] FROM [Group] WITH (NOLOCK) ORDER BY [GroupId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C6,11,0,true,false )
             ,new CursorDef("H001C7", "SELECT [GroupId], [DeviceId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @AV5DeviceId and [GroupId] = @GroupId ORDER BY [DeviceId], [GroupId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C7,1,0,false,true )
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
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
