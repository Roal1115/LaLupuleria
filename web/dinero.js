/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:29.92
*/
gx.evt.autoSkip=!1;gx.define("dinero",!1,function(){this.ServerClass="dinero";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7DineroId=gx.fn.getIntegerValue("vDINEROID",".");this.A14DineroId=gx.fn.getIntegerValue("DINEROID",".");this.AV11Insert_UsersId=gx.fn.getIntegerValue("vINSERT_USERSID",".");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Usersid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Usersid",["gx.O.A3UsersId"],[]),!0};this.Valid_Dinerototal=function(){try{var n=gx.util.balloon.getNew("DINEROTOTAL");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dineropago=function(){try{var n=gx.util.balloon.getNew("DINEROPAGO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dineroabono=function(){try{var n=gx.util.balloon.getNew("DINEROABONO");this.AnyError=0;try{this.A61DineroBalance=this.A62DineroPago+this.A63DineroAbono}catch(t){}try{this.A65DineroNuevo=this.A64DineroTotal-this.A61DineroBalance}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dinerobalance=function(){try{var n=gx.util.balloon.getNew("DINEROBALANCE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e12062_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130612_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140612_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69];this.GXLastCtrlId=69;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usersid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSID",gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSID",".")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_UsersId)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Dinerototal,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROTOTAL",gxz:"Z64DineroTotal",gxold:"O64DineroTotal",gxvar:"A64DineroTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A64DineroTotal=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z64DineroTotal=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROTOTAL",gx.O.A64DineroTotal,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A64DineroTotal=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROTOTAL",".",",")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Dineropago,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROPAGO",gxz:"Z62DineroPago",gxold:"O62DineroPago",gxvar:"A62DineroPago",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A62DineroPago=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z62DineroPago=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROPAGO",gx.O.A62DineroPago,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A62DineroPago=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROPAGO",".",",")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"+ ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Dineroabono,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROABONO",gxz:"Z63DineroAbono",gxold:"O63DineroAbono",gxvar:"A63DineroAbono",ucs:[],op:[59,54],ip:[59,54,39,49,44],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A63DineroAbono=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z63DineroAbono=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROABONO",gx.O.A63DineroAbono,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A63DineroAbono=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROABONO",".",",")},nac:gx.falseFn};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dinerobalance,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROBALANCE",gxz:"Z61DineroBalance",gxold:"O61DineroBalance",gxvar:"A61DineroBalance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A61DineroBalance=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z61DineroBalance=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROBALANCE",gx.O.A61DineroBalance,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A61DineroBalance=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROBALANCE",".",",")},nac:gx.falseFn};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINERONUEVO",gxz:"Z65DineroNuevo",gxold:"O65DineroNuevo",gxvar:"A65DineroNuevo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A65DineroNuevo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z65DineroNuevo=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINERONUEVO",gx.O.A65DineroNuevo,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A65DineroNuevo=this.val())},val:function(){return gx.fn.getDecimalValue("DINERONUEVO",".",",")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"BTN_ENTER",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"BTN_CANCEL",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"BTN_DELETE",grid:0};n[69]={id:69,fld:"PROMPT_3",grid:12};this.A3UsersId=0;this.Z3UsersId=0;this.O3UsersId=0;this.A64DineroTotal=0;this.Z64DineroTotal=0;this.O64DineroTotal=0;this.A62DineroPago=0;this.Z62DineroPago=0;this.O62DineroPago=0;this.A63DineroAbono=0;this.Z63DineroAbono=0;this.O63DineroAbono=0;this.A61DineroBalance=0;this.Z61DineroBalance=0;this.O61DineroBalance=0;this.A65DineroNuevo=0;this.Z65DineroNuevo=0;this.O65DineroNuevo=0;this.AV13Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_UsersId=0;this.AV14GXV1=0;this.AV12TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7DineroId=0;this.AV10WebSession={};this.A14DineroId=0;this.A3UsersId=0;this.A61DineroBalance=0;this.A65DineroNuevo=0;this.A64DineroTotal=0;this.A62DineroPago=0;this.A63DineroAbono=0;this.Gx_mode="";this.Events={e12062_client:["AFTER TRN",!0],e130612_client:["ENTER",!0],e140612_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7DineroId",fld:"vDINEROID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7DineroId",fld:"vDINEROID",pic:"ZZZ9",hsh:!0},{av:"AV11Insert_UsersId",fld:"vINSERT_USERSID",pic:"ZZZ9"},{av:"A14DineroId",fld:"DINEROID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV11Insert_UsersId",fld:"vINSERT_USERSID",pic:"ZZZ9"},{av:"AV14GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV12TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_3",[34]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7DineroId","vDINEROID",0,"int",4,0);this.setVCMap("A14DineroId","DINEROID",0,"int",4,0);this.setVCMap("AV11Insert_UsersId","vINSERT_USERSID",0,"int",4,0);this.setVCMap("AV13Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.createParentObj(dinero)