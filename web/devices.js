/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:51:56.83
*/
gx.evt.autoSkip=!1;gx.define("devices",!1,function(){var n,t;this.ServerClass="devices";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7DeviceId=gx.fn.getControlValue("vDEVICEID");this.AV11Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Deviceid=function(){try{var n=gx.util.balloon.getNew("DEVICEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Groupid=function(){try{if(this.sMode2=this.Gx_mode,this.Gx_mode=gx.fn.getGridRowMode(2,58),this.standaloneModal012(),this.standaloneNotModal012(),gx.fn.currentGridRowImpl(58)===0)return this.Gx_mode=this.sMode2,!0;var n=gx.util.balloon.getNew("GROUPID",gx.fn.currentGridRowImpl(58));if(gx.fn.gridDuplicateKey(59))return n.setError(gx.text.format(gx.getMessage("GXM_1004"),"Grupo","","","","","","","","")),this.AnyError=gx.num.trunc(1,0),this.Gx_mode=this.sMode2,n.show();gx.ajax.validSrvEvt("dyncall","Valid_Groupid",["gx.O.A6GroupId","gx.O.A22GroupName"],["A22GroupName"])}finally{this.Gx_mode=this.sMode2}return!0};this.standaloneModal012=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("GROUPID","Enabled",0):gx.fn.setCtrlProperty("GROUPID","Enabled",1)}catch(n){}return!0};this.standaloneNotModal012=function(){return!0};this.e12012_client=function(){return this.executeServerEvent("AFTER TRN",!0,arguments[0],!1,!1)};this.e13011_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14011_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,59,60,61,62,63,64,65,66,67,68,69,70];this.GXLastCtrlId=70;this.Griddevices_groupContainer=new gx.grid.grid(this,2,"Group",58,"Griddevices_group","Griddevices_group","Griddevices_groupContainer",this.CmpContext,this.IsMasterPage,"devices",[6],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Griddevices_groupContainer;t.addSingleLineEdit(6,59,"GROUPID","Grupo Id","","GroupId","int",0,"px",4,4,"right",null,[],6,"GroupId",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("prompt_6","PROMPT_6",70,0,"",0,"",null,"","","gx-prompt Image","");t.addSingleLineEdit(22,60,"GROUPNAME","Grupo Nombre","","GroupName","char",0,"px",20,20,"left",null,[],22,"GroupName",!0,0,!1,!1,"Attribute",1,"");this.Griddevices_groupContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"svchar",len:128,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Deviceid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Griddevices_groupContainer],fld:"DEVICEID",gxz:"Z1DeviceId",gxold:"O1DeviceId",gxvar:"A1DeviceId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1DeviceId=n)},v2z:function(n){n!==undefined&&(gx.O.Z1DeviceId=n)},v2c:function(){gx.fn.setControlValue("DEVICEID",gx.O.A1DeviceId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1DeviceId=this.val())},val:function(){return gx.fn.getControlValue("DEVICEID")},nac:function(){return!(""==this.AV7DeviceId)}};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICETYPE",gxz:"Z19DeviceType",gxold:"O19DeviceType",gxvar:"A19DeviceType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A19DeviceType=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19DeviceType=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("DEVICETYPE",gx.O.A19DeviceType);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19DeviceType=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("DEVICETYPE",".")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"svchar",len:1e3,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICETOKEN",gxz:"Z20DeviceToken",gxold:"O20DeviceToken",gxvar:"A20DeviceToken",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A20DeviceToken=n)},v2z:function(n){n!==undefined&&(gx.O.Z20DeviceToken=n)},v2c:function(){gx.fn.setControlValue("DEVICETOKEN",gx.O.A20DeviceToken,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20DeviceToken=this.val())},val:function(){return gx.fn.getControlValue("DEVICETOKEN")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"svchar",len:128,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICENAME",gxz:"Z21DeviceName",gxold:"O21DeviceName",gxvar:"A21DeviceName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A21DeviceName=n)},v2z:function(n){n!==undefined&&(gx.O.Z21DeviceName=n)},v2c:function(){gx.fn.setControlValue("DEVICENAME",gx.O.A21DeviceName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21DeviceName=this.val())},val:function(){return gx.fn.getControlValue("DEVICENAME")},nac:gx.falseFn};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"GROUPTABLE",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"TITLEGROUP",format:0,grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[59]={id:59,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:58,gxgrid:this.Griddevices_groupContainer,fnc:this.Valid_Groupid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GROUPID",gxz:"Z6GroupId",gxold:"O6GroupId",gxvar:"A6GroupId",ucs:[],op:[60],ip:[60,59],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A6GroupId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6GroupId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("GROUPID",n||gx.fn.currentGridRowImpl(58),gx.O.A6GroupId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6GroupId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("GROUPID",n||gx.fn.currentGridRowImpl(58),".")},nac:gx.falseFn};n[60]={id:60,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:1,grid:58,gxgrid:this.Griddevices_groupContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GROUPNAME",gxz:"Z22GroupName",gxold:"O22GroupName",gxvar:"A22GroupName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A22GroupName=n)},v2z:function(n){n!==undefined&&(gx.O.Z22GroupName=n)},v2c:function(n){gx.fn.setGridControlValue("GROUPNAME",n||gx.fn.currentGridRowImpl(58),gx.O.A22GroupName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A22GroupName=this.val())},val:function(n){return gx.fn.getGridControlValue("GROUPNAME",n||gx.fn.currentGridRowImpl(58))},nac:gx.falseFn};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"BTN_ENTER",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"BTN_CANCEL",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"BTN_DELETE",grid:0};n[70]={id:70,fld:"PROMPT_6",grid:2};this.A1DeviceId="";this.Z1DeviceId="";this.O1DeviceId="";this.A19DeviceType=0;this.Z19DeviceType=0;this.O19DeviceType=0;this.A20DeviceToken="";this.Z20DeviceToken="";this.O20DeviceToken="";this.A21DeviceName="";this.Z21DeviceName="";this.O21DeviceName="";this.Z6GroupId=0;this.O6GroupId=0;this.Z22GroupName="";this.O22GroupName="";this.A6GroupId=0;this.A22GroupName="";this.AV11Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV7DeviceId="";this.AV10WebSession={};this.A1DeviceId="";this.A19DeviceType=0;this.A20DeviceToken="";this.A21DeviceName="";this.Gx_mode="";this.Events={e12012_client:["AFTER TRN",!0],e13011_client:["ENTER",!0],e14011_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7DeviceId",fld:"vDEVICEID",pic:"",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7DeviceId",fld:"vDEVICEID",pic:"",hsh:!0},{av:"A21DeviceName",fld:"DEVICENAME",pic:""},{ctrl:"DEVICETYPE"},{av:"A19DeviceType",fld:"DEVICETYPE",pic:"9"},{av:"A20DeviceToken",fld:"DEVICETOKEN",pic:""}],[]];this.EvtParms.START=[[{av:"AV11Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_6",[59]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7DeviceId","vDEVICEID",0,"svchar",128,0);this.setVCMap("AV11Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);t.addPostingVar({rfrVar:"Gx_mode"});this.Initialize()});gx.createParentObj(devices)