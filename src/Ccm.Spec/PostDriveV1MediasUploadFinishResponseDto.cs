using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传素材（完成上传） 响应体
/// <para>触发完成上传。</para>
/// <para>接口ID：6979562676003880988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_finish</para>
/// </summary>
public record PostDriveV1MediasUploadFinishResponseDto
{
    /// <summary>
    /// <para>新创建文件的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("file_token")]
    public string? FileToken { get; set; }
}
