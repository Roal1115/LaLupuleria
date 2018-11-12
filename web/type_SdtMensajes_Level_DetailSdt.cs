/*
               File: type_SdtMensajes_Level_DetailSdt
        Description: Mensajes_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/12/2018 13:11:49.34
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
   [XmlRoot(ElementName = "Mensajes_Level_DetailSdt" )]
   [XmlType(TypeName =  "Mensajes_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtMensajes_Level_DetailSdt : GxUserType
   {
      public SdtMensajes_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtMensajes_Level_DetailSdt_Destination = "";
         gxTv_SdtMensajes_Level_DetailSdt_Subject = "";
      }

      public SdtMensajes_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Destination", gxTv_SdtMensajes_Level_DetailSdt_Destination, false);
         AddObjectProperty("Subject", gxTv_SdtMensajes_Level_DetailSdt_Subject, false);
         return  ;
      }

      [  SoapElement( ElementName = "Destination" )]
      [  XmlElement( ElementName = "Destination"   )]
      public String gxTpr_Destination
      {
         get {
            return gxTv_SdtMensajes_Level_DetailSdt_Destination ;
         }

         set {
            gxTv_SdtMensajes_Level_DetailSdt_Destination = value;
            SetDirty("Destination");
         }

      }

      [  SoapElement( ElementName = "Subject" )]
      [  XmlElement( ElementName = "Subject"   )]
      public String gxTpr_Subject
      {
         get {
            return gxTv_SdtMensajes_Level_DetailSdt_Subject ;
         }

         set {
            gxTv_SdtMensajes_Level_DetailSdt_Subject = value;
            SetDirty("Subject");
         }

      }

      public void initialize( )
      {
         gxTv_SdtMensajes_Level_DetailSdt_Destination = "";
         gxTv_SdtMensajes_Level_DetailSdt_Subject = "";
         return  ;
      }

      protected String gxTv_SdtMensajes_Level_DetailSdt_Destination ;
      protected String gxTv_SdtMensajes_Level_DetailSdt_Subject ;
   }

   [DataContract(Name = @"Mensajes_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtMensajes_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtMensajes_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMensajes_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtMensajes_Level_DetailSdt_RESTInterface( SdtMensajes_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Destination" , Order = 0 )]
      public String gxTpr_Destination
      {
         get {
            return sdt.gxTpr_Destination ;
         }

         set {
            sdt.gxTpr_Destination = value;
         }

      }

      [DataMember( Name = "Subject" , Order = 1 )]
      public String gxTpr_Subject
      {
         get {
            return sdt.gxTpr_Subject ;
         }

         set {
            sdt.gxTpr_Subject = value;
         }

      }

      public SdtMensajes_Level_DetailSdt sdt
      {
         get {
            return (SdtMensajes_Level_DetailSdt)Sdt ;
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
            sdt = new SdtMensajes_Level_DetailSdt() ;
         }
      }

   }

}
