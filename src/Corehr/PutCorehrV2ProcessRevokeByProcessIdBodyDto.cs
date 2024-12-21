// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PutCorehrV2ProcessRevokeByProcessIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销流程 请求体
/// <para>撤销单个流程，状态为已完成的流程能够进行撤销，使用时需指定操作人，目前支持流程管理员和审批单管理员。</para>
/// <para>接口ID：7431231062508142593</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process_revoke/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_revoke%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessRevokeByProcessIdBodyDto
{
    /// <summary>
    /// <para>按照查询参数中指定的用户ID类型传递对应的用户ID，默认为Open ID。</para>
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
    /// <para>true-系统身份操作</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("system_user")]
    public bool? SystemUser { get; set; }
}
