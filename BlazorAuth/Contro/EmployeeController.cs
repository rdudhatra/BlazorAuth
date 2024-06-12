﻿//using BlazorAuth.Data;
//using BlazorAuth.Data.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Reflection;
//using System.Linq.Dynamic.Core;

//namespace BlazorAuth.Contro
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmployeeController : ControllerBase
//    {

//        private readonly BlazorAuthContext _context;

//        public EmployeeController(BlazorAuthContext context)
//        {
//            _context = context;
//        }


//        // Data load on serverside using datatable
//        [HttpPost]
//        public IActionResult GetCustomers()
//        {
//            try
//            {
//                var draw = Request.Form["draw"].FirstOrDefault();
//                var start = Request.Form["start"].FirstOrDefault();
//                var length = Request.Form["length"].FirstOrDefault();
//                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
//                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
//                var searchValue = Request.Form["search[value]"].FirstOrDefault();
//                int pageSize = length != null ? Convert.ToInt32(length) : 0;
//                int skip = start != null ? Convert.ToInt32(start) : 0;
//                int recordsTotal = 0;

//                var customerData = (from tempcustomer in _context.Employees select tempcustomer);
//                //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
//                if (!string.IsNullOrEmpty(sortColumn) && typeof(Employee).GetProperty(sortColumn, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) != null)
//                {
//                    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
//                }
//                if (!string.IsNullOrEmpty(searchValue))
//                {
//                    customerData = customerData.Where(m => m.FirstName.Contains(searchValue)
//                                                || m.LastName.Contains(searchValue)
//                                                || m.Contact.Contains(searchValue)
//                                                || m.Email.Contains(searchValue));
//                }
//                recordsTotal = customerData.Count();
//                var data = customerData.Skip(skip).Take(pageSize).ToList();
//                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
//                return Ok(jsonData);

//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}