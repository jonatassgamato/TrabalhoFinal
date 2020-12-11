using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabalhoFinalMVCCRUD.Models;

namespace TrabalhoFinalMVCCRUD.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioContext _context;

        public FuncionariosController(FuncionarioContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }

  

        // GET: Funcionarios/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new Funcionario());
            else
                return View(_context.Funcionarios.Find(id));
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("IdFuncionario,NomeCompleto,NomeLogin,Cargo,Localizacao")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                if(funcionario.IdFuncionario ==0)
                _context.Add(funcionario);
                else
                    _context.Update(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }



        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {


            var funcionario = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
