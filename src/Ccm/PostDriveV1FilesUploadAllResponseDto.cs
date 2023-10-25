using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传文件 响应体
/// <para>向云空间指定目录下上传一个小文件。</para>
/// <para>接口ID：6979562676003864604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_all</para>
/// </summary>
public record PostDriveV1FilesUploadAllResponseDto
{
    /// <summary>
    /// <para>新创建文件的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonProperty("file_token")]
    public string? FileToken { get; set; }
}
