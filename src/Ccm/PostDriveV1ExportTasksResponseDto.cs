using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导出任务 响应体
/// <para>创建导出任务，将云文档导出为指定格式的本地文件，目前支持新版文档、电子表格、多维表格和旧版文档。该接口为异步接口，任务创建完成即刻返回，并不会阻塞等待到任务执行成功，因此需要结合[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)接口获取导出结果。</para>
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ExportTasksResponseDto
{
    /// <summary>
    /// <para>导出任务ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6933093124755423251</para>
    /// </summary>
    [JsonProperty("ticket")]
    public string? Ticket { get; set; }
}
