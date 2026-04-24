// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadCompleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件 - 完成上传 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 分片上传文件 - 完成上传 请求体
/// <para>调用`上传分片`将分片全部上传完毕后，调用本接口触发完成上传。</para>
/// <para>接口ID：7631245788191312854</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_complete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_complete</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadCompleteBodyDto
{
    /// <summary>
    /// <para>上传请求 ID，可通过`分片上传文件 - 创建上传`请求获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：upload_abc123xyz456</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string UploadId { get; set; } = string.Empty;
}
