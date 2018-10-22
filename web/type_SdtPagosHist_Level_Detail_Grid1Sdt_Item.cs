/*
               File: type_SdtPagosHist_Level_Detail_Grid1Sdt_Item
        Description: PagosHist_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/11/2018 18:53:14.32
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Item" )]
   [XmlType(TypeName =  "Item" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtPagosHist_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtPagosHist_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
      }

      public SdtPagosHist_Level_Detail_Grid1Sdt_Item( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("DineroId", gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroid, false);
         AddObjectProperty("DineroTotal", gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal, false);
         AddObjectProperty("DineroBalance", gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance, false);
         AddObjectProperty("DineroAbono", gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono, false);
         AddObjectProperty("DineroNuevo", gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo, false);
         return  ;
      }

      [  SoapElement( ElementName = "DineroId" )]
      [  XmlElement( ElementName = "DineroId"   )]
      public short gxTpr_Dineroid
      {
         get {
            return gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroid ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroid = value;
            SetDirty("Dineroid");
         }

      }

      [  SoapElement( ElementName = "DineroTotal" )]
      [  XmlElement( ElementName = "DineroTotal"   )]
      public double gxTpr_Dinerototal_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal) ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Dinerototal
      {
         get {
            return gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal = value;
            SetDirty("Dinerototal");
         }

      }

      [  SoapElement( ElementName = "DineroBalance" )]
      [  XmlElement( ElementName = "DineroBalance"   )]
      public double gxTpr_Dinerobalance_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance) ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Dinerobalance
      {
         get {
            return gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance = value;
            SetDirty("Dinerobalance");
         }

      }

      [  SoapElement( ElementName = "DineroAbono" )]
      [  XmlElement( ElementName = "DineroAbono"   )]
      public double gxTpr_Dineroabono_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono) ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Dineroabono
      {
         get {
            return gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono = value;
            SetDirty("Dineroabono");
         }

      }

      [  SoapElement( ElementName = "DineroNuevo" )]
      [  XmlElement( ElementName = "DineroNuevo"   )]
      public double gxTpr_Dineronuevo_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo) ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Dineronuevo
      {
         get {
            return gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo ;
         }

         set {
            gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo = value;
            SetDirty("Dineronuevo");
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected short gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroid ;
      protected decimal gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerototal ;
      protected decimal gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dinerobalance ;
      protected decimal gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineroabono ;
      protected decimal gxTv_SdtPagosHist_Level_Detail_Grid1Sdt_Item_Dineronuevo ;
   }

   [DataContract(Name = @"PagosHist_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtPagosHist_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtPagosHist_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtPagosHist_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "DineroId" , Order = 0 )]
      public Nullable<short> gxTpr_Dineroid
      {
         get {
            return sdt.gxTpr_Dineroid ;
         }

         set {
            sdt.gxTpr_Dineroid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DineroTotal" , Order = 1 )]
      public String gxTpr_Dinerototal
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Dinerototal, 9, 2)) ;
         }

         set {
            sdt.gxTpr_Dinerototal = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "DineroBalance" , Order = 2 )]
      public String gxTpr_Dinerobalance
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Dinerobalance, 9, 2)) ;
         }

         set {
            sdt.gxTpr_Dinerobalance = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "DineroAbono" , Order = 3 )]
      public String gxTpr_Dineroabono
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Dineroabono, 9, 2)) ;
         }

         set {
            sdt.gxTpr_Dineroabono = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "DineroNuevo" , Order = 4 )]
      public String gxTpr_Dineronuevo
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Dineronuevo, 9, 2)) ;
         }

         set {
            sdt.gxTpr_Dineronuevo = NumberUtil.Val( value, ".");
         }

      }

      public SdtPagosHist_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtPagosHist_Level_Detail_Grid1Sdt_Item)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtPagosHist_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
