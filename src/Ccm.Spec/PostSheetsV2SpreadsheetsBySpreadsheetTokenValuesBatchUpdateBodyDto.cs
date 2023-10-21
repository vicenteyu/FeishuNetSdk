using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 向多个范围写入数据 请求体
/// <para>该接口用于根据 spreadsheetToken 和 range 向多个范围写入数据，若范围内有数据，将被更新覆盖；单次写入不超过5000行，100列，每个格子不超过5万字符。</para>
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto
{
    /// <summary>
    /// <para>需要更新的多个范围</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("valueRanges")]
    public ValueRange[] ValueRanges { get; set; } = Array.Empty<ValueRange>();

    public record ValueRange
    {
        /// <summary>
        /// <para>更新范围，包含 sheetId 与单元格范围两部分，目前支持三种索引方式，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。range所表示的范围需要大于等于values占用的范围。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>需要写入的值，如要写入公式、超链接、email、@人等，可详看附录[sheet 支持写入数据类型](https://open.feishu.cn/document/ukTMukTMukTM/ugjN1UjL4YTN14CO2UTN)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("values")]
        public object[][] Values { get; set; } = default!;
    }
}
