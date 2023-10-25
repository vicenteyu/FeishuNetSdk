using System.Net.Http.Headers;
using WebApiClientCore;

namespace FeishuNetSdk.Parameters
{
    public class HeaderRanges : IApiParameter
    {
        private readonly long? _from;
        private readonly long? _to;
        public HeaderRanges((long? from, long? to) ranges)
        {
            _from = ranges.from;
            _to = ranges.to;
        }

        public System.Threading.Tasks.Task OnRequestAsync(ApiParameterContext context)
        {
            context.HttpContext.RequestMessage.Headers.Range = new RangeHeaderValue(_from, _to);
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public static implicit operator HeaderRanges((long? from, long? to) ranges)
        {
            return new HeaderRanges(ranges);
        }

        public override string ToString()
        {
            return $"Range: bytes={_from}-{_to}";
        }
    }
}
