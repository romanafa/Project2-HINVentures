using HIN_Ventures.Helpers;
using HIN_Ventures.Migrations;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Models.Viewmodels;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace HIN_Ventures.Controllers
{
    [Authorize]
    public class SubscriptionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;

        public SubscriptionController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [Authorize(Roles = Roles.RoleCustomer)]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Subscription> subscriptionList = _unitOfWork.Subscription.GetAll();
            return View(subscriptionList);
        }

        [Authorize(Roles = Roles.RoleCustomer)]
        [HttpPost]
        public async Task<IActionResult> Subscribe(int? subscriptionId, SubscriptionVM subscription)
        {
            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User);

            subscriptionId = int.Parse(Request.Form["subscriptionId"]);

            if (user == null)
            {
                return BadRequest("Finner ikke bruker");
            }
            
            Customer customer = _unitOfWork.Customer.GetFirstOrDefault(x => x.Id == user.Id);

            Subscription _subscription = _unitOfWork.Subscription.GetFirstOrDefault(
                s => s.SubscriptionId == subscriptionId);

            customer.IsSubscriber = true;
            customer.Subscription = _subscription;

            _unitOfWork.Customer.Update(customer);

            return RedirectToAction("Index");
        }

        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        public IActionResult ManageSubscriptions()
        {
            IEnumerable<Subscription> subscriptionList = _unitOfWork.Subscription.GetAll();
            return View(subscriptionList);
        }

        // GET: SubscriptionController/Create
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubscriptionController/Create
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("SubscriptionId, SubscriptionName, Description, Price, NumberOfLines")] SubscriptionVM subscription)
        {
            ModelState.Clear();

            if (ModelState.IsValid)
            {
                await _unitOfWork.Subscription.Save(subscription);
                TempData["success"] = "Subscription created successfully";
                return Json(new
                {
                    isValid = true,
                    html = Helper.RenderRazorViewToString(this, "_ViewAllSubscriptions", _unitOfWork.Subscription.GetAll())
                });
                //return RedirectToAction("ManageSubscriptions");
            }

            return View(subscription);
        }

        // GET: SubscriptionController/Edit/5
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        public ActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var post = _unitOfWork.Subscription.GetFirstOrDefault(x => x.SubscriptionId == id);

            if (post == null || post.SubscriptionId != id)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: SubscriptionController/Edit/5
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int subscriptionId, [Bind("SubscriptionId, SubscriptionName, SubscriptionDescription, Price, NumberOfLines")] Subscription subscription)
        {
            if (subscriptionId != subscription.SubscriptionId)
            {
                return NotFound();
            }

            ModelState.Clear();
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.Subscription.Update(subscription);
                    _unitOfWork.Save();
                    TempData["message"] = $"{subscription.SubscriptionName} has been updated";
                    return RedirectToAction("ManageSubscriptions", "Subscription");
                }
                else throw new Exception();
            }
            catch
            {
                return View(subscription);
            }
        }

        // GET: SubscriptionController/Delete/5
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subscription = _unitOfWork.Subscription.GetFirstOrDefault(x => x.SubscriptionId == id);

            if (subscription == null || subscription.SubscriptionId != id)
            {
                return NotFound();
            }
            return View(subscription);
        }

        // POST: SubscriptionController/Delete/5
        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var subscription = _unitOfWork.Subscription.GetFirstOrDefault(x => x.SubscriptionId == id);
            if (subscription == null)
            {
                return NotFound();
            }
            try
            {
                _unitOfWork.Subscription.Delete(subscription);
                _unitOfWork.Save();
                TempData["success"] = "Subscription deleted successfully";
                return RedirectToAction("ManageSubscriptions", "Subscription");
            }
            catch
            {
                return View();
            }
        }
    }
}
