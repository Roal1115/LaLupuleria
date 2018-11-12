using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"home_level_detail", "dll");
      sc.Add( @"home_level_detail", "dll");
      sc.Add( @"infoes_level_detail", "dll");
      sc.Add( @"infoes_level_detail", "dll");
      sc.Add( @"mensajes_level_detail_grid1", "dll");
      sc.Add( @"mensajes_level_detail_grid1", "dll");
      sc.Add( @"mensajes_level_detail", "dll");
      sc.Add( @"mensajes_level_detail", "dll");
      sc.Add( @"schoolinfo_level_detail", "dll");
      sc.Add( @"schoolinfo_level_detail", "dll");
      sc.Add( @"materesp_level_detail_grid1", "dll");
      sc.Add( @"materesp_level_detail_grid1", "dll");
      sc.Add( @"materesp_level_detail", "dll");
      sc.Add( @"materesp_level_detail", "dll");
      sc.Add( @"pagoshist_level_detail_grid1", "dll");
      sc.Add( @"pagoshist_level_detail_grid1", "dll");
      sc.Add( @"anuncios_level_detail_grid1", "dll");
      sc.Add( @"anuncios_level_detail_grid1", "dll");
      sc.Add( @"permisos_level_detail_grid1", "dll");
      sc.Add( @"permisos_level_detail_grid1", "dll");
      sc.Add( @"permisos_level_detail", "dll");
      sc.Add( @"permisos_level_detail", "dll");
      sc.Add( @"calendariosd_level_detail_grid1", "dll");
      sc.Add( @"calendariosd_level_detail_grid1", "dll");
      sc.Add( @"materia_level_detail_grid1", "dll");
      sc.Add( @"materia_level_detail_grid1", "dll");
      sc.Add( @"pushtestmain_level_detail_grid1", "dll");
      sc.Add( @"pushtestmain_level_detail_grid1", "dll");
      sc.Add( @"pushtestmain_level_detail", "dll");
      sc.Add( @"pushtestmain_level_detail", "dll");
      sc.Add( @"anotificationsregistrationhandler", "dll");
      sc.Add( @"anotificationsregistrationhandler", "dll");
      sc.Add( @"gxaftereventreplicator", "dll");
      sc.Add( @"gxaftereventreplicator", "dll");
      sc.Add( @"gxonpendingeventfailed", "dll");
      sc.Add( @"gxonpendingeventfailed", "dll");
      sc.Add( @"procdummy", "dll");
      sc.Add( @"procdummy", "dll");
      sc.Add( @"addremovedevicefromgroup", "dll");
      sc.Add( @"addremovedevicefromgroup", "dll");
      sc.Add( @"loginuser", "dll");
      sc.Add( @"loginuser", "dll");
      sc.Add( @"getbusiness", "dll");
      sc.Add( @"getbusiness", "dll");
      sc.Add( @"getuserid", "dll");
      sc.Add( @"getuserid", "dll");
      sc.Add( @"pago", "dll");
      sc.Add( @"pago", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"homes", "dll");
      sc.Add( @"homes", "dll");
      sc.Add( @"notauthorized", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"viewdevices", "dll");
      sc.Add( @"wwdevices", "dll");
      sc.Add( @"devicesgeneral", "dll");
      sc.Add( @"devicesgroupwc", "dll");
      sc.Add( @"wwusers", "dll");
      sc.Add( @"usersgeneral", "dll");
      sc.Add( @"usersbalancewc", "dll");
      sc.Add( @"usersmonederoelectronicowc", "dll");
      sc.Add( @"userscalifaswc", "dll");
      sc.Add( @"usersdinerowc", "dll");
      sc.Add( @"usersnurserywc", "dll");
      sc.Add( @"viewusers", "dll");
      sc.Add( @"wwbalance", "dll");
      sc.Add( @"balancegeneral", "dll");
      sc.Add( @"balancehistorywc", "dll");
      sc.Add( @"viewbalance", "dll");
      sc.Add( @"wwmonederoelectronico", "dll");
      sc.Add( @"monederoelectronicogeneral", "dll");
      sc.Add( @"monederoelectronicomovimientoswc", "dll");
      sc.Add( @"viewmonederoelectronico", "dll");
      sc.Add( @"wwmaterias", "dll");
      sc.Add( @"materiasgeneral", "dll");
      sc.Add( @"materiascalifaswc", "dll");
      sc.Add( @"viewmaterias", "dll");
      sc.Add( @"wwcalifas", "dll");
      sc.Add( @"califasgeneral", "dll");
      sc.Add( @"viewcalifas", "dll");
      sc.Add( @"wwdinero", "dll");
      sc.Add( @"dinerogeneral", "dll");
      sc.Add( @"viewdinero", "dll");
      sc.Add( @"wwcalendario", "dll");
      sc.Add( @"calendariogeneral", "dll");
      sc.Add( @"calendariocalendariomeswc", "dll");
      sc.Add( @"viewcalendario", "dll");
      sc.Add( @"wwanunciostrs", "dll");
      sc.Add( @"anunciostrsgeneral", "dll");
      sc.Add( @"viewanunciostrs", "dll");
      sc.Add( @"dispositivos", "dll");
      sc.Add( @"sendnotifications", "dll");
      sc.Add( @"gx0021", "dll");
      sc.Add( @"gx0080", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx0051", "dll");
      sc.Add( @"gx0071", "dll");
      sc.Add( @"gx0090", "dll");
      sc.Add( @"gx00f1", "dll");
      sc.Add( @"viewschoolinfotrs", "dll");
      sc.Add( @"wwschoolinfotrs", "dll");
      sc.Add( @"schoolinfotrsgeneral", "dll");
      sc.Add( @"gx00a0", "dll");
      sc.Add( @"devices", "dll");
      sc.Add( @"users", "dll");
      sc.Add( @"balance", "dll");
      sc.Add( @"monederoelectronico", "dll");
      sc.Add( @"califas", "dll");
      sc.Add( @"dinero", "dll");
      sc.Add( @"nursery", "dll");
      sc.Add( @"materias", "dll");
      sc.Add( @"materias_bc", "dll");
      sc.Add( @"calendario", "dll");
      sc.Add( @"anunciostrs", "dll");
      sc.Add( @"group", "dll");
      sc.Add( @"pagos", "dll");
      sc.Add( @"schoolinfotrs", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtAnuncios_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtCalendarioSD_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtHome_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtHome_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtInfoEs_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtLogin_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMaterEsp_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMaterEsp_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMateria_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMensajes_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMensajes_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtOrganizations_Level_Detail_Grid2Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPagosCol_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPagosHist_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPermisos_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPermisos_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPushTestMain_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtPushTestMain_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchoolInfo_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtDevices.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtDevices_Group.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMaterias.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGroup.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGoogleChartType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGoogleTableFormatter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerChartType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerOutputType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerPlotSeries.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerShowDataAs.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerOrientation.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerTrendPeriod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerXAxisLabels.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAggregationType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAxisOrderType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAxisType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerConditionOperator.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerExpandCollapse.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerFilterType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerObjectType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerSubtotals.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerShowDataLabelsIn.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

