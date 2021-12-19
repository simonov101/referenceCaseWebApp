using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenceCaseWebApp.Model
{
    public class Detail : IDetail
    {
        public string FullName
        {
            get
            {
                return "Kamya Nehwal";
            }
            set
            {
                this.FullName = value;
            }
        }
    }
}
