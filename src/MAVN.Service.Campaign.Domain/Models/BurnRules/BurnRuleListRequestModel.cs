using System;

namespace MAVN.Service.Campaign.Domain.Models.BurnRules
{
    public class BurnRuleListRequestModel : PaginationModel
    {
        public string Title { get; set; }

        public Guid? PartnerId { get; set; }
    }
}
