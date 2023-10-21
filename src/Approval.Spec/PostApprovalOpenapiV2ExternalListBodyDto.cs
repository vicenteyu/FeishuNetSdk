using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 获取三方审批任务状态 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_task/list)该接口用于获取三方审批的状态。用户传入查询条件，接口返回满足条件的审批实例的状态。</para>
/// <para>该接口支持多种参数的组合， 包括如下组合：</para>
/// <para>1. 通过 instance_ids 获取指定实例的任务状态</para>
/// <para>2. 通过 user_ids 获取指定用户的任务状态</para>
/// <para>3. 通过 status 获取指定状态的所有任务</para>
/// <para>4. 获取下一批数据</para>
/// <para>接口ID：6915007875422568450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjNyYjL5YjM24SO2IjN%2fexternal_status</para>
/// </summary>
public record PostApprovalOpenapiV2ExternalListBodyDto
{
    /// <summary>
    /// <para>审批定义 Code，用于指定只获取这些定义下的数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_codes")]
    public string[]? ApprovalCodes { get; set; }

    /// <summary>
    /// <para>审批实例 ID, 用于指定只获取这些实例下的数据，最多支持 20 个</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_ids")]
    public string[]? InstanceIds { get; set; }

    /// <summary>
    /// <para>审批人 user_id，用于指定只获取这些用户的数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>审批任务状态，用于指定获取该状态下的数据，状态值参照 [三方审批任务状态枚举](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_instance/create)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>通过 status 获取所有任务的请求，数据是分批返回的，使用 scroll_id 获取下一批数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("scroll_id")]
    public string? ScrollId { get; set; }
}
