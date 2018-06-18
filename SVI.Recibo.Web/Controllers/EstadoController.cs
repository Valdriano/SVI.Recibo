using SVI.Recibo.Web.AutoMapper;
using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Models;
using SVI.Recibo.Web.Repository;
using SVI.Recibo.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVI.Recibo.Web.Controllers
{
    public class EstadoController : Controller
    {
        private EstadoRepository repository = new EstadoRepository( new ApplicationDbContext() );

        // GET: Estado
        public ActionResult Index()
        {
            var estados = AutoMapperManager.Instance.Mapper.Map<List<Estado>, List<EstadoViewModel>>( repository.GetList() );

            return View( estados );
        }

        // GET: Estado/Details/5
        public ActionResult Details( int id )
        {
            return View();
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado/Create
        [HttpPost]
        public ActionResult Create( FormCollection collection )
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado/Edit/5
        public ActionResult Edit( int id )
        {
            return View();
        }

        // POST: Estado/Edit/5
        [HttpPost]
        public ActionResult Edit( int id, FormCollection collection )
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado/Delete/5
        public ActionResult Delete( int id )
        {
            return View();
        }

        // POST: Estado/Delete/5
        [HttpPost]
        public ActionResult Delete( int id, FormCollection collection )
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }
    }
}
