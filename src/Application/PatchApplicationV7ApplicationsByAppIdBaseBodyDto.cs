// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PatchApplicationV7ApplicationsByAppIdBaseBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用基础信息配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用基础信息配置 请求体
/// <para>通过该接口可更新自建应用的基础信息（名称、头像等），不传入的参数则保持不变，仅针对传入的参数则进行更新。如果应用正在审核中，则无法更新配置</para>
/// <para>接口ID：7621030901518584791</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-base/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-base%2fpatch</para>
/// </summary>
public record PatchApplicationV7ApplicationsByAppIdBaseBodyDto
{
    /// <summary>
    /// <para>应用名称描述多语种</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("i18ns")]
    public AppI18nInfo[]? I18ns { get; set; }

    /// <summary>
    /// <para>应用名称描述多语种</para>
    /// </summary>
    public record AppI18nInfo
    {
        /// <summary>
        /// <para>必填，国际化语言的 key</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh_cn</para>
        /// <para>可选值：<list type="bullet">
        /// <item>zh_cn：中文</item>
        /// <item>en_us：英文</item>
        /// <item>ja_jp：日文</item>
        /// <item>zh_hk：繁体中文(中国香港)</item>
        /// <item>zh_tw：繁体中文(中国台湾)</item>
        /// <item>id_id：印度尼西亚语</item>
        /// <item>ms_my：马来语</item>
        /// <item>de_de：德语</item>
        /// <item>es_es：西班牙语</item>
        /// <item>fr_fr：法语</item>
        /// <item>it_it：意大利语</item>
        /// <item>pt_br：葡萄牙语(巴西)</item>
        /// <item>vi_vn：越南语</item>
        /// <item>ru_ru：俄语</item>
        /// <item>th_th：泰语</item>
        /// <item>ko_kr：韩语</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("i18n_key")]
        public string I18nKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>i18n_key对应的应用国际化名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用名称</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>应用国际化描述（副标题）</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用描述</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>帮助国际化文档链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com</para>
        /// </summary>
        [JsonPropertyName("help_use")]
        public string? HelpUse { get; set; }
    }

    /// <summary>
    /// <para>应用icon图片链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://s3-imfile.feishucdn.com/static-resource/v1/v2_953a8fc1-50bd-4b2e-87e2-b09e47dba23g</para>
    /// <para>最大长度：512</para>
    /// </summary>
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// <para>应用管理后台url链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://open.feishu.cn/</para>
    /// <para>最大长度：512</para>
    /// </summary>
    [JsonPropertyName("homepage_url")]
    public string? HomepageUrl { get; set; }
}
