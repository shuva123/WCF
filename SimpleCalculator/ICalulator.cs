using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalulator
    {

        [OperationContract]
         double AddNumber(double num1, double num2);


        [OperationContract]
         double SubNumber(double num1, double num2);
        


    }
}
