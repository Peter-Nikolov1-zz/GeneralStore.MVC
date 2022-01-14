using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class TransactionsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transaction
        public ActionResult Create()
        {
            ViewBag.Customers = new SelectList(_db.Customers, "CustomerId", "FirstName");
            return View();
        }

        // POST: Transaction
        public ActionResult CreateTransaction([Bind(Include = "TransactionId, CustomerId, TransactionDate")] Transactions transaction)
        {
            ViewBag.Customers = new SelectList(_db.Customers, "CustomerId", "FirstName", transaction.CustomerId);
            if (ModelState.IsValid)
            {
                _db.Transactions.Add(transaction);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transaction);
        }
    }
}