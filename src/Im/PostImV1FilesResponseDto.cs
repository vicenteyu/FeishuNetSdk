using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传文件 响应体
/// <para>上传文件，可以上传视频，音频和常见的文件类型。</para>
/// <para>接口ID：6946222931479461889</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/file/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2ffile%2fcreate</para>
/// </summary>
public record PostImV1FilesResponseDto
{
    /// <summary>
    /// <para>文件的key</para>
    /// <para>必填：否</para>
    /// <para>示例值：file_456a92d6-c6ea-4de4-ac3f-7afcf44ac78g</para>
    /// </summary>
    [JsonProperty("file_key")]
    public string? FileKey { get; set; }
}
