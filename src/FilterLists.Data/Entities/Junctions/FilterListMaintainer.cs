﻿namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListMaintainer : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }

        public int MaintainerId { get; set; }
        public Maintainer Maintainer { get; set; }
    }
}