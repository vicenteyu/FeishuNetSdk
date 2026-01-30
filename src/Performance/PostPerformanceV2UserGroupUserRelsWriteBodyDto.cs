// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostPerformanceV2UserGroupUserRelsWriteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人员组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 更新人员组成员 请求体
/// <para>更新指定人员组成员。</para>
/// <para>接口ID：7381506957100875778</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/user_group_user_rel/write</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_group_user_rel%2fwrite</para>
/// </summary>
public record PostPerformanceV2UserGroupUserRelsWriteBodyDto
{
    /// <summary>
    /// <para>人员组 ID，可以从**人员组管理**页面获取</para>
    /// <para>**必填：** 是</para>
    /// <para>必填：否</para>
    /// <para>示例值：ABCDEFG</para>
    /// <para>最大长度：128</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }

    /// <summary>
    /// <para>人员组可见性配置</para>
    /// <para>**必填：** 是</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>最大值：10</para>
    /// <para>最小值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：无限制</item>
    /// <item>1：后台管理员不可见</item>
    /// </list></para>
    /// <para>默认值：1</para>
    /// </summary>
    [JsonPropertyName("scope_visible_setting")]
    public int? ScopeVisibleSetting { get; set; }

    /// <summary>
    /// <para>人员 ID 列表，ID 类型与查询参数 user_id_type 取值一致</para>
    /// <para>**必填：** 是</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
