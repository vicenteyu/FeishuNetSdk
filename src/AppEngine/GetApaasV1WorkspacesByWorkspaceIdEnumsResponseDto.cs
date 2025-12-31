// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-31
//
// Last Modified By : yxr
// Last Modified On : 2025-12-31
// ************************************************************************
// <copyright file="GetApaasV1WorkspacesByWorkspaceIdEnumsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作空间下的自定义枚举列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取工作空间下的自定义枚举列表 响应体
/// <para>获取工作空间下的自定义枚举列表</para>
/// <para>接口ID：7587254819414035669</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-enum/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-enum%2flist</para>
/// </summary>
public record GetApaasV1WorkspacesByWorkspaceIdEnumsResponseDto : IPageableResponse<GetApaasV1WorkspacesByWorkspaceIdEnumsResponseDto.WorkspaceEnum>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>枚举列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkspaceEnum[] Items { get; set; } = [];

    /// <summary>
    /// <para>枚举列表</para>
    /// </summary>
    public record WorkspaceEnum
    {
        /// <summary>
        /// <para>枚举名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：enum_demo</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>枚举描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：enum_demo的描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>枚举值列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：99999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("options")]
        public string[] Options { get; set; } = [];

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1765524810744</para>
        /// <para>最大值：9765524810744</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public WorkspaceUserInfo CreatedBy { get; set; } = new();

        /// <summary>
        /// <para>创建人</para>
        /// </summary>
        public record WorkspaceUserInfo
        {
            /// <summary>
            /// <para>用户 id，如 1693861178143800</para>
            /// <para>必填：是</para>
            /// <para>示例值：1693861178143800</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>用户姓名，如王小小</para>
            /// <para>必填：是</para>
            /// <para>示例值：王小小</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>用户头像 URL</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://xxx.image_url.com</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; } = string.Empty;
        }
    }
}
