// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-18
//
// Last Modified By : yxr
// Last Modified On : 2025-04-18
// ************************************************************************
// <copyright file="PutBaseV2AppsByAppTokenRolesByRoleIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义角色 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新自定义角色 请求体
/// <para>更新多维表格高级权限中自定义的角色。</para>
/// <para>## 前提条件</para>
/// <para>要调用自定义角色相关接口，你需确保多维表格已开启高级权限。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限。</para>
/// <para>接口ID：7473089245106323460</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/advanced-permission/app-role/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fadvanced-permission%2fbase-v2%2fapp-role%2fupdate</para>
/// </summary>
public record PutBaseV2AppsByAppTokenRolesByRoleIdBodyDto
{
    /// <summary>
    /// <para>自定义角色名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：自定义权限1</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("role_name")]
    public string RoleName { get; set; } = string.Empty;

    /// <summary>
    /// <para>针对数据表的权限设置，未设置该字段的情况下，保持旧值不变</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("table_roles")]
    public TableRole[] TableRoles { get; set; } = Array.Empty<TableRole>();

    /// <summary>
    /// <para>针对数据表的权限设置，未设置该字段的情况下，保持旧值不变</para>
    /// </summary>
    public record TableRole
    {
        /// <summary>
        /// <para>数据表权限。</para>
        /// <para>**提示**：**协作者可编辑自己的记录** 和 **可编辑指定字段** 是 **可编辑记录** 的特殊情况，可通过指定 `rec_rule` 或 `field_perm` 参数实现相同的效果。</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最大值：4</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无权限</item>
        /// <item>1：仅可阅读</item>
        /// <item>2：可编辑</item>
        /// <item>4：可管理</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("table_perm")]
        public int TablePerm { get; set; }

        /// <summary>
        /// <para>数据表名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：数据表1</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
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
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
        /// <para>- rec_rule字段未设置、且 `table_perm `不变的情况下，保持旧值。</para>
        /// <para>- 字段 value 为 {} 的情况下，表示设置为默认值，即全部可编辑或可阅读，具体权限需结合 table_perm 参数。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rec_rule")]
        public TableRoleRecRule? RecRule { get; set; }

        /// <summary>
        /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
        /// <para>- rec_rule字段未设置、且 `table_perm `不变的情况下，保持旧值。</para>
        /// <para>- 字段 value 为 {} 的情况下，表示设置为默认值，即全部可编辑或可阅读，具体权限需结合 table_perm 参数。</para>
        /// </summary>
        public record TableRoleRecRule
        {
            /// <summary>
            /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public RecRuleCondition[]? Conditions { get; set; }

            /// <summary>
            /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
            /// </summary>
            public record RecRuleCondition
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
                /// <para>最大长度：50</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("values")]
                public string[]? Values { get; set; }
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
            /// <para>其他记录权限，仅在 `table_perm` 为 2 （数据表权限为可编辑）时生效。</para>
            /// <para>- 当 `other_perm` 为 1 时，表示未命中 `rec_rule` 的记录仅可阅读，不可编辑</para>
            /// <para>- 当 `other_perm` 为 0 时，表示既未命中 `rec_rule`、也未命中 `other_rec_rule` 的记录会被禁止阅读。即你可以通过 `other_rec_rule` 进一步指定可阅读的记录范围。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
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
        /// <para>记录筛选条件，在 `table_perm` 为 2 且`rec_rule.other_perm` 为 0 时生效。</para>
        /// <para>- 对于未命中 `rec_rule` 的记录，通过 `other_rec_rule` 指定可阅读记录范围；此时，既未命中 `rec_rule`、也未命中 `other_rec_rule` 的记录会被禁止阅读。</para>
        /// <para>- `other_rec_rule` 字段未设置、且 `table_perm` 与 `rec_rule` 不变的情况下，将会保持旧值不变。</para>
        /// <para>- `other_rec_rule` 字段设置为 {} 时，且 `table_perm` 与`rec_rule` 不变的情况下，表示设置为默认值，即非`rec_rule` 记录全部可阅读。</para>
        /// <para>**注意**：仅高级权限为 v2 版本的多维表格支持该参数。是否是 v2 版本可调用[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)查看。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("other_rec_rule")]
        public TableRoleOtherRecRule? OtherRecRule { get; set; }

        /// <summary>
        /// <para>记录筛选条件，在 `table_perm` 为 2 且`rec_rule.other_perm` 为 0 时生效。</para>
        /// <para>- 对于未命中 `rec_rule` 的记录，通过 `other_rec_rule` 指定可阅读记录范围；此时，既未命中 `rec_rule`、也未命中 `other_rec_rule` 的记录会被禁止阅读。</para>
        /// <para>- `other_rec_rule` 字段未设置、且 `table_perm` 与 `rec_rule` 不变的情况下，将会保持旧值不变。</para>
        /// <para>- `other_rec_rule` 字段设置为 {} 时，且 `table_perm` 与`rec_rule` 不变的情况下，表示设置为默认值，即非`rec_rule` 记录全部可阅读。</para>
        /// <para>**注意**：仅高级权限为 v2 版本的多维表格支持该参数。是否是 v2 版本可调用[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)查看。</para>
        /// </summary>
        public record TableRoleOtherRecRule
        {
            /// <summary>
            /// <para>记录筛选条件，用于指定可阅读的记录。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public RecRuleCondition[]? Conditions { get; set; }

            /// <summary>
            /// <para>记录筛选条件，用于指定可阅读的记录。</para>
            /// </summary>
            public record RecRuleCondition
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
                /// <para>最大长度：50</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("values")]
                public string[]? Values { get; set; }
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
        }

        /// <summary>
        /// <para>字段权限，仅在 `table_perm` 为 1和 2 时生效。用于设置字段可编辑或可阅读。类型为 map，key 是字段名称，value 是字段权限。对于未设置的多维表格字段，则为无权限。更新时，`field_perm` 未传值时，将保留旧值不变。`field_perm` 传{}时，则将所有字段设置为默认值可编辑或者可阅读，默认值需结合`table_perm `字段。value 枚举值有：</para>
        /// <para>- `1`：可阅读</para>
        /// <para>- `2`：可添加</para>
        /// <para>- `3`：可编辑</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"姓名": 1, "年龄": 2}</para>
        /// </summary>
        [JsonPropertyName("field_perm")]
        public object? FieldPerm { get; set; }

        /// <summary>
        /// <para>新增记录权限，仅在 `table_perm` 为 2 时生效，用于设置记录是否可以新增。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：true</para>
        /// </summary>
        [JsonPropertyName("allow_add_record")]
        public bool? AllowAddRecord { get; set; }

        /// <summary>
        /// <para>删除记录权限，仅在 `table_perm` 为 2 时生效，用于设置记录是否可以删除。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：true</para>
        /// </summary>
        [JsonPropertyName("allow_delete_record")]
        public bool? AllowDeleteRecord { get; set; }

        /// <summary>
        /// <para>设置视图的编辑权限。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>最大值：2</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：可阅读</item>
        /// <item>2：可编辑</item>
        /// </list></para>
        /// <para>默认值：2</para>
        /// </summary>
        [JsonPropertyName("view_perm")]
        public int? ViewPerm { get; set; }

        /// <summary>
        /// <para>可读的视图集合，仅在 `view_perm` 为 1 （视图为可阅读）时生效。更新时，未设置该字段`view_rules `，且 `view_perm` 未变化的情况下，将保留旧值。设置该字段`view_rules `为{}，且 `view_perm` 为1的情况下，会将所有视图置为可读。</para>
        /// <para>该参数类型为 map，其中 key 是[视图 ID](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/bitable-overview#5b05b8ca)，value 是视图对应的权限。value 枚举值有：</para>
        /// <para>- `0`：无权限</para>
        /// <para>- `1`：可阅读</para>
        /// <para>**注意**：仅高级权限为 v2 版本的多维表格支持该参数。是否是 v2 版本可调用[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)查看。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"vewEYknYcC": 0}</para>
        /// </summary>
        [JsonPropertyName("view_rules")]
        public object? ViewRules { get; set; }

        /// <summary>
        /// <para>更新字段的权限，仅可配置单多选字段、附件字段。可选的点位有：</para>
        /// <para>- `select_option_edit` : 选项配置点位，配置是否可增删改单、多选选项，未设置表示无权限。</para>
        /// <para>- `attachment_export`: 附件操作权限点位，配置是否可导出附件，未设置表示可导出。</para>
        /// <para>该参数类型为两层 map 结构，其中 key 是字段点位权限，value 是字段权限集合。字段权限集合也是一个 map 结构，其中 key 是字段名称，value 是字段点位权限：</para>
        /// <para>- `0`：无权限</para>
        /// <para>- `1`：有权限</para>
        /// <para>**注意**：仅高级权限为 v2 版本的多维表格支持该参数。是否是 v2 版本可调用[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)查看。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"select_option_edit": {"单选1":0}}</para>
        /// </summary>
        [JsonPropertyName("field_action_rules")]
        public object? FieldActionRules { get; set; }
    }

    /// <summary>
    /// <para>针对仪表盘的权限设置。更新是，未设置该字段的情况下，保持旧值不变。设置`block_roles`为{}时，将所有仪表盘更新为默认权限，即所有仪表盘无权限。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("block_roles")]
    public BlockRole[]? BlockRoles { get; set; }

    /// <summary>
    /// <para>针对仪表盘的权限设置。更新是，未设置该字段的情况下，保持旧值不变。设置`block_roles`为{}时，将所有仪表盘更新为默认权限，即所有仪表盘无权限。</para>
    /// </summary>
    public record BlockRole
    {
        /// <summary>
        /// <para>多维表格仪表盘的唯一标识，以 blk 开头。获取方式：</para>
        /// <para>- 在多维表格的 URL 地址栏中，`block_id` 是下图中高亮部分：</para>
        /// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/a966d15323ee73c66b1e9a31d34ae6c7_x3ctncH2nO.png?height=575&amp;lazyload=true&amp;width=1397)</para>
        /// <para>- 通过[列出仪表盘](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-dashboard/list)接口获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：blknkqrP3RqUkcAW</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
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
        /// </summary>
        [JsonPropertyName("block_perm")]
        public int BlockPerm { get; set; }
    }

    /// <summary>
    /// <para>多维表格点位的权限。更新时，未设置`base_rule`字段时，所有点位保持旧值。设置`base_rule`字段为{}时，会将所有点位设置为默认值，即所有点位有权限。</para>
    /// <para>可设置以下两种权限：</para>
    /// <para>- `base_complex_edit` : 设置是否可以创建副本、下载、打印多维表格</para>
    /// <para>- `copy`: 设置是否可以复制多维表格内容</para>
    /// <para>该参数类型为 map，其中 key 是权限点位名称，value 是权限开关。value 枚举值有：</para>
    /// <para>- `0`：无权限</para>
    /// <para>- `1`：有权限</para>
    /// <para>**注意**：仅高级权限为 v2 版本的多维表格支持该参数。是否是 v2 版本可调用[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)查看。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"base_complex_edit": 1, "copy": 0}</para>
    /// </summary>
    [JsonPropertyName("base_rule")]
    public object? BaseRule { get; set; }
}
