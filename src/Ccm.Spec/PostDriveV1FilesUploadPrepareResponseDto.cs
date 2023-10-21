using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传文件（预上传） 响应体
/// <para>发送初始化请求获取上传事务ID和分块策略，目前是以4MB大小进行定长分片。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=drive&version=v1&resource=file&method=upload_prepare)</para>
/// <para>接口ID：6979562676003815452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_prepare</para>
/// </summary>
public record PostDriveV1FilesUploadPrepareResponseDto
{
    /// <summary>
    /// <para>分片上传事务ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("upload_id")]
    public string? UploadId { get; set; }

    /// <summary>
    /// <para>分片大小策略</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("block_size")]
    public int? BlockSize { get; set; }

    /// <summary>
    /// <para>分片数量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("block_num")]
    public int? BlockNum { get; set; }
}
