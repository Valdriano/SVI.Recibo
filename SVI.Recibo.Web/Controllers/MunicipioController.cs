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
    public class MunicipioController : Controller
    {
        private MunicipioRepository repository = new MunicipioRepository( new ApplicationDbContext() );
        private EstadoRepository estadoRepository = new EstadoRepository( new ApplicationDbContext() );

        // GET: Municipio
        public ActionResult Index()
        {
            List<MunicipioViewModel> viewModels = AutoMapperManager.Instance.Mapper.Map<List<Municipio>, List<MunicipioViewModel>>( repository.GetList() );

            return View( viewModels );
        }

        // GET: Municipio/Details/5
        public ActionResult Details( int id )
        {
            return View();
        }

        // GET: Municipio/Create
        public ActionResult Create()
        {
            ViewBag.IdEstado = new SelectList( estadoRepository.GetList(), "Id", "Descricao" );

            return View();
        }

        // POST: Municipio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MunicipioViewModel viewModel )
        {
            try
            {
                // TODO: Add insert logic here
                if( !ModelState.IsValid )
                {
                    return View( viewModel );
                }

                Municipio municipio = AutoMapperManager.Instance.Mapper.Map<MunicipioViewModel, Municipio>( viewModel );

                repository.Insert( municipio );

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Municipio/Edit/5
        public ActionResult Edit( int id )
        {
            ViewBag.IdEstado = new SelectList( estadoRepository.GetList(), "Id", "Descricao" );

            MunicipioViewModel viewModel = AutoMapperManager.Instance.Mapper.Map<Municipio, MunicipioViewModel>( repository.Get( id ) );

            return View( viewModel );
        }

        // POST: Municipio/Edit/5
        [HttpPost]
        public ActionResult Edit( int id, MunicipioViewModel viewModel )
        {
            try
            {
                // TODO: Add update logic here
                if( !ModelState.IsValid )
                {
                    return View( viewModel );
                }

                Municipio municipio = AutoMapperManager.Instance.Mapper.Map<MunicipioViewModel, Municipio>( viewModel );

                repository.Update( municipio );

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Municipio/Delete/5
        public ActionResult Delete( int id )
        {
            return View();
        }

        // POST: Municipio/Delete/5
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
