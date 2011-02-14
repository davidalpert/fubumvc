﻿using System.Collections.Generic;
using FubuFastPack.Querying;
using Microsoft.Practices.ServiceLocation;

namespace FubuFastPack.JqGrid
{
    public interface ISmartGrid
    {
        IGridDefinition Definition { get; }

        // TODO -- let's move this inside.  Could use, *gasp* Setter injection here
        GridResults Invoke(IServiceLocator services, GridDataRequest request);

        IEnumerable<FilteredProperty> AllFilteredProperties(IQueryService queryService);

        IEnumerable<IDictionary<string, object>> ToColumnModel();
        int Count(IServiceLocator services);
        string GetHeader();
    }
}