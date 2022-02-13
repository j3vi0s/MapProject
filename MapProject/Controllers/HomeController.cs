using MapProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace MapProject.Controllers
{



    public class HomeController : Controller
    {

        private readonly Repository _repository;

        public HomeController(Repository repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {

            List<City> response = _repository.GetAllData();
            return View(response);
        
        
        }

        public JsonResult GetCitiesDetails()
        {
            List<City> response = _repository.GetAllData();
            return Json(response);
        }

        public IActionResult UpdateCityDetail()
        {

            List<City> response = _repository.GetAllData();
            return View(response);


        }

        public JsonResult GetCityDetailsById(int id)
        {

            City response = _repository.GetCityDetailsById(id);
            return Json(response);

        }

        public void SaveCityDetail(City city)
        {
            _repository.UpdateCityDetail(city);
        }

        // ŞEHİRLERİ İLK YÜKLERKEN KULLANILAN FONKSİYON 
        //public IActionResult UploadCities()
        //{

        //    List<City> cityList = new List<City>();
        //    string[] cityNameList = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        //    foreach(var cityName in cityNameList)
        //    {
        //        cityList.Add(new City()
        //        {
        //            Name = cityName,
        //            CenturyBrandProduct = 0,
        //            ProductCount = 0,
        //            GeographicalProduct = 0
        //        });
        //    }
        //    _repository.UploadCities(cityList);
        //    return View();


        //}


    }
}
