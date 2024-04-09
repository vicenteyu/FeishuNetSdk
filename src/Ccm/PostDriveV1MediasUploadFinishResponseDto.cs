namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材-完成上传 响应体
/// <para>调用[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part)接口将分片全部上传完毕后，你可调用本接口触发完成上传。了解完整的分片上传素材流程，参考[分片上传素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/multipart-upload-media/introduction)。</para>
/// <para>接口ID：6979562676003880988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_finish</para>
/// </summary>
public record PostDriveV1MediasUploadFinishResponseDto
{
    /// <summary>
    /// <para>新创建文件的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }
}
