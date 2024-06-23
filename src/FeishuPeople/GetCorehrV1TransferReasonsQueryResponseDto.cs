// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1TransferReasonsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取异动原因列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取异动原因列表 响应体
/// <para>获取异动原因列表。</para>
/// <para>接口ID：7086375306023895041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2ftransfer_reason%2fquery</para>
/// </summary>
public record GetCorehrV1TransferReasonsQueryResponseDto
{
    /// <summary>
    /// <para>异动原因列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TransferReason[]? Items { get; set; }

    /// <summary>
    /// <para>异动原因列表</para>
    /// </summary>
    public record TransferReason
    {
        /// <summary>
        /// <para>异动原因唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：voluntary_transfer</para>
        /// </summary>
        [JsonPropertyName("transfer_reason_unique_identifier")]
        public string? TransferReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动原因的名称信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>异动原因的名称信息</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>异动原因状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>上级异动原因唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：reason_for_job_change_option25</para>
        /// </summary>
        [JsonPropertyName("parent_transfer_reason_unique_identifier")]
        public string? ParentTransferReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-0420:30:47</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-02-2816:27:56</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }
    }
}
