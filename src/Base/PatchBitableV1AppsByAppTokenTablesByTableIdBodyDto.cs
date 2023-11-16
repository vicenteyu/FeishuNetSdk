namespace FeishuNetSdk.Base;
/// <summary>
/// 更新数据表 请求体
/// <para>该接口用于更新数据表的基本信息，包括数据表的名称等。</para>
/// <para>接口ID：7182466310810402817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto
{
    /// <summary>
    /// <para>数据表的新名称。</para>
    /// <para>请注意：</para>
    /// <para>1. 名称中的首尾空格将会被去除。</para>
    /// <para>2. 如果名称为空或和旧名称相同，接口仍然会返回成功，但是名称不会被更改。</para>
    /// <para>必填：否</para>
    /// <para>示例值：数据表的新名称</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
