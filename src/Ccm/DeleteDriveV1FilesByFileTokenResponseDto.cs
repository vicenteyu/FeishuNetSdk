// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteDriveV1FilesByFileTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除文件或文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除文件或文件夹 响应体
/// <para>删除用户在云空间内的文件或者文件夹。文件或文件夹被删除后，会进入回收站中。</para>
/// <para>## 前提条件</para>
/// <para>要删除文件，需要确保应用或用户具有以下两种权限之一：</para>
/// <para>- 该应用或用户是文件所有者并且具有该文件所在父文件夹的编辑权限。</para>
/// <para>- 该应用或用户并非文件所有者，但是该文件所在父文件夹的所有者或者拥有该父文件夹的所有权限（full access）。</para>
/// <para>## 使用限制</para>
/// <para>该接口不支持并发调用，且调用频率上限为 5 QPS，10000 次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
/// <para>接口ID：7029475705897828354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fdelete</para>
/// </summary>
public record DeleteDriveV1FilesByFileTokenResponseDto
{
    /// <summary>
    /// <para>异步任务 ID，删除文件夹时返回。你可继续使用[查询异步任务状态](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/task_check)接口查询任务执行状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：7360595374803812356</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
