using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 向多个范围写入数据 响应体
/// <para>该接口用于根据 spreadsheetToken 和 range 向多个范围写入数据，若范围内有数据，将被更新覆盖；单次写入不超过5000行，100列，每个格子不超过5万字符。</para>
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto
{
    /// <summary>
    /// <para>响应</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>spreadsheet 的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>写入的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>写入的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>写入的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>写入的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedCells")]
        public int? UpdatedCells { get; set; }
    }

    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }
}
