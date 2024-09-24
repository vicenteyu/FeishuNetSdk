// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="GetApaasV1ApplicationsByNamespaceAuditLogAuditLogListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询审计日志列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询审计日志列表 响应体
/// <para>根据搜索/筛选条件，查询审计日志列表</para>
/// <para>接口ID：7418119603744391171</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-audit_log/audit_log_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-audit_log%2faudit_log_list</para>
/// </summary>
public record GetApaasV1ApplicationsByNamespaceAuditLogAuditLogListResponseDto
{
    /// <summary>
    /// <para>审计日志查询结果列表详情信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AuditLogEsField[]? Items { get; set; }

    /// <summary>
    /// <para>审计日志查询结果列表详情信息</para>
    /// </summary>
    public record AuditLogEsField
    {
        /// <summary>
        /// <para>审计日志ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7376574450886557740</para>
        /// <para>最大长度：30</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// <para>操作时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1723634726874</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("op_time")]
        public string? OpTime { get; set; }

        /// <summary>
        /// <para>日志类型：</para>
        /// <para>- 10000: 全部日志</para>
        /// <para>- 10001: 企业管理日志</para>
        /// <para>- 10002: 登录日志</para>
        /// <para>- 10003: 应用管理日志</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("log_type")]
        public string? LogType { get; set; }

        /// <summary>
        /// <para>操作人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public LookupWithAvatar? Operator { get; set; }

        /// <summary>
        /// <para>操作人</para>
        /// </summary>
        public record LookupWithAvatar
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1768491480010814</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：郭xx</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>租户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：79888</para>
            /// </summary>
            [JsonPropertyName("tenant_id")]
            public string? TenantId { get; set; }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：gxxx@bytedance.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        /// <summary>
        /// <para>是否为外部用户,true代表是外部用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("outsider")]
        public bool? Outsider { get; set; }

        /// <summary>
        /// <para>登录类型:</para>
        /// <para>-11001: 飞书登录</para>
        /// <para>-11003: 账号密码登录</para>
        /// <para>必填：否</para>
        /// <para>示例值：11001</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("login_type")]
        public string? LoginType { get; set; }

        /// <summary>
        /// <para>飞书租户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("lark_tenant_id")]
        public string? LarkTenantId { get; set; }

        /// <summary>
        /// <para>apaas租户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：23333</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("apaas_tenant_id")]
        public string? ApaasTenantId { get; set; }

        /// <summary>
        /// <para>用户地理信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：America/Chicago</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_geo")]
        public string? UserGeo { get; set; }

        /// <summary>
        /// <para>客户端IP</para>
        /// <para>必填：否</para>
        /// <para>示例值：192.168.1.1</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// <para>IP位置</para>
        /// <para>必填：否</para>
        /// <para>示例值：中国北京</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("ip_loc")]
        public string? IpLoc { get; set; }

        /// <summary>
        /// <para>IP提供商</para>
        /// <para>必填：否</para>
        /// <para>示例值：ISP_com</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("ip_provider")]
        public string? IpProvider { get; set; }

        /// <summary>
        /// <para>引用页面</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com/referer</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("referer")]
        public string? Referer { get; set; }

        /// <summary>
        /// <para>源页面</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com/origin</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// <para>路由路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：/api/xxx</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("api_path")]
        public string? ApiPath { get; set; }

        /// <summary>
        /// <para>网关路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：/api/xxx</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("full_path")]
        public string? FullPath { get; set; }

        /// <summary>
        /// <para>用户代理</para>
        /// <para>必填：否</para>
        /// <para>示例值：Mozilla/5.0 (iPhone; CPU iPhone OS 14_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// <para>设备ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：device_1234</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("device_id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// <para>web端设备ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：webDevice_1234</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("web_device_id")]
        public string? WebDeviceId { get; set; }

        /// <summary>
        /// <para>终端类型:</para>
        /// <para>- 13002: PC类型</para>
        /// <para>- 13003: Web类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("terminal_type")]
        public string? TerminalType { get; set; }

        /// <summary>
        /// <para>系统类型:</para>
        /// <para>- 14002: window</para>
        /// <para>- 14001: 未知</para>
        /// <para>必填：否</para>
        /// <para>示例值：14002</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("os_type")]
        public string? OsType { get; set; }

        /// <summary>
        /// <para>系统版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：14.6</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("os_version")]
        public string? OsVersion { get; set; }

        /// <summary>
        /// <para>功能模块</para>
        /// <para>必填：否</para>
        /// <para>示例值：17001</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("module")]
        public string? Module { get; set; }

        /// <summary>
        /// <para>数据对象</para>
        /// <para>必填：否</para>
        /// <para>示例值：object_api_aaa</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_object")]
        public string? DataObject { get; set; }

        /// <summary>
        /// <para>审计域:</para>
        /// <para>- 15001: 企业管理后台</para>
        /// <para>- 15002: 应用管理后台</para>
        /// <para>- 15003: 应用开发平台</para>
        /// <para>必填：否</para>
        /// <para>示例值：15001</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("audit_scope")]
        public string? AuditScope { get; set; }

        /// <summary>
        /// <para>租户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：23335</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// <para>应用唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：package_aacc</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// <para>环境类型:</para>
        /// <para>- 16001：沙箱环境</para>
        /// <para>- 16003：线上环境</para>
        /// <para>必填：否</para>
        /// <para>示例值：16003</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("env_type")]
        public string? EnvType { get; set; }

        /// <summary>
        /// <para>事件类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：19001</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("op_type")]
        public string? OpType { get; set; }

        /// <summary>
        /// <para>操作详情内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：{ "2052":"管理员和开发者自动获取所有使用权限" }</para>
        /// </summary>
        [JsonPropertyName("op_detail")]
        public Dictionary<string, object>? OpDetail { get; set; }

        /// <summary>
        /// <para>操作源:</para>
        /// <para>- 20001：前端</para>
        /// <para>- 20004：openapi</para>
        /// <para>必填：否</para>
        /// <para>示例值：20001</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("op_source")]
        public string? OpSource { get; set; }

        /// <summary>
        /// <para>操作状态:</para>
        /// <para>- 18001：成功</para>
        /// <para>- 18002：失败</para>
        /// <para>必填：否</para>
        /// <para>示例值：18001</para>
        /// <para>最大长度：20000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>失败原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：{ "2052": "中文失败原因内容" }</para>
        /// </summary>
        [JsonPropertyName("failed_reason_i18n")]
        public Dictionary<string, object>? FailedReasonI18n { get; set; }

        /// <summary>
        /// <para>数据变化(旧值和新值)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_changes")]
        public string[]? DataChanges { get; set; }

        /// <summary>
        /// <para>应用名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：{ "2052": "应用示例" }</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public Dictionary<string, object>? AppName { get; set; }

        /// <summary>
        /// <para>应用版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：v1.2.3</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("keyword_field_app_version")]
        public string? KeywordFieldAppVersion { get; set; }

        /// <summary>
        /// <para>审计日志事件子模块</para>
        /// <para>必填：否</para>
        /// <para>示例值：223</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("keyword_field_functional_sub_module")]
        public string? KeywordFieldFunctionalSubModule { get; set; }
    }

    /// <summary>
    /// <para>审计日志查询总条数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("total")]
    public string? Total { get; set; }
}
