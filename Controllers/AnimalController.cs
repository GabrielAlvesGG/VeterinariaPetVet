using System.Collections.Generic;
using petVet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using petVet.Controllers;

namespace petVet.Controllers
{
    public class AnimalController : Controller
    {
    
        public IActionResult Cadastro(){
            if(HttpContext.Session.GetInt32("id")==null)
            return RedirectToAction("LoginCliente", "Cliente");
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Animal pet)
        {   
            AnimalRepository ar = new AnimalRepository();
            ar.Inserir(pet);
            return View("Concluido");
        }
        public IActionResult Lista(Animal pet)
        {   
            if(HttpContext.Session.GetInt32("id")==null)
            return RedirectToAction("LoginCliente", "Cliente");
            AnimalRepository ar = new AnimalRepository();
           List<Animal> animal = ar.Lista();
            return View(animal);
        }
        public IActionResult Excluir(Animal pet)
        {   
            AnimalRepository ar = new AnimalRepository();
            ar.Excluir(pet);  
            return RedirectToAction("Lista");
        }
        public IActionResult Atualizar(int idPet)
        {
            AnimalRepository ar = new AnimalRepository();
            Animal pet = ar.BuscarId(idPet);
            return View(pet);
        }
        [HttpPost]
        public IActionResult Atualizar(Animal pet )
        {
            AnimalRepository ar = new AnimalRepository();
            ar.Atualizar(pet);
            return RedirectToAction("Lista");
        }
    }
}