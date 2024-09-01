// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="DriveFileReadV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件已读 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 文件已读 事件体
/// <para>文件已读事件。云文档被打开时，将触发此事件。了解事件订阅的配置流程和使用场景，参考[事件概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。</para>
/// <para>接口ID：7013346140632481820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/event/list/file-read</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fevent%2ffile-read</para>
/// </summary>
public record DriveFileReadV1EventBodyDto() : EventBodyDto("drive.file.read_v1")
{
    /// <summary>
    /// <para>云文档类型，支持以下枚举：</para>
    /// <para>- doc：旧版文档。已不推荐使用</para>
    /// <para>- docx：新版文档</para>
    /// <para>- sheet：电子表格</para>
    /// <para>- bitable：多维表格</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>多维表格 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }
}
