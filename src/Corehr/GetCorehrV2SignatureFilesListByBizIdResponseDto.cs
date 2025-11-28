// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="GetCorehrV2SignatureFilesListByBizIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据流程获取电子签文件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据流程获取电子签文件信息 响应体
/// <para>该接口可以根据传入的业务类型和流程ID获取该流程中签署的电子签文件信息</para>
/// <para>接口ID：7398535900936847363</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list_by_biz_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2flist_by_biz_id</para>
/// </summary>
public record GetCorehrV2SignatureFilesListByBizIdResponseDto
{
    /// <summary>
    /// <para>返回的流程关联的电子签文件列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("signature_files")]
    public SignatureFile[]? SignatureFiles { get; set; }

    /// <summary>
    /// <para>返回的流程关联的电子签文件列表</para>
    /// </summary>
    public record SignatureFile
    {
        /// <summary>
        /// <para>电子签文件ID</para>
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
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
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
        /// <para>员工雇佣ID；可以通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取该员工详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7123132668099919891</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>待入职ID，可以通过[【搜索待入职人员信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)搜索该待入职人员详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7123132668099919891</para>
        /// </summary>
        [JsonPropertyName("pre_hire_id")]
        public string? PreHireId { get; set; }

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
            /// <para>示例值：pending_sign</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举值多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举值多语展示</para>
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
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：待签字</para>
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
        /// <para>电子签文件生效日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-12-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>电子签模板ID，可以通过[【根据ID获取电子签模板】](/ssl:ttdc/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_template/search)获取电子签模板详情信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7147527056140813828</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// <para>签署链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.letsign.com/v2/saas/sign?signCode=05325cb58b77484f92d4b145c18222cf&amp;taskCode=batch-0-4639de2ddcb54439b7f31517a17b7b4c</para>
        /// </summary>
        [JsonPropertyName("sign_url")]
        public string? SignUrl { get; set; }
    }

    /// <summary>
    /// <para>批量签署链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://www.letsign.com/v2/saas/sign?signCode=05325cb58b77484f92d4b145c18222cf&amp;taskCode=batch-0-4639de2ddcb54439b7f31517a17b7b4c</para>
    /// </summary>
    [JsonPropertyName("batch_sign_url")]
    public string? BatchSignUrl { get; set; }
}
