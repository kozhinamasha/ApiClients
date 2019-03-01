using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ApiClients
{
    [DataContract(Name = "repo")]
    public class Repository
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "html_url")]
        public Uri GitHubHomeUrl { get; set; }

        [DataMember(Name = "homepage")]
        public Uri Homepage { get; set; }

        [DataMember(Name = "watchers")]
        public int Watchers { get; set; }

        [DataMember(Name = "pushed_at")]
        private string PushedAt { get; set; }

        [DataMember (Name="updated_at")]
        private string Updated { get; set; }

        [IgnoreDataMember]
        public DateTime LastPush
        {
            get
            {
                return DateTime.ParseExact(PushedAt, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
            }
        }

        [IgnoreDataMember]
        public DateTime LastUpdated
        {
            get { return DateTime.ParseExact(Updated, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);}
        }
    }
}
