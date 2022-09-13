using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added";
        public static string ProductNameInvalid = "Product name should be min 2 character";
        public static string MaintenanceTime = "System in maintenance";
        public static string ProductListed = "Products listed";
        public static string ProductCountOfCategoryError = "The Category can only have 10 products";
        public static string ProductNameAlreadyExistError = "The product name already exists";
        public static string CategoryLimitExceeded = "The category limit exceeded";
    }
}
