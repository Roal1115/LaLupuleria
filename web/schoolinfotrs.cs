/*
               File: SchoolInfoTrs
        Description: School Info Trs
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:52:39.65
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
   public class schoolinfotrs : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7SchoolInfoTrsId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7SchoolInfoTrsId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSCHOOLINFOTRSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SchoolInfoTrsId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "School Info Trs", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public schoolinfotrs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public schoolinfotrs( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_SchoolInfoTrsId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7SchoolInfoTrsId = aP1_SchoolInfoTrsId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "School Info Trs", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SchoolInfoTrs.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SchoolInfoTrs.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSchoolInfoTrsId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSchoolInfoTrsId_Internalname, "Trs Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSchoolInfoTrsId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A74SchoolInfoTrsId), 4, 0, ",", "")), ((edtSchoolInfoTrsId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9")) : context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSchoolInfoTrsId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSchoolInfoTrsId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoId", "right", false, "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSchoolInfoTrsNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSchoolInfoTrsNombre_Internalname, "Trs Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSchoolInfoTrsNombre_Internalname, StringUtil.RTrim( A75SchoolInfoTrsNombre), "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, 1, edtSchoolInfoTrsNombre_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSchoolInfoTrsSolgan_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSchoolInfoTrsSolgan_Internalname, "Trs Solgan", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSchoolInfoTrsSolgan_Internalname, StringUtil.RTrim( A76SchoolInfoTrsSolgan), "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, 1, edtSchoolInfoTrsSolgan_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSchoolInfoTrsAddress_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSchoolInfoTrsAddress_Internalname, "Trs Address", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSchoolInfoTrsAddress_Internalname, A77SchoolInfoTrsAddress, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A77SchoolInfoTrsAddress), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, 1, edtSchoolInfoTrsAddress_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSchoolInfoTrsPhone_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSchoolInfoTrsPhone_Internalname, "Trs Phone", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            if ( context.isSmartDevice( ) )
            {
               gxphoneLink = "tel:" + StringUtil.RTrim( A78SchoolInfoTrsPhone);
            }
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSchoolInfoTrsPhone_Internalname, StringUtil.RTrim( A78SchoolInfoTrsPhone), StringUtil.RTrim( context.localUtil.Format( A78SchoolInfoTrsPhone, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", gxphoneLink, "", "", "", edtSchoolInfoTrsPhone_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSchoolInfoTrsPhone_Enabled, 0, "tel", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Phone", "left", true, "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgSchoolInfoTrsImagen_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgSchoolInfoTrsImagen_Internalname, "Trs Imagen", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A79SchoolInfoTrsImagen_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SchoolInfoTrsImagen_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.PathToRelativeUrl( A79SchoolInfoTrsImagen));
            GxWebStd.gx_bitmap( context, imgSchoolInfoTrsImagen_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgSchoolInfoTrsImagen_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", "", "", 0, A79SchoolInfoTrsImagen_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_SchoolInfoTrs.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.PathToRelativeUrl( A79SchoolInfoTrsImagen)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "IsBlob", StringUtil.BoolToStr( A79SchoolInfoTrsImagen_IsBlob), true);
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SchoolInfoTrs.htm");
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
         E110D2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A74SchoolInfoTrsId = (short)(context.localUtil.CToN( cgiGet( edtSchoolInfoTrsId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
               A75SchoolInfoTrsNombre = cgiGet( edtSchoolInfoTrsNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75SchoolInfoTrsNombre", A75SchoolInfoTrsNombre);
               A76SchoolInfoTrsSolgan = cgiGet( edtSchoolInfoTrsSolgan_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76SchoolInfoTrsSolgan", A76SchoolInfoTrsSolgan);
               A77SchoolInfoTrsAddress = cgiGet( edtSchoolInfoTrsAddress_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77SchoolInfoTrsAddress", A77SchoolInfoTrsAddress);
               A78SchoolInfoTrsPhone = cgiGet( edtSchoolInfoTrsPhone_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78SchoolInfoTrsPhone", A78SchoolInfoTrsPhone);
               A79SchoolInfoTrsImagen = cgiGet( imgSchoolInfoTrsImagen_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79SchoolInfoTrsImagen", A79SchoolInfoTrsImagen);
               /* Read saved values. */
               Z74SchoolInfoTrsId = (short)(context.localUtil.CToN( cgiGet( "Z74SchoolInfoTrsId"), ",", "."));
               Z75SchoolInfoTrsNombre = cgiGet( "Z75SchoolInfoTrsNombre");
               Z76SchoolInfoTrsSolgan = cgiGet( "Z76SchoolInfoTrsSolgan");
               Z77SchoolInfoTrsAddress = cgiGet( "Z77SchoolInfoTrsAddress");
               Z78SchoolInfoTrsPhone = cgiGet( "Z78SchoolInfoTrsPhone");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7SchoolInfoTrsId = (short)(context.localUtil.CToN( cgiGet( "vSCHOOLINFOTRSID"), ",", "."));
               A40000SchoolInfoTrsImagen_GXI = cgiGet( "SCHOOLINFOTRSIMAGEN_GXI");
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgSchoolInfoTrsImagen_Internalname, ref  A79SchoolInfoTrsImagen, ref  A40000SchoolInfoTrsImagen_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "SchoolInfoTrs";
               A74SchoolInfoTrsId = (short)(context.localUtil.CToN( cgiGet( edtSchoolInfoTrsId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A74SchoolInfoTrsId != Z74SchoolInfoTrsId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("schoolinfotrs:[SecurityCheckFailed value for]"+"SchoolInfoTrsId:"+context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9"));
                  GXUtil.WriteLog("schoolinfotrs:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A74SchoolInfoTrsId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
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
                     sMode17 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode17;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound17 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0D0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SCHOOLINFOTRSID");
                        AnyError = 1;
                        GX_FocusControl = edtSchoolInfoTrsId_Internalname;
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E110D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120D2 ();
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
            E120D2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0D17( ) ;
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
            DisableAttributes0D17( ) ;
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

      protected void CONFIRM_0D0( )
      {
         BeforeValidate0D17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0D17( ) ;
            }
            else
            {
               CheckExtendedTable0D17( ) ;
               CloseExtendedTableCursors0D17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0D0( )
      {
      }

      protected void E110D2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Verbo2");
      }

      protected void E120D2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwschoolinfotrs.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0D17( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z75SchoolInfoTrsNombre = T000D3_A75SchoolInfoTrsNombre[0];
               Z76SchoolInfoTrsSolgan = T000D3_A76SchoolInfoTrsSolgan[0];
               Z77SchoolInfoTrsAddress = T000D3_A77SchoolInfoTrsAddress[0];
               Z78SchoolInfoTrsPhone = T000D3_A78SchoolInfoTrsPhone[0];
            }
            else
            {
               Z75SchoolInfoTrsNombre = A75SchoolInfoTrsNombre;
               Z76SchoolInfoTrsSolgan = A76SchoolInfoTrsSolgan;
               Z77SchoolInfoTrsAddress = A77SchoolInfoTrsAddress;
               Z78SchoolInfoTrsPhone = A78SchoolInfoTrsPhone;
            }
         }
         if ( GX_JID == -3 )
         {
            Z74SchoolInfoTrsId = A74SchoolInfoTrsId;
            Z75SchoolInfoTrsNombre = A75SchoolInfoTrsNombre;
            Z76SchoolInfoTrsSolgan = A76SchoolInfoTrsSolgan;
            Z77SchoolInfoTrsAddress = A77SchoolInfoTrsAddress;
            Z78SchoolInfoTrsPhone = A78SchoolInfoTrsPhone;
            Z79SchoolInfoTrsImagen = A79SchoolInfoTrsImagen;
            Z40000SchoolInfoTrsImagen_GXI = A40000SchoolInfoTrsImagen_GXI;
         }
      }

      protected void standaloneNotModal( )
      {
         edtSchoolInfoTrsId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsId_Enabled), 5, 0)), true);
         edtSchoolInfoTrsId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsId_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7SchoolInfoTrsId) )
         {
            A74SchoolInfoTrsId = AV7SchoolInfoTrsId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
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

      protected void Load0D17( )
      {
         /* Using cursor T000D4 */
         pr_default.execute(2, new Object[] {A74SchoolInfoTrsId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound17 = 1;
            A75SchoolInfoTrsNombre = T000D4_A75SchoolInfoTrsNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75SchoolInfoTrsNombre", A75SchoolInfoTrsNombre);
            A76SchoolInfoTrsSolgan = T000D4_A76SchoolInfoTrsSolgan[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76SchoolInfoTrsSolgan", A76SchoolInfoTrsSolgan);
            A77SchoolInfoTrsAddress = T000D4_A77SchoolInfoTrsAddress[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77SchoolInfoTrsAddress", A77SchoolInfoTrsAddress);
            A78SchoolInfoTrsPhone = T000D4_A78SchoolInfoTrsPhone[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78SchoolInfoTrsPhone", A78SchoolInfoTrsPhone);
            A40000SchoolInfoTrsImagen_GXI = T000D4_A40000SchoolInfoTrsImagen_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
            A79SchoolInfoTrsImagen = T000D4_A79SchoolInfoTrsImagen[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79SchoolInfoTrsImagen", A79SchoolInfoTrsImagen);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
            ZM0D17( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0D17( ) ;
      }

      protected void OnLoadActions0D17( )
      {
         AV11Pgmname = "SchoolInfoTrs";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable0D17( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "SchoolInfoTrs";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors0D17( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0D17( )
      {
         /* Using cursor T000D5 */
         pr_default.execute(3, new Object[] {A74SchoolInfoTrsId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000D3 */
         pr_default.execute(1, new Object[] {A74SchoolInfoTrsId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0D17( 3) ;
            RcdFound17 = 1;
            A74SchoolInfoTrsId = T000D3_A74SchoolInfoTrsId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
            A75SchoolInfoTrsNombre = T000D3_A75SchoolInfoTrsNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75SchoolInfoTrsNombre", A75SchoolInfoTrsNombre);
            A76SchoolInfoTrsSolgan = T000D3_A76SchoolInfoTrsSolgan[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76SchoolInfoTrsSolgan", A76SchoolInfoTrsSolgan);
            A77SchoolInfoTrsAddress = T000D3_A77SchoolInfoTrsAddress[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77SchoolInfoTrsAddress", A77SchoolInfoTrsAddress);
            A78SchoolInfoTrsPhone = T000D3_A78SchoolInfoTrsPhone[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78SchoolInfoTrsPhone", A78SchoolInfoTrsPhone);
            A40000SchoolInfoTrsImagen_GXI = T000D3_A40000SchoolInfoTrsImagen_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
            A79SchoolInfoTrsImagen = T000D3_A79SchoolInfoTrsImagen[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79SchoolInfoTrsImagen", A79SchoolInfoTrsImagen);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
            Z74SchoolInfoTrsId = A74SchoolInfoTrsId;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0D17( ) ;
            if ( AnyError == 1 )
            {
               RcdFound17 = 0;
               InitializeNonKey0D17( ) ;
            }
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0D17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0D17( ) ;
         if ( RcdFound17 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound17 = 0;
         /* Using cursor T000D6 */
         pr_default.execute(4, new Object[] {A74SchoolInfoTrsId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A74SchoolInfoTrsId[0] < A74SchoolInfoTrsId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A74SchoolInfoTrsId[0] > A74SchoolInfoTrsId ) ) )
            {
               A74SchoolInfoTrsId = T000D6_A74SchoolInfoTrsId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound17 = 0;
         /* Using cursor T000D7 */
         pr_default.execute(5, new Object[] {A74SchoolInfoTrsId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A74SchoolInfoTrsId[0] > A74SchoolInfoTrsId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A74SchoolInfoTrsId[0] < A74SchoolInfoTrsId ) ) )
            {
               A74SchoolInfoTrsId = T000D7_A74SchoolInfoTrsId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0D17( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0D17( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound17 == 1 )
            {
               if ( A74SchoolInfoTrsId != Z74SchoolInfoTrsId )
               {
                  A74SchoolInfoTrsId = Z74SchoolInfoTrsId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SCHOOLINFOTRSID");
                  AnyError = 1;
                  GX_FocusControl = edtSchoolInfoTrsId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0D17( ) ;
                  GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A74SchoolInfoTrsId != Z74SchoolInfoTrsId )
               {
                  /* Insert record */
                  GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0D17( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SCHOOLINFOTRSID");
                     AnyError = 1;
                     GX_FocusControl = edtSchoolInfoTrsId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0D17( ) ;
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
         if ( A74SchoolInfoTrsId != Z74SchoolInfoTrsId )
         {
            A74SchoolInfoTrsId = Z74SchoolInfoTrsId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SCHOOLINFOTRSID");
            AnyError = 1;
            GX_FocusControl = edtSchoolInfoTrsId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSchoolInfoTrsNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0D17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000D2 */
            pr_default.execute(0, new Object[] {A74SchoolInfoTrsId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SchoolInfoTrs"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z75SchoolInfoTrsNombre, T000D2_A75SchoolInfoTrsNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z76SchoolInfoTrsSolgan, T000D2_A76SchoolInfoTrsSolgan[0]) != 0 ) || ( StringUtil.StrCmp(Z77SchoolInfoTrsAddress, T000D2_A77SchoolInfoTrsAddress[0]) != 0 ) || ( StringUtil.StrCmp(Z78SchoolInfoTrsPhone, T000D2_A78SchoolInfoTrsPhone[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z75SchoolInfoTrsNombre, T000D2_A75SchoolInfoTrsNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("schoolinfotrs:[seudo value changed for attri]"+"SchoolInfoTrsNombre");
                  GXUtil.WriteLogRaw("Old: ",Z75SchoolInfoTrsNombre);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A75SchoolInfoTrsNombre[0]);
               }
               if ( StringUtil.StrCmp(Z76SchoolInfoTrsSolgan, T000D2_A76SchoolInfoTrsSolgan[0]) != 0 )
               {
                  GXUtil.WriteLog("schoolinfotrs:[seudo value changed for attri]"+"SchoolInfoTrsSolgan");
                  GXUtil.WriteLogRaw("Old: ",Z76SchoolInfoTrsSolgan);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A76SchoolInfoTrsSolgan[0]);
               }
               if ( StringUtil.StrCmp(Z77SchoolInfoTrsAddress, T000D2_A77SchoolInfoTrsAddress[0]) != 0 )
               {
                  GXUtil.WriteLog("schoolinfotrs:[seudo value changed for attri]"+"SchoolInfoTrsAddress");
                  GXUtil.WriteLogRaw("Old: ",Z77SchoolInfoTrsAddress);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A77SchoolInfoTrsAddress[0]);
               }
               if ( StringUtil.StrCmp(Z78SchoolInfoTrsPhone, T000D2_A78SchoolInfoTrsPhone[0]) != 0 )
               {
                  GXUtil.WriteLog("schoolinfotrs:[seudo value changed for attri]"+"SchoolInfoTrsPhone");
                  GXUtil.WriteLogRaw("Old: ",Z78SchoolInfoTrsPhone);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A78SchoolInfoTrsPhone[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SchoolInfoTrs"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0D17( )
      {
         BeforeValidate0D17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0D17( 0) ;
            CheckOptimisticConcurrency0D17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0D17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D8 */
                     pr_default.execute(6, new Object[] {A75SchoolInfoTrsNombre, A76SchoolInfoTrsSolgan, A77SchoolInfoTrsAddress, A78SchoolInfoTrsPhone, A79SchoolInfoTrsImagen, A40000SchoolInfoTrsImagen_GXI});
                     A74SchoolInfoTrsId = T000D8_A74SchoolInfoTrsId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("SchoolInfoTrs") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0D0( ) ;
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
               Load0D17( ) ;
            }
            EndLevel0D17( ) ;
         }
         CloseExtendedTableCursors0D17( ) ;
      }

      protected void Update0D17( )
      {
         BeforeValidate0D17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0D17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D9 */
                     pr_default.execute(7, new Object[] {A75SchoolInfoTrsNombre, A76SchoolInfoTrsSolgan, A77SchoolInfoTrsAddress, A78SchoolInfoTrsPhone, A74SchoolInfoTrsId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("SchoolInfoTrs") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SchoolInfoTrs"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0D17( ) ;
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
            EndLevel0D17( ) ;
         }
         CloseExtendedTableCursors0D17( ) ;
      }

      protected void DeferredUpdate0D17( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000D10 */
            pr_default.execute(8, new Object[] {A79SchoolInfoTrsImagen, A40000SchoolInfoTrsImagen_GXI, A74SchoolInfoTrsId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("SchoolInfoTrs") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate0D17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0D17( ) ;
            AfterConfirm0D17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0D17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000D11 */
                  pr_default.execute(9, new Object[] {A74SchoolInfoTrsId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("SchoolInfoTrs") ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0D17( ) ;
         Gx_mode = sMode17;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0D17( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "SchoolInfoTrs";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void EndLevel0D17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0D17( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("schoolinfotrs",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("schoolinfotrs",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0D17( )
      {
         /* Scan By routine */
         /* Using cursor T000D12 */
         pr_default.execute(10);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound17 = 1;
            A74SchoolInfoTrsId = T000D12_A74SchoolInfoTrsId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0D17( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound17 = 1;
            A74SchoolInfoTrsId = T000D12_A74SchoolInfoTrsId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
         }
      }

      protected void ScanEnd0D17( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0D17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0D17( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0D17( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0D17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0D17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0D17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0D17( )
      {
         edtSchoolInfoTrsId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsId_Enabled), 5, 0)), true);
         edtSchoolInfoTrsNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsNombre_Enabled), 5, 0)), true);
         edtSchoolInfoTrsSolgan_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsSolgan_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsSolgan_Enabled), 5, 0)), true);
         edtSchoolInfoTrsAddress_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsAddress_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsAddress_Enabled), 5, 0)), true);
         edtSchoolInfoTrsPhone_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSchoolInfoTrsPhone_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSchoolInfoTrsPhone_Enabled), 5, 0)), true);
         imgSchoolInfoTrsImagen_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgSchoolInfoTrsImagen_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0D17( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0D0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2018101118524144", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("schoolinfotrs.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SchoolInfoTrsId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "SchoolInfoTrs";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("schoolinfotrs:[SendSecurityCheck value for]"+"SchoolInfoTrsId:"+context.localUtil.Format( (decimal)(A74SchoolInfoTrsId), "ZZZ9"));
         GXUtil.WriteLog("schoolinfotrs:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z74SchoolInfoTrsId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z75SchoolInfoTrsNombre", StringUtil.RTrim( Z75SchoolInfoTrsNombre));
         GxWebStd.gx_hidden_field( context, "Z76SchoolInfoTrsSolgan", StringUtil.RTrim( Z76SchoolInfoTrsSolgan));
         GxWebStd.gx_hidden_field( context, "Z77SchoolInfoTrsAddress", Z77SchoolInfoTrsAddress);
         GxWebStd.gx_hidden_field( context, "Z78SchoolInfoTrsPhone", StringUtil.RTrim( Z78SchoolInfoTrsPhone));
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
         GxWebStd.gx_hidden_field( context, "vSCHOOLINFOTRSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7SchoolInfoTrsId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSCHOOLINFOTRSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SchoolInfoTrsId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SCHOOLINFOTRSIMAGEN_GXI", A40000SchoolInfoTrsImagen_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "SCHOOLINFOTRSIMAGEN" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A79SchoolInfoTrsImagen);
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
         return formatLink("schoolinfotrs.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SchoolInfoTrsId) ;
      }

      public override String GetPgmname( )
      {
         return "SchoolInfoTrs" ;
      }

      public override String GetPgmdesc( )
      {
         return "School Info Trs" ;
      }

      protected void InitializeNonKey0D17( )
      {
         A75SchoolInfoTrsNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75SchoolInfoTrsNombre", A75SchoolInfoTrsNombre);
         A76SchoolInfoTrsSolgan = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76SchoolInfoTrsSolgan", A76SchoolInfoTrsSolgan);
         A77SchoolInfoTrsAddress = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77SchoolInfoTrsAddress", A77SchoolInfoTrsAddress);
         A78SchoolInfoTrsPhone = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78SchoolInfoTrsPhone", A78SchoolInfoTrsPhone);
         A79SchoolInfoTrsImagen = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79SchoolInfoTrsImagen", A79SchoolInfoTrsImagen);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
         A40000SchoolInfoTrsImagen_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A79SchoolInfoTrsImagen)) ? A40000SchoolInfoTrsImagen_GXI : context.convertURL( context.PathToRelativeUrl( A79SchoolInfoTrsImagen))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSchoolInfoTrsImagen_Internalname, "SrcSet", context.GetImageSrcSet( A79SchoolInfoTrsImagen), true);
         Z75SchoolInfoTrsNombre = "";
         Z76SchoolInfoTrsSolgan = "";
         Z77SchoolInfoTrsAddress = "";
         Z78SchoolInfoTrsPhone = "";
      }

      protected void InitAll0D17( )
      {
         A74SchoolInfoTrsId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74SchoolInfoTrsId", StringUtil.LTrim( StringUtil.Str( (decimal)(A74SchoolInfoTrsId), 4, 0)));
         InitializeNonKey0D17( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018101118524156", true);
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
         context.AddJavascriptSource("schoolinfotrs.js", "?2018101118524157", false);
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
         edtSchoolInfoTrsId_Internalname = "SCHOOLINFOTRSID";
         edtSchoolInfoTrsNombre_Internalname = "SCHOOLINFOTRSNOMBRE";
         edtSchoolInfoTrsSolgan_Internalname = "SCHOOLINFOTRSSOLGAN";
         edtSchoolInfoTrsAddress_Internalname = "SCHOOLINFOTRSADDRESS";
         edtSchoolInfoTrsPhone_Internalname = "SCHOOLINFOTRSPHONE";
         imgSchoolInfoTrsImagen_Internalname = "SCHOOLINFOTRSIMAGEN";
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
         Form.Caption = "School Info Trs";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgSchoolInfoTrsImagen_Enabled = 1;
         edtSchoolInfoTrsPhone_Jsonclick = "";
         edtSchoolInfoTrsPhone_Enabled = 1;
         edtSchoolInfoTrsAddress_Enabled = 1;
         edtSchoolInfoTrsSolgan_Enabled = 1;
         edtSchoolInfoTrsNombre_Enabled = 1;
         edtSchoolInfoTrsId_Jsonclick = "";
         edtSchoolInfoTrsId_Enabled = 0;
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SchoolInfoTrsId',fld:'vSCHOOLINFOTRSID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SchoolInfoTrsId',fld:'vSCHOOLINFOTRSID',pic:'ZZZ9',hsh:true},{av:'A74SchoolInfoTrsId',fld:'SCHOOLINFOTRSID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120D2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z75SchoolInfoTrsNombre = "";
         Z76SchoolInfoTrsSolgan = "";
         Z77SchoolInfoTrsAddress = "";
         Z78SchoolInfoTrsPhone = "";
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
         A75SchoolInfoTrsNombre = "";
         A76SchoolInfoTrsSolgan = "";
         A77SchoolInfoTrsAddress = "";
         gxphoneLink = "";
         A78SchoolInfoTrsPhone = "";
         A79SchoolInfoTrsImagen = "";
         A40000SchoolInfoTrsImagen_GXI = "";
         sImgUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode17 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         Z79SchoolInfoTrsImagen = "";
         Z40000SchoolInfoTrsImagen_GXI = "";
         T000D4_A74SchoolInfoTrsId = new short[1] ;
         T000D4_A75SchoolInfoTrsNombre = new String[] {""} ;
         T000D4_A76SchoolInfoTrsSolgan = new String[] {""} ;
         T000D4_A77SchoolInfoTrsAddress = new String[] {""} ;
         T000D4_A78SchoolInfoTrsPhone = new String[] {""} ;
         T000D4_A40000SchoolInfoTrsImagen_GXI = new String[] {""} ;
         T000D4_A79SchoolInfoTrsImagen = new String[] {""} ;
         T000D5_A74SchoolInfoTrsId = new short[1] ;
         T000D3_A74SchoolInfoTrsId = new short[1] ;
         T000D3_A75SchoolInfoTrsNombre = new String[] {""} ;
         T000D3_A76SchoolInfoTrsSolgan = new String[] {""} ;
         T000D3_A77SchoolInfoTrsAddress = new String[] {""} ;
         T000D3_A78SchoolInfoTrsPhone = new String[] {""} ;
         T000D3_A40000SchoolInfoTrsImagen_GXI = new String[] {""} ;
         T000D3_A79SchoolInfoTrsImagen = new String[] {""} ;
         T000D6_A74SchoolInfoTrsId = new short[1] ;
         T000D7_A74SchoolInfoTrsId = new short[1] ;
         T000D2_A74SchoolInfoTrsId = new short[1] ;
         T000D2_A75SchoolInfoTrsNombre = new String[] {""} ;
         T000D2_A76SchoolInfoTrsSolgan = new String[] {""} ;
         T000D2_A77SchoolInfoTrsAddress = new String[] {""} ;
         T000D2_A78SchoolInfoTrsPhone = new String[] {""} ;
         T000D2_A40000SchoolInfoTrsImagen_GXI = new String[] {""} ;
         T000D2_A79SchoolInfoTrsImagen = new String[] {""} ;
         T000D8_A74SchoolInfoTrsId = new short[1] ;
         T000D12_A74SchoolInfoTrsId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.schoolinfotrs__default(),
            new Object[][] {
                new Object[] {
               T000D2_A74SchoolInfoTrsId, T000D2_A75SchoolInfoTrsNombre, T000D2_A76SchoolInfoTrsSolgan, T000D2_A77SchoolInfoTrsAddress, T000D2_A78SchoolInfoTrsPhone, T000D2_A40000SchoolInfoTrsImagen_GXI, T000D2_A79SchoolInfoTrsImagen
               }
               , new Object[] {
               T000D3_A74SchoolInfoTrsId, T000D3_A75SchoolInfoTrsNombre, T000D3_A76SchoolInfoTrsSolgan, T000D3_A77SchoolInfoTrsAddress, T000D3_A78SchoolInfoTrsPhone, T000D3_A40000SchoolInfoTrsImagen_GXI, T000D3_A79SchoolInfoTrsImagen
               }
               , new Object[] {
               T000D4_A74SchoolInfoTrsId, T000D4_A75SchoolInfoTrsNombre, T000D4_A76SchoolInfoTrsSolgan, T000D4_A77SchoolInfoTrsAddress, T000D4_A78SchoolInfoTrsPhone, T000D4_A40000SchoolInfoTrsImagen_GXI, T000D4_A79SchoolInfoTrsImagen
               }
               , new Object[] {
               T000D5_A74SchoolInfoTrsId
               }
               , new Object[] {
               T000D6_A74SchoolInfoTrsId
               }
               , new Object[] {
               T000D7_A74SchoolInfoTrsId
               }
               , new Object[] {
               T000D8_A74SchoolInfoTrsId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000D12_A74SchoolInfoTrsId
               }
            }
         );
         AV11Pgmname = "SchoolInfoTrs";
      }

      private short wcpOAV7SchoolInfoTrsId ;
      private short Z74SchoolInfoTrsId ;
      private short GxWebError ;
      private short AV7SchoolInfoTrsId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A74SchoolInfoTrsId ;
      private short RcdFound17 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSchoolInfoTrsId_Enabled ;
      private int edtSchoolInfoTrsNombre_Enabled ;
      private int edtSchoolInfoTrsSolgan_Enabled ;
      private int edtSchoolInfoTrsAddress_Enabled ;
      private int edtSchoolInfoTrsPhone_Enabled ;
      private int imgSchoolInfoTrsImagen_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z75SchoolInfoTrsNombre ;
      private String Z76SchoolInfoTrsSolgan ;
      private String Z78SchoolInfoTrsPhone ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSchoolInfoTrsNombre_Internalname ;
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
      private String edtSchoolInfoTrsId_Internalname ;
      private String edtSchoolInfoTrsId_Jsonclick ;
      private String A75SchoolInfoTrsNombre ;
      private String edtSchoolInfoTrsSolgan_Internalname ;
      private String A76SchoolInfoTrsSolgan ;
      private String edtSchoolInfoTrsAddress_Internalname ;
      private String edtSchoolInfoTrsPhone_Internalname ;
      private String gxphoneLink ;
      private String A78SchoolInfoTrsPhone ;
      private String edtSchoolInfoTrsPhone_Jsonclick ;
      private String imgSchoolInfoTrsImagen_Internalname ;
      private String sImgUrl ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode17 ;
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
      private bool A79SchoolInfoTrsImagen_IsBlob ;
      private bool returnInSub ;
      private String Z77SchoolInfoTrsAddress ;
      private String A77SchoolInfoTrsAddress ;
      private String A40000SchoolInfoTrsImagen_GXI ;
      private String Z40000SchoolInfoTrsImagen_GXI ;
      private String A79SchoolInfoTrsImagen ;
      private String Z79SchoolInfoTrsImagen ;
      private IGxSession AV10WebSession ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T000D4_A74SchoolInfoTrsId ;
      private String[] T000D4_A75SchoolInfoTrsNombre ;
      private String[] T000D4_A76SchoolInfoTrsSolgan ;
      private String[] T000D4_A77SchoolInfoTrsAddress ;
      private String[] T000D4_A78SchoolInfoTrsPhone ;
      private String[] T000D4_A40000SchoolInfoTrsImagen_GXI ;
      private String[] T000D4_A79SchoolInfoTrsImagen ;
      private short[] T000D5_A74SchoolInfoTrsId ;
      private short[] T000D3_A74SchoolInfoTrsId ;
      private String[] T000D3_A75SchoolInfoTrsNombre ;
      private String[] T000D3_A76SchoolInfoTrsSolgan ;
      private String[] T000D3_A77SchoolInfoTrsAddress ;
      private String[] T000D3_A78SchoolInfoTrsPhone ;
      private String[] T000D3_A40000SchoolInfoTrsImagen_GXI ;
      private String[] T000D3_A79SchoolInfoTrsImagen ;
      private short[] T000D6_A74SchoolInfoTrsId ;
      private short[] T000D7_A74SchoolInfoTrsId ;
      private short[] T000D2_A74SchoolInfoTrsId ;
      private String[] T000D2_A75SchoolInfoTrsNombre ;
      private String[] T000D2_A76SchoolInfoTrsSolgan ;
      private String[] T000D2_A77SchoolInfoTrsAddress ;
      private String[] T000D2_A78SchoolInfoTrsPhone ;
      private String[] T000D2_A40000SchoolInfoTrsImagen_GXI ;
      private String[] T000D2_A79SchoolInfoTrsImagen ;
      private short[] T000D8_A74SchoolInfoTrsId ;
      private short[] T000D12_A74SchoolInfoTrsId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class schoolinfotrs__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000D4 ;
          prmT000D4 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D5 ;
          prmT000D5 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D3 ;
          prmT000D3 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D6 ;
          prmT000D6 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D7 ;
          prmT000D7 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D2 ;
          prmT000D2 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D8 ;
          prmT000D8 = new Object[] {
          new Object[] {"@SchoolInfoTrsNombre",SqlDbType.Char,200,0} ,
          new Object[] {"@SchoolInfoTrsSolgan",SqlDbType.Char,200,0} ,
          new Object[] {"@SchoolInfoTrsAddress",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SchoolInfoTrsPhone",SqlDbType.Char,20,0} ,
          new Object[] {"@SchoolInfoTrsImagen",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SchoolInfoTrsImagen_GXI",SqlDbType.VarChar,2048,0}
          } ;
          Object[] prmT000D9 ;
          prmT000D9 = new Object[] {
          new Object[] {"@SchoolInfoTrsNombre",SqlDbType.Char,200,0} ,
          new Object[] {"@SchoolInfoTrsSolgan",SqlDbType.Char,200,0} ,
          new Object[] {"@SchoolInfoTrsAddress",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SchoolInfoTrsPhone",SqlDbType.Char,20,0} ,
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D10 ;
          prmT000D10 = new Object[] {
          new Object[] {"@SchoolInfoTrsImagen",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SchoolInfoTrsImagen_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D11 ;
          prmT000D11 = new Object[] {
          new Object[] {"@SchoolInfoTrsId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D12 ;
          prmT000D12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000D2", "SELECT [SchoolInfoTrsId], [SchoolInfoTrsNombre], [SchoolInfoTrsSolgan], [SchoolInfoTrsAddress], [SchoolInfoTrsPhone], [SchoolInfoTrsImagen_GXI], [SchoolInfoTrsImagen] FROM [SchoolInfoTrs] WITH (UPDLOCK) WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D2,1,0,true,false )
             ,new CursorDef("T000D3", "SELECT [SchoolInfoTrsId], [SchoolInfoTrsNombre], [SchoolInfoTrsSolgan], [SchoolInfoTrsAddress], [SchoolInfoTrsPhone], [SchoolInfoTrsImagen_GXI], [SchoolInfoTrsImagen] FROM [SchoolInfoTrs] WITH (NOLOCK) WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D3,1,0,true,false )
             ,new CursorDef("T000D4", "SELECT TM1.[SchoolInfoTrsId], TM1.[SchoolInfoTrsNombre], TM1.[SchoolInfoTrsSolgan], TM1.[SchoolInfoTrsAddress], TM1.[SchoolInfoTrsPhone], TM1.[SchoolInfoTrsImagen_GXI], TM1.[SchoolInfoTrsImagen] FROM [SchoolInfoTrs] TM1 WITH (NOLOCK) WHERE TM1.[SchoolInfoTrsId] = @SchoolInfoTrsId ORDER BY TM1.[SchoolInfoTrsId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D4,100,0,true,false )
             ,new CursorDef("T000D5", "SELECT [SchoolInfoTrsId] FROM [SchoolInfoTrs] WITH (NOLOCK) WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D5,1,0,true,false )
             ,new CursorDef("T000D6", "SELECT TOP 1 [SchoolInfoTrsId] FROM [SchoolInfoTrs] WITH (NOLOCK) WHERE ( [SchoolInfoTrsId] > @SchoolInfoTrsId) ORDER BY [SchoolInfoTrsId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D6,1,0,true,true )
             ,new CursorDef("T000D7", "SELECT TOP 1 [SchoolInfoTrsId] FROM [SchoolInfoTrs] WITH (NOLOCK) WHERE ( [SchoolInfoTrsId] < @SchoolInfoTrsId) ORDER BY [SchoolInfoTrsId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D7,1,0,true,true )
             ,new CursorDef("T000D8", "INSERT INTO [SchoolInfoTrs]([SchoolInfoTrsNombre], [SchoolInfoTrsSolgan], [SchoolInfoTrsAddress], [SchoolInfoTrsPhone], [SchoolInfoTrsImagen], [SchoolInfoTrsImagen_GXI]) VALUES(@SchoolInfoTrsNombre, @SchoolInfoTrsSolgan, @SchoolInfoTrsAddress, @SchoolInfoTrsPhone, @SchoolInfoTrsImagen, @SchoolInfoTrsImagen_GXI); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000D8)
             ,new CursorDef("T000D9", "UPDATE [SchoolInfoTrs] SET [SchoolInfoTrsNombre]=@SchoolInfoTrsNombre, [SchoolInfoTrsSolgan]=@SchoolInfoTrsSolgan, [SchoolInfoTrsAddress]=@SchoolInfoTrsAddress, [SchoolInfoTrsPhone]=@SchoolInfoTrsPhone  WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId", GxErrorMask.GX_NOMASK,prmT000D9)
             ,new CursorDef("T000D10", "UPDATE [SchoolInfoTrs] SET [SchoolInfoTrsImagen]=@SchoolInfoTrsImagen, [SchoolInfoTrsImagen_GXI]=@SchoolInfoTrsImagen_GXI  WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId", GxErrorMask.GX_NOMASK,prmT000D10)
             ,new CursorDef("T000D11", "DELETE FROM [SchoolInfoTrs]  WHERE [SchoolInfoTrsId] = @SchoolInfoTrsId", GxErrorMask.GX_NOMASK,prmT000D11)
             ,new CursorDef("T000D12", "SELECT [SchoolInfoTrsId] FROM [SchoolInfoTrs] WITH (NOLOCK) ORDER BY [SchoolInfoTrsId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D12,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 200) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(6)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 200) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(6)) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 200) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 200) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(6)) ;
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
                stmt.SetParameterBlob(5, (String)parms[4], false);
                stmt.SetParameterMultimedia(6, (String)parms[5], (String)parms[4], "SchoolInfoTrs", "SchoolInfoTrsImagen");
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 8 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "SchoolInfoTrs", "SchoolInfoTrsImagen");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
