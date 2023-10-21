using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新多维表格元数据 请求体
/// <para>通过 app_token 更新多维表格元数据</para>
/// <para>接口ID：7073673019918811164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fupdate</para>
/// </summary>
public record PutBitableV1AppsByAppTokenBodyDto
{
    /// <summary>
    /// <para>新的多维表格名字</para>
    /// <para>必填：否</para>
    /// <para>示例值：新的多维表格名字</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>多维表格是否开启高级权限</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("is_advanced")]
    public bool? IsAdvanced { get; set; }
}
