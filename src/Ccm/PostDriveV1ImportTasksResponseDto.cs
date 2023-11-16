namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导入任务 响应体
/// <para>创建导入任务。支持导入为新版文档、电子表格、多维表格以及旧版文档。该接口为异步接口，需要通过[查询导入结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get)接口获取导入结果，调用方式可参考[导入使用指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
/// <para>接口ID：6987581325629947905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ImportTasksResponseDto
{
    /// <summary>
    /// <para>导入任务ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6990281xxxxxxxxxxx843</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public string? Ticket { get; set; }
}
