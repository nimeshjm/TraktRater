﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TraktRater.TraktAPI.DataStructures
{
    [DataContract]
    public class TraktEpisode
    {
        [DataMember(Name = "ids")]
        public TraktEpisodeId Ids { get; set; }
    }
}
