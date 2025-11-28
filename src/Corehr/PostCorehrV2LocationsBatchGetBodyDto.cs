// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2LocationsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过地点 ID 批量获取地点信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过地点 ID 批量获取地点信息 请求体
/// <para>该接口用于根据地点 ID批量查询地点信息，信息包含地点名称、描述、地点用途、工时制度、区域设置、时区以及关联的地址信息等。</para>
/// <para>接口ID：7252157701853167644</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fbatch_get</para>
/// </summary>
public record PostCorehrV2LocationsBatchGetBodyDto
{
    /// <summary>
    /// <para>地点 ID 列表， 地点维护管理员在 飞书人事系统，组织管理模块维护的地点记录 ID。ID获取方式：</para>
    /// <para>- 调用[【创建地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/create)[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)等接口可以返回地点ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("location_ids")]
    public string[] LocationIds { get; set; } = [];
}
