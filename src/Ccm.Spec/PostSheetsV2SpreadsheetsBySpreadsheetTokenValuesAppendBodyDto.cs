namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 追加数据 请求体
/// <para>该接口用于在已有数据的末尾追加写入给定的数据。该接口会从给定的range中的起始行列开始向下寻找（如range为"sheet1!A1:B2",将会依次寻找A1、A2、A3...），找到第一个空白位置后将数据写入到该区域。单次写入不得超过5000行，100列，每个格子不得超过5万字符。</para>
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto
{
    /// <summary>
    /// <para>值与范围</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("valueRange")]
    public ValueRangeSuffix ValueRange { get; set; } = new();

    /// <summary></summary>
    public record ValueRangeSuffix
    {
        /// <summary>
        /// <para>⁣查询范围，包含 sheetId 与单元格范围两部分，目前支持四种索引方式，详见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。range所表示的范围需要大于等于values占用的范围。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>需要写入的值，如要写入公式、超链接、email、@人等，可详看附录[sheet 支持写入数据类型](https://open.feishu.cn/document/ukTMukTMukTM/ugjN1UjL4YTN14CO2UTN)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][] Values { get; set; } = Array.Empty<object[][]>();
    }
}
