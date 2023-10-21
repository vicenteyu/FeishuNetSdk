using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新数据表 响应体
/// <para>该接口用于更新数据表的基本信息，包括数据表的名称等。</para>
/// <para>接口ID：7182466310810402817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdResponseDto
{
    /// <summary>
    /// <para>数据表的名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：数据表的新名称</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }
}
