using Microsoft.AspNetCore.Mvc;
using netwebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace netwebAPI.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private IStudentRepository _IStudentRepository;
        private IMapper _Imapper;
        public StudentsController(IStudentRepository IStudentRepository, IMapper Imapper)
        {
            this._IStudentRepository = IStudentRepository;
            this._Imapper = Imapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var _domainModelStudents = new List<DomainModels.Student>();
            var students = await _IStudentRepository.GetStudentsAsync();

            #region
            //foreach (var item in students)
            //{
            //    _domainModelStudents.Add(new DomainModels.Student
            //    {
            //        Id = item.Id,
            //        FirstName = item.FirstName,
            //        LastName = item.LastName,
            //        DateOfBirth = item.DateOfBirth,
            //        Email = item.Email,
            //        ProfileImageUrl = item.ProfileImageUrl,
            //        GenderId = item.GenderId,
            //        Address = new DomainModels.Address()
            //        {
            //            Id = item.Address.Id,
            //            PhysicalAddress = item.Address.PhysicalAddress,
            //            PostalAddress = item.Address.PostalAddress
            //        },

            //        Gender = new DomainModels.Gender()
            //        {
            //            Id = item.Gender.Id,
            //            Description = item.Gender.Description
            //        }

            //    });
            //}
            #endregion

            return Ok(
            _Imapper.Map<List<DataModels.Student>>(students));
        }
    }
}
