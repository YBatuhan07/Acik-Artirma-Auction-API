﻿using AuctionBusiness.Abstraction;
using AuctionBusiness.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBidService _bidService;
        public BidController(IBidService bidService)
        {
            _bidService = bidService;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateBid(CreateBidDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.CreateBid(model);

                return Ok(response);
            }
            return BadRequest();
        }


        [HttpGet("{bidId:int}")]
        public async Task<IActionResult> GetBidById(int bidId)
        {

            var response = await _bidService.GetBidById(bidId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);

        }



        [HttpPut("{bidId:int}")]
        public async Task<IActionResult> ModifyBid(int bidId, UpdateBidDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.UpdateBid(bidId, model);
                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AutoBid(CreateBidDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.AutomaticallyCreateBid(model);
                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }



        [HttpGet("GetBidsByVehicle/{vehicleId:int}")]
        public async Task<ActionResult> GetBidByVehicle(int vehicleId)
        {

            var response = await _bidService.GetBidByVehicleId(vehicleId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);

        }

    }
}
