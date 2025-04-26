// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4ApprovalsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批定义 响应体
/// <para>该接口用于创建审批定义，可以灵活指定审批定义的基础信息、表单和流程等。</para>
/// <para>## 使用限制</para>
/// <para>通过该 API 创建的审批定义，无法从审批管理后台或以 API 方式停用、删除，请谨慎调用。不推荐企业自建应用使用该 API 创建审批定义，如有需要，尽量联系企业管理员[在审批管理后台创建定义](https://www.feishu.cn/hc/zh-CN/articles/360040241113-%E7%AE%A1%E7%90%86%E5%91%98%E5%88%9B%E5%BB%BA%E5%AE%A1%E6%89%B9)。</para>
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
public record PostApprovalV4ApprovalsResponseDto
{
    /// <summary>
    /// <para>审批定义 Code。建议妥善保管该 Code，后续[查看指定审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get)、[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)等场景需要使用审批定义 Code。</para>
    /// <para>必填：否</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批定义 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7090754740375519252</para>
    /// </summary>
    [JsonPropertyName("approval_id")]
    public string? ApprovalId { get; set; }
}
