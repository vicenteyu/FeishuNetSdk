using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询导入任务结果 响应体
/// <para>根据创建导入任务返回的`ticket`轮询导入结果，调用方式可参考[导入使用指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
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
    [JsonProperty("result")]
    public ImportTask? Result { get; set; }

    /// <summary>
    /// <para>导入结果</para>
    /// </summary>
    public record ImportTask
    {
        /// <summary>
        /// <para>任务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6990281865xxxxxxxx7843</para>
        /// </summary>
        [JsonProperty("ticket")]
        public string? Ticket { get; set; }

        /// <summary>
        /// <para>导入目标云文档格式</para>
        /// <para>必填：是</para>
        /// <para>示例值：sheet</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：成功</item>
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
        /// <item>5000：内部错误</item>
        /// <item>7000：docxblock数量超过系统上限</item>
        /// <item>7001：docxblock层级超过系统上线</item>
        /// <item>7002：docxblock大小超过系统上限</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("job_status")]
        public int? JobStatus { get; set; }

        /// <summary>
        /// <para>任务失败原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：success</para>
        /// </summary>
        [JsonProperty("job_error_msg")]
        public string? JobErrorMsg { get; set; }

        /// <summary>
        /// <para>导入云文档Token</para>
        /// <para>必填：否</para>
        /// <para>示例值：shtcnVBTG6SuxxxxxxxkM2tUX</para>
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>导入云文档URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://bytedance.feishu.cn/sheets/shtcnVBTG6SuxxxxxxxkM2tUX</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>任务成功后的提示信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("extra")]
        public string[]? Extra { get; set; }
    }
}
