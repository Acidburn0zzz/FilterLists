﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Services
{
    public class FilterListService
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public FilterListService(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<FilterListSummaryDto>> GetAllSummariesAsync()
        {
            return await filterListsDbContext.Set<FilterList>().AsNoTracking().ProjectTo<FilterListSummaryDto>()
                .ToListAsync();
        }
    }
}