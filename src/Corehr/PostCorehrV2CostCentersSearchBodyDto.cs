namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索成本中心信息 请求体
/// <para>查询成本中心信息</para>
/// <para>接口ID：7225452763517075459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fsearch</para>
/// </summary>
public record PostCorehrV2CostCentersSearchBodyDto
{
    /// <summary>
    /// <para>成本中心ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_id_list")]
    public string[]? CostCenterIdList { get; set; }

    /// <summary>
    /// <para>成长中心名称列表，精确匹配</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name_list")]
    public string[]? NameList { get; set; }

    /// <summary>
    /// <para>成本中心编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：MDPD00000023</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>上级成本中心ID，可用于查询直接下级成本中心</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("parent_cost_center_id")]
    public string? ParentCostCenterId { get; set; }

    /// <summary>
    /// <para>是否获取所有成本中心版本，true 为获取成本中心所有版本记录，false 为仅获取当前生效的成本中心记录，默认为 false</para>
    /// <para>当填写 true 并输入其他查询条件时，返回的是所有符合查询条件的版本信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("get_all_version")]
    public bool? GetAllVersion { get; set; }
}
