﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTO
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(IEnumerable<T> source, int pageNumber, int pageSize, int totalCount)
        {

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (pageSize <= 0)
            {
                throw new ArgumentException("pageSize");
            }

            this.AddRange(source);

            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPageCount = (int)Math.Ceiling(totalCount / (double)pageSize);
        }

        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPageCount { get; private set; }

        public bool HasPreviousPage
        {
            get
            {
                return PageNumber > 1;
            }
        }

        public bool HasNextPage
        {
            get
            {
                return PageNumber < TotalPageCount;
            }
        }
    }
}
