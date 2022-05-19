using SuperHelper.Extension;
using SuperTools.Data;
using SuperTools.Data.Entity;

namespace SupeTools.Service
{

    public class CustomerService
    {
        private ToolsDbContext _db;
        public CustomerService(ToolsDbContext db)
        {
            _db = db;
        }

        public bool GetCustomers(out List<Customer> customers, out string msg)
        {
            customers = _db.Customers.ToList();
            msg = "成功";
            return true;
        }

        public bool GetCustomer(long id, out Customer? customer, out string msg)
        {
            customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                msg = "未找到该客户信息";
                return false;
            }
            else
            {
                msg = "成功";
                return true;
            }
        }

        public bool Delete(long id, out string msg)
        {
            var info = _db.Customers.FirstOrDefault(x => x.Id == id);
            if (info == null)
            {
                msg = "未找到该客户信息";
                return false;
            }
            _db.Customers.Remove(info);
            _db.SaveChanges();
            msg = "成功";
            return true;
        }

        public bool AddOrUpdate(Customer customer,out string msg)
        {
            if (customer.Id==0)//新增
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
            else
            {
                var oldCustomer = _db.Customers.FirstOrDefault(x => x.Id == customer.Id);
                oldCustomer.ValueAssign(customer);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }
    }
}
