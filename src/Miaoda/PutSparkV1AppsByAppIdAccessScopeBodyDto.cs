// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PutSparkV1AppsByAppIdAccessScopeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新妙搭应用可用范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 更新妙搭应用可用范围 请求体
/// <para>更新妙搭应用可用范围</para>
/// <para>接口ID：7642228089434868917</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/update_app_visibility</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fupdate_app_visibility</para>
/// </summary>
public record PutSparkV1AppsByAppIdAccessScopeBodyDto
{
    /// <summary>
    /// <para>仅 Scope = Range 时生效，授权用户 open_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public string[]? Users { get; set; }

    /// <summary>
    /// <para>仅 Scope = Range 时生效，授权部门 department_id 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public string[]? Departments { get; set; }

    /// <summary>
    /// <para>仅 Scope= Range 时生效，授权群聊 chat_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chats")]
    public string[]? Chats { get; set; }

    /// <summary>
    /// <para>申请访问配置（含审批人，仅支持单个用户 open_id）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("apply_config")]
    public ApplyConfigSuffix? ApplyConfig { get; set; }

    /// <summary>
    /// <para>申请访问配置（含审批人，仅支持单个用户 open_id）</para>
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
    /// <para>访问 Share URL 是否需要登录</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("require_login")]
    public bool? RequireLogin { get; set; }

    /// <summary>
    /// <para>可见范围类型：Public / Tenant / Range</para>
    /// <para>Public: 互联网公开可见</para>
    /// <para>Tenant: 组织内可见</para>
    /// <para>Range: 部分人员/部门/租户可见</para>
    /// <para>必填：是</para>
    /// <para>示例值：Range</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; } = string.Empty;
}
