using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Exceptions
{
    public class ListNotFoundException : AppException
    {
        public ListNotFoundException() : base() { }

        public ListNotFoundException(string message) : base(message) { }

        public ListNotFoundException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}
