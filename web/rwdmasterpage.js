/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:41.89
*/
gx.evt.autoSkip=!1;gx.define("rwdmasterpage",!1,function(){this.ServerClass="rwdmasterpage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.IsMasterPage=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e11041_client=function(){return this.clearMessages(),this.call("wwusers.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e12041_client=function(){return this.clearMessages(),this.call("dispositivos.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e13041_client=function(){return this.clearMessages(),this.call("sendnotifications.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e17042_client=function(){return this.executeServerEvent("ENTER_MPAGE",!0,null,!1,!1)};this.e18042_client=function(){return this.executeServerEvent("CANCEL_MPAGE",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,27,28,29,30,31];this.GXLastCtrlId=31;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"HEADER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"APPLICATIONHEADER",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"IMAGE1",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BUTTON1",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BUTTON2",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BUTTON3",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"RECENT",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"CONTENT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};this.Events={e17042_client:["ENTER_MPAGE",!0],e18042_client:["CANCEL_MPAGE",!0],e11041_client:["CLIENTES_MPAGE",!1],e12041_client:["DISPOSITIVOS_MPAGE",!1],e13041_client:["SEND NOTIFICATION_MPAGE",!1]};this.EvtParms.REFRESH_MPAGE=[[{ctrl:"FORM_MPAGE",prop:"Caption"}],[{ctrl:"WCRECENTLINKS_MPAGE"}]];this.EvtParms.START_MPAGE=[[],[]];this.EvtParms.CLIENTES_MPAGE=[[],[]];this.EvtParms.DISPOSITIVOS_MPAGE=[[],[]];this.EvtParms["SEND NOTIFICATION_MPAGE"]=[[],[]];this.Initialize();this.setComponent({id:"WCRECENTLINKS",GXClass:null,Prefix:"MPW0026",lvl:1})});gx.createMasterPage(rwdmasterpage)