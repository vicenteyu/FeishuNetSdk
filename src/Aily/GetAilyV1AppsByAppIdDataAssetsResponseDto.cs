// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-23
//
// Last Modified By : yxr
// Last Modified On : 2024-11-27
// ************************************************************************
// <copyright file="GetAilyV1AppsByAppIdDataAssetsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询数据知识列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 查询数据知识列表 响应体
/// <para>获取智能伙伴搭建助手的数据知识列表</para>
/// <para>接口ID：7424752773160796164</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/app-data_asset/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2flist</para>
/// </summary>
public record GetAilyV1AppsByAppIdDataAssetsResponseDto
{
    /// <summary>
    /// <para>数据知识列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DataAsset[]? Items { get; set; }

    /// <summary>
    /// <para>数据知识列表</para>
    /// </summary>
    public record DataAsset
    {
        /// <summary>
        /// <para>数据知识ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：asset_aadg3mcgvpybu</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_asset_id")]
        public string? DataAssetId { get; set; }

        /// <summary>
        /// <para>数据知识标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"zh_cn":"数据知识标题"}</para>
        /// </summary>
        [JsonPropertyName("label")]
        public object? Label { get; set; }

        /// <summary>
        /// <para>数据知识描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"zh_cn":"这个是电影相关的知识集合"}</para>
        /// </summary>
        [JsonPropertyName("description")]
        public object? Description { get; set; }

        /// <summary>
        /// <para>数据资源类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：excel</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>excel：excel</item>
        /// <item>pdf：pdf</item>
        /// <item>pptx：pptx</item>
        /// <item>txt：txt</item>
        /// <item>docx：docx</item>
        /// <item>mysql：mysql</item>
        /// <item>postgresql：postgresql</item>
        /// <item>larkbase：飞书多维表格</item>
        /// <item>salesforce：salesforce</item>
        /// <item>fenxiangxiaoke：分享逍客</item>
        /// <item>qianchuan：巨量千川</item>
        /// <item>clickhouse：clickhouse</item>
        /// <item>databricks：databricks</item>
        /// <item>servicedesk：飞书服务台</item>
        /// <item>larkbiz_wiki：飞书Wiki</item>
        /// <item>larkbiz_doc：飞书doc</item>
        /// <item>larkbiz_docs：飞书docs</item>
        /// <item>larkbiz_docx：飞书docx</item>
        /// <item>larkbiz_pdf：飞书pdf</item>
        /// <item>larkbiz_word：飞书word</item>
        /// <item>larkbiz_pptx：飞书pptx</item>
        /// <item>larkbiz_sheets：飞书文档</item>
        /// <item>larkbiz_base：飞书多维表格</item>
        /// <item>larkbiz_personalfolder：飞书个人文件夹</item>
        /// <item>larkbiz_sharedfolder：飞书共享文件夹</item>
        /// <item>object：数据表</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("data_source_type")]
        public string? DataSourceType { get; set; }

        /// <summary>
        /// <para>数据连接状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：successful</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>awaiting：等待连接</item>
        /// <item>syncing：连接中</item>
        /// <item>successful：连接成功</item>
        /// <item>continuously_syncing：增量同步中</item>
        /// <item>partially_successful：部分成功</item>
        /// <item>failed：连接失败</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("connect_status")]
        public string? ConnectStatus { get; set; }

        /// <summary>
        /// <para>数据知识分类列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tags")]
        public DataAssetTag[]? Tags { get; set; }

        /// <summary>
        /// <para>数据知识分类列表</para>
        /// </summary>
        public record DataAssetTag
        {
            /// <summary>
            /// <para>数据知识分类名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("data_asset_tag_id")]
            public string? DataAssetTagId { get; set; }

            /// <summary>
            /// <para>数据知识分类ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：电影</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>数据知识项列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("items")]
        public DataAssetItem[]? Items { get; set; }

        /// <summary>
        /// <para>数据知识项列表</para>
        /// </summary>
        public record DataAssetItem
        {
            /// <summary>
            /// <para>数据知识项ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：asset_item_aadg3mcgvpydu</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("data_asset_item_id")]
            public string? DataAssetItemId { get; set; }

            /// <summary>
            /// <para>数据知识项标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：movie</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("api_name")]
            public string? ApiName { get; set; }

            /// <summary>
            /// <para>数据知识项标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh_cn":"标题"}</para>
            /// </summary>
            [JsonPropertyName("label")]
            public object? Label { get; set; }

            /// <summary>
            /// <para>数据知识项描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh_cn": "描述内容"}</para>
            /// </summary>
            [JsonPropertyName("description")]
            public object? Description { get; set; }

            /// <summary>
            /// <para>数据知识资源</para>
            /// <para>必填：否</para>
            /// <para>最大长度：65535</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("resources")]
            public DataAssetResource[]? Resources { get; set; }

            /// <summary>
            /// <para>数据知识资源</para>
            /// </summary>
            public record DataAssetResource
            {
                /// <summary>
                /// <para>数据知识资源ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：spring_5862e4fea8__c__dataset_aadg3lxm4j6mg</para>
                /// <para>最大长度：255</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("resource_id")]
                public string? ResourceId { get; set; }

                /// <summary>
                /// <para>数据知识资源类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：dataset</para>
                /// <para>最大长度：255</para>
                /// <para>最小长度：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>dataset：数据视图</item>
                /// <item>vector：知识视图</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("resource_type")]
                public string? ResourceType { get; set; }
            }
        }

        /// <summary>
        /// <para>连接状态失败信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：连接超时</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("connect_failed_reason")]
        public string? ConnectFailedReason { get; set; }

        /// <summary>
        /// <para>数据连接类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：direct</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>import：导入</item>
        /// <item>direct：直连</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("connect_type")]
        public string? ConnectType { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
