// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-07
//
// Last Modified By : yxr
// Last Modified On : 2024-08-07
// ************************************************************************
// <copyright file="GetAdminV1AuditInfosResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取行为审计日志数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Admin.Spec;
/// <summary>
/// 获取行为审计日志数据 响应体
/// <para>该接口用于查询成员的操作行为日志。行为审计日志中记录了成员进行操作的时间、地点、操作对象等信息。通过查询成员行为日志，管理员可以发现成员是否有违规操作，以保护企业数据和信息安全。</para>
/// <para>- 性能说明：查询时请适当缩短查询时间范围和适当控制查询频次（避免重复的无效查询等情况）</para>
/// <para>接口ID：6921713375245352988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/audit_log/audit_data_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjM5YjL0ITO24CNykjN%2faudit_log%2faudit_data_get</para>
/// </summary>
public record GetAdminV1AuditInfosResponseDto : IPageableResponse<GetAdminV1AuditInfosResponseDto.AuditInfo>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>返回的具体数据内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AuditInfo[]? Items { get; set; }

    /// <summary>
    /// 数据内容
    /// </summary>
    public record AuditInfo
    {
        /// <summary>
        /// <para>事件ID，不唯一，可用作聚合</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// <para>事件唯一ID，可以用于去重，倾向使用该字段识别用户的行为</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// <para>事件名称，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_name")]
        public string? EventName { get; set; }

        /// <summary>
        /// <para>用户所属部门的ID列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>事件模块，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_module")]
        public int? EventModule { get; set; }

        /// <summary>
        /// <para>操作人类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:组织内成员,12:机器人,1001:组织外成员</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：组织内成员</item>
        /// <item>12：机器人</item>
        /// <item>1001：组织外成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("operator_type")]
        public int? OperatorType { get; set; }

        /// <summary>
        /// <para>操作人id，当operator_type是1001时，该项为脱敏后的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_value")]
        public string? OperatorValue { get; set; }

        /// <summary>
        /// <para>操作对象列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("objects")]
        public AuditObjectEntity[]? Objects { get; set; }

        /// <summary>
        /// 操作对象
        /// </summary>
        public record AuditObjectEntity
        {
            /// <summary>
            /// <para>操作对象类型，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public string? ObjectType { get; set; }

            /// <summary>
            /// <para>操作对象值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_value")]
            public string? ObjectValue { get; set; }

            /// <summary>
            /// <para>操作对象名称，当前针对文档、会话、应用类型开放，如会话名、文档名等</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_name")]
            public string? ObjectName { get; set; }

            /// <summary>
            /// <para>操作对象所有者，当前针对文档类型开放</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_owner")]
            public string? ObjectOwner { get; set; }

            /// <summary>
            /// <para>操作对象扩展字段，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_detail")]
            public Dictionary<string, object>? ObjectDetail { get; set; }
        }

        /// <summary>
        /// <para>接收者对象列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recipients")]
        public AuditRecipientEntity[]? Recipients { get; set; }

        /// <summary>
        /// 接收者对象
        /// </summary>
        public record AuditRecipientEntity
        {
            /// <summary>
            /// <para>接收者对象类型，1代表用户，2代表部门，4代表会话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recipient_type")]
            public string? RecipientType { get; set; }

            /// <summary>
            /// <para>接收者对象值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recipient_value")]
            public string? RecipientValue { get; set; }

            /// <summary>
            /// <para>接收者对象扩展字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recipient_detail")]
            public Dictionary<string, object>? RecipientDetail { get; set; }
        }

        /// <summary>
        /// <para>事件时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_time")]
        public int? EventTime { get; set; }

        /// <summary>
        /// <para>ip信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// <para>第三方isvID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_app")]
        public string? OperatorApp { get; set; }

        /// <summary>
        /// <para>环境信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("audit_context")]
        public AuditContextSuffix? AuditContext { get; set; }

        /// <summary>
        /// 环境信息
        /// </summary>
        public record AuditContextSuffix
        {
            /// <summary>
            /// <para>终端类型</para>
            /// <para>**可选值有**：</para>
            /// <para>0:ios,1:安卓,2:pc端,3:web端</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：ios</item>
            /// <item>1：安卓</item>
            /// <item>2：pc端</item>
            /// <item>3：web端</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("terminal_type")]
            public int? TerminalType { get; set; }

            /// <summary>
            /// <para>返回ios的环境信息，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ios_context")]
            public Dictionary<string, string>? IosContext { get; set; }

            /// <summary>
            /// <para>返回pc的环境信息，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("pc_context")]
            public Dictionary<string, string>? PcContext { get; set; }

            /// <summary>
            /// <para>返回web的环境信息，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("web_context")]
            public Dictionary<string, string>? WebContext { get; set; }

            /// <summary>
            /// <para>返回android的环境信息，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("android_context")]
            public Dictionary<string, string>? AndroidContext { get; set; }
        }

        /// <summary>
        /// <para>事件扩展字段，参考common_drawers中的信息即可</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("extend")]
        public Dictionary<string, object>? Extend { get; set; }

        /// <summary>
        /// <para>第三方isv名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_app_name")]
        public string? OperatorAppName { get; set; }

        /// <summary>
        /// <para>事件扩展字段，字段详情见[枚举值列表](https://open.feishu.cn/document/ukTMukTMukTM/uQjM5YjL0ITO24CNykjN/audit_log/appendix)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("common_drawers")]
        public ApiAuditCommonDrawers? CommonDrawers { get; set; }

        /// <summary>
        /// 事件扩展字段
        /// </summary>
        public record ApiAuditCommonDrawers
        {
            /// <summary>
            /// 事件扩展字段
            /// </summary>
            [JsonPropertyName("common_draw_info_list")]
            public CommonDrawInfo[]? CommonDrawInfoList { get; set; }

            /// <summary>
            /// 事件扩展字段
            /// </summary>
            public record CommonDrawInfo
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("info_key")]
                public string? InfoKey { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("info_val")]
                public string? InfoVal { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("key_i18n_key")]
                public string? KeyI18nKey { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("val_i18n_key")]
                public string? ValI18nKey { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("val_type")]
                public string? ValType { get; set; }
            }
        }

        /// <summary>
        /// <para>设备信息：</para>
        /// <para>city：ip位置，城市名称；</para>
        /// <para>device_model：设备型号；</para>
        /// <para>mc：Mac地址；</para>
        /// <para>os：操作系统；</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("audit_detail")]
        public AuditDetailSuffix? AuditDetail { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        public record AuditDetailSuffix
        {
            /// <summary>
            /// ip位置，城市名称；
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// 设备型号；
            /// </summary>
            [JsonPropertyName("device_model")]
            public string? DeviceModel { get; set; }

            /// <summary>
            /// Mac地址；
            /// </summary>
            [JsonPropertyName("mc")]
            public string? Mc { get; set; }

            /// <summary>
            /// 操作系统；
            /// </summary>
            [JsonPropertyName("os")]
            public string? Os { get; set; }

        }

        /// <summary>
        /// <para>操作人所在企业编号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_tenant")]
        public string? OperatorTenant { get; set; }
    }
}
