﻿using AzureAIContentSafety.Helpers;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace AzureAIContentSafety.Models.AzureAIContentSafety
{
    public class BlockListSelectionFactory : ISelectionFactory
    {
        private Injected<OptimizelyCmsHelpers> _optimizelyCMSHelpers;

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var result = new List<ISelectItem>();

            var searchResult = _optimizelyCMSHelpers.Service.GetTextBlockListsCMS();
            if (searchResult.Any())
            {
                foreach (var search in searchResult)
                {
                    result.Add(new SelectItem() { Text = search.Description, Value = search.BlocklistName });
                }

                return result;
            }
            result.Add(new SelectItem() { Text = "-- No Blocklists --", Value = null });
            return result;
        }
    }
}