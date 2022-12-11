using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    internal interface IHuman
    {
        int Age { get; set; }   
        string Name { get; set; }
        string SecondName { get; set; }         
    }    
}
