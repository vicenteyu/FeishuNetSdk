// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesUploadPrepareBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件-预上传 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传文件-预上传 请求体
/// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_part)做准备。平台固定以 4MB 的大小对文件进行分片。了解完整的上传文件流程，参考[上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
/// <para>## 注意事项</para>
/// <para>上传事务 ID 和上传进度在 24 小时内有效。请及时保存和恢复上传。</para>
/// <para>## 使用限制</para>
/// <para>该接口不支持并发调用，且调用频率上限为 5 QPS，10000 次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
/// <para>接口ID：6979562676003815452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_prepare</para>
/// </summary>
public record PostDriveV1FilesUploadPrepareBodyDto
{
    /// <summary>
    /// <para>文件的名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：test.txt</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的类型。取固定值 explorer，表示将文件上传至云空间中。</para>
    /// <para>必填：是</para>
    /// <para>示例值：explorer</para>
    /// <para>可选值：<list type="bullet">
    /// <item>explorer：云空间</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>云空间中文件夹的 token。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的大小，单位为字节。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }
}
