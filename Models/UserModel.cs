using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello_aspx.Models
{
    public class UserModel
    {
        // string is System.String
        public UserModel(long id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public long id { get; set; }
        public String name { get; set; }
    }
}
