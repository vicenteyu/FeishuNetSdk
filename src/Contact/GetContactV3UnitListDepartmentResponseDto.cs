// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3UnitListDepartmentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取单位绑定的部门列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单位绑定的部门列表 响应体
/// <para>调用该接口获取指定单位绑定的部门列表。</para>
/// <para>接口ID：7023995901275357187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/list_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2flist_department</para>
/// </summary>
public record GetContactV3UnitListDepartmentResponseDto : IPageableResponse<GetContactV3UnitListDepartmentResponseDto.UnitDepartment>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public UnitDepartment[]? Items => Departmentlists;

    /// <summary>
    /// <para>单位绑定的部门列表。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("departmentlist")]
    public UnitDepartment[] Departmentlists { get; set; } = [];

    /// <summary>
    /// <para>单位绑定的部门列表。</para>
    /// </summary>
    public record UnitDepartment
    {
        /// <summary>
        /// <para>单位 ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：BU121</para>
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门 ID。你可以调用[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)接口，获取部门详情。</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JdtW=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
