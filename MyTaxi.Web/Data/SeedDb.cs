using MyTaxi.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace MyTaxi.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await ChecktaxisAsync();
        }

        private async Task ChecktaxisAsync()
        {
            if (!_dataContext.Taxis.Any())
            {


                _dataContext.Taxis.Add(new TaxiEntity
                {
                    Plaque = "A234567",
                    Trips = new List<TripEntity>
                    {
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(30),
                            Qualification=4.5f,
                            Source="Tiradente",
                            Target="Ricardo Mejia",
                            Remarks="Exelente servicio."
                        },
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(30),
                            Qualification=3.5f,
                            Source="Ricardo Mejia",
                            Target="Tiradente",
                            Remarks="Servicio Regular."
                        }
                    }
                });

                _dataContext.Taxis.Add(new TaxiEntity
                {
                    Plaque = "A904567",
                    Trips = new List<TripEntity>
                    {
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(60),
                            Qualification=3.3f,
                            Source="Alcarizos",
                            Target="Gazcue",
                            Remarks="Servicio Regular."
                        },
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(120),
                            Qualification=2.5f,
                            Source="Gazcue",
                            Target="Alcarizos",
                            Remarks="Servicio Regular."
                        }
                    }
                });

                _dataContext.Taxis.Add(new TaxiEntity
                {
                    Plaque = "A678912",
                    Trips = new List<TripEntity>
                    {
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(60),
                            Qualification=1.5f,
                            Source="Duarte",
                            Target="Ovando",
                            Remarks="Servicio de muy mala calidad."
                        },
                        new TripEntity
                        {
                            StarDate=DateTime.UtcNow,
                            EndDate=DateTime.UtcNow.AddMinutes(20),
                            Qualification=5.5f,
                            Source="Sambil",
                            Target="Piantini",
                            Remarks="Un servicio Exepcional."
                        }
                    }
                });
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
