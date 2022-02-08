using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using petVet.Models;
using Microsoft.AspNetCore.Http;

namespace petVet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {   
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente(Cliente cliente)
        {   
            ClienteRepository cr = new ClienteRepository();
            cr.Inserir(cliente);
            ViewBag.Mensagem = "Cadastro Efetuado com Sucesso!";
            return View();
        }
        public IActionResult ListaClientes(Cliente cliente)
        {   
             if(HttpContext.Session.GetInt32("id")== null)
            return View("LoginCliente");
            ClienteRepository cr = new ClienteRepository();
            List<Cliente> lista = cr.ListaClientes(cliente);
            return View(lista);
        }
        public IActionResult ExcluirCliente(Cliente cliente)
        {   
             if(HttpContext.Session.GetInt32("id")== null)
            return View("LoginCliente");
            ClienteRepository cr = new ClienteRepository();
            cr.Excluir(cliente);
            return RedirectToAction("ListaClientes");
        }
        public IActionResult AtualizarCliente(int id)
        {   
             if(HttpContext.Session.GetInt32("id")== null)
            return View("LoginCliente");
            ClienteRepository cr = new ClienteRepository();
            Cliente cliente = cr.BuscarId(id);
            return View(cliente);
        }
        [HttpPost]
        public IActionResult AtualizarCliente(Cliente cliente)
        {   
            if(HttpContext.Session.GetInt32("id")== null)
            return View("LoginCliente");
            ClienteRepository cr = new ClienteRepository();
            cr.Atualizar(cliente);
            return RedirectToAction("ListaClientes");
        }
        public IActionResult LoginCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginCliente(Cliente cliente){
            ClienteRepository cr = new ClienteRepository();
            Cliente clienteSessao  = cr.ValidarCliente(cliente);
            if(clienteSessao !=null)
            {   
                HttpContext.Session.SetInt32("id", clienteSessao.id);
                HttpContext.Session.SetString("nome", clienteSessao.nome);
                return RedirectToAction("ListaClientes");
            }
            else{
            ViewBag.Mensagem = "Erro no login !" ;
            return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("LoginCliente");
        }
    }
}