// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV1ChatsByChatIdAnnouncementBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新群公告信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群公告信息 请求体
/// <para>更新会话中的群公告信息，更新公告信息的格式和更新[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)格式相同，不支持新版文档格式。</para>
/// <para>接口ID：6946222931479511041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fpatch</para>
/// </summary>
public record PatchImV1ChatsByChatIdAnnouncementBodyDto
{
    /// <summary>
    /// <para>文档当前版本号 int64 类型，[获取群公告信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-announcement/get)接口会返回</para>
    /// <para>**注意**：传入的版本号和最新版本号的差距不能超过100</para>
    /// <para>必填：是</para>
    /// <para>示例值：12</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; } = string.Empty;

    /// <summary>
    /// <para>修改文档请求的序列化字段</para>
    /// <para>更新公告信息的格式和更新[云文档](https://open.feishu.cn/document/ukTMukTMukTM/uYDM2YjL2AjN24iNwYjN)格式相同</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"requestType\":\"InsertBlocksRequestType\",\"insertBlocksRequest\":{\"payload\":\"{\\\"blocks\\\":[{\\\"type\\\":\\\"paragraph\\\",\\\"paragraph\\\":{\\\"elements\\\":[{\\\"type\\\":\\\"textRun\\\",\\\"textRun\\\":{\\\"text\\\":\\\"ylyyyyyDocsAPISampleContent\\\",\\\"style\\\":{}}}],\\\"style\\\":{}}}]}\",\"location\":{\"zoneId\":\"0\",\"index\":0,\"endOfZone\":true}}}</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public string[]? Requests { get; set; }
}
