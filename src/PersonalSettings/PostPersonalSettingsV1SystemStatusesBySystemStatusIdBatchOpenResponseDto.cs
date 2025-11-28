// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量开启系统状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.PersonalSettings;
/// <summary>
/// 批量开启系统状态 响应体
/// <para>批量开启用户系统状态可用。</para>
/// <para>接口ID：7161608966368772099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_open</para>
/// </summary>
public record PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenResponseDto
{
    /// <summary>
    /// <para>开启结果</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("result_list")]
    public SystemStatusUserOpenResultEntity[] ResultLists { get; set; } = [];

    /// <summary>
    /// <para>开启结果</para>
    /// </summary>
    public record SystemStatusUserOpenResultEntity
    {
        /// <summary>
        /// <para>用户ID</para>
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

        /// <summary>
        /// <para>开启结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：success_show</para>
        /// <para>可选值：<list type="bullet">
        /// <item>success_show：成功且在客户端展示</item>
        /// <item>success_user_close_syn：成功但是用户设置了默认不开启</item>
        /// <item>success_user_in_higher_priority_system_status：成功但是用户存在更高优先级的系统状态</item>
        /// <item>fail：失败</item>
        /// <item>invisible_user_id：用户ID不可见</item>
        /// <item>invalid_user_id：用户ID无效</item>
        /// <item>resign_user_id：用户离职</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
