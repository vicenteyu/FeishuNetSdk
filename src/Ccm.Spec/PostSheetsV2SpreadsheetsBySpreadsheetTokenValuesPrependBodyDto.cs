using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入数据 请求体
/// <para>该接口用于根据 spreadsheetToken 和 range 向范围之前增加相应数据的行和相应的数据，相当于数组的插入操作；单次写入不超过5000行，100列，每个格子不超过5万字符。</para>
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto
{
    /// <summary>
    /// <para>值与范围</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("valueRange")]
    public ValueRangeSuffix ValueRange { get; set; } = new();

    public record ValueRangeSuffix
    {
        /// <summary>
        /// <para>⁣插入范围，包含 sheetId 与单元格范围两部分，目前支持三种索引方式，详见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)，range所表示的范围需要大于等于values占用的范围。</para>
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
