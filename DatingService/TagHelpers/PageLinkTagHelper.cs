using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using DatingService.Infrastructure.ViewModels;

namespace DatingService.TagHelpers
{
    public class PageLinkTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory _urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            _urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel Model { get; set; }
        public string Action { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "action-")]
        public Dictionary<string, object> ActionValues { get; set; } = new();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";

            TagBuilder tag = new ("ul");
            tag.AddCssClass("pagination");

            TagBuilder currentItem = CreateTag(urlHelper, Model.PageNumber);

            if (Model.HasPreviousPage)
            {
                TagBuilder prevItem = CreateTag(urlHelper, Model.PageNumber - 1);
                tag.InnerHtml.AppendHtml(prevItem);
            }

            tag.InnerHtml.AppendHtml(currentItem);

            if (Model.HasNextPage)
            {
                TagBuilder nextItem = CreateTag(urlHelper, Model.PageNumber + 1);
                tag.InnerHtml.AppendHtml(nextItem);
            }
            output.Content.AppendHtml(tag);
        }


        private TagBuilder CreateTag(IUrlHelper urlHelper, int value, string view = null)
        {
            var item = new TagBuilder("li");
            var link = new TagBuilder("a");

            if (value == Model.PageNumber)
            {
                item.AddCssClass("active");
            }
            else
            {
                ActionValues["page"] = value;
                link.Attributes["href"] = urlHelper.Action(Action, ActionValues);
            }

            item.AddCssClass("page-item");
            link.AddCssClass("page-link");

            link.InnerHtml.Append(view ?? value.ToString());
            item.InnerHtml.AppendHtml(link);

            return item;
        }
    }
}
