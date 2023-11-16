namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 批量新增部门 请求体
/// <para>该接口用于向通讯录中批量新增多个部门。</para>
/// <para>调用该接口需要具有所有新增部门父部门的授权范围。</para>
/// <para>应用商店应用无权限调用此接口。</para>
/// <para>调用该接口需要申请 `更新通讯录` 以及 `以应用身份访问通讯录` 权限。</para>
/// <para>接口ID：6907569524101021697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-departments</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDOwUjLzgDM14yM4ATN</para>
/// </summary>
public record PostContactV2DepartmentBatchAddBodyDto
{
    /// <summary>
    /// <para>所有要新增部门的集合。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public Department[] Departments { get; set; } = Array.Empty<Department>();

    /// <summary></summary>
    public record Department
    {
        /// <summary>
        /// <para>自定义部门 ID，企业内必须唯一。只能在创建部门时指定，不支持更新。</para>
        /// <para>若不填该参数，将自动生成。</para>
        /// <para>不区分大小写，长度为 1 ~ 64 个字符。只能由数字、字母和“_”、“-”、“@”、“.”四种特殊字符组成，且第一个字符必须是数字或字母。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门名称。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>父部门 ID。</para>
        /// <para>当被添加的部门为企业一级部门时，此字段填写“0”。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门负责人 ID，支持通过 user_id 或 open_id 进行设置。请求同时传递两个字段时只使用 leader_user_id，忽略 leader_open_id。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>部门负责人 ID，支持通过 user_id 或 open_id 进行设置。请求同时传递两个字段时只使用 leader_user_id，忽略 leader_open_id。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_open_id")]
        public string? LeaderOpenId { get; set; }

        /// <summary>
        /// <para>是否同时创建部门群，默认为 false，不创建部门群。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_group_chat")]
        public bool? CreateGroupChat { get; set; }
    }
}
