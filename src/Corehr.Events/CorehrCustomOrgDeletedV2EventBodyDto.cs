// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="CorehrCustomOrgDeletedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>自定义组织被删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 自定义组织被删除 事件体
/// <para>飞书人事中「自定义组织被删除」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=custom_org&amp;event=deleted)</para>
/// <para>接口ID：7478258640808443908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fevents%2fdeleted</para>
/// </summary>
public record CorehrCustomOrgDeletedV2EventBodyDto() : EventBodyDto("corehr.custom_org.deleted_v2")
{
    /// <summary>
    /// <para>被删除自定义组织的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("org_id")]
    public string? OrgId { get; set; }

    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织设置」中相应的自定义组织目录下查看</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string? ObjectApiName { get; set; }
}
