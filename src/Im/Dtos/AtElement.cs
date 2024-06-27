// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="AtElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>At 消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// At 消息
    /// </summary>
    /// <param name="UserId">
    /// <para>用户的open_id，union_id 或 user_id，请参考如何获取 User ID、Open ID 和 Union ID。</para>
    /// <para>注意: @单个用户时，user_id字段必须是有效值；@所有人填"all"。</para>
    /// </param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record AtElement([property: JsonPropertyName("user_id")] string UserId = "",
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("at");
}
