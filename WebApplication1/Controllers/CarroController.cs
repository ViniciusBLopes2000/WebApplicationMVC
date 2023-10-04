using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarroController : Controller
    {
        // GET: Carro
        public ActionResult Index()
        {
            return View(CarroModel.CriarLista());
        }

        // GET: Carro/Details/5
        public ActionResult Details(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);


        }

        // GET: Carro/Create
        public ActionResult Create()
        {
            var carro = CarroModel.CriarCarro();
            return View();
        }

        // POST: Carro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Edit/5
        public ActionResult Edit(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
        }

        // POST: Carro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Delete/5
        public ActionResult Delete(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
        }

        // POST: Carro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}