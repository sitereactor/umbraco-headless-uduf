﻿using TeePhrase.Models.Grid;
using Umbraco.Headless.Client.Net.Models;

namespace TeePhrase.Models
{
    public class GenericContent: ContentItem, IContentBase
    {
        public UmbracoGrid BodyContent { get; set; }
    }
}
