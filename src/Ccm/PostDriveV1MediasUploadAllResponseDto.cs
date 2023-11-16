namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传素材 响应体
/// <para>将文件、图片、视频等素材文件上传到指定云文档中。素材文件在云空间中不会显示，只会显示在对应云文档中。</para>
/// <para>接口ID：6979562676003831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_all</para>
/// </summary>
public record PostDriveV1MediasUploadAllResponseDto
{
    /// <summary>
    /// <para>素材文件的 token。</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }
}
