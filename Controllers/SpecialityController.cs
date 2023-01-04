using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HIN_Ventures.Controllers
{
    [Authorize]
    public class SpecialityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HIN_VenturesContext _db;

        public SpecialityController(IUnitOfWork unitOfWork, HIN_VenturesContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;
        }

        // GET: SpecialityController/
        public ActionResult AllSpecialities()
        {
            IEnumerable<Speciality> specialityList = _unitOfWork.Speciality.GetAll();
            ViewBag.Specialities = specialityList;

            return View();
        }

        [HttpGet]
        public ActionResult FreelancersBySpecialities(int? id)
        {
            var freelancersbySpeciality = _db.Specialities.Where(s => s.SpecialityId == id)
                .SelectMany(f => f.Freelancers).ToList();
            return PartialView("~/Views/Freelancer/_ViewFreelancersBySpeciality.cshtml", freelancersbySpeciality);
        }
    }
}
