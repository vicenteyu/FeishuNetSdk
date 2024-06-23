// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenMoveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移动文件或文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动文件或文件夹 响应体
/// <para>将文件或者文件夹移动到用户云空间的其他位置。</para>
/// <para>接口ID：7080903916725993474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fmove</para>
/// </summary>
public record PostDriveV1FilesByFileTokenMoveResponseDto
{
    /// <summary>
    /// <para>异步任务 ID，移动文件夹时返回。你可继续使用[查询异步任务状态](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/task_check)接口查询任务执行状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：7360595374803812356</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
