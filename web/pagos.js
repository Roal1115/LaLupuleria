/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:47.82
*/
gx.evt.autoSkip=!1;gx.define("pagos",!1,function(){this.ServerClass="pagos";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Pagosid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Pagosid",["gx.O.A12PagosId"],["Gx_mode","Z12PagosId",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110c10_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120c10_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Pagosid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAGOSID",gxz:"Z12PagosId",gxold:"O12PagosId",gxvar:"A12PagosId",ucs:[],op:[],ip:[34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12PagosId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12PagosId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PAGOSID",gx.O.A12PagosId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12PagosId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PAGOSID",".")},nac:gx.falseFn};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"BTN_ENTER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTN_CANCEL",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"BTN_DELETE",grid:0};this.A12PagosId=0;this.Z12PagosId=0;this.O12PagosId=0;this.A12PagosId=0;this.Events={e110c10_client:["ENTER",!0],e120c10_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(pagos)