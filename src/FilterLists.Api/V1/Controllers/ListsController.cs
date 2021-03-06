﻿using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;
        private readonly SeedService seedService;

        public ListsController(SeedService seedService, FilterListService filterListService)
        {
            this.seedService = seedService;
            this.filterListService = filterListService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Json(await filterListService.GetAllSummariesAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Json(await filterListService.GetDetailsAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<FilterList, FilterListSeedDto>());
        }
    }
}