﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    /// <summary>
    /// Partial class to add the EventData attribute and any additional customizations to the generated type.
    /// </summary>
#if NET40
    [Microsoft.Diagnostics.Tracing.EventData(Name = "PartB_PageViewPerfData")]
#else
    [System.Diagnostics.Tracing.EventData(Name = "PartB_PageViewPerfData")]
#endif
    internal partial class PageViewPerfData
    {
    }
}