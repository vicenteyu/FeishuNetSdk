namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导出任务 响应体
/// <para>该接口用于创建导出文件的任务，并返回导出任务 ID。导出文件指将飞书文档、电子表格、多维表格导出为本地文件。该接口为异步接口，需要继续调用[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)接口获取导出结果。了解完整的导出文件步骤，参考[导出飞书云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ExportTasksResponseDto
{
    /// <summary>
    /// <para>导出任务的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6933093124755423251</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public string? Ticket { get; set; }
}
