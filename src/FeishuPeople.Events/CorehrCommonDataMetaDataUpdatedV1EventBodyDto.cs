// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-08
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="CorehrCommonDataMetaDataUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>元数据信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 元数据信息变更 事件体
/// <para>People元数据定义变更会对外推送事件。例如在People系统中，设置-人员档案配置-个人信息-基本信息 中添加一个字段。就会收到person相关的元数据变更推送。</para>
/// <para>可通过[获取飞书人事对象列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/list_object_api_name)查询对象列表，包括了预置对象的字段变更以及自定义对象的字段变更，不保证顺序，所以要使用的话当监听到变更事件后需要判断是否关心该对象然后查询对象的字段来做业务逻辑。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=common_data.meta_data&amp;event=updated)</para>
/// <para>接口ID：7432559725286539266</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-meta_data/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-meta_data%2fevents%2fupdated</para>
/// </summary>
public record CorehrCommonDataMetaDataUpdatedV1EventBodyDto() : EventBodyDto("corehr.common_data.meta_data.updated_v1")
{
    /// <summary>
    /// <para>发生变更的对象 API Name，可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询字段详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("api_name")]
    public string? ApiName { get; set; }

    /// <summary>
    /// <para>变更的字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }

    /// <summary>
    /// <para>变更的元数据类型（包括对象和枚举）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("metadata_type")]
    public string? MetadataType { get; set; }

    /// <summary>
    /// <para>变更的枚举</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("enum_value_changes")]
    public string[]? EnumValueChanges { get; set; }
}
