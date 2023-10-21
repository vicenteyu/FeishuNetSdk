using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建导入任务 请求体
/// <para>创建导入任务。支持导入为新版文档、电子表格、多维表格以及旧版文档。该接口为异步接口，需要通过[查询导入结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get)接口获取导入结果，调用方式可参考[导入使用指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
/// <para>接口ID：6987581325629947905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fcreate</para>
/// </summary>
public record PostDriveV1ImportTasksBodyDto
{
    /// <summary>
    /// <para>导入文件格式后缀</para>
    /// <para>必填：是</para>
    /// <para>示例值：xlsx</para>
    /// </summary>
    [JsonProperty("file_extension")]
    public string FileExtension { get; set; } = string.Empty;

    /// <summary>
    /// <para>导入文件Drive FileToken</para>
    /// <para>必填：是</para>
    /// <para>示例值：boxcnxe5OxxxxxxxSNdsJviENsk</para>
    /// </summary>
    [JsonProperty("file_token")]
    public string FileToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>导入目标云文档格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：sheet</para>
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>导入目标云文档文件名 ，若为空使用Drive文件名</para>
    /// <para>必填：否</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonProperty("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// <para>挂载点</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("point")]
    public ImportTaskMountPoint Point { get; set; } = new();

    /// <summary>
    /// <para>挂载点</para>
    /// </summary>
    public record ImportTaskMountPoint
    {
        /// <summary>
        /// <para>挂载类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：挂载到云空间</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("mount_type")]
        public int MountType { get; set; }

        /// <summary>
        /// <para>挂载位置,对于mount_type=1, 云空间目录token，空表示根目录</para>
        /// <para>必填：是</para>
        /// <para>示例值：fldxxxxxxxx</para>
        /// </summary>
        [JsonProperty("mount_key")]
        public string MountKey { get; set; } = string.Empty;
    }
}
