namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导入任务 响应体
/// <para>该接口用于创建导入文件的任务，并返回导入任务 ID。导入文件指将本地文件如 Word、TXT、Markdown、Excel 等格式的文件导入为某种格式的飞书在线云文档。该接口为异步接口，需要继续调用[查询导入任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get)接口获取导入结果。了解完整的导入文件步骤，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
/// <para>接口ID：6987581325629947905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ImportTasksResponseDto
{
    /// <summary>
    /// <para>导入任务 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7369583175086912356</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public string? Ticket { get; set; }
}
