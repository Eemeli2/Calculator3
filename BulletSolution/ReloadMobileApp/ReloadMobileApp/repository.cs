using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BulletLibrary;
using Newtonsoft.Json;

namespace ReloadMobileApp
{
    public class Repository
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("html_url")]
        public Uri GitHubHomeUrl { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        }
    }
