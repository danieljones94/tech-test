using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test.Models;

namespace tech_test.Interfaces
{
    public interface INumberFinderService
    {
        public int Solution(DialPad dialPad, PhoneNumber phoneNumber);
    }
}
