// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenRolesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增自定义角色 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增自定义角色 请求体
/// <para>新增多维表格高级权限中自定义的角色。</para>
/// <para>## 前提条件</para>
/// <para>要调用自定义角色相关接口，你需确保多维表格已开启高级权限。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限。</para>
/// <para>接口ID：7101134500528734211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenRolesBodyDto
{
    /// <summary>
    /// <para>自定义角色名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：普通用户</para>
    /// </summary>
    [JsonPropertyName("role_name")]
    public string RoleName { get; set; } = string.Empty;

    /// <summary>
    /// <para>针对数据表的权限设置</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("table_roles")]
    public AppRoleTableRole[] TableRoles { get; set; } = Array.Empty<AppRoleTableRole>();

    /// <summary>
    /// <para>针对数据表的权限设置</para>
    /// </summary>
    public record AppRoleTableRole
    {
        /// <summary>
        /// <para>数据表权限。</para>
        /// <para>**提示**：**协作者可编辑自己的记录** 和 **可编辑指定字段** 是 **可编辑记录** 的特殊情况，可通过指定 `rec_rule` 或 `field_perm` 参数实现相同的效果。</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无权限</item>
        /// <item>1：仅可阅读</item>
        /// <item>2：可编辑记录</item>
        /// <item>4：可编辑字段和记录</item>
        /// </list></para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("table_perm")]
        public int TablePerm { get; set; }

        /// <summary>
        /// <para>数据表名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：数据表1</para>
        /// </summary>
        [JsonPropertyName("table_name")]
        public string? TableName { get; set; }

        /// <summary>
        /// <para>多维表格数据表的唯一标识。获取方式：</para>
        /// <para>- 你可通过多维表格 URL 获取 `table_id`，下图高亮部分即为当前数据表的 `table_id`</para>
        /// <para>- 也可通过[列出数据表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/list)接口获取 `table_id`</para>
        /// <para>![](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/18741fe2a0d3cafafaf9949b263bb57d_yD1wkOrSju.png?height=746&amp;lazyload=true&amp;maxWidth=700&amp;width=2976)</para>
        /// <para>必填：否</para>
        /// <para>示例值：tblKz5D60T4JlfcT</para>
        /// </summary>
        [JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rec_rule")]
        public AppRoleTableRoleRecRule? RecRule { get; set; }

        /// <summary>
        /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
        /// </summary>
        public record AppRoleTableRoleRecRule
        {
            /// <summary>
            /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
            /// <para>必填：是</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public AppRoleTableRoleRecRuleCondition[] Conditions { get; set; } = Array.Empty<AppRoleTableRoleRecRuleCondition>();

            /// <summary>
            /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
            /// </summary>
            public record AppRoleTableRoleRecRuleCondition
            {
                /// <summary>
                /// <para>条件字段的名称。记录筛选条件是“创建人包含访问者本人”时，此参数值为 ""。</para>
                /// <para>必填：是</para>
                /// <para>示例值：单选</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>条件运算符</para>
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
                [JsonPropertyName("operator")]
                public string? Operator { get; set; }

                /// <summary>
                /// <para>条件的值，可以是单个值或多个值的数组。详情参考[字段目标值（value）填写说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/record-filter-guide#3e0fd644)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：["optbdVHf4q", "optrpd3eIJ"]</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string[]? Value { get; set; }
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
            [JsonPropertyName("conjunction")]
            public string? Conjunction { get; set; }

            /// <summary>
            /// <para>其他记录权限，仅当 `table_perm` 为 2 时生效。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：禁止查看</item>
            /// <item>1：仅可阅读</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("other_perm")]
            public int? OtherPerm { get; set; }
        }

        /// <summary>
        /// <para>字段权限，仅在 `table_perm` 为 2 时生效。用于设置字段可编辑或可阅读。类型为 map，key 是字段名称，value 是字段权限。value 枚举值有：</para>
        /// <para>- `1`：可阅读</para>
        /// <para>- `2`：可编辑</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"姓名": 1, "年龄": 2}</para>
        /// </summary>
        [JsonPropertyName("field_perm")]
        public Dictionary<string, int>? FieldPerm { get; set; }

        /// <summary>
        /// <para>新增记录权限，仅当 `table_perm` 为 2 时生效。用于设置记录是否可以新增。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：true</para>
        /// </summary>
        [JsonPropertyName("allow_add_record")]
        public bool? AllowAddRecord { get; set; }

        /// <summary>
        /// <para>删除记录权限，仅当 `table_perm` 为 2 时生效。用于设置记录是否可以删除。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：true</para>
        /// </summary>
        [JsonPropertyName("allow_delete_record")]
        public bool? AllowDeleteRecord { get; set; }
    }

    /// <summary>
    /// <para>针对仪表盘的权限设置</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("block_roles")]
    public AppRoleBlockRole[]? BlockRoles { get; set; }

    /// <summary>
    /// <para>针对仪表盘的权限设置</para>
    /// </summary>
    public record AppRoleBlockRole
    {
        /// <summary>
        /// <para>多维表格仪表盘的唯一标识，以 blk 开头。获取方式：</para>
        /// <para>- 在多维表格的 URL 地址栏中，`block_id` 是下图中高亮部分：</para>
        /// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/a966d15323ee73c66b1e9a31d34ae6c7_x3ctncH2nO.png?height=575&amp;lazyload=true&amp;width=1397)</para>
        /// <para>- 通过[列出仪表盘](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-dashboard/list)接口获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：blknkqrP3RqUkcAW</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; } = string.Empty;

        /// <summary>
        /// <para>仪表盘的权限</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无权限</item>
        /// <item>1：可阅读</item>
        /// </list></para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("block_perm")]
        public int BlockPerm { get; set; }
    }
}
