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
    public class EditController : Controller
    {
        private IRepositoryManager repositoryManager = new RepositoryManager();

        // GET: Edit
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            var model = new List<PropertyContainer>();
            var propertyAll = repositoryManager.PropertyRepository.GetAll().ToList();
            var property = propertyAll.Where(x => x.UserId == user).ToList();

            foreach(var item in property)
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

                var container = new PropertyContainer() { Property = item };
                model.Add(container);
            }

            return View(model);
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "Image")]Property property, HttpPostedFileBase image)
        {
            var user = User.Identity.GetUserId();

            ModelState["property.Image"].Errors.Clear();
            ModelState["property.UserId"].Errors.Clear();
            if (ModelState.IsValid && image != null)
            {
                property.IsSold = false;
                property.UserId = user;
                property.Image = new byte[image.ContentLength];
                image.InputStream.Read(property.Image, 0, image.ContentLength);

                repositoryManager.PropertyRepository.Add(property);
                repositoryManager.PropertyRepository.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            repositoryManager.PropertyRepository.Remove(id);
            repositoryManager.PropertyRepository.Save();
            return RedirectToAction("Index");
        }
    }
}