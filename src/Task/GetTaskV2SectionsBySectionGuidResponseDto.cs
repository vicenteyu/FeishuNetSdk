// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV2SectionsBySectionGuidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自定义分组详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取自定义分组详情 响应体
/// <para>获取一个自定义分组详情，包括名称，创建人等信息。如果该自定义分组归属于一个清单，还会返回清单的摘要信息。</para>
/// <para>接口ID：7259330038033825820</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fget</para>
/// </summary>
public record GetTaskV2SectionsBySectionGuidResponseDto
{
    /// <summary>
    /// <para>获取的自定义分组详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("section")]
    public GetTaskV2SectionsBySectionGuidResponseDtoSection? Section { get; set; }

    /// <summary>
    /// <para>获取的自定义分组详情</para>
    /// </summary>
    public record GetTaskV2SectionsBySectionGuidResponseDtoSection
    {
        /// <summary>
        /// <para>自定义分组的GUID</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>自定义分组的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：已经评审过的任务</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>资源类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：tasklist</para>
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>分组是否为默认自定义分组</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>自定义分组的创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>自定义分组的创建者</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：creator</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>如果该分组归属于清单，展示清单的简要信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasklist")]
        public TasklistSummary? Tasklist { get; set; }

        /// <summary>
        /// <para>如果该分组归属于清单，展示清单的简要信息</para>
        /// </summary>
        public record TasklistSummary
        {
            /// <summary>
            /// <para>清单GUID</para>
            /// <para>必填：否</para>
            /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
            /// </summary>
            [JsonPropertyName("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>清单名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：活动分工任务列表</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>自定义分组创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>自定义分组最近一次更新时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
