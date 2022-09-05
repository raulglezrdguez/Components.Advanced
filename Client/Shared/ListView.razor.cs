using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Components.Advanced.Client.Shared
{
    public partial class ListView<TItem>
    {
        [Parameter]
        public RenderFragment<TItem> ItemTemplate { get; set; } = default!;

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; } = default!;

    }
}