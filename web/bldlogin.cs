using System;
using GeneXus.Builder;
using System.IO;
public class bldlogin : GxBaseBuilder
{
   string cs_path = "." ;
   public bldlogin( ) : base()
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
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldlogin x = new bldlogin() ;
      x.SetMainSourceFile( "login.cs");
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
      sc.Add( @"login", "dll");
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

