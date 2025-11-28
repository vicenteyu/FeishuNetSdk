// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量开启系统状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.PersonalSettings;
/// <summary>
/// 批量开启系统状态 请求体
/// <para>批量开启用户系统状态可用。</para>
/// <para>接口ID：7161608966368772099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_open</para>
/// </summary>
public record PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenBodyDto
{
    /// <summary>
    /// <para>开启列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("user_list")]
    public SystemStatusUserOpenParam[] UserLists { get; set; } = [];

    /// <summary>
    /// <para>开启列表</para>
    /// </summary>
    public record SystemStatusUserOpenParam
    {
        /// <summary>
        /// <para>用户ID，传入的ID类型由user_id_type决定，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_53edd3282dbc2fdbe5c593cfa5ce82ab</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>结束时间，传入的应为秒单位的时间戳，距当前的时间跨度不能超过365天。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1665990378</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;
    }
}
