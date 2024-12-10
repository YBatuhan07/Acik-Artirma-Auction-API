//using AuctionBusiness.Abstraction;
//using AuctionBusiness.Dtos;
//using Microsoft.AspNetCore.Mvc;

//namespace Auction.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class VehiclesController : ControllerBase
//{
//    private readonly IVehicleService _vehicleService;
//    private readonly IWebHostEnvironment _webHostEnvironment;

//    public VehiclesController(IVehicleService vehicleService, IWebHostEnvironment webHostEnvironment)
//    {
//        _vehicleService = vehicleService;
//        _webHostEnvironment = webHostEnvironment;
//    }

//    [HttpPost("CreateVehicle")]
//    public async Task<IActionResult> AddVehicle([FromForm]CreateVehicleDTO model)
//    {
//        if (ModelState.IsValid)
//        {
//            if (model.File == null || model.File.Length == 0)
//            {
//                return BadRequest();
//            }

//            string uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath,"Images");
//            string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
//            string filePath = Path.Combine(uploadsFolder,fileName);

//            using(var fileStream = new FileStream(filePath, FileMode.Create))
//            {
//                await model.File.CopyToAsync(fileStream);
//            }
//            model.Image = fileName;

//            var result = await _vehicleService.CreateVehicle(model);
//            if (result.IsSuccess)
//            {
//                return Ok(result);
//            }
//        }
//        return BadRequest();
//    }

//    [HttpGet("GetVehicles")]
//    public async Task<IActionResult> GetAllVehicles()
//    {
//        var vehicles = await _vehicleService.GetVehicle();

//        return Ok(vehicles);
//    }

//    [HttpPut("UpdateVehicle")]
//    public async Task<IActionResult> UpdateVehicle([FromRoute] int vehicleId, UpdateVehicleDTO model)
//    {
//        if (ModelState.IsValid)
//        {
//            var result = await _vehicleService.UpdateVehicleResponse(vehicleId, model);
//            if (result.IsSuccess)
//            {
//                return Ok(result);
//            }
//        }
//        return BadRequest();
//    }

//    [HttpDelete("{vehicleId}")]
//    public async Task<IActionResult> DeleteVehicle([FromRoute] int vehicleId)
//    {
//        var result = await _vehicleService.DeleteVehicle(vehicleId);
//        if (result.IsSuccess)
//        {
//            return Ok();
//        }
//        return BadRequest();
//    }

//    [HttpGet("{vehicleId}")]
//    public async Task<IActionResult> GetVehicleById([FromRoute] int vehicleId)
//    {
//        var result = await _vehicleService.GetVehicleById(vehicleId);
//        if (result.IsSuccess)
//        {
//            return Ok(result);
//        }
//        return BadRequest();
//    }

//    [HttpPut("{vehicleId}")]
//    public async Task<IActionResult> ChangeStatus([FromRoute] int vehicleId)
//    {
//        var result = await _vehicleService.ChangeVehicleStatus(vehicleId);
//        if (result.IsSuccess)
//        {
//            return Ok(result);
//        }
//        return BadRequest();
//    }
//}