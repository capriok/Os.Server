﻿using Microsoft.AspNetCore.Http;
using OS.API.Models.Oversite;
using OS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OS.API.Managers.Interfaces
{
    public interface ISightManager
    {
        Task<List<SightModel>> FindByOversiteId(int oversiteId);
        Task<SightModel> CreateAsync(int oversiteId, IFormFile sight);
        Task<List<SightModel>> CreateRangeAsync(int oversiteId, IFormFileCollection osSight);
    }
}