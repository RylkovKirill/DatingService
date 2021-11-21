using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingService.Infrastructure.ViewModels;
using Braintree;

namespace DatingService.Controllers
{
    public class PayController : Controller
    {
        private readonly IBraintreeService _braintreeService;
        public PayController(IBraintreeService braintreeService)
        {
            _braintreeService = braintreeService;
        }
        public IActionResult Index()
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var data = new ProductViewModel()
            {
                Title = "Test",
                Price = 0.001f
            };
            return View(data);
        }
        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal("150"),
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                return View("Success");
            }
            else
            {
                string errorMessages = "";
                foreach (ValidationError error in result.Errors.DeepAll())
                {
                    errorMessages += "Error: " + (int)error.Code + " - " + error.Message + "\n";
                }
                return View("sda");
            }
        }

    }
}
