/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:17.17
*/
gx.evt.autoSkip=!1;gx.define("balancegeneral",!0,function(n){this.ServerClass="balancegeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Balancecredit=function(){try{var n=gx.util.balloon.getNew("BALANCECREDIT");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Usersid=function(){try{var n=gx.util.balloon.getNew("USERSID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Balancetotalabono=function(){try{var n=gx.util.balloon.getNew("BALANCETOTALABONO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Balanceid=function(){try{var n=gx.util.balloon.getNew("BALANCEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110n1_client=function(){return this.clearMessages(),this.call("balance.aspx",["UPD",this.A7BalanceId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120n1_client=function(){return this.clearMessages(),this.call("balance.aspx",["DLT",this.A7BalanceId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150n2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160n2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60];this.GXLastCtrlId=60;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"decimal",len:10,dec:2,sign:!1,pic:"$ Z,ZZZ,ZZZ.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Balancecredit,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCECREDIT",gxz:"Z24BalanceCredit",gxold:"O24BalanceCredit",gxvar:"A24BalanceCredit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A24BalanceCredit=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z24BalanceCredit=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("BALANCECREDIT",gx.O.A24BalanceCredit,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A24BalanceCredit=this.val())},val:function(){return gx.fn.getDecimalValue("BALANCECREDIT",".",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCEDATEMADE",gxz:"Z27BalanceDateMade",gxold:"O27BalanceDateMade",gxvar:"A27BalanceDateMade",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27BalanceDateMade=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z27BalanceDateMade=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BALANCEDATEMADE",gx.O.A27BalanceDateMade,0)},c2v:function(){this.val()!==undefined&&(gx.O.A27BalanceDateMade=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BALANCEDATEMADE")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCEMONTHS",gxz:"Z28BalanceMonths",gxold:"O28BalanceMonths",gxvar:"A28BalanceMonths",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28BalanceMonths=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z28BalanceMonths=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BALANCEMONTHS",gx.O.A28BalanceMonths,0)},c2v:function(){this.val()!==undefined&&(gx.O.A28BalanceMonths=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BALANCEMONTHS",".")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCENAME",gxz:"Z29BalanceName",gxold:"O29BalanceName",gxvar:"A29BalanceName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A29BalanceName=n)},v2z:function(n){n!==undefined&&(gx.O.Z29BalanceName=n)},v2c:function(){gx.fn.setComboBoxValue("BALANCENAME",gx.O.A29BalanceName)},c2v:function(){this.val()!==undefined&&(gx.O.A29BalanceName=this.val())},val:function(){return gx.fn.getControlValue("BALANCENAME")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Usersid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSID",gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSID",".")},nac:gx.falseFn};this.declareDomainHdlr(38,function(){});t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"decimal",len:10,dec:2,sign:!1,pic:"$ Z,ZZZ,ZZZ.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Balancetotalabono,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCETOTALABONO",gxz:"Z32BalanceTotalAbono",gxold:"O32BalanceTotalAbono",gxvar:"A32BalanceTotalAbono",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32BalanceTotalAbono=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z32BalanceTotalAbono=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("BALANCETOTALABONO",gx.O.A32BalanceTotalAbono,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A32BalanceTotalAbono=this.val())},val:function(){return gx.fn.getDecimalValue("BALANCETOTALABONO",".",",")},nac:gx.falseFn};this.declareDomainHdlr(43,function(){});t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"decimal",len:10,dec:2,sign:!1,pic:"$ Z,ZZZ,ZZZ.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCESALDO",gxz:"Z34BalanceSaldo",gxold:"O34BalanceSaldo",gxvar:"A34BalanceSaldo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34BalanceSaldo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z34BalanceSaldo=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("BALANCESALDO",gx.O.A34BalanceSaldo,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A34BalanceSaldo=this.val())},val:function(){return gx.fn.getDecimalValue("BALANCESALDO",".",",")},nac:gx.falseFn};this.declareDomainHdlr(48,function(){});t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Balanceid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCEID",gxz:"Z7BalanceId",gxold:"O7BalanceId",gxvar:"A7BalanceId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A7BalanceId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7BalanceId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BALANCEID",gx.O.A7BalanceId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A7BalanceId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BALANCEID",".")},nac:gx.falseFn};this.declareDomainHdlr(52,function(){});t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSNAME",gxz:"Z4UsersName",gxold:"O4UsersName",gxvar:"A4UsersName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4UsersName=n)},v2z:function(n){n!==undefined&&(gx.O.Z4UsersName=n)},v2c:function(){gx.fn.setControlValue("USERSNAME",gx.O.A4UsersName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4UsersName=this.val())},val:function(){return gx.fn.getControlValue("USERSNAME")},nac:gx.falseFn};t[57]={id:57,fld:"",grid:0};t[58]={id:58,fld:"",grid:0};t[59]={id:59,fld:"",grid:0};t[60]={id:60,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BALANCELASTLINE",gxz:"Z30BalanceLastLine",gxold:"O30BalanceLastLine",gxvar:"A30BalanceLastLine",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A30BalanceLastLine=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z30BalanceLastLine=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BALANCELASTLINE",gx.O.A30BalanceLastLine,0)},c2v:function(){this.val()!==undefined&&(gx.O.A30BalanceLastLine=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BALANCELASTLINE",".")},nac:gx.falseFn};this.A24BalanceCredit=0;this.Z24BalanceCredit=0;this.O24BalanceCredit=0;this.A27BalanceDateMade=gx.date.nullDate();this.Z27BalanceDateMade=gx.date.nullDate();this.O27BalanceDateMade=gx.date.nullDate();this.A28BalanceMonths=0;this.Z28BalanceMonths=0;this.O28BalanceMonths=0;this.A29BalanceName="";this.Z29BalanceName="";this.O29BalanceName="";this.A3UsersId=0;this.Z3UsersId=0;this.O3UsersId=0;this.A32BalanceTotalAbono=0;this.Z32BalanceTotalAbono=0;this.O32BalanceTotalAbono=0;this.A34BalanceSaldo=0;this.Z34BalanceSaldo=0;this.O34BalanceSaldo=0;this.A7BalanceId=0;this.Z7BalanceId=0;this.O7BalanceId=0;this.A4UsersName="";this.Z4UsersName="";this.O4UsersName="";this.A30BalanceLastLine=0;this.Z30BalanceLastLine=0;this.O30BalanceLastLine=0;this.A24BalanceCredit=0;this.A27BalanceDateMade=gx.date.nullDate();this.A28BalanceMonths=0;this.A29BalanceName="";this.A3UsersId=0;this.A32BalanceTotalAbono=0;this.A34BalanceSaldo=0;this.A7BalanceId=0;this.A4UsersName="";this.A30BalanceLastLine=0;this.Events={e150n2_client:["ENTER",!0],e160n2_client:["CANCEL",!0],e110n1_client:["'DOUPDATE'",!1],e120n1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6BalanceId",fld:"vBALANCEID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BALANCEID","Visible")',ctrl:"BALANCEID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("USERSNAME","Visible")',ctrl:"USERSNAME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BALANCELASTLINE","Visible")',ctrl:"BALANCELASTLINE",prop:"Visible"}]];this.EvtParms["'DOUPDATE'"]=[[{av:"A7BalanceId",fld:"BALANCEID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A7BalanceId",fld:"BALANCEID",pic:"ZZZ9"}],[]];this.Initialize()})