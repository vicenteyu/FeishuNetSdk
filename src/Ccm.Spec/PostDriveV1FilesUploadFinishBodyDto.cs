using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传文件（完成上传） 请求体
/// <para>触发完成上传。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=drive&version=v1&resource=file&method=upload_finish)</para>
/// <para>接口ID：6979562676003766300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_finish</para>
/// </summary>
public record PostDriveV1FilesUploadFinishBodyDto
{
    /// <summary>
    /// <para>分片上传事务ID</para>
    /// <para>**示例值**："7111211691345512356"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>分片数量</para>
    /// <para>**示例值**：1</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("block_num")]
    public int BlockNum { get; set; }
}
