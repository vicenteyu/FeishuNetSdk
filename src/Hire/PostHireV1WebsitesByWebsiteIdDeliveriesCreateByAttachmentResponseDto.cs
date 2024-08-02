// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentResponseDtonsAddRoleAssignBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据简历附件创建招聘官网投递任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 根据简历附件创建招聘官网投递任务 响应体
/// <para>根据简历附件创建招聘官网投递任务，创建投递的最终结果请通过[获取招聘官网投递任务结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery_task/get)获取。</para>
/// <para>接口ID：7097131869725179905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_attachment</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentResponseDto
{
    /// <summary>
    /// <para>异步任务 ID，可根据此 ID 通过[获取招聘官网投递任务结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery_task/get)查询最终的投递结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：f1c2a0f138ec492d99d7ab73594158ad</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
