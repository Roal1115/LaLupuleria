/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:53:7.36
*/
gx.evt.autoSkip=!1;gx.define("gx0030",!1,function(){var n,t;this.ServerClass="gx0030";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12pUsersId=gx.fn.getIntegerValue("vPUSERSID",".")};this.e171f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e111f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSID","Visible",!0)):(gx.fn.setCtrlProperty("USERSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSIDFILTERCONTAINER","Class")',ctrl:"USERSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSID","Visible")',ctrl:"vCUSERSID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e121f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSNAMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSNAMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSNAME","Visible",!0)):(gx.fn.setCtrlProperty("USERSNAMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSNAME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSNAMEFILTERCONTAINER","Class")',ctrl:"USERSNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSNAME","Visible")',ctrl:"vCUSERSNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e131f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSPASSWORD","Visible",!0)):(gx.fn.setCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSPASSWORD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class")',ctrl:"USERSPASSWORDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSPASSWORD","Visible")',ctrl:"vCUSERSPASSWORD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e141f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSBUSINESS","Visible",!0)):(gx.fn.setCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSBUSINESS","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class")',ctrl:"USERSBUSINESSFILTERCONTAINER",prop:"Class"},{ctrl:"vCUSERSBUSINESS"}]),gx.$.Deferred().resolve()};this.e151f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSCURPFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSCURPFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSCURP","Visible",!0)):(gx.fn.setCtrlProperty("USERSCURPFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSCURP","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSCURPFILTERCONTAINER","Class")',ctrl:"USERSCURPFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSCURP","Visible")',ctrl:"vCUSERSCURP",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e161f1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSERSMATRICULA","Visible",!0)):(gx.fn.setCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSERSMATRICULA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class")',ctrl:"USERSMATRICULAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSMATRICULA","Visible")',ctrl:"vCUSERSMATRICULA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e201f2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e211f1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85];this.GXLastCtrlId=85;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0030",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(3,76,"USERSID","Id","","UsersId","int",0,"px",4,4,"right",null,[],3,"UsersId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(4,77,"USERSNAME","Nombre Usuario","","UsersName","char",0,"px",20,20,"left",null,[],4,"UsersName",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(5,78,"USERSPASSWORD","Contrasenia","","UsersPassword","char",0,"px",20,20,"left",null,[],5,"UsersPassword",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addComboBox(2,79,"USERSBUSINESS","Empresa","UsersBusiness","char",null,0,!0,!1,0,"px","WWColumn OptionalColumn");t.addSingleLineEdit(45,80,"USERSCURP","CURP","","UsersCURP","char",0,"px",18,18,"left",null,[],45,"UsersCURP",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addBitmap(46,"USERSFOTOGRAFIA",81,0,"px",17,"px",null,"","Fotografia","ImageAttribute","WWColumn OptionalColumn");t.addSingleLineEdit(47,82,"USERSMATRICULA","Matricula","","UsersMatricula","int",0,"px",8,8,"right",null,[],47,"UsersMatricula",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"USERSIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLUSERSIDFILTER",format:1,grid:0,evt:"e111f1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSID",gxz:"ZV6cUsersId",gxold:"OV6cUsersId",gxvar:"AV6cUsersId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cUsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cUsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCUSERSID",gx.O.AV6cUsersId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cUsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSERSID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"USERSNAMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLUSERSNAMEFILTER",format:1,grid:0,evt:"e121f1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSNAME",gxz:"ZV7cUsersName",gxold:"OV7cUsersName",gxvar:"AV7cUsersName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cUsersName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cUsersName=n)},v2c:function(){gx.fn.setControlValue("vCUSERSNAME",gx.O.AV7cUsersName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cUsersName=this.val())},val:function(){return gx.fn.getControlValue("vCUSERSNAME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"USERSPASSWORDFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLUSERSPASSWORDFILTER",format:1,grid:0,evt:"e131f1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSPASSWORD",gxz:"ZV8cUsersPassword",gxold:"OV8cUsersPassword",gxvar:"AV8cUsersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cUsersPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cUsersPassword=n)},v2c:function(){gx.fn.setControlValue("vCUSERSPASSWORD",gx.O.AV8cUsersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cUsersPassword=this.val())},val:function(){return gx.fn.getControlValue("vCUSERSPASSWORD")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"USERSBUSINESSFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLUSERSBUSINESSFILTER",format:1,grid:0,evt:"e141f1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSBUSINESS",gxz:"ZV9cUsersBusiness",gxold:"OV9cUsersBusiness",gxvar:"AV9cUsersBusiness",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV9cUsersBusiness=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cUsersBusiness=n)},v2c:function(){gx.fn.setComboBoxValue("vCUSERSBUSINESS",gx.O.AV9cUsersBusiness)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cUsersBusiness=this.val())},val:function(){return gx.fn.getControlValue("vCUSERSBUSINESS")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"USERSCURPFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLUSERSCURPFILTER",format:1,grid:0,evt:"e151f1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:18,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSCURP",gxz:"ZV10cUsersCURP",gxold:"OV10cUsersCURP",gxvar:"AV10cUsersCURP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cUsersCURP=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cUsersCURP=n)},v2c:function(){gx.fn.setControlValue("vCUSERSCURP",gx.O.AV10cUsersCURP,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cUsersCURP=this.val())},val:function(){return gx.fn.getControlValue("vCUSERSCURP")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"USERSMATRICULAFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLUSERSMATRICULAFILTER",format:1,grid:0,evt:"e161f1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSERSMATRICULA",gxz:"ZV11cUsersMatricula",gxold:"OV11cUsersMatricula",gxvar:"AV11cUsersMatricula",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cUsersMatricula=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cUsersMatricula=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCUSERSMATRICULA",gx.O.AV11cUsersMatricula,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cUsersMatricula=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSERSMATRICULA",".")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GRIDTABLE",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTNTOGGLE",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[75]={id:75,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[76]={id:76,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USERSID",n||gx.fn.currentGridRowImpl(74),gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USERSID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[77]={id:77,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSNAME",gxz:"Z4UsersName",gxold:"O4UsersName",gxvar:"A4UsersName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A4UsersName=n)},v2z:function(n){n!==undefined&&(gx.O.Z4UsersName=n)},v2c:function(n){gx.fn.setGridControlValue("USERSNAME",n||gx.fn.currentGridRowImpl(74),gx.O.A4UsersName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4UsersName=this.val())},val:function(n){return gx.fn.getGridControlValue("USERSNAME",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[78]={id:78,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSPASSWORD",gxz:"Z5UsersPassword",gxold:"O5UsersPassword",gxvar:"A5UsersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A5UsersPassword=n)},v2z:function(n){n!==undefined&&(gx.O.Z5UsersPassword=n)},v2c:function(n){gx.fn.setGridControlValue("USERSPASSWORD",n||gx.fn.currentGridRowImpl(74),gx.O.A5UsersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5UsersPassword=this.val())},val:function(n){return gx.fn.getGridControlValue("USERSPASSWORD",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[79]={id:79,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSBUSINESS",gxz:"Z2UsersBusiness",gxold:"O2UsersBusiness",gxvar:"A2UsersBusiness",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A2UsersBusiness=n)},v2z:function(n){n!==undefined&&(gx.O.Z2UsersBusiness=n)},v2c:function(n){gx.fn.setGridComboBoxValue("USERSBUSINESS",n||gx.fn.currentGridRowImpl(74),gx.O.A2UsersBusiness)},c2v:function(){this.val()!==undefined&&(gx.O.A2UsersBusiness=this.val())},val:function(n){return gx.fn.getGridControlValue("USERSBUSINESS",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[80]={id:80,lvl:2,type:"char",len:18,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSCURP",gxz:"Z45UsersCURP",gxold:"O45UsersCURP",gxvar:"A45UsersCURP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A45UsersCURP=n)},v2z:function(n){n!==undefined&&(gx.O.Z45UsersCURP=n)},v2c:function(n){gx.fn.setGridControlValue("USERSCURP",n||gx.fn.currentGridRowImpl(74),gx.O.A45UsersCURP,0)},c2v:function(){this.val()!==undefined&&(gx.O.A45UsersCURP=this.val())},val:function(n){return gx.fn.getGridControlValue("USERSCURP",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[81]={id:81,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSFOTOGRAFIA",gxz:"Z46UsersFotografia",gxold:"O46UsersFotografia",gxvar:"A46UsersFotografia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A46UsersFotografia=n)},v2z:function(n){n!==undefined&&(gx.O.Z46UsersFotografia=n)},v2c:function(n){gx.fn.setGridMultimediaValue("USERSFOTOGRAFIA",n||gx.fn.currentGridRowImpl(74),gx.O.A46UsersFotografia,gx.O.A40000UsersFotografia_GXI)},c2v:function(){gx.O.A40000UsersFotografia_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A46UsersFotografia=this.val())},val:function(n){return gx.fn.getGridControlValue("USERSFOTOGRAFIA",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("USERSFOTOGRAFIA_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"A40000UsersFotografia_GXI",nac:gx.falseFn};n[82]={id:82,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSMATRICULA",gxz:"Z47UsersMatricula",gxold:"O47UsersMatricula",gxvar:"A47UsersMatricula",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A47UsersMatricula=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z47UsersMatricula=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USERSMATRICULA",n||gx.fn.currentGridRowImpl(74),gx.O.A47UsersMatricula,0)},c2v:function(){this.val()!==undefined&&(gx.O.A47UsersMatricula=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USERSMATRICULA",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"BTN_CANCEL",grid:0};this.AV6cUsersId=0;this.ZV6cUsersId=0;this.OV6cUsersId=0;this.AV7cUsersName="";this.ZV7cUsersName="";this.OV7cUsersName="";this.AV8cUsersPassword="";this.ZV8cUsersPassword="";this.OV8cUsersPassword="";this.AV9cUsersBusiness="";this.ZV9cUsersBusiness="";this.OV9cUsersBusiness="";this.AV10cUsersCURP="";this.ZV10cUsersCURP="";this.OV10cUsersCURP="";this.AV11cUsersMatricula=0;this.ZV11cUsersMatricula=0;this.OV11cUsersMatricula=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z3UsersId=0;this.O3UsersId=0;this.Z4UsersName="";this.O4UsersName="";this.Z5UsersPassword="";this.O5UsersPassword="";this.Z2UsersBusiness="";this.O2UsersBusiness="";this.Z45UsersCURP="";this.O45UsersCURP="";this.Z46UsersFotografia="";this.O46UsersFotografia="";this.Z47UsersMatricula=0;this.O47UsersMatricula=0;this.AV6cUsersId=0;this.AV7cUsersName="";this.AV8cUsersPassword="";this.AV9cUsersBusiness="";this.AV10cUsersCURP="";this.AV11cUsersMatricula=0;this.A40000UsersFotografia_GXI="";this.AV12pUsersId=0;this.AV5LinkSelection="";this.A3UsersId=0;this.A4UsersName="";this.A5UsersPassword="";this.A2UsersBusiness="";this.A45UsersCURP="";this.A46UsersFotografia="";this.A47UsersMatricula=0;this.Events={e201f2_client:["ENTER",!0],e211f1_client:["CANCEL",!0],e171f1_client:["'TOGGLE'",!1],e111f1_client:["LBLUSERSIDFILTER.CLICK",!1],e121f1_client:["LBLUSERSNAMEFILTER.CLICK",!1],e131f1_client:["LBLUSERSPASSWORDFILTER.CLICK",!1],e141f1_client:["LBLUSERSBUSINESSFILTER.CLICK",!1],e151f1_client:["LBLUSERSCURPFILTER.CLICK",!1],e161f1_client:["LBLUSERSMATRICULAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsersId",fld:"vCUSERSID",pic:"ZZZ9"},{av:"AV7cUsersName",fld:"vCUSERSNAME",pic:""},{av:"AV8cUsersPassword",fld:"vCUSERSPASSWORD",pic:""},{ctrl:"vCUSERSBUSINESS"},{av:"AV9cUsersBusiness",fld:"vCUSERSBUSINESS",pic:""},{av:"AV10cUsersCURP",fld:"vCUSERSCURP",pic:""},{av:"AV11cUsersMatricula",fld:"vCUSERSMATRICULA",pic:"ZZZZZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLUSERSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSIDFILTERCONTAINER","Class")',ctrl:"USERSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSIDFILTERCONTAINER","Class")',ctrl:"USERSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSID","Visible")',ctrl:"vCUSERSID",prop:"Visible"}]];this.EvtParms["LBLUSERSNAMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSNAMEFILTERCONTAINER","Class")',ctrl:"USERSNAMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSNAMEFILTERCONTAINER","Class")',ctrl:"USERSNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSNAME","Visible")',ctrl:"vCUSERSNAME",prop:"Visible"}]];this.EvtParms["LBLUSERSPASSWORDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class")',ctrl:"USERSPASSWORDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSPASSWORDFILTERCONTAINER","Class")',ctrl:"USERSPASSWORDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSPASSWORD","Visible")',ctrl:"vCUSERSPASSWORD",prop:"Visible"}]];this.EvtParms["LBLUSERSBUSINESSFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class")',ctrl:"USERSBUSINESSFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSBUSINESSFILTERCONTAINER","Class")',ctrl:"USERSBUSINESSFILTERCONTAINER",prop:"Class"},{ctrl:"vCUSERSBUSINESS"}]];this.EvtParms["LBLUSERSCURPFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSCURPFILTERCONTAINER","Class")',ctrl:"USERSCURPFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSCURPFILTERCONTAINER","Class")',ctrl:"USERSCURPFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSCURP","Visible")',ctrl:"vCUSERSCURP",prop:"Visible"}]];this.EvtParms["LBLUSERSMATRICULAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class")',ctrl:"USERSMATRICULAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USERSMATRICULAFILTERCONTAINER","Class")',ctrl:"USERSMATRICULAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSERSMATRICULA","Visible")',ctrl:"vCUSERSMATRICULA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A3UsersId",fld:"USERSID",pic:"ZZZ9",hsh:!0}],[{av:"AV12pUsersId",fld:"vPUSERSID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsersId",fld:"vCUSERSID",pic:"ZZZ9"},{av:"AV7cUsersName",fld:"vCUSERSNAME",pic:""},{av:"AV8cUsersPassword",fld:"vCUSERSPASSWORD",pic:""},{ctrl:"vCUSERSBUSINESS"},{av:"AV9cUsersBusiness",fld:"vCUSERSBUSINESS",pic:""},{av:"AV10cUsersCURP",fld:"vCUSERSCURP",pic:""},{av:"AV11cUsersMatricula",fld:"vCUSERSMATRICULA",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsersId",fld:"vCUSERSID",pic:"ZZZ9"},{av:"AV7cUsersName",fld:"vCUSERSNAME",pic:""},{av:"AV8cUsersPassword",fld:"vCUSERSPASSWORD",pic:""},{ctrl:"vCUSERSBUSINESS"},{av:"AV9cUsersBusiness",fld:"vCUSERSBUSINESS",pic:""},{av:"AV10cUsersCURP",fld:"vCUSERSCURP",pic:""},{av:"AV11cUsersMatricula",fld:"vCUSERSMATRICULA",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsersId",fld:"vCUSERSID",pic:"ZZZ9"},{av:"AV7cUsersName",fld:"vCUSERSNAME",pic:""},{av:"AV8cUsersPassword",fld:"vCUSERSPASSWORD",pic:""},{ctrl:"vCUSERSBUSINESS"},{av:"AV9cUsersBusiness",fld:"vCUSERSBUSINESS",pic:""},{av:"AV10cUsersCURP",fld:"vCUSERSCURP",pic:""},{av:"AV11cUsersMatricula",fld:"vCUSERSMATRICULA",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsersId",fld:"vCUSERSID",pic:"ZZZ9"},{av:"AV7cUsersName",fld:"vCUSERSNAME",pic:""},{av:"AV8cUsersPassword",fld:"vCUSERSPASSWORD",pic:""},{ctrl:"vCUSERSBUSINESS"},{av:"AV9cUsersBusiness",fld:"vCUSERSBUSINESS",pic:""},{av:"AV10cUsersCURP",fld:"vCUSERSCURP",pic:""},{av:"AV11cUsersMatricula",fld:"vCUSERSMATRICULA",pic:"ZZZZZZZ9"}],[]];this.setVCMap("AV12pUsersId","vPUSERSID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);this.Initialize()});gx.createParentObj(gx0030)