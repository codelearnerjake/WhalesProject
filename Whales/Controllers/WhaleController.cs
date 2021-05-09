using Microsoft.AspNetCore.Mvc;
using Whales.Models;
using Whales.ViewModels;

namespace Whales.Controllers
{
    public class WhaleController : Controller
    {
        private readonly IWhalesRepository _whaleRepository;

        public WhaleController(IWhalesRepository whalesRepository)
        {
            _whaleRepository = whalesRepository;
        }

        public ViewResult List()
        {
            WhalesListViewModel whalesListViewModel = new WhalesListViewModel();
            whalesListViewModel.Whales = _whaleRepository.AllWhales;
            return View(whalesListViewModel);
        }

        [HttpPost]
        [Route("WhaleController/Save")]
        public IActionResult Save([FromBody] Whale data)
        {
            if (data.Id != 0)
            {
                _whaleRepository.EditWhale(data);
            }
            else
            {
                _whaleRepository.AddWhale(data);
            }

            return new JsonResult(new { StatusCode = 200 });
        }

        [HttpDelete]
        [Route("WhaleController/Delete")]
        public IActionResult Delete([FromBody] Whale data)
        {
            _whaleRepository.DeleteWhale(data);
            return new JsonResult(new { StatusCode = 200 });
        }
    }
}
