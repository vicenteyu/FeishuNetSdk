// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="CorehrCommonDataIdUserMappingChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户ID映射变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 用户ID映射变更 事件体
/// <para>用户ID映射变更事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=common_data.id&amp;event=user_mapping_changed)</para>
/// <para>接口ID：7485189163967332371</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/common_data-id/events/user_mapping_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fevents%2fuser_mapping_changed</para>
/// </summary>
public record CorehrCommonDataIdUserMappingChangedV1EventBodyDto() : EventBodyDto("corehr.common_data.id.user_mapping_changed_v1")
{
    /// <summary>
    /// <para>变更类型。insert：创建用户ID映射，delete：删除用户ID映射。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("change_type")]
    public string? ChangeType { get; set; }

    /// <summary>
    /// <para>ID转换类型。1:飞书人事&lt;-&gt;飞书，2:飞书人事&lt;-&gt;PeopleAdmin，3:PeopleAdmin&lt;-&gt;飞书。</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`1` ～ `3`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_transform_type")]
    public int? IdTransformType { get; set; }

    /// <summary>
    /// <para>飞书人事ID，仅id_transform_type等于1、2时有值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("corehr_id")]
    public string? CorehrId { get; set; }

    /// <summary>
    /// <para>PeopleAdmin ID，仅id_transform_type等于2、3时有值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("people_admin_id")]
    public string? PeopleAdminId { get; set; }

    /// <summary>
    /// <para>飞书用户ID，仅id_transform_type等于1、3时有值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feishu_id")]
    public UserIdSuffix? FeishuId { get; set; }
}
