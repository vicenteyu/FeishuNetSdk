using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 上传图片 响应体
/// <para>词条图片资源上传。</para>
/// <para>接口ID：7249689905697013788</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/file/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2ffile%2fupload</para>
/// </summary>
public record PostLingoV1FilesUploadResponseDto
{
    /// <summary>
    /// <para>文件 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxbcEcmKiD****vgqWTpvdc7jc</para>
    /// </summary>
    [JsonProperty("file_token")]
    public string? FileToken { get; set; }
}
