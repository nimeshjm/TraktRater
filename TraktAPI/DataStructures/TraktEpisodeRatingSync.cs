﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TraktRater.TraktAPI.DataStructures
{
    [DataContract]
    public class TraktEpisodeRatingSyncEx
    {
        [DataMember(Name = "shows")]
        public List<TraktShowSeasonsRating> Shows { get; set; }

        [DataContract]
        public class TraktShowSeasonsRating : TraktShow
        {
            [DataMember(Name = "seasons")]
            public List<TraktSeasonEpisodesRating> Seasons { get; set; }

            [DataContract]
            public class TraktSeasonEpisodesRating
            {
                [DataMember(Name = "number")]
                public int Number { get; set; }

                [DataMember(Name = "episodes")]
                public List<TraktEpisodeRatingEx> Episodes { get; set; }
            }
        }
    }

    [DataContract]
    public class TraktEpisodeRatingSync
    {
        [DataMember(Name = "episodes")]
        public List<TraktEpisodeRating> Episodes { get; set; }
    }
}
