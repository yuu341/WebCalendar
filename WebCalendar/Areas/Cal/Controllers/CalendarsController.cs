using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebCalendar.Areas.Cal.Models;
using WebCalendar.Models;

namespace WebCalendar.Areas.Cal.Controllers
{
    public class CalendarsController : Controller
    {
        private WorkingShareContext db = new WorkingShareContext();

        // GET: Cal/Calendars
        public async Task<ActionResult> Index()
        {
            return PartialView(await db.CalendarBases.ToListAsync());
        }


        public CalendarResponse Get([ModelBinder] CalendarListRequest model)
        {
            model = model ?? new CalendarListRequest();
            var repository = new ExampleDataRepository();
            return repository.GetCalendarList(model);
        }

        public Calendar Get(int id)
        {
            var repository = new ExampleDataRepository();
            var Calendar = repository.ReadCalendar(id);
            if (Calendar == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return Calendar;
        }

        public void Post(Calendar Calendar)
        {
            var repository = new ExampleDataRepository();
            repository.CreateCalendar(Calendar);
        }

        public void Put(Calendar Calendar)
        {
            var repository = new ExampleDataRepository();
            repository.UpdateCalendar(Calendar);
        }

        public void Delete(int id)
        {
            var repository = new ExampleDataRepository();
            repository.DeleteCalendar(id);
        }




        // GET: Cal/Calendars/List
        public async Task<ActionResult> List()
        {
            return PartialView(await db.CalendarBases.ToListAsync());
        }

        // GET: Cal/Calendars/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarBase calendarBase = await db.CalendarBases.FindAsync(id);
            if (calendarBase == null)
            {
                return HttpNotFound();
            }
            return View(calendarBase);
        }

        // GET: Cal/Calendars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cal/Calendars/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,EndFlg,TempFlg,DeleteFlg,PublicLevel,Title,CreateDate")] CalendarBase calendarBase)
        {
            if (ModelState.IsValid)
            {
                db.CalendarBases.Add(calendarBase);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(calendarBase);
        }

        // GET: Cal/Calendars/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarBase calendarBase = await db.CalendarBases.FindAsync(id);
            if (calendarBase == null)
            {
                return HttpNotFound();
            }
            return View(calendarBase);
        }

        // POST: Cal/Calendars/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,EndFlg,TempFlg,DeleteFlg,PublicLevel,Title,CreateDate")] CalendarBase calendarBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calendarBase).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(calendarBase);
        }

        // GET: Cal/Calendars/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarBase calendarBase = await db.CalendarBases.FindAsync(id);
            if (calendarBase == null)
            {
                return HttpNotFound();
            }
            return View(calendarBase);
        }

        // POST: Cal/Calendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CalendarBase calendarBase = await db.CalendarBases.FindAsync(id);
            db.CalendarBases.Remove(calendarBase);
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
