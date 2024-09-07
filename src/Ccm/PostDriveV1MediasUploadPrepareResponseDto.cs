// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MediasUploadPrepareResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传素材-预上传 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材-预上传 响应体
/// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传素材分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part)做准备。平台固定以 4MB 的大小对素材进行分片。了解完整的分片上传素材流程，参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。</para>
/// <para>## 注意事项</para>
/// <para>上传事务 ID 和上传进度在 24 小时内有效。请及时保存和恢复上传。</para>
/// <para>## 使用限制</para>
/// <para>该接口调用频率上限为 5 QPS，10000 次/天。</para>
/// <para>接口ID：6979562676003848220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_prepare</para>
/// </summary>
public record PostDriveV1MediasUploadPrepareResponseDto
{
    /// <summary>
    /// <para>分片上传事务 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7111211691345512356</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string? UploadId { get; set; }

    /// <summary>
    /// <para>分片大小策略</para>
    /// <para>必填：否</para>
    /// <para>示例值：4194304</para>
    /// </summary>
    [JsonPropertyName("block_size")]
    public int? BlockSize { get; set; }

    /// <summary>
    /// <para>分片数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("block_num")]
    public int? BlockNum { get; set; }
}
