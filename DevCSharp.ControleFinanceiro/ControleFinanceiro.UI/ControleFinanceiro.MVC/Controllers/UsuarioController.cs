using AutoMapper;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Interfaces;
using ControleFinanceiro.Infrastrucure.Data.Repositories;
using ControleFinanceiro.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();
        
        public ActionResult Index()
        {
            var usuarios = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepository.ObterTodos());
            return View(usuarios);
        }

        public ActionResult Details(int id)
        {
            var usuario = Mapper.Map<Usuario, UsuarioViewModel>(_usuarioRepository.ObterPorId(id));
            return View(usuario);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UsuarioViewModel usuarioViewModel)
        {
            try
            {
                Usuario usuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
                _usuarioRepository.Adicionar(usuario);

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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
