﻿using Azure.AI.ContentSafety;
using AzureAIContentSafety.ContentSafety.Models;
using AzureAIContentSafety.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureAIContentSafety.ContentSafety.Attributes
{
    public class TextAnalysisAttribute : ContentSafetyBaseContentAttribute
    {
        public override bool AnalyzeCMSContent => true;

        public override void UpdateContent(AnalyzeTextResult analyseContentSafetyTextResult, AzureAIContentSafetyService azureAIContentSafetyService, ContentPropertyAccess contentPropertyAccess)
        {
            
        }
    }
}
