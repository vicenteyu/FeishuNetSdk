namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 写入图片 请求体
/// <para>该接口用于根据 spreadsheetToken 和 range 向单个格子写入图片。</para>
/// <para>接口ID：6907568073252585474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-images</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNxYjL1QTM24SN0EjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto
{
    /// <summary>
    /// <para>查询范围 range=&lt;sheetId&gt;!&lt;开始格子&gt;:&lt;结束格子&gt; 如：xxxx!A1:D5，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。此处限定为一个格子，如: xxxx!A1:A1</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要写入的图片二进制流，支持 "PNG", "JPEG", "JPG", "GIF", "BMP", "JFIF", "EXIF", "TIFF", "BPG", "HEIC" 等图片格式</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("image")]
    public byte[] Image { get; set; } = Array.Empty<byte>();

    /// <summary>
    /// <para>写入的图片名字</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
