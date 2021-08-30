using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace CorsoBlazor.Components
{
    public partial class DismissableAlert
    {
        private bool show;
        [Parameter]
        public bool Show
        {
            get => this.show;
            set
            {
                if (value != this.show)
                {
                    this.show = value;
                    ShowChanged.InvokeAsync(this.show);
                }
            }
        }
        [Parameter]
        public EventCallback<bool> ShowChanged { get; set; }

        //public Action<bool> ShowChanged { get; set; }


        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public void Dismiss()
            => Show = false;
    }
}
