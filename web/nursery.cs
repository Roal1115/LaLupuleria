/*
               File: Nursery
        Description: Nursery
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:29.52
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
   public class nursery : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A3UsersId) ;
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
            Form.Meta.addItem("description", "Nursery", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public nursery( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public nursery( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Nursery", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Nursery.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Nursery.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersId_Internalname, "Clientes Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), ((edtUsersId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")) : context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_Nursery.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNurseryReport_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNurseryReport_Internalname, "Report", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtNurseryReport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A66NurseryReport), 6, 0, ",", "")), ((edtNurseryReport_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A66NurseryReport), "ZZZZZ9")) : context.localUtil.Format( (decimal)(A66NurseryReport), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNurseryReport_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNurseryReport_Enabled, 0, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNurseryDr_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNurseryDr_Internalname, "Dr", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtNurseryDr_Internalname, StringUtil.RTrim( A67NurseryDr), StringUtil.RTrim( context.localUtil.Format( A67NurseryDr, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNurseryDr_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNurseryDr_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNurseryReason_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNurseryReason_Internalname, "Reason", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtNurseryReason_Internalname, StringUtil.RTrim( A68NurseryReason), "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, 1, edtNurseryReason_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "250", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Nursery.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Nursery.htm");
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtNurseryReport_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNurseryReport_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NURSERYREPORT");
                  AnyError = 1;
                  GX_FocusControl = edtNurseryReport_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A66NurseryReport = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66NurseryReport", StringUtil.LTrim( StringUtil.Str( (decimal)(A66NurseryReport), 6, 0)));
               }
               else
               {
                  A66NurseryReport = (int)(context.localUtil.CToN( cgiGet( edtNurseryReport_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66NurseryReport", StringUtil.LTrim( StringUtil.Str( (decimal)(A66NurseryReport), 6, 0)));
               }
               A67NurseryDr = cgiGet( edtNurseryDr_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67NurseryDr", A67NurseryDr);
               A68NurseryReason = cgiGet( edtNurseryReason_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68NurseryReason", A68NurseryReason);
               /* Read saved values. */
               Z15NurseryId = (short)(context.localUtil.CToN( cgiGet( "Z15NurseryId"), ",", "."));
               Z66NurseryReport = (int)(context.localUtil.CToN( cgiGet( "Z66NurseryReport"), ",", "."));
               Z67NurseryDr = cgiGet( "Z67NurseryDr");
               Z68NurseryReason = cgiGet( "Z68NurseryReason");
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               A15NurseryId = (short)(context.localUtil.CToN( cgiGet( "NURSERYID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Nursery";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A15NurseryId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("nursery:[SecurityCheckFailed value for]"+"NurseryId:"+context.localUtil.Format( (decimal)(A15NurseryId), "ZZZ9"));
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
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A15NurseryId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NurseryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15NurseryId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0713( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes0713( ) ;
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

      protected void ResetCaption070( )
      {
      }

      protected void ZM0713( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z66NurseryReport = T00073_A66NurseryReport[0];
               Z67NurseryDr = T00073_A67NurseryDr[0];
               Z68NurseryReason = T00073_A68NurseryReason[0];
               Z3UsersId = T00073_A3UsersId[0];
            }
            else
            {
               Z66NurseryReport = A66NurseryReport;
               Z67NurseryDr = A67NurseryDr;
               Z68NurseryReason = A68NurseryReason;
               Z3UsersId = A3UsersId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z15NurseryId = A15NurseryId;
            Z66NurseryReport = A66NurseryReport;
            Z67NurseryDr = A67NurseryDr;
            Z68NurseryReason = A68NurseryReason;
            Z3UsersId = A3UsersId;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USERSID"+"'), id:'"+"USERSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
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
      }

      protected void Load0713( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A15NurseryId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound13 = 1;
            A66NurseryReport = T00075_A66NurseryReport[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66NurseryReport", StringUtil.LTrim( StringUtil.Str( (decimal)(A66NurseryReport), 6, 0)));
            A67NurseryDr = T00075_A67NurseryDr[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67NurseryDr", A67NurseryDr);
            A68NurseryReason = T00075_A68NurseryReason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68NurseryReason", A68NurseryReason);
            A3UsersId = T00075_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            ZM0713( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0713( ) ;
      }

      protected void OnLoadActions0713( )
      {
      }

      protected void CheckExtendedTable0713( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0713( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A3UsersId )
      {
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0713( )
      {
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A15NurseryId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A15NurseryId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0713( 1) ;
            RcdFound13 = 1;
            A15NurseryId = T00073_A15NurseryId[0];
            A66NurseryReport = T00073_A66NurseryReport[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66NurseryReport", StringUtil.LTrim( StringUtil.Str( (decimal)(A66NurseryReport), 6, 0)));
            A67NurseryDr = T00073_A67NurseryDr[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67NurseryDr", A67NurseryDr);
            A68NurseryReason = T00073_A68NurseryReason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68NurseryReason", A68NurseryReason);
            A3UsersId = T00073_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            Z15NurseryId = A15NurseryId;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0713( ) ;
            if ( AnyError == 1 )
            {
               RcdFound13 = 0;
               InitializeNonKey0713( ) ;
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0713( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0713( ) ;
         if ( RcdFound13 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound13 = 0;
         /* Using cursor T00078 */
         pr_default.execute(6, new Object[] {A15NurseryId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00078_A15NurseryId[0] < A15NurseryId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00078_A15NurseryId[0] > A15NurseryId ) ) )
            {
               A15NurseryId = T00078_A15NurseryId[0];
               RcdFound13 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound13 = 0;
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A15NurseryId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00079_A15NurseryId[0] > A15NurseryId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00079_A15NurseryId[0] < A15NurseryId ) ) )
            {
               A15NurseryId = T00079_A15NurseryId[0];
               RcdFound13 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0713( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0713( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound13 == 1 )
            {
               if ( A15NurseryId != Z15NurseryId )
               {
                  A15NurseryId = Z15NurseryId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NurseryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15NurseryId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0713( ) ;
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A15NurseryId != Z15NurseryId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0713( ) ;
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
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsersId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0713( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A15NurseryId != Z15NurseryId )
         {
            A15NurseryId = Z15NurseryId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NurseryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15NurseryId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "");
            AnyError = 1;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0713( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0713( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0713( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound13 != 0 )
            {
               ScanNext0713( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0713( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0713( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A15NurseryId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Nursery"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z66NurseryReport != T00072_A66NurseryReport[0] ) || ( StringUtil.StrCmp(Z67NurseryDr, T00072_A67NurseryDr[0]) != 0 ) || ( StringUtil.StrCmp(Z68NurseryReason, T00072_A68NurseryReason[0]) != 0 ) || ( Z3UsersId != T00072_A3UsersId[0] ) )
            {
               if ( Z66NurseryReport != T00072_A66NurseryReport[0] )
               {
                  GXUtil.WriteLog("nursery:[seudo value changed for attri]"+"NurseryReport");
                  GXUtil.WriteLogRaw("Old: ",Z66NurseryReport);
                  GXUtil.WriteLogRaw("Current: ",T00072_A66NurseryReport[0]);
               }
               if ( StringUtil.StrCmp(Z67NurseryDr, T00072_A67NurseryDr[0]) != 0 )
               {
                  GXUtil.WriteLog("nursery:[seudo value changed for attri]"+"NurseryDr");
                  GXUtil.WriteLogRaw("Old: ",Z67NurseryDr);
                  GXUtil.WriteLogRaw("Current: ",T00072_A67NurseryDr[0]);
               }
               if ( StringUtil.StrCmp(Z68NurseryReason, T00072_A68NurseryReason[0]) != 0 )
               {
                  GXUtil.WriteLog("nursery:[seudo value changed for attri]"+"NurseryReason");
                  GXUtil.WriteLogRaw("Old: ",Z68NurseryReason);
                  GXUtil.WriteLogRaw("Current: ",T00072_A68NurseryReason[0]);
               }
               if ( Z3UsersId != T00072_A3UsersId[0] )
               {
                  GXUtil.WriteLog("nursery:[seudo value changed for attri]"+"UsersId");
                  GXUtil.WriteLogRaw("Old: ",Z3UsersId);
                  GXUtil.WriteLogRaw("Current: ",T00072_A3UsersId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Nursery"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0713( )
      {
         BeforeValidate0713( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0713( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0713( 0) ;
            CheckOptimisticConcurrency0713( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0713( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0713( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000710 */
                     pr_default.execute(8, new Object[] {A66NurseryReport, A67NurseryDr, A68NurseryReason, A3UsersId});
                     A15NurseryId = T000710_A15NurseryId[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Nursery") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption070( ) ;
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
               Load0713( ) ;
            }
            EndLevel0713( ) ;
         }
         CloseExtendedTableCursors0713( ) ;
      }

      protected void Update0713( )
      {
         BeforeValidate0713( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0713( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0713( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0713( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0713( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000711 */
                     pr_default.execute(9, new Object[] {A66NurseryReport, A67NurseryDr, A68NurseryReason, A3UsersId, A15NurseryId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Nursery") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Nursery"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0713( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption070( ) ;
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
            EndLevel0713( ) ;
         }
         CloseExtendedTableCursors0713( ) ;
      }

      protected void DeferredUpdate0713( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0713( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0713( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0713( ) ;
            AfterConfirm0713( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0713( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000712 */
                  pr_default.execute(10, new Object[] {A15NurseryId});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Nursery") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound13 == 0 )
                        {
                           InitAll0713( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption070( ) ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0713( ) ;
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0713( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0713( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0713( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("nursery",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("nursery",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0713( )
      {
         /* Using cursor T000713 */
         pr_default.execute(11);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A15NurseryId = T000713_A15NurseryId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0713( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A15NurseryId = T000713_A15NurseryId[0];
         }
      }

      protected void ScanEnd0713( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0713( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0713( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0713( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0713( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0713( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0713( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0713( )
      {
         edtUsersId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         edtNurseryReport_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNurseryReport_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNurseryReport_Enabled), 5, 0)), true);
         edtNurseryDr_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNurseryDr_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNurseryDr_Enabled), 5, 0)), true);
         edtNurseryReason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNurseryReason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNurseryReason_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0713( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
      {
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118523155", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("nursery.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "Nursery";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A15NurseryId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("nursery:[SendSecurityCheck value for]"+"NurseryId:"+context.localUtil.Format( (decimal)(A15NurseryId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z15NurseryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15NurseryId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z66NurseryReport", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z66NurseryReport), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z67NurseryDr", StringUtil.RTrim( Z67NurseryDr));
         GxWebStd.gx_hidden_field( context, "Z68NurseryReason", StringUtil.RTrim( Z68NurseryReason));
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "NURSERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15NurseryId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("nursery.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Nursery" ;
      }

      public override String GetPgmdesc( )
      {
         return "Nursery" ;
      }

      protected void InitializeNonKey0713( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         A66NurseryReport = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66NurseryReport", StringUtil.LTrim( StringUtil.Str( (decimal)(A66NurseryReport), 6, 0)));
         A67NurseryDr = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67NurseryDr", A67NurseryDr);
         A68NurseryReason = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68NurseryReason", A68NurseryReason);
         Z66NurseryReport = 0;
         Z67NurseryDr = "";
         Z68NurseryReason = "";
         Z3UsersId = 0;
      }

      protected void InitAll0713( )
      {
         A15NurseryId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NurseryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15NurseryId), 4, 0)));
         InitializeNonKey0713( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118523164", true);
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
         context.AddJavascriptSource("nursery.js", "?2018101118523164", false);
         /* End function include_jscripts */
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
         edtUsersId_Internalname = "USERSID";
         edtNurseryReport_Internalname = "NURSERYREPORT";
         edtNurseryDr_Internalname = "NURSERYDR";
         edtNurseryReason_Internalname = "NURSERYREASON";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_3_Internalname = "PROMPT_3";
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
         Form.Caption = "Nursery";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtNurseryReason_Enabled = 1;
         edtNurseryDr_Jsonclick = "";
         edtNurseryDr_Enabled = 1;
         edtNurseryReport_Jsonclick = "";
         edtNurseryReport_Enabled = 1;
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         edtUsersId_Jsonclick = "";
         edtUsersId_Enabled = 1;
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

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtUsersId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Usersid( short GX_Parm1 )
      {
         A3UsersId = GX_Parm1;
         /* Using cursor T000714 */
         pr_default.execute(12, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
         }
         pr_default.close(12);
         dynload_actions( ) ;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A15NurseryId',fld:'NURSERYID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z67NurseryDr = "";
         Z68NurseryReason = "";
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
         sImgUrl = "";
         A67NurseryDr = "";
         A68NurseryReason = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00075_A15NurseryId = new short[1] ;
         T00075_A66NurseryReport = new int[1] ;
         T00075_A67NurseryDr = new String[] {""} ;
         T00075_A68NurseryReason = new String[] {""} ;
         T00075_A3UsersId = new short[1] ;
         T00074_A3UsersId = new short[1] ;
         T00076_A3UsersId = new short[1] ;
         T00077_A15NurseryId = new short[1] ;
         T00073_A15NurseryId = new short[1] ;
         T00073_A66NurseryReport = new int[1] ;
         T00073_A67NurseryDr = new String[] {""} ;
         T00073_A68NurseryReason = new String[] {""} ;
         T00073_A3UsersId = new short[1] ;
         sMode13 = "";
         T00078_A15NurseryId = new short[1] ;
         T00079_A15NurseryId = new short[1] ;
         T00072_A15NurseryId = new short[1] ;
         T00072_A66NurseryReport = new int[1] ;
         T00072_A67NurseryDr = new String[] {""} ;
         T00072_A68NurseryReason = new String[] {""} ;
         T00072_A3UsersId = new short[1] ;
         T000710_A15NurseryId = new short[1] ;
         T000713_A15NurseryId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000714_A3UsersId = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.nursery__default(),
            new Object[][] {
                new Object[] {
               T00072_A15NurseryId, T00072_A66NurseryReport, T00072_A67NurseryDr, T00072_A68NurseryReason, T00072_A3UsersId
               }
               , new Object[] {
               T00073_A15NurseryId, T00073_A66NurseryReport, T00073_A67NurseryDr, T00073_A68NurseryReason, T00073_A3UsersId
               }
               , new Object[] {
               T00074_A3UsersId
               }
               , new Object[] {
               T00075_A15NurseryId, T00075_A66NurseryReport, T00075_A67NurseryDr, T00075_A68NurseryReason, T00075_A3UsersId
               }
               , new Object[] {
               T00076_A3UsersId
               }
               , new Object[] {
               T00077_A15NurseryId
               }
               , new Object[] {
               T00078_A15NurseryId
               }
               , new Object[] {
               T00079_A15NurseryId
               }
               , new Object[] {
               T000710_A15NurseryId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000713_A15NurseryId
               }
               , new Object[] {
               T000714_A3UsersId
               }
            }
         );
      }

      private short Z15NurseryId ;
      private short Z3UsersId ;
      private short GxWebError ;
      private short A3UsersId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A15NurseryId ;
      private short GX_JID ;
      private short RcdFound13 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z66NurseryReport ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsersId_Enabled ;
      private int imgprompt_3_Visible ;
      private int A66NurseryReport ;
      private int edtNurseryReport_Enabled ;
      private int edtNurseryDr_Enabled ;
      private int edtNurseryReason_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String Z67NurseryDr ;
      private String Z68NurseryReason ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsersId_Internalname ;
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
      private String edtUsersId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_3_Internalname ;
      private String imgprompt_3_Link ;
      private String edtNurseryReport_Internalname ;
      private String edtNurseryReport_Jsonclick ;
      private String edtNurseryDr_Internalname ;
      private String A67NurseryDr ;
      private String edtNurseryDr_Jsonclick ;
      private String edtNurseryReason_Internalname ;
      private String A68NurseryReason ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode13 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00075_A15NurseryId ;
      private int[] T00075_A66NurseryReport ;
      private String[] T00075_A67NurseryDr ;
      private String[] T00075_A68NurseryReason ;
      private short[] T00075_A3UsersId ;
      private short[] T00074_A3UsersId ;
      private short[] T00076_A3UsersId ;
      private short[] T00077_A15NurseryId ;
      private short[] T00073_A15NurseryId ;
      private int[] T00073_A66NurseryReport ;
      private String[] T00073_A67NurseryDr ;
      private String[] T00073_A68NurseryReason ;
      private short[] T00073_A3UsersId ;
      private short[] T00078_A15NurseryId ;
      private short[] T00079_A15NurseryId ;
      private short[] T00072_A15NurseryId ;
      private int[] T00072_A66NurseryReport ;
      private String[] T00072_A67NurseryDr ;
      private String[] T00072_A68NurseryReason ;
      private short[] T00072_A3UsersId ;
      private short[] T000710_A15NurseryId ;
      private short[] T000713_A15NurseryId ;
      private short[] T000714_A3UsersId ;
      private GXWebForm Form ;
   }

   public class nursery__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@NurseryReport",SqlDbType.Int,6,0} ,
          new Object[] {"@NurseryDr",SqlDbType.Char,60,0} ,
          new Object[] {"@NurseryReason",SqlDbType.Char,250,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          new Object[] {"@NurseryReport",SqlDbType.Int,6,0} ,
          new Object[] {"@NurseryDr",SqlDbType.Char,60,0} ,
          new Object[] {"@NurseryReason",SqlDbType.Char,250,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@NurseryId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          } ;
          Object[] prmT000714 ;
          prmT000714 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [NurseryId], [NurseryReport], [NurseryDr], [NurseryReason], [UsersId] FROM [Nursery] WITH (UPDLOCK) WHERE [NurseryId] = @NurseryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT [NurseryId], [NurseryReport], [NurseryDr], [NurseryReason], [UsersId] FROM [Nursery] WITH (NOLOCK) WHERE [NurseryId] = @NurseryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1,0,true,false )
             ,new CursorDef("T00075", "SELECT TM1.[NurseryId], TM1.[NurseryReport], TM1.[NurseryDr], TM1.[NurseryReason], TM1.[UsersId] FROM [Nursery] TM1 WITH (NOLOCK) WHERE TM1.[NurseryId] = @NurseryId ORDER BY TM1.[NurseryId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,100,0,true,false )
             ,new CursorDef("T00076", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,false )
             ,new CursorDef("T00077", "SELECT [NurseryId] FROM [Nursery] WITH (NOLOCK) WHERE [NurseryId] = @NurseryId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,false )
             ,new CursorDef("T00078", "SELECT TOP 1 [NurseryId] FROM [Nursery] WITH (NOLOCK) WHERE ( [NurseryId] > @NurseryId) ORDER BY [NurseryId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,1,0,true,true )
             ,new CursorDef("T00079", "SELECT TOP 1 [NurseryId] FROM [Nursery] WITH (NOLOCK) WHERE ( [NurseryId] < @NurseryId) ORDER BY [NurseryId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,1,0,true,true )
             ,new CursorDef("T000710", "INSERT INTO [Nursery]([NurseryReport], [NurseryDr], [NurseryReason], [UsersId]) VALUES(@NurseryReport, @NurseryDr, @NurseryReason, @UsersId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000710)
             ,new CursorDef("T000711", "UPDATE [Nursery] SET [NurseryReport]=@NurseryReport, [NurseryDr]=@NurseryDr, [NurseryReason]=@NurseryReason, [UsersId]=@UsersId  WHERE [NurseryId] = @NurseryId", GxErrorMask.GX_NOMASK,prmT000711)
             ,new CursorDef("T000712", "DELETE FROM [Nursery]  WHERE [NurseryId] = @NurseryId", GxErrorMask.GX_NOMASK,prmT000712)
             ,new CursorDef("T000713", "SELECT [NurseryId] FROM [Nursery] WITH (NOLOCK) ORDER BY [NurseryId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000713,100,0,true,false )
             ,new CursorDef("T000714", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000714,1,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 250) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
