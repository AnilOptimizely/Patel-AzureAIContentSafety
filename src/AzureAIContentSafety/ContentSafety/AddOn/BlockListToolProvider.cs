﻿using EPiServer.Authorization;
using EPiServer.Shell.Navigation;

namespace AzureAIContentSafety.ContentSafety.AddOn
{
    [MenuProvider]
    public class BlockListToolProvider : IMenuProvider
    {
        public IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new UrlMenuItem("Azure Content Safety - BlockList",
                MenuPaths.Global + "/cms" + "/blocklist",
                "/AzureContentSafetyBlockList")
            {
                SortIndex = SortIndex.Last + 25,
                AuthorizationPolicy = CmsPolicyNames.CmsAdmin
            });
            return menuItems;
        }
    }
}
