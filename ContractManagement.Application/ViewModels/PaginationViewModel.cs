using System;

namespace ContractManagement.Application.ViewModels
{
    public class PaginationViewModel
    {
        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; }

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
    }
}
