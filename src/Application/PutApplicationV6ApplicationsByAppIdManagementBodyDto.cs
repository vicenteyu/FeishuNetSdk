namespace FeishuNetSdk.Application;
/// <summary>
/// 启停用应用 请求体
/// <para>可停用或启用企业内已安装的自建应用与商店应用。</para>
/// <para>接口ID：7327327802326958081</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application-management/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-management%2fupdate</para>
/// </summary>
public record PutApplicationV6ApplicationsByAppIdManagementBodyDto
{
    /// <summary>
    /// <para>启用/停用应用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}
