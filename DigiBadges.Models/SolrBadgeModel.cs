using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBadges.Models
{
    public class SolrBadgeModel
    {
        public SolrBadgeModel() { }
        public SolrBadgeModel(Badge badge)
        {

            this.BadgeId = badge.BadgeId.ToString();
            this.BadgeName = badge.BadgeName;
            this.ImageUrl = badge.ImageUrl;
            this.ExpiryDuration = badge.ExpiryDuration.ToString();
            this.EarningCriteriaDescription = badge.EarningCriteriaDescription;
            this.CreatedDate = badge.CreatedDate;
            this.IssuerId = badge.IssuerId.ToString();
            this.FacebookId = badge.FacebookId;
            this.CreatedBy = badge.CreatedBy;
            

        }
        [SolrUniqueKey("BadgeId")]
        public String BadgeId { get; set; }

        //        [SolrUniqueKey("id")]
        [SolrField("id")]
        public String Id { get; set; }

        //[SolrField("CreatedAt")]
        //public DateTime CreatedAt { get; set; }

        [SolrField("Name")]
        public String BadgeName { get; set; }


        [SolrField("Path")]
        public String ImageUrl { get; set; }

        [SolrField("ExpiryDuration")]
        public string ExpiryDuration { get; set; }

        [SolrField("EarningCriteriaDescription")]
        public string EarningCriteriaDescription { get; set; }

        [SolrField("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [SolrField("IssuerId")]
        public string IssuerId { get; set; }

        [SolrField("FacebookId")]
        public string FacebookId { get; set; }

        [SolrField("CreatedBy")]
        public string CreatedBy { get; set; }

    }
}
