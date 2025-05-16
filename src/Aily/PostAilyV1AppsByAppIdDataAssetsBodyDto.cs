// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-16
//
// Last Modified By : yxr
// Last Modified On : 2025-05-16
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdDataAssetsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建数据知识 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建数据知识 请求体
/// <para>在智能伙伴中添加单个数据知识</para>
/// <para>接口ID：7441589456115892227</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2fcreate</para>
/// </summary>
public record PostAilyV1AppsByAppIdDataAssetsBodyDto
{
    /// <summary>
    /// <para>连接类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：direct</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>import：导入模式</item>
    /// <item>direct：直连模式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("connect_type")]
    public string ConnectType { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据源类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：file</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：文件，只支持导入模式</item>
    /// <item>lark_wiki_space：飞书知识空间，只支持直连模式</item>
    /// <item>lark_doc：飞书云文档，导入模式只支持docx</item>
    /// <item>lark_helpdesk：飞书服务台，只支持直连模式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("source_type")]
    public string SourceType { get; set; } = string.Empty;

    /// <summary>
    /// <para>知识导入配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("import_knowledge_setting")]
    public DataAssetImportKnowledgeSetting? ImportKnowledgeSetting { get; set; }

    /// <summary>
    /// <para>知识导入配置</para>
    /// </summary>
    public record DataAssetImportKnowledgeSetting
    {
        /// <summary>
        /// <para>知识切片配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chunk_setting")]
        public DataAssetKnowledgeChunkSetting? ChunkSetting { get; set; }

        /// <summary>
        /// <para>知识切片配置</para>
        /// </summary>
        public record DataAssetKnowledgeChunkSetting
        {
            /// <summary>
            /// <para>切片规则</para>
            /// <para>必填：是</para>
            /// <para>示例值：intelligent</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>separator：按标识符</item>
            /// <item>intelligent：智能切片</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("rule_type")]
            public string RuleType { get; set; } = string.Empty;

            /// <summary>
            /// <para>切片分割符类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：paragraph</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>paragraph：段落分隔符："\n\n"、"\n"、空格</item>
            /// <item>title：标题分割符：######</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("separate_type")]
            public string? SeparateType { get; set; }

            /// <summary>
            /// <para>分段最大长度（字符），按标识符切片时必须填写</para>
            /// <para>必填：否</para>
            /// <para>示例值：600</para>
            /// <para>最大值：1000</para>
            /// <para>最小值：200</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }

            /// <summary>
            /// <para>分段重叠字符数，按标识符切片时必须填写，不能超过size的数值</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// <para>最大值：200</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("overlap")]
            public int? Overlap { get; set; }
        }

        /// <summary>
        /// <para>知识导入-文件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("file")]
        public DataAssetImportKnowledgeFile? File { get; set; }

        /// <summary>
        /// <para>知识导入-文件</para>
        /// </summary>
        public record DataAssetImportKnowledgeFile
        {
            /// <summary>
            /// <para>文件标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：文件标题</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>上传文件获取到的token。和content二选一，优先使用token。</para>
            /// <para>必填：否</para>
            /// <para>示例值：bb690637b49440b08f39459a2fdcd2ca</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>文件内容。和token二选一，优先使用token。有长度限制，大文件优先使用token方式。</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是文件内容</para>
            /// <para>最大长度：65536</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>文件内容对应的 MIME 类型，必须填写</para>
            /// <para>可选值：</para>
            /// <para>- text/plain (.txt)</para>
            /// <para>- application/pdf (.pdf)</para>
            /// <para>- application/vnd.openxmlformats-officedocument.presentationml.presentation (.pptx)</para>
            /// <para>- application/vnd.openxmlformats-officedocument.wordprocessingml.document (.docx)</para>
            /// <para>必填：否</para>
            /// <para>示例值：application/pdf</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("mime_type")]
            public string? MimeType { get; set; }

            /// <summary>
            /// <para>文件源的URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://document.com/1</para>
            /// <para>最大长度：65535</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }

        /// <summary>
        /// <para>知识导入-飞书云文档</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lark_doc")]
        public DataAssetImportKnowledgeLarkDoc? LarkDoc { get; set; }

        /// <summary>
        /// <para>知识导入-飞书云文档</para>
        /// </summary>
        public record DataAssetImportKnowledgeLarkDoc
        {
            /// <summary>
            /// <para>云文档类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>doc：飞书文档</item>
            /// <item>file：飞书文件</item>
            /// <item>wiki：飞书知识库</item>
            /// <item>docx：飞书新版文档</item>
            /// <item>folder：飞书文件夹</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>云文档token，可以通过[搜索云文档](https://open.larkoffice.com/document/server-docs/docs/drive-v1/search/document-search)API获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：T8FAcuilgC1fdaxkt58vcp91xngh</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;

            /// <summary>
            /// <para>是否包含子文档，只有wiki类型的云文档支持</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("with_sub_docs")]
            public bool? WithSubDocs { get; set; }
        }

        /// <summary>
        /// <para>知识导入-飞书知识空间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lark_wiki_space")]
        public DataAssetImportKnowledgeWiki? LarkWikiSpace { get; set; }

        /// <summary>
        /// <para>知识导入-飞书知识空间</para>
        /// </summary>
        public record DataAssetImportKnowledgeWiki
        {
            /// <summary>
            /// <para>飞书知识空间ID，可以通过[搜索 Wiki](https://open.larkoffice.com/document/server-docs/docs/wiki-v2/search_wiki)API获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：798546548961351</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("space_id")]
            public string SpaceId { get; set; } = string.Empty;

            /// <summary>
            /// <para>指定知识空间子节点时使用</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sub_docs")]
            public DataAssetImportKnowledgeWikiSubDoc[]? SubDocs { get; set; }

            /// <summary>
            /// <para>指定知识空间子节点时使用</para>
            /// </summary>
            public record DataAssetImportKnowledgeWikiSubDoc
            {
                /// <summary>
                /// <para>云文档类型，只支持wiki中的云文档</para>
                /// <para>必填：是</para>
                /// <para>示例值：wiki</para>
                /// <para>最大长度：255</para>
                /// <para>最小长度：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>wiki：飞书知识库</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// <para>云文档token，可以通过[搜索云文档](https://open.larkoffice.com/document/server-docs/docs/drive-v1/search/document-search)API获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：T8FAcuilgC1fdaxkt58vcp91xngh</para>
                /// <para>最大长度：255</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("token")]
                public string Token { get; set; } = string.Empty;

                /// <summary>
                /// <para>云文档链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://cdas.feishu.cn/wiki/fdisu1</para>
                /// <para>最大长度：65535</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            /// <summary>
            /// <para>知识空间URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://ai-tenant.feishu-boe.cn/wiki/space/7283525110814736404</para>
            /// <para>最大长度：65535</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }

        /// <summary>
        /// <para>知识导入-飞书服务台</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lark_helpdesk")]
        public DataAssetImportKnowledgeHelpdesk? LarkHelpdesk { get; set; }

        /// <summary>
        /// <para>知识导入-飞书服务台</para>
        /// </summary>
        public record DataAssetImportKnowledgeHelpdesk
        {
            /// <summary>
            /// <para>飞书服务台ID，可以通过[服务台-接入指南](https://open.larkoffice.com/document/server-docs/helpdesk-v1/access-guide) 获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：123</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("helpdesk_id")]
            public string HelpdeskId { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>数据知识描述信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"zh_cn":"描述"}</para>
    /// </summary>
    [JsonPropertyName("description")]
    public object? Description { get; set; }
}
