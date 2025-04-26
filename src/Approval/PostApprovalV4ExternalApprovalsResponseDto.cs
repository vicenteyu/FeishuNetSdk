// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4ExternalApprovalsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建三方审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建三方审批定义 响应体
/// <para>三方审批定义用于设置审批的名称、描述等基本信息，同时还需要设置三方审批系统的审批发起页、数据回调 URL 等信息，将飞书审批与三方审批系统关联起来，使企业员工在飞书审批内即可直接发起三方审批，且审批中心可以将审批数据回传给三方审批系统。</para>
/// <para>## 注意事项</para>
/// <para>飞书审批中心不负责审批流程的流转，只负责审批的展示、状态操作、消息通知。因此，创建三方审批定义时，没有审批流程的参数配置项。</para>
/// <para>接口ID：7114621541589794819</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fcreate</para>
/// </summary>
public record PostApprovalV4ExternalApprovalsResponseDto
{
    /// <summary>
    /// <para>审批定义 Code。</para>
    /// <para>**注意**：在传入已存在的审批定义 Code 进行更新操作的场景中，该参数返回的 Code 可能与传入的 Code 不同。如果不同，请继续使用你传入的 Code，而不是该参数返回的 Code。</para>
    /// <para>必填：是</para>
    /// <para>示例值：C30381C8-7A5F-4717-A9CF-C233BF0202D4</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;
}
