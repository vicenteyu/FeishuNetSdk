// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="Block.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Block 块元素</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// Block 块元素
/// </summary>
public record Block
{
    /// <summary>
    /// <para>Block 唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：doxcnSS4ouQkQEouGSUkTg9NJPe</para>
    /// </summary>
    [JsonPropertyName("block_id")]
    public string? BlockId { get; set; }

    /// <summary>
    /// <para>block 的父亲 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>block 的孩子 id 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：[doxcnO6UW6wAw2qIcYf4hZpFIth]</para>
    /// </summary>
    [JsonPropertyName("children")]
    public string[]? Children { get; set; }

    /// <summary>
    /// <para>block 类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：页面 Block</item>
    /// <item>2：文本 Block</item>
    /// <item>3：标题 1 Block</item>
    /// <item>4：标题 2 Block</item>
    /// <item>5：标题 3 Block</item>
    /// <item>6：标题 4 Block</item>
    /// <item>7：标题 5 Block</item>
    /// <item>8：标题 6 Block</item>
    /// <item>9：标题 7 Block</item>
    /// <item>10：标题 8 Block</item>
    /// <item>11：标题 9 Block</item>
    /// <item>12：无序列表 Block</item>
    /// <item>13：有序列表 Block</item>
    /// <item>14：代码块 Block</item>
    /// <item>15：引用 Block</item>
    /// <item>17：待办事项 Block</item>
    /// <item>18：多维表格 Block</item>
    /// <item>19：高亮块 Block</item>
    /// <item>20：会话卡片 Block</item>
    /// <item>21：流程图 &amp; UML Block</item>
    /// <item>22：分割线 Block</item>
    /// <item>23：文件 Block</item>
    /// <item>24：分栏 Block</item>
    /// <item>25：分栏列 Block</item>
    /// <item>26：内嵌 Block Block</item>
    /// <item>27：图片 Block</item>
    /// <item>28：开放平台小组件 Block</item>
    /// <item>29：思维笔记 Block</item>
    /// <item>30：电子表格 Block</item>
    /// <item>31：表格 Block</item>
    /// <item>32：表格单元格 Block</item>
    /// <item>33：视图 Block</item>
    /// <item>34：引用容器 Block</item>
    /// <item>35：任务 Block</item>
    /// <item>36：OKR Block</item>
    /// <item>37：OKR Objective</item>
    /// <item>38：OKR Key Result</item>
    /// <item>39：OKR 进展</item>
    /// <item>40：文档小组件</item>
    /// <item>41：Jira Issue</item>
    /// <item>42：Wiki 子目录 Block</item>
    /// <item>43：画板 Block</item>
    /// <item>44：议程 Block</item>
    /// <item>45：议程项 Block</item>
    /// <item>46：议程项标题 Block</item>
    /// <item>47：议程项内容 Block</item>
    /// <item>48：链接预览 Block</item>
    /// <item>49：源同步块</item>
    /// <item>50：引用同步块</item>
    /// <item>51：新版 Wiki 子目录 Block</item>
    /// <item>52：AI 模板 Block</item>
    /// <item>999：未支持 Block</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("block_type")]
    public int BlockType { get; set; }

    /// <summary>
    /// <para>文档 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page")]
    public BlockText? Page { get; set; }

    /// <summary>
    /// <para>文本 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("text")]
    public BlockText? Text { get; set; }

    /// <summary>
    /// <para>一级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading1")]
    public BlockText? Heading1 { get; set; }

    /// <summary>
    /// <para>二级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading2")]
    public BlockText? Heading2 { get; set; }

    /// <summary>
    /// <para>三级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading3")]
    public BlockText? Heading3 { get; set; }

    /// <summary>
    /// <para>四级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading4")]
    public BlockText? Heading4 { get; set; }

    /// <summary>
    /// <para>五级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading5")]
    public BlockText? Heading5 { get; set; }

    /// <summary>
    /// <para>六级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading6")]
    public BlockText? Heading6 { get; set; }

    /// <summary>
    /// <para>七级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading7")]
    public BlockText? Heading7 { get; set; }

    /// <summary>
    /// <para>八级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading8")]
    public BlockText? Heading8 { get; set; }

    /// <summary>
    /// <para>九级标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("heading9")]
    public BlockText? Heading9 { get; set; }

    /// <summary>
    /// <para>无序列表 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bullet")]
    public BlockText? Bullet { get; set; }

    /// <summary>
    /// <para>有序列表 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ordered")]
    public BlockText? Ordered { get; set; }

    /// <summary>
    /// <para>代码块 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public BlockText? Code { get; set; }

    /// <summary>
    /// <para>引用 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("quote")]
    public BlockText? Quote { get; set; }

    /// <summary>
    /// <para>公式 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("equation")]
    public BlockText? Equation { get; set; }

    /// <summary>
    /// <para>任务 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("todo")]
    public BlockText? Todo { get; set; }

    /// <summary>
    /// <para>多维表格 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bitable")]
    public BlockBitable? Bitable { get; set; }

    /// <summary>
    /// <para>高亮块 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("callout")]
    public BlockCallout? Callout { get; set; }

    /// <summary>
    /// <para>群聊卡片 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_card")]
    public BlockChatCard? ChatCard { get; set; }

    /// <summary>
    /// <para>流程图/UML Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("diagram")]
    public BlockDiagram? Diagram { get; set; }

    /// <summary>
    /// <para>分割线 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("divider")]
    public object? Divider { get; set; }

    /// <summary>
    /// <para>文件 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file")]
    public BlockFile? File { get; set; }

    /// <summary>
    /// <para>分栏 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("grid")]
    public BlockGrid? Grid { get; set; }

    /// <summary>
    /// <para>分栏列 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("grid_column")]
    public BlockGridColumn? GridColumn { get; set; }

    /// <summary>
    /// <para>内嵌 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("iframe")]
    public BlockIframe? Iframe { get; set; }

    /// <summary>
    /// <para>图片 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("image")]
    public BlockImage? Image { get; set; }

    /// <summary>
    /// <para>三方 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("isv")]
    public BlockIsv? Isv { get; set; }

    /// <summary>
    /// <para>Add-ons</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_ons")]
    public BlockAddOns? AddOns { get; set; }

    /// <summary>
    /// <para>思维笔记 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mindnote")]
    public BlockMindnote? Mindnote { get; set; }

    /// <summary>
    /// <para>电子表格 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet")]
    public BlockSheet? Sheet { get; set; }

    /// <summary>
    /// <para>表格 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table")]
    public BlockTable? Table { get; set; }

    /// <summary>
    /// <para>单元格 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table_cell")]
    public object? TableCell { get; set; }

    /// <summary>
    /// <para>视图 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("view")]
    public BlockView? View { get; set; }

    /// <summary>
    /// <para>未支持 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("undefined")]
    public object? Undefined { get; set; }

    /// <summary>
    /// <para>引用容器 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("quote_container")]
    public object? QuoteContainer { get; set; }

    /// <summary>
    /// <para>任务 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task")]
    public BlockTask? Task { get; set; }

    /// <summary>
    /// <para>OKR Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("okr")]
    public BlockOkr? Okr { get; set; }

    /// <summary>
    /// <para>OKR Objective</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("okr_objective")]
    public BlockOkrObjective? OkrObjective { get; set; }

    /// <summary>
    /// <para>OKR Key Result</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("okr_key_result")]
    public BlockOkrKeyResult? OkrKeyResult { get; set; }

    /// <summary>
    /// <para>OKR 进展信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("okr_progress")]
    public OkrProgressRate? OkrProgress { get; set; }

    /// <summary>
    /// <para>评论 id 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：[1660030311959965796]</para>
    /// </summary>
    [JsonPropertyName("comment_ids")]
    public string[]? CommentIds { get; set; }

    /// <summary>
    /// <para>Jira Issue</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("jira_issue")]
    public BlockJiraIssue? JiraIssue { get; set; }

    /// <summary>
    /// <para>Wiki 子目录 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("wiki_catalog")]
    public BlockWikiCatalog? WikiCatalog { get; set; }

    /// <summary>
    /// <para>画板 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("board")]
    public BlockBoard? Board { get; set; }

    /// <summary>
    /// <para>议程 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agenda")]
    public object? Agenda { get; set; }

    /// <summary>
    /// <para>议程项 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agenda_item")]
    public object? AgendaItem { get; set; }

    /// <summary>
    /// <para>议程项标题 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agenda_item_title")]
    public BlockAgendaItemTitle? AgendaItemTitle { get; set; }

    /// <summary>
    /// <para>议程项内容 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agenda_item_content")]
    public object? AgendaItemContent { get; set; }

    /// <summary>
    /// <para>链接预览 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("link_preview")]
    public BlockLinkPreview? LinkPreview { get; set; }

    /// <summary>
    /// <para>源同步块</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("source_synced")]
    public BlockSourceSynced? SourceSynced { get; set; }

    /// <summary>
    /// <para>引用同步块</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reference_synced")]
    public BlockReferenceSynced? ReferenceSynced { get; set; }

    /// <summary>
    /// <para>新版 Wiki 子目录 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sub_page_list")]
    public BlockSubPageList? SubPageList { get; set; }

    /// <summary>
    /// <para>AI 模板 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ai_template")]
    public object? AiTemplate { get; set; }
}
