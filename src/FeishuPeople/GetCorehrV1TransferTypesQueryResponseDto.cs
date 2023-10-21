using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取异动类型列表 响应体
/// <para>获取异动类型列表。</para>
/// <para>接口ID：7086375306023911425</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2ftransfer_type%2fquery</para>
/// </summary>
public record GetCorehrV1TransferTypesQueryResponseDto
{
    /// <summary>
    /// <para>异动类型列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public TransferType[]? Items { get; set; }

    /// <summary>
    /// <para>异动类型列表</para>
    /// </summary>
    public record TransferType
    {
        /// <summary>
        /// <para>异动类型唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：internal_transfer</para>
        /// </summary>
        [JsonProperty("transfer_type_unique_identifier")]
        public string? TransferTypeUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动类型名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>异动类型名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonProperty("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>异动类型状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>关联流程唯一标识符</para>
        /// <para>必填：否</para>
        /// <para>示例值：people_6963913041981490725_6983885526583627531</para>
        /// </summary>
        [JsonProperty("flow_id")]
        public string? FlowId { get; set; }

        /// <summary>
        /// <para>关联流程名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("flow_name")]
        public I18n[]? FlowNames { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-06-2918:21:26</para>
        /// </summary>
        [JsonProperty("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-01-0717:20:51</para>
        /// </summary>
        [JsonProperty("updated_time")]
        public string? UpdatedTime { get; set; }
    }
}
