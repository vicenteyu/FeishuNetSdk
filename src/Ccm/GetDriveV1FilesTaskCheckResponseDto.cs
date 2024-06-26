// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1FilesTaskCheckResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询异步任务状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询异步任务状态 响应体
/// <para>查询异步任务的状态信息。目前支持查询删除文件夹和移动文件夹的异步任务。</para>
/// <para>接口ID：7094912924435021826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/async-task/task_check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2ftask_check</para>
/// </summary>
public record GetDriveV1FilesTaskCheckResponseDto
{
    /// <summary>
    /// <para>异步任务的执行状态。枚举值有：</para>
    /// <para>- success：任务执行成功</para>
    /// <para>- fail：任务执行失败</para>
    /// <para>- process：任务还在执行中</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
