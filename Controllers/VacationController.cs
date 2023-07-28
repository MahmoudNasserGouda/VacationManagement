using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VacationManagement.Models.Entities;
using VacationManagement.Repositories;
using VacationManagement.ViewModels;

namespace VacationManagement.Controllers
{
    public class VacationController : Controller
    {
        private readonly IVacationRequestRepository _vacationRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public VacationController(IVacationRequestRepository vacationRepository, IDepartmentRepository departmentRepository)
        {
            _vacationRepository = vacationRepository;
            _departmentRepository = departmentRepository;
        }

        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            List<ListVacationRequestsVM> vacationRequestsVM = await _vacationRepository.ListVacationRequests();
            return View(vacationRequestsVM);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentRepository.GetDepartments().Result;
            return View(new CreateVacationRequestVM());
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreateVacationRequestVM vacationRequestVM)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = _departmentRepository.GetDepartments().Result;
                return View(vacationRequestVM);
            }
            if (vacationRequestVM.DateTo < vacationRequestVM.DateFrom)
            {
                ModelState.AddModelError(nameof(vacationRequestVM.DateTo), "*Date To Must Be After Date From");
                ViewBag.Departments = _departmentRepository.GetDepartments().Result;
                return View(vacationRequestVM);
            }
            await _vacationRepository.CreateVacationRequest(vacationRequestVM);
            return RedirectToAction("Create");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(Guid Id)
        {
            VacationRequest vacationRequest = await _vacationRepository.GetVacationRequest(Id);
            return View(vacationRequest);
        }
    }
}
