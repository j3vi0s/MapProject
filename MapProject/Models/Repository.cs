using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace MapProject.Models
{
    public class Repository
    {
        public List<City> GetAllData()
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<City>("select * from city_details").ToList();
            }
        }

        public void UploadCities(List<City> cityList)
        {
            using (var db = new DbContext().GetConnection())
            {
                foreach(var i in cityList)
                 db.Execute("insert into city_details (Name,ProductCount,GeographicalProduct,CenturyBrandProduct) Values (@Name,@ProductCount,@GeographicalProduct,@CenturyBrandProduct)", i);
            }
        }

        public City GetCityDetailsById(int id)
        {
            using (var db = new DbContext().GetConnection())
            {
               return db.Query<City>("select * from city_details where Id = @id", new { id }).FirstOrDefault();
            }
        }

        public void UpdateCityDetail(City city)
        {
            using (var db = new DbContext().GetConnection())
            {
                db.Execute("Update city_details set ProductCount=@ProductCount,GeographicalProduct=@GeographicalProduct,CenturyBrandProduct=@CenturyBrandProduct where Id=@Id", city);
            }
        }
    }
}
