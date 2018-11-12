/*
               File: Devices
        Description: Devices
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:51:49.47
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
   public class devices : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A6GroupId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_9( A6GroupId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Griddevices_group") == 0 )
         {
            nRC_GXsfl_58 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_58_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_58_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGriddevices_group_newrow( ) ;
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
               AV7DeviceId = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DeviceId", AV7DeviceId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDEVICEID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7DeviceId, "")), context));
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
            Form.Meta.addItem("description", "Devices", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public devices( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public devices( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_DeviceId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7DeviceId = aP1_DeviceId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbDeviceType = new GXCombobox();
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
         if ( cmbDeviceType.ItemCount > 0 )
         {
            A19DeviceType = (short)(NumberUtil.Val( cmbDeviceType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A19DeviceType), 1, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbDeviceType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbDeviceType_Internalname, "Values", cmbDeviceType.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Devices", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Devices.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Devices.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDeviceId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDeviceId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDeviceId_Internalname, A1DeviceId, StringUtil.RTrim( context.localUtil.Format( A1DeviceId, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDeviceId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDeviceId_Enabled, 1, "text", "", 80, "chr", 1, "row", 128, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbDeviceType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbDeviceType_Internalname, "Type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbDeviceType, cmbDeviceType_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A19DeviceType), 1, 0)), 1, cmbDeviceType_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbDeviceType.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_Devices.htm");
            cmbDeviceType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbDeviceType_Internalname, "Values", (String)(cmbDeviceType.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDeviceToken_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDeviceToken_Internalname, "Token", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtDeviceToken_Internalname, A20DeviceToken, "", "", 0, 1, edtDeviceToken_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDeviceName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDeviceName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtDeviceName_Internalname, A21DeviceName, StringUtil.RTrim( context.localUtil.Format( A21DeviceName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDeviceName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDeviceName_Enabled, 0, "text", "", 80, "chr", 1, "row", 128, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGrouptable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlegroup_Internalname, "Grupo", "", "", lblTitlegroup_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Griddevices_group( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Devices.htm");
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

      protected void gxdraw_Griddevices_group( )
      {
         /*  Grid Control  */
         Griddevices_groupContainer.AddObjectProperty("GridName", "Griddevices_group");
         Griddevices_groupContainer.AddObjectProperty("Header", subGriddevices_group_Header);
         Griddevices_groupContainer.AddObjectProperty("Class", "Grid");
         Griddevices_groupContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Backcolorstyle), 1, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("CmpContext", "");
         Griddevices_groupContainer.AddObjectProperty("InMasterPage", "false");
         Griddevices_groupColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddevices_groupColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6GroupId), 4, 0, ".", "")));
         Griddevices_groupColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupId_Enabled), 5, 0, ".", "")));
         Griddevices_groupContainer.AddColumnProperties(Griddevices_groupColumn);
         Griddevices_groupColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddevices_groupContainer.AddColumnProperties(Griddevices_groupColumn);
         Griddevices_groupColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddevices_groupColumn.AddObjectProperty("Value", StringUtil.RTrim( A22GroupName));
         Griddevices_groupColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupName_Enabled), 5, 0, ".", "")));
         Griddevices_groupContainer.AddColumnProperties(Griddevices_groupColumn);
         Griddevices_groupContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Selectedindex), 4, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Allowselection), 1, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Selectioncolor), 9, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Allowhovering), 1, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Hoveringcolor), 9, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Allowcollapsing), 1, 0, ".", "")));
         Griddevices_groupContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddevices_group_Collapsed), 1, 0, ".", "")));
         nGXsfl_58_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount2 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_2 = 1;
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
               nBlankRcdCount2 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            sMode2 = Gx_mode;
            while ( nGXsfl_58_idx < nRC_GXsfl_58 )
            {
               bGXsfl_58_Refreshing = true;
               ReadRow012( ) ;
               edtGroupId_Enabled = (int)(context.localUtil.CToN( cgiGet( "GROUPID_"+sGXsfl_58_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupId_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               edtGroupName_Enabled = (int)(context.localUtil.CToN( cgiGet( "GROUPNAME_"+sGXsfl_58_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupName_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               imgprompt_6_Link = cgiGet( "PROMPT_6_"+sGXsfl_58_idx+"Link");
               if ( ( nRcdExists_2 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal012( ) ;
               }
               SendRow012( ) ;
               bGXsfl_58_Refreshing = false;
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount2 = 5;
            nRcdExists_2 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_582( ) ;
                  init_level_properties2( ) ;
                  standaloneNotModal012( ) ;
                  getByPrimaryKey012( ) ;
                  standaloneModal012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode2 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_582( ) ;
            InitAll012( ) ;
            init_level_properties2( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            nRcdExists_2 = 0;
            nIsMod_2 = 0;
            nRcdDeleted_2 = 0;
            nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2);
            fRowAdded = 0;
            while ( nBlankRcdCount2 > 0 )
            {
               AddRow012( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtGroupId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount2 = (short)(nBlankRcdCount2-1);
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Griddevices_groupContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griddevices_group", Griddevices_groupContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Griddevices_groupContainerData", Griddevices_groupContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Griddevices_groupContainerData"+"V", Griddevices_groupContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Griddevices_groupContainerData"+"V"+"\" value='"+Griddevices_groupContainer.GridValuesHidden()+"'/>") ;
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
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A1DeviceId = cgiGet( edtDeviceId_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
               cmbDeviceType.Name = cmbDeviceType_Internalname;
               cmbDeviceType.CurrentValue = cgiGet( cmbDeviceType_Internalname);
               A19DeviceType = (short)(NumberUtil.Val( cgiGet( cmbDeviceType_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
               A20DeviceToken = cgiGet( edtDeviceToken_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20DeviceToken", A20DeviceToken);
               A21DeviceName = cgiGet( edtDeviceName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21DeviceName", A21DeviceName);
               /* Read saved values. */
               Z1DeviceId = cgiGet( "Z1DeviceId");
               Z19DeviceType = (short)(context.localUtil.CToN( cgiGet( "Z19DeviceType"), ",", "."));
               Z20DeviceToken = cgiGet( "Z20DeviceToken");
               Z21DeviceName = cgiGet( "Z21DeviceName");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_58 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_58"), ",", "."));
               AV7DeviceId = cgiGet( "vDEVICEID");
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Devices";
               A21DeviceName = cgiGet( edtDeviceName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21DeviceName", A21DeviceName);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A21DeviceName, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               A19DeviceType = (short)(NumberUtil.Val( cgiGet( cmbDeviceType_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A19DeviceType), "9");
               A20DeviceToken = cgiGet( edtDeviceToken_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20DeviceToken", A20DeviceToken);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A20DeviceToken, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("devices:[SecurityCheckFailed value for]"+"DeviceName:"+StringUtil.RTrim( context.localUtil.Format( A21DeviceName, "")));
                  GXUtil.WriteLog("devices:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("devices:[SecurityCheckFailed value for]"+"DeviceType:"+context.localUtil.Format( (decimal)(A19DeviceType), "9"));
                  GXUtil.WriteLog("devices:[SecurityCheckFailed value for]"+"DeviceToken:"+StringUtil.RTrim( context.localUtil.Format( A20DeviceToken, "")));
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
                  A1DeviceId = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
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
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode1;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "DEVICEID");
                        AnyError = 1;
                        GX_FocusControl = edtDeviceId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "AFTER TRN") == 0 ) )
                        {
                           nGXsfl_58_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
                           SubsflControlProps_582( ) ;
                           if ( ( ( context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
                           {
                              GXCCtl = "GROUPID_" + sGXsfl_58_idx;
                              GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                              AnyError = 1;
                              GX_FocusControl = edtGroupId_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                              wbErr = true;
                              A6GroupId = 0;
                           }
                           else
                           {
                              A6GroupId = (short)(context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", "."));
                           }
                           A22GroupName = cgiGet( edtGroupName_Internalname);
                           GXCCtl = "Z6GroupId_" + sGXsfl_58_idx;
                           Z6GroupId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                           GXCCtl = "nRcdDeleted_2_" + sGXsfl_58_idx;
                           nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                           GXCCtl = "nRcdExists_2_" + sGXsfl_58_idx;
                           nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                           GXCCtl = "nIsMod_2_" + sGXsfl_58_idx;
                           nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E11012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: After Trn */
                                 E12012 ();
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
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
            DisableAttributes011( ) ;
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
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_58_idx = 0;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "GROUPID_" + sGXsfl_58_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtGroupId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              CloseExtendedTableCursors012( ) ;
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
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "GROUPID_" + sGXsfl_58_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtGroupId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtGroupId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6GroupId), 4, 0, ",", ""))) ;
            ChangePostValue( edtGroupName_Internalname, StringUtil.RTrim( A22GroupName)) ;
            ChangePostValue( "ZT_"+"Z6GroupId_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6GroupId), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "GROUPID_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "GROUPNAME_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupName_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwdevices.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(1);
         pr_default.close(2);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z19DeviceType = T00016_A19DeviceType[0];
               Z20DeviceToken = T00016_A20DeviceToken[0];
               Z21DeviceName = T00016_A21DeviceName[0];
            }
            else
            {
               Z19DeviceType = A19DeviceType;
               Z20DeviceToken = A20DeviceToken;
               Z21DeviceName = A21DeviceName;
            }
         }
         if ( GX_JID == -7 )
         {
            Z1DeviceId = A1DeviceId;
            Z19DeviceType = A19DeviceType;
            Z20DeviceToken = A20DeviceToken;
            Z21DeviceName = A21DeviceName;
         }
      }

      protected void standaloneNotModal( )
      {
         edtDeviceName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceName_Enabled), 5, 0)), true);
         cmbDeviceType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbDeviceType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbDeviceType.Enabled), 5, 0)), true);
         edtDeviceToken_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceToken_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceToken_Enabled), 5, 0)), true);
         edtDeviceId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
         edtDeviceName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceName_Enabled), 5, 0)), true);
         cmbDeviceType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbDeviceType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbDeviceType.Enabled), 5, 0)), true);
         edtDeviceToken_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceToken_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceToken_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7DeviceId)) )
         {
            A1DeviceId = AV7DeviceId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7DeviceId)) )
         {
            edtDeviceId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
         }
         else
         {
            if ( true )
            {
               edtDeviceId_Enabled = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
            }
            else
            {
               edtDeviceId_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7DeviceId)) )
         {
            edtDeviceId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV11Pgmname = "Devices";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
            A19DeviceType = T00017_A19DeviceType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
            A20DeviceToken = T00017_A20DeviceToken[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20DeviceToken", A20DeviceToken);
            A21DeviceName = T00017_A21DeviceName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21DeviceName", A21DeviceName);
            ZM011( -7) ;
         }
         pr_default.close(5);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         AV11Pgmname = "Devices";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Devices";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T00018 */
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
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM011( 7) ;
            RcdFound1 = 1;
            A1DeviceId = T00016_A1DeviceId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
            A19DeviceType = T00016_A19DeviceType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
            A20DeviceToken = T00016_A20DeviceToken[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20DeviceToken", A20DeviceToken);
            A21DeviceName = T00016_A21DeviceName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21DeviceName", A21DeviceName);
            Z1DeviceId = A1DeviceId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00019_A1DeviceId[0], A1DeviceId) < 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00019_A1DeviceId[0], A1DeviceId) > 0 ) ) )
            {
               A1DeviceId = T00019_A1DeviceId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A1DeviceId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000110_A1DeviceId[0], A1DeviceId) > 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000110_A1DeviceId[0], A1DeviceId) < 0 ) ) )
            {
               A1DeviceId = T000110_A1DeviceId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
               {
                  A1DeviceId = Z1DeviceId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "DEVICEID");
                  AnyError = 1;
                  GX_FocusControl = edtDeviceId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
               {
                  /* Insert record */
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "DEVICEID");
                     AnyError = 1;
                     GX_FocusControl = edtDeviceId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     Insert011( ) ;
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
         if ( StringUtil.StrCmp(A1DeviceId, Z1DeviceId) != 0 )
         {
            A1DeviceId = Z1DeviceId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "DEVICEID");
            AnyError = 1;
            GX_FocusControl = edtDeviceId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00015 */
            pr_default.execute(3, new Object[] {A1DeviceId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Devices"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z19DeviceType != T00015_A19DeviceType[0] ) || ( StringUtil.StrCmp(Z20DeviceToken, T00015_A20DeviceToken[0]) != 0 ) || ( StringUtil.StrCmp(Z21DeviceName, T00015_A21DeviceName[0]) != 0 ) )
            {
               if ( Z19DeviceType != T00015_A19DeviceType[0] )
               {
                  GXUtil.WriteLog("devices:[seudo value changed for attri]"+"DeviceType");
                  GXUtil.WriteLogRaw("Old: ",Z19DeviceType);
                  GXUtil.WriteLogRaw("Current: ",T00015_A19DeviceType[0]);
               }
               if ( StringUtil.StrCmp(Z20DeviceToken, T00015_A20DeviceToken[0]) != 0 )
               {
                  GXUtil.WriteLog("devices:[seudo value changed for attri]"+"DeviceToken");
                  GXUtil.WriteLogRaw("Old: ",Z20DeviceToken);
                  GXUtil.WriteLogRaw("Current: ",T00015_A20DeviceToken[0]);
               }
               if ( StringUtil.StrCmp(Z21DeviceName, T00015_A21DeviceName[0]) != 0 )
               {
                  GXUtil.WriteLog("devices:[seudo value changed for attri]"+"DeviceName");
                  GXUtil.WriteLogRaw("Old: ",Z21DeviceName);
                  GXUtil.WriteLogRaw("Current: ",T00015_A21DeviceName[0]);
               }
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
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A1DeviceId, A19DeviceType, A20DeviceToken, A21DeviceName});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
                     if ( (pr_default.getStatus(9) == 1) )
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
                              ResetCaption010( ) ;
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
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {A19DeviceType, A20DeviceToken, A21DeviceName, A1DeviceId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
                     if ( (pr_default.getStatus(10) == 103) )
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
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
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000113 */
                     pr_default.execute(11, new Object[] {A1DeviceId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Devices") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Devices";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_58_idx = 0;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert012( ) ;
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "GROUPID_" + sGXsfl_58_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtGroupId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtGroupId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6GroupId), 4, 0, ",", ""))) ;
            ChangePostValue( edtGroupName_Internalname, StringUtil.RTrim( A22GroupName)) ;
            ChangePostValue( "ZT_"+"Z6GroupId_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6GroupId), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "GROUPID_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "GROUPNAME_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupName_Enabled), 5, 0, ".", ""))) ;
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
         nRcdDeleted_2 = 0;
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
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("devices",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("devices",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000114 */
         pr_default.execute(12);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound1 = 1;
            A1DeviceId = T000114_A1DeviceId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound1 = 1;
            A1DeviceId = T000114_A1DeviceId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(12);
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
         edtDeviceId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceId_Enabled), 5, 0)), true);
         cmbDeviceType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbDeviceType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbDeviceType.Enabled), 5, 0)), true);
         edtDeviceToken_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceToken_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceToken_Enabled), 5, 0)), true);
         edtDeviceName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDeviceName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDeviceName_Enabled), 5, 0)), true);
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -8 )
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtGroupId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupId_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         }
         else
         {
            edtGroupId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupId_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000115 */
         pr_default.execute(13, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound2 = 1;
            A22GroupName = T000115_A22GroupName[0];
            ZM012( -8) ;
         }
         pr_default.close(13);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         Gx_BScreen = 1;
         standaloneModal012( ) ;
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "GROUPID_" + sGXsfl_58_idx;
            GX_msglist.addItem("No existe 'Group Id'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtGroupId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A22GroupName = T00014_A22GroupName[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors012( )
      {
         pr_default.close(2);
      }

      protected void enableDisable012( )
      {
      }

      protected void gxLoad_9( short A6GroupId )
      {
         /* Using cursor T000116 */
         pr_default.execute(14, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GXCCtl = "GROUPID_" + sGXsfl_58_idx;
            GX_msglist.addItem("No existe 'Group Id'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtGroupId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A22GroupName = T000116_A22GroupName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A22GroupName))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(14);
      }

      protected void GetKey012( )
      {
         /* Using cursor T000117 */
         pr_default.execute(15, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(15);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1DeviceId, A6GroupId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM012( 8) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A6GroupId = T00013_A6GroupId[0];
            Z1DeviceId = A1DeviceId;
            Z6GroupId = A6GroupId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load012( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal012( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
            /* Using cursor T00012 */
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
                     /* Using cursor T000118 */
                     pr_default.execute(16, new Object[] {A1DeviceId, A6GroupId});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("DevicesGroup") ;
                     if ( (pr_default.getStatus(16) == 1) )
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
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
                  /* Using cursor T000119 */
                  pr_default.execute(17, new Object[] {A1DeviceId, A6GroupId});
                  pr_default.close(17);
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
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel012( ) ;
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000120 */
            pr_default.execute(18, new Object[] {A6GroupId});
            A22GroupName = T000120_A22GroupName[0];
            pr_default.close(18);
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

      public void ScanStart012( )
      {
         /* Scan By routine */
         /* Using cursor T000121 */
         pr_default.execute(19, new Object[] {A1DeviceId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A6GroupId = T000121_A6GroupId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A6GroupId = T000121_A6GroupId[0];
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(19);
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
         edtGroupId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupId_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         edtGroupName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupName_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void SubsflControlProps_582( )
      {
         edtGroupId_Internalname = "GROUPID_"+sGXsfl_58_idx;
         imgprompt_6_Internalname = "PROMPT_6_"+sGXsfl_58_idx;
         edtGroupName_Internalname = "GROUPNAME_"+sGXsfl_58_idx;
      }

      protected void SubsflControlProps_fel_582( )
      {
         edtGroupId_Internalname = "GROUPID_"+sGXsfl_58_fel_idx;
         imgprompt_6_Internalname = "PROMPT_6_"+sGXsfl_58_fel_idx;
         edtGroupName_Internalname = "GROUPNAME_"+sGXsfl_58_fel_idx;
      }

      protected void AddRow012( )
      {
         nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_582( ) ;
         SendRow012( ) ;
      }

      protected void SendRow012( )
      {
         Griddevices_groupRow = GXWebRow.GetNew(context);
         if ( subGriddevices_group_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGriddevices_group_Backstyle = 0;
            if ( StringUtil.StrCmp(subGriddevices_group_Class, "") != 0 )
            {
               subGriddevices_group_Linesclass = subGriddevices_group_Class+"Odd";
            }
         }
         else if ( subGriddevices_group_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGriddevices_group_Backstyle = 0;
            subGriddevices_group_Backcolor = subGriddevices_group_Allbackcolor;
            if ( StringUtil.StrCmp(subGriddevices_group_Class, "") != 0 )
            {
               subGriddevices_group_Linesclass = subGriddevices_group_Class+"Uniform";
            }
         }
         else if ( subGriddevices_group_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGriddevices_group_Backstyle = 1;
            if ( StringUtil.StrCmp(subGriddevices_group_Class, "") != 0 )
            {
               subGriddevices_group_Linesclass = subGriddevices_group_Class+"Odd";
            }
            subGriddevices_group_Backcolor = (int)(0x0);
         }
         else if ( subGriddevices_group_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGriddevices_group_Backstyle = 1;
            if ( ((int)(((nGXsfl_58_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGriddevices_group_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriddevices_group_Class, "") != 0 )
               {
                  subGriddevices_group_Linesclass = subGriddevices_group_Class+"Odd";
               }
            }
            else
            {
               subGriddevices_group_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriddevices_group_Class, "") != 0 )
               {
                  subGriddevices_group_Linesclass = subGriddevices_group_Class+"Even";
               }
            }
         }
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GROUPID_"+sGXsfl_58_idx+"'), id:'"+"GROUPID_"+sGXsfl_58_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_2_"+sGXsfl_58_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_58_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_58_idx + "',58)\"";
         ROClassString = "Attribute";
         Griddevices_groupRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGroupId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6GroupId), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A6GroupId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtGroupId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtGroupId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"AutoId",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         Griddevices_groupRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_6_Internalname,(String)sImgUrl,(String)imgprompt_6_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_6_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddevices_groupRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGroupName_Internalname,StringUtil.RTrim( A22GroupName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtGroupName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtGroupName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Griddevices_groupRow);
         send_integrity_lvl_hashes012( ) ;
         GXCCtl = "Z6GroupId_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6GroupId), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_58_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vDEVICEID_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, AV7DeviceId);
         GxWebStd.gx_hidden_field( context, "GROUPID_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GROUPNAME_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGroupName_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_6_"+sGXsfl_58_idx+"Link", StringUtil.RTrim( imgprompt_6_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Griddevices_groupContainer.AddRow(Griddevices_groupRow);
      }

      protected void ReadRow012( )
      {
         nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_582( ) ;
         edtGroupId_Enabled = (int)(context.localUtil.CToN( cgiGet( "GROUPID_"+sGXsfl_58_idx+"Enabled"), ",", "."));
         edtGroupName_Enabled = (int)(context.localUtil.CToN( cgiGet( "GROUPNAME_"+sGXsfl_58_idx+"Enabled"), ",", "."));
         imgprompt_6_Link = cgiGet( "PROMPT_6_"+sGXsfl_58_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "GROUPID_" + sGXsfl_58_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtGroupId_Internalname;
            wbErr = true;
            A6GroupId = 0;
         }
         else
         {
            A6GroupId = (short)(context.localUtil.CToN( cgiGet( edtGroupId_Internalname), ",", "."));
         }
         A22GroupName = cgiGet( edtGroupName_Internalname);
         GXCCtl = "Z6GroupId_" + sGXsfl_58_idx;
         Z6GroupId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_58_idx;
         nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_2_" + sGXsfl_58_idx;
         nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_2_" + sGXsfl_58_idx;
         nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtGroupId_Enabled = edtGroupId_Enabled;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_58_idx = 0;
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_582( ) ;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
            SubsflControlProps_582( ) ;
            ChangePostValue( "Z6GroupId_"+sGXsfl_58_idx, cgiGet( "ZT_"+"Z6GroupId_"+sGXsfl_58_idx)) ;
            DeletePostValue( "ZT_"+"Z6GroupId_"+sGXsfl_58_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118515527", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("devices.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7DeviceId))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Devices";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A21DeviceName, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A19DeviceType), "9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A20DeviceToken, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("devices:[SendSecurityCheck value for]"+"DeviceName:"+StringUtil.RTrim( context.localUtil.Format( A21DeviceName, "")));
         GXUtil.WriteLog("devices:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("devices:[SendSecurityCheck value for]"+"DeviceType:"+context.localUtil.Format( (decimal)(A19DeviceType), "9"));
         GXUtil.WriteLog("devices:[SendSecurityCheck value for]"+"DeviceToken:"+StringUtil.RTrim( context.localUtil.Format( A20DeviceToken, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1DeviceId", Z1DeviceId);
         GxWebStd.gx_hidden_field( context, "Z19DeviceType", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19DeviceType), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z20DeviceToken", Z20DeviceToken);
         GxWebStd.gx_hidden_field( context, "Z21DeviceName", Z21DeviceName);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_58", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_58_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vDEVICEID", AV7DeviceId);
         GxWebStd.gx_hidden_field( context, "gxhash_vDEVICEID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7DeviceId, "")), context));
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
         return formatLink("devices.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7DeviceId)) ;
      }

      public override String GetPgmname( )
      {
         return "Devices" ;
      }

      public override String GetPgmdesc( )
      {
         return "Devices" ;
      }

      protected void InitializeNonKey011( )
      {
         A19DeviceType = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
         A20DeviceToken = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20DeviceToken", A20DeviceToken);
         A21DeviceName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21DeviceName", A21DeviceName);
         Z19DeviceType = 0;
         Z20DeviceToken = "";
         Z21DeviceName = "";
      }

      protected void InitAll011( )
      {
         A1DeviceId = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1DeviceId", A1DeviceId);
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118515552", true);
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
         context.AddJavascriptSource("devices.js", "?2018101118515553", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         edtGroupId_Enabled = defedtGroupId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGroupId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGroupId_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
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
         edtDeviceId_Internalname = "DEVICEID";
         cmbDeviceType_Internalname = "DEVICETYPE";
         edtDeviceToken_Internalname = "DEVICETOKEN";
         edtDeviceName_Internalname = "DEVICENAME";
         lblTitlegroup_Internalname = "TITLEGROUP";
         edtGroupId_Internalname = "GROUPID";
         edtGroupName_Internalname = "GROUPNAME";
         divGrouptable_Internalname = "GROUPTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_6_Internalname = "PROMPT_6";
         subGriddevices_group_Internalname = "GRIDDEVICES_GROUP";
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
         Form.Caption = "Devices";
         edtGroupName_Jsonclick = "";
         imgprompt_6_Visible = 1;
         imgprompt_6_Link = "";
         imgprompt_6_Visible = 1;
         edtGroupId_Jsonclick = "";
         subGriddevices_group_Class = "Grid";
         subGriddevices_group_Backcolorstyle = 0;
         subGriddevices_group_Allowcollapsing = 0;
         subGriddevices_group_Allowselection = 0;
         edtGroupName_Enabled = 0;
         edtGroupId_Enabled = 1;
         subGriddevices_group_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtDeviceName_Jsonclick = "";
         edtDeviceName_Enabled = 0;
         edtDeviceToken_Enabled = 0;
         cmbDeviceType_Jsonclick = "";
         cmbDeviceType.Enabled = 0;
         edtDeviceId_Jsonclick = "";
         edtDeviceId_Enabled = 0;
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

      protected void gxnrGriddevices_group_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_582( ) ;
         while ( nGXsfl_58_idx <= nRC_GXsfl_58 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow012( ) ;
            nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
            SubsflControlProps_582( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Griddevices_groupContainer));
         /* End function gxnrGriddevices_group_newrow */
      }

      protected void init_web_controls( )
      {
         cmbDeviceType.Name = "DEVICETYPE";
         cmbDeviceType.WebTags = "";
         cmbDeviceType.addItem("0", "iOS", 0);
         cmbDeviceType.addItem("1", "Android", 0);
         cmbDeviceType.addItem("2", "Blackberry", 0);
         cmbDeviceType.addItem("3", "Windows", 0);
         if ( cmbDeviceType.ItemCount > 0 )
         {
            A19DeviceType = (short)(NumberUtil.Val( cmbDeviceType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A19DeviceType), 1, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19DeviceType", StringUtil.Str( (decimal)(A19DeviceType), 1, 0));
         }
         /* End function init_web_controls */
      }

      public void Valid_Groupid( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A6GroupId = GX_Parm1;
         A22GroupName = GX_Parm2;
         /* Using cursor T000120 */
         pr_default.execute(18, new Object[] {A6GroupId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Group Id'.", "ForeignKeyNotFound", 1, "GROUPID");
            AnyError = 1;
            GX_FocusControl = edtGroupId_Internalname;
         }
         A22GroupName = T000120_A22GroupName[0];
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A22GroupName = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A22GroupName));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DeviceId',fld:'vDEVICEID',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DeviceId',fld:'vDEVICEID',pic:'',hsh:true},{av:'A21DeviceName',fld:'DEVICENAME',pic:''},{av:'cmbDeviceType'},{av:'A19DeviceType',fld:'DEVICETYPE',pic:'9'},{av:'A20DeviceToken',fld:'DEVICETOKEN',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(18);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV7DeviceId = "";
         Z1DeviceId = "";
         Z20DeviceToken = "";
         Z21DeviceName = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A1DeviceId = "";
         A20DeviceToken = "";
         A21DeviceName = "";
         lblTitlegroup_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Griddevices_groupContainer = new GXWebGrid( context);
         Griddevices_groupColumn = new GXWebColumn();
         A22GroupName = "";
         sMode2 = "";
         GX_FocusControl = "";
         sStyleString = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00017_A1DeviceId = new String[] {""} ;
         T00017_A19DeviceType = new short[1] ;
         T00017_A20DeviceToken = new String[] {""} ;
         T00017_A21DeviceName = new String[] {""} ;
         T00018_A1DeviceId = new String[] {""} ;
         T00016_A1DeviceId = new String[] {""} ;
         T00016_A19DeviceType = new short[1] ;
         T00016_A20DeviceToken = new String[] {""} ;
         T00016_A21DeviceName = new String[] {""} ;
         T00019_A1DeviceId = new String[] {""} ;
         T000110_A1DeviceId = new String[] {""} ;
         T00015_A1DeviceId = new String[] {""} ;
         T00015_A19DeviceType = new short[1] ;
         T00015_A20DeviceToken = new String[] {""} ;
         T00015_A21DeviceName = new String[] {""} ;
         T000114_A1DeviceId = new String[] {""} ;
         Z22GroupName = "";
         T000115_A1DeviceId = new String[] {""} ;
         T000115_A22GroupName = new String[] {""} ;
         T000115_A6GroupId = new short[1] ;
         T00014_A22GroupName = new String[] {""} ;
         T000116_A22GroupName = new String[] {""} ;
         T000117_A1DeviceId = new String[] {""} ;
         T000117_A6GroupId = new short[1] ;
         T00013_A1DeviceId = new String[] {""} ;
         T00013_A6GroupId = new short[1] ;
         T00012_A1DeviceId = new String[] {""} ;
         T00012_A6GroupId = new short[1] ;
         T000120_A22GroupName = new String[] {""} ;
         T000121_A1DeviceId = new String[] {""} ;
         T000121_A6GroupId = new short[1] ;
         Griddevices_groupRow = new GXWebRow();
         subGriddevices_group_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.devices__default(),
            new Object[][] {
                new Object[] {
               T00012_A1DeviceId, T00012_A6GroupId
               }
               , new Object[] {
               T00013_A1DeviceId, T00013_A6GroupId
               }
               , new Object[] {
               T00014_A22GroupName
               }
               , new Object[] {
               T00015_A1DeviceId, T00015_A19DeviceType, T00015_A20DeviceToken, T00015_A21DeviceName
               }
               , new Object[] {
               T00016_A1DeviceId, T00016_A19DeviceType, T00016_A20DeviceToken, T00016_A21DeviceName
               }
               , new Object[] {
               T00017_A1DeviceId, T00017_A19DeviceType, T00017_A20DeviceToken, T00017_A21DeviceName
               }
               , new Object[] {
               T00018_A1DeviceId
               }
               , new Object[] {
               T00019_A1DeviceId
               }
               , new Object[] {
               T000110_A1DeviceId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000114_A1DeviceId
               }
               , new Object[] {
               T000115_A1DeviceId, T000115_A22GroupName, T000115_A6GroupId
               }
               , new Object[] {
               T000116_A22GroupName
               }
               , new Object[] {
               T000117_A1DeviceId, T000117_A6GroupId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000120_A22GroupName
               }
               , new Object[] {
               T000121_A1DeviceId, T000121_A6GroupId
               }
            }
         );
         AV11Pgmname = "Devices";
      }

      private short nIsMod_2 ;
      private short Z19DeviceType ;
      private short nRC_GXsfl_58 ;
      private short nGXsfl_58_idx=1 ;
      private short Z6GroupId ;
      private short nRcdDeleted_2 ;
      private short nRcdExists_2 ;
      private short GxWebError ;
      private short A6GroupId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A19DeviceType ;
      private short subGriddevices_group_Backcolorstyle ;
      private short subGriddevices_group_Allowselection ;
      private short subGriddevices_group_Allowhovering ;
      private short subGriddevices_group_Allowcollapsing ;
      private short subGriddevices_group_Collapsed ;
      private short nBlankRcdCount2 ;
      private short RcdFound2 ;
      private short nBlankRcdUsr2 ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGriddevices_group_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtDeviceId_Enabled ;
      private int edtDeviceToken_Enabled ;
      private int edtDeviceName_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtGroupId_Enabled ;
      private int edtGroupName_Enabled ;
      private int subGriddevices_group_Selectedindex ;
      private int subGriddevices_group_Selectioncolor ;
      private int subGriddevices_group_Hoveringcolor ;
      private int fRowAdded ;
      private int subGriddevices_group_Backcolor ;
      private int subGriddevices_group_Allbackcolor ;
      private int imgprompt_6_Visible ;
      private int defedtGroupId_Enabled ;
      private int idxLst ;
      private long GRIDDEVICES_GROUP_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_58_idx="0001" ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String cmbDeviceType_Internalname ;
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
      private String edtDeviceId_Internalname ;
      private String edtDeviceId_Jsonclick ;
      private String cmbDeviceType_Jsonclick ;
      private String edtDeviceToken_Internalname ;
      private String edtDeviceName_Internalname ;
      private String edtDeviceName_Jsonclick ;
      private String divGrouptable_Internalname ;
      private String lblTitlegroup_Internalname ;
      private String lblTitlegroup_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGriddevices_group_Header ;
      private String A22GroupName ;
      private String sMode2 ;
      private String edtGroupId_Internalname ;
      private String edtGroupName_Internalname ;
      private String imgprompt_6_Link ;
      private String GX_FocusControl ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z22GroupName ;
      private String imgprompt_6_Internalname ;
      private String sGXsfl_58_fel_idx="0001" ;
      private String subGriddevices_group_Class ;
      private String subGriddevices_group_Linesclass ;
      private String ROClassString ;
      private String edtGroupId_Jsonclick ;
      private String sImgUrl ;
      private String edtGroupName_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGriddevices_group_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_58_Refreshing=false ;
      private bool returnInSub ;
      private String wcpOAV7DeviceId ;
      private String Z1DeviceId ;
      private String Z20DeviceToken ;
      private String Z21DeviceName ;
      private String AV7DeviceId ;
      private String A1DeviceId ;
      private String A20DeviceToken ;
      private String A21DeviceName ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Griddevices_groupContainer ;
      private GXWebRow Griddevices_groupRow ;
      private GXWebColumn Griddevices_groupColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbDeviceType ;
      private IDataStoreProvider pr_default ;
      private String[] T00017_A1DeviceId ;
      private short[] T00017_A19DeviceType ;
      private String[] T00017_A20DeviceToken ;
      private String[] T00017_A21DeviceName ;
      private String[] T00018_A1DeviceId ;
      private String[] T00016_A1DeviceId ;
      private short[] T00016_A19DeviceType ;
      private String[] T00016_A20DeviceToken ;
      private String[] T00016_A21DeviceName ;
      private String[] T00019_A1DeviceId ;
      private String[] T000110_A1DeviceId ;
      private String[] T00015_A1DeviceId ;
      private short[] T00015_A19DeviceType ;
      private String[] T00015_A20DeviceToken ;
      private String[] T00015_A21DeviceName ;
      private String[] T000114_A1DeviceId ;
      private String[] T000115_A1DeviceId ;
      private String[] T000115_A22GroupName ;
      private short[] T000115_A6GroupId ;
      private String[] T00014_A22GroupName ;
      private String[] T000116_A22GroupName ;
      private String[] T000117_A1DeviceId ;
      private short[] T000117_A6GroupId ;
      private String[] T00013_A1DeviceId ;
      private short[] T00013_A6GroupId ;
      private String[] T00012_A1DeviceId ;
      private short[] T00012_A6GroupId ;
      private String[] T000120_A22GroupName ;
      private String[] T000121_A1DeviceId ;
      private short[] T000121_A6GroupId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class devices__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceType",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@DeviceType",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DeviceToken",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@DeviceName",SqlDbType.VarChar,128,0} ,
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0} ,
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@DeviceId",SqlDbType.VarChar,128,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@GroupId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (UPDLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT [GroupName] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new CursorDef("T00015", "SELECT [DeviceId], [DeviceType], [DeviceToken], [DeviceName] FROM [Devices] WITH (UPDLOCK) WHERE [DeviceId] = @DeviceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT [DeviceId], [DeviceType], [DeviceToken], [DeviceName] FROM [Devices] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new CursorDef("T00017", "SELECT TM1.[DeviceId], TM1.[DeviceType], TM1.[DeviceToken], TM1.[DeviceName] FROM [Devices] TM1 WITH (NOLOCK) WHERE TM1.[DeviceId] = @DeviceId ORDER BY TM1.[DeviceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,100,0,true,false )
             ,new CursorDef("T00018", "SELECT [DeviceId] FROM [Devices] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new CursorDef("T00019", "SELECT TOP 1 [DeviceId] FROM [Devices] WITH (NOLOCK) WHERE ( [DeviceId] > @DeviceId) ORDER BY [DeviceId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,true )
             ,new CursorDef("T000110", "SELECT TOP 1 [DeviceId] FROM [Devices] WITH (NOLOCK) WHERE ( [DeviceId] < @DeviceId) ORDER BY [DeviceId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,true )
             ,new CursorDef("T000111", "INSERT INTO [Devices]([DeviceId], [DeviceType], [DeviceToken], [DeviceName]) VALUES(@DeviceId, @DeviceType, @DeviceToken, @DeviceName)", GxErrorMask.GX_NOMASK,prmT000111)
             ,new CursorDef("T000112", "UPDATE [Devices] SET [DeviceType]=@DeviceType, [DeviceToken]=@DeviceToken, [DeviceName]=@DeviceName  WHERE [DeviceId] = @DeviceId", GxErrorMask.GX_NOMASK,prmT000112)
             ,new CursorDef("T000113", "DELETE FROM [Devices]  WHERE [DeviceId] = @DeviceId", GxErrorMask.GX_NOMASK,prmT000113)
             ,new CursorDef("T000114", "SELECT [DeviceId] FROM [Devices] WITH (NOLOCK) ORDER BY [DeviceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,100,0,true,false )
             ,new CursorDef("T000115", "SELECT T1.[DeviceId], T2.[GroupName], T1.[GroupId] FROM ([DevicesGroup] T1 WITH (NOLOCK) INNER JOIN [Group] T2 WITH (NOLOCK) ON T2.[GroupId] = T1.[GroupId]) WHERE T1.[DeviceId] = @DeviceId and T1.[GroupId] = @GroupId ORDER BY T1.[DeviceId], T1.[GroupId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,11,0,true,false )
             ,new CursorDef("T000116", "SELECT [GroupName] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1,0,true,false )
             ,new CursorDef("T000117", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,false )
             ,new CursorDef("T000118", "INSERT INTO [DevicesGroup]([DeviceId], [GroupId]) VALUES(@DeviceId, @GroupId)", GxErrorMask.GX_NOMASK,prmT000118)
             ,new CursorDef("T000119", "DELETE FROM [DevicesGroup]  WHERE [DeviceId] = @DeviceId AND [GroupId] = @GroupId", GxErrorMask.GX_NOMASK,prmT000119)
             ,new CursorDef("T000120", "SELECT [GroupName] FROM [Group] WITH (NOLOCK) WHERE [GroupId] = @GroupId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000120,1,0,true,false )
             ,new CursorDef("T000121", "SELECT [DeviceId], [GroupId] FROM [DevicesGroup] WITH (NOLOCK) WHERE [DeviceId] = @DeviceId ORDER BY [DeviceId], [GroupId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,11,0,true,false )
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
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
