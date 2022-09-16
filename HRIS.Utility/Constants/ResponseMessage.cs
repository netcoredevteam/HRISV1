using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Utility.Constants
{
    public class ResponseMessage
    {
        public const string Success = "Success";
        public const string BadRequest = "Bad request.";
        public const string FileNotSupported = "File not supported.";
        public const string NotFound = "Not found.";
        public const string DuplicateEmployeeNo = "Employee No. already exists";
        public const string UploadComplete = "Upload complete.";
        public const string UploadFailed = "Upload failed.";
    }
}
