// Controllers/BookController.cs
using System.Linq;
using System.Net;
using System.Web.Mvc;

public class BookController : Controller
{
    private readonly ApplicationContext _context = new ApplicationContext();

    // GET: Book
    public ActionResult Index()
    {
        return View(_context.Books.ToList());
    }

    // GET: Book/Details/5
    public ActionResult Details(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Book book = _context.Books.Find(id);
        if (book == null)
        {
            return HttpNotFound();
        }

        return View(book);
    }

    // GET: Book/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Book/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "BookID,Title,Author,Genre,ISBN,PublicationDate,AvailabilityStatus")] Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(book);
    }

    // GET: Book/Edit/5
    public ActionResult Edit(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Book book = _context.Books.Find(id);
        if (book == null)
        {
            return HttpNotFound();
        }

        return View(book);
    }

    // POST: Book/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "BookID,Title,Author,Genre,ISBN,PublicationDate,AvailabilityStatus")] Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(book);
    }

    // GET: Book/Delete/5
    public ActionResult Delete(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Book book = _context.Books.Find(id);
        if (book == null)
        {
            return HttpNotFound();
        }

        return View(book);
    }

    // POST: Book/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
        Book book = _context.Books.Find(id);
        _context.Books.Remove(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
        base.Dispose(disposing);
    }
}
