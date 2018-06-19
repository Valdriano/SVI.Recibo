using SVI.Recibo.Web.AutoMapper;
using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Repository;
using SVI.Recibo.Web.Services;
using SVI.Recibo.Web.Util;
using SVI.Recibo.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using static SVI.Recibo.Web.DataModel.ReciboDataSet;

namespace SVI.Recibo.Web.Controllers
{
    public class ReciboController : Controller
    {
        private ReciboRepository repository = new ReciboRepository( new ApplicationDbContext() );
        private EstadoRepository estadoRepository = new EstadoRepository( new ApplicationDbContext() );
        private FornecedorRepository fornecedorRepository = new FornecedorRepository( new ApplicationDbContext() );
        private MunicipioRepository municipioRepository = new MunicipioRepository( new ApplicationDbContext() );

        // GET: Recibo
        public ActionResult Index()
        {
            var recibos = AutoMapperManager.Instance.Mapper.Map<List<Models.Recibo>, List<ReciboViewModel>>( repository.GetList() );

            return View( recibos );
        }

        // GET: Recibo/Details/5
        public ActionResult Details( int id )
        {
            return View();
        }

        // GET: Recibo/Create
        public ActionResult Create()
        {
            ViewBag.IdFornecedor = new SelectList( fornecedorRepository.GetList(), "Id", "Nome" );
            ViewBag.IdEstado = new SelectList( estadoRepository.GetList(), "Id", "Descricao" );
            ViewBag.IdMunicipio = new SelectList( municipioRepository.GetList(), "Id", "Descricao" );

            return View();
        }

        // POST: Recibo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( ReciboViewModel viewModel )
        {
            try
            {
                if( !ModelState.IsValid )
                {
                    return View( viewModel );
                }

                var recibo = AutoMapperManager.Instance.Mapper.Map<ReciboViewModel, Models.Recibo>( viewModel );

                repository.Insert( recibo );

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Recibo/Edit/5
        public ActionResult Edit( int id )
        {
            return View();
        }

        // POST: Recibo/Edit/5
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

        // GET: Recibo/Delete/5
        public ActionResult Delete( int id )
        {
            return View();
        }

        // POST: Recibo/Delete/5
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

        public ActionResult Visualizar()
        {
            List<Models.Recibo> recibos = repository.GetList();

            ReciboDataTable dt = new ReciboDataTable();

            foreach( Models.Recibo rec in recibos )
            {
                ReciboRow dr = dt.NewReciboRow();

                dr.Ano = DateTime.Now.Year;
                dr.Bairro = rec.Fornecedor.Bairro;
                dr.CEP = AppUtil.MaskCEP( rec.Fornecedor.CEP );
                dr.CPNJ = AppUtil.MaskCPFCNPJ( rec.Fornecedor.CNPJ );
                dr.Extenso = AppUtil.EscreverExtenso( rec.Valor );
                dr.Fornecedor = rec.Fornecedor.Nome;
                dr.IdRecibo = rec.Id;
                dr.Logo = rec.Fornecedor.Logo;
                dr.Logradouro = rec.Fornecedor.Logradouro;
                dr.Municipio = rec.Municipio.Descricao;
                dr.Referente = rec.Referencia;
                dr.Valor = rec.Valor;

                dt.AddReciboRow( dr );
            }

            return File( ReciboService.GetPDF_Recibo( "ReciboReport.rdlc", "dsRecibo", dt.ToList() ), "application/pdf" );
        }

        //public ActionResult Visualizar()
        //{

        //    List<Models.Recibo> recibos = repository.GetList();

        //    ReciboDataTable dt = new ReciboDataTable();

        //    foreach( Models.Recibo rec in recibos )
        //    {
        //        ReciboRow dr = dt.NewReciboRow();

        //        dr.Ano = DateTime.Now.Year;
        //        dr.Bairro = rec.Fornecedor.Bairro;
        //        dr.CEP = rec.Fornecedor.CEP;
        //        dr.CPNJ = rec.Fornecedor.CNPJ;
        //        dr.Extenso = AppUtil.EscreverExtenso( rec.Valor );
        //        dr.Fornecedor = rec.Fornecedor.Nome;
        //        dr.IdRecibo = rec.Id;
        //        dr.Logo = rec.Fornecedor.Logo;
        //        dr.Logradouro = rec.Fornecedor.Logradouro;
        //        dr.Municipio = rec.Municipio.Descricao;
        //        dr.Referente = rec.Referencia;
        //        dr.Valor = rec.Valor;

        //        dt.AddReciboRow( dr );
        //    }

        //    Microsoft.Reporting.WebForms.LocalReport report = new Microsoft.Reporting.WebForms.LocalReport();
        //    report.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath( "~/Reports/" + "ReciboReport.rdlc" );
        //    report.DataSources.Add( new Microsoft.Reporting.WebForms.ReportDataSource( "dsRecibo", dt.ToList() ) );

        //    //if( parameters != null )
        //    //{
        //    //    report.SetParameters( parameters );
        //    //}

        //    report.Refresh();

        //    string mimeType = "";
        //    string encoding = "";
        //    string filenameExtension = "";
        //    string[] streams = null;
        //    Microsoft.Reporting.WebForms.Warning[] warnings = null;
        //    byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

        //    return File( bytes, mimeType );
        //}
    }
}
