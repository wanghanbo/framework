﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Views
{
    using System;
    using System.Collections.Generic;
    
    #line 3 "..\..\Signum\Views\SearchControl.cshtml"
    using System.Configuration;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Engine.DynamicQuery;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/SearchControl.cshtml")]
    public partial class SearchControl : System.Web.Mvc.WebViewPage<Context>
    {
        public SearchControl()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Signum\Views\SearchControl.cshtml"
   
    Model.ReadOnly = false; /*SearchControls Context should never inherit Readonly property of parent context */
    FindOptions findOptions = (FindOptions)ViewData[ViewDataKeys.FindOptions];
    QueryDescription queryDescription = (QueryDescription)ViewData[ViewDataKeys.QueryDescription];
    var entityColumn = queryDescription.Columns.SingleEx(a => a.IsEntity);
    Type entitiesType = Lite.Extract(entityColumn.Type);
    Implementations implementations = entityColumn.Implementations.Value;
    findOptions.Pagination = findOptions.Pagination ?? (Navigator.Manager.QuerySettings.GetOrThrow(findOptions.QueryName, "Missing QuerySettings for QueryName {0}").Pagination) ?? FindOptions.DefaultPagination;

    ViewData[ViewDataKeys.FindOptions] = findOptions;

    var prefix = Model.Compose("sfSearchControl");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 990), Tuple.Create("\"", 1002)
            
            #line 19 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 995), Tuple.Create<System.Object, System.Int32>(prefix
            
            #line default
            #line hidden
, 995), false)
);

WriteLiteral(" \r\n     class=\"sf-search-control SF-control-container\"");

WriteLiteral(" \r\n     data-prefix=\"");

            
            #line 21 "..\..\Signum\Views\SearchControl.cshtml"
             Write(Model.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n     data-find-url=\"");

            
            #line 22 "..\..\Signum\Views\SearchControl.cshtml"
               Write(Navigator.FindRoute(findOptions.QueryName));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n     >\r\n\r\n");

WriteLiteral("    ");

            
            #line 25 "..\..\Signum\Views\SearchControl.cshtml"
Write(Html.Hidden(Model.Compose("sfEntityTypeNames"),
                                implementations.IsByAll ? EntityBase.ImplementedByAllKey :
                                implementations.Types.ToString(t => Navigator.ResolveWebTypeName(t), ","), new { disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 28 "..\..\Signum\Views\SearchControl.cshtml"
Write(Html.Hidden(Model.Compose("sfEntityTypeNiceNames"),
                                implementations.IsByAll ? EntityBase.ImplementedByAllKey :
                                implementations.Types.ToString(t => t.NiceName(), ","), new { disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

            
            #line 33 "..\..\Signum\Views\SearchControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 33 "..\..\Signum\Views\SearchControl.cshtml"
      
        bool filtersAlwaysHidden = findOptions.FilterMode == FilterMode.AlwaysHidden || findOptions.FilterMode == FilterMode.OnlyResults;
        bool filtersVisible = findOptions.FilterMode == FilterMode.Visible;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteAttribute("style", Tuple.Create(" style=\"", 1972), Tuple.Create("\"", 2029)
, Tuple.Create(Tuple.Create("", 1980), Tuple.Create("display:", 1980), true)
            
            #line 38 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(filtersAlwaysHidden ? "none" : "block"
            
            #line default
            #line hidden
, 1988), false)
);

WriteLiteral(">\r\n        <div");

WriteAttribute("id", Tuple.Create(" id=\"", 2045), Tuple.Create("\"", 2084)
            
            #line 39 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create<System.Object, System.Int32>(Model.Compose("tblFilterBuilder")
            
            #line default
            #line hidden
, 2050), false)
);

WriteLiteral(" class=\"ui-widget sf-filters\"");

WriteLiteral(" ");

            
            #line 39 "..\..\Signum\Views\SearchControl.cshtml"
                                                                              Write(filtersVisible ? "" : "style=display:none");

            
            #line default
            #line hidden
WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui-widget-header ui-corner-top sf-filters-body\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Signum\Views\SearchControl.cshtml"
           Write(Html.QueryTokenBuilder(null, Model, SearchControlHelper.GetQueryTokenBuilderSettings(queryDescription)));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Signum\Views\SearchControl.cshtml"
           Write(Html.Href(
                            Model.Compose("btnAddFilter"),
                            SearchMessage.FilterBuilder_AddFilter.NiceToString(),
                            "",
                            JavascriptMessage.selectToken.NiceToString(),
                            "sf-query-button sf-add-filter sf-disabled",
                            new Dictionary<string, object> 
                            { 
                                { "data-icon", "ui-icon-arrowthick-1-s" }
                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 54 "..\..\Signum\Views\SearchControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 54 "..\..\Signum\Views\SearchControl.cshtml"
                 if (string.IsNullOrEmpty(Model.Prefix) && findOptions.AllowChangeColumns)
                {
                    
            
            #line default
            #line hidden
            
            #line 56 "..\..\Signum\Views\SearchControl.cshtml"
               Write(Html.Href(
                            Model.Compose("btnAddColumn"),
                            SearchMessage.FilterBuilder_AddColumn.NiceToString(),
                            "",
                            JavascriptMessage.selectToken.NiceToString(),
                            "sf-query-button sf-add-column sf-disabled",
                            new Dictionary<string, object> 
                            { 
                                { "data-icon", "ui-icon-arrowthick-1-e" },
                                { "data-url", Url.Action("GetColumnName", "Finder") }
                            }));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Signum\Views\SearchControl.cshtml"
                              
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 69 "..\..\Signum\Views\SearchControl.cshtml"
            
            
            #line default
            #line hidden
            
            #line 69 "..\..\Signum\Views\SearchControl.cshtml"
               
                ViewData[ViewDataKeys.FilterOptions] = findOptions.FilterOptions;
                Html.RenderPartial(Navigator.Manager.FilterBuilderView); 
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n");

            
            #line 77 "..\..\Signum\Views\SearchControl.cshtml"
 if (!filtersAlwaysHidden)
{
    
            
            #line default
            #line hidden
            
            #line 79 "..\..\Signum\Views\SearchControl.cshtml"
Write(Html.Href("",
                (filtersVisible ? JavascriptMessage.hideFilters.NiceToString() : JavascriptMessage.showFilters.NiceToString()),
                "",
                (filtersVisible ? JavascriptMessage.hideFilters.NiceToString() : JavascriptMessage.showFilters.NiceToString()),
                "sf-query-button sf-filters-header" + (filtersVisible ? "" : " close"),
                new Dictionary<string, object> 
                { 
                    { "onclick", JsFunction.SFControlThen(prefix,  "toggleFilters()") },
                    { "data-icon", filtersVisible ? "ui-icon-triangle-1-n" : "ui-icon-triangle-1-e" }
                }));

            
            #line default
            #line hidden
            
            #line 88 "..\..\Signum\Views\SearchControl.cshtml"
                  
}

            
            #line default
            #line hidden
            
            #line 90 "..\..\Signum\Views\SearchControl.cshtml"
 if (findOptions.FilterMode != FilterMode.OnlyResults && (bool?)ViewData[ViewDataKeys.InPopup] != true)
{ 
    
            
            #line default
            #line hidden
            
            #line 92 "..\..\Signum\Views\SearchControl.cshtml"
Write(Html.Href(Model.Compose("sfFullScreen"),
            "Full Screen",
            "",
            "Full Screen",
            "sf-query-button sf-query-fullscreen",
            new Dictionary<string, object> 
            { 
                { "data-icon", "ui-icon-extlink" },
                { "data-text", false }
            }));

            
            #line default
            #line hidden
            
            #line 101 "..\..\Signum\Views\SearchControl.cshtml"
              
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-query-button-bar\"");

WriteAttribute("style", Tuple.Create(" style=\"", 5127), Tuple.Create("\"", 5215)
, Tuple.Create(Tuple.Create("", 5135), Tuple.Create("display:", 5135), true)
            
            #line 104 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 5143), Tuple.Create<System.Object, System.Int32>((findOptions.FilterMode != FilterMode.OnlyResults) ? "block" : "none"
            
            #line default
            #line hidden
, 5143), false)
);

WriteLiteral(">\r\n    <button");

WriteLiteral(" class=\"sf-query-button sf-search\"");

WriteLiteral(" data-icon=\"ui-icon-search\"");

WriteAttribute("id", Tuple.Create(" id=\"", 5291), Tuple.Create("\"", 5322)
            
            #line 105 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 5296), Tuple.Create<System.Object, System.Int32>(Model.Compose("qbSearch")
            
            #line default
            #line hidden
, 5296), false)
);

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5323), Tuple.Create("\"", 5402)
, Tuple.Create(Tuple.Create("", 5333), Tuple.Create("event.preventDefault();", 5333), true)
            
            #line 105 "..\..\Signum\Views\SearchControl.cshtml"
                                                         , Tuple.Create(Tuple.Create(" ", 5356), Tuple.Create<System.Object, System.Int32>(JsFunction.SFControlThen(prefix, "search()")
            
            #line default
            #line hidden
, 5357), false)
);

WriteLiteral(">");

            
            #line 105 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                                                                                                                    Write(SearchMessage.Search.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 106 "..\..\Signum\Views\SearchControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 106 "..\..\Signum\Views\SearchControl.cshtml"
     if (findOptions.Create)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" class=\"sf-query-button\"");

WriteLiteral(" data-icon=\"ui-icon-plusthick\"");

WriteLiteral(" data-text=\"false\"");

WriteAttribute("id", Tuple.Create(" id=\"", 5570), Tuple.Create("\"", 5607)
            
            #line 108 "..\..\Signum\Views\SearchControl.cshtml"
       , Tuple.Create(Tuple.Create("", 5575), Tuple.Create<System.Object, System.Int32>(Model.Compose("qbSearchCreate")
            
            #line default
            #line hidden
, 5575), false)
);

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5608), Tuple.Create("\"", 5692)
, Tuple.Create(Tuple.Create("", 5618), Tuple.Create("event.preventDefault();", 5618), true)
            
            #line 108 "..\..\Signum\Views\SearchControl.cshtml"
                                                                         , Tuple.Create(Tuple.Create("", 5641), Tuple.Create<System.Object, System.Int32>(JsFunction.SFControlThen(prefix, "create_click()")
            
            #line default
            #line hidden
, 5641), false)
);

WriteLiteral(">");

            
            #line 108 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                                                                                                                                         Write(SearchMessage.Create.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 109 "..\..\Signum\Views\SearchControl.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 110 "..\..\Signum\Views\SearchControl.cshtml"
Write(ButtonBarQueryHelper.GetButtonBarElementsForQuery(new QueryButtonContext
       {
           Url = Url,
           ControllerContext = this.ViewContext,
           QueryName = findOptions.QueryName,
           ManualQueryButtons = (ToolBarButton[])ViewData[ViewDataKeys.ManualToolbarButtons],
           EntityType = entitiesType,
           Prefix = Model.Prefix
       }).ToString(Html));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 120 "..\..\Signum\Views\SearchControl.cshtml"
 if (findOptions.FilterMode != FilterMode.OnlyResults)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clearall\"");

WriteLiteral(">\r\n    </div>\r\n");

            
            #line 124 "..\..\Signum\Views\SearchControl.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteAttribute("id", Tuple.Create(" id=\"", 6260), Tuple.Create("\"", 6293)
            
            #line 125 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 6265), Tuple.Create<System.Object, System.Int32>(Model.Compose("divResults")
            
            #line default
            #line hidden
, 6265), false)
);

WriteLiteral(" class=\"ui-widget ui-corner-all sf-search-results-container\"");

WriteLiteral(">\r\n    <table");

WriteAttribute("id", Tuple.Create(" id=\"", 6367), Tuple.Create("\"", 6400)
            
            #line 126 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 6372), Tuple.Create<System.Object, System.Int32>(Model.Compose("tblResults")
            
            #line default
            #line hidden
, 6372), false)
);

WriteLiteral(" class=\"sf-search-results\"");

WriteLiteral(">\r\n        <thead");

WriteLiteral(" class=\"ui-widget-header ui-corner-top\"");

WriteLiteral(">\r\n            <tr>\r\n");

            
            #line 129 "..\..\Signum\Views\SearchControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 129 "..\..\Signum\Views\SearchControl.cshtml"
                 if (findOptions.AllowSelection)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"ui-state-default sf-th-selection\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 132 "..\..\Signum\Views\SearchControl.cshtml"
                   Write(Html.CheckBox(Model.Compose("cbSelectAll"), false, new { onclick = JsFunction.SFControlThen(prefix, "toggleSelectAll()") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n");

            
            #line 134 "..\..\Signum\Views\SearchControl.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 135 "..\..\Signum\Views\SearchControl.cshtml"
                 if (findOptions.Navigate)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"ui-state-default sf-th-entity\"");

WriteLiteral("></th>\r\n");

            
            #line 138 "..\..\Signum\Views\SearchControl.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 139 "..\..\Signum\Views\SearchControl.cshtml"
                  List<Column> columns = findOptions.MergeColumns(); 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 140 "..\..\Signum\Views\SearchControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 140 "..\..\Signum\Views\SearchControl.cshtml"
                 foreach (var col in columns)
                {
                    var order = findOptions.OrderOptions.FirstOrDefault(oo => oo.Token.FullKey() == col.Name);
                    OrderType? orderType = null;
                    if (order != null)
                    {
                        orderType = order.OrderType;
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteAttribute("class", Tuple.Create(" class=\"", 7450), Tuple.Create("\"", 7585)
, Tuple.Create(Tuple.Create("", 7458), Tuple.Create("ui-state-default", 7458), true)
            
            #line 148 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create(" ", 7474), Tuple.Create<System.Object, System.Int32>((orderType == null) ? "" : (orderType == OrderType.Ascending ? "sf-header-sort-down" : "sf-header-sort-up")
            
            #line default
            #line hidden
, 7475), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"sf-header-droppable sf-header-droppable-right\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"sf-header-droppable sf-header-droppable-left\"");

WriteLiteral("></div>\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7814), Tuple.Create("\"", 7831)
            
            #line 151 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 7822), Tuple.Create<System.Object, System.Int32>(col.Name
            
            #line default
            #line hidden
, 7822), false)
);

WriteLiteral(" />\r\n                        <span>");

            
            #line 152 "..\..\Signum\Views\SearchControl.cshtml"
                         Write(col.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </th>\r\n");

            
            #line 154 "..\..\Signum\Views\SearchControl.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"ui-widget-content\"");

WriteLiteral(">\r\n");

            
            #line 158 "..\..\Signum\Views\SearchControl.cshtml"
            
            
            #line default
            #line hidden
            
            #line 158 "..\..\Signum\Views\SearchControl.cshtml"
               int columnsCount = columns.Count + (findOptions.Navigate ? 1 : 0) + (findOptions.AllowSelection ? 1 : 0); 
            
            #line default
            #line hidden
WriteLiteral("\r\n            <tr>\r\n                <td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 8179), Tuple.Create("\"", 8202)
            
            #line 160 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 8189), Tuple.Create<System.Object, System.Int32>(columnsCount
            
            #line default
            #line hidden
, 8189), false)
);

WriteLiteral(">");

            
            #line 160 "..\..\Signum\Views\SearchControl.cshtml"
                                       Write(JavascriptMessage.noResults.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 162 "..\..\Signum\Views\SearchControl.cshtml"
            
            
            #line default
            #line hidden
            
            #line 162 "..\..\Signum\Views\SearchControl.cshtml"
               
                ViewData[ViewDataKeys.Pagination] = findOptions.Pagination;
                ViewData[ViewDataKeys.FilterMode] = findOptions.FilterMode;
                ViewData[ViewDataKeys.SearchControlColumnsCount] = columnsCount;
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 167 "..\..\Signum\Views\SearchControl.cshtml"
       Write(Html.Partial(Navigator.Manager.PaginationSelectorView, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    require([\"");

            
            #line 173 "..\..\Signum\Views\SearchControl.cshtml"
         Write(JsFunction.FinderModule);

            
            #line default
            #line hidden
WriteLiteral("\"], function(Finder) { new Finder.SearchControl($(\"#");

            
            #line 173 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                     Write(Model.Compose("sfSearchControl"));

            
            #line default
            #line hidden
WriteLiteral("\"), ");

            
            #line 173 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                                                           Write(MvcHtmlString.Create(findOptions.ToJS(Model.Prefix).ToString()));

            
            #line default
            #line hidden
WriteLiteral(").ready();});\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
