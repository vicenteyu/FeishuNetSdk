namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导入任务 请求体
/// <para>该接口用于创建导入文件的任务，并返回导入任务 ID。导入文件指将本地文件如 Word、TXT、Markdown、Excel 等格式的文件导入为某种格式的飞书在线云文档。该接口为异步接口，需要继续调用[查询导入任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get)接口获取导入结果。了解完整的导入文件步骤，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
/// <para>接口ID：6987581325629947905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ImportTasksBodyDto
{
    /// <summary>
    /// <para>要导入的文件的扩展名。了解支持的文件格式，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
    /// <para>**注意**：此处填写的文件扩展名需与实际文件的后缀名保持严格一致。请注意区分后缀为 “markdown”、“md”、“mark” 的 Markdown 文件，并在填写相关参数时保持后缀名一致。否则将返回 1069910 错误码。</para>
    /// <para>必填：是</para>
    /// <para>示例值：xlsx</para>
    /// </summary>
    [JsonPropertyName("file_extension")]
    public string FileExtension { get; set; } = string.Empty;

    /// <summary>
    /// <para>要导入文件的 token。创建任务前，你需先调用[上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)或[上传文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_all)接口获取源文件的 token。了解更多，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// <para>最大长度：27</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string FileToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>目标云文档格式。不同文件支持的云文档格式不同。详情参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。可选值如下所示：</para>
    /// <para>- `docx`：新版文档</para>
    /// <para>- `sheet`：电子表格</para>
    /// <para>- `bitable`：多维表格</para>
    /// <para>必填：是</para>
    /// <para>示例值：sheet</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>导入后的在线云文档名称。参数为空时，使用上传本地文件时的文件名。</para>
    /// <para>必填：否</para>
    /// <para>示例值：销售表</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// <para>挂载点（导入后的云文档所在位置）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("point")]
    public ImportTaskMountPoint Point { get; set; } = new();

    /// <summary>
    /// <para>挂载点（导入后的云文档所在位置）</para>
    /// </summary>
    public record ImportTaskMountPoint
    {
        /// <summary>
        /// <para>挂载类型。取固定值 1，表示将该云文档挂载至云空间下。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：挂载到云空间</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("mount_type")]
        public int MountType { get; set; }

        /// <summary>
        /// <para>云文档挂载的文件夹的 token，即云空间下文件夹的 token。空表示云空间根目录。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：AbqrfuRTjlJEIJduwDwcnIabcef</para>
        /// </summary>
        [JsonPropertyName("mount_key")]
        public string MountKey { get; set; } = string.Empty;
    }
}
