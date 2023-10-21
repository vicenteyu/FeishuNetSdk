using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出自定义角色 响应体
/// <para>列出自定义角色</para>
/// <para>接口ID：7101134500528701443</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenRolesResponseDto
{
    /// <summary>
    /// <para>自定义角色列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public AppRole[]? Items { get; set; }

    /// <summary>
    /// <para>自定义角色列表</para>
    /// </summary>
    public record AppRole
    {
        /// <summary>
        /// <para>自定义角色的名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：自定义权限1</para>
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义角色的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：roljRpwIUt</para>
        /// </summary>
        [JsonProperty("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// <para>数据表角色</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("table_roles")]
        public AppRoleTableRole[] TableRoles { get; set; } = Array.Empty<AppRoleTableRole>();

        /// <summary>
        /// <para>数据表角色</para>
        /// </summary>
        public record AppRoleTableRole
        {
            /// <summary>
            /// <para>数据表名</para>
            /// <para>必填：否</para>
            /// <para>示例值：数据表1</para>
            /// </summary>
            [JsonProperty("table_name")]
            public string? TableName { get; set; }

            /// <summary>
            /// <para>数据表ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：tblKz5D60T4JlfcT</para>
            /// </summary>
            [JsonProperty("table_id")]
            public string? TableId { get; set; }

            /// <summary>
            /// <para>数据表权限，`协作者可编辑自己的记录`和`可编辑指定字段`是`可编辑记录`的特殊情况，可通过指定`rec_rule`或`field_perm`参数实现相同的效果</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：无权限</item>
            /// <item>1：可阅读</item>
            /// <item>2：可编辑记录</item>
            /// <item>4：可编辑字段和记录</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonProperty("table_perm")]
            public int TablePerm { get; set; }

            /// <summary>
            /// <para>记录筛选条件，在table_perm为1或2时有意义，用于指定可编辑或可阅读某些记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("rec_rule")]
            public AppRoleTableRoleRecRule? RecRule { get; set; }

            /// <summary>
            /// <para>记录筛选条件，在table_perm为1或2时有意义，用于指定可编辑或可阅读某些记录</para>
            /// </summary>
            public record AppRoleTableRoleRecRule
            {
                /// <summary>
                /// <para>记录筛选条件</para>
                /// <para>必填：是</para>
                /// <para>最大长度：100</para>
                /// </summary>
                [JsonProperty("conditions")]
                public AppRoleTableRoleRecRuleCondition[] Conditions { get; set; } = Array.Empty<AppRoleTableRoleRecRuleCondition>();

                /// <summary>
                /// <para>记录筛选条件</para>
                /// </summary>
                public record AppRoleTableRoleRecRuleCondition
                {
                    /// <summary>
                    /// <para>字段名，记录筛选条件是`创建人包含访问者本人`时，此参数值为""</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：单选</para>
                    /// </summary>
                    [JsonProperty("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>运算符</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：is</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>is：等于</item>
                    /// <item>isNot：不等于</item>
                    /// <item>contains：包含</item>
                    /// <item>doesNotContain：不包含</item>
                    /// <item>isEmpty：为空</item>
                    /// <item>isNotEmpty：不为空</item>
                    /// </list></para>
                    /// <para>默认值：is</para>
                    /// </summary>
                    [JsonProperty("operator")]
                    public string? Operator { get; set; }

                    /// <summary>
                    /// <para>单选或多选字段的选项id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：["optbdVHf4q","optrpd3eIJ"]</para>
                    /// </summary>
                    [JsonProperty("value")]
                    public string[]? Value { get; set; }

                    /// <summary>
                    /// <para>字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
                    /// </summary>
                    [JsonProperty("field_type")]
                    public int? FieldType { get; set; }
                }

                /// <summary>
                /// <para>多个筛选条件的关系</para>
                /// <para>必填：否</para>
                /// <para>示例值：and</para>
                /// <para>可选值：<list type="bullet">
                /// <item>and：与</item>
                /// <item>or：或</item>
                /// </list></para>
                /// <para>默认值：and</para>
                /// </summary>
                [JsonProperty("conjunction")]
                public string? Conjunction { get; set; }

                /// <summary>
                /// <para>其他记录权限，仅在table_perm为2时有意义</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：禁止查看</item>
                /// <item>1：仅可阅读</item>
                /// </list></para>
                /// <para>默认值：0</para>
                /// </summary>
                [JsonProperty("other_perm")]
                public int? OtherPerm { get; set; }
            }

            /// <summary>
            /// <para>字段权限，仅在table_perm为2时有意义，设置字段可编辑或可阅读。类型为 map，key 是字段名，value 是字段权限</para>
            /// <para>**value 枚举值有：**</para>
            /// <para>- `1`：可阅读</para>
            /// <para>- `2`：可编辑</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"姓名":1,"年龄":2}</para>
            /// </summary>
            [JsonProperty("field_perm")]
            public object? FieldPerm { get; set; }

            /// <summary>
            /// <para>新增记录权限，仅在table_perm为2时有意义，用于设置记录是否可以新增。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonProperty("allow_add_record")]
            public bool? AllowAddRecord { get; set; }

            /// <summary>
            /// <para>删除记录权限，仅在table_perm为2时有意义，用于设置记录是否可以删除</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonProperty("allow_delete_record")]
            public bool? AllowDeleteRecord { get; set; }
        }

        /// <summary>
        /// <para>block权限</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("block_roles")]
        public AppRoleBlockRole[]? BlockRoles { get; set; }

        /// <summary>
        /// <para>block权限</para>
        /// </summary>
        public record AppRoleBlockRole
        {
            /// <summary>
            /// <para>Block 的 ID，例如列出仪表盘接口中的仪表盘 block  id</para>
            /// <para>必填：是</para>
            /// <para>示例值：blknkqrP3RqUkcAW</para>
            /// </summary>
            [JsonProperty("block_id")]
            public string BlockId { get; set; } = string.Empty;

            /// <summary>
            /// <para>Block类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：dashboard</para>
            /// <para>可选值：<list type="bullet">
            /// <item>dashboard：仪表盘</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("block_type")]
            public string? BlockType { get; set; }

            /// <summary>
            /// <para>Block权限</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：无权限</item>
            /// <item>1：可阅读</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonProperty("block_perm")]
            public int BlockPerm { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：\-</para>
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }
}
