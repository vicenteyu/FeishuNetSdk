// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-30
// ************************************************************************
// <copyright file="GetCorehrV1SecurityGroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取角色列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量获取角色列表 响应体
/// <para>用于查询飞书人事中的角色列表（对应[飞书人事管理后台](https://people.feishu.cn/people/) - 设置 - 权限设置 - 角色设置中的角色列表），列表内包含角色 ID、名称、状态以及描述等信息。</para>
/// <para>接口ID：7088513302561128449</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2flist</para>
/// </summary>
public record GetCorehrV1SecurityGroupsResponseDto : IPageableResponse<GetCorehrV1SecurityGroupsResponseDto.SecurityGroup>
{
    /// <summary>
    /// <para>查询的用户角色信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SecurityGroup[]? Items { get; set; }

    /// <summary>
    /// <para>查询的用户角色信息</para>
    /// </summary>
    public record SecurityGroup
    {
        /// <summary>
        /// <para>角色ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7034393015968122400</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>角色code，通常用于与其他系统进行交互</para>
        /// <para>必填：是</para>
        /// <para>示例值：department_manager</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>角色名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public SecurityGroupName? Name { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// </summary>
        public record SecurityGroupName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>状态，可能值有：</para>
        /// <para>- 1 = Inactive / 停用</para>
        /// <para>- 2 = Active / 启用</para>
        /// <para>- 3 = TobeActivated / 待启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int ActiveStatus { get; set; }

        /// <summary>
        /// <para>角色描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public NameSuffix? Description { get; set; }

        /// <summary>
        /// <para>角色描述</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>角色类型</para>
        /// <para>- 3 = 组织类角色</para>
        /// <para>- 7 = 非组织类角色</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("group_type")]
        public int GroupType { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>- 返回"sys"时，表示角色是系统创建角色</para>
        /// <para>- 返回用户ID时，表示是角色是用户自定义角色，可以使用 [ID转换服务](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert) 换取 飞书人事的employment_id</para>
        /// <para>必填：是</para>
        /// <para>示例值：6967639606963471902</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>组织管理维度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("org_truncation")]
        public OrgTruncation[]? OrgTruncations { get; set; }

        /// <summary>
        /// <para>组织管理维度</para>
        /// </summary>
        public record OrgTruncation
        {
            /// <summary>
            /// <para>组织管理维度名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：department</para>
            /// </summary>
            [JsonPropertyName("org_key")]
            public string? OrgKey { get; set; }

            /// <summary>
            /// <para>下钻类型</para>
            /// <para>- 0 = 对当前管理维度及下级管理维度均有权限</para>
            /// <para>- 1 = 只对当前管理维度有权限，不包含其下级管理维度</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>下钻深度</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("depth")]
            public int? Depth { get; set; }
        }
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
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
