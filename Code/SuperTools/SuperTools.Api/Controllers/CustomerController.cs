using Microsoft.AspNetCore.Mvc;
using SuperTools.Data.Entity;
using SuperTools.VO;
using SupeTools.Service;

namespace SuperTools.Api.Controllers
{
    public class CustomerController : BaseController
    {
        private CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public JsonResult AddOrUpdateCustomer(Customer customer)
        {
            var flag = _customerService.AddOrUpdate(customer, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpPost]
        public JsonResult DeleteCustomer(long id)
        {
            var flag = _customerService.Delete(id, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpGet]
        public JsonResult GetCustomer(long id)
        {
            var flag = _customerService.GetCustomer(id, out var user, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(user));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpGet]
        public JsonResult GetCustomers()
        {
            var flag =_customerService.GetCustomers(out var customers, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(customers));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }
    }
}
