// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1ImportTasksByTicketResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询导入任务结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询导入任务结果 响应体
/// <para>根据[创建导入任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/create)返回的导入任务 ID（ticket）轮询导入结果。了解完整的导入文件步骤，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
/// <para>接口ID：6987581325629931521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fget</para>
/// </summary>
public record GetDriveV1ImportTasksByTicketResponseDto
{
    /// <summary>
    /// <para>导入结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("result")]
    public ImportTask? Result { get; set; }

    /// <summary>
    /// <para>导入结果</para>
    /// </summary>
    public record ImportTask
    {
        /// <summary>
        /// <para>导入任务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7369583175086912356</para>
        /// </summary>
        [JsonPropertyName("ticket")]
        public string? Ticket { get; set; }

        /// <summary>
        /// <para>导入的在线云文档类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：sheet</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务的状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：导入成功。但需关注是否有 extra 参数返回。如果源文件内容超过系统上限，将被系统截断，此时将返回 extra 参数，进行额外提示。extra 参数说明见本文末尾。</item>
        /// <item>1：初始化</item>
        /// <item>2：处理中</item>
        /// <item>3：内部错误</item>
        /// <item>100：导入文档已加密</item>
        /// <item>101：内部错误</item>
        /// <item>102：内部错误</item>
        /// <item>103：内部错误</item>
        /// <item>104：租户容量不足</item>
        /// <item>105：文件夹节点太多</item>
        /// <item>106：内部错误</item>
        /// <item>108：处理超时</item>
        /// <item>109：内部错误</item>
        /// <item>110：无权限</item>
        /// <item>112：格式不支持</item>
        /// <item>113：office格式不支持</item>
        /// <item>114：内部错误</item>
        /// <item>115：导入文件过大</item>
        /// <item>116：目录无权限</item>
        /// <item>117：目录已删除</item>
        /// <item>118：导入文件和任务指定后缀不匹配</item>
        /// <item>119：目录不存在</item>
        /// <item>120：导入文件和任务指定文件类型不匹配</item>
        /// <item>121：导入文件已过期</item>
        /// <item>122：创建副本中禁止导出</item>
        /// <item>129：文件格式损坏。请另存为新文件后导入</item>
        /// <item>5000：内部错误</item>
        /// <item>7000：docx block 数量超过系统上限</item>
        /// <item>7001：docx block 层级超过系统上线</item>
        /// <item>7002：docx block 大小超过系统上限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("job_status")]
        public int? JobStatus { get; set; }

        /// <summary>
        /// <para>任务失败的原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：success</para>
        /// </summary>
        [JsonPropertyName("job_error_msg")]
        public string? JobErrorMsg { get; set; }

        /// <summary>
        /// <para>导入云文档的 token</para>
        /// <para>必填：否</para>
        /// <para>示例值：Fm7osyjtMh5o7Ktrv32c73abcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>导入云文档的 URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/sheets/Fm7osyjtMh5o7Ktrv32c73abcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>导入成功的额外提示。详情参考下文。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string[]? Extra { get; set; }
    }
}
