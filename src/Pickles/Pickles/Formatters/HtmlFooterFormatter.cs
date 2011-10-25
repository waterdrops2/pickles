﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Pickles.Formatters
{
    public class HtmlFooterFormatter
    {
        public XElement Format()
        {
            var xmlns = XNamespace.Get("http://www.w3.org/1999/xhtml");
            return new XElement(xmlns + "div",
                new XAttribute("id", "footer"),
                new XElement("p", "Produced by Pickles version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()));
        }
    }
}
