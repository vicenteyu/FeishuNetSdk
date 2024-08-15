// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutContactV3DepartmentsByDepartmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新部门所有信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新部门所有信息 请求体
/// <para>调用该接口更新指定部门的信息，包括名称、父部门以及负责人等信息。</para>
/// <para>## 注意事项</para>
/// <para>- 调用该接口更新部门信息时，所涉及的所有部门需要在应用的通讯录权限范围内，否则会调用失败，并报无权限错误。了解权限范围，参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 本接口是全量更新接口，没有传值的请求参数默认会被置为空值（部门排序 order 参数除外）。如果你只需要更新部门的部分信息，可参见[修改部门部分信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/patch)。</para>
/// <para>接口ID：6943913881477021723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate</para>
/// </summary>
public record PutContactV3DepartmentsByDepartmentIdBodyDto
{
    /// <summary>
    /// <para>部门名称。</para>
    /// <para>**注意**：</para>
    /// <para>- 不可包含斜杠（`/`）。</para>
    /// <para>- 不能与存量部门名称重复。</para>
    /// <para>必填：是</para>
    /// <para>示例值：DemoName</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>部门名称的国际化配置。</para>
    /// <para>**注意**：</para>
    /// <para>- 不可包含斜杠（`/`）。</para>
    /// <para>- 不能与存量部门名称的国际化配置重复。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_name")]
    public DepartmentI18nName? I18nName { get; set; }

    /// <summary>
    /// <para>部门名称的国际化配置。</para>
    /// <para>**注意**：</para>
    /// <para>- 不可包含斜杠（`/`）。</para>
    /// <para>- 不能与存量部门名称的国际化配置重复。</para>
    /// </summary>
    public record DepartmentI18nName
    {
        /// <summary>
        /// <para>部门的中文名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Demo名称</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>部门的日文名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：デモ名</para>
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public string? JaJp { get; set; }

        /// <summary>
        /// <para>部门的英文名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Demo Name</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }
    }

    /// <summary>
    /// <para>父部门的 ID。部门 ID 获取方式：</para>
    /// <para>- 如果需要将部门的父部门设置为根部门，则该参数取值 `0`。</para>
    /// <para>- 你可以调用[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)接口获取所需的部门 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：D067</para>
    /// </summary>
    [JsonPropertyName("parent_department_id")]
    public string ParentDepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>部门主管的用户 ID。ID 类型与查询参数 user_id_type 的取值保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>**注意**：部门主管（leader_user_id）和部门主负责人（leaderType 取值为 1 所对应的 leaderID）取值始终一致。因此：</para>
    /// <para>- 如果同时设置了部门主负责人（leaderType 取值为 1 所对应的 leaderID），则此处设置的部门主管必须与部门主负责人为同一个人。</para>
    /// <para>- 仅修改部门主管，会同步修改部门主负责人（leaderType 取值为 1 所对应的 leaderID）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("leader_user_id")]
    public string? LeaderUserId { get; set; }

    /// <summary>
    /// <para>部门的排序，即部门在其同级部门的展示顺序。取值格式为 String 类型的非负整数，数值越小，排序越靠前。</para>
    /// <para>**注意**：</para>
    /// <para>- order 值唯一，即传入的值不能与存量部门的 order 值重复。</para>
    /// <para>- 不传值表示不修改部门原有的 order 值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// <para>部门绑定的单位自定义 ID 列表，当前只支持绑定一个单位。</para>
    /// <para>- 了解单位信息参见[资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/unit/overview)。</para>
    /// <para>- 调用[获取单位列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/unit/list)接口，可获取单位 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：custom_unit_id</para>
    /// </summary>
    [JsonPropertyName("unit_ids")]
    public string[]? UnitIds { get; set; }

    /// <summary>
    /// <para>是否创建部门群。</para>
    /// <para>**可选值有：**</para>
    /// <para>- true：创建。</para>
    /// <para>- false：不创建。</para>
    /// <para>**说明**：</para>
    /// <para>- 如果部门之前没有部门群，则取值为 true 会创建部门群，创建时，群名默认为部门名，群主默认为部门主负责人。</para>
    /// <para>- 如果部门之前已创建了部门群，则该参数无论是否传值均不会影响原有部门群。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("create_group_chat")]
    public bool? CreateGroupChat { get; set; }

    /// <summary>
    /// <para>部门负责人信息。</para>
    /// <para>**注意**：</para>
    /// <para>- 配置该参数时，必须指定一名主负责人。</para>
    /// <para>- 设置多名负责人时，仅支持将某一负责人设置为主负责人。</para>
    /// <para>- 部门主管（leader_user_id）和部门主负责人（leaderType 取值为 1 所对应的 leaderID）取值始终一致。因此：</para>
    /// <para>- 如果同时设置了部门主管（leader_user_id），则此处设置的部门主负责人必须与部门主管为同一个人。</para>
    /// <para>- 仅修改部门主负责人，会同步修改部门主管（leader_user_id）。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("leaders")]
    public DepartmentLeader[]? Leaders { get; set; }

    /// <summary>
    /// <para>部门负责人信息。</para>
    /// <para>**注意**：</para>
    /// <para>- 配置该参数时，必须指定一名主负责人。</para>
    /// <para>- 设置多名负责人时，仅支持将某一负责人设置为主负责人。</para>
    /// <para>- 部门主管（leader_user_id）和部门主负责人（leaderType 取值为 1 所对应的 leaderID）取值始终一致。因此：</para>
    /// <para>- 如果同时设置了部门主管（leader_user_id），则此处设置的部门主负责人必须与部门主管为同一个人。</para>
    /// <para>- 仅修改部门主负责人，会同步修改部门主管（leader_user_id）。</para>
    /// </summary>
    public record DepartmentLeader
    {
        /// <summary>
        /// <para>负责人类型。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：主负责人。</item>
        /// <item>2：副负责人。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("leaderType")]
        public int LeaderType { get; set; }

        /// <summary>
        /// <para>负责人的用户 ID，ID 类型与查询参数 user_id_type 的取值保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("leaderID")]
        public string LeaderID { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>部门群的人员类型限制。</para>
    /// <para>人员类型的取值范围如下。该参数支持设置多个类型值，若有多个，用英文 `,` 分隔：</para>
    /// <para>- 1：正式员工</para>
    /// <para>- 2：实习生</para>
    /// <para>- 3：外包</para>
    /// <para>- 4：劳务</para>
    /// <para>- 5：顾问</para>
    /// <para>该参数支持传入自定义人员类型对应的编号。你可以调用[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口获取相应编号（enum_value）。</para>
    /// <para>**说明**：如果部门之前已创建了部门群，则该参数不传值时，默认不会修改原有的部门群人员类型限制。</para>
    /// <para>必填：否</para>
    /// <para>示例值：[1,2,3]</para>
    /// </summary>
    [JsonPropertyName("group_chat_employee_types")]
    public int[]? GroupChatEmployeeTypes { get; set; }
}
