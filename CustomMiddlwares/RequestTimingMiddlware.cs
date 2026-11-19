using System.Diagnostics;

namespace MVC___Session_1.CustomMiddlwares
{
    public class RequestTimingMiddlware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddlware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();

            // Next
            await _next(context);

            watch.Stop();

            Console.WriteLine($"[[{context.Request.Path}]] :: {watch.ElapsedMilliseconds} ms");
        }
    }
}