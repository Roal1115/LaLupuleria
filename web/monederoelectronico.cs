/*
               File: MonederoElectronico
        Description: Monedero Electronico
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:11.50
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
   public class monederoelectronico : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A3UsersId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A3UsersId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridmonederoelectronico_movimientos") == 0 )
         {
            nRC_GXsfl_53 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_53_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_53_idx = GetNextPar( );
            A42MovimientosLastLine = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A37MonederoElectronicoDepositos = NumberUtil.Val( GetNextPar( ), ".");
            n37MonederoElectronicoDepositos = false;
            A40MonederoElectronicoRetiros = NumberUtil.Val( GetNextPar( ), ".");
            n40MonederoElectronicoRetiros = false;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridmonederoelectronico_movimientos_newrow( ) ;
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
               AV10MonederoElectronicoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10MonederoElectronicoId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMONEDEROELECTRONICOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10MonederoElectronicoId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Monedero Electronico", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public monederoelectronico( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public monederoelectronico( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_MonederoElectronicoId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10MonederoElectronicoId = aP1_MonederoElectronicoId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbMovimientosTipoMonto = new GXCombobox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Monedero Electronico", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_MonederoElectronico.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_MonederoElectronico.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMonederoElectronicoApertura_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMonederoElectronicoApertura_Internalname, "Electronico Apertura", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtMonederoElectronicoApertura_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicoApertura_Internalname, context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"), context.localUtil.Format( A35MonederoElectronicoApertura, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicoApertura_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMonederoElectronicoApertura_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MonederoElectronico.htm");
            GxWebStd.gx_bitmap( context, edtMonederoElectronicoApertura_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtMonederoElectronicoApertura_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_MonederoElectronico.htm");
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
            GxWebStd.gx_label_element( context, edtUsersId_Internalname, "Clientes Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsersId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A3UsersId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsersId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsersId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_MonederoElectronico.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_MonederoElectronico.htm");
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
            GxWebStd.gx_label_element( context, edtMonederoElectronicosaldo_Internalname, "Electronicosaldo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMonederoElectronicosaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A36MonederoElectronicosaldo, 14, 2, ",", "")), ((edtMonederoElectronicosaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A36MonederoElectronicosaldo, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A36MonederoElectronicosaldo, "$ Z,ZZZ,ZZZ.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMonederoElectronicosaldo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMonederoElectronicosaldo_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "Currency", "right", false, "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMovimientostable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlemovimientos_Internalname, "Movimientos", "", "", lblTitlemovimientos_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridmonederoelectronico_movimientos( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MonederoElectronico.htm");
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

      protected void gxdraw_Gridmonederoelectronico_movimientos( )
      {
         /*  Grid Control  */
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("GridName", "Gridmonederoelectronico_movimientos");
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Header", subGridmonederoelectronico_movimientos_Header);
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Class", "Grid");
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Backcolorstyle), 1, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("CmpContext", "");
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("InMasterPage", "false");
         Gridmonederoelectronico_movimientosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ".", "")));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosId_Enabled), 5, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddColumnProperties(Gridmonederoelectronico_movimientosColumn);
         Gridmonederoelectronico_movimientosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Value", context.localUtil.Format(A41MovimientosFecha, "99/99/99"));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosFecha_Enabled), 5, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddColumnProperties(Gridmonederoelectronico_movimientosColumn);
         Gridmonederoelectronico_movimientosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ".", "")));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosCantidad_Enabled), 5, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddColumnProperties(Gridmonederoelectronico_movimientosColumn);
         Gridmonederoelectronico_movimientosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39MovimientosTipoMonto), 4, 0, ".", "")));
         Gridmonederoelectronico_movimientosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddColumnProperties(Gridmonederoelectronico_movimientosColumn);
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Selectedindex), 4, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Allowselection), 1, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Selectioncolor), 9, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Allowhovering), 1, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Hoveringcolor), 9, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Allowcollapsing), 1, 0, ".", "")));
         Gridmonederoelectronico_movimientosContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmonederoelectronico_movimientos_Collapsed), 1, 0, ".", "")));
         nGXsfl_53_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount7 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_7 = 1;
               ScanStart047( ) ;
               while ( RcdFound7 != 0 )
               {
                  init_level_properties7( ) ;
                  getByPrimaryKey047( ) ;
                  AddRow047( ) ;
                  ScanNext047( ) ;
               }
               ScanEnd047( ) ;
               nBlankRcdCount7 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B42MovimientosLastLine = A42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            sMode7 = Gx_mode;
            while ( nGXsfl_53_idx < nRC_GXsfl_53 )
            {
               bGXsfl_53_Refreshing = true;
               ReadRow047( ) ;
               edtMovimientosId_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSID_"+sGXsfl_53_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtMovimientosFecha_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSFECHA_"+sGXsfl_53_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosFecha_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtMovimientosCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosCantidad_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               cmbMovimientosTipoMonto.Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientosTipoMonto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               if ( ( nRcdExists_7 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal047( ) ;
               }
               SendRow047( ) ;
               bGXsfl_53_Refreshing = false;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A42MovimientosLastLine = B42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount7 = 5;
            nRcdExists_7 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart047( ) ;
               while ( RcdFound7 != 0 )
               {
                  sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_537( ) ;
                  init_level_properties7( ) ;
                  standaloneNotModal047( ) ;
                  getByPrimaryKey047( ) ;
                  standaloneModal047( ) ;
                  AddRow047( ) ;
                  ScanNext047( ) ;
               }
               ScanEnd047( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode7 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_537( ) ;
            InitAll047( ) ;
            init_level_properties7( ) ;
            B42MovimientosLastLine = A42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            nRcdExists_7 = 0;
            nIsMod_7 = 0;
            nRcdDeleted_7 = 0;
            nBlankRcdCount7 = (short)(nBlankRcdUsr7+nBlankRcdCount7);
            fRowAdded = 0;
            while ( nBlankRcdCount7 > 0 )
            {
               AddRow047( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtMovimientosFecha_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount7 = (short)(nBlankRcdCount7-1);
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A42MovimientosLastLine = B42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridmonederoelectronico_movimientosContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridmonederoelectronico_movimientos", Gridmonederoelectronico_movimientosContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridmonederoelectronico_movimientosContainerData", Gridmonederoelectronico_movimientosContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridmonederoelectronico_movimientosContainerData"+"V", Gridmonederoelectronico_movimientosContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridmonederoelectronico_movimientosContainerData"+"V"+"\" value='"+Gridmonederoelectronico_movimientosContainer.GridValuesHidden()+"'/>") ;
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
         E11042 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( context.localUtil.VCDate( cgiGet( edtMonederoElectronicoApertura_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Monedero Electronico Apertura"}), 1, "MONEDEROELECTRONICOAPERTURA");
                  AnyError = 1;
                  GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A35MonederoElectronicoApertura = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
               }
               else
               {
                  A35MonederoElectronicoApertura = context.localUtil.CToD( cgiGet( edtMonederoElectronicoApertura_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
               }
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
               A36MonederoElectronicosaldo = context.localUtil.CToN( cgiGet( edtMonederoElectronicosaldo_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
               /* Read saved values. */
               Z9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( "Z9MonederoElectronicoId"), ",", "."));
               Z35MonederoElectronicoApertura = context.localUtil.CToD( cgiGet( "Z35MonederoElectronicoApertura"), 0);
               Z42MovimientosLastLine = (short)(context.localUtil.CToN( cgiGet( "Z42MovimientosLastLine"), ",", "."));
               Z3UsersId = (short)(context.localUtil.CToN( cgiGet( "Z3UsersId"), ",", "."));
               A42MovimientosLastLine = (short)(context.localUtil.CToN( cgiGet( "Z42MovimientosLastLine"), ",", "."));
               O42MovimientosLastLine = (short)(context.localUtil.CToN( cgiGet( "O42MovimientosLastLine"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_53 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), ",", "."));
               N3UsersId = (short)(context.localUtil.CToN( cgiGet( "N3UsersId"), ",", "."));
               A37MonederoElectronicoDepositos = context.localUtil.CToN( cgiGet( "MONEDEROELECTRONICODEPOSITOS"), ",", ".");
               A40MonederoElectronicoRetiros = context.localUtil.CToN( cgiGet( "MONEDEROELECTRONICORETIROS"), ",", ".");
               AV10MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( "vMONEDEROELECTRONICOID"), ",", "."));
               A9MonederoElectronicoId = (short)(context.localUtil.CToN( cgiGet( "MONEDEROELECTRONICOID"), ",", "."));
               AV14Insert_UsersId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_USERSID"), ",", "."));
               A42MovimientosLastLine = (short)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSLASTLINE"), ",", "."));
               A4UsersName = cgiGet( "USERSNAME");
               AV17Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "MonederoElectronico";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_UsersId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("monederoelectronico:[SecurityCheckFailed value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV14Insert_UsersId), "ZZZ9"));
                  GXUtil.WriteLog("monederoelectronico:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("monederoelectronico:[SecurityCheckFailed value for]"+"MonederoElectronicoId:"+context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9"));
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
                  A9MonederoElectronicoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
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
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode6;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
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
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12042 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            E12042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll046( ) ;
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
            DisableAttributes046( ) ;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls046( ) ;
            }
            else
            {
               CheckExtendedTable046( ) ;
               CloseExtendedTableCursors046( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode6 = Gx_mode;
            CONFIRM_047( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode6;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_047( )
      {
         s42MovimientosLastLine = O42MovimientosLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         s36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow047( ) ;
            if ( ( nRcdExists_7 != 0 ) || ( nIsMod_7 != 0 ) )
            {
               GetKey047( ) ;
               if ( ( nRcdExists_7 == 0 ) && ( nRcdDeleted_7 == 0 ) )
               {
                  if ( RcdFound7 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate047( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable047( ) ;
                        CloseExtendedTableCursors047( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O42MovimientosLastLine = A42MovimientosLastLine;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                        O36MonederoElectronicosaldo = A36MonederoElectronicosaldo;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1;
                  }
               }
               else
               {
                  if ( RcdFound7 != 0 )
                  {
                     if ( nRcdDeleted_7 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey047( ) ;
                        Load047( ) ;
                        BeforeValidate047( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls047( ) ;
                           O42MovimientosLastLine = A42MovimientosLastLine;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                           O36MonederoElectronicosaldo = A36MonederoElectronicosaldo;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_7 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate047( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable047( ) ;
                              CloseExtendedTableCursors047( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O42MovimientosLastLine = A42MovimientosLastLine;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                              O36MonederoElectronicosaldo = A36MonederoElectronicosaldo;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_7 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            ChangePostValue( edtMovimientosId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", ""))) ;
            ChangePostValue( edtMovimientosFecha_Internalname, context.localUtil.Format(A41MovimientosFecha, "99/99/99")) ;
            ChangePostValue( edtMovimientosCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ",", ""))) ;
            ChangePostValue( cmbMovimientosTipoMonto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39MovimientosTipoMonto), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10MovimientosId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10MovimientosId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z41MovimientosFecha_"+sGXsfl_53_idx, context.localUtil.DToC( Z41MovimientosFecha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z38MovimientosCantidad_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( Z38MovimientosCantidad, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z39MovimientosTipoMonto_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39MovimientosTipoMonto), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", ""))) ;
            if ( nIsMod_7 != 0 )
            {
               ChangePostValue( "MOVIMIENTOSID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSFECHA_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosFecha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0, ".", ""))) ;
            }
         }
         O42MovimientosLastLine = s42MovimientosLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         O36MonederoElectronicosaldo = s36MonederoElectronicosaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         /* Start of After( level) rules */
         /* Using cursor T00045 */
         pr_default.execute(2, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A37MonederoElectronicoDepositos = T00045_A37MonederoElectronicoDepositos[0];
            n37MonederoElectronicoDepositos = T00045_n37MonederoElectronicoDepositos[0];
         }
         else
         {
            A37MonederoElectronicoDepositos = 0;
            n37MonederoElectronicoDepositos = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
         }
         /* Using cursor T00047 */
         pr_default.execute(3, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40MonederoElectronicoRetiros = T00047_A40MonederoElectronicoRetiros[0];
            n40MonederoElectronicoRetiros = T00047_n40MonederoElectronicoRetiros[0];
         }
         else
         {
            A40MonederoElectronicoRetiros = 0;
            n40MonederoElectronicoRetiros = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
         }
         A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV17Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
         AV14Insert_UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Insert_UsersId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV12TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV12TrnContext.gxTpr_Attributes.Count )
            {
               AV15TrnContextAtt = ((SdtTransactionContext_Attribute)AV12TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "UsersId") == 0 )
               {
                  AV14Insert_UsersId = (short)(NumberUtil.Val( AV15TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Insert_UsersId), 4, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV12TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwmonederoelectronico.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM046( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z35MonederoElectronicoApertura = T00049_A35MonederoElectronicoApertura[0];
               Z42MovimientosLastLine = T00049_A42MovimientosLastLine[0];
               Z3UsersId = T00049_A3UsersId[0];
            }
            else
            {
               Z35MonederoElectronicoApertura = A35MonederoElectronicoApertura;
               Z42MovimientosLastLine = A42MovimientosLastLine;
               Z3UsersId = A3UsersId;
            }
         }
         if ( GX_JID == -16 )
         {
            Z9MonederoElectronicoId = A9MonederoElectronicoId;
            Z35MonederoElectronicoApertura = A35MonederoElectronicoApertura;
            Z42MovimientosLastLine = A42MovimientosLastLine;
            Z3UsersId = A3UsersId;
            Z37MonederoElectronicoDepositos = A37MonederoElectronicoDepositos;
            Z40MonederoElectronicoRetiros = A40MonederoElectronicoRetiros;
            Z4UsersName = A4UsersName;
         }
      }

      protected void standaloneNotModal( )
      {
         edtMonederoElectronicosaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMonederoElectronicosaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicosaldo_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USERSID"+"'), id:'"+"USERSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV10MonederoElectronicoId) )
         {
            A9MonederoElectronicoId = AV10MonederoElectronicoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
         }
         /* Using cursor T00045 */
         pr_default.execute(2, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A37MonederoElectronicoDepositos = T00045_A37MonederoElectronicoDepositos[0];
            n37MonederoElectronicoDepositos = T00045_n37MonederoElectronicoDepositos[0];
         }
         else
         {
            A37MonederoElectronicoDepositos = 0;
            n37MonederoElectronicoDepositos = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
         }
         pr_default.close(2);
         /* Using cursor T00047 */
         pr_default.execute(3, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40MonederoElectronicoRetiros = T00047_A40MonederoElectronicoRetiros[0];
            n40MonederoElectronicoRetiros = T00047_n40MonederoElectronicoRetiros[0];
         }
         else
         {
            A40MonederoElectronicoRetiros = 0;
            n40MonederoElectronicoRetiros = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
         }
         pr_default.close(3);
         A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_UsersId) )
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_UsersId) )
         {
            A3UsersId = AV14Insert_UsersId;
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
            AV17Pgmname = "MonederoElectronico";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000410 */
            pr_default.execute(6, new Object[] {A3UsersId});
            A4UsersName = T000410_A4UsersName[0];
            pr_default.close(6);
         }
      }

      protected void Load046( )
      {
         /* Using cursor T000413 */
         pr_default.execute(7, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound6 = 1;
            A35MonederoElectronicoApertura = T000413_A35MonederoElectronicoApertura[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
            A4UsersName = T000413_A4UsersName[0];
            A42MovimientosLastLine = T000413_A42MovimientosLastLine[0];
            A3UsersId = T000413_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            A37MonederoElectronicoDepositos = T000413_A37MonederoElectronicoDepositos[0];
            n37MonederoElectronicoDepositos = T000413_n37MonederoElectronicoDepositos[0];
            A40MonederoElectronicoRetiros = T000413_A40MonederoElectronicoRetiros[0];
            n40MonederoElectronicoRetiros = T000413_n40MonederoElectronicoRetiros[0];
            ZM046( -16) ;
         }
         pr_default.close(7);
         OnLoadActions046( ) ;
      }

      protected void OnLoadActions046( )
      {
         AV17Pgmname = "MonederoElectronico";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable046( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV17Pgmname = "MonederoElectronico";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         if ( ! ( (DateTime.MinValue==A35MonederoElectronicoApertura) || ( A35MonederoElectronicoApertura >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Monedero Electronico Apertura fuera de rango", "OutOfRange", 1, "MONEDEROELECTRONICOAPERTURA");
            AnyError = 1;
            GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000410 */
         pr_default.execute(6, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A4UsersName = T000410_A4UsersName[0];
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors046( )
      {
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_17( short A3UsersId )
      {
         /* Using cursor T000414 */
         pr_default.execute(8, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A4UsersName = T000414_A4UsersName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4UsersName))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void GetKey046( )
      {
         /* Using cursor T000415 */
         pr_default.execute(9, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00049 */
         pr_default.execute(5, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM046( 16) ;
            RcdFound6 = 1;
            A9MonederoElectronicoId = T00049_A9MonederoElectronicoId[0];
            A35MonederoElectronicoApertura = T00049_A35MonederoElectronicoApertura[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
            A42MovimientosLastLine = T00049_A42MovimientosLastLine[0];
            A3UsersId = T00049_A3UsersId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
            O42MovimientosLastLine = A42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            Z9MonederoElectronicoId = A9MonederoElectronicoId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load046( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey046( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey046( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey046( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T000416 */
         pr_default.execute(10, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000416_A9MonederoElectronicoId[0] < A9MonederoElectronicoId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000416_A9MonederoElectronicoId[0] > A9MonederoElectronicoId ) ) )
            {
               A9MonederoElectronicoId = T000416_A9MonederoElectronicoId[0];
               RcdFound6 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T000417 */
         pr_default.execute(11, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000417_A9MonederoElectronicoId[0] > A9MonederoElectronicoId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000417_A9MonederoElectronicoId[0] < A9MonederoElectronicoId ) ) )
            {
               A9MonederoElectronicoId = T000417_A9MonederoElectronicoId[0];
               RcdFound6 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey046( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A42MovimientosLastLine = O42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
            GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert046( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A9MonederoElectronicoId != Z9MonederoElectronicoId )
               {
                  A9MonederoElectronicoId = Z9MonederoElectronicoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A42MovimientosLastLine = O42MovimientosLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                  A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A42MovimientosLastLine = O42MovimientosLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                  A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                  Update046( ) ;
                  GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A9MonederoElectronicoId != Z9MonederoElectronicoId )
               {
                  /* Insert record */
                  A42MovimientosLastLine = O42MovimientosLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                  A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                  GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert046( ) ;
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
                     A42MovimientosLastLine = O42MovimientosLastLine;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                     A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                     GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert046( ) ;
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
         if ( A9MonederoElectronicoId != Z9MonederoElectronicoId )
         {
            A9MonederoElectronicoId = Z9MonederoElectronicoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "");
            AnyError = 1;
         }
         else
         {
            A42MovimientosLastLine = O42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtMonederoElectronicoApertura_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00048 */
            pr_default.execute(4, new Object[] {A9MonederoElectronicoId});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MonederoElectronico"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) || ( Z35MonederoElectronicoApertura != T00048_A35MonederoElectronicoApertura[0] ) || ( Z42MovimientosLastLine != T00048_A42MovimientosLastLine[0] ) || ( Z3UsersId != T00048_A3UsersId[0] ) )
            {
               if ( Z35MonederoElectronicoApertura != T00048_A35MonederoElectronicoApertura[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"MonederoElectronicoApertura");
                  GXUtil.WriteLogRaw("Old: ",Z35MonederoElectronicoApertura);
                  GXUtil.WriteLogRaw("Current: ",T00048_A35MonederoElectronicoApertura[0]);
               }
               if ( Z42MovimientosLastLine != T00048_A42MovimientosLastLine[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"MovimientosLastLine");
                  GXUtil.WriteLogRaw("Old: ",Z42MovimientosLastLine);
                  GXUtil.WriteLogRaw("Current: ",T00048_A42MovimientosLastLine[0]);
               }
               if ( Z3UsersId != T00048_A3UsersId[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"UsersId");
                  GXUtil.WriteLogRaw("Old: ",Z3UsersId);
                  GXUtil.WriteLogRaw("Current: ",T00048_A3UsersId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MonederoElectronico"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM046( 0) ;
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000418 */
                     pr_default.execute(12, new Object[] {A35MonederoElectronicoApertura, A42MovimientosLastLine, A3UsersId});
                     A9MonederoElectronicoId = T000418_A9MonederoElectronicoId[0];
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronico") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel046( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption040( ) ;
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
               Load046( ) ;
            }
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void Update046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000419 */
                     pr_default.execute(13, new Object[] {A35MonederoElectronicoApertura, A42MovimientosLastLine, A3UsersId, A9MonederoElectronicoId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronico") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MonederoElectronico"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate046( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel046( ) ;
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
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void DeferredUpdate046( )
      {
      }

      protected void delete( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls046( ) ;
            AfterConfirm046( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete046( ) ;
               if ( AnyError == 0 )
               {
                  A42MovimientosLastLine = O42MovimientosLastLine;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                  A36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                  ScanStart047( ) ;
                  while ( RcdFound7 != 0 )
                  {
                     getByPrimaryKey047( ) ;
                     Delete047( ) ;
                     ScanNext047( ) ;
                     O42MovimientosLastLine = A42MovimientosLastLine;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
                     O36MonederoElectronicosaldo = A36MonederoElectronicosaldo;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
                  }
                  ScanEnd047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000420 */
                     pr_default.execute(14, new Object[] {A9MonederoElectronicoId});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronico") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel046( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls046( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "MonederoElectronico";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000421 */
            pr_default.execute(15, new Object[] {A3UsersId});
            A4UsersName = T000421_A4UsersName[0];
            pr_default.close(15);
         }
      }

      protected void ProcessNestedLevel047( )
      {
         s42MovimientosLastLine = O42MovimientosLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         s36MonederoElectronicosaldo = O36MonederoElectronicosaldo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow047( ) ;
            if ( ( nRcdExists_7 != 0 ) || ( nIsMod_7 != 0 ) )
            {
               standaloneNotModal047( ) ;
               GetKey047( ) ;
               if ( ( nRcdExists_7 == 0 ) && ( nRcdDeleted_7 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert047( ) ;
               }
               else
               {
                  if ( RcdFound7 != 0 )
                  {
                     if ( ( nRcdDeleted_7 != 0 ) && ( nRcdExists_7 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete047( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_7 != 0 ) && ( nRcdExists_7 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update047( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_7 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               O42MovimientosLastLine = A42MovimientosLastLine;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
               O36MonederoElectronicosaldo = A36MonederoElectronicosaldo;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
            }
            ChangePostValue( edtMovimientosId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", ""))) ;
            ChangePostValue( edtMovimientosFecha_Internalname, context.localUtil.Format(A41MovimientosFecha, "99/99/99")) ;
            ChangePostValue( edtMovimientosCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ",", ""))) ;
            ChangePostValue( cmbMovimientosTipoMonto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39MovimientosTipoMonto), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10MovimientosId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10MovimientosId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z41MovimientosFecha_"+sGXsfl_53_idx, context.localUtil.DToC( Z41MovimientosFecha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z38MovimientosCantidad_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( Z38MovimientosCantidad, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z39MovimientosTipoMonto_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39MovimientosTipoMonto), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_7_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", ""))) ;
            if ( nIsMod_7 != 0 )
            {
               ChangePostValue( "MOVIMIENTOSID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSFECHA_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosFecha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* Using cursor T000423 */
         pr_default.execute(16, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A37MonederoElectronicoDepositos = T000423_A37MonederoElectronicoDepositos[0];
            n37MonederoElectronicoDepositos = T000423_n37MonederoElectronicoDepositos[0];
         }
         else
         {
            A37MonederoElectronicoDepositos = 0;
            n37MonederoElectronicoDepositos = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37MonederoElectronicoDepositos", StringUtil.LTrim( StringUtil.Str( A37MonederoElectronicoDepositos, 10, 2)));
         }
         /* Using cursor T000425 */
         pr_default.execute(17, new Object[] {A9MonederoElectronicoId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            A40MonederoElectronicoRetiros = T000425_A40MonederoElectronicoRetiros[0];
            n40MonederoElectronicoRetiros = T000425_n40MonederoElectronicoRetiros[0];
         }
         else
         {
            A40MonederoElectronicoRetiros = 0;
            n40MonederoElectronicoRetiros = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40MonederoElectronicoRetiros", StringUtil.LTrim( StringUtil.Str( A40MonederoElectronicoRetiros, 10, 2)));
         }
         A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         /* End of After( level) rules */
         InitAll047( ) ;
         if ( AnyError != 0 )
         {
            O42MovimientosLastLine = s42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            O36MonederoElectronicosaldo = s36MonederoElectronicosaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         }
         nRcdExists_7 = 0;
         nIsMod_7 = 0;
         nRcdDeleted_7 = 0;
      }

      protected void ProcessLevel046( )
      {
         /* Save parent mode. */
         sMode6 = Gx_mode;
         ProcessNestedLevel047( ) ;
         if ( AnyError != 0 )
         {
            O42MovimientosLastLine = s42MovimientosLastLine;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
            O36MonederoElectronicosaldo = s36MonederoElectronicosaldo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000426 */
         pr_default.execute(18, new Object[] {A42MovimientosLastLine, A9MonederoElectronicoId});
         pr_default.close(18);
         dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronico") ;
      }

      protected void EndLevel046( )
      {
         pr_default.close(4);
         if ( AnyError == 0 )
         {
            BeforeComplete046( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(15);
            pr_default.close(16);
            pr_default.close(17);
            context.CommitDataStores("monederoelectronico",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(15);
            pr_default.close(16);
            pr_default.close(17);
            context.RollbackDataStores("monederoelectronico",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart046( )
      {
         /* Scan By routine */
         /* Using cursor T000427 */
         pr_default.execute(19);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound6 = 1;
            A9MonederoElectronicoId = T000427_A9MonederoElectronicoId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext046( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound6 = 1;
            A9MonederoElectronicoId = T000427_A9MonederoElectronicoId[0];
         }
      }

      protected void ScanEnd046( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm046( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert046( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate046( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete046( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete046( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate046( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes046( )
      {
         edtMonederoElectronicoApertura_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMonederoElectronicoApertura_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicoApertura_Enabled), 5, 0)), true);
         edtUsersId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsersId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsersId_Enabled), 5, 0)), true);
         edtMonederoElectronicosaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMonederoElectronicosaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicosaldo_Enabled), 5, 0)), true);
      }

      protected void ZM047( short GX_JID )
      {
         if ( ( GX_JID == 20 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z41MovimientosFecha = T00043_A41MovimientosFecha[0];
               Z38MovimientosCantidad = T00043_A38MovimientosCantidad[0];
               Z39MovimientosTipoMonto = T00043_A39MovimientosTipoMonto[0];
            }
            else
            {
               Z41MovimientosFecha = A41MovimientosFecha;
               Z38MovimientosCantidad = A38MovimientosCantidad;
               Z39MovimientosTipoMonto = A39MovimientosTipoMonto;
            }
         }
         if ( GX_JID == -20 )
         {
            Z9MonederoElectronicoId = A9MonederoElectronicoId;
            Z10MovimientosId = A10MovimientosId;
            Z41MovimientosFecha = A41MovimientosFecha;
            Z38MovimientosCantidad = A38MovimientosCantidad;
            Z39MovimientosTipoMonto = A39MovimientosTipoMonto;
         }
      }

      protected void standaloneNotModal047( )
      {
         edtMovimientosId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtMonederoElectronicosaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMonederoElectronicosaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicosaldo_Enabled), 5, 0)), true);
         edtMonederoElectronicosaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMonederoElectronicosaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMonederoElectronicosaldo_Enabled), 5, 0)), true);
         A36MonederoElectronicosaldo = (decimal)(A37MonederoElectronicoDepositos-A40MonederoElectronicoRetiros);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36MonederoElectronicosaldo", StringUtil.LTrim( StringUtil.Str( A36MonederoElectronicosaldo, 10, 2)));
      }

      protected void standaloneModal047( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A42MovimientosLastLine = (short)(O42MovimientosLastLine+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A10MovimientosId = A42MovimientosLastLine;
         }
      }

      protected void Load047( )
      {
         /* Using cursor T000428 */
         pr_default.execute(20, new Object[] {A9MonederoElectronicoId, A10MovimientosId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound7 = 1;
            A41MovimientosFecha = T000428_A41MovimientosFecha[0];
            A38MovimientosCantidad = T000428_A38MovimientosCantidad[0];
            A39MovimientosTipoMonto = T000428_A39MovimientosTipoMonto[0];
            ZM047( -20) ;
         }
         pr_default.close(20);
         OnLoadActions047( ) ;
      }

      protected void OnLoadActions047( )
      {
      }

      protected void CheckExtendedTable047( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal047( ) ;
         if ( ! ( (DateTime.MinValue==A41MovimientosFecha) || ( A41MovimientosFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "MOVIMIENTOSFECHA_" + sGXsfl_53_idx;
            GX_msglist.addItem("Campo Movimientos Fecha fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtMovimientosFecha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors047( )
      {
      }

      protected void enableDisable047( )
      {
      }

      protected void GetKey047( )
      {
         /* Using cursor T000429 */
         pr_default.execute(21, new Object[] {A9MonederoElectronicoId, A10MovimientosId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey047( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A9MonederoElectronicoId, A10MovimientosId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM047( 20) ;
            RcdFound7 = 1;
            InitializeNonKey047( ) ;
            A10MovimientosId = T00043_A10MovimientosId[0];
            A41MovimientosFecha = T00043_A41MovimientosFecha[0];
            A38MovimientosCantidad = T00043_A38MovimientosCantidad[0];
            A39MovimientosTipoMonto = T00043_A39MovimientosTipoMonto[0];
            Z9MonederoElectronicoId = A9MonederoElectronicoId;
            Z10MovimientosId = A10MovimientosId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load047( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey047( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal047( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes047( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A9MonederoElectronicoId, A10MovimientosId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MonederoElectronicoMovimientos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z41MovimientosFecha != T00042_A41MovimientosFecha[0] ) || ( Z38MovimientosCantidad != T00042_A38MovimientosCantidad[0] ) || ( Z39MovimientosTipoMonto != T00042_A39MovimientosTipoMonto[0] ) )
            {
               if ( Z41MovimientosFecha != T00042_A41MovimientosFecha[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"MovimientosFecha");
                  GXUtil.WriteLogRaw("Old: ",Z41MovimientosFecha);
                  GXUtil.WriteLogRaw("Current: ",T00042_A41MovimientosFecha[0]);
               }
               if ( Z38MovimientosCantidad != T00042_A38MovimientosCantidad[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"MovimientosCantidad");
                  GXUtil.WriteLogRaw("Old: ",Z38MovimientosCantidad);
                  GXUtil.WriteLogRaw("Current: ",T00042_A38MovimientosCantidad[0]);
               }
               if ( Z39MovimientosTipoMonto != T00042_A39MovimientosTipoMonto[0] )
               {
                  GXUtil.WriteLog("monederoelectronico:[seudo value changed for attri]"+"MovimientosTipoMonto");
                  GXUtil.WriteLogRaw("Old: ",Z39MovimientosTipoMonto);
                  GXUtil.WriteLogRaw("Current: ",T00042_A39MovimientosTipoMonto[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MonederoElectronicoMovimientos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM047( 0) ;
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000430 */
                     pr_default.execute(22, new Object[] {A9MonederoElectronicoId, A10MovimientosId, A41MovimientosFecha, A38MovimientosCantidad, A39MovimientosTipoMonto});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronicoMovimientos") ;
                     if ( (pr_default.getStatus(22) == 1) )
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
               Load047( ) ;
            }
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void Update047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000431 */
                     pr_default.execute(23, new Object[] {A41MovimientosFecha, A38MovimientosCantidad, A39MovimientosTipoMonto, A9MonederoElectronicoId, A10MovimientosId});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronicoMovimientos") ;
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MonederoElectronicoMovimientos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate047( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey047( ) ;
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
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void DeferredUpdate047( )
      {
      }

      protected void Delete047( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls047( ) ;
            AfterConfirm047( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete047( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000432 */
                  pr_default.execute(24, new Object[] {A9MonederoElectronicoId, A10MovimientosId});
                  pr_default.close(24);
                  dsDefault.SmartCacheProvider.SetUpdated("MonederoElectronicoMovimientos") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel047( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls047( )
      {
         standaloneModal047( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel047( )
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

      public void ScanStart047( )
      {
         /* Scan By routine */
         /* Using cursor T000433 */
         pr_default.execute(25, new Object[] {A9MonederoElectronicoId});
         RcdFound7 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound7 = 1;
            A10MovimientosId = T000433_A10MovimientosId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext047( )
      {
         /* Scan next routine */
         pr_default.readNext(25);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound7 = 1;
            A10MovimientosId = T000433_A10MovimientosId[0];
         }
      }

      protected void ScanEnd047( )
      {
         pr_default.close(25);
      }

      protected void AfterConfirm047( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert047( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate047( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete047( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete047( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate047( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes047( )
      {
         edtMovimientosId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtMovimientosFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosFecha_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtMovimientosCantidad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosCantidad_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         cmbMovimientosTipoMonto.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientosTipoMonto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0)), !bGXsfl_53_Refreshing);
      }

      protected void send_integrity_lvl_hashes047( )
      {
      }

      protected void send_integrity_lvl_hashes046( )
      {
      }

      protected void SubsflControlProps_537( )
      {
         edtMovimientosId_Internalname = "MOVIMIENTOSID_"+sGXsfl_53_idx;
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA_"+sGXsfl_53_idx;
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx;
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_537( )
      {
         edtMovimientosId_Internalname = "MOVIMIENTOSID_"+sGXsfl_53_fel_idx;
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA_"+sGXsfl_53_fel_idx;
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_fel_idx;
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_fel_idx;
      }

      protected void AddRow047( )
      {
         nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_537( ) ;
         SendRow047( ) ;
      }

      protected void SendRow047( )
      {
         Gridmonederoelectronico_movimientosRow = GXWebRow.GetNew(context);
         if ( subGridmonederoelectronico_movimientos_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridmonederoelectronico_movimientos_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridmonederoelectronico_movimientos_Class, "") != 0 )
            {
               subGridmonederoelectronico_movimientos_Linesclass = subGridmonederoelectronico_movimientos_Class+"Odd";
            }
         }
         else if ( subGridmonederoelectronico_movimientos_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridmonederoelectronico_movimientos_Backstyle = 0;
            subGridmonederoelectronico_movimientos_Backcolor = subGridmonederoelectronico_movimientos_Allbackcolor;
            if ( StringUtil.StrCmp(subGridmonederoelectronico_movimientos_Class, "") != 0 )
            {
               subGridmonederoelectronico_movimientos_Linesclass = subGridmonederoelectronico_movimientos_Class+"Uniform";
            }
         }
         else if ( subGridmonederoelectronico_movimientos_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridmonederoelectronico_movimientos_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridmonederoelectronico_movimientos_Class, "") != 0 )
            {
               subGridmonederoelectronico_movimientos_Linesclass = subGridmonederoelectronico_movimientos_Class+"Odd";
            }
            subGridmonederoelectronico_movimientos_Backcolor = (int)(0x0);
         }
         else if ( subGridmonederoelectronico_movimientos_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridmonederoelectronico_movimientos_Backstyle = 1;
            if ( ((int)(((nGXsfl_53_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridmonederoelectronico_movimientos_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridmonederoelectronico_movimientos_Class, "") != 0 )
               {
                  subGridmonederoelectronico_movimientos_Linesclass = subGridmonederoelectronico_movimientos_Class+"Odd";
               }
            }
            else
            {
               subGridmonederoelectronico_movimientos_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridmonederoelectronico_movimientos_Class, "") != 0 )
               {
                  subGridmonederoelectronico_movimientos_Linesclass = subGridmonederoelectronico_movimientos_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridmonederoelectronico_movimientosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10MovimientosId), 4, 0, ",", "")),((edtMovimientosId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10MovimientosId), "ZZZ9")) : context.localUtil.Format( (decimal)(A10MovimientosId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientosId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtMovimientosId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridmonederoelectronico_movimientosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosFecha_Internalname,context.localUtil.Format(A41MovimientosFecha, "99/99/99"),context.localUtil.Format( A41MovimientosFecha, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientosFecha_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtMovimientosFecha_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridmonederoelectronico_movimientosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientosCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A38MovimientosCantidad, 14, 2, ",", "")),((edtMovimientosCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A38MovimientosCantidad, "$ Z,ZZZ,ZZZ.99")) : context.localUtil.Format( A38MovimientosCantidad, "$ Z,ZZZ,ZZZ.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientosCantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtMovimientosCantidad_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"Currency",(String)"right",(bool)false});
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_53_idx + "',53)\"";
         if ( ( cmbMovimientosTipoMonto.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "MOVIMIENTOSTIPOMONTO_" + sGXsfl_53_idx;
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
         Gridmonederoelectronico_movimientosRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbMovimientosTipoMonto,(String)cmbMovimientosTipoMonto_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0)),(short)1,(String)cmbMovimientosTipoMonto_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,cmbMovimientosTipoMonto.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"",(String)"",(bool)true});
         cmbMovimientosTipoMonto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A39MovimientosTipoMonto), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientosTipoMonto_Internalname, "Values", (String)(cmbMovimientosTipoMonto.ToJavascriptSource()), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_sending_grid_row(Gridmonederoelectronico_movimientosRow);
         send_integrity_lvl_hashes047( ) ;
         GXCCtl = "Z10MovimientosId_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10MovimientosId), 4, 0, ",", "")));
         GXCCtl = "Z41MovimientosFecha_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z41MovimientosFecha, 0, "/"));
         GXCCtl = "Z38MovimientosCantidad_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z38MovimientosCantidad, 10, 2, ",", "")));
         GXCCtl = "Z39MovimientosTipoMonto_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39MovimientosTipoMonto), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_7_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_7_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", "")));
         GXCCtl = "nIsMod_7_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_53_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV12TrnContext);
         }
         GXCCtl = "vMONEDEROELECTRONICOID_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10MonederoElectronicoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSFECHA_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosFecha_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientosCantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbMovimientosTipoMonto.Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridmonederoelectronico_movimientosContainer.AddRow(Gridmonederoelectronico_movimientosRow);
      }

      protected void ReadRow047( )
      {
         nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_537( ) ;
         edtMovimientosId_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSID_"+sGXsfl_53_idx+"Enabled"), ",", "."));
         edtMovimientosFecha_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSFECHA_"+sGXsfl_53_idx+"Enabled"), ",", "."));
         edtMovimientosCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSCANTIDAD_"+sGXsfl_53_idx+"Enabled"), ",", "."));
         cmbMovimientosTipoMonto.Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOSTIPOMONTO_"+sGXsfl_53_idx+"Enabled"), ",", "."));
         A10MovimientosId = (short)(context.localUtil.CToN( cgiGet( edtMovimientosId_Internalname), ",", "."));
         if ( context.localUtil.VCDate( cgiGet( edtMovimientosFecha_Internalname), 2) == 0 )
         {
            GXCCtl = "MOVIMIENTOSFECHA_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Movimientos Fecha"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtMovimientosFecha_Internalname;
            wbErr = true;
            A41MovimientosFecha = DateTime.MinValue;
         }
         else
         {
            A41MovimientosFecha = context.localUtil.CToD( cgiGet( edtMovimientosFecha_Internalname), 2);
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtMovimientosCantidad_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovimientosCantidad_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "MOVIMIENTOSCANTIDAD_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtMovimientosCantidad_Internalname;
            wbErr = true;
            A38MovimientosCantidad = 0;
         }
         else
         {
            A38MovimientosCantidad = context.localUtil.CToN( cgiGet( edtMovimientosCantidad_Internalname), ",", ".");
         }
         cmbMovimientosTipoMonto.Name = cmbMovimientosTipoMonto_Internalname;
         cmbMovimientosTipoMonto.CurrentValue = cgiGet( cmbMovimientosTipoMonto_Internalname);
         A39MovimientosTipoMonto = (short)(NumberUtil.Val( cgiGet( cmbMovimientosTipoMonto_Internalname), "."));
         GXCCtl = "Z10MovimientosId_" + sGXsfl_53_idx;
         Z10MovimientosId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z41MovimientosFecha_" + sGXsfl_53_idx;
         Z41MovimientosFecha = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "Z38MovimientosCantidad_" + sGXsfl_53_idx;
         Z38MovimientosCantidad = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "Z39MovimientosTipoMonto_" + sGXsfl_53_idx;
         Z39MovimientosTipoMonto = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_7_" + sGXsfl_53_idx;
         nRcdDeleted_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_7_" + sGXsfl_53_idx;
         nRcdExists_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_7_" + sGXsfl_53_idx;
         nIsMod_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtMovimientosId_Enabled = edtMovimientosId_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_53_idx = 0;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_537( ) ;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_537( ) ;
            ChangePostValue( "Z10MovimientosId_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z10MovimientosId_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z10MovimientosId_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z41MovimientosFecha_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z41MovimientosFecha_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z41MovimientosFecha_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z38MovimientosCantidad_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z38MovimientosCantidad_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z38MovimientosCantidad_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z39MovimientosTipoMonto_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z39MovimientosTipoMonto_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z39MovimientosTipoMonto_"+sGXsfl_53_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118521784", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("monederoelectronico.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10MonederoElectronicoId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "MonederoElectronico";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_UsersId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("monederoelectronico:[SendSecurityCheck value for]"+"Insert_UsersId:"+context.localUtil.Format( (decimal)(AV14Insert_UsersId), "ZZZ9"));
         GXUtil.WriteLog("monederoelectronico:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("monederoelectronico:[SendSecurityCheck value for]"+"MonederoElectronicoId:"+context.localUtil.Format( (decimal)(A9MonederoElectronicoId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z9MonederoElectronicoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9MonederoElectronicoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z35MonederoElectronicoApertura", context.localUtil.DToC( Z35MonederoElectronicoApertura, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z42MovimientosLastLine", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42MovimientosLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O42MovimientosLastLine", StringUtil.LTrim( StringUtil.NToC( (decimal)(O42MovimientosLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_53_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N3UsersId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3UsersId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV12TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "MONEDEROELECTRONICODEPOSITOS", StringUtil.LTrim( StringUtil.NToC( A37MonederoElectronicoDepositos, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "MONEDEROELECTRONICORETIROS", StringUtil.LTrim( StringUtil.NToC( A40MonederoElectronicoRetiros, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMONEDEROELECTRONICOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10MonederoElectronicoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMONEDEROELECTRONICOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10MonederoElectronicoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "MONEDEROELECTRONICOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9MonederoElectronicoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_USERSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Insert_UsersId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOSLASTLINE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42MovimientosLastLine), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USERSNAME", StringUtil.RTrim( A4UsersName));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
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
         return formatLink("monederoelectronico.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10MonederoElectronicoId) ;
      }

      public override String GetPgmname( )
      {
         return "MonederoElectronico" ;
      }

      public override String GetPgmdesc( )
      {
         return "Monedero Electronico" ;
      }

      protected void InitializeNonKey046( )
      {
         A3UsersId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsersId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3UsersId), 4, 0)));
         A35MonederoElectronicoApertura = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35MonederoElectronicoApertura", context.localUtil.Format(A35MonederoElectronicoApertura, "99/99/99"));
         A4UsersName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsersName", A4UsersName);
         A42MovimientosLastLine = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         O42MovimientosLastLine = A42MovimientosLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
         Z35MonederoElectronicoApertura = DateTime.MinValue;
         Z42MovimientosLastLine = 0;
         Z3UsersId = 0;
      }

      protected void InitAll046( )
      {
         A9MonederoElectronicoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MonederoElectronicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A9MonederoElectronicoId), 4, 0)));
         InitializeNonKey046( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey047( )
      {
         A41MovimientosFecha = DateTime.MinValue;
         A38MovimientosCantidad = 0;
         A39MovimientosTipoMonto = 0;
         Z41MovimientosFecha = DateTime.MinValue;
         Z38MovimientosCantidad = 0;
         Z39MovimientosTipoMonto = 0;
      }

      protected void InitAll047( )
      {
         A10MovimientosId = 0;
         InitializeNonKey047( ) ;
      }

      protected void StandaloneModalInsert047( )
      {
         A42MovimientosLastLine = i42MovimientosLastLine;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42MovimientosLastLine", StringUtil.LTrim( StringUtil.Str( (decimal)(A42MovimientosLastLine), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118521819", true);
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
         context.AddJavascriptSource("monederoelectronico.js", "?2018101118521819", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties7( )
      {
         edtMovimientosId_Enabled = defedtMovimientosId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientosId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientosId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
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
         edtMonederoElectronicoApertura_Internalname = "MONEDEROELECTRONICOAPERTURA";
         edtUsersId_Internalname = "USERSID";
         edtMonederoElectronicosaldo_Internalname = "MONEDEROELECTRONICOSALDO";
         lblTitlemovimientos_Internalname = "TITLEMOVIMIENTOS";
         edtMovimientosId_Internalname = "MOVIMIENTOSID";
         edtMovimientosFecha_Internalname = "MOVIMIENTOSFECHA";
         edtMovimientosCantidad_Internalname = "MOVIMIENTOSCANTIDAD";
         cmbMovimientosTipoMonto_Internalname = "MOVIMIENTOSTIPOMONTO";
         divMovimientostable_Internalname = "MOVIMIENTOSTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_3_Internalname = "PROMPT_3";
         subGridmonederoelectronico_movimientos_Internalname = "GRIDMONEDEROELECTRONICO_MOVIMIENTOS";
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
         Form.Caption = "Monedero Electronico";
         cmbMovimientosTipoMonto_Jsonclick = "";
         edtMovimientosCantidad_Jsonclick = "";
         edtMovimientosFecha_Jsonclick = "";
         edtMovimientosId_Jsonclick = "";
         subGridmonederoelectronico_movimientos_Class = "Grid";
         subGridmonederoelectronico_movimientos_Backcolorstyle = 0;
         subGridmonederoelectronico_movimientos_Allowcollapsing = 0;
         subGridmonederoelectronico_movimientos_Allowselection = 0;
         cmbMovimientosTipoMonto.Enabled = 1;
         edtMovimientosCantidad_Enabled = 1;
         edtMovimientosFecha_Enabled = 1;
         edtMovimientosId_Enabled = 0;
         subGridmonederoelectronico_movimientos_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtMonederoElectronicosaldo_Jsonclick = "";
         edtMonederoElectronicosaldo_Enabled = 0;
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         edtUsersId_Jsonclick = "";
         edtUsersId_Enabled = 1;
         edtMonederoElectronicoApertura_Jsonclick = "";
         edtMonederoElectronicoApertura_Enabled = 1;
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

      protected void gxnrGridmonederoelectronico_movimientos_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_537( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow047( ) ;
            nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_537( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridmonederoelectronico_movimientosContainer));
         /* End function gxnrGridmonederoelectronico_movimientos_newrow */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "MOVIMIENTOSTIPOMONTO_" + sGXsfl_53_idx;
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

      public void Valid_Usersid( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A3UsersId = GX_Parm1;
         A4UsersName = GX_Parm2;
         /* Using cursor T000421 */
         pr_default.execute(15, new Object[] {A3UsersId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe ' T4'.", "ForeignKeyNotFound", 1, "USERSID");
            AnyError = 1;
            GX_FocusControl = edtUsersId_Internalname;
         }
         A4UsersName = T000421_A4UsersName[0];
         pr_default.close(15);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A4UsersName = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A4UsersName));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10MonederoElectronicoId',fld:'vMONEDEROELECTRONICOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10MonederoElectronicoId',fld:'vMONEDEROELECTRONICOID',pic:'ZZZ9',hsh:true},{av:'AV14Insert_UsersId',fld:'vINSERT_USERSID',pic:'ZZZ9'},{av:'A9MonederoElectronicoId',fld:'MONEDEROELECTRONICOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12042',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(5);
         pr_default.close(15);
         pr_default.close(16);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z35MonederoElectronicoApertura = DateTime.MinValue;
         Z41MovimientosFecha = DateTime.MinValue;
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
         A35MonederoElectronicoApertura = DateTime.MinValue;
         sImgUrl = "";
         lblTitlemovimientos_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridmonederoelectronico_movimientosContainer = new GXWebGrid( context);
         Gridmonederoelectronico_movimientosColumn = new GXWebColumn();
         A41MovimientosFecha = DateTime.MinValue;
         sMode7 = "";
         sStyleString = "";
         A4UsersName = "";
         AV17Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00045_A37MonederoElectronicoDepositos = new decimal[1] ;
         T00045_n37MonederoElectronicoDepositos = new bool[] {false} ;
         T00047_A40MonederoElectronicoRetiros = new decimal[1] ;
         T00047_n40MonederoElectronicoRetiros = new bool[] {false} ;
         AV12TrnContext = new SdtTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV15TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z4UsersName = "";
         T000410_A4UsersName = new String[] {""} ;
         T000413_A9MonederoElectronicoId = new short[1] ;
         T000413_A35MonederoElectronicoApertura = new DateTime[] {DateTime.MinValue} ;
         T000413_A4UsersName = new String[] {""} ;
         T000413_A42MovimientosLastLine = new short[1] ;
         T000413_A3UsersId = new short[1] ;
         T000413_A37MonederoElectronicoDepositos = new decimal[1] ;
         T000413_n37MonederoElectronicoDepositos = new bool[] {false} ;
         T000413_A40MonederoElectronicoRetiros = new decimal[1] ;
         T000413_n40MonederoElectronicoRetiros = new bool[] {false} ;
         T000414_A4UsersName = new String[] {""} ;
         T000415_A9MonederoElectronicoId = new short[1] ;
         T00049_A9MonederoElectronicoId = new short[1] ;
         T00049_A35MonederoElectronicoApertura = new DateTime[] {DateTime.MinValue} ;
         T00049_A42MovimientosLastLine = new short[1] ;
         T00049_A3UsersId = new short[1] ;
         T000416_A9MonederoElectronicoId = new short[1] ;
         T000417_A9MonederoElectronicoId = new short[1] ;
         T00048_A9MonederoElectronicoId = new short[1] ;
         T00048_A35MonederoElectronicoApertura = new DateTime[] {DateTime.MinValue} ;
         T00048_A42MovimientosLastLine = new short[1] ;
         T00048_A3UsersId = new short[1] ;
         T000418_A9MonederoElectronicoId = new short[1] ;
         T000421_A4UsersName = new String[] {""} ;
         T000423_A37MonederoElectronicoDepositos = new decimal[1] ;
         T000423_n37MonederoElectronicoDepositos = new bool[] {false} ;
         T000425_A40MonederoElectronicoRetiros = new decimal[1] ;
         T000425_n40MonederoElectronicoRetiros = new bool[] {false} ;
         T000427_A9MonederoElectronicoId = new short[1] ;
         T000428_A9MonederoElectronicoId = new short[1] ;
         T000428_A10MovimientosId = new short[1] ;
         T000428_A41MovimientosFecha = new DateTime[] {DateTime.MinValue} ;
         T000428_A38MovimientosCantidad = new decimal[1] ;
         T000428_A39MovimientosTipoMonto = new short[1] ;
         GXCCtl = "";
         T000429_A9MonederoElectronicoId = new short[1] ;
         T000429_A10MovimientosId = new short[1] ;
         T00043_A9MonederoElectronicoId = new short[1] ;
         T00043_A10MovimientosId = new short[1] ;
         T00043_A41MovimientosFecha = new DateTime[] {DateTime.MinValue} ;
         T00043_A38MovimientosCantidad = new decimal[1] ;
         T00043_A39MovimientosTipoMonto = new short[1] ;
         T00042_A9MonederoElectronicoId = new short[1] ;
         T00042_A10MovimientosId = new short[1] ;
         T00042_A41MovimientosFecha = new DateTime[] {DateTime.MinValue} ;
         T00042_A38MovimientosCantidad = new decimal[1] ;
         T00042_A39MovimientosTipoMonto = new short[1] ;
         T000433_A9MonederoElectronicoId = new short[1] ;
         T000433_A10MovimientosId = new short[1] ;
         Gridmonederoelectronico_movimientosRow = new GXWebRow();
         subGridmonederoelectronico_movimientos_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.monederoelectronico__default(),
            new Object[][] {
                new Object[] {
               T00042_A9MonederoElectronicoId, T00042_A10MovimientosId, T00042_A41MovimientosFecha, T00042_A38MovimientosCantidad, T00042_A39MovimientosTipoMonto
               }
               , new Object[] {
               T00043_A9MonederoElectronicoId, T00043_A10MovimientosId, T00043_A41MovimientosFecha, T00043_A38MovimientosCantidad, T00043_A39MovimientosTipoMonto
               }
               , new Object[] {
               T00045_A37MonederoElectronicoDepositos, T00045_n37MonederoElectronicoDepositos
               }
               , new Object[] {
               T00047_A40MonederoElectronicoRetiros, T00047_n40MonederoElectronicoRetiros
               }
               , new Object[] {
               T00048_A9MonederoElectronicoId, T00048_A35MonederoElectronicoApertura, T00048_A42MovimientosLastLine, T00048_A3UsersId
               }
               , new Object[] {
               T00049_A9MonederoElectronicoId, T00049_A35MonederoElectronicoApertura, T00049_A42MovimientosLastLine, T00049_A3UsersId
               }
               , new Object[] {
               T000410_A4UsersName
               }
               , new Object[] {
               T000413_A9MonederoElectronicoId, T000413_A35MonederoElectronicoApertura, T000413_A4UsersName, T000413_A42MovimientosLastLine, T000413_A3UsersId, T000413_A37MonederoElectronicoDepositos, T000413_n37MonederoElectronicoDepositos, T000413_A40MonederoElectronicoRetiros, T000413_n40MonederoElectronicoRetiros
               }
               , new Object[] {
               T000414_A4UsersName
               }
               , new Object[] {
               T000415_A9MonederoElectronicoId
               }
               , new Object[] {
               T000416_A9MonederoElectronicoId
               }
               , new Object[] {
               T000417_A9MonederoElectronicoId
               }
               , new Object[] {
               T000418_A9MonederoElectronicoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000421_A4UsersName
               }
               , new Object[] {
               T000423_A37MonederoElectronicoDepositos, T000423_n37MonederoElectronicoDepositos
               }
               , new Object[] {
               T000425_A40MonederoElectronicoRetiros, T000425_n40MonederoElectronicoRetiros
               }
               , new Object[] {
               }
               , new Object[] {
               T000427_A9MonederoElectronicoId
               }
               , new Object[] {
               T000428_A9MonederoElectronicoId, T000428_A10MovimientosId, T000428_A41MovimientosFecha, T000428_A38MovimientosCantidad, T000428_A39MovimientosTipoMonto
               }
               , new Object[] {
               T000429_A9MonederoElectronicoId, T000429_A10MovimientosId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000433_A9MonederoElectronicoId, T000433_A10MovimientosId
               }
            }
         );
         AV17Pgmname = "MonederoElectronico";
      }

      private short wcpOAV10MonederoElectronicoId ;
      private short Z9MonederoElectronicoId ;
      private short Z42MovimientosLastLine ;
      private short Z3UsersId ;
      private short O42MovimientosLastLine ;
      private short nRC_GXsfl_53 ;
      private short nGXsfl_53_idx=1 ;
      private short N3UsersId ;
      private short Z10MovimientosId ;
      private short Z39MovimientosTipoMonto ;
      private short nRcdDeleted_7 ;
      private short nRcdExists_7 ;
      private short nIsMod_7 ;
      private short GxWebError ;
      private short A3UsersId ;
      private short A42MovimientosLastLine ;
      private short Gx_BScreen ;
      private short AV10MonederoElectronicoId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridmonederoelectronico_movimientos_Backcolorstyle ;
      private short A10MovimientosId ;
      private short A39MovimientosTipoMonto ;
      private short subGridmonederoelectronico_movimientos_Allowselection ;
      private short subGridmonederoelectronico_movimientos_Allowhovering ;
      private short subGridmonederoelectronico_movimientos_Allowcollapsing ;
      private short subGridmonederoelectronico_movimientos_Collapsed ;
      private short nBlankRcdCount7 ;
      private short RcdFound7 ;
      private short B42MovimientosLastLine ;
      private short nBlankRcdUsr7 ;
      private short A9MonederoElectronicoId ;
      private short AV14Insert_UsersId ;
      private short RcdFound6 ;
      private short s42MovimientosLastLine ;
      private short GX_JID ;
      private short subGridmonederoelectronico_movimientos_Backstyle ;
      private short gxajaxcallmode ;
      private short i42MovimientosLastLine ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtMonederoElectronicoApertura_Enabled ;
      private int edtUsersId_Enabled ;
      private int imgprompt_3_Visible ;
      private int edtMonederoElectronicosaldo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtMovimientosId_Enabled ;
      private int edtMovimientosFecha_Enabled ;
      private int edtMovimientosCantidad_Enabled ;
      private int subGridmonederoelectronico_movimientos_Selectedindex ;
      private int subGridmonederoelectronico_movimientos_Selectioncolor ;
      private int subGridmonederoelectronico_movimientos_Hoveringcolor ;
      private int fRowAdded ;
      private int AV18GXV1 ;
      private int subGridmonederoelectronico_movimientos_Backcolor ;
      private int subGridmonederoelectronico_movimientos_Allbackcolor ;
      private int defedtMovimientosId_Enabled ;
      private int idxLst ;
      private long GRIDMONEDEROELECTRONICO_MOVIMIENTOS_nFirstRecordOnPage ;
      private decimal Z38MovimientosCantidad ;
      private decimal A37MonederoElectronicoDepositos ;
      private decimal A40MonederoElectronicoRetiros ;
      private decimal A36MonederoElectronicosaldo ;
      private decimal A38MovimientosCantidad ;
      private decimal s36MonederoElectronicosaldo ;
      private decimal O36MonederoElectronicosaldo ;
      private decimal Z37MonederoElectronicoDepositos ;
      private decimal Z40MonederoElectronicoRetiros ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_53_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtMonederoElectronicoApertura_Internalname ;
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
      private String edtMonederoElectronicoApertura_Jsonclick ;
      private String edtUsersId_Internalname ;
      private String edtUsersId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_3_Internalname ;
      private String imgprompt_3_Link ;
      private String edtMonederoElectronicosaldo_Internalname ;
      private String edtMonederoElectronicosaldo_Jsonclick ;
      private String divMovimientostable_Internalname ;
      private String lblTitlemovimientos_Internalname ;
      private String lblTitlemovimientos_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridmonederoelectronico_movimientos_Header ;
      private String sMode7 ;
      private String edtMovimientosId_Internalname ;
      private String edtMovimientosFecha_Internalname ;
      private String edtMovimientosCantidad_Internalname ;
      private String cmbMovimientosTipoMonto_Internalname ;
      private String sStyleString ;
      private String A4UsersName ;
      private String AV17Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z4UsersName ;
      private String GXCCtl ;
      private String sGXsfl_53_fel_idx="0001" ;
      private String subGridmonederoelectronico_movimientos_Class ;
      private String subGridmonederoelectronico_movimientos_Linesclass ;
      private String ROClassString ;
      private String edtMovimientosId_Jsonclick ;
      private String edtMovimientosFecha_Jsonclick ;
      private String edtMovimientosCantidad_Jsonclick ;
      private String cmbMovimientosTipoMonto_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridmonederoelectronico_movimientos_Internalname ;
      private DateTime Z35MonederoElectronicoApertura ;
      private DateTime Z41MovimientosFecha ;
      private DateTime A35MonederoElectronicoApertura ;
      private DateTime A41MovimientosFecha ;
      private bool entryPointCalled ;
      private bool n37MonederoElectronicoDepositos ;
      private bool n40MonederoElectronicoRetiros ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_53_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV13WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridmonederoelectronico_movimientosContainer ;
      private GXWebRow Gridmonederoelectronico_movimientosRow ;
      private GXWebColumn Gridmonederoelectronico_movimientosColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMovimientosTipoMonto ;
      private IDataStoreProvider pr_default ;
      private decimal[] T00045_A37MonederoElectronicoDepositos ;
      private bool[] T00045_n37MonederoElectronicoDepositos ;
      private decimal[] T00047_A40MonederoElectronicoRetiros ;
      private bool[] T00047_n40MonederoElectronicoRetiros ;
      private String[] T000410_A4UsersName ;
      private short[] T000413_A9MonederoElectronicoId ;
      private DateTime[] T000413_A35MonederoElectronicoApertura ;
      private String[] T000413_A4UsersName ;
      private short[] T000413_A42MovimientosLastLine ;
      private short[] T000413_A3UsersId ;
      private decimal[] T000413_A37MonederoElectronicoDepositos ;
      private bool[] T000413_n37MonederoElectronicoDepositos ;
      private decimal[] T000413_A40MonederoElectronicoRetiros ;
      private bool[] T000413_n40MonederoElectronicoRetiros ;
      private String[] T000414_A4UsersName ;
      private short[] T000415_A9MonederoElectronicoId ;
      private short[] T00049_A9MonederoElectronicoId ;
      private DateTime[] T00049_A35MonederoElectronicoApertura ;
      private short[] T00049_A42MovimientosLastLine ;
      private short[] T00049_A3UsersId ;
      private short[] T000416_A9MonederoElectronicoId ;
      private short[] T000417_A9MonederoElectronicoId ;
      private short[] T00048_A9MonederoElectronicoId ;
      private DateTime[] T00048_A35MonederoElectronicoApertura ;
      private short[] T00048_A42MovimientosLastLine ;
      private short[] T00048_A3UsersId ;
      private short[] T000418_A9MonederoElectronicoId ;
      private String[] T000421_A4UsersName ;
      private decimal[] T000423_A37MonederoElectronicoDepositos ;
      private bool[] T000423_n37MonederoElectronicoDepositos ;
      private decimal[] T000425_A40MonederoElectronicoRetiros ;
      private bool[] T000425_n40MonederoElectronicoRetiros ;
      private short[] T000427_A9MonederoElectronicoId ;
      private short[] T000428_A9MonederoElectronicoId ;
      private short[] T000428_A10MovimientosId ;
      private DateTime[] T000428_A41MovimientosFecha ;
      private decimal[] T000428_A38MovimientosCantidad ;
      private short[] T000428_A39MovimientosTipoMonto ;
      private short[] T000429_A9MonederoElectronicoId ;
      private short[] T000429_A10MovimientosId ;
      private short[] T00043_A9MonederoElectronicoId ;
      private short[] T00043_A10MovimientosId ;
      private DateTime[] T00043_A41MovimientosFecha ;
      private decimal[] T00043_A38MovimientosCantidad ;
      private short[] T00043_A39MovimientosTipoMonto ;
      private short[] T00042_A9MonederoElectronicoId ;
      private short[] T00042_A10MovimientosId ;
      private DateTime[] T00042_A41MovimientosFecha ;
      private decimal[] T00042_A38MovimientosCantidad ;
      private short[] T00042_A39MovimientosTipoMonto ;
      private short[] T000433_A9MonederoElectronicoId ;
      private short[] T000433_A10MovimientosId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV12TrnContext ;
      private SdtTransactionContext_Attribute AV15TrnContextAtt ;
   }

   public class monederoelectronico__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@MonederoElectronicoApertura",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientosLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@MonederoElectronicoApertura",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientosLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000426 ;
          prmT000426 = new Object[] {
          new Object[] {"@MovimientosLastLine",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000427 ;
          prmT000427 = new Object[] {
          } ;
          Object[] prmT000428 ;
          prmT000428 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000429 ;
          prmT000429 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000430 ;
          prmT000430 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientosCantidad",SqlDbType.Decimal,10,2} ,
          new Object[] {"@MovimientosTipoMonto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000431 ;
          prmT000431 = new Object[] {
          new Object[] {"@MovimientosFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientosCantidad",SqlDbType.Decimal,10,2} ,
          new Object[] {"@MovimientosTipoMonto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000432 ;
          prmT000432 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientosId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000433 ;
          prmT000433 = new Object[] {
          new Object[] {"@MonederoElectronicoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@UsersId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [MonederoElectronicoId], [MovimientosId], [MovimientosFecha], [MovimientosCantidad], [MovimientosTipoMonto] FROM [MonederoElectronicoMovimientos] WITH (UPDLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId AND [MovimientosId] = @MovimientosId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [MonederoElectronicoId], [MovimientosId], [MovimientosFecha], [MovimientosCantidad], [MovimientosTipoMonto] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId AND [MovimientosId] = @MovimientosId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00045", "SELECT COALESCE( T1.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoDepositos FROM (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (UPDLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00047", "SELECT COALESCE( T1.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoRetiros FROM (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (UPDLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,false )
             ,new CursorDef("T00048", "SELECT [MonederoElectronicoId], [MonederoElectronicoApertura], [MovimientosLastLine], [UsersId] FROM [MonederoElectronico] WITH (UPDLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "SELECT [MonederoElectronicoId], [MonederoElectronicoApertura], [MovimientosLastLine], [UsersId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1,0,true,false )
             ,new CursorDef("T000410", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,false )
             ,new CursorDef("T000413", "SELECT TM1.[MonederoElectronicoId], TM1.[MonederoElectronicoApertura], T4.[UsersName], TM1.[MovimientosLastLine], TM1.[UsersId], COALESCE( T2.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoDepositos, COALESCE( T3.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoRetiros FROM ((([MonederoElectronico] TM1 WITH (NOLOCK) LEFT JOIN (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T2 ON T2.[MonederoElectronicoId] = TM1.[MonederoElectronicoId]) LEFT JOIN (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T3 ON T3.[MonederoElectronicoId] = TM1.[MonederoElectronicoId]) INNER JOIN [Users] T4 WITH (NOLOCK) ON T4.[UsersId] = TM1.[UsersId]) WHERE TM1.[MonederoElectronicoId] = @MonederoElectronicoId ORDER BY TM1.[MonederoElectronicoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,100,0,true,false )
             ,new CursorDef("T000414", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,1,0,true,false )
             ,new CursorDef("T000415", "SELECT [MonederoElectronicoId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,1,0,true,false )
             ,new CursorDef("T000416", "SELECT TOP 1 [MonederoElectronicoId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE ( [MonederoElectronicoId] > @MonederoElectronicoId) ORDER BY [MonederoElectronicoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1,0,true,true )
             ,new CursorDef("T000417", "SELECT TOP 1 [MonederoElectronicoId] FROM [MonederoElectronico] WITH (NOLOCK) WHERE ( [MonederoElectronicoId] < @MonederoElectronicoId) ORDER BY [MonederoElectronicoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,1,0,true,true )
             ,new CursorDef("T000418", "INSERT INTO [MonederoElectronico]([MonederoElectronicoApertura], [MovimientosLastLine], [UsersId]) VALUES(@MonederoElectronicoApertura, @MovimientosLastLine, @UsersId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000418)
             ,new CursorDef("T000419", "UPDATE [MonederoElectronico] SET [MonederoElectronicoApertura]=@MonederoElectronicoApertura, [MovimientosLastLine]=@MovimientosLastLine, [UsersId]=@UsersId  WHERE [MonederoElectronicoId] = @MonederoElectronicoId", GxErrorMask.GX_NOMASK,prmT000419)
             ,new CursorDef("T000420", "DELETE FROM [MonederoElectronico]  WHERE [MonederoElectronicoId] = @MonederoElectronicoId", GxErrorMask.GX_NOMASK,prmT000420)
             ,new CursorDef("T000421", "SELECT [UsersName] FROM [Users] WITH (NOLOCK) WHERE [UsersId] = @UsersId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000421,1,0,true,false )
             ,new CursorDef("T000423", "SELECT COALESCE( T1.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoDepositos FROM (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (UPDLOCK) WHERE [MovimientosTipoMonto] = 2 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000423,1,0,true,false )
             ,new CursorDef("T000425", "SELECT COALESCE( T1.[MonederoElectronicoDepositos], 0) AS MonederoElectronicoRetiros FROM (SELECT SUM([MovimientosCantidad]) AS MonederoElectronicoDepositos, [MonederoElectronicoId] FROM [MonederoElectronicoMovimientos] WITH (UPDLOCK) WHERE [MovimientosTipoMonto] = 1 GROUP BY [MonederoElectronicoId] ) T1 WHERE T1.[MonederoElectronicoId] = @MonederoElectronicoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000425,1,0,true,false )
             ,new CursorDef("T000426", "UPDATE [MonederoElectronico] SET [MovimientosLastLine]=@MovimientosLastLine  WHERE [MonederoElectronicoId] = @MonederoElectronicoId", GxErrorMask.GX_NOMASK,prmT000426)
             ,new CursorDef("T000427", "SELECT [MonederoElectronicoId] FROM [MonederoElectronico] WITH (NOLOCK) ORDER BY [MonederoElectronicoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000427,100,0,true,false )
             ,new CursorDef("T000428", "SELECT [MonederoElectronicoId], [MovimientosId], [MovimientosFecha], [MovimientosCantidad], [MovimientosTipoMonto] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId and [MovimientosId] = @MovimientosId ORDER BY [MonederoElectronicoId], [MovimientosId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000428,11,0,true,false )
             ,new CursorDef("T000429", "SELECT [MonederoElectronicoId], [MovimientosId] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId AND [MovimientosId] = @MovimientosId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000429,1,0,true,false )
             ,new CursorDef("T000430", "INSERT INTO [MonederoElectronicoMovimientos]([MonederoElectronicoId], [MovimientosId], [MovimientosFecha], [MovimientosCantidad], [MovimientosTipoMonto]) VALUES(@MonederoElectronicoId, @MovimientosId, @MovimientosFecha, @MovimientosCantidad, @MovimientosTipoMonto)", GxErrorMask.GX_NOMASK,prmT000430)
             ,new CursorDef("T000431", "UPDATE [MonederoElectronicoMovimientos] SET [MovimientosFecha]=@MovimientosFecha, [MovimientosCantidad]=@MovimientosCantidad, [MovimientosTipoMonto]=@MovimientosTipoMonto  WHERE [MonederoElectronicoId] = @MonederoElectronicoId AND [MovimientosId] = @MovimientosId", GxErrorMask.GX_NOMASK,prmT000431)
             ,new CursorDef("T000432", "DELETE FROM [MonederoElectronicoMovimientos]  WHERE [MonederoElectronicoId] = @MonederoElectronicoId AND [MovimientosId] = @MovimientosId", GxErrorMask.GX_NOMASK,prmT000432)
             ,new CursorDef("T000433", "SELECT [MonederoElectronicoId], [MovimientosId] FROM [MonederoElectronicoMovimientos] WITH (NOLOCK) WHERE [MonederoElectronicoId] = @MonederoElectronicoId ORDER BY [MonederoElectronicoId], [MovimientosId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000433,11,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 9 :
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
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 16 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 23 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
