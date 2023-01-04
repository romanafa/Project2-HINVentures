using HIN_Ventures.Models;
using HIN_Ventures.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Models.Viewmodels;
using HIN_Ventures.Repository;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Data;
using Microsoft.AspNetCore.Identity;

namespace HIN_Ventures.Controllers
{
    [Authorize(Roles = Roles.RoleCustomer)]
    public class CustomerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly HIN_VenturesContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager,
            HIN_VenturesContext context,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewAssignment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewAssignment(AssignmentVM vm, IFormCollection form)
        {
            var model = FromVmToModel(vm);

            model.Specialities = new List<Speciality>();
            var specialities = form["specialities"];

            var list = specialities.ToArray();
            var speciality = _unitOfWork.Speciality.GetAll(
            ).ToList();

            foreach (var spec
                     in list)
            {

                var currentSpeciality = _unitOfWork.Speciality.GetFirstOrDefault(x => x.SpecialityId == int.
                    Parse(spec));
                if (currentSpeciality != null)
                {
                    model.Specialities.Add(currentSpeciality);
                }

                
            }


            

            try
            {
                model.CustomerId = _userManager.GetUserId(User);
                model.CustomerName = _userManager.GetUserName(User);
                
                _unitOfWork.Assignment.Add(model);
                _unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }

           
        }

        private Assignment FromVmToModel(AssignmentVM vm)
        {
            Assignment assignment = new()
            {
                IsActive = true,
                Created = DateTime.Now,
                Deadline = vm.Deadline,
                //CustomerId = vm.CustomerId,
                Description = vm.Description,
                IsCompleted = false,
                Progress = 0,
                Title = vm.Title
               // SubmittedCode = new SubmittedCode()
            };

            return assignment;
        }


        public IActionResult Assignments()
        {
            return View();
        }

        public IActionResult AssignmentStatus()
        {
            return View();
        }

        public IActionResult Developers()
        {
            return View();
        }

    }
}