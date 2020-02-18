using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class ResetPasswordModel
    {
       
        private string email;
        private string password;

        private string userName;
        
        public string UserName
        {
            get;
            set;
        }
       
         public string Email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }
       
       
    }
}
