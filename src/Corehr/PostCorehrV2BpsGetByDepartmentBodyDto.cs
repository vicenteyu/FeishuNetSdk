using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询部门 HRBP 请求体
/// <para>查询部门的 HRBP 信息，包括来自上级部门的 HRBP。</para>
/// <para>接口ID：7261860942295547906</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/bp/get_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2fget_by_department</para>
/// </summary>
public record PostCorehrV2BpsGetByDepartmentBodyDto
{
    /// <summary>
    /// <para>部门 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6893014062142064111</para>
    /// </summary>
    [JsonProperty("department_id")]
    public string DepartmentId { get; set; } = string.Empty;
}
