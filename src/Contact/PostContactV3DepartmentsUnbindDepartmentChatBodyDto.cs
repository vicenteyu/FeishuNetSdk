// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3DepartmentsUnbindDepartmentChatBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>部门群转为普通群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 部门群转为普通群 请求体
/// <para>调用该接口将指定部门的部门群转为普通群。</para>
/// <para>## 注意事项</para>
/// <para>应用的通讯录权限范围内需要包含当前操作的部门。了解权限范围，参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7069758645957836801</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/unbind_department_chat</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2funbind_department_chat</para>
/// </summary>
public record PostContactV3DepartmentsUnbindDepartmentChatBodyDto
{
    /// <summary>
    /// <para>部门 ID，ID 类型需要与查询参数 department_id_type 的取值保持一致。ID 获取方式说明：</para>
    /// <para>- 调用[创建部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/create)接口后，可从返回结果中获取到部门 ID 信息。</para>
    /// <para>- 部门 API 提供了多种获取其他部门 ID 的方式，如[获取子部门列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/children)、[获取父部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/parent)、[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)，你可以选择合适的 API 进行查询。</para>
    /// <para>必填：是</para>
    /// <para>示例值：D096</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;
}
