// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsPostDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除帖子 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 删除帖子 事件体
/// <para>公司圈用户删除帖子时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=post&amp;event=deleted)</para>
/// <para>接口ID：7270433540692656131</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost%2fevents%2fdeleted</para>
/// </summary>
public record MomentsPostDeletedV1EventBodyDto() : EventBodyDto("moments.post.deleted_v1")
{
    /// <summary>
    /// <para>帖子 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
