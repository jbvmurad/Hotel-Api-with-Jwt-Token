using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaÖdev.Entity;
using PatikaTask.DTOs.CustomerDTOs;
using PatikaTask.Services;

namespace PatikaTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController (IGeneric<Customer> _customerService , IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var customers = _customerService.GetList();
            if (customers == null)
            {
                return NotFound("No customers found.");
            }
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var existingCustomer = _customerService.GetById(id);
            if (existingCustomer == null)
            {
                return NotFound("Customer not found.");
            }
            return Ok(existingCustomer);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingCustomer = _customerService.GetById(id);
            if (existingCustomer == null)
            {
                return NotFound("Customer not found.");
            }
            _customerService.Delete(id);
            return Ok("Customer deleted successfully.");
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerDTO createCustomerDTO)
        {
            var newCustomer = _mapper.Map<Customer>(createCustomerDTO);
            _customerService.Create(newCustomer);
            return Ok(newCustomer);
        }
        [HttpPut]
        public IActionResult Update(UpdateCustomerDTO updateCustomerDTO)
        {
            var updatedCustomer = _mapper.Map<Customer>(updateCustomerDTO);
            _customerService.Update(updatedCustomer);
            return Ok(updatedCustomer);
        }
    }
}
