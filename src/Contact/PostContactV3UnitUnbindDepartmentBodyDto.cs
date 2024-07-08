// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UnitUnbindDepartmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>解除部门与单位的绑定关系 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 解除部门与单位的绑定关系 请求体
/// <para>调用该接口解除部门与单位的绑定关系。</para>
/// <para>接口ID：7023995901275340803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/unbind_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2funbind_department</para>
/// </summary>
public record PostContactV3UnitUnbindDepartmentBodyDto
{
    /// <summary>
    /// <para>单位 ID。</para>
    /// <para>当你在创建单位时，可以在返回结果中获取单位 ID。你也可以调用[获取单位列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/unit/list)接口，获取单位 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonPropertyName("unit_id")]
    public string UnitId { get; set; } = string.Empty;

    /// <summary>
    /// <para>待解除关联的部门 ID。ID 类型与 department_id_type 的取值保持一致。</para>
    /// <para>部门 API 提供了多种获取部门 ID 的方式，如[获取子部门列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/children)、[获取父部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/parent)、[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)，你可以选择合适的 API 进行查询。</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>此次调用中的部门 ID 类型。关于部门 ID 的详细介绍，可参见[部门 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_department_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>department_id：支持用户自定义配置的部门 ID。自定义配置时可复用已删除的 department_id，因此在未删除的部门范围内 department_id 具有唯一性。</item>
    /// <item>open_department_id：由系统自动生成的部门 ID，ID 前缀固定为 `od-`，在租户内全局唯一。</item>
    /// </list></para>
    /// <para>默认值：open_department_id</para>
    /// </summary>
    [JsonPropertyName("department_id_type")]
    public string? DepartmentIdType { get; set; }
}
