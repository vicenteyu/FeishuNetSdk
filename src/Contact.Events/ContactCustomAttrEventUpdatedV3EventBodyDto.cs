// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ContactCustomAttrEventUpdatedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>成员字段变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Events;
/// <summary>
/// 成员字段变更 事件体
/// <para>当成员字段发生变更时（变更动作包括「打开/关闭」开关、「增加/删除」成员字段），会触发该事件。事件体的 old_object 展示字段的原始值，object 展示字段的更新值。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=contact&amp;version=v3&amp;resource=custom_attr_event&amp;event=updated)</para>
/// <para>接口ID：7051452465808080899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/custom_attr/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fcustom_attr_event%2fevents%2fupdated</para>
/// </summary>
public record ContactCustomAttrEventUpdatedV3EventBodyDto() : EventBodyDto("contact.custom_attr_event.updated_v3")
{
    /// <summary>
    /// <para>变更后信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object")]
    public CustomAttrEvent? Object { get; set; }

    /// <summary>
    /// 信息
    /// </summary>
    public record CustomAttrEvent
    {
        /// <summary>
        /// <para>通讯录字段键值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contact_field_key")]
        public string[]? ContactFieldKey { get; set; }

        /// <summary>
        /// <para>开关是否打开</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("allow_open_query")]
        public bool? AllowOpenQuery { get; set; }
    }

    /// <summary>
    /// <para>变更前信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("old_object")]
    public CustomAttrEvent? OldObject { get; set; }
}
