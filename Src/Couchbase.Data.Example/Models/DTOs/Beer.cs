﻿using System;
using Couchbase.Data.DAO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Couchbase.Data.Example.Models.DTOs
{
    /// <summary>
    ///     'Beer' POCO for testing
    /// </summary>
    public class Beer : DataTransferObjectBase
    {
        [Required]
        public override string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Abv { get; set; }

        public decimal Ibu { get; set; }

        public decimal Srm { get; set; }

        public int Upc { get; set; }

        [JsonProperty("brewery_id")]
        public string BreweryId { get; set; }

        public string Description { get; set; }

        public string Style { get; set; }

        public string Category { get; set; }

        public DateTime ?Updated { get; set; }
        /*
             * {
                  "name": "21A IPA",
                  "abv": 7.2,
                  "ibu": 0,
                  "srm": 0,
                  "upc": 0,
                  "type": "beer",
                  "brewery_id": "21st_amendment_brewery_cafe",
                  "updated": "2010-07-22 20:00:20",
                  "description": "Deep golden color. Citrus and piney hop aromas. Assertive malt backbone supporting the overwhelming bitterness. Dry hopped in the fermenter with four types of hops giving an explosive hop aroma. Many refer to this IPA as Nectar of the Gods. Judge for yourself. Now Available in Cans!",
                  "style": "American-Style India Pale Ale",
                  "category": "North American Ale"
                }
             */
    }
}
