﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class RoomsController : ControllerBase
    {
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}