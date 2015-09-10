using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebCalendar.Models.CodeFastEntities;
using WebCalendar.Models;

namespace WebCalendar.Controllers
{
    public class TaskBasesController : Controller
    {
        private WorkingShareContext db = new WorkingShareContext();

        // GET: TaskBases
        public async Task<ActionResult> Index()
        {
            return View(await db.DateItems.ToListAsync());
        }

        // GET: TaskBases/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBase taskBase = await db.DateItems.FindAsync(id);
            if (taskBase == null)
            {
                return HttpNotFound();
            }
            return View(taskBase);
        }

        // GET: TaskBases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskBases/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserId,PublicLevel,Date,Complete,ItemKbn")] TaskBase taskBase)
        {
            if (ModelState.IsValid)
            {
                db.DateItems.Add(taskBase);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(taskBase);
        }

        // GET: TaskBases/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBase taskBase = await db.DateItems.FindAsync(id);
            if (taskBase == null)
            {
                return HttpNotFound();
            }
            return View(taskBase);
        }

        // POST: TaskBases/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,PublicLevel,Date,Complete,ItemKbn")] TaskBase taskBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskBase).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(taskBase);
        }

        // GET: TaskBases/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBase taskBase = await db.DateItems.FindAsync(id);
            if (taskBase == null)
            {
                return HttpNotFound();
            }
            return View(taskBase);
        }

        // POST: TaskBases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TaskBase taskBase = await db.DateItems.FindAsync(id);
            db.DateItems.Remove(taskBase);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
