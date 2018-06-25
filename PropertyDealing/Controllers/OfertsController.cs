using Microsoft.AspNet.Identity;
using PropertyDealing.DataAccess.Models;
using PropertyDealing.Models;
using PropertyDealing.Repository.Interfaces;
using PropertyDealing.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyDealing.Controllers
{
    public class OfertsController : Controller
    {
        private IRepositoryManager repositoryManager = new RepositoryManager();

        // GET: Oferts
        public ActionResult Index()
        {
            var model = new List<PropertyContainer>();
            var propertyAll = repositoryManager.PropertyRepository.GetAll().ToList();
            var property = propertyAll.Where(x => x.IsSold == false).ToList();

            foreach (var item in property)
            {
                Property prop = new Property();
                prop.City = item.City;
                prop.Description = item.Description;
                prop.Id = item.Id;
                prop.Image = item.Image;
                prop.IsBalcony = item.IsBalcony;
                prop.Price = item.Price;
                prop.PropertyArea = item.PropertyArea;
                prop.RoomsNumber = item.RoomsNumber;
                prop.Storey = item.Storey;
                prop.Street = item.Street;
                prop.Title = item.Title;
                prop.UserId = item.UserId;
                prop.IsSold = item.IsSold;

                var container = new PropertyContainer() { Property = item };
                model.Add(container);
            }

            return View(model);
        }
    }
}