namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询部门 HRBP 响应体
/// <para>查询部门的 HRBP 信息，包括来自上级部门的 HRBP。</para>
/// <para>接口ID：7261860942295547906</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/bp/get_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2fget_by_department</para>
/// </summary>
public record PostCorehrV2BpsGetByDepartmentResponseDto
{
    /// <summary>
    /// <para>部门 HRBP 信息，依次为部门及各层级上级部门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DepartmentHrbp[]? Items { get; set; }

    /// <summary>
    /// <para>部门 HRBP 信息，依次为部门及各层级上级部门</para>
    /// </summary>
    public record DepartmentHrbp
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门 HRBP 雇佣 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hrbp_ids")]
        public string[]? HrbpIds { get; set; }
    }
}
