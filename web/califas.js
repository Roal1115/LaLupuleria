/*!   GeneXus C# 15_0_12-126726 on 10/11/2018 18:52:24.82
*/
gx.evt.autoSkip=!1;gx.define("califas",!1,function(){this.ServerClass="califas";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7CalifasId=gx.fn.getIntegerValue("vCALIFASID",".");this.A13CalifasId=gx.fn.getIntegerValue("CALIFASID",".");this.AV11Insert_UsersId=gx.fn.getIntegerValue("vINSERT_USERSID",".");this.AV12Insert_MateriasId=gx.fn.getIntegerValue("vINSERT_MATERIASID",".");this.AV14Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Usersid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Usersid",["gx.O.A3UsersId"],[]),!0};this.Valid_Materiasid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Materiasid",["gx.O.A11MateriasId"],[]),!0};this.e12052_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130511_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140511_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90];this.GXLastCtrlId=90;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usersid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERSID",gxz:"Z3UsersId",gxold:"O3UsersId",gxvar:"A3UsersId",ucs:[],op:[],ip:[34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3UsersId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3UsersId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERSID",gx.O.A3UsersId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsersId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERSID",".")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_UsersId)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Materiasid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MATERIASID",gxz:"Z11MateriasId",gxold:"O11MateriasId",gxvar:"A11MateriasId",ucs:[],op:[],ip:[39],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11MateriasId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11MateriasId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MATERIASID",gx.O.A11MateriasId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11MateriasId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MATERIASID",".")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV12Insert_MateriasId)}};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS1",gxz:"Z53Califas1",gxold:"O53Califas1",gxvar:"A53Califas1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A53Califas1=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z53Califas1=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS1",gx.O.A53Califas1,0)},c2v:function(){this.val()!==undefined&&(gx.O.A53Califas1=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS1",".")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS2",gxz:"Z54Califas2",gxold:"O54Califas2",gxvar:"A54Califas2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A54Califas2=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z54Califas2=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS2",gx.O.A54Califas2,0)},c2v:function(){this.val()!==undefined&&(gx.O.A54Califas2=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS2",".")},nac:gx.falseFn};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS3",gxz:"Z55Califas3",gxold:"O55Califas3",gxvar:"A55Califas3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A55Califas3=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z55Califas3=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS3",gx.O.A55Califas3,0)},c2v:function(){this.val()!==undefined&&(gx.O.A55Califas3=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS3",".")},nac:gx.falseFn};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS4",gxz:"Z56Califas4",gxold:"O56Califas4",gxvar:"A56Califas4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A56Califas4=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z56Califas4=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS4",gx.O.A56Califas4,0)},c2v:function(){this.val()!==undefined&&(gx.O.A56Califas4=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS4",".")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS5",gxz:"Z57Califas5",gxold:"O57Califas5",gxvar:"A57Califas5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A57Califas5=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z57Califas5=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS5",gx.O.A57Califas5,0)},c2v:function(){this.val()!==undefined&&(gx.O.A57Califas5=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS5",".")},nac:gx.falseFn};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS6",gxz:"Z58Califas6",gxold:"O58Califas6",gxvar:"A58Califas6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A58Califas6=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z58Califas6=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS6",gx.O.A58Califas6,0)},c2v:function(){this.val()!==undefined&&(gx.O.A58Califas6=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS6",".")},nac:gx.falseFn};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS7",gxz:"Z59Califas7",gxold:"O59Califas7",gxvar:"A59Califas7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A59Califas7=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z59Califas7=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS7",gx.O.A59Califas7,0)},c2v:function(){this.val()!==undefined&&(gx.O.A59Califas7=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS7",".")},nac:gx.falseFn};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CALIFAS8",gxz:"Z60Califas8",gxold:"O60Califas8",gxvar:"A60Califas8",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A60Califas8=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z60Califas8=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CALIFAS8",gx.O.A60Califas8,0)},c2v:function(){this.val()!==undefined&&(gx.O.A60Califas8=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CALIFAS8",".")},nac:gx.falseFn};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"BTN_ENTER",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"BTN_CANCEL",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"BTN_DELETE",grid:0};n[89]={id:89,fld:"PROMPT_3",grid:11};n[90]={id:90,fld:"PROMPT_11",grid:11};this.A3UsersId=0;this.Z3UsersId=0;this.O3UsersId=0;this.A11MateriasId=0;this.Z11MateriasId=0;this.O11MateriasId=0;this.A53Califas1=0;this.Z53Califas1=0;this.O53Califas1=0;this.A54Califas2=0;this.Z54Califas2=0;this.O54Califas2=0;this.A55Califas3=0;this.Z55Califas3=0;this.O55Califas3=0;this.A56Califas4=0;this.Z56Califas4=0;this.O56Califas4=0;this.A57Califas5=0;this.Z57Califas5=0;this.O57Califas5=0;this.A58Califas6=0;this.Z58Califas6=0;this.O58Califas6=0;this.A59Califas7=0;this.Z59Califas7=0;this.O59Califas7=0;this.A60Califas8=0;this.Z60Califas8=0;this.O60Califas8=0;this.AV14Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_UsersId=0;this.AV12Insert_MateriasId=0;this.AV15GXV1=0;this.AV13TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7CalifasId=0;this.AV10WebSession={};this.A13CalifasId=0;this.A3UsersId=0;this.A11MateriasId=0;this.A53Califas1=0;this.A54Califas2=0;this.A55Califas3=0;this.A56Califas4=0;this.A57Califas5=0;this.A58Califas6=0;this.A59Califas7=0;this.A60Califas8=0;this.Gx_mode="";this.Events={e12052_client:["AFTER TRN",!0],e130511_client:["ENTER",!0],e140511_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7CalifasId",fld:"vCALIFASID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7CalifasId",fld:"vCALIFASID",pic:"ZZZ9",hsh:!0},{av:"AV11Insert_UsersId",fld:"vINSERT_USERSID",pic:"ZZZ9"},{av:"AV12Insert_MateriasId",fld:"vINSERT_MATERIASID",pic:"ZZZ9"},{av:"A13CalifasId",fld:"CALIFASID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV11Insert_UsersId",fld:"vINSERT_USERSID",pic:"ZZZ9"},{av:"AV12Insert_MateriasId",fld:"vINSERT_MATERIASID",pic:"ZZZ9"},{av:"AV15GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV13TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_3",[34]);this.setPrompt("PROMPT_11",[39]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7CalifasId","vCALIFASID",0,"int",4,0);this.setVCMap("A13CalifasId","CALIFASID",0,"int",4,0);this.setVCMap("AV11Insert_UsersId","vINSERT_USERSID",0,"int",4,0);this.setVCMap("AV12Insert_MateriasId","vINSERT_MATERIASID",0,"int",4,0);this.setVCMap("AV14Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.createParentObj(califas)