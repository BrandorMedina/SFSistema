using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminLTE.Data;
using AdminLTE.Models;

namespace AdminLTE.Controllers
{
    public class DocsController : BaseController
    {

        private readonly ApplicationDbContext _context;

        public DocsController(ApplicationDbContext context)
        {
            
            _context = context;
        }

        // GET: Docs
        public async Task<IActionResult> Index()
        {
            AddBreadcrumb("Lista de Documentos", "");
            return View(await _context.AspNetUserDocuments.ToListAsync());
        }

        // GET: Docs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            AddBreadcrumb("Lista de Documentos", "/Docs/Index");
            AddBreadcrumb("Detalles", "");
            ViewBag.ClarderSousSecteurID = (from p in _context.AspNetUsers
                                            join f in _context.AspNetUsers
                                            on p.Id equals f.Id
                                            select new SelectListItem
                                            {
                                                Value = p.Id,
                                                Text = f.FirstName + " " + f.LastName + "(" + f.Email + ")"
                                            }).Distinct();
            if (id == null)
            {
                return NotFound();
            }

            var docs = await _context.AspNetUserDocuments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docs == null)
            {
                return NotFound();
            }

            return View(docs);
        }

        // GET: Docs/Create
        public IActionResult Create()
        {
            AddBreadcrumb("Lista de Documentos", "/Docs/Index");
            AddBreadcrumb("Crear Documento", "");
            //List<ApplicationUser> stateList = new List<ApplicationUser>();

            //stateList = (from produc in _context.AspNetUsers
            //             select produc).ToList();
            //stateList.Insert(0, new ApplicationUser { Id = "", LastName = "", FirstName= ""});

            //ViewBag.stateList1 = stateList;


            ViewBag.ClarderSousSecteurID = (from p in _context.AspNetUsers
                                            join f in _context.AspNetUsers
                                            on p.Id equals f.Id
                                            select new SelectListItem
                                            {
                                                Value = p.Id,
                                                Text = f.FirstName + " " + f.LastName + "(" +f.Email +")"
                                            }).Distinct();

            return View();
        }

    // POST: Docs/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_Usuario,Tipo_documento,Asunto,Via,Anexo,Descripcion,Fecha_Creado,Fecha_Limite")] Docs docs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(docs);
        }
      

        // GET: Docs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            AddBreadcrumb("Lista de Documentos", "/Docs/Index");
            AddBreadcrumb("Editar", "");
            ViewBag.ClarderSousSecteurID = (from p in _context.AspNetUsers
                                            join f in _context.AspNetUsers
                                            on p.Id equals f.Id
                                            select new SelectListItem
                                            {
                                                Value = p.Id,
                                                Text = f.FirstName + " " + f.LastName + "(" + f.Email + ")"
                                            }).Distinct();

            if (id == null)
            {
                return NotFound();
            }

            var docs = await _context.AspNetUserDocuments.FindAsync(id);
            if (docs == null)
            {
                return NotFound();
            }
            return View(docs);
        }

        // POST: Docs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_Usuario,Tipo_documento,Asunto,Via,Anexo,Descripcion,Fecha_Creado,Fecha_Limite")] Docs docs)
        {
            if (id != docs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocsExists(docs.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(docs);
        }

        // GET: Docs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            AddBreadcrumb("Lista de Documentos", "/Docs/Index");
            AddBreadcrumb("Eliminar", "");
            ViewBag.ClarderSousSecteurID = (from p in _context.AspNetUsers
                                            join f in _context.AspNetUsers
                                            on p.Id equals f.Id
                                            select new SelectListItem
                                            {
                                                Value = p.Id,
                                                Text = f.FirstName + " " + f.LastName + "(" + f.Email + ")"
                                            }).Distinct();
            if (id == null)
            {
                return NotFound();
            }

            var docs = await _context.AspNetUserDocuments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docs == null)
            {
                return NotFound();
            }

            return View(docs);
        }

        // POST: Docs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var docs = await _context.AspNetUserDocuments.FindAsync(id);
            _context.AspNetUserDocuments.Remove(docs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocsExists(int id)
        {
            return _context.AspNetUserDocuments.Any(e => e.Id == id);
        }
    }
}
