using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace Components.Advanced.Client.Shared
{
    public partial class Grid<TItem>
    {
        [Parameter]
        public RenderFragment Header { get; set; } = default!;

        [Parameter]
        public RenderFragment<TItem> Row { get; set; } = default!;

        [Parameter]
        public RenderFragment Footer { get; set; } = default!;

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; } = default!;
    }
}