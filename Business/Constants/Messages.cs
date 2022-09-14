using Core.Entities.Concrete;
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
        public static string AuthorizationDenied = "You don't have authorization";
        public static string UserRegistered = "User registered";
        public static string UserNotFound ="Registered user not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "The User already exists";
        public static string AccessTokenCreated ="Token was created";
        public static string UserAdded = "The user is added";
        public static string ProductUpdated = "The product is updated";
    }
}
