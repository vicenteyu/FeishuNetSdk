using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 新建文件夹 请求体
/// <para>在用户云空间的指定文件夹中创建一个新的空文件夹。</para>
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
public record PostDriveV1FilesCreateFolderBodyDto
{
    /// <summary>
    /// <para>文件夹名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：NewFolder</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父文件夹token。如果需要创建到「我的空间」作为顶级文件夹，请传入我的空间token[获取方式](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/get-root-folder-meta)</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonProperty("folder_token")]
    public string FolderToken { get; set; } = string.Empty;
}
