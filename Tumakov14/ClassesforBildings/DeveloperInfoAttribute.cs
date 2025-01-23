using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov14.ClassesforBildings
{

    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string Organization { get; }

        public DeveloperInfoAttribute(string developerName, string organization)
        {
            DeveloperName = developerName;
            Organization = organization;
        }
    }

}
