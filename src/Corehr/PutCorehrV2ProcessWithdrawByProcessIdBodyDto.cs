// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PutCorehrV2ProcessWithdrawByProcessIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤回流程 请求体
/// <para>对状态为“审批中”的单个审批实例进行撤回操作，撤回后审批流程结束</para>
/// <para>接口ID：7431231062508126209</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_withdraw%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessWithdrawByProcessIdBodyDto
{
    /// <summary>
    /// <para>按照查询参数中指定的用户ID类型传递对应的用户ID，默认为Open ID。如果system_user为true，此字段可不填</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_91791271921729102012</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：原因自定义字符串</para>
    /// <para>最大长度：500</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// <para>是否以系统身份操作，如果为false，则user_id必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("system_user")]
    public bool? SystemUser { get; set; }
}
