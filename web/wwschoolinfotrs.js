/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:53:1.66
*/
gx.evt.autoSkip=!1;gx.define("wwschoolinfotrs",!1,function(){var n,t;this.ServerClass="wwschoolinfotrs";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME")};this.e111l2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e151l2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e161l2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwschoolinfotrs",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(74,26,"SCHOOLINFOTRSID","Trs Id","","SchoolInfoTrsId","int",0,"px",4,4,"right",null,[],74,"SchoolInfoTrsId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(75,27,"SCHOOLINFOTRSNOMBRE","Trs Nombre","","SchoolInfoTrsNombre","char",0,"px",200,80,"left",null,[],75,"SchoolInfoTrsNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(76,28,"SCHOOLINFOTRSSOLGAN","Trs Solgan","","SchoolInfoTrsSolgan","char",0,"px",200,80,"left",null,[],76,"SchoolInfoTrsSolgan",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(77,29,"SCHOOLINFOTRSADDRESS","Trs Address","","SchoolInfoTrsAddress","svchar",0,"px",1024,80,"left",null,[],77,"SchoolInfoTrsAddress",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(78,30,"SCHOOLINFOTRSPHONE","Trs Phone","","SchoolInfoTrsPhone","char",0,"px",20,20,"left",null,[],78,"SchoolInfoTrsPhone",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap(79,"SCHOOLINFOTRSIMAGEN",31,0,"px",17,"px",null,"","Trs Imagen","ImageAttribute","WWColumn WWOptionalColumn");t.addSingleLineEdit("Update",32,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");t.addSingleLineEdit("Delete",33,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"char",len:200,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSCHOOLINFOTRSNOMBRE",gxz:"ZV13SchoolInfoTrsNombre",gxold:"OV13SchoolInfoTrsNombre",gxvar:"AV13SchoolInfoTrsNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13SchoolInfoTrsNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13SchoolInfoTrsNombre=n)},v2c:function(){gx.fn.setControlValue("vSCHOOLINFOTRSNOMBRE",gx.O.AV13SchoolInfoTrsNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13SchoolInfoTrsNombre=this.val())},val:function(){return gx.fn.getControlValue("vSCHOOLINFOTRSNOMBRE")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSID",gxz:"Z74SchoolInfoTrsId",gxold:"O74SchoolInfoTrsId",gxvar:"A74SchoolInfoTrsId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A74SchoolInfoTrsId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z74SchoolInfoTrsId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SCHOOLINFOTRSID",n||gx.fn.currentGridRowImpl(25),gx.O.A74SchoolInfoTrsId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A74SchoolInfoTrsId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SCHOOLINFOTRSID",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"char",len:200,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSNOMBRE",gxz:"Z75SchoolInfoTrsNombre",gxold:"O75SchoolInfoTrsNombre",gxvar:"A75SchoolInfoTrsNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A75SchoolInfoTrsNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z75SchoolInfoTrsNombre=n)},v2c:function(n){gx.fn.setGridControlValue("SCHOOLINFOTRSNOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A75SchoolInfoTrsNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A75SchoolInfoTrsNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSNOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"char",len:200,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSSOLGAN",gxz:"Z76SchoolInfoTrsSolgan",gxold:"O76SchoolInfoTrsSolgan",gxvar:"A76SchoolInfoTrsSolgan",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A76SchoolInfoTrsSolgan=n)},v2z:function(n){n!==undefined&&(gx.O.Z76SchoolInfoTrsSolgan=n)},v2c:function(n){gx.fn.setGridControlValue("SCHOOLINFOTRSSOLGAN",n||gx.fn.currentGridRowImpl(25),gx.O.A76SchoolInfoTrsSolgan,0)},c2v:function(){this.val()!==undefined&&(gx.O.A76SchoolInfoTrsSolgan=this.val())},val:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSSOLGAN",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"svchar",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSADDRESS",gxz:"Z77SchoolInfoTrsAddress",gxold:"O77SchoolInfoTrsAddress",gxvar:"A77SchoolInfoTrsAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A77SchoolInfoTrsAddress=n)},v2z:function(n){n!==undefined&&(gx.O.Z77SchoolInfoTrsAddress=n)},v2c:function(n){gx.fn.setGridControlValue("SCHOOLINFOTRSADDRESS",n||gx.fn.currentGridRowImpl(25),gx.O.A77SchoolInfoTrsAddress,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A77SchoolInfoTrsAddress=this.val())},val:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSADDRESS",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSPHONE",gxz:"Z78SchoolInfoTrsPhone",gxold:"O78SchoolInfoTrsPhone",gxvar:"A78SchoolInfoTrsPhone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"tel",v2v:function(n){n!==undefined&&(gx.O.A78SchoolInfoTrsPhone=n)},v2z:function(n){n!==undefined&&(gx.O.Z78SchoolInfoTrsPhone=n)},v2c:function(n){gx.fn.setGridControlValue("SCHOOLINFOTRSPHONE",n||gx.fn.currentGridRowImpl(25),gx.O.A78SchoolInfoTrsPhone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A78SchoolInfoTrsPhone=this.val())},val:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSPHONE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SCHOOLINFOTRSIMAGEN",gxz:"Z79SchoolInfoTrsImagen",gxold:"O79SchoolInfoTrsImagen",gxvar:"A79SchoolInfoTrsImagen",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A79SchoolInfoTrsImagen=n)},v2z:function(n){n!==undefined&&(gx.O.Z79SchoolInfoTrsImagen=n)},v2c:function(n){gx.fn.setGridMultimediaValue("SCHOOLINFOTRSIMAGEN",n||gx.fn.currentGridRowImpl(25),gx.O.A79SchoolInfoTrsImagen,gx.O.A40000SchoolInfoTrsImagen_GXI)},c2v:function(){gx.O.A40000SchoolInfoTrsImagen_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A79SchoolInfoTrsImagen=this.val())},val:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSIMAGEN",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("SCHOOLINFOTRSIMAGEN_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"A40000SchoolInfoTrsImagen_GXI",nac:gx.falseFn};n[32]={id:32,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[33]={id:33,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};this.AV13SchoolInfoTrsNombre="";this.ZV13SchoolInfoTrsNombre="";this.OV13SchoolInfoTrsNombre="";this.Z74SchoolInfoTrsId=0;this.O74SchoolInfoTrsId=0;this.Z75SchoolInfoTrsNombre="";this.O75SchoolInfoTrsNombre="";this.Z76SchoolInfoTrsSolgan="";this.O76SchoolInfoTrsSolgan="";this.Z77SchoolInfoTrsAddress="";this.O77SchoolInfoTrsAddress="";this.Z78SchoolInfoTrsPhone="";this.O78SchoolInfoTrsPhone="";this.Z79SchoolInfoTrsImagen="";this.O79SchoolInfoTrsImagen="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13SchoolInfoTrsNombre="";this.A40000SchoolInfoTrsImagen_GXI="";this.A74SchoolInfoTrsId=0;this.A75SchoolInfoTrsNombre="";this.A76SchoolInfoTrsSolgan="";this.A77SchoolInfoTrsAddress="";this.A78SchoolInfoTrsPhone="";this.A79SchoolInfoTrsImagen="";this.AV14Update="";this.AV15Delete="";this.AV19Pgmname="";this.Events={e111l2_client:["'DOINSERT'",!0],e151l2_client:["ENTER",!0],e161l2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{ctrl:"FORM",prop:"Caption"},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A74SchoolInfoTrsId",fld:"SCHOOLINFOTRSID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("SCHOOLINFOTRSNOMBRE","Link")',ctrl:"SCHOOLINFOTRSNOMBRE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A74SchoolInfoTrsId",fld:"SCHOOLINFOTRSID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13SchoolInfoTrsNombre",fld:"vSCHOOLINFOTRSNOMBRE",pic:""}],[]];this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV19Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.createParentObj(wwschoolinfotrs)