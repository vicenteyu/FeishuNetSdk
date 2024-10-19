// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomLevelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议室层级 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 创建会议室层级 请求体
/// <para>该接口用于创建会议室层级。</para>
/// <para>接口ID：7160517357591986179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fcreate</para>
/// </summary>
public record PostVcV1RoomLevelsBodyDto
{
    /// <summary>
    /// <para>层级名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试层级</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父层级ID。</para>
    /// <para>**说明**：如需在租户层级（即根层级）下创建会议室层级，可以先调用[查询会议室层级详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room_level/get)接口，将路径参数 `room_level_id` 传入 `0` 进行查询，返回结果中的 `room_level_id` 值即为根层级 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义层级ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：10000</para>
    /// </summary>
    [JsonPropertyName("custom_group_id")]
    public string? CustomGroupId { get; set; }
}
