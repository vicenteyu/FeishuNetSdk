using Newtonsoft.Json;
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批实例 响应体
/// <para>创建一个审批实例，调用方需对审批定义的表单有详细了解，将按照定义的表单结构，将表单 Value 通过接口传入。</para>
/// <para>接口ID：7114621541589827587</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesResponseDto
{
    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;
}
