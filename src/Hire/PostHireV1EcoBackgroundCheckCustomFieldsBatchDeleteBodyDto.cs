// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoBackgroundCheckCustomFieldsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除背调自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除背调自定义字段 请求体
/// <para>删除用户在发起背调时展示的表单自定义字段。</para>
/// <para>接口ID：7195815979079565313</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_custom_field/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_custom_field%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoBackgroundCheckCustomFieldsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>背调账号 ID，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6995842370159937061</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;
}
