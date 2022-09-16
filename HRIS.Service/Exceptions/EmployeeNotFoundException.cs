using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Exceptions
{
    public class EmployeeNotFoundException : AppException
    {
        public EmployeeNotFoundException() : base() { }

        public EmployeeNotFoundException(string message) : base(message) { }

        public EmployeeNotFoundException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        { }
    }
}
