using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询员工 HRBP / 属地 BP 响应体
/// <para>查询员工的 HRBP 和属地 BP，包括来自上级部门的 HRBP 和属地 BP。</para>
/// <para>接口ID：7261860942295580674</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-bp/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-bp%2fbatch_get</para>
/// </summary>
public record PostCorehrV2EmployeesBpsBatchGetResponseDto
{
    /// <summary>
    /// <para>员工直属 BP 信息，当员工所在部门、属地无 BP 时，会上钻找到最近的 BP</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employment_direct_bps")]
    public EmploymentBp[]? EmploymentDirectBps { get; set; }

    /// <summary>
    /// <para>员工直属 BP 信息，当员工所在部门、属地无 BP 时，会上钻找到最近的 BP</para>
    /// </summary>
    public record EmploymentBp
    {
        /// <summary>
        /// <para>员工雇佣 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863326262618752123</para>
        /// </summary>
        [JsonProperty("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>员工直属 HRBP 雇佣 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("hrbp_ids")]
        public string[]? HrbpIds { get; set; }

        /// <summary>
        /// <para>员工直属属地 BP 雇佣 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("location_bp_ids")]
        public string[]? LocationBpIds { get; set; }
    }

    /// <summary>
    /// <para>员工全部 BP 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employment_all_bps")]
    public EmploymentBp[]? EmploymentAllBps { get; set; }
}
