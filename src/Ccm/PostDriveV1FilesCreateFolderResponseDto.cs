using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 新建文件夹 响应体
/// <para>在用户云空间的指定文件夹中创建一个新的空文件夹。</para>
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
public record PostDriveV1FilesCreateFolderResponseDto
{
    /// <summary>
    /// <para>创建文件夹的token</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbcddUuPz8VwnpPx5oc2abcef</para>
    /// </summary>
    [JsonProperty("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>创建文件夹的访问url</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://feishu.cn/drive/folder/fldbcddUuPz8VwnpPx5oc2abcef</para>
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }
}
