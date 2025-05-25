// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-20
// ************************************************************************
// <copyright file="GetApplicationV3AppListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取企业安装的应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取企业安装的应用 响应体
/// <para>该接口用于查询企业安装的应用列表，只能被企业自建应用调用。</para>
/// <para>该接口为旧版获取企业安装应用接口。推荐使用新版接口[获取企业安装的应用](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application/list)。</para>
/// <para>接口ID：6907569744330555393</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/obtain-the-apps-installed-by-an-organization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDN3UjL2QzN14iN0cTN</para>
/// </summary>
public record GetApplicationV3AppListResponseDto : IPageableResponse<GetApplicationV3AppListResponseDto.App>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public App[]? Items => AppList;

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
    public int? HasMore1 { get; set; }

    /// <inheritdoc/>
    [JsonIgnore]
    public bool? HasMore { get { return HasMore1 == 1; } set { HasMore1 = value == true ? 1 : 0; } }

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

        /// <summary>
        /// <para>应用创建来源：`developer_console`：开发者后台；`base`：多维表格自动化流程创建的应用；`app_engine`：飞书应用引擎；`bot_builder`：机器人助手；`aily`：aily(智能伙伴搭建平台)；`unknown`：未知来源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_source")]
        public string? CreateSource { get; set; }
    }
}
