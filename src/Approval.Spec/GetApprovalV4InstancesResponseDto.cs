using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 批量获取审批实例 ID 响应体
/// <para>根据 approval_code 批量获取审批实例的 instance_code，用于拉取租户下某个审批定义的全部审批实例。默认以审批创建时间先后顺序排列。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=approval&version=v4&resource=instance&method=list)</para>
/// <para>接口ID：7114621541589876739</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2flist</para>
/// </summary>
public record GetApprovalV4InstancesResponseDto
{
    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_code_list")]
    public string[]? InstanceCodeList { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
