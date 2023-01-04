using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HIN_Ventures.Controllers
{
    [Authorize(Roles = Roles.RoleSeniorDeveloper)]
    public class SeniorController : Controller
    {
        private readonly ILogger<SeniorController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public SeniorController(ILogger<SeniorController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult CodeForApproval()
        {

            var code = _unitOfWork.SubmittedCode.GetAll().
                ToList();

            return View(code);
        }

        [HttpPost]
        public ActionResult<SubmittedCode> CodeForApproval( 
            IFormCollection form)
        {
            var statusInput = form["status"];
            var id = form["id"];

            var status = false;
            if (statusInput.Equals("approved"))
                status = true;
            else status = false;


            SubmittedCode _code = _unitOfWork.SubmittedCode.GetFirstOrDefault(x => x.CodeId == 
                int.Parse(id));
            _code.IsApproved = status;

            _unitOfWork.SubmittedCode.Update(_code);

            return RedirectToAction("CodeForApproval");
        }

        public IActionResult ShowAllAssignments()
        {
            return View();
        }
    }
}
