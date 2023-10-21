using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除字段 响应体
/// <para>该接口用于在数据表中删除一个字段</para>
/// <para>接口ID：6960166873968525315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fdelete</para>
/// </summary>
public record DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto
{
    /// <summary>
    /// <para>field id</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldPTb0U2y</para>
    /// </summary>
    [JsonProperty("field_id")]
    public string? FieldId { get; set; }

    /// <summary>
    /// <para>删除标记</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("deleted")]
    public bool? Deleted { get; set; }
}
