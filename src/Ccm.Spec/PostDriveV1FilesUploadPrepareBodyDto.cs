using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传文件（预上传） 请求体
/// <para>发送初始化请求获取上传事务ID和分块策略，目前是以4MB大小进行定长分片。</para>
/// <para>接口ID：6979562676003815452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_prepare</para>
/// </summary>
public record PostDriveV1FilesUploadPrepareBodyDto
{
    /// <summary>
    /// <para>文件名</para>
    /// <para>**示例值**："test.txt"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大长度：`250` 字符</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点类型</para>
    /// <para>**示例值**："explorer"</para>
    /// <para>**可选值有**：</para>
    /// <para>explorer:云空间。</para>
    /// <para>必填：是</para>
    /// <para>可选值：<list type="bullet">
    /// <item>explorer：云空间。</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件夹的token</para>
    /// <para>**示例值**："fldbcO1UuPz8VwnpPx5a92abcef"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件大小</para>
    /// <para>**示例值**：1024</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最小值：`0`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("size")]
    public int Size { get; set; }
}
