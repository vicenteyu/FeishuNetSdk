// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="GetCorehrV2SignatureFilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取电子签文件列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取电子签文件列表 响应体
/// <para>该接口用于获取电子签文件列表</para>
/// <para>接口ID：7376163028442808348</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2flist</para>
/// </summary>
public record GetCorehrV2SignatureFilesResponseDto : IPageableResponse<GetCorehrV2SignatureFilesResponseDto.SignatureFile>
{
    /// <summary>
    /// <para>电子签文件信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SignatureFile[]? Items { get; set; }

    /// <summary>
    /// <para>电子签文件信息</para>
    /// </summary>
    public record SignatureFile
    {
        /// <summary>
        /// <para>电子签文件ID，[【查询电子签文件详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_file/query)</para>
        /// <para>必填：是</para>
        /// <para>示例值：7147527056140813828</para>
        /// </summary>
        [JsonPropertyName("signature_file_id")]
        public string SignatureFileId { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>创建时间，格式：YYYY-MM-DD 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，格式：YYYY-MM-DD 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>雇员 id，[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>电子签文件状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("signature_file_state")]
        public Enum? SignatureFileState { get; set; }

        /// <summary>
        /// <para>电子签文件状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>供应商侧的合同编号，作为幂等key</para>
        /// <para>必填：否</para>
        /// <para>示例值：48793beea04f4e2583d50732e481d507</para>
        /// </summary>
        [JsonPropertyName("contract_code")]
        public string? ContractCode { get; set; }

        /// <summary>
        /// <para>电子签文件生效日期，格式：YYYY-MM-DD</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-12-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>电子签模板ID，[【查询模板内容】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_template/search)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7147527056140813828</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"cn":"[\"7371387495822411308\"]"}</para>
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
