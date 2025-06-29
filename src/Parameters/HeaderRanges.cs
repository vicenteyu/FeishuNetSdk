﻿// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="HeaderRanges.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using System.Net.Http.Headers;
using WebApiClientCore;

namespace FeishuNetSdk.Parameters
{
    /// <summary></summary>
    public class HeaderRanges((long? from, long? to) ranges) : IApiParameter
    {
        private readonly long? _from = ranges.from;
        private readonly long? _to = ranges.to;

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
