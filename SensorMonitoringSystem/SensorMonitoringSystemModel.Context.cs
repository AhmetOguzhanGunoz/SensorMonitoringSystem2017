﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensorMonitoringSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SensorMonitoringSystemEntities : DbContext
    {
        public SensorMonitoringSystemEntities()
            : base("name=SensorMonitoringSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CompaniesEntity> Companies { get; set; }
        public virtual DbSet<SensorsEntity> Sensors { get; set; }
        public virtual DbSet<SensorsDatasEntity> SensorsDatas { get; set; }
        public virtual DbSet<UsersEntity> Users { get; set; }
        public virtual DbSet<UsersDetailsEntity> UsersDetails { get; set; }
    
        [DbFunction("SensorMonitoringSystemEntities", "DatasBetweenDates")]
        public virtual IQueryable<DatasBetweenDates_Result> DatasBetweenDates(Nullable<int> sensorID, Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var sensorIDParameter = sensorID.HasValue ?
                new ObjectParameter("SensorID", sensorID) :
                new ObjectParameter("SensorID", typeof(int));
    
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("Date1", date1) :
                new ObjectParameter("Date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("Date2", date2) :
                new ObjectParameter("Date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DatasBetweenDates_Result>("[SensorMonitoringSystemEntities].[DatasBetweenDates](@SensorID, @Date1, @Date2)", sensorIDParameter, date1Parameter, date2Parameter);
        }
    
        public virtual int DataRegistration(Nullable<decimal> okunanDeger, Nullable<System.DateTime> okunanDegerZamani, Nullable<int> sensorID)
        {
            var okunanDegerParameter = okunanDeger.HasValue ?
                new ObjectParameter("OkunanDeger", okunanDeger) :
                new ObjectParameter("OkunanDeger", typeof(decimal));
    
            var okunanDegerZamaniParameter = okunanDegerZamani.HasValue ?
                new ObjectParameter("OkunanDegerZamani", okunanDegerZamani) :
                new ObjectParameter("OkunanDegerZamani", typeof(System.DateTime));
    
            var sensorIDParameter = sensorID.HasValue ?
                new ObjectParameter("SensorID", sensorID) :
                new ObjectParameter("SensorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DataRegistration", okunanDegerParameter, okunanDegerZamaniParameter, sensorIDParameter);
        }
    
        public virtual int SensorRegistration(Nullable<int> kurumID, string sensorTipi, string sensorAdresi, Nullable<int> kucukGrafikDegeri, Nullable<int> buyukGrafikDegeri, Nullable<decimal> kucukKritikDegeri, Nullable<decimal> buyukKritikDegeri, string sensorBirimi)
        {
            var kurumIDParameter = kurumID.HasValue ?
                new ObjectParameter("KurumID", kurumID) :
                new ObjectParameter("KurumID", typeof(int));
    
            var sensorTipiParameter = sensorTipi != null ?
                new ObjectParameter("SensorTipi", sensorTipi) :
                new ObjectParameter("SensorTipi", typeof(string));
    
            var sensorAdresiParameter = sensorAdresi != null ?
                new ObjectParameter("SensorAdresi", sensorAdresi) :
                new ObjectParameter("SensorAdresi", typeof(string));
    
            var kucukGrafikDegeriParameter = kucukGrafikDegeri.HasValue ?
                new ObjectParameter("KucukGrafikDegeri", kucukGrafikDegeri) :
                new ObjectParameter("KucukGrafikDegeri", typeof(int));
    
            var buyukGrafikDegeriParameter = buyukGrafikDegeri.HasValue ?
                new ObjectParameter("BuyukGrafikDegeri", buyukGrafikDegeri) :
                new ObjectParameter("BuyukGrafikDegeri", typeof(int));
    
            var kucukKritikDegeriParameter = kucukKritikDegeri.HasValue ?
                new ObjectParameter("KucukKritikDegeri", kucukKritikDegeri) :
                new ObjectParameter("KucukKritikDegeri", typeof(decimal));
    
            var buyukKritikDegeriParameter = buyukKritikDegeri.HasValue ?
                new ObjectParameter("BuyukKritikDegeri", buyukKritikDegeri) :
                new ObjectParameter("BuyukKritikDegeri", typeof(decimal));
    
            var sensorBirimiParameter = sensorBirimi != null ?
                new ObjectParameter("SensorBirimi", sensorBirimi) :
                new ObjectParameter("SensorBirimi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SensorRegistration", kurumIDParameter, sensorTipiParameter, sensorAdresiParameter, kucukGrafikDegeriParameter, buyukGrafikDegeriParameter, kucukKritikDegeriParameter, buyukKritikDegeriParameter, sensorBirimiParameter);
        }
    }
}
