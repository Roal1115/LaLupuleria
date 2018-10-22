/*
               File: Califas
        Description: Califas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:20.19
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
   public class califas : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A3UsersId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_12") == 0 )
         {
            A11MateriasId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_12( A11MateriasId) ;
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
               AV7CalifasId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CalifasId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCALIFASID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CalifasId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Califas", 0) ;
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

      public califas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public califas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_CalifasId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7CalifasId = aP1_CalifasId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Califas", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Califas.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Califas.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_Califas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMateriasId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMateriasId_Internalname, "Materias Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMateriasId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11MateriasId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A11MateriasId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMateriasId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMateriasId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_Califas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas1_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas1_Internalname, "Califas1", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A53Califas1), 3, 0, ",", "")), ((edtCalifas1_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A53Califas1), "ZZ9")) : context.localUtil.Format( (decimal)(A53Califas1), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas1_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas1_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas2_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas2_Internalname, "Califas2", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A54Califas2), 3, 0, ",", "")), ((edtCalifas2_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A54Califas2), "ZZ9")) : context.localUtil.Format( (decimal)(A54Califas2), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas2_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas2_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas3_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas3_Internalname, "Califas3", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A55Califas3), 3, 0, ",", "")), ((edtCalifas3_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A55Califas3), "ZZ9")) : context.localUtil.Format( (decimal)(A55Califas3), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas3_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas3_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas4_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas4_Internalname, "Califas4", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A56Califas4), 3, 0, ",", "")), ((edtCalifas4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A56Califas4), "ZZ9")) : context.localUtil.Format( (decimal)(A56Califas4), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas4_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas4_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas5_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas5_Internalname, "Califas5", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas5_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A57Califas5), 3, 0, ",", "")), ((edtCalifas5_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A57Califas5), "ZZ9")) : context.localUtil.Format( (decimal)(A57Califas5), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas5_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas5_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas6_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas6_Internalname, "Califas6", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas6_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A58Califas6), 3, 0, ",", "")), ((edtCalifas6_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A58Califas6), "ZZ9")) : context.localUtil.Format( (decimal)(A58Califas6), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas6_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas6_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas7_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas7_Internalname, "Califas7", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas7_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A59Califas7), 3, 0, ",", "")), ((edtCalifas7_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A59Califas7), "ZZ9")) : context.localUtil.Format( (decimal)(A59Califas7), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas7_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas7_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCalifas8_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCalifas8_Internalname, "Califas8", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCalifas8_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A60Califas8), 3, 0, ",", "")), ((edtCalifas8_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A60Califas8), "ZZ9")) : context.localUtil.Format( (decimal)(A60Califas8), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCalifas8_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCalifas8_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Califas.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Califas.htm");
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
         E11052 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtMateriasId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMateriasId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MATERIASID");
                  AnyError = 1;
                  GX_FocusControl = edtMateriasId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11MateriasId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
               }
               else
               {
                  A11MateriasId = (short)(context.localUtil.CToN( cgiGet( edtMateriasId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS1");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas1_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A53Califas1 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53Califas1", StringUtil.LTrim( StringUtil.Str( (decimal)(A53Califas1), 3, 0)));
               }
               else
               {
                  A53Califas1 = (short)(context.localUtil.CToN( cgiGet( edtCalifas1_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53Califas1", StringUtil.LTrim( StringUtil.Str( (decimal)(A53Califas1), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS2");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas2_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A54Califas2 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54Califas2", StringUtil.LTrim( StringUtil.Str( (decimal)(A54Califas2), 3, 0)));
               }
               else
               {
                  A54Califas2 = (short)(context.localUtil.CToN( cgiGet( edtCalifas2_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54Califas2", StringUtil.LTrim( StringUtil.Str( (decimal)(A54Califas2), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS3");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas3_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A55Califas3 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55Califas3", StringUtil.LTrim( StringUtil.Str( (decimal)(A55Califas3), 3, 0)));
               }
               else
               {
                  A55Califas3 = (short)(context.localUtil.CToN( cgiGet( edtCalifas3_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55Califas3", StringUtil.LTrim( StringUtil.Str( (decimal)(A55Califas3), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS4");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas4_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A56Califas4 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56Califas4", StringUtil.LTrim( StringUtil.Str( (decimal)(A56Califas4), 3, 0)));
               }
               else
               {
                  A56Califas4 = (short)(context.localUtil.CToN( cgiGet( edtCalifas4_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56Califas4", StringUtil.LTrim( StringUtil.Str( (decimal)(A56Califas4), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas5_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas5_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS5");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas5_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A57Califas5 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57Califas5", StringUtil.LTrim( StringUtil.Str( (decimal)(A57Califas5), 3, 0)));
               }
               else
               {
                  A57Califas5 = (short)(context.localUtil.CToN( cgiGet( edtCalifas5_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57Califas5", StringUtil.LTrim( StringUtil.Str( (decimal)(A57Califas5), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas6_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas6_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS6");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas6_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A58Califas6 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58Califas6", StringUtil.LTrim( StringUtil.Str( (decimal)(A58Califas6), 3, 0)));
               }
               else
               {
                  A58Califas6 = (short)(context.localUtil.CToN( cgiGet( edtCalifas6_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58Califas6", StringUtil.LTrim( StringUtil.Str( (decimal)(A58Califas6), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas7_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas7_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS7");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas7_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A59Califas7 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59Califas7", StringUtil.LTrim( StringUtil.Str( (decimal)(A59Califas7), 3, 0)));
               }
               else
               {
                  A59Califas7 = (short)(context.localUtil.CToN( cgiGet( edtCalifas7_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59Califas7", StringUtil.LTrim( StringUtil.Str( (decimal)(A59Califas7), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCalifas8_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCalifas8_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CALIFAS8");
                  AnyError = 1;
                  GX_FocusControl = edtCalifas8_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A60Califas8 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60Califas8", StringUtil.LTrim( StringUtil.Str( (decimal)(A60Califas8), 3, 0)));
               }
               else
               {
                  A60Califas8 = (short)(context.localUtil.CToN( cgiGet( edtCalifas8_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60Califas8", StringUtil.LTrim( StringUtil.Str( (decimal)(A60Califas8), 3, 0)));
               }
               /* Read saved values. */
               Z13CalifasId = (short)(context.localUtil.CToN( cgiGet( "Z13CalifasId"), ",", "."));
               Z53Califas1 = (short)(context.localUtil.CToN( cgiGet( "Z53Califas1"), ",", "."));
               Z54Califas2 = (short)(context.localUtil.CToN( cgiGet( "Z54Califas2"), ",", "."));
               Z55Califas3 = (short)(context.localUtil.CToN( cgiGet( "Z55Califas3"), ",", "."));
               Z56Califas4 = (short)(context.localUtil.CToN( cgiGet( "Z56Califas4"), ",", "."));
               Z57Califas5 = (short)(context.localUtil.CToN( cgiGet( "Z57Califas5"), ",", "."));
               Z58Califas6 = (short)(context.localUtil.CToN( cgiGet( "Z58Califas6"), ",", "."));
               Z59Califas7 = (short)(context.localUtil.CToN( cgiGet( "Z59Califas7"), ",", "."));
               Z60Califas8 = (short)(context.localUtil.CToN( cgiGet( "Z60Califas8"), ",", "."));
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               Z11MateriasId = (short)(context.localUtil.CToN( cgiGet( "Z11MateriasId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N3UsersId = (short)(context.localUtil.CToN( cgiGet( "N3UsersId"), ",", "."));
               N11MateriasId = (short)(context.localUtil.CToN( cgiGet( "N11MateriasId"), ",", "."));
               AV7CalifasId = (short)(context.localUtil.CToN( cgiGet( "vCALIFASID"), ",", "."));
               A13CalifasId = (short)(context.localUtil.CToN( cgiGet( "CALIFASID"), ",", "."));
               AV11Insert_UsersId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_USERSID"), ",", "."));
               AV12Insert_MateriasId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_MATERIASID"), ",", "."));
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Califas";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_MateriasId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13CalifasId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("califas:[SecurityCheckFailed value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
                  GXUtil.WriteLog("califas:[SecurityCheckFailed value for]"+"Insert_MateriasId:"+context.localUtil.Format( (decimal)(AV12Insert_MateriasId), "ZZZ9"));
                  GXUtil.WriteLog("califas:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("califas:[SecurityCheckFailed value for]"+"CalifasId:"+context.localUtil.Format( (decimal)(A13CalifasId), "ZZZ9"));
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
                  A13CalifasId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13CalifasId), 4, 0)));
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
                     sMode11 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode11;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound11 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
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
                           E11052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12052 ();
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
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0511( ) ;
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
            DisableAttributes0511( ) ;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate0511( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0511( ) ;
            }
            else
            {
               CheckExtendedTable0511( ) ;
               CloseExtendedTableCursors0511( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
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
         AV12Insert_MateriasId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_MateriasId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "UsersId") == 0 )
               {
                  AV11Insert_UsersId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_UsersId), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "MateriasId") == 0 )
               {
                  AV12Insert_MateriasId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_MateriasId), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcalifas.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0511( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z53Califas1 = T00053_A53Califas1[0];
               Z54Califas2 = T00053_A54Califas2[0];
               Z55Califas3 = T00053_A55Califas3[0];
               Z56Califas4 = T00053_A56Califas4[0];
               Z57Califas5 = T00053_A57Califas5[0];
               Z58Califas6 = T00053_A58Califas6[0];
               Z59Califas7 = T00053_A59Califas7[0];
               Z60Califas8 = T00053_A60Califas8[0];
               Z3UsersId = T00053_A3UsersId[0];
               Z11MateriasId = T00053_A11MateriasId[0];
            }
            else
            {
               Z53Califas1 = A53Califas1;
               Z54Califas2 = A54Califas2;
               Z55Califas3 = A55Califas3;
               Z56Califas4 = A56Califas4;
               Z57Califas5 = A57Califas5;
               Z58Califas6 = A58Califas6;
               Z59Califas7 = A59Califas7;
               Z60Califas8 = A60Califas8;
               Z3UsersId = A3UsersId;
               Z11MateriasId = A11MateriasId;
            }
         }
         if ( GX_JID == -10 )
         {
            Z13CalifasId = A13CalifasId;
            Z53Califas1 = A53Califas1;
            Z54Califas2 = A54Califas2;
            Z55Califas3 = A55Califas3;
            Z56Califas4 = A56Califas4;
            Z57Califas5 = A57Califas5;
            Z58Califas6 = A58Califas6;
            Z59Califas7 = A59Califas7;
            Z60Califas8 = A60Califas8;
            Z3UsersId = A3UsersId;
            Z11MateriasId = A11MateriasId;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USERSID"+"'), id:'"+"USERSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MATERIASID"+"'), id:'"+"MATERIASID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7CalifasId) )
         {
            A13CalifasId = AV7CalifasId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13CalifasId), 4, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_MateriasId) )
         {
            edtMateriasId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMateriasId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMateriasId_Enabled), 5, 0)), true);
         }
         else
         {
            edtMateriasId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMateriasId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMateriasId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_MateriasId) )
         {
            A11MateriasId = AV12Insert_MateriasId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
         }
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
            AV14Pgmname = "Califas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         }
      }

      protected void Load0511( )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A13CalifasId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1;
            A53Califas1 = T00056_A53Califas1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53Califas1", StringUtil.LTrim( StringUtil.Str( (decimal)(A53Califas1), 3, 0)));
            A54Califas2 = T00056_A54Califas2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54Califas2", StringUtil.LTrim( StringUtil.Str( (decimal)(A54Califas2), 3, 0)));
            A55Califas3 = T00056_A55Califas3[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55Califas3", StringUtil.LTrim( StringUtil.Str( (decimal)(A55Califas3), 3, 0)));
            A56Califas4 = T00056_A56Califas4[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56Califas4", StringUtil.LTrim( StringUtil.Str( (decimal)(A56Califas4), 3, 0)));
            A57Califas5 = T00056_A57Califas5[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57Califas5", StringUtil.LTrim( StringUtil.Str( (decimal)(A57Califas5), 3, 0)));
            A58Califas6 = T00056_A58Califas6[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58Califas6", StringUtil.LTrim( StringUtil.Str( (decimal)(A58Califas6), 3, 0)));
            A59Califas7 = T00056_A59Califas7[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59Califas7", StringUtil.LTrim( StringUtil.Str( (decimal)(A59Califas7), 3, 0)));
            A60Califas8 = T00056_A60Califas8[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60Califas8", StringUtil.LTrim( StringUtil.Str( (decimal)(A60Califas8), 3, 0)));
            A3UsersId = T00056_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A11MateriasId = T00056_A11MateriasId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
            ZM0511( -10) ;
         }
         pr_default.close(4);
         OnLoadActions0511( ) ;
      }

      protected void OnLoadActions0511( )
      {
         AV14Pgmname = "Califas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable0511( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Califas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Materias'.", "ForeignKeyNotFound", 1, "MATERIASID");
            AnyError = 1;
            GX_FocusControl = edtMateriasId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0511( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A3UsersId )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(5) == 101) )
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
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_12( short A11MateriasId )
      {
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Materias'.", "ForeignKeyNotFound", 1, "MATERIASID");
            AnyError = 1;
            GX_FocusControl = edtMateriasId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0511( )
      {
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A13CalifasId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A13CalifasId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0511( 10) ;
            RcdFound11 = 1;
            A13CalifasId = T00053_A13CalifasId[0];
            A53Califas1 = T00053_A53Califas1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53Califas1", StringUtil.LTrim( StringUtil.Str( (decimal)(A53Califas1), 3, 0)));
            A54Califas2 = T00053_A54Califas2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54Califas2", StringUtil.LTrim( StringUtil.Str( (decimal)(A54Califas2), 3, 0)));
            A55Califas3 = T00053_A55Califas3[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55Califas3", StringUtil.LTrim( StringUtil.Str( (decimal)(A55Califas3), 3, 0)));
            A56Califas4 = T00053_A56Califas4[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56Califas4", StringUtil.LTrim( StringUtil.Str( (decimal)(A56Califas4), 3, 0)));
            A57Califas5 = T00053_A57Califas5[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57Califas5", StringUtil.LTrim( StringUtil.Str( (decimal)(A57Califas5), 3, 0)));
            A58Califas6 = T00053_A58Califas6[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58Califas6", StringUtil.LTrim( StringUtil.Str( (decimal)(A58Califas6), 3, 0)));
            A59Califas7 = T00053_A59Califas7[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59Califas7", StringUtil.LTrim( StringUtil.Str( (decimal)(A59Califas7), 3, 0)));
            A60Califas8 = T00053_A60Califas8[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60Califas8", StringUtil.LTrim( StringUtil.Str( (decimal)(A60Califas8), 3, 0)));
            A3UsersId = T00053_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A11MateriasId = T00053_A11MateriasId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
            Z13CalifasId = A13CalifasId;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0511( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0511( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0511( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0511( ) ;
         if ( RcdFound11 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0;
         /* Using cursor T000510 */
         pr_default.execute(8, new Object[] {A13CalifasId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000510_A13CalifasId[0] < A13CalifasId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000510_A13CalifasId[0] > A13CalifasId ) ) )
            {
               A13CalifasId = T000510_A13CalifasId[0];
               RcdFound11 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T000511 */
         pr_default.execute(9, new Object[] {A13CalifasId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000511_A13CalifasId[0] > A13CalifasId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000511_A13CalifasId[0] < A13CalifasId ) ) )
            {
               A13CalifasId = T000511_A13CalifasId[0];
               RcdFound11 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0511( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0511( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A13CalifasId != Z13CalifasId )
               {
                  A13CalifasId = Z13CalifasId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13CalifasId), 4, 0)));
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
                  Update0511( ) ;
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A13CalifasId != Z13CalifasId )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsersId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0511( ) ;
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
                     Insert0511( ) ;
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
         if ( A13CalifasId != Z13CalifasId )
         {
            A13CalifasId = Z13CalifasId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13CalifasId), 4, 0)));
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

      protected void CheckOptimisticConcurrency0511( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A13CalifasId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Califas"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z53Califas1 != T00052_A53Califas1[0] ) || ( Z54Califas2 != T00052_A54Califas2[0] ) || ( Z55Califas3 != T00052_A55Califas3[0] ) || ( Z56Califas4 != T00052_A56Califas4[0] ) || ( Z57Califas5 != T00052_A57Califas5[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z58Califas6 != T00052_A58Califas6[0] ) || ( Z59Califas7 != T00052_A59Califas7[0] ) || ( Z60Califas8 != T00052_A60Califas8[0] ) || ( Z3UsersId != T00052_A3UsersId[0] ) || ( Z11MateriasId != T00052_A11MateriasId[0] ) )
            {
               if ( Z53Califas1 != T00052_A53Califas1[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas1");
                  GXUtil.WriteLogRaw("Old: ",Z53Califas1);
                  GXUtil.WriteLogRaw("Current: ",T00052_A53Califas1[0]);
               }
               if ( Z54Califas2 != T00052_A54Califas2[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas2");
                  GXUtil.WriteLogRaw("Old: ",Z54Califas2);
                  GXUtil.WriteLogRaw("Current: ",T00052_A54Califas2[0]);
               }
               if ( Z55Califas3 != T00052_A55Califas3[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas3");
                  GXUtil.WriteLogRaw("Old: ",Z55Califas3);
                  GXUtil.WriteLogRaw("Current: ",T00052_A55Califas3[0]);
               }
               if ( Z56Califas4 != T00052_A56Califas4[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas4");
                  GXUtil.WriteLogRaw("Old: ",Z56Califas4);
                  GXUtil.WriteLogRaw("Current: ",T00052_A56Califas4[0]);
               }
               if ( Z57Califas5 != T00052_A57Califas5[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas5");
                  GXUtil.WriteLogRaw("Old: ",Z57Califas5);
                  GXUtil.WriteLogRaw("Current: ",T00052_A57Califas5[0]);
               }
               if ( Z58Califas6 != T00052_A58Califas6[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas6");
                  GXUtil.WriteLogRaw("Old: ",Z58Califas6);
                  GXUtil.WriteLogRaw("Current: ",T00052_A58Califas6[0]);
               }
               if ( Z59Califas7 != T00052_A59Califas7[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas7");
                  GXUtil.WriteLogRaw("Old: ",Z59Califas7);
                  GXUtil.WriteLogRaw("Current: ",T00052_A59Califas7[0]);
               }
               if ( Z60Califas8 != T00052_A60Califas8[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"Califas8");
                  GXUtil.WriteLogRaw("Old: ",Z60Califas8);
                  GXUtil.WriteLogRaw("Current: ",T00052_A60Califas8[0]);
               }
               if ( Z3UsersId != T00052_A3UsersId[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"UsersId");
                  GXUtil.WriteLogRaw("Old: ",Z3UsersId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A3UsersId[0]);
               }
               if ( Z11MateriasId != T00052_A11MateriasId[0] )
               {
                  GXUtil.WriteLog("califas:[seudo value changed for attri]"+"MateriasId");
                  GXUtil.WriteLogRaw("Old: ",Z11MateriasId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A11MateriasId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Califas"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0511( )
      {
         BeforeValidate0511( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0511( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0511( 0) ;
            CheckOptimisticConcurrency0511( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0511( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0511( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000512 */
                     pr_default.execute(10, new Object[] {A53Califas1, A54Califas2, A55Califas3, A56Califas4, A57Califas5, A58Califas6, A59Califas7, A60Califas8, A3UsersId, A11MateriasId});
                     A13CalifasId = T000512_A13CalifasId[0];
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Califas") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption050( ) ;
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
               Load0511( ) ;
            }
            EndLevel0511( ) ;
         }
         CloseExtendedTableCursors0511( ) ;
      }

      protected void Update0511( )
      {
         BeforeValidate0511( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0511( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0511( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0511( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0511( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000513 */
                     pr_default.execute(11, new Object[] {A53Califas1, A54Califas2, A55Califas3, A56Califas4, A57Califas5, A58Califas6, A59Califas7, A60Califas8, A3UsersId, A11MateriasId, A13CalifasId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Califas") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Califas"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0511( ) ;
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
            EndLevel0511( ) ;
         }
         CloseExtendedTableCursors0511( ) ;
      }

      protected void DeferredUpdate0511( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0511( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0511( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0511( ) ;
            AfterConfirm0511( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0511( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000514 */
                  pr_default.execute(12, new Object[] {A13CalifasId});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("Califas") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0511( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0511( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Califas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         }
      }

      protected void EndLevel0511( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0511( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("califas",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("califas",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0511( )
      {
         /* Scan By routine */
         /* Using cursor T000515 */
         pr_default.execute(13);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound11 = 1;
            A13CalifasId = T000515_A13CalifasId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0511( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound11 = 1;
            A13CalifasId = T000515_A13CalifasId[0];
         }
      }

      protected void ScanEnd0511( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0511( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0511( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0511( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0511( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0511( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0511( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0511( )
      {
         edtUsersId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         edtMateriasId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMateriasId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMateriasId_Enabled), 5, 0)), true);
         edtCalifas1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas1_Enabled), 5, 0)), true);
         edtCalifas2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas2_Enabled), 5, 0)), true);
         edtCalifas3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas3_Enabled), 5, 0)), true);
         edtCalifas4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas4_Enabled), 5, 0)), true);
         edtCalifas5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas5_Enabled), 5, 0)), true);
         edtCalifas6_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas6_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas6_Enabled), 5, 0)), true);
         edtCalifas7_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas7_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas7_Enabled), 5, 0)), true);
         edtCalifas8_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalifas8_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalifas8_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0511( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118522383", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("califas.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CalifasId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Califas";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_MateriasId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13CalifasId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("califas:[SendSecurityCheck value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV11Insert_UsersId), "ZZZ9"));
         GXUtil.WriteLog("califas:[SendSecurityCheck value for]"+"Insert_MateriasId:"+context.localUtil.Format( (decimal)(AV12Insert_MateriasId), "ZZZ9"));
         GXUtil.WriteLog("califas:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("califas:[SendSecurityCheck value for]"+"CalifasId:"+context.localUtil.Format( (decimal)(A13CalifasId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z13CalifasId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13CalifasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z53Califas1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z53Califas1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z54Califas2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z54Califas2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z55Califas3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z55Califas3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z56Califas4", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z56Califas4), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z57Califas5", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z57Califas5), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z58Califas6", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z58Califas6), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z59Califas7", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z59Califas7), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z60Califas8", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z60Califas8), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z11MateriasId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11MateriasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N11MateriasId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11MateriasId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCALIFASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CalifasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCALIFASID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CalifasId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CALIFASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13CalifasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_MATERIASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_MateriasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
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
         return formatLink("califas.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CalifasId) ;
      }

      public override String GetPgmname( )
      {
         return "Califas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Califas" ;
      }

      protected void InitializeNonKey0511( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         A11MateriasId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11MateriasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11MateriasId), 4, 0)));
         A53Califas1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53Califas1", StringUtil.LTrim( StringUtil.Str( (decimal)(A53Califas1), 3, 0)));
         A54Califas2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54Califas2", StringUtil.LTrim( StringUtil.Str( (decimal)(A54Califas2), 3, 0)));
         A55Califas3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55Califas3", StringUtil.LTrim( StringUtil.Str( (decimal)(A55Califas3), 3, 0)));
         A56Califas4 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56Califas4", StringUtil.LTrim( StringUtil.Str( (decimal)(A56Califas4), 3, 0)));
         A57Califas5 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57Califas5", StringUtil.LTrim( StringUtil.Str( (decimal)(A57Califas5), 3, 0)));
         A58Califas6 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58Califas6", StringUtil.LTrim( StringUtil.Str( (decimal)(A58Califas6), 3, 0)));
         A59Califas7 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59Califas7", StringUtil.LTrim( StringUtil.Str( (decimal)(A59Califas7), 3, 0)));
         A60Califas8 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60Califas8", StringUtil.LTrim( StringUtil.Str( (decimal)(A60Califas8), 3, 0)));
         Z53Califas1 = 0;
         Z54Califas2 = 0;
         Z55Califas3 = 0;
         Z56Califas4 = 0;
         Z57Califas5 = 0;
         Z58Califas6 = 0;
         Z59Califas7 = 0;
         Z60Califas8 = 0;
         Z3UsersId = 0;
         Z11MateriasId = 0;
      }

      protected void InitAll0511( )
      {
         A13CalifasId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13CalifasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13CalifasId), 4, 0)));
         InitializeNonKey0511( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201810111852245", true);
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
         context.AddJavascriptSource("califas.js", "?201810111852245", false);
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
         edtMateriasId_Internalname = "MATERIASID";
         edtCalifas1_Internalname = "CALIFAS1";
         edtCalifas2_Internalname = "CALIFAS2";
         edtCalifas3_Internalname = "CALIFAS3";
         edtCalifas4_Internalname = "CALIFAS4";
         edtCalifas5_Internalname = "CALIFAS5";
         edtCalifas6_Internalname = "CALIFAS6";
         edtCalifas7_Internalname = "CALIFAS7";
         edtCalifas8_Internalname = "CALIFAS8";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_3_Internalname = "PROMPT_3";
         imgprompt_11_Internalname = "PROMPT_11";
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
         Form.Caption = "Califas";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCalifas8_Jsonclick = "";
         edtCalifas8_Enabled = 1;
         edtCalifas7_Jsonclick = "";
         edtCalifas7_Enabled = 1;
         edtCalifas6_Jsonclick = "";
         edtCalifas6_Enabled = 1;
         edtCalifas5_Jsonclick = "";
         edtCalifas5_Enabled = 1;
         edtCalifas4_Jsonclick = "";
         edtCalifas4_Enabled = 1;
         edtCalifas3_Jsonclick = "";
         edtCalifas3_Enabled = 1;
         edtCalifas2_Jsonclick = "";
         edtCalifas2_Enabled = 1;
         edtCalifas1_Jsonclick = "";
         edtCalifas1_Enabled = 1;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtMateriasId_Jsonclick = "";
         edtMateriasId_Enabled = 1;
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
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Materiasid( short GX_Parm1 )
      {
         A11MateriasId = GX_Parm1;
         /* Using cursor T000517 */
         pr_default.execute(15, new Object[] {A11MateriasId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Materias'.", "ForeignKeyNotFound", 1, "MATERIASID");
            AnyError = 1;
            GX_FocusControl = edtMateriasId_Internalname;
         }
         pr_default.close(15);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CalifasId',fld:'vCALIFASID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CalifasId',fld:'vCALIFASID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_UsersId',fld:'vINSERT_USERSID',pic:'ZZZ9'},{av:'AV12Insert_MateriasId',fld:'vINSERT_MATERIASID',pic:'ZZZ9'},{av:'A13CalifasId',fld:'CALIFASID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(14);
         pr_default.close(15);
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
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode11 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         T00056_A13CalifasId = new short[1] ;
         T00056_A53Califas1 = new short[1] ;
         T00056_A54Califas2 = new short[1] ;
         T00056_A55Califas3 = new short[1] ;
         T00056_A56Califas4 = new short[1] ;
         T00056_A57Califas5 = new short[1] ;
         T00056_A58Califas6 = new short[1] ;
         T00056_A59Califas7 = new short[1] ;
         T00056_A60Califas8 = new short[1] ;
         T00056_A3UsersId = new short[1] ;
         T00056_A11MateriasId = new short[1] ;
         T00054_A3UsersId = new short[1] ;
         T00055_A11MateriasId = new short[1] ;
         T00057_A3UsersId = new short[1] ;
         T00058_A11MateriasId = new short[1] ;
         T00059_A13CalifasId = new short[1] ;
         T00053_A13CalifasId = new short[1] ;
         T00053_A53Califas1 = new short[1] ;
         T00053_A54Califas2 = new short[1] ;
         T00053_A55Califas3 = new short[1] ;
         T00053_A56Califas4 = new short[1] ;
         T00053_A57Califas5 = new short[1] ;
         T00053_A58Califas6 = new short[1] ;
         T00053_A59Califas7 = new short[1] ;
         T00053_A60Califas8 = new short[1] ;
         T00053_A3UsersId = new short[1] ;
         T00053_A11MateriasId = new short[1] ;
         T000510_A13CalifasId = new short[1] ;
         T000511_A13CalifasId = new short[1] ;
         T00052_A13CalifasId = new short[1] ;
         T00052_A53Califas1 = new short[1] ;
         T00052_A54Califas2 = new short[1] ;
         T00052_A55Califas3 = new short[1] ;
         T00052_A56Califas4 = new short[1] ;
         T00052_A57Califas5 = new short[1] ;
         T00052_A58Califas6 = new short[1] ;
         T00052_A59Califas7 = new short[1] ;
         T00052_A60Califas8 = new short[1] ;
         T00052_A3UsersId = new short[1] ;
         T00052_A11MateriasId = new short[1] ;
         T000512_A13CalifasId = new short[1] ;
         T000515_A13CalifasId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000516_A3UsersId = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000517_A11MateriasId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.califas__default(),
            new Object[][] {
                new Object[] {
               T00052_A13CalifasId, T00052_A53Califas1, T00052_A54Califas2, T00052_A55Califas3, T00052_A56Califas4, T00052_A57Califas5, T00052_A58Califas6, T00052_A59Califas7, T00052_A60Califas8, T00052_A3UsersId,
               T00052_A11MateriasId
               }
               , new Object[] {
               T00053_A13CalifasId, T00053_A53Califas1, T00053_A54Califas2, T00053_A55Califas3, T00053_A56Califas4, T00053_A57Califas5, T00053_A58Califas6, T00053_A59Califas7, T00053_A60Califas8, T00053_A3UsersId,
               T00053_A11MateriasId
               }
               , new Object[] {
               T00054_A3UsersId
               }
               , new Object[] {
               T00055_A11MateriasId
               }
               , new Object[] {
               T00056_A13CalifasId, T00056_A53Califas1, T00056_A54Califas2, T00056_A55Califas3, T00056_A56Califas4, T00056_A57Califas5, T00056_A58Califas6, T00056_A59Califas7, T00056_A60Califas8, T00056_A3UsersId,
               T00056_A11MateriasId
               }
               , new Object[] {
               T00057_A3UsersId
               }
               , new Object[] {
               T00058_A11MateriasId
               }
               , new Object[] {
               T00059_A13CalifasId
               }
               , new Object[] {
               T000510_A13CalifasId
               }
               , new Object[] {
               T000511_A13CalifasId
               }
               , new Object[] {
               T000512_A13CalifasId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000515_A13CalifasId
               }
               , new Object[] {
               T000516_A3UsersId
               }
               , new Object[] {
               T000517_A11MateriasId
               }
            }
         );
         AV14Pgmname = "Califas";
      }

      private short wcpOAV7CalifasId ;
      private short Z13CalifasId ;
      private short Z53Califas1 ;
      private short Z54Califas2 ;
      private short Z55Califas3 ;
      private short Z56Califas4 ;
      private short Z57Califas5 ;
      private short Z58Califas6 ;
      private short Z59Califas7 ;
      private short Z60Califas8 ;
      private short Z3UsersId ;
      private short Z11MateriasId ;
      private short N3UsersId ;
      private short N11MateriasId ;
      private short GxWebError ;
      private short A3UsersId ;
      private short A11MateriasId ;
      private short AV7CalifasId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A53Califas1 ;
      private short A54Califas2 ;
      private short A55Califas3 ;
      private short A56Califas4 ;
      private short A57Califas5 ;
      private short A58Califas6 ;
      private short A59Califas7 ;
      private short A60Califas8 ;
      private short A13CalifasId ;
      private short AV11Insert_UsersId ;
      private short AV12Insert_MateriasId ;
      private short RcdFound11 ;
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
      private int edtMateriasId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtCalifas1_Enabled ;
      private int edtCalifas2_Enabled ;
      private int edtCalifas3_Enabled ;
      private int edtCalifas4_Enabled ;
      private int edtCalifas5_Enabled ;
      private int edtCalifas6_Enabled ;
      private int edtCalifas7_Enabled ;
      private int edtCalifas8_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
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
      private String edtMateriasId_Internalname ;
      private String edtMateriasId_Jsonclick ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtCalifas1_Internalname ;
      private String edtCalifas1_Jsonclick ;
      private String edtCalifas2_Internalname ;
      private String edtCalifas2_Jsonclick ;
      private String edtCalifas3_Internalname ;
      private String edtCalifas3_Jsonclick ;
      private String edtCalifas4_Internalname ;
      private String edtCalifas4_Jsonclick ;
      private String edtCalifas5_Internalname ;
      private String edtCalifas5_Jsonclick ;
      private String edtCalifas6_Internalname ;
      private String edtCalifas6_Jsonclick ;
      private String edtCalifas7_Internalname ;
      private String edtCalifas7_Jsonclick ;
      private String edtCalifas8_Internalname ;
      private String edtCalifas8_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode11 ;
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
      private bool Gx_longc ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00056_A13CalifasId ;
      private short[] T00056_A53Califas1 ;
      private short[] T00056_A54Califas2 ;
      private short[] T00056_A55Califas3 ;
      private short[] T00056_A56Califas4 ;
      private short[] T00056_A57Califas5 ;
      private short[] T00056_A58Califas6 ;
      private short[] T00056_A59Califas7 ;
      private short[] T00056_A60Califas8 ;
      private short[] T00056_A3UsersId ;
      private short[] T00056_A11MateriasId ;
      private short[] T00054_A3UsersId ;
      private short[] T00055_A11MateriasId ;
      private short[] T00057_A3UsersId ;
      private short[] T00058_A11MateriasId ;
      private short[] T00059_A13CalifasId ;
      private short[] T00053_A13CalifasId ;
      private short[] T00053_A53Califas1 ;
      private short[] T00053_A54Califas2 ;
      private short[] T00053_A55Califas3 ;
      private short[] T00053_A56Califas4 ;
      private short[] T00053_A57Califas5 ;
      private short[] T00053_A58Califas6 ;
      private short[] T00053_A59Califas7 ;
      private short[] T00053_A60Califas8 ;
      private short[] T00053_A3UsersId ;
      private short[] T00053_A11MateriasId ;
      private short[] T000510_A13CalifasId ;
      private short[] T000511_A13CalifasId ;
      private short[] T00052_A13CalifasId ;
      private short[] T00052_A53Califas1 ;
      private short[] T00052_A54Califas2 ;
      private short[] T00052_A55Califas3 ;
      private short[] T00052_A56Califas4 ;
      private short[] T00052_A57Califas5 ;
      private short[] T00052_A58Califas6 ;
      private short[] T00052_A59Califas7 ;
      private short[] T00052_A60Califas8 ;
      private short[] T00052_A3UsersId ;
      private short[] T00052_A11MateriasId ;
      private short[] T000512_A13CalifasId ;
      private short[] T000515_A13CalifasId ;
      private short[] T000516_A3UsersId ;
      private short[] T000517_A11MateriasId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class califas__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
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
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@Califas1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas5",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas6",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas7",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas8",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@Califas1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas5",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas6",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas7",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Califas8",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@CalifasId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000517 ;
          prmT000517 = new Object[] {
          new Object[] {"@MateriasId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [CalifasId], [Califas1], [Califas2], [Califas3], [Califas4], [Califas5], [Califas6], [Califas7], [Califas8], [UsersId], [MateriasId] FROM [Califas] WITH (UPDLOCK) WHERE [CalifasId] = @CalifasId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new CursorDef("T00053", "SELECT [CalifasId], [Califas1], [Califas2], [Califas3], [Califas4], [Califas5], [Califas6], [Califas7], [Califas8], [UsersId], [MateriasId] FROM [Califas] WITH (NOLOCK) WHERE [CalifasId] = @CalifasId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new CursorDef("T00054", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,false )
             ,new CursorDef("T00055", "SELECT [MateriasId] FROM [Materias] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,false )
             ,new CursorDef("T00056", "SELECT TM1.[CalifasId], TM1.[Califas1], TM1.[Califas2], TM1.[Califas3], TM1.[Califas4], TM1.[Califas5], TM1.[Califas6], TM1.[Califas7], TM1.[Califas8], TM1.[UsersId], TM1.[MateriasId] FROM [Califas] TM1 WITH (NOLOCK) WHERE TM1.[CalifasId] = @CalifasId ORDER BY TM1.[CalifasId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,100,0,true,false )
             ,new CursorDef("T00057", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,false )
             ,new CursorDef("T00058", "SELECT [MateriasId] FROM [Materias] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1,0,true,false )
             ,new CursorDef("T00059", "SELECT [CalifasId] FROM [Califas] WITH (NOLOCK) WHERE [CalifasId] = @CalifasId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1,0,true,false )
             ,new CursorDef("T000510", "SELECT TOP 1 [CalifasId] FROM [Califas] WITH (NOLOCK) WHERE ( [CalifasId] > @CalifasId) ORDER BY [CalifasId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1,0,true,true )
             ,new CursorDef("T000511", "SELECT TOP 1 [CalifasId] FROM [Califas] WITH (NOLOCK) WHERE ( [CalifasId] < @CalifasId) ORDER BY [CalifasId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1,0,true,true )
             ,new CursorDef("T000512", "INSERT INTO [Califas]([Califas1], [Califas2], [Califas3], [Califas4], [Califas5], [Califas6], [Califas7], [Califas8], [UsersId], [MateriasId]) VALUES(@Califas1, @Califas2, @Califas3, @Califas4, @Califas5, @Califas6, @Califas7, @Califas8, @UsersId, @MateriasId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000512)
             ,new CursorDef("T000513", "UPDATE [Califas] SET [Califas1]=@Califas1, [Califas2]=@Califas2, [Califas3]=@Califas3, [Califas4]=@Califas4, [Califas5]=@Califas5, [Califas6]=@Califas6, [Califas7]=@Califas7, [Califas8]=@Califas8, [UsersId]=@UsersId, [MateriasId]=@MateriasId  WHERE [CalifasId] = @CalifasId", GxErrorMask.GX_NOMASK,prmT000513)
             ,new CursorDef("T000514", "DELETE FROM [Califas]  WHERE [CalifasId] = @CalifasId", GxErrorMask.GX_NOMASK,prmT000514)
             ,new CursorDef("T000515", "SELECT [CalifasId] FROM [Califas] WITH (NOLOCK) ORDER BY [CalifasId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,100,0,true,false )
             ,new CursorDef("T000516", "SELECT [UsersId] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1,0,true,false )
             ,new CursorDef("T000517", "SELECT [MateriasId] FROM [Materias] WITH (NOLOCK) WHERE [MateriasId] = @MateriasId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000517,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
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
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                stmt.SetParameter(11, (short)parms[10]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
