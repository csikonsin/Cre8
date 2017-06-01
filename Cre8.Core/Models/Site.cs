using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cre8.Core.Models
{
    public class Site
    {
        public string Title { get; set; }
        public IList<MetaTag> MetaTags{ get; set; }
        public IList<Gear> Gears{ get; set; }

        public string Theme { get; set; }


        public Site()
        {
            Gears = new List<Gear>();
            MetaTags = new List<MetaTag>();
            Title = string.Empty;
        }

    }


    public class MetaTag
    {

    }

    public abstract class Gear
    {
        private string path;
        public string ViewPath
        {
            get
            {
                return path;
            }
        }

        public Gear(string _path)
        {
            path = _path;
        }

    }

    public class Text : Gear
    {
        

        public string HtmlContent { get; set; }


        public Text():base("Gears/Text/Text")
        {

        }

    }

    public class Picture : Gear
    {
        public Picture():base("Gears/Picture/ImgPicture")
        {

        }

        public string Source { get; set; }
        public string AltText { get; set; }


    }



}