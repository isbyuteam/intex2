﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using intex2.Models.ViewModels;

namespace intex2.Infrastructure
{
    [HtmlTargetElement("ul", Attributes = "page-blah")]
    public class Pagination : TagHelper
    {
        private IUrlHelperFactory Uhf;

        public Pagination(IUrlHelperFactory uhf)
        {
            Uhf = uhf;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext Vc { get; set; }
        public PageInformation PageBlah { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper uh = Uhf.GetUrlHelper(Vc);
            TagBuilder final = new TagBuilder("ul");

            for (int i = 1; i <= PageBlah.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["Href"] = uh.Action(PageAction, new { PageNum = i });
                tb.Attributes["class"] = "page-link";
                tb.InnerHtml.Append(i.ToString());
                final.InnerHtml.AppendHtml(tb);
            }

            output.Content.AppendHtml(final.InnerHtml);
        }
    }
}
