using System;
using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace BemModels
{
    public class Dropmenu
    {

        public String Id { get;}

        public IPublishedContent Node { get;}

        public Dropmenu(string id, IPublishedContent node)
        {
            Id = id;
            Node = node;
        }
    }
}