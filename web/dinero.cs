/*
               File: Dinero
        Description: Dinero
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:26.63
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
   public class dinero : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A3UsersId) ;
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
               AV7DineroId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7DineroId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDINEROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7DineroId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Dinero", 0) ;
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

      public dinero( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public dinero( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_DineroId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7DineroId = aP1_DineroId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Dinero", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Dinero.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Dinero.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_Dinero.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDineroTotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDineroTotal_Internalname, "Total", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDineroTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A64DineroTotal, 10, 2, ",", "")), ((edtDineroTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A64DineroTotal, "ZZZ,ZZ9.99")) : context.localUtil.Format( A64DineroTotal, "ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDineroTotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDineroTotal_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDineroPago_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDineroPago_Internalname, "Pago", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDineroPago_Internalname, StringUtil.LTrim( StringUtil.NToC( A62DineroPago, 10, 2, ",", "")), ((edtDineroPago_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A62DineroPago, "ZZZ,ZZ9.99")) : context.localUtil.Format( A62DineroPago, "ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDineroPago_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDineroPago_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDineroAbono_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDineroAbono_Internalname, "Abono", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDineroAbono_Internalname, StringUtil.LTrim( StringUtil.NToC( A63DineroAbono, 12, 2, ",", "")), ((edtDineroAbono_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A63DineroAbono, "+ ZZZ,ZZ9.99")) : context.localUtil.Format( A63DineroAbono, "+ ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDineroAbono_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDineroAbono_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDineroBalance_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDineroBalance_Internalname, "Balance", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtDineroBalance_Internalname, StringUtil.LTrim( StringUtil.NToC( A61DineroBalance, 10, 2, ",", "")), ((edtDineroBalance_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A61DineroBalance, "ZZZ,ZZ9.99")) : context.localUtil.Format( A61DineroBalance, "ZZZ,ZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDineroBalance_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDineroBalance_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDineroNuevo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDineroNuevo_Internalname, "Nuevo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtDineroNuevo_Internalname, StringUtil.LTrim( StringUtil.NToC( A65DineroNuevo, 10, 2, ",", "")), ((edtDineroNuevo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A65DineroNuevo, "ZZZ,ZZ9.99")) : context.localUtil.Format( A65DineroNuevo, "ZZZ,ZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDineroNuevo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDineroNuevo_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Dinero.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Dinero.htm");
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
         E11062 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtDineroTotal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDineroTotal_Internalname), ",", ".") > 999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DINEROTOTAL");
                  AnyError = 1;
                  GX_FocusControl = edtDineroTotal_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A64DineroTotal = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DineroTotal", StringUtil.LTrim( StringUtil.Str( A64DineroTotal, 9, 2)));
               }
               else
               {
                  A64DineroTotal = context.localUtil.CToN( cgiGet( edtDineroTotal_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DineroTotal", StringUtil.LTrim( StringUtil.Str( A64DineroTotal, 9, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtDineroPago_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDineroPago_Internalname), ",", ".") > 999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DINEROPAGO");
                  AnyError = 1;
                  GX_FocusControl = edtDineroPago_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A62DineroPago = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62DineroPago", StringUtil.LTrim( StringUtil.Str( A62DineroPago, 9, 2)));
               }
               else
               {
                  A62DineroPago = context.localUtil.CToN( cgiGet( edtDineroPago_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62DineroPago", StringUtil.LTrim( StringUtil.Str( A62DineroPago, 9, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtDineroAbono_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDineroAbono_Internalname), ",", ".") > 999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DINEROABONO");
                  AnyError = 1;
                  GX_FocusControl = edtDineroAbono_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A63DineroAbono = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63DineroAbono", StringUtil.LTrim( StringUtil.Str( A63DineroAbono, 9, 2)));
               }
               else
               {
                  A63DineroAbono = context.localUtil.CToN( cgiGet( edtDineroAbono_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63DineroAbono", StringUtil.LTrim( StringUtil.Str( A63DineroAbono, 9, 2)));
               }
               A61DineroBalance = context.localUtil.CToN( cgiGet( edtDineroBalance_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61DineroBalance", StringUtil.LTrim( StringUtil.Str( A61DineroBalance, 9, 2)));
               A65DineroNuevo = context.localUtil.CToN( cgiGet( edtDineroNuevo_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DineroNuevo", StringUtil.LTrim( StringUtil.Str( A65DineroNuevo, 9, 2)));
               /* Read saved values. */
               Z14DineroId = (short)(context.localUtil.CToN( cgiGet( "Z14DineroId"), ",", "."));
               Z64DineroTotal = context.localUtil.CToN( cgiGet( "Z64DineroTotal"), ",", ".");
               Z62DineroPago = context.localUtil.CToN( cgiGet( "Z62DineroPago"), ",", ".");
               Z63DineroAbono = context.localUtil.CToN( cgiGet( "Z63DineroAbono"), ",", ".");
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N3UsersId = (short)(context.localUtil.CToN( cgiGet( "N3UsersId"), ",", "."));
               AV7DineroId = (short)(context.localUtil.CToN( cgiGet( "vDINEROID"), ",", "."));
               A14DineroId = (short)(context.localUtil.CToN( cgiGet( "DINEROID"), ",", "."));
               AV11Insert_UsersId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_USERSID"), ",", "."));
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Dinero";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A14DineroId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("dinero:[SecurityCheckFailed value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
                  GXUtil.WriteLog("dinero:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("dinero:[SecurityCheckFailed value for]"+"DineroId:"+context.localUtil.Format( (decimal)(A14DineroId), "ZZZ9"));
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
                  A14DineroId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14DineroId), 4, 0)));
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
                     sMode12 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode12;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound12 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
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
                           E11062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12062 ();
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
            E12062 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0612( ) ;
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
            DisableAttributes0612( ) ;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate0612( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0612( ) ;
            }
            else
            {
               CheckExtendedTable0612( ) ;
               CloseExtendedTableCursors0612( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption060( )
      {
      }

      protected void E11062( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
         AV11Insert_UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_UsersId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV13Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV14GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            while ( AV14GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV14GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "UsersId") == 0 )
               {
                  AV11Insert_UsersId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_UsersId), 4, 0)));
               }
               AV14GXV1 = (int)(AV14GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            }
         }
      }

      protected void E12062( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwdinero.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0612( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z64DineroTotal = T00063_A64DineroTotal[0];
               Z62DineroPago = T00063_A62DineroPago[0];
               Z63DineroAbono = T00063_A63DineroAbono[0];
               Z3UsersId = T00063_A3UsersId[0];
            }
            else
            {
               Z64DineroTotal = A64DineroTotal;
               Z62DineroPago = A62DineroPago;
               Z63DineroAbono = A63DineroAbono;
               Z3UsersId = A3UsersId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z14DineroId = A14DineroId;
            Z64DineroTotal = A64DineroTotal;
            Z62DineroPago = A62DineroPago;
            Z63DineroAbono = A63DineroAbono;
            Z3UsersId = A3UsersId;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USERSID"+"'), id:'"+"USERSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7DineroId) )
         {
            A14DineroId = AV7DineroId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14DineroId), 4, 0)));
         }
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
            AV13Pgmname = "Dinero";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void Load0612( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A14DineroId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound12 = 1;
            A64DineroTotal = T00065_A64DineroTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DineroTotal", StringUtil.LTrim( StringUtil.Str( A64DineroTotal, 9, 2)));
            A62DineroPago = T00065_A62DineroPago[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62DineroPago", StringUtil.LTrim( StringUtil.Str( A62DineroPago, 9, 2)));
            A63DineroAbono = T00065_A63DineroAbono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63DineroAbono", StringUtil.LTrim( StringUtil.Str( A63DineroAbono, 9, 2)));
            A3UsersId = T00065_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            ZM0612( -9) ;
         }
         pr_default.close(3);
         OnLoadActions0612( ) ;
      }

      protected void OnLoadActions0612( )
      {
         AV13Pgmname = "Dinero";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         A61DineroBalance = (decimal)(A62DineroPago+A63DineroAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61DineroBalance", StringUtil.LTrim( StringUtil.Str( A61DineroBalance, 9, 2)));
         A65DineroNuevo = (decimal)(A64DineroTotal-A61DineroBalance);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DineroNuevo", StringUtil.LTrim( StringUtil.Str( A65DineroNuevo, 9, 2)));
      }

      protected void CheckExtendedTable0612( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Dinero";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         A61DineroBalance = (decimal)(A62DineroPago+A63DineroAbono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61DineroBalance", StringUtil.LTrim( StringUtil.Str( A61DineroBalance, 9, 2)));
         A65DineroNuevo = (decimal)(A64DineroTotal-A61DineroBalance);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DineroNuevo", StringUtil.LTrim( StringUtil.Str( A65DineroNuevo, 9, 2)));
      }

      protected void CloseExtendedTableCursors0612( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( short A3UsersId )
      {
         /* Using cursor T00066 */
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

      protected void GetKey0612( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A14DineroId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A14DineroId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0612( 9) ;
            RcdFound12 = 1;
            A14DineroId = T00063_A14DineroId[0];
            A64DineroTotal = T00063_A64DineroTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DineroTotal", StringUtil.LTrim( StringUtil.Str( A64DineroTotal, 9, 2)));
            A62DineroPago = T00063_A62DineroPago[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62DineroPago", StringUtil.LTrim( StringUtil.Str( A62DineroPago, 9, 2)));
            A63DineroAbono = T00063_A63DineroAbono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63DineroAbono", StringUtil.LTrim( StringUtil.Str( A63DineroAbono, 9, 2)));
            A3UsersId = T00063_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            Z14DineroId = A14DineroId;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0612( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0612( ) ;
            }
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0612( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0612( ) ;
         if ( RcdFound12 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound12 = 0;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A14DineroId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00068_A14DineroId[0] < A14DineroId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00068_A14DineroId[0] > A14DineroId ) ) )
            {
               A14DineroId = T00068_A14DineroId[0];
               RcdFound12 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A14DineroId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00069_A14DineroId[0] > A14DineroId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00069_A14DineroId[0] < A14DineroId ) ) )
            {
               A14DineroId = T00069_A14DineroId[0];
               RcdFound12 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0612( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0612( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A14DineroId != Z14DineroId )
               {
                  A14DineroId = Z14DineroId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14DineroId), 4, 0)));
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
                  /* Update record */
                  Update0612( ) ;
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A14DineroId != Z14DineroId )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0612( ) ;
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
                     GX_FocusControl = edtUsersId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0612( ) ;
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
         if ( A14DineroId != Z14DineroId )
         {
            A14DineroId = Z14DineroId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14DineroId), 4, 0)));
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
         }
      }

      protected void CheckOptimisticConcurrency0612( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A14DineroId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Dinero"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z64DineroTotal != T00062_A64DineroTotal[0] ) || ( Z62DineroPago != T00062_A62DineroPago[0] ) || ( Z63DineroAbono != T00062_A63DineroAbono[0] ) || ( Z3UsersId != T00062_A3UsersId[0] ) )
            {
               if ( Z64DineroTotal != T00062_A64DineroTotal[0] )
               {
                  GXUtil.WriteLog("dinero:[seudo value changed for attri]"+"DineroTotal");
                  GXUtil.WriteLogRaw("Old: ",Z64DineroTotal);
                  GXUtil.WriteLogRaw("Current: ",T00062_A64DineroTotal[0]);
               }
               if ( Z62DineroPago != T00062_A62DineroPago[0] )
               {
                  GXUtil.WriteLog("dinero:[seudo value changed for attri]"+"DineroPago");
                  GXUtil.WriteLogRaw("Old: ",Z62DineroPago);
                  GXUtil.WriteLogRaw("Current: ",T00062_A62DineroPago[0]);
               }
               if ( Z63DineroAbono != T00062_A63DineroAbono[0] )
               {
                  GXUtil.WriteLog("dinero:[seudo value changed for attri]"+"DineroAbono");
                  GXUtil.WriteLogRaw("Old: ",Z63DineroAbono);
                  GXUtil.WriteLogRaw("Current: ",T00062_A63DineroAbono[0]);
               }
               if ( Z3UsersId != T00062_A3UsersId[0] )
               {
                  GXUtil.WriteLog("dinero:[seudo value changed for attri]"+"UsersId");
                  GXUtil.WriteLogRaw("Old: ",Z3UsersId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A3UsersId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Dinero"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0612( )
      {
         BeforeValidate0612( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0612( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0612( 0) ;
            CheckOptimisticConcurrency0612( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0612( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0612( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {A64DineroTotal, A62DineroPago, A63DineroAbono, A3UsersId});
                     A14DineroId = T000610_A14DineroId[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Dinero") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption060( ) ;
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
               Load0612( ) ;
            }
            EndLevel0612( ) ;
         }
         CloseExtendedTableCursors0612( ) ;
      }

      protected void Update0612( )
      {
         BeforeValidate0612( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0612( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0612( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0612( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0612( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000611 */
                     pr_default.execute(9, new Object[] {A64DineroTotal, A62DineroPago, A63DineroAbono, A3UsersId, A14DineroId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Dinero") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Dinero"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0612( ) ;
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
            EndLevel0612( ) ;
         }
         CloseExtendedTableCursors0612( ) ;
      }

      protected void DeferredUpdate0612( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0612( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0612( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0612( ) ;
            AfterConfirm0612( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0612( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000612 */
                  pr_default.execute(10, new Object[] {A14DineroId});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Dinero") ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0612( ) ;
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0612( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Dinero";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            A61DineroBalance = (decimal)(A62DineroPago+A63DineroAbono);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61DineroBalance", StringUtil.LTrim( StringUtil.Str( A61DineroBalance, 9, 2)));
            A65DineroNuevo = (decimal)(A64DineroTotal-A61DineroBalance);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DineroNuevo", StringUtil.LTrim( StringUtil.Str( A65DineroNuevo, 9, 2)));
         }
      }

      protected void EndLevel0612( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0612( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("dinero",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("dinero",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0612( )
      {
         /* Scan By routine */
         /* Using cursor T000613 */
         pr_default.execute(11);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound12 = 1;
            A14DineroId = T000613_A14DineroId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0612( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound12 = 1;
            A14DineroId = T000613_A14DineroId[0];
         }
      }

      protected void ScanEnd0612( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0612( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0612( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0612( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0612( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0612( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0612( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0612( )
      {
         edtUsersId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         edtDineroTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDineroTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDineroTotal_Enabled), 5, 0)), true);
         edtDineroPago_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDineroPago_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDineroPago_Enabled), 5, 0)), true);
         edtDineroAbono_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDineroAbono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDineroAbono_Enabled), 5, 0)), true);
         edtDineroBalance_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDineroBalance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDineroBalance_Enabled), 5, 0)), true);
         edtDineroNuevo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDineroNuevo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDineroNuevo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0612( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118522920", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("dinero.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7DineroId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Dinero";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A14DineroId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("dinero:[SendSecurityCheck value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
         GXUtil.WriteLog("dinero:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("dinero:[SendSecurityCheck value for]"+"DineroId:"+context.localUtil.Format( (decimal)(A14DineroId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z14DineroId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14DineroId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z64DineroTotal", StringUtil.LTrim( StringUtil.NToC( Z64DineroTotal, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z62DineroPago", StringUtil.LTrim( StringUtil.NToC( Z62DineroPago, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z63DineroAbono", StringUtil.LTrim( StringUtil.NToC( Z63DineroAbono, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vDINEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7DineroId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vDINEROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7DineroId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DINEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14DineroId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
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
         return formatLink("dinero.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7DineroId) ;
      }

      public override String GetPgmname( )
      {
         return "Dinero" ;
      }

      public override String GetPgmdesc( )
      {
         return "Dinero" ;
      }

      protected void InitializeNonKey0612( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         A61DineroBalance = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61DineroBalance", StringUtil.LTrim( StringUtil.Str( A61DineroBalance, 9, 2)));
         A65DineroNuevo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65DineroNuevo", StringUtil.LTrim( StringUtil.Str( A65DineroNuevo, 9, 2)));
         A64DineroTotal = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64DineroTotal", StringUtil.LTrim( StringUtil.Str( A64DineroTotal, 9, 2)));
         A62DineroPago = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62DineroPago", StringUtil.LTrim( StringUtil.Str( A62DineroPago, 9, 2)));
         A63DineroAbono = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63DineroAbono", StringUtil.LTrim( StringUtil.Str( A63DineroAbono, 9, 2)));
         Z64DineroTotal = 0;
         Z62DineroPago = 0;
         Z63DineroAbono = 0;
         Z3UsersId = 0;
      }

      protected void InitAll0612( )
      {
         A14DineroId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DineroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14DineroId), 4, 0)));
         InitializeNonKey0612( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118522937", true);
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
         context.AddJavascriptSource("dinero.js", "?2018101118522937", false);
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
         edtDineroTotal_Internalname = "DINEROTOTAL";
         edtDineroPago_Internalname = "DINEROPAGO";
         edtDineroAbono_Internalname = "DINEROABONO";
         edtDineroBalance_Internalname = "DINEROBALANCE";
         edtDineroNuevo_Internalname = "DINERONUEVO";
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
         Form.Caption = "Dinero";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtDineroNuevo_Jsonclick = "";
         edtDineroNuevo_Enabled = 0;
         edtDineroBalance_Jsonclick = "";
         edtDineroBalance_Enabled = 0;
         edtDineroAbono_Jsonclick = "";
         edtDineroAbono_Enabled = 1;
         edtDineroPago_Jsonclick = "";
         edtDineroPago_Enabled = 1;
         edtDineroTotal_Jsonclick = "";
         edtDineroTotal_Enabled = 1;
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

      public void Valid_Usersid( short GX_Parm1 )
      {
         A3UsersId = GX_Parm1;
         /* Using cursor T000614 */
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DineroId',fld:'vDINEROID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DineroId',fld:'vDINEROID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_UsersId',fld:'vINSERT_USERSID',pic:'ZZZ9'},{av:'A14DineroId',fld:'DINEROID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12062',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
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
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode12 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         T00065_A14DineroId = new short[1] ;
         T00065_A64DineroTotal = new decimal[1] ;
         T00065_A62DineroPago = new decimal[1] ;
         T00065_A63DineroAbono = new decimal[1] ;
         T00065_A3UsersId = new short[1] ;
         T00064_A3UsersId = new short[1] ;
         T00066_A3UsersId = new short[1] ;
         T00067_A14DineroId = new short[1] ;
         T00063_A14DineroId = new short[1] ;
         T00063_A64DineroTotal = new decimal[1] ;
         T00063_A62DineroPago = new decimal[1] ;
         T00063_A63DineroAbono = new decimal[1] ;
         T00063_A3UsersId = new short[1] ;
         T00068_A14DineroId = new short[1] ;
         T00069_A14DineroId = new short[1] ;
         T00062_A14DineroId = new short[1] ;
         T00062_A64DineroTotal = new decimal[1] ;
         T00062_A62DineroPago = new decimal[1] ;
         T00062_A63DineroAbono = new decimal[1] ;
         T00062_A3UsersId = new short[1] ;
         T000610_A14DineroId = new short[1] ;
         T000613_A14DineroId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000614_A3UsersId = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.dinero__default(),
            new Object[][] {
                new Object[] {
               T00062_A14DineroId, T00062_A64DineroTotal, T00062_A62DineroPago, T00062_A63DineroAbono, T00062_A3UsersId
               }
               , new Object[] {
               T00063_A14DineroId, T00063_A64DineroTotal, T00063_A62DineroPago, T00063_A63DineroAbono, T00063_A3UsersId
               }
               , new Object[] {
               T00064_A3UsersId
               }
               , new Object[] {
               T00065_A14DineroId, T00065_A64DineroTotal, T00065_A62DineroPago, T00065_A63DineroAbono, T00065_A3UsersId
               }
               , new Object[] {
               T00066_A3UsersId
               }
               , new Object[] {
               T00067_A14DineroId
               }
               , new Object[] {
               T00068_A14DineroId
               }
               , new Object[] {
               T00069_A14DineroId
               }
               , new Object[] {
               T000610_A14DineroId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000613_A14DineroId
               }
               , new Object[] {
               T000614_A3UsersId
               }
            }
         );
         AV13Pgmname = "Dinero";
      }

      private short wcpOAV7DineroId ;
      private short Z14DineroId ;
      private short Z3UsersId ;
      private short N3UsersId ;
      private short GxWebError ;
      private short A3UsersId ;
      private short AV7DineroId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A14DineroId ;
      private short AV11Insert_UsersId ;
      private short RcdFound12 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsersId_Enabled ;
      private int imgprompt_3_Visible ;
      private int edtDineroTotal_Enabled ;
      private int edtDineroPago_Enabled ;
      private int edtDineroAbono_Enabled ;
      private int edtDineroBalance_Enabled ;
      private int edtDineroNuevo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV14GXV1 ;
      private int idxLst ;
      private decimal Z64DineroTotal ;
      private decimal Z62DineroPago ;
      private decimal Z63DineroAbono ;
      private decimal A64DineroTotal ;
      private decimal A62DineroPago ;
      private decimal A63DineroAbono ;
      private decimal A61DineroBalance ;
      private decimal A65DineroNuevo ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
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
      private String edtDineroTotal_Internalname ;
      private String edtDineroTotal_Jsonclick ;
      private String edtDineroPago_Internalname ;
      private String edtDineroPago_Jsonclick ;
      private String edtDineroAbono_Internalname ;
      private String edtDineroAbono_Jsonclick ;
      private String edtDineroBalance_Internalname ;
      private String edtDineroBalance_Jsonclick ;
      private String edtDineroNuevo_Internalname ;
      private String edtDineroNuevo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode12 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00065_A14DineroId ;
      private decimal[] T00065_A64DineroTotal ;
      private decimal[] T00065_A62DineroPago ;
      private decimal[] T00065_A63DineroAbono ;
      private short[] T00065_A3UsersId ;
      private short[] T00064_A3UsersId ;
      private short[] T00066_A3UsersId ;
      private short[] T00067_A14DineroId ;
      private short[] T00063_A14DineroId ;
      private decimal[] T00063_A64DineroTotal ;
      private decimal[] T00063_A62DineroPago ;
      private decimal[] T00063_A63DineroAbono ;
      private short[] T00063_A3UsersId ;
      private short[] T00068_A14DineroId ;
      private short[] T00069_A14DineroId ;
      private short[] T00062_A14DineroId ;
      private decimal[] T00062_A64DineroTotal ;
      private decimal[] T00062_A62DineroPago ;
      private decimal[] T00062_A63DineroAbono ;
      private short[] T00062_A3UsersId ;
      private short[] T000610_A14DineroId ;
      private short[] T000613_A14DineroId ;
      private short[] T000614_A3UsersId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class dinero__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@DineroTotal",SqlDbType.Decimal,9,2} ,
          new Object[] {"@DineroPago",SqlDbType.Decimal,9,2} ,
          new Object[] {"@DineroAbono",SqlDbType.Decimal,9,2} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@DineroTotal",SqlDbType.Decimal,9,2} ,
          new Object[] {"@DineroPago",SqlDbType.Decimal,9,2} ,
          new Object[] {"@DineroAbono",SqlDbType.Decimal,9,2} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@DineroId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [DineroId], [DineroTotal], [DineroPago], [DineroAbono], [UsersId] FROM [Dinero] WITH (UPDLOCK) WHERE [DineroId] = @DineroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT [DineroId], [DineroTotal], [DineroPago], [DineroAbono], [UsersId] FROM [Dinero] WITH (NOLOCK) WHERE [DineroId] = @DineroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
             ,new CursorDef("T00065", "SELECT TM1.[DineroId], TM1.[DineroTotal], TM1.[DineroPago], TM1.[DineroAbono], TM1.[UsersId] FROM [Dinero] TM1 WITH (NOLOCK) WHERE TM1.[DineroId] = @DineroId ORDER BY TM1.[DineroId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,100,0,true,false )
             ,new CursorDef("T00066", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
             ,new CursorDef("T00067", "SELECT [DineroId] FROM [Dinero] WITH (NOLOCK) WHERE [DineroId] = @DineroId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
             ,new CursorDef("T00068", "SELECT TOP 1 [DineroId] FROM [Dinero] WITH (NOLOCK) WHERE ( [DineroId] > @DineroId) ORDER BY [DineroId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,true )
             ,new CursorDef("T00069", "SELECT TOP 1 [DineroId] FROM [Dinero] WITH (NOLOCK) WHERE ( [DineroId] < @DineroId) ORDER BY [DineroId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1,0,true,true )
             ,new CursorDef("T000610", "INSERT INTO [Dinero]([DineroTotal], [DineroPago], [DineroAbono], [UsersId]) VALUES(@DineroTotal, @DineroPago, @DineroAbono, @UsersId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000610)
             ,new CursorDef("T000611", "UPDATE [Dinero] SET [DineroTotal]=@DineroTotal, [DineroPago]=@DineroPago, [DineroAbono]=@DineroAbono, [UsersId]=@UsersId  WHERE [DineroId] = @DineroId", GxErrorMask.GX_NOMASK,prmT000611)
             ,new CursorDef("T000612", "DELETE FROM [Dinero]  WHERE [DineroId] = @DineroId", GxErrorMask.GX_NOMASK,prmT000612)
             ,new CursorDef("T000613", "SELECT [DineroId] FROM [Dinero] WITH (NOLOCK) ORDER BY [DineroId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,100,0,true,false )
             ,new CursorDef("T000614", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
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
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 9 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
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
