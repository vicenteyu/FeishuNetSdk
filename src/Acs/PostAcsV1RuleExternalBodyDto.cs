// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAcsV1RuleExternalBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或更新权限组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs;
/// <summary>
/// 创建或更新权限组 请求体
/// <para>创建或更新权限组</para>
/// <para>接口ID：7321978105899122716</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/rule_external/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fcreate</para>
/// </summary>
public record PostAcsV1RuleExternalBodyDto
{
    /// <summary>
    /// <para>权限组信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("rule")]
    public PostAcsV1RuleExternalBodyDtoRule Rule { get; set; } = new();

    /// <summary>
    /// <para>权限组信息</para>
    /// </summary>
    public record PostAcsV1RuleExternalBodyDtoRule
    {
        /// <summary>
        /// <para>权限组id</para>
        /// <para>必填：否</para>
        /// <para>示例值：34252345234523</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>权限组名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：南门</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>权限组包含的设备</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("devices")]
        public DeviceExternal[]? Devices { get; set; }

        /// <summary>
        /// <para>权限组包含的设备</para>
        /// </summary>
        public record DeviceExternal
        {
            /// <summary>
            /// <para>设备id</para>
            /// <para>必填：否</para>
            /// <para>示例值：534545234523452345</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>设备名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：北门</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>权限组包含的员工个数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("user_count")]
        public string? UserCount { get; set; }

        /// <summary>
        /// <para>权限组包含的员工列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("users")]
        public UserExternal[]? Users { get; set; }

        /// <summary>
        /// <para>权限组包含的员工列表</para>
        /// </summary>
        public record UserExternal
        {
            /// <summary>
            /// <para>用户类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：员工</item>
            /// <item>2：部门</item>
            /// <item>10：全体员工</item>
            /// <item>11：访客</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("user_type")]
            public int UserType { get; set; }

            /// <summary>
            /// <para>用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>用户名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("user_name")]
            public string? UserName { get; set; }

            /// <summary>
            /// <para>电话号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：1357890001</para>
            /// </summary>
            [JsonPropertyName("phone_num")]
            public string? PhoneNum { get; set; }

            /// <summary>
            /// <para>部门id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-f7d44ab733f7602f5cc5194735fd9aaf</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }
        }

        /// <summary>
        /// <para>权限组包含的访客个数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("visitor_count")]
        public string? VisitorCount { get; set; }

        /// <summary>
        /// <para>权限组包含的访客列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("visitors")]
        public UserExternal[]? Visitors { get; set; }

        /// <summary>
        /// <para>是否通知人员录入</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("remind_face")]
        public bool? RemindFace { get; set; }

        /// <summary>
        /// <para>开门时间段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("opening_time")]
        public OpeningTimeExternal? OpeningTime { get; set; }

        /// <summary>
        /// <para>开门时间段</para>
        /// </summary>
        public record OpeningTimeExternal
        {
            /// <summary>
            /// <para>有效日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("valid_day")]
            public OpeningTimeValidDayExternal? ValidDay { get; set; }

            /// <summary>
            /// <para>有效日期</para>
            /// </summary>
            public record OpeningTimeValidDayExternal
            {
                /// <summary>
                /// <para>权限开始时间</para>
                /// <para>必填：是</para>
                /// <para>示例值：1699031483</para>
                /// <para>最大值：2147483647</para>
                /// <para>最小值：1000000000</para>
                /// </summary>
                [JsonPropertyName("start_day")]
                public int StartDay { get; set; }

                /// <summary>
                /// <para>权限结束时间</para>
                /// <para>必填：是</para>
                /// <para>示例值：1699931483</para>
                /// <para>最大值：2147483647</para>
                /// <para>最小值：1000000000</para>
                /// </summary>
                [JsonPropertyName("end_day")]
                public int EndDay { get; set; }
            }

            /// <summary>
            /// <para>有效星期</para>
            /// <para>必填：否</para>
            /// <para>最大长度：7</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("weekdays")]
            public int[]? Weekdays { get; set; }

            /// <summary>
            /// <para>有效时间</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("day_times")]
            public OpeningTimePeriodExternal[]? DayTimes { get; set; }

            /// <summary>
            /// <para>有效时间</para>
            /// </summary>
            public record OpeningTimePeriodExternal
            {
                /// <summary>
                /// <para>起始时间</para>
                /// <para>必填：是</para>
                /// <para>示例值：1200</para>
                /// <para>最大值：2400</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("start_hhmm")]
                public int StartHhmm { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// <para>必填：是</para>
                /// <para>示例值：1400</para>
                /// <para>最大值：2400</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("end_hhmm")]
                public int EndHhmm { get; set; }
            }
        }

        /// <summary>
        /// <para>是否为临时权限组</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_temp")]
        public bool? IsTemp { get; set; }
    }
}
