using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;
using Dal;

namespace Bal
{
   
    public class BalClass1
    {
        DalClass1 dal = new DalClass1();
       
            public DataTable GetStatesByCountry(int countryID)
            {
                return dal.GetStatesByCountry(countryID);
            }

            public DataTable GetCityByStates(int stateID)
            {
                return dal.GetCityByStates(stateID);
            }
        


    }
}
