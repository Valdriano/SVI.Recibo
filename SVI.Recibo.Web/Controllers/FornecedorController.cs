﻿using SVI.Recibo.Web.AutoMapper;
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
    public class FornecedorController : Controller
    {
        private FornecedorRepository repository = new FornecedorRepository( new ApplicationDbContext() );
        private EstadoRepository estadoRepository = new EstadoRepository( new ApplicationDbContext() );
        private MunicipioRepository municipioRepository = new MunicipioRepository( new ApplicationDbContext() );

        // GET: Fornecedor
        public ActionResult Index()
        {
            var fornecedores = AutoMapperManager.Instance.Mapper.Map<List<Fornecedor>, List<FornecedorViewModel>>( repository.GetList() );

            return View( fornecedores );
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details( int id )
        {
            return View();
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            ViewBag.IdEstado = new SelectList( estadoRepository.GetList(), "Id", "Descricao" );
            ViewBag.IdMunicipio = new SelectList( municipioRepository.GetList(), "Id", "Descricao" );

            return View();
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( FornecedorViewModel viewModel , HttpPostedFileBase file )
        {
            try
            {
                if( !ModelState.IsValid )
                {
                    return View( viewModel );
                }

                if( file != null )
                {
                    String[] strName = file.FileName.Split( '.' );
                    String strExt = strName[ strName.Count() - 1 ];
                    string pathSave = String.Format( "{0}{1}.{2}", Server.MapPath( "~/Imagens/" ), viewModel.Id, strExt );
                    String pathBase = String.Format( "/Imagens/{0}.{1}", viewModel.Id, strExt );
                    file.SaveAs( pathSave );
                    //viewModel.Logo = pathBase;
                }

                var fornecedor = AutoMapperManager.Instance.Mapper.Map<FornecedorViewModel, Fornecedor>( viewModel );

                repository.Insert( fornecedor );

                return RedirectToAction( "Index" );
            }
            catch
            {
                return HttpNotFound( "Erro ao criar Fornecedor" );
            }
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit( int id )
        {
            ViewBag.IdEstado = new SelectList( estadoRepository.GetList(), "Id", "Descricao" );
            ViewBag.IdMunicipio = new SelectList( municipioRepository.GetList(), "Id", "Descricao" );

            var fornecedor = AutoMapperManager.Instance.Mapper.Map<Fornecedor, FornecedorViewModel>( repository.Get( id ) );

            return View( fornecedor );
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        public ActionResult Edit( int id, FornecedorViewModel viewModel )
        {
            try
            {
                if( !ModelState.IsValid )
                {
                    return View( viewModel );
                }

                var fornecedor = AutoMapperManager.Instance.Mapper.Map<FornecedorViewModel, Fornecedor>( viewModel );

                repository.Update( fornecedor );

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete( int id )
        {
            return View();
        }

        // POST: Fornecedor/Delete/5
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
