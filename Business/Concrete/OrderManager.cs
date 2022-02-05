using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
       IOrderDal  _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            orderDal = _orderDal;
        }

       
    }
}
