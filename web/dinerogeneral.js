/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:31.29
*/
gx.evt.autoSkip=!1;gx.define("dinerogeneral",!0,function(n){this.ServerClass="dinerogeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Dinerototal=function(){try{var n=gx.util.balloon.getNew("DINEROTOTAL");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dineropago=function(){try{var n=gx.util.balloon.getNew("DINEROPAGO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dineroabono=function(){try{var n=gx.util.balloon.getNew("DINEROABONO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dinerobalance=function(){try{var n=gx.util.balloon.getNew("DINEROBALANCE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Dineroid=function(){try{var n=gx.util.balloon.getNew("DINEROID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e11121_client=function(){return this.clearMessages(),this.call("dinero.aspx",["UPD",this.A14DineroId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e12121_client=function(){return this.clearMessages(),this.call("dinero.aspx",["DLT",this.A14DineroId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e15122_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16122_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47];this.GXLastCtrlId=47;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSID",gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSID",".")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dinerototal,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROTOTAL",gxz:"Z64DineroTotal",gxold:"O64DineroTotal",gxvar:"A64DineroTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A64DineroTotal=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z64DineroTotal=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROTOTAL",gx.O.A64DineroTotal,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A64DineroTotal=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROTOTAL",".",",")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dineropago,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROPAGO",gxz:"Z62DineroPago",gxold:"O62DineroPago",gxvar:"A62DineroPago",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A62DineroPago=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z62DineroPago=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROPAGO",gx.O.A62DineroPago,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A62DineroPago=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROPAGO",".",",")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"+ ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dineroabono,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROABONO",gxz:"Z63DineroAbono",gxold:"O63DineroAbono",gxvar:"A63DineroAbono",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A63DineroAbono=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z63DineroAbono=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROABONO",gx.O.A63DineroAbono,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A63DineroAbono=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROABONO",".",",")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dinerobalance,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROBALANCE",gxz:"Z61DineroBalance",gxold:"O61DineroBalance",gxvar:"A61DineroBalance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A61DineroBalance=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z61DineroBalance=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINEROBALANCE",gx.O.A61DineroBalance,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A61DineroBalance=this.val())},val:function(){return gx.fn.getDecimalValue("DINEROBALANCE",".",",")},nac:gx.falseFn};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZ,ZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINERONUEVO",gxz:"Z65DineroNuevo",gxold:"O65DineroNuevo",gxvar:"A65DineroNuevo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A65DineroNuevo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z65DineroNuevo=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("DINERONUEVO",gx.O.A65DineroNuevo,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A65DineroNuevo=this.val())},val:function(){return gx.fn.getDecimalValue("DINERONUEVO",".",",")},nac:gx.falseFn};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Dineroid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DINEROID",gxz:"Z14DineroId",gxold:"O14DineroId",gxvar:"A14DineroId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14DineroId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14DineroId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("DINEROID",gx.O.A14DineroId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A14DineroId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("DINEROID",".")},nac:gx.falseFn};this.declareDomainHdlr(47,function(){});this.A3UsersId=0;this.Z3UsersId=0;this.O3UsersId=0;this.A64DineroTotal=0;this.Z64DineroTotal=0;this.O64DineroTotal=0;this.A62DineroPago=0;this.Z62DineroPago=0;this.O62DineroPago=0;this.A63DineroAbono=0;this.Z63DineroAbono=0;this.O63DineroAbono=0;this.A61DineroBalance=0;this.Z61DineroBalance=0;this.O61DineroBalance=0;this.A65DineroNuevo=0;this.Z65DineroNuevo=0;this.O65DineroNuevo=0;this.A14DineroId=0;this.Z14DineroId=0;this.O14DineroId=0;this.A3UsersId=0;this.A64DineroTotal=0;this.A62DineroPago=0;this.A63DineroAbono=0;this.A61DineroBalance=0;this.A65DineroNuevo=0;this.A14DineroId=0;this.Events={e15122_client:["ENTER",!0],e16122_client:["CANCEL",!0],e11121_client:["'DOUPDATE'",!1],e12121_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6DineroId",fld:"vDINEROID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("DINEROID","Visible")',ctrl:"DINEROID",prop:"Visible"}]];this.EvtParms["'DOUPDATE'"]=[[{av:"A14DineroId",fld:"DINEROID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A14DineroId",fld:"DINEROID",pic:"ZZZ9"}],[]];this.Initialize()})