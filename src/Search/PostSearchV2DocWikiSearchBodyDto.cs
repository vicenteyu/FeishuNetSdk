// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-30
// ************************************************************************
// <copyright file="PostSearchV2DocWikiSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索文档 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Search;
/// <summary>
/// 搜索文档 请求体
/// <para>该接口用于根据搜索关键词（query）对当前用户可见的云文档进行搜索</para>
/// <para>接口ID：7589313298248600535</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/doc_wiki/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdoc_wiki%2fsearch</para>
/// </summary>
public record PostSearchV2DocWikiSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词（query至少搭配一种doc/wiki筛选器）</para>
    /// <para>必填：是</para>
    /// <para>示例值：飞书文档使用指南</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档过滤参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"folder_tokens": ["fld_123456"]}</para>
    /// </summary>
    [JsonPropertyName("doc_filter")]
    public DocFilterSuffix? DocFilter { get; set; }

    /// <summary>
    /// <para>文档过滤参数</para>
    /// </summary>
    public record DocFilterSuffix
    {
        /// <summary>
        /// <para>文档所有者OpenID</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("creator_ids")]
        public string[]? CreatorIds { get; set; }

        /// <summary>
        /// <para>文档类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DOC：文档</item>
        /// <item>SHEET：表格</item>
        /// <item>BITABLE：多维表格</item>
        /// <item>MINDNOTE：思维导图</item>
        /// <item>FILE：文件</item>
        /// <item>WIKI：wiki</item>
        /// <item>DOCX：新版文档</item>
        /// <item>FOLDER：space文件夹</item>
        /// <item>CATALOG：wiki2.0文件夹</item>
        /// <item>SLIDES：新版本幻灯片</item>
        /// <item>SHORTCUT：快捷方式</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("doc_types")]
        public string[]? DocTypes { get; set; }

        /// <summary>
        /// <para>搜索文件夹内的文档（文件夹token列表）</para>
        /// <para>注：如果存在该字段则wiki筛选器失效</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("folder_tokens")]
        public string[]? FolderTokens { get; set; }

        /// <summary>
        /// <para>仅搜文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("only_title")]
        public bool? OnlyTitle { get; set; }

        /// <summary>
        /// <para>浏览文档的时间范围（秒级时间戳，包含start和end字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_time")]
        public TimeRange? OpenTime { get; set; }

        /// <summary>
        /// <para>浏览文档的时间范围（秒级时间戳，包含start和end字段）</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>时间范围的起始时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1742348544</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("start")]
            public long? Start { get; set; }

            /// <summary>
            /// <para>时间范围的截止时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1742348544</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("end")]
            public long? End { get; set; }
        }

        /// <summary>
        /// <para>排序方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：CREATE_TIME</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DEFAULT_TYPE：默认排序</item>
        /// <item>OPEN_TIME：User打开时间排序</item>
        /// <item>EDIT_TIME：User编辑时间降序</item>
        /// <item>EDIT_TIME_ASC：User编辑时间升序</item>
        /// <item>ENTITY_CREATE_TIME_ASC：实体创建时间升序</item>
        /// <item>ENTITY_CREATE_TIME_DESC：实体创建时间降序</item>
        /// <item>CREATE_TIME：按文档创建时间排序</item>
        /// <item>CREATE_TIME_ASC：按文档创建时间正序（该排序暂不支持）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("sort_type")]
        public string? SortType { get; set; }

        /// <summary>
        /// <para>文档创建的时间范围（秒级时间戳，包含start和end字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public TimeRange? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>Wiki过滤参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"creator_ids": ["ou_789012"], "space_ids": ["space_123456"]}</para>
    /// </summary>
    [JsonPropertyName("wiki_filter")]
    public WikiFilterSuffix? WikiFilter { get; set; }

    /// <summary>
    /// <para>Wiki过滤参数</para>
    /// </summary>
    public record WikiFilterSuffix
    {
        /// <summary>
        /// <para>Wiki所有者OpenID</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("creator_ids")]
        public string[]? CreatorIds { get; set; }

        /// <summary>
        /// <para>Wiki类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DOC：文档</item>
        /// <item>SHEET：表格</item>
        /// <item>BITABLE：多维表格</item>
        /// <item>MINDNOTE：思维导图</item>
        /// <item>FILE：文件</item>
        /// <item>WIKI：维基</item>
        /// <item>DOCX：新版文档</item>
        /// <item>FOLDER：space文件夹</item>
        /// <item>CATALOG：wiki2.0文件夹</item>
        /// <item>SLIDES：新版本幻灯片</item>
        /// <item>SHORTCUT：快捷方式</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("doc_types")]
        public string[]? DocTypes { get; set; }

        /// <summary>
        /// <para>搜索某个Space下的Wiki（Space ID列表）</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("space_ids")]
        public string[]? SpaceIds { get; set; }

        /// <summary>
        /// <para>仅搜Wiki标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("only_title")]
        public bool? OnlyTitle { get; set; }

        /// <summary>
        /// <para>浏览文档的时间范围（秒级时间戳，包含start和end字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_time")]
        public TimeRange? OpenTime { get; set; }

        /// <summary>
        /// <para>浏览文档的时间范围（秒级时间戳，包含start和end字段）</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>时间范围的起始时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1742348544</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("start")]
            public int? Start { get; set; }

            /// <summary>
            /// <para>时间范围的截止时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1742348544</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("end")]
            public int? End { get; set; }
        }

        /// <summary>
        /// <para>排序方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：CREATE_TIME</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DEFAULT_TYPE：默认排序</item>
        /// <item>OPEN_TIME：User打开时间排序</item>
        /// <item>EDIT_TIME：User编辑时间降序</item>
        /// <item>EDIT_TIME_ASC：User编辑时间升序</item>
        /// <item>ENTITY_CREATE_TIME_ASC：实体创建时间升序</item>
        /// <item>ENTITY_CREATE_TIME_DESC：实体创建时间降序</item>
        /// <item>CREATE_TIME：按文档创建时间排序</item>
        /// <item>CREATE_TIME_ASC：按文档创建时间正序（该排序暂不支持）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("sort_type")]
        public string? SortType { get; set; }

        /// <summary>
        /// <para>Wiki创建的时间范围（秒级时间戳，包含start和end字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public TimeRange? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：token_1234567890fedcba</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：否</para>
    /// <para>示例值：15</para>
    /// <para>最大值：20</para>
    /// <para>最小值：0</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }
}
