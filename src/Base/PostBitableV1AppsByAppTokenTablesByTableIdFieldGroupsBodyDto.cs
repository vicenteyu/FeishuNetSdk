// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建字段编组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 创建字段编组 请求体
/// <para>该接口用于为多维表格数据表的字段创建编组。创建字段编组后，字段将被组织到该编组中，便于多维表格的数据管理</para>
/// <para>#### 业务使用场景</para>
/// <para>适用于多维表格字段较多，需要分类管理字段的场景</para>
/// <para>接口ID：7600708368865856725</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field_group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field_group%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsBodyDto
{
    /// <summary>
    /// <para>要新增字段编组列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：300</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("field_groups")]
    public FieldGroup[] FieldGroups { get; set; } = [];

    /// <summary>
    /// <para>要新增字段编组列表</para>
    /// </summary>
    public record FieldGroup
    {
        /// <summary>
        /// <para>字段编组的ID，默认由系统生成新的字段编组ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldPTb0U2y</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>字段编组的名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：用户信息组</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段编组的成员</para>
        /// <para>必填：是</para>
        /// <para>最大长度：300</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("children")]
        public FieldGroupChild[] Childrens { get; set; } = [];

        /// <summary>
        /// <para>字段编组的成员</para>
        /// </summary>
        public record FieldGroupChild
        {
            /// <summary>
            /// <para>编组成员类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：field</para>
            /// <para>可选值：<list type="bullet">
            /// <item>field：字段</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>编组成员ID，必须与type的取值一致（如type为field时，id为字段的ID）；字段ID可以通过调用[获取字段列表]接口获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：fldPTb0U2y</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>字段编组的描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：用于组织用户信息相关的字段</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
