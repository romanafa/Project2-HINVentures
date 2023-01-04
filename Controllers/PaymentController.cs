using System.Security.Cryptography.Xml;
using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Services;
using HIN_Ventures.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HIN_Ventures.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly HIN_VenturesContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private double _pricePerLine = 0.001;

        public PaymentController(ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager,
            HIN_VenturesContext context,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> _FreelancerPaymentIndex()
        {
            var freelancer = await _userManager.GetUserAsync(User);
            var freelancerId = freelancer.Id;

            var payment = _context.Payments.
                Where(p => p.FreelancerId == freelancerId).Include(x => x.Assignment)
                .ThenInclude(s => s.SubmittedCode).ToList();

            return View(payment);
        }

        public IActionResult _CustomerPaymentIndex()
        {
            var customerId = _userManager.GetUserId(User);
            
            var assignmentsWithCode = _context.Assignments.Include(x => x.SubmittedCode)
                .Where(c => c.CustomerId == customerId).
                ToList();


            return View(assignmentsWithCode);
        }

        public IActionResult _HINVenturesPaymentIndex()
        {

            var payment = _context.Payments.Include(x => x.Assignment)
                .ThenInclude(s => s.SubmittedCode).ToList();

            return View(payment);   
            
        }

        [HttpPost]
        public async Task<IActionResult> _HINVenturesPaymentIndex(IFormCollection form)
        {

            var freelancerId = form["freelancerId"];
            var customerId = form["customerId"];
            var numberOfLines = form["numberOfLines"];

            var customerUser = await _userManager.FindByIdAsync(customerId);
            var customer = (Customer)customerUser;

            var freelancerUser = await _userManager.FindByIdAsync(
                freelancerId);
            var freelancer = (Freelancer)freelancerUser;

            var addressTo = freelancer.AccountAddress;
            var noOfLines = int.Parse(numberOfLines);

            var assignmentIdInput = form["assignmentId"];
            var assignmentId = int.Parse(assignmentIdInput);

            var assignment = _unitOfWork.Assignment.GetFirstOrDefault(
                x => x.AssignmentId == assignmentId);

            var amount = noOfLines * _pricePerLine;

            PaymentService service = new();

            service.TransferMoneyFromHinToFreelancer(freelancer,
                amount, assignment);


            Payment payment = new()
            {
                Amount = amount,
                Assignment = assignment,
                FreelancerId = freelancer.Id,

            };

            _unitOfWork.Payment.Add(payment);

            assignment.IsPayedToFreelancer = true;
            _unitOfWork.Assignment.Update(assignment);

            return RedirectToAction("_HINVenturesPaymentIndex", "Payment");

        }

        [HttpPost]
        public async Task<IActionResult> _CustomerPaymentIndex(IFormCollection form)
        {

            var freelancerId = form["freelancerId"];
            var numberOfLines = form["numberOfLines"];
            var customerUser =  await _userManager.GetUserAsync(User);
            var customer = (Customer)customerUser;

            var freelancerUser = await _userManager.FindByIdAsync(
                freelancerId);
            var freelancer = (Freelancer)freelancerUser;


            var addressFrom = customer.AccountAddress;
            var noOfLines = int.Parse(numberOfLines);
            
            

            var assignmentIdInput = form["assignmentId"];
            var assignmentId = int.Parse(assignmentIdInput);

            var assignment = _unitOfWork.Assignment.GetFirstOrDefault(
                x => x.AssignmentId == assignmentId);

            var amount = noOfLines * _pricePerLine;

            var customerWithSubscription =
                _context.Customers.Include(x => x.Subscription)
                    .Where(y => y.Id == customer.Id).FirstOrDefault();

                PaymentService service = new();

                
                
                    service.TransferMoneyToHinVentures(customerWithSubscription, freelancer,
                        amount, assignment);
                    
                

                Payment payment = new()
                {
                    Amount = amount,
                    Assignment = assignment,
                    CustomerId = customer.Id,
                    
                };

                _unitOfWork.Payment.Add(payment);

                assignment.IsPayed = true;
                _unitOfWork.Assignment.Update(assignment);

            return RedirectToAction("_CustomerPaymentIndex", "Payment");

        }

        

        public IActionResult Index()
        {
            /*
             eksempel på transaksjon:
            PaymentService service = new();
            var user = await _userManager.GetUserAsync(User);
            var freelancer = (Freelancer)user;
            var address1 = freelancer.AccountAddress;

            service.transferMoneyFromHinToFreelancer(freelancer, "0.000125");
            
             */
            return View();
        }

        [Authorize(Roles = Roles.RoleSeniorDeveloper + "," + Roles.RoleHINEmployee + "," + Roles.RoleAdmin)]
        public IActionResult ManagePayments()
        {
            return View();
        }
    }
}
