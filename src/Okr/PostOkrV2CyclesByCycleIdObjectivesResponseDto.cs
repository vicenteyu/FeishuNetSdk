// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostOkrV2CyclesByCycleIdObjectivesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建 OKR 目标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 创建 OKR 目标 响应体
/// <para>在指定的 OKR 周期下创建一个新的目标。使用富文本结构定义目标内容，添加可选备注，设置截止时间，并配置权重、分类和初始分数。</para>
/// <para>接口ID：7644863390543973340</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle-objective/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle-objective%2fcreate</para>
/// </summary>
public record PostOkrV2CyclesByCycleIdObjectivesResponseDto
{
    /// <summary>
    /// <para>目标 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("objective_id")]
    public string? ObjectiveId { get; set; }
}
