/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:51:28.17
*/
gx.evt.autoSkip=!1;gx.define("calendariocalendariomeswc",!0,function(n){var t,i;this.ServerClass="calendariocalendariomeswc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6CalendarioId=gx.fn.getIntegerValue("vCALENDARIOID",".");this.AV6CalendarioId=gx.fn.getIntegerValue("vCALENDARIOID",".")};this.e13162_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e14162_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,15,16,17,18,19];this.GXLastCtrlId=19;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"calendariocalendariomeswc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(17,13,"CALENDARIOMESID","Mes Id","","CalendarioMesId","int",0,"px",4,4,"right",null,[],17,"CalendarioMesId",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(70,14,"CALENDARIOMESDATE","Mes Date","","CalendarioMesDate","date",0,"px",8,8,"right",null,[],70,"CalendarioMesDate",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(71,15,"CALENDARIOMESDESCRIPTION","Mes Description","","CalendarioMesDescription","char",0,"px",250,80,"left",null,[],71,"CalendarioMesDescription",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"GRIDCELL",grid:0};t[6]={id:6,fld:"GRIDTABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[13]={id:13,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALENDARIOMESID",gxz:"Z17CalendarioMesId",gxold:"O17CalendarioMesId",gxvar:"A17CalendarioMesId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17CalendarioMesId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17CalendarioMesId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CALENDARIOMESID",n||gx.fn.currentGridRowImpl(12),gx.O.A17CalendarioMesId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A17CalendarioMesId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CALENDARIOMESID",n||gx.fn.currentGridRowImpl(12),".")},nac:gx.falseFn};t[14]={id:14,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALENDARIOMESDATE",gxz:"Z70CalendarioMesDate",gxold:"O70CalendarioMesDate",gxvar:"A70CalendarioMesDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A70CalendarioMesDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z70CalendarioMesDate=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("CALENDARIOMESDATE",n||gx.fn.currentGridRowImpl(12),gx.O.A70CalendarioMesDate,0)},c2v:function(){this.val()!==undefined&&(gx.O.A70CalendarioMesDate=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("CALENDARIOMESDATE",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={id:15,lvl:2,type:"char",len:250,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALENDARIOMESDESCRIPTION",gxz:"Z71CalendarioMesDescription",gxold:"O71CalendarioMesDescription",gxvar:"A71CalendarioMesDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A71CalendarioMesDescription=n)},v2z:function(n){n!==undefined&&(gx.O.Z71CalendarioMesDescription=n)},v2c:function(n){gx.fn.setGridControlValue("CALENDARIOMESDESCRIPTION",n||gx.fn.currentGridRowImpl(12),gx.O.A71CalendarioMesDescription,0)},c2v:function(){this.val()!==undefined&&(gx.O.A71CalendarioMesDescription=this.val())},val:function(n){return gx.fn.getGridControlValue("CALENDARIOMESDESCRIPTION",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALENDARIOID",gxz:"Z16CalendarioId",gxold:"O16CalendarioId",gxvar:"A16CalendarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A16CalendarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z16CalendarioId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALENDARIOID",gx.O.A16CalendarioId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A16CalendarioId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALENDARIOID",".")},nac:gx.falseFn};this.declareDomainHdlr(19,function(){});this.Z17CalendarioMesId=0;this.O17CalendarioMesId=0;this.Z70CalendarioMesDate=gx.date.nullDate();this.O70CalendarioMesDate=gx.date.nullDate();this.Z71CalendarioMesDescription="";this.O71CalendarioMesDescription="";this.A16CalendarioId=0;this.Z16CalendarioId=0;this.O16CalendarioId=0;this.A16CalendarioId=0;this.AV6CalendarioId=0;this.A17CalendarioMesId=0;this.A70CalendarioMesDate=gx.date.nullDate();this.A71CalendarioMesDescription="";this.Events={e13162_client:["ENTER",!0],e14162_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("CALENDARIOID","Visible")',ctrl:"CALENDARIOID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6CalendarioId",fld:"vCALENDARIOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.setVCMap("AV6CalendarioId","vCALENDARIOID",0,"int",4,0);this.setVCMap("AV6CalendarioId","vCALENDARIOID",0,"int",4,0);this.setVCMap("AV6CalendarioId","vCALENDARIOID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6CalendarioId"});this.Initialize()})