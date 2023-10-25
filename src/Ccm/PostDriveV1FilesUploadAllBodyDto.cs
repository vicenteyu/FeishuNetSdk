using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传文件 请求体
/// <para>向云空间指定目录下上传一个小文件。</para>
/// <para>接口ID：6979562676003864604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_all</para>
/// </summary>
public record PostDriveV1FilesUploadAllBodyDto
{
    /// <summary>
    /// <para>文件名。</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.pdf</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点类型。</para>
    /// <para>必填：是</para>
    /// <para>示例值：explorer</para>
    /// <para>可选值：<list type="bullet">
    /// <item>explorer：云空间。</item>
    /// </list></para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件夹token，</para>
    /// <para>获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件大小（以字节为单位）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// <para>最大值：20971520</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>文件adler32校验和(可选)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：123423882374238912356</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("checksum")]
    public string? Checksum { get; set; }
}
