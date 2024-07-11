// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV1UserVisibleAppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户可用的应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取用户可用的应用 响应体
/// <para>该接口用于查询用户可用的应用列表，只能被企业自建应用调用。</para>
/// <para>接口ID：6907569742384070658</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/obtain-the-apps-available-to-a-user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjM3UjLzIzN14yMycTN</para>
/// </summary>
public record GetApplicationV1UserVisibleAppsResponseDto
{
    /// <summary>
    /// <para>下一个请求页应当给的起始位置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>本次请求实际返回的页大小</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>可用的应用总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// <para>是否还有更多应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public int? HasMore { get; set; }

    /// <summary>
    /// <para>当前选择的版本语言</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    /// <summary>
    /// <para>应用列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_list")]
    public App[]? AppList { get; set; }

    /// <summary></summary>
    public record App
    {
        /// <summary>
        /// <para>应用 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// <para>应用首选语言</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("primary_language")]
        public string? PrimaryLanguage { get; set; }

        /// <summary>
        /// <para>应用名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>应用描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用 icon</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>应用类型，0：企业自建应用；1：应用商店应用</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_scene_type")]
        public int? AppSceneType { get; set; }

        /// <summary>
        /// <para>启停状态，0：停用；1：启用</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>移动端默认的应用功能，0：未开启；1：小程序；2：H5；8：机器人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile_default_ability")]
        public int? MobileDefaultAbility { get; set; }

        /// <summary>
        /// <para>PC客户端默认的应用功能，0：未开启；1：小程序；2：H5；8：机器人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("pc_default_ability")]
        public int? PcDefaultAbility { get; set; }
    }
}
