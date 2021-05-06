using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test.Interfaces;
using tech_test.Models;

namespace tech_test.Controllers
{
    public class PhoneNumbersController
    {
        private readonly INumberFinderService _numberFinderService;

        public PhoneNumbersController(INumberFinderService numberFinderService)
        {
            _numberFinderService = numberFinderService;
        }

        public int CalculateAmountOfPaths()
        {
            var dialPad = new DialPad()
            {
                Height = 4,
                Width = 3
            };
            var phoneNumber = new PhoneNumber()
            {
                Length = 7
            };

            int amountOfPaths = _numberFinderService.Solution(dialPad, phoneNumber);

            return amountOfPaths;
        }
    }
}
