// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="CorehrProcessCommentInfoUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流程下评论事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 流程下评论事件 事件体
/// <para>流程新增评论时会触发该事件，该事件包含评论所在的流程ID（process_id是其唯一标识）和评论唯一ID（comment_id）,此功能不受数据权限范围控制{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process_comment_info&amp;event=updated)</para>
/// <para>接口ID：7563552023226925057</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process_comment_info/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_comment_info%2fevents%2fupdated</para>
/// </summary>
public record CorehrProcessCommentInfoUpdatedV2EventBodyDto() : EventBodyDto("corehr.process_comment_info.updated_v2")
{
    /// <summary>
    /// <para>流程运行实例id</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>流程下评论的唯一id</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>评论事件的类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:新增</para>
    /// <para>**默认值**：`1`</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`1` ～ `100`</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：新增</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}
