/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:2.20
*/
gx.evt.autoSkip=!1;gx.define("usersgeneral",!0,function(n){this.ServerClass="usersgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Usersid=function(){try{var n=gx.util.balloon.getNew("USERSID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110f1_client=function(){return this.clearMessages(),this.call("users.aspx",["UPD",this.A3UsersId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120f1_client=function(){return this.clearMessages(),this.call("users.aspx",["DLT",this.A3UsersId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150f2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160f2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58];this.GXLastCtrlId=58;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSNAME",gxz:"Z4UsersName",gxold:"O4UsersName",gxvar:"A4UsersName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4UsersName=n)},v2z:function(n){n!==undefined&&(gx.O.Z4UsersName=n)},v2c:function(){gx.fn.setControlValue("USERSNAME",gx.O.A4UsersName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4UsersName=this.val())},val:function(){return gx.fn.getControlValue("USERSNAME")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSPASSWORD",gxz:"Z5UsersPassword",gxold:"O5UsersPassword",gxvar:"A5UsersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5UsersPassword=n)},v2z:function(n){n!==undefined&&(gx.O.Z5UsersPassword=n)},v2c:function(){gx.fn.setControlValue("USERSPASSWORD",gx.O.A5UsersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5UsersPassword=this.val())},val:function(){return gx.fn.getControlValue("USERSPASSWORD")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSBUSINESS",gxz:"Z2UsersBusiness",gxold:"O2UsersBusiness",gxvar:"A2UsersBusiness",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A2UsersBusiness=n)},v2z:function(n){n!==undefined&&(gx.O.Z2UsersBusiness=n)},v2c:function(){gx.fn.setComboBoxValue("USERSBUSINESS",gx.O.A2UsersBusiness)},c2v:function(){this.val()!==undefined&&(gx.O.A2UsersBusiness=this.val())},val:function(){return gx.fn.getControlValue("USERSBUSINESS")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:200,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSNOMBRE",gxz:"Z43UsersNombre",gxold:"O43UsersNombre",gxvar:"A43UsersNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A43UsersNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z43UsersNombre=n)},v2c:function(){gx.fn.setControlValue("USERSNOMBRE",gx.O.A43UsersNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43UsersNombre=this.val())},val:function(){return gx.fn.getControlValue("USERSNOMBRE")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSDIRECCION",gxz:"Z44UsersDireccion",gxold:"O44UsersDireccion",gxvar:"A44UsersDireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A44UsersDireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z44UsersDireccion=n)},v2c:function(){gx.fn.setControlValue("USERSDIRECCION",gx.O.A44UsersDireccion,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A44UsersDireccion=this.val())},val:function(){return gx.fn.getControlValue("USERSDIRECCION")},nac:gx.falseFn};this.declareDomainHdlr(38,function(){gx.fn.setCtrlProperty("USERSDIRECCION","Link",gx.fn.getCtrlProperty("USERSDIRECCION","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A44UsersDireccion))});t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"char",len:18,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSCURP",gxz:"Z45UsersCURP",gxold:"O45UsersCURP",gxvar:"A45UsersCURP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A45UsersCURP=n)},v2z:function(n){n!==undefined&&(gx.O.Z45UsersCURP=n)},v2c:function(){gx.fn.setControlValue("USERSCURP",gx.O.A45UsersCURP,0)},c2v:function(){this.val()!==undefined&&(gx.O.A45UsersCURP=this.val())},val:function(){return gx.fn.getControlValue("USERSCURP")},nac:gx.falseFn};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSMATRICULA",gxz:"Z47UsersMatricula",gxold:"O47UsersMatricula",gxvar:"A47UsersMatricula",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A47UsersMatricula=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z47UsersMatricula=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSMATRICULA",gx.O.A47UsersMatricula,0)},c2v:function(){this.val()!==undefined&&(gx.O.A47UsersMatricula=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSMATRICULA",".")},nac:gx.falseFn};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"IMAGESTABLE",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSFOTOGRAFIA",gxz:"Z46UsersFotografia",gxold:"O46UsersFotografia",gxvar:"A46UsersFotografia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A46UsersFotografia=n)},v2z:function(n){n!==undefined&&(gx.O.Z46UsersFotografia=n)},v2c:function(){gx.fn.setMultimediaValue("USERSFOTOGRAFIA",gx.O.A46UsersFotografia,gx.O.A40000UsersFotografia_GXI)},c2v:function(){gx.O.A40000UsersFotografia_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A46UsersFotografia=this.val())},val:function(){return gx.fn.getBlobValue("USERSFOTOGRAFIA")},val_GXI:function(){return gx.fn.getControlValue("USERSFOTOGRAFIA_GXI")},gxvar_GXI:"A40000UsersFotografia_GXI",nac:gx.falseFn};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"",grid:0};t[58]={id:58,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Usersid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSID",gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSID",".")},nac:gx.falseFn};this.declareDomainHdlr(58,function(){});this.A4UsersName="";this.Z4UsersName="";this.O4UsersName="";this.A5UsersPassword="";this.Z5UsersPassword="";this.O5UsersPassword="";this.A2UsersBusiness="";this.Z2UsersBusiness="";this.O2UsersBusiness="";this.A43UsersNombre="";this.Z43UsersNombre="";this.O43UsersNombre="";this.A44UsersDireccion="";this.Z44UsersDireccion="";this.O44UsersDireccion="";this.A45UsersCURP="";this.Z45UsersCURP="";this.O45UsersCURP="";this.A47UsersMatricula=0;this.Z47UsersMatricula=0;this.O47UsersMatricula=0;this.A40000UsersFotografia_GXI="";this.A46UsersFotografia="";this.Z46UsersFotografia="";this.O46UsersFotografia="";this.A3UsersId=0;this.Z3UsersId=0;this.O3UsersId=0;this.A4UsersName="";this.A5UsersPassword="";this.A2UsersBusiness="";this.A43UsersNombre="";this.A44UsersDireccion="";this.A45UsersCURP="";this.A47UsersMatricula=0;this.A46UsersFotografia="";this.A3UsersId=0;this.A40000UsersFotografia_GXI="";this.Events={e150f2_client:["ENTER",!0],e160f2_client:["CANCEL",!0],e110f1_client:["'DOUPDATE'",!1],e120f1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6UsersId",fld:"vUSERSID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("USERSID","Visible")',ctrl:"USERSID",prop:"Visible"}]];this.EvtParms["'DOUPDATE'"]=[[{av:"A3UsersId",fld:"USERSID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A3UsersId",fld:"USERSID",pic:"ZZZ9"}],[]];this.Initialize()})