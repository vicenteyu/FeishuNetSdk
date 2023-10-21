using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导出任务 请求体
/// <para>创建导出任务，将云文档导出为指定格式的本地文件，目前支持新版文档、电子表格、多维表格和旧版文档。该接口为异步接口，任务创建完成即刻返回，并不会阻塞等待到任务执行成功，因此需要结合[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)接口获取导出结果。</para>
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ExportTasksBodyDto
{
    /// <summary>
    /// <para>导出文件扩展名</para>
    /// <para>必填：是</para>
    /// <para>示例值：csv</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：MicrosoftWord(DOCX)格式</item>
    /// <item>pdf：pdf格式</item>
    /// <item>xlsx：MicrosoftExcel(XLSX)格式</item>
    /// <item>csv：csv格式</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("file_extension")]
    public string FileExtension { get; set; } = string.Empty;

    /// <summary>
    /// <para>导出文档 token [获取文档 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>必填：是</para>
    /// <para>示例值：shtcnxe5OxxxxxxxSNdsJviENsk</para>
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>导出文档类型 [文档类型说明](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#560bf735)</para>
    /// <para>必填：是</para>
    /// <para>示例值：sheet</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版飞书云文档类型，支持导出为docx、pdf格式</item>
    /// <item>sheet：飞书电子表格类型，支持导出为xlsx、csv格式</item>
    /// <item>bitable：飞书多维表格类型，支持导出为xlsx、csv格式</item>
    /// <item>docx：新版飞书云文档类型，支持导出为docx、pdf格式</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>导出子表ID，仅当将电子表格/多维表格导出为 csv 时使用</para>
    /// <para>[获取电子表格子表ID](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 文档中的 sheet_id</para>
    /// <para>[获取多维表格子表ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/list) 文档中的 table_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：tblKz5D60T4JlfcT</para>
    /// </summary>
    [JsonProperty("sub_id")]
    public string? SubId { get; set; }
}
