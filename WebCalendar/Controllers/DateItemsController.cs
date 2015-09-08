using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebCalendar.Models;

namespace WebCalendar.Controllers
{
    public class DateItemsController : Controller
    {
        private WorkingShareContext db = new WorkingShareContext();

        // GET: DateItems
        public async Task<ActionResult> Index()
        {
            return View(await db.DateItems.ToListAsync());
        }

        // GET: DateItems/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateItem dateItem = await db.DateItems.FindAsync(id);
            if (dateItem == null)
            {
                return HttpNotFound();
            }
            return View(dateItem);
        }

        // GET: DateItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DateItems/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserId,Date,Complete,ItemKbn")] DateItem dateItem)
        {
            if (ModelState.IsValid)
            {
                db.DateItems.Add(dateItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dateItem);
        }

        // GET: DateItems/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateItem dateItem = await db.DateItems.FindAsync(id);
            if (dateItem == null)
            {
                return HttpNotFound();
            }
            return View(dateItem);
        }

        // POST: DateItems/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,Date,Complete,ItemKbn")] DateItem dateItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dateItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dateItem);
        }

        // GET: DateItems/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateItem dateItem = await db.DateItems.FindAsync(id);
            if (dateItem == null)
            {
                return HttpNotFound();
            }
            return View(dateItem);
        }

        // POST: DateItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DateItem dateItem = await db.DateItems.FindAsync(id);
            db.DateItems.Remove(dateItem);
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
