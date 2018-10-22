/*
               File: Users
        Description: Clientes
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:2.51
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
   public class users : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7UsersId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7UsersId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Clientes", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsersName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public users( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public users( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_UsersId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7UsersId = aP1_UsersId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbUsersBusiness = new GXCombobox();
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
         if ( cmbUsersBusiness.ItemCount > 0 )
         {
            A2UsersBusiness = cmbUsersBusiness.getValidValue(A2UsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbUsersBusiness.CurrentValue = StringUtil.RTrim( A2UsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsersBusiness_Internalname, "Values", cmbUsersBusiness.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Clientes", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Users.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Users.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersName_Internalname, "Nombre Usuario", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersName_Internalname, StringUtil.RTrim( A4UsersName), StringUtil.RTrim( context.localUtil.Format( A4UsersName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersName_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersPassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersPassword_Internalname, "Contrasenia", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersPassword_Internalname, StringUtil.RTrim( A5UsersPassword), StringUtil.RTrim( context.localUtil.Format( A5UsersPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersPassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersPassword_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbUsersBusiness_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbUsersBusiness_Internalname, "Empresa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbUsersBusiness, cmbUsersBusiness_Internalname, StringUtil.RTrim( A2UsersBusiness), 1, cmbUsersBusiness_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbUsersBusiness.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "", true, "HLP_Users.htm");
            cmbUsersBusiness.CurrentValue = StringUtil.RTrim( A2UsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsersBusiness_Internalname, "Values", (String)(cmbUsersBusiness.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersNombre_Internalname, "Nombre Completo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsersNombre_Internalname, A43UsersNombre, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, 1, edtUsersNombre_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersDireccion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersDireccion_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsersDireccion_Internalname, A44UsersDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A44UsersDireccion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, 1, edtUsersDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersCURP_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersCURP_Internalname, "CURP", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersCURP_Internalname, StringUtil.RTrim( A45UsersCURP), StringUtil.RTrim( context.localUtil.Format( A45UsersCURP, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersCURP_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersCURP_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgUsersFotografia_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgUsersFotografia_Internalname, "Fotografia", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A46UsersFotografia_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000UsersFotografia_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.PathToRelativeUrl( A46UsersFotografia));
            GxWebStd.gx_bitmap( context, imgUsersFotografia_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgUsersFotografia_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", "", "", 0, A46UsersFotografia_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Users.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.PathToRelativeUrl( A46UsersFotografia)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "IsBlob", StringUtil.BoolToStr( A46UsersFotografia_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsersMatricula_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsersMatricula_Internalname, "Matricula", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersMatricula_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A47UsersMatricula), 8, 0, ",", "")), ((edtUsersMatricula_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A47UsersMatricula), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A47UsersMatricula), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersMatricula_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersMatricula_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Users.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Users.htm");
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
         /* Execute user event: Start */
         E11022 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A4UsersName = cgiGet( edtUsersName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
               A5UsersPassword = cgiGet( edtUsersPassword_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsersPassword", A5UsersPassword);
               cmbUsersBusiness.CurrentValue = cgiGet( cmbUsersBusiness_Internalname);
               A2UsersBusiness = cgiGet( cmbUsersBusiness_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
               A43UsersNombre = cgiGet( edtUsersNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43UsersNombre", A43UsersNombre);
               A44UsersDireccion = cgiGet( edtUsersDireccion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44UsersDireccion", A44UsersDireccion);
               A45UsersCURP = cgiGet( edtUsersCURP_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45UsersCURP", A45UsersCURP);
               A46UsersFotografia = cgiGet( imgUsersFotografia_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46UsersFotografia", A46UsersFotografia);
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsersMatricula_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsersMatricula_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USERSMATRICULA");
                  AnyError = 1;
                  GX_FocusControl = edtUsersMatricula_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A47UsersMatricula = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47UsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(A47UsersMatricula), 8, 0)));
               }
               else
               {
                  A47UsersMatricula = (int)(context.localUtil.CToN( cgiGet( edtUsersMatricula_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47UsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(A47UsersMatricula), 8, 0)));
               }
               /* Read saved values. */
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               Z4UsersName = cgiGet( "Z4UsersName");
               Z5UsersPassword = cgiGet( "Z5UsersPassword");
               Z2UsersBusiness = cgiGet( "Z2UsersBusiness");
               Z43UsersNombre = cgiGet( "Z43UsersNombre");
               Z44UsersDireccion = cgiGet( "Z44UsersDireccion");
               Z45UsersCURP = cgiGet( "Z45UsersCURP");
               Z47UsersMatricula = (int)(context.localUtil.CToN( cgiGet( "Z47UsersMatricula"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7UsersId = (short)(context.localUtil.CToN( cgiGet( "vUSERSID"), ",", "."));
               A3UsersId = (short)(context.localUtil.CToN( cgiGet( "USERSID"), ",", "."));
               A40000UsersFotografia_GXI = cgiGet( "USERSFOTOGRAFIA_GXI");
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgUsersFotografia_Internalname, ref  A46UsersFotografia, ref  A40000UsersFotografia_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Users";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("users:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("users:[SecurityCheckFailed value for]"+"UsersId:"+context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9"));
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
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
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
                     sMode3 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode3;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound3 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_020( ) ;
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
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12022 ();
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
            E12022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll023( ) ;
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
            DisableAttributes023( ) ;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls023( ) ;
            }
            else
            {
               CheckExtendedTable023( ) ;
               CloseExtendedTableCursors023( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption020( )
      {
      }

      protected void E11022( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
      }

      protected void E12022( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwusers.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM023( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z4UsersName = T00023_A4UsersName[0];
               Z5UsersPassword = T00023_A5UsersPassword[0];
               Z2UsersBusiness = T00023_A2UsersBusiness[0];
               Z43UsersNombre = T00023_A43UsersNombre[0];
               Z44UsersDireccion = T00023_A44UsersDireccion[0];
               Z45UsersCURP = T00023_A45UsersCURP[0];
               Z47UsersMatricula = T00023_A47UsersMatricula[0];
            }
            else
            {
               Z4UsersName = A4UsersName;
               Z5UsersPassword = A5UsersPassword;
               Z2UsersBusiness = A2UsersBusiness;
               Z43UsersNombre = A43UsersNombre;
               Z44UsersDireccion = A44UsersDireccion;
               Z45UsersCURP = A45UsersCURP;
               Z47UsersMatricula = A47UsersMatricula;
            }
         }
         if ( GX_JID == -2 )
         {
            Z3UsersId = A3UsersId;
            Z4UsersName = A4UsersName;
            Z5UsersPassword = A5UsersPassword;
            Z2UsersBusiness = A2UsersBusiness;
            Z43UsersNombre = A43UsersNombre;
            Z44UsersDireccion = A44UsersDireccion;
            Z45UsersCURP = A45UsersCURP;
            Z46UsersFotografia = A46UsersFotografia;
            Z40000UsersFotografia_GXI = A40000UsersFotografia_GXI;
            Z47UsersMatricula = A47UsersMatricula;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7UsersId) )
         {
            A3UsersId = AV7UsersId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
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

      protected void Load023( )
      {
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A4UsersName = T00024_A4UsersName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
            A5UsersPassword = T00024_A5UsersPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsersPassword", A5UsersPassword);
            A2UsersBusiness = T00024_A2UsersBusiness[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
            A43UsersNombre = T00024_A43UsersNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43UsersNombre", A43UsersNombre);
            A44UsersDireccion = T00024_A44UsersDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44UsersDireccion", A44UsersDireccion);
            A45UsersCURP = T00024_A45UsersCURP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45UsersCURP", A45UsersCURP);
            A40000UsersFotografia_GXI = T00024_A40000UsersFotografia_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
            A47UsersMatricula = T00024_A47UsersMatricula[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47UsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(A47UsersMatricula), 8, 0)));
            A46UsersFotografia = T00024_A46UsersFotografia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46UsersFotografia", A46UsersFotografia);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
            ZM023( -2) ;
         }
         pr_default.close(2);
         OnLoadActions023( ) ;
      }

      protected void OnLoadActions023( )
      {
         AV11Pgmname = "Users";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable023( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Users";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors023( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey023( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM023( 2) ;
            RcdFound3 = 1;
            A3UsersId = T00023_A3UsersId[0];
            A4UsersName = T00023_A4UsersName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
            A5UsersPassword = T00023_A5UsersPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsersPassword", A5UsersPassword);
            A2UsersBusiness = T00023_A2UsersBusiness[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
            A43UsersNombre = T00023_A43UsersNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43UsersNombre", A43UsersNombre);
            A44UsersDireccion = T00023_A44UsersDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44UsersDireccion", A44UsersDireccion);
            A45UsersCURP = T00023_A45UsersCURP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45UsersCURP", A45UsersCURP);
            A40000UsersFotografia_GXI = T00023_A40000UsersFotografia_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
            A47UsersMatricula = T00023_A47UsersMatricula[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47UsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(A47UsersMatricula), 8, 0)));
            A46UsersFotografia = T00023_A46UsersFotografia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46UsersFotografia", A46UsersFotografia);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
            Z3UsersId = A3UsersId;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load023( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey023( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey023( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey023( ) ;
         if ( RcdFound3 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00026_A3UsersId[0] < A3UsersId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00026_A3UsersId[0] > A3UsersId ) ) )
            {
               A3UsersId = T00026_A3UsersId[0];
               RcdFound3 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00027_A3UsersId[0] > A3UsersId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00027_A3UsersId[0] < A3UsersId ) ) )
            {
               A3UsersId = T00027_A3UsersId[0];
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey023( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsersName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert023( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A3UsersId != Z3UsersId )
               {
                  A3UsersId = Z3UsersId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsersName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update023( ) ;
                  GX_FocusControl = edtUsersName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A3UsersId != Z3UsersId )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsersName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert023( ) ;
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
                     GX_FocusControl = edtUsersName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert023( ) ;
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
         if ( A3UsersId != Z3UsersId )
         {
            A3UsersId = Z3UsersId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "");
            AnyError = 1;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsersName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency023( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Users"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z4UsersName, T00022_A4UsersName[0]) != 0 ) || ( StringUtil.StrCmp(Z5UsersPassword, T00022_A5UsersPassword[0]) != 0 ) || ( StringUtil.StrCmp(Z2UsersBusiness, T00022_A2UsersBusiness[0]) != 0 ) || ( StringUtil.StrCmp(Z43UsersNombre, T00022_A43UsersNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z44UsersDireccion, T00022_A44UsersDireccion[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z45UsersCURP, T00022_A45UsersCURP[0]) != 0 ) || ( Z47UsersMatricula != T00022_A47UsersMatricula[0] ) )
            {
               if ( StringUtil.StrCmp(Z4UsersName, T00022_A4UsersName[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersName");
                  GXUtil.WriteLogRaw("Old: ",Z4UsersName);
                  GXUtil.WriteLogRaw("Current: ",T00022_A4UsersName[0]);
               }
               if ( StringUtil.StrCmp(Z5UsersPassword, T00022_A5UsersPassword[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersPassword");
                  GXUtil.WriteLogRaw("Old: ",Z5UsersPassword);
                  GXUtil.WriteLogRaw("Current: ",T00022_A5UsersPassword[0]);
               }
               if ( StringUtil.StrCmp(Z2UsersBusiness, T00022_A2UsersBusiness[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersBusiness");
                  GXUtil.WriteLogRaw("Old: ",Z2UsersBusiness);
                  GXUtil.WriteLogRaw("Current: ",T00022_A2UsersBusiness[0]);
               }
               if ( StringUtil.StrCmp(Z43UsersNombre, T00022_A43UsersNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersNombre");
                  GXUtil.WriteLogRaw("Old: ",Z43UsersNombre);
                  GXUtil.WriteLogRaw("Current: ",T00022_A43UsersNombre[0]);
               }
               if ( StringUtil.StrCmp(Z44UsersDireccion, T00022_A44UsersDireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z44UsersDireccion);
                  GXUtil.WriteLogRaw("Current: ",T00022_A44UsersDireccion[0]);
               }
               if ( StringUtil.StrCmp(Z45UsersCURP, T00022_A45UsersCURP[0]) != 0 )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersCURP");
                  GXUtil.WriteLogRaw("Old: ",Z45UsersCURP);
                  GXUtil.WriteLogRaw("Current: ",T00022_A45UsersCURP[0]);
               }
               if ( Z47UsersMatricula != T00022_A47UsersMatricula[0] )
               {
                  GXUtil.WriteLog("users:[seudo value changed for attri]"+"UsersMatricula");
                  GXUtil.WriteLogRaw("Old: ",Z47UsersMatricula);
                  GXUtil.WriteLogRaw("Current: ",T00022_A47UsersMatricula[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Users"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert023( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable023( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM023( 0) ;
            CheckOptimisticConcurrency023( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm023( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert023( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00028 */
                     pr_default.execute(6, new Object[] {A4UsersName, A5UsersPassword, A2UsersBusiness, A43UsersNombre, A44UsersDireccion, A45UsersCURP, A46UsersFotografia, A40000UsersFotografia_GXI, A47UsersMatricula});
                     A3UsersId = T00028_A3UsersId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Users") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption020( ) ;
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
               Load023( ) ;
            }
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void Update023( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable023( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency023( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm023( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate023( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00029 */
                     pr_default.execute(7, new Object[] {A4UsersName, A5UsersPassword, A2UsersBusiness, A43UsersNombre, A44UsersDireccion, A45UsersCURP, A47UsersMatricula, A3UsersId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Users") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Users"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate023( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
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
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void DeferredUpdate023( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000210 */
            pr_default.execute(8, new Object[] {A46UsersFotografia, A40000UsersFotografia_GXI, A3UsersId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("Users") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency023( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls023( ) ;
            AfterConfirm023( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete023( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000211 */
                  pr_default.execute(9, new Object[] {A3UsersId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Users") ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel023( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls023( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Users";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000212 */
            pr_default.execute(10, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Nursery"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000213 */
            pr_default.execute(11, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Dinero"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Califas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000215 */
            pr_default.execute(13, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Monedero Electronico"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000216 */
            pr_default.execute(14, new Object[] {A3UsersId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T5"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
         }
      }

      protected void EndLevel023( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete023( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("users",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("users",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart023( )
      {
         /* Scan By routine */
         /* Using cursor T000217 */
         pr_default.execute(15);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound3 = 1;
            A3UsersId = T000217_A3UsersId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext023( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound3 = 1;
            A3UsersId = T000217_A3UsersId[0];
         }
      }

      protected void ScanEnd023( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm023( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert023( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate023( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete023( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete023( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate023( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes023( )
      {
         edtUsersName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersName_Enabled), 5, 0)), true);
         edtUsersPassword_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersPassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersPassword_Enabled), 5, 0)), true);
         cmbUsersBusiness.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsersBusiness_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsersBusiness.Enabled), 5, 0)), true);
         edtUsersNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersNombre_Enabled), 5, 0)), true);
         edtUsersDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersDireccion_Enabled), 5, 0)), true);
         edtUsersCURP_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersCURP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersCURP_Enabled), 5, 0)), true);
         imgUsersFotografia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgUsersFotografia_Enabled), 5, 0)), true);
         edtUsersMatricula_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersMatricula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersMatricula_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes023( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.AddJavascriptSource("gxcfg.js", "?201810111852637", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("users.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7UsersId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Users";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("users:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("users:[SendSecurityCheck value for]"+"UsersId:"+context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z4UsersName", StringUtil.RTrim( Z4UsersName));
         GxWebStd.gx_hidden_field( context, "Z5UsersPassword", StringUtil.RTrim( Z5UsersPassword));
         GxWebStd.gx_hidden_field( context, "Z2UsersBusiness", StringUtil.RTrim( Z2UsersBusiness));
         GxWebStd.gx_hidden_field( context, "Z43UsersNombre", Z43UsersNombre);
         GxWebStd.gx_hidden_field( context, "Z44UsersDireccion", Z44UsersDireccion);
         GxWebStd.gx_hidden_field( context, "Z45UsersCURP", StringUtil.RTrim( Z45UsersCURP));
         GxWebStd.gx_hidden_field( context, "Z47UsersMatricula", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47UsersMatricula), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vUSERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7UsersId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USERSFOTOGRAFIA_GXI", A40000UsersFotografia_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "USERSFOTOGRAFIA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A46UsersFotografia);
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
         return formatLink("users.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7UsersId) ;
      }

      public override String GetPgmname( )
      {
         return "Users" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clientes" ;
      }

      protected void InitializeNonKey023( )
      {
         A4UsersName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
         A5UsersPassword = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsersPassword", A5UsersPassword);
         A2UsersBusiness = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
         A43UsersNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43UsersNombre", A43UsersNombre);
         A44UsersDireccion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44UsersDireccion", A44UsersDireccion);
         A45UsersCURP = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45UsersCURP", A45UsersCURP);
         A46UsersFotografia = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46UsersFotografia", A46UsersFotografia);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
         A40000UsersFotografia_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A46UsersFotografia)) ? A40000UsersFotografia_GXI : context.convertURL( context.PathToRelativeUrl( A46UsersFotografia))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgUsersFotografia_Internalname, "SrcSet", context.GetImageSrcSet( A46UsersFotografia), true);
         A47UsersMatricula = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47UsersMatricula", StringUtil.LTrim( StringUtil.Str( (decimal)(A47UsersMatricula), 8, 0)));
         Z4UsersName = "";
         Z5UsersPassword = "";
         Z2UsersBusiness = "";
         Z43UsersNombre = "";
         Z44UsersDireccion = "";
         Z45UsersCURP = "";
         Z47UsersMatricula = 0;
      }

      protected void InitAll023( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         InitializeNonKey023( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201810111852656", true);
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
         context.AddJavascriptSource("users.js", "?201810111852657", false);
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
         edtUsersName_Internalname = "USERSNAME";
         edtUsersPassword_Internalname = "USERSPASSWORD";
         cmbUsersBusiness_Internalname = "USERSBUSINESS";
         edtUsersNombre_Internalname = "USERSNOMBRE";
         edtUsersDireccion_Internalname = "USERSDIRECCION";
         edtUsersCURP_Internalname = "USERSCURP";
         imgUsersFotografia_Internalname = "USERSFOTOGRAFIA";
         edtUsersMatricula_Internalname = "USERSMATRICULA";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
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
         Form.Caption = "Clientes";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUsersMatricula_Jsonclick = "";
         edtUsersMatricula_Enabled = 1;
         imgUsersFotografia_Enabled = 1;
         edtUsersCURP_Jsonclick = "";
         edtUsersCURP_Enabled = 1;
         edtUsersDireccion_Enabled = 1;
         edtUsersNombre_Enabled = 1;
         cmbUsersBusiness_Jsonclick = "";
         cmbUsersBusiness.Enabled = 1;
         edtUsersPassword_Jsonclick = "";
         edtUsersPassword_Enabled = 1;
         edtUsersName_Jsonclick = "";
         edtUsersName_Enabled = 1;
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
         cmbUsersBusiness.Name = "USERSBUSINESS";
         cmbUsersBusiness.WebTags = "";
         cmbUsersBusiness.addItem("", "(Ninguno)", 0);
         cmbUsersBusiness.addItem("Credi OK", "Credi OK", 0);
         cmbUsersBusiness.addItem("Prexa", "Prexa", 0);
         cmbUsersBusiness.addItem("GDM3", "GDM3", 0);
         if ( cmbUsersBusiness.ItemCount > 0 )
         {
            A2UsersBusiness = cmbUsersBusiness.getValidValue(A2UsersBusiness);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2UsersBusiness", A2UsersBusiness);
         }
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7UsersId',fld:'vUSERSID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7UsersId',fld:'vUSERSID',pic:'ZZZ9',hsh:true},{av:'A3UsersId',fld:'USERSID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12022',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z4UsersName = "";
         Z5UsersPassword = "";
         Z2UsersBusiness = "";
         Z43UsersNombre = "";
         Z44UsersDireccion = "";
         Z45UsersCURP = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A2UsersBusiness = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A4UsersName = "";
         A5UsersPassword = "";
         A43UsersNombre = "";
         A44UsersDireccion = "";
         A45UsersCURP = "";
         A46UsersFotografia = "";
         A40000UsersFotografia_GXI = "";
         sImgUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode3 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         Z46UsersFotografia = "";
         Z40000UsersFotografia_GXI = "";
         T00024_A3UsersId = new short[1] ;
         T00024_A4UsersName = new String[] {""} ;
         T00024_A5UsersPassword = new String[] {""} ;
         T00024_A2UsersBusiness = new String[] {""} ;
         T00024_A43UsersNombre = new String[] {""} ;
         T00024_A44UsersDireccion = new String[] {""} ;
         T00024_A45UsersCURP = new String[] {""} ;
         T00024_A40000UsersFotografia_GXI = new String[] {""} ;
         T00024_A47UsersMatricula = new int[1] ;
         T00024_A46UsersFotografia = new String[] {""} ;
         T00025_A3UsersId = new short[1] ;
         T00023_A3UsersId = new short[1] ;
         T00023_A4UsersName = new String[] {""} ;
         T00023_A5UsersPassword = new String[] {""} ;
         T00023_A2UsersBusiness = new String[] {""} ;
         T00023_A43UsersNombre = new String[] {""} ;
         T00023_A44UsersDireccion = new String[] {""} ;
         T00023_A45UsersCURP = new String[] {""} ;
         T00023_A40000UsersFotografia_GXI = new String[] {""} ;
         T00023_A47UsersMatricula = new int[1] ;
         T00023_A46UsersFotografia = new String[] {""} ;
         T00026_A3UsersId = new short[1] ;
         T00027_A3UsersId = new short[1] ;
         T00022_A3UsersId = new short[1] ;
         T00022_A4UsersName = new String[] {""} ;
         T00022_A5UsersPassword = new String[] {""} ;
         T00022_A2UsersBusiness = new String[] {""} ;
         T00022_A43UsersNombre = new String[] {""} ;
         T00022_A44UsersDireccion = new String[] {""} ;
         T00022_A45UsersCURP = new String[] {""} ;
         T00022_A40000UsersFotografia_GXI = new String[] {""} ;
         T00022_A47UsersMatricula = new int[1] ;
         T00022_A46UsersFotografia = new String[] {""} ;
         T00028_A3UsersId = new short[1] ;
         T000212_A15NurseryId = new short[1] ;
         T000213_A14DineroId = new short[1] ;
         T000214_A13CalifasId = new short[1] ;
         T000215_A9MonederoElectronicoId = new short[1] ;
         T000216_A7BalanceId = new short[1] ;
         T000217_A3UsersId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.users__default(),
            new Object[][] {
                new Object[] {
               T00022_A3UsersId, T00022_A4UsersName, T00022_A5UsersPassword, T00022_A2UsersBusiness, T00022_A43UsersNombre, T00022_A44UsersDireccion, T00022_A45UsersCURP, T00022_A40000UsersFotografia_GXI, T00022_A47UsersMatricula, T00022_A46UsersFotografia
               }
               , new Object[] {
               T00023_A3UsersId, T00023_A4UsersName, T00023_A5UsersPassword, T00023_A2UsersBusiness, T00023_A43UsersNombre, T00023_A44UsersDireccion, T00023_A45UsersCURP, T00023_A40000UsersFotografia_GXI, T00023_A47UsersMatricula, T00023_A46UsersFotografia
               }
               , new Object[] {
               T00024_A3UsersId, T00024_A4UsersName, T00024_A5UsersPassword, T00024_A2UsersBusiness, T00024_A43UsersNombre, T00024_A44UsersDireccion, T00024_A45UsersCURP, T00024_A40000UsersFotografia_GXI, T00024_A47UsersMatricula, T00024_A46UsersFotografia
               }
               , new Object[] {
               T00025_A3UsersId
               }
               , new Object[] {
               T00026_A3UsersId
               }
               , new Object[] {
               T00027_A3UsersId
               }
               , new Object[] {
               T00028_A3UsersId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000212_A15NurseryId
               }
               , new Object[] {
               T000213_A14DineroId
               }
               , new Object[] {
               T000214_A13CalifasId
               }
               , new Object[] {
               T000215_A9MonederoElectronicoId
               }
               , new Object[] {
               T000216_A7BalanceId
               }
               , new Object[] {
               T000217_A3UsersId
               }
            }
         );
         AV11Pgmname = "Users";
      }

      private short wcpOAV7UsersId ;
      private short Z3UsersId ;
      private short GxWebError ;
      private short AV7UsersId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A3UsersId ;
      private short RcdFound3 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int Z47UsersMatricula ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsersName_Enabled ;
      private int edtUsersPassword_Enabled ;
      private int edtUsersNombre_Enabled ;
      private int edtUsersDireccion_Enabled ;
      private int edtUsersCURP_Enabled ;
      private int imgUsersFotografia_Enabled ;
      private int A47UsersMatricula ;
      private int edtUsersMatricula_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z4UsersName ;
      private String Z5UsersPassword ;
      private String Z2UsersBusiness ;
      private String Z45UsersCURP ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsersName_Internalname ;
      private String A2UsersBusiness ;
      private String cmbUsersBusiness_Internalname ;
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
      private String A4UsersName ;
      private String edtUsersName_Jsonclick ;
      private String edtUsersPassword_Internalname ;
      private String A5UsersPassword ;
      private String edtUsersPassword_Jsonclick ;
      private String cmbUsersBusiness_Jsonclick ;
      private String edtUsersNombre_Internalname ;
      private String edtUsersDireccion_Internalname ;
      private String edtUsersCURP_Internalname ;
      private String A45UsersCURP ;
      private String edtUsersCURP_Jsonclick ;
      private String imgUsersFotografia_Internalname ;
      private String sImgUrl ;
      private String edtUsersMatricula_Internalname ;
      private String edtUsersMatricula_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A46UsersFotografia_IsBlob ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z43UsersNombre ;
      private String Z44UsersDireccion ;
      private String A43UsersNombre ;
      private String A44UsersDireccion ;
      private String A40000UsersFotografia_GXI ;
      private String Z40000UsersFotografia_GXI ;
      private String A46UsersFotografia ;
      private String Z46UsersFotografia ;
      private IGxSession AV10WebSession ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbUsersBusiness ;
      private IDataStoreProvider pr_default ;
      private short[] T00024_A3UsersId ;
      private String[] T00024_A4UsersName ;
      private String[] T00024_A5UsersPassword ;
      private String[] T00024_A2UsersBusiness ;
      private String[] T00024_A43UsersNombre ;
      private String[] T00024_A44UsersDireccion ;
      private String[] T00024_A45UsersCURP ;
      private String[] T00024_A40000UsersFotografia_GXI ;
      private int[] T00024_A47UsersMatricula ;
      private String[] T00024_A46UsersFotografia ;
      private short[] T00025_A3UsersId ;
      private short[] T00023_A3UsersId ;
      private String[] T00023_A4UsersName ;
      private String[] T00023_A5UsersPassword ;
      private String[] T00023_A2UsersBusiness ;
      private String[] T00023_A43UsersNombre ;
      private String[] T00023_A44UsersDireccion ;
      private String[] T00023_A45UsersCURP ;
      private String[] T00023_A40000UsersFotografia_GXI ;
      private int[] T00023_A47UsersMatricula ;
      private String[] T00023_A46UsersFotografia ;
      private short[] T00026_A3UsersId ;
      private short[] T00027_A3UsersId ;
      private short[] T00022_A3UsersId ;
      private String[] T00022_A4UsersName ;
      private String[] T00022_A5UsersPassword ;
      private String[] T00022_A2UsersBusiness ;
      private String[] T00022_A43UsersNombre ;
      private String[] T00022_A44UsersDireccion ;
      private String[] T00022_A45UsersCURP ;
      private String[] T00022_A40000UsersFotografia_GXI ;
      private int[] T00022_A47UsersMatricula ;
      private String[] T00022_A46UsersFotografia ;
      private short[] T00028_A3UsersId ;
      private short[] T000212_A15NurseryId ;
      private short[] T000213_A14DineroId ;
      private short[] T000214_A13CalifasId ;
      private short[] T000215_A9MonederoElectronicoId ;
      private short[] T000216_A7BalanceId ;
      private short[] T000217_A3UsersId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class users__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@UsersName",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersPassword",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersBusiness",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersNombre",SqlDbType.VarChar,200,0} ,
          new Object[] {"@UsersDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@UsersCURP",SqlDbType.Char,18,0} ,
          new Object[] {"@UsersFotografia",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@UsersFotografia_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@UsersMatricula",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@UsersName",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersPassword",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersBusiness",SqlDbType.Char,20,0} ,
          new Object[] {"@UsersNombre",SqlDbType.VarChar,200,0} ,
          new Object[] {"@UsersDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@UsersCURP",SqlDbType.Char,18,0} ,
          new Object[] {"@UsersMatricula",SqlDbType.Int,8,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@UsersFotografia",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@UsersFotografia_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000217 ;
          prmT000217 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [UsersId], [UsersName], [UsersPassword], [UsersBusiness], [UsersNombre], [UsersDireccion], [UsersCURP], [UsersFotografia_GXI], [UsersMatricula], [UsersFotografia] FROM [Users] WITH (UPDLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT [UsersId], [UsersName], [UsersPassword], [UsersBusiness], [UsersNombre], [UsersDireccion], [UsersCURP], [UsersFotografia_GXI], [UsersMatricula], [UsersFotografia] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT TM1.[UsersId], TM1.[UsersName], TM1.[UsersPassword], TM1.[UsersBusiness], TM1.[UsersNombre], TM1.[UsersDireccion], TM1.[UsersCURP], TM1.[UsersFotografia_GXI], TM1.[UsersMatricula], TM1.[UsersFotografia] FROM [Users] TM1 WITH (NOLOCK) WHERE TM1.[UsersId] = @UsersId ORDER BY TM1.[UsersId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,100,0,true,false )
             ,new CursorDef("T00025", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,false )
             ,new CursorDef("T00026", "SELECT TOP 1 [UsersId] FROM [Users] WITH (NOLOCK) WHERE ( [UsersId] > @UsersId) ORDER BY [UsersId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,true )
             ,new CursorDef("T00027", "SELECT TOP 1 [UsersId] FROM [Users] WITH (NOLOCK) WHERE ( [UsersId] < @UsersId) ORDER BY [UsersId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,true )
             ,new CursorDef("T00028", "INSERT INTO [Users]([UsersName], [UsersPassword], [UsersBusiness], [UsersNombre], [UsersDireccion], [UsersCURP], [UsersFotografia], [UsersFotografia_GXI], [UsersMatricula]) VALUES(@UsersName, @UsersPassword, @UsersBusiness, @UsersNombre, @UsersDireccion, @UsersCURP, @UsersFotografia, @UsersFotografia_GXI, @UsersMatricula); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00028)
             ,new CursorDef("T00029", "UPDATE [Users] SET [UsersName]=@UsersName, [UsersPassword]=@UsersPassword, [UsersBusiness]=@UsersBusiness, [UsersNombre]=@UsersNombre, [UsersDireccion]=@UsersDireccion, [UsersCURP]=@UsersCURP, [UsersMatricula]=@UsersMatricula  WHERE [UsersId] = @UsersId", GxErrorMask.GX_NOMASK,prmT00029)
             ,new CursorDef("T000210", "UPDATE [Users] SET [UsersFotografia]=@UsersFotografia, [UsersFotografia_GXI]=@UsersFotografia_GXI  WHERE [UsersId] = @UsersId", GxErrorMask.GX_NOMASK,prmT000210)
             ,new CursorDef("T000211", "DELETE FROM [Users]  WHERE [UsersId] = @UsersId", GxErrorMask.GX_NOMASK,prmT000211)
             ,new CursorDef("T000212", "SELECT TOP 1 [NurseryId] FROM [Nursery] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,1,0,true,true )
             ,new CursorDef("T000213", "SELECT TOP 1 [DineroId] FROM [Dinero] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1,0,true,true )
             ,new CursorDef("T000214", "SELECT TOP 1 [CalifasId] FROM [Califas] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1,0,true,true )
             ,new CursorDef("T000215", "SELECT TOP 1 [MonederoElectronicoId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,true )
             ,new CursorDef("T000216", "SELECT TOP 1 [BalanceId] FROM [Balance] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,1,0,true,true )
             ,new CursorDef("T000217", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) ORDER BY [UsersId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000217,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 18) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaUri(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(8)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 18) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaUri(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(8)) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 18) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaUri(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(8)) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameterBlob(7, (String)parms[6], false);
                stmt.SetParameterMultimedia(8, (String)parms[7], (String)parms[6], "Users", "UsersFotografia");
                stmt.SetParameter(9, (int)parms[8]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                return;
             case 8 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Users", "UsersFotografia");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
