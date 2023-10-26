using System.Net.Http.Headers;
using WebApiClientCore;

namespace FeishuNetSdk.Parameters
{
    /// <summary></summary>
    public class HeaderRanges : IApiParameter
    {
        private readonly long? _from;
        private readonly long? _to;
        /// <summary></summary>
        public HeaderRanges((long? from, long? to) ranges)
        {
            _from = ranges.from;
            _to = ranges.to;
        }

        /// <summary></summary>
        public System.Threading.Tasks.Task OnRequestAsync(ApiParameterContext context)
        {
            context.HttpContext.RequestMessage.Headers.Range = new RangeHeaderValue(_from, _to);
            return System.Threading.Tasks.Task.CompletedTask;
        }

        /// <summary></summary>
        public static implicit operator HeaderRanges((long? from, long? to) ranges)
        {
            return new HeaderRanges(ranges);
        }

        /// <summary></summary>
        public override string ToString()
        {
            return $"Range: bytes={_from}-{_to}";
        }
    }
}
