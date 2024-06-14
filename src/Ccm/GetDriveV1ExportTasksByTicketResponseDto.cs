namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询导出任务结果 响应体
/// <para>根据[创建导出任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/create)返回的导出任务 ID（ticket）轮询导出任务结果，并返回导出文件的 token。你可使用该 token 继续调用[下载导出文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/download)接口将导出的产物下载到本地。了解完整的导出文件步骤，参考[导出飞书云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
/// <para>接口ID：7089034521211207682</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fget</para>
/// </summary>
public record GetDriveV1ExportTasksByTicketResponseDto
{
    /// <summary>
    /// <para>导出任务结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("result")]
    public ExportTask? Result { get; set; }

    /// <summary>
    /// <para>导出任务结果</para>
    /// </summary>
    public record ExportTask
    {
        /// <summary>
        /// <para>导出的文件的扩展名</para>
        /// <para>必填：是</para>
        /// <para>示例值：pdf</para>
        /// <para>可选值：<list type="bullet">
        /// <item>docx：Microsoft Word 格式</item>
        /// <item>pdf：PDF 格式</item>
        /// <item>xlsx：Microsoft Excel (XLSX) 格式</item>
        /// <item>csv：CSV 格式</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("file_extension")]
        public string FileExtension { get; set; } = string.Empty;

        /// <summary>
        /// <para>要导出的云文档的类型。可通过云文档的链接判断。</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>doc：旧版飞书文档。支持导出扩展名为 docx 和 pdf 的文件。已不推荐使用。</item>
        /// <item>sheet：飞书电子表格。支持导出扩展名为 xlsx 和 csv 的文件</item>
        /// <item>bitable：飞书多维表格。支持导出扩展名为 xlsx 和 csv 格式的文件</item>
        /// <item>docx：新版飞书文档。支持导出扩展名为 docx 和 pdf 格式的文件</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>导出的文件名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：docName</para>
        /// </summary>
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// <para>导出的文件的 token。可用于调用[下载导出文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/download)接口将导出的产物下载到本地。</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxcnxe5OdjlAkNgSNdsJvabcef</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// <para>导出文件的大小，单位字节。</para>
        /// <para>必填：否</para>
        /// <para>示例值：34356</para>
        /// </summary>
        [JsonPropertyName("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// <para>导出任务失败的原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：success</para>
        /// </summary>
        [JsonPropertyName("job_error_msg")]
        public string? JobErrorMsg { get; set; }

        /// <summary>
        /// <para>导出任务状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：成功</item>
        /// <item>1：初始化</item>
        /// <item>2：处理中</item>
        /// <item>3：内部错误</item>
        /// <item>107：导出文档过大</item>
        /// <item>108：处理超时</item>
        /// <item>109：导出内容块无权限</item>
        /// <item>110：无权限</item>
        /// <item>111：导出文档已删除</item>
        /// <item>122：创建副本中禁止导出</item>
        /// <item>123：导出文档不存在</item>
        /// <item>6000：导出文档图片过多</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("job_status")]
        public int? JobStatus { get; set; }
    }
}
