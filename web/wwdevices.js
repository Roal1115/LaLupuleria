/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:44.47
*/
gx.evt.autoSkip=!1;gx.define("wwdevices",!1,function(){var n,t;this.ServerClass="wwdevices";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Validv_Devicetype=function(){try{var n=gx.util.balloon.getNew("vDEVICETYPE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110b2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e150b2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e160b2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31];this.GXLastCtrlId=31;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwdevices",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(1,26,"DEVICEID","Id","","DeviceId","svchar",0,"px",128,80,"left",null,[],1,"DeviceId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addComboBox(19,27,"DEVICETYPE","Type","DeviceType","int",null,0,!0,!1,0,"px","WWColumn");t.addSingleLineEdit(20,28,"DEVICETOKEN","Token","","DeviceToken","svchar",0,"px",1e3,80,"left",null,[],20,"DeviceToken",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(21,29,"DEVICENAME","Name","","DeviceName","svchar",0,"px",128,80,"left",null,[],21,"DeviceName",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit("Update",30,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");t.addSingleLineEdit("Delete",31,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Devicetype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDEVICETYPE",gxz:"ZV13DeviceType",gxold:"OV13DeviceType",gxvar:"AV13DeviceType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV13DeviceType=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13DeviceType=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vDEVICETYPE",gx.O.AV13DeviceType)},c2v:function(){this.val()!==undefined&&(gx.O.AV13DeviceType=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vDEVICETYPE",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"svchar",len:128,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICEID",gxz:"Z1DeviceId",gxold:"O1DeviceId",gxvar:"A1DeviceId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A1DeviceId=n)},v2z:function(n){n!==undefined&&(gx.O.Z1DeviceId=n)},v2c:function(n){gx.fn.setGridControlValue("DEVICEID",n||gx.fn.currentGridRowImpl(25),gx.O.A1DeviceId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1DeviceId=this.val())},val:function(n){return gx.fn.getGridControlValue("DEVICEID",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICETYPE",gxz:"Z19DeviceType",gxold:"O19DeviceType",gxvar:"A19DeviceType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A19DeviceType=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19DeviceType=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("DEVICETYPE",n||gx.fn.currentGridRowImpl(25),gx.O.A19DeviceType);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19DeviceType=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DEVICETYPE",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"svchar",len:1e3,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICETOKEN",gxz:"Z20DeviceToken",gxold:"O20DeviceToken",gxvar:"A20DeviceToken",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A20DeviceToken=n)},v2z:function(n){n!==undefined&&(gx.O.Z20DeviceToken=n)},v2c:function(n){gx.fn.setGridControlValue("DEVICETOKEN",n||gx.fn.currentGridRowImpl(25),gx.O.A20DeviceToken,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20DeviceToken=this.val())},val:function(n){return gx.fn.getGridControlValue("DEVICETOKEN",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"svchar",len:128,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DEVICENAME",gxz:"Z21DeviceName",gxold:"O21DeviceName",gxvar:"A21DeviceName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A21DeviceName=n)},v2z:function(n){n!==undefined&&(gx.O.Z21DeviceName=n)},v2c:function(n){gx.fn.setGridControlValue("DEVICENAME",n||gx.fn.currentGridRowImpl(25),gx.O.A21DeviceName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21DeviceName=this.val())},val:function(n){return gx.fn.getGridControlValue("DEVICENAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};this.AV13DeviceType=0;this.ZV13DeviceType=0;this.OV13DeviceType=0;this.Z1DeviceId="";this.O1DeviceId="";this.Z19DeviceType=0;this.O19DeviceType=0;this.Z20DeviceToken="";this.O20DeviceToken="";this.Z21DeviceName="";this.O21DeviceName="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13DeviceType=0;this.A1DeviceId="";this.A19DeviceType=0;this.A20DeviceToken="";this.A21DeviceName="";this.AV14Update="";this.AV15Delete="";this.AV19Pgmname="";this.Events={e110b2_client:["'DOINSERT'",!0],e150b2_client:["ENTER",!0],e160b2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"},{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A1DeviceId",fld:"DEVICEID",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A1DeviceId",fld:"DEVICEID",pic:"",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"vDEVICETYPE"},{av:"AV13DeviceType",fld:"vDEVICETYPE",pic:"9"}],[]];this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV19Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.createParentObj(wwdevices)