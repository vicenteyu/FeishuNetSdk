namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导出任务 请求体
/// <para>该接口用于创建导出文件的任务，并返回导出任务 ID。导出文件指将飞书文档、电子表格、多维表格导出为本地文件，包括 Word、Excel、PDF、CSV 格式。该接口为异步接口，需要继续调用[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)接口获取导出结果。了解完整的导出步骤，参考[导出云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ExportTasksBodyDto
{
    /// <summary>
    /// <para>将云文档导出为本地文件后，本地文件的扩展名。了解各类云文档支持导出的文件格式，参考[导出云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：csv</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：Microsoft Word 格式</item>
    /// <item>pdf：PDF 格式</item>
    /// <item>xlsx：Microsoft Excel 格式</item>
    /// <item>csv：CSV 格式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("file_extension")]
    public string FileExtension { get; set; } = string.Empty;

    /// <summary>
    /// <para>要导出的云文档的 token。获取方式参考 [如何获取云文档相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：Fm7osyjtMh5o7Ktrv32c73abcef</para>
    /// <para>最大长度：27</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>要导出的云文档的类型 。可通过云文档的链接判断。</para>
    /// <para>必填：是</para>
    /// <para>示例值：sheet</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版飞书文档。支持导出扩展名为 docx 和 pdf 的文件。已不推荐使用。</item>
    /// <item>sheet：飞书电子表格。支持导出扩展名为 xlsx 和 csv 的文件。</item>
    /// <item>bitable：飞书多维表格。支持导出扩展名为 xlsx 和 csv 格式的文件。</item>
    /// <item>docx：新版飞书文档。支持导出扩展名为 docx 和 pdf 格式的文件。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>导出飞书电子表格为 CSV 文件时，需传入电子表格中具体工作表的 ID。</para>
    /// <para>你需调用</para>
    /// <para>[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 接口获取返回的 `sheet_id` 的值作为该参数的值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6e5ed3</para>
    /// </summary>
    [JsonPropertyName("sub_id")]
    public string? SubId { get; set; }
}
