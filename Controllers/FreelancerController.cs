using HIN_Ventures.Models;
using HIN_Ventures.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BlockIoLib;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Services;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NBitcoin;
using HIN_Ventures.Data;
using HIN_Ventures.Models.Viewmodels;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HIN_Ventures.Controllers
{
    [Authorize(Roles = Roles.RoleFreelancer)]
    public class FreelancerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly HIN_VenturesContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private IFreelancerRepository _freelancerRepository;

        public FreelancerController(ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager, 
            HIN_VenturesContext context, 
            IUnitOfWork unitOfWork,
            IFreelancerRepository freelancerRepository)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
            _unitOfWork = unitOfWork;
            _freelancerRepository = freelancerRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            List<Freelancer> freelancers = (List<Freelancer>)_freelancerRepository.GetAllFreelancers();
            return View(freelancers);
        }

        [HttpPost]
        public ActionResult EditRating([FromForm] int rating, [Bind("TotalRating")] string freelancerId)
        {
            //var productViewModel = repository.GetProductByIdModel(model.ProductId);


                Freelancer freelancer = _freelancerRepository.GetFreelancerById(freelancerId);

                // Kall til metoden save i repository
                this._freelancerRepository.UpdateRating(freelancer, rating);

                

                return RedirectToAction("Index");
           

        }


        

        public IActionResult DeliverCode(int id)
        {
            var assignment = _unitOfWork.Assignment.GetFirstOrDefault(x => x.AssignmentId == id);
            var freelancerId = _userManager.GetUserAsync(User).Result.Id;
            var freelancerName = _userManager.GetUserName(User);
            assignment.IsActive = false;
            assignment.FreelancerId = freelancerId;
            assignment.FreelancerName = freelancerName;
            _unitOfWork.Assignment.Update(assignment);

            SubmittedCodeVM vm = new()
            {
                Assignment = assignment
            };
         
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<SubmittedCode>> DeliverCode(
            SubmittedCodeVM vm, IFormCollection form)
        {
            if (!ModelState.IsValid)
            {
                var progress = form["progress"];
                var id = form["assignmentId"];
                var numberOfLines = form["numberOfLines"];

                var assignment = _unitOfWork.Assignment.GetFirstOrDefault(x => x.AssignmentId == int.Parse(id));
                assignment.Progress = int.Parse(progress);
                _unitOfWork.Assignment.Update(assignment);

                SubmittedCode newCode = FromSubmittedCodeVMToModel(vm, int.Parse(id), 
                    int.Parse(numberOfLines));

                _context.SubmittedCodes.Add(newCode);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPut]


        private SubmittedCode FromSubmittedCodeVMToModel(SubmittedCodeVM vm,
            int id, int numberOfLines)
        {

            SubmittedCode code = new()
            {
                Code = vm.Code,
                IsApproved = false,
                DateSubmitted = DateTime.Now,
                Assignment = _context.Assignments.Find(id),
                NumberOfLines = numberOfLines
                
            };

            return code;

        }


        public async Task<IActionResult> Assignments()
        {

            var freelancerUser = await _userManager.GetUserAsync(User);
            var freelancer = (Freelancer)freelancerUser;

            var freelancerListOfSpecialities =
                _unitOfWork.Freelancer.GetAllSpecialities(freelancer.Id);

            var assignmentsContainsSpecialities = false;
            var assignments = _context.Assignments.Include(x => x.Specialities).ToList();
            
            var filteredAssignments = new List<Assignment>();
            
            foreach (var assignment in assignments)
            {
                
                    if (_unitOfWork.Assignment.GetAllSpecialities(
                            assignment.AssignmentId).ToList().Count > 0)
                    {
                        assignmentsContainsSpecialities = true;

                        var addToList = true;

                        foreach (var spec in assignment.Specialities)
                        {
                            if (!freelancerListOfSpecialities.Contains(spec))
                                addToList = true;
                        }

                        if (addToList)
                            filteredAssignments.Add(assignment);

                    }

                    filteredAssignments.Add(assignment);

            }

            if (assignmentsContainsSpecialities && filteredAssignments.Count > 0)
                return View(filteredAssignments);

            return View(assignments);
                
        }
        
        
        public IActionResult Chat()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<Freelancer>> Account(IFormCollection form)
        {
            var freelancerUser = await _userManager.GetUserAsync(User);
            var _freelancer = (Freelancer)freelancerUser;
           
            var specialityId = form["spec"];

            var freelancer = _unitOfWork.Freelancer.GetFirstOrDefault(
                x => x.Id == _freelancer.Id);

            var speciality = _unitOfWork.Speciality.GetFirstOrDefault(
                x => x.SpecialityId == int.Parse(specialityId));

                freelancer.Specialities.Add(speciality);
                speciality.Freelancers.Add(freelancer);

            await _unitOfWork.Freelancer.Update(freelancer);
            

            var freelancerWithSpecs = _context.Freelancers.Where(
                    x => x.Id == _freelancer.Id)
                .Include(s => s.Specialities)
                .FirstOrDefault();
            

            return View(freelancerWithSpecs);

        }
       
        public async Task<IActionResult> Account()
        {
            var freelancerUser = await _userManager.GetUserAsync(User);
            var _freelancer = (Freelancer)freelancerUser;

            var freelancer = _context.Freelancers.Where(
                    x => x.Id == _freelancer.Id)
                .Include(s => s.Specialities)
                .FirstOrDefault();

            return View(freelancer);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}