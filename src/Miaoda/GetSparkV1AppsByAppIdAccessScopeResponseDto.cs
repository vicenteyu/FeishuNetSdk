// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdAccessScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙搭应用可用范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取妙搭应用可用范围 响应体
/// <para>获取妙搭应用可用范围</para>
/// <para>接口ID：7642228089434885301</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/get_app_visibility</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fget_app_visibility</para>
/// </summary>
public record GetSparkV1AppsByAppIdAccessScopeResponseDto
{
    /// <summary>
    /// <para>当前可见范围类型，枚举值为 All / Tenant / Range</para>
    /// <para>必填：否</para>
    /// <para>示例值：Range</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// <para>仅 Scope=Range 时返回，授权用户 open_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public string[]? Users { get; set; }

    /// <summary>
    /// <para>仅 Scope=Range 时返回，授权部门 department_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public string[]? Departments { get; set; }

    /// <summary>
    /// <para>仅 Scope=Range 时返回，授权群聊 chat_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chats")]
    public string[]? Chats { get; set; }

    /// <summary>
    /// <para>ApplyConfig 当前申请访问配置（含审批人）；未启用申请时为 nil</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"enabled":true,"approvers":["ou_1234567890abcdef1234567890abcdef"]}</para>
    /// </summary>
    [JsonPropertyName("apply_config")]
    public ApplyConfigSuffix? ApplyConfig { get; set; }

    /// <summary>
    /// <para>ApplyConfig 当前申请访问配置（含审批人）；未启用申请时为 nil</para>
    /// </summary>
    public record ApplyConfigSuffix
    {
        /// <summary>
        /// <para>控制审批流程是否启用。设为true时，提交申请后将触发配置的审批流程；设为false时，申请将直接通过无需审批。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>仅支持配置一个用户 open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approvers")]
        public string[]? Approvers { get; set; }
    }

    /// <summary>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("require_login")]
    public bool? RequireLogin { get; set; }
}
