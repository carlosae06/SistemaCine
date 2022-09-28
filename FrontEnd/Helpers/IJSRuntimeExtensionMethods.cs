﻿using Microsoft.JSInterop;

namespace FrontEnd.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            return await  js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
