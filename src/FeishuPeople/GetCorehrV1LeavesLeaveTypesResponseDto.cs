// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1LeavesLeaveTypesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取假期类型列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取假期类型列表 响应体
/// <para>获取休假设置后台配置的假期类型列表（比如年假、事假、婚假等）。</para>
/// <para>接口ID：7126729166647885827</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_types</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_types</para>
/// </summary>
public record GetCorehrV1LeavesLeaveTypesResponseDto
{
    /// <summary>
    /// <para>假期类型列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("leave_type_list")]
    public LeaveType[]? LeaveTypeLists { get; set; }

    /// <summary>
    /// <para>假期类型列表</para>
    /// </summary>
    public record LeaveType
    {
        /// <summary>
        /// <para>假期类型ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonPropertyName("leave_type_id")]
        public string LeaveTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("leave_type_name")]
        public I18n[] LeaveTypeNames { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>假期类型名称</para>
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
        /// <para>假期类型状态</para>
        /// <para>可选值有：</para>
        /// <para>- 1：已启用</para>
        /// <para>- 2：已停用</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// <para>假期子类列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_subtype_list")]
        public LeaveSubtype[]? LeaveSubtypeLists { get; set; }

        /// <summary>
        /// <para>假期子类列表</para>
        /// </summary>
        public record LeaveSubtype
        {
            /// <summary>
            /// <para>假期子类ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：4718803945687580505</para>
            /// </summary>
            [JsonPropertyName("leave_type_id")]
            public string LeaveTypeId { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期子类名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("leave_type_name")]
            public I18n[] LeaveTypeNames { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>假期子类名称</para>
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
        }

        /// <summary>
        /// <para>假期类型的创建时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1658730384</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型的创建人，值为创建人的员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7104164629974646786</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型的更新时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1658996995</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型的更新人，值为更新人的员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7112112899636854812</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
