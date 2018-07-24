﻿using System;
using Newtonsoft.Json;

namespace Lands.Models
{
    public class Currency
    {
        #region Properties
        [JsonProperty(PropertyName="code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
        #endregion

        public Currency()
        {
        }
    }
}
