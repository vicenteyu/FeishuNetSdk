namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取预约 响应体
/// <para>获取一个预约的详情。</para>
/// <para>接口ID：6921909217674936347</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fget</para>
/// </summary>
public record GetVcV1ReservesByReserveIdResponseDto
{
    /// <summary>
    /// <para>预约数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reserve")]
    public GetVcV1ReservesByReserveIdResponseDtoReserve? Reserve { get; set; }

    /// <summary>
    /// <para>预约数据</para>
    /// </summary>
    public record GetVcV1ReservesByReserveIdResponseDtoReserve
    {
        /// <summary>
        /// <para>预约ID（预约的唯一标识，非会议ID，会议ID仅在会议开始后才生成）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411934973028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>9位会议号（飞书用户可通过输入9位会议号快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：112000358</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议链接（飞书用户可通过点击会议链接快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://vc.feishu.cn/j/337736498</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>APPLink用于唤起飞书APP入会。"{?}"为占位符，用于配置入会参数，使用时需替换具体值：0表示关闭，1表示打开。preview为入会前的设置页，mic为麦克风，speaker为扬声器，camera为摄像头</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/videochat/open?source=openplatform&amp;action=join&amp;idtype=reservationid&amp;id={?}&amp;preview={?}&amp;mic={?}&amp;speaker={?}&amp;camera={?}</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }

        /// <summary>
        /// <para>会议转直播链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://meetings.feishu.cn/s/1gub381l4gglv</para>
        /// </summary>
        [JsonPropertyName("live_link")]
        public string? LiveLink { get; set; }

        /// <summary>
        /// <para>预约到期时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608883322</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>过期状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未过期</item>
        /// <item>2：已过期</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("expire_status")]
        public int? ExpireStatus { get; set; }

        /// <summary>
        /// <para>预约人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonPropertyName("reserve_user_id")]
        public string? ReserveUserId { get; set; }

        /// <summary>
        /// <para>会议设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meeting_settings")]
        public ReserveMeetingSetting? MeetingSettings { get; set; }

        /// <summary>
        /// <para>会议设置</para>
        /// </summary>
        public record ReserveMeetingSetting
        {
            /// <summary>
            /// <para>会议主题</para>
            /// <para>必填：否</para>
            /// <para>示例值：my meeting</para>
            /// </summary>
            [JsonPropertyName("topic")]
            public string? Topic { get; set; }

            /// <summary>
            /// <para>会议权限配置列表，如果存在相同的权限配置项则它们之间为"逻辑或"的关系（即 有一个为true则拥有该权限）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("action_permissions")]
            public ReserveActionPermission[]? ActionPermissions { get; set; }

            /// <summary>
            /// <para>会议权限配置列表，如果存在相同的权限配置项则它们之间为"逻辑或"的关系（即 有一个为true则拥有该权限）</para>
            /// </summary>
            public record ReserveActionPermission
            {
                /// <summary>
                /// <para>权限项</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：是否能成为主持人</item>
                /// <item>2：是否能邀请参会人</item>
                /// <item>3：是否能加入会议</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("permission")]
                public int Permission { get; set; }

                /// <summary>
                /// <para>权限检查器列表，权限检查器之间为"逻辑或"的关系（即 有一个为true则拥有该权限）</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("permission_checkers")]
                public ReservePermissionChecker[] PermissionCheckers { get; set; } = Array.Empty<ReservePermissionChecker>();

                /// <summary>
                /// <para>权限检查器列表，权限检查器之间为"逻辑或"的关系（即 有一个为true则拥有该权限）</para>
                /// </summary>
                public record ReservePermissionChecker
                {
                    /// <summary>
                    /// <para>检查字段类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：用户ID（check_list填入用户ID）</item>
                    /// <item>2：用户类型（check_list可选值有 "1"：飞书用户、 "2"：rooms用户、 "6"：pstn用户、 "7"：sip用户）</item>
                    /// <item>3：租户ID（check_list填入租户tenant_key）</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("check_field")]
                    public int CheckField { get; set; }

                    /// <summary>
                    /// <para>检查方式</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：在check_list中为有权限（白名单）</item>
                    /// <item>2：不在check_list中为有权限（黑名单）</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("check_mode")]
                    public int CheckMode { get; set; }

                    /// <summary>
                    /// <para>检查字段列表（根据check_field的类型填入对应内容）</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("check_list")]
                    public string[] CheckList { get; set; } = Array.Empty<string>();
                }
            }

            /// <summary>
            /// <para>会议初始类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：多人会议</item>
            /// <item>2：1v1呼叫</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("meeting_initial_type")]
            public int? MeetingInitialType { get; set; }

            /// <summary>
            /// <para>1v1呼叫相关参数</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("call_setting")]
            public ReserveCallSetting? CallSetting { get; set; }

            /// <summary>
            /// <para>1v1呼叫相关参数</para>
            /// </summary>
            public record ReserveCallSetting
            {
                /// <summary>
                /// <para>被呼叫的用户</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("callee")]
                public ReserveCallee Callee { get; set; } = new();

                /// <summary>
                /// <para>被呼叫的用户</para>
                /// </summary>
                public record ReserveCallee
                {
                    /// <summary>
                    /// <para>用户ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型，当前仅支持用户类型6(pstn用户)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：飞书用户</item>
                    /// <item>2：rooms用户</item>
                    /// <item>3：文档用户</item>
                    /// <item>4：neo单品用户</item>
                    /// <item>5：neo单品游客用户</item>
                    /// <item>6：pstn用户</item>
                    /// <item>7：sip用户</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int UserType { get; set; }

                    /// <summary>
                    /// <para>pstn/sip信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("pstn_sip_info")]
                    public ReserveCalleePstnSipInfo? PstnSipInfo { get; set; }

                    /// <summary>
                    /// <para>pstn/sip信息</para>
                    /// </summary>
                    public record ReserveCalleePstnSipInfo
                    {
                        /// <summary>
                        /// <para>给pstn/sip用户设置的临时昵称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：dodo</para>
                        /// </summary>
                        [JsonPropertyName("nickname")]
                        public string? Nickname { get; set; }

                        /// <summary>
                        /// <para>pstn/sip主机号，格式为：[国际冠字]-[电话区号][电话号码]，当前仅支持国内手机及固定电话号码</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：+86-02187654321</para>
                        /// </summary>
                        [JsonPropertyName("main_address")]
                        public string MainAddress { get; set; } = string.Empty;
                    }
                }
            }

            /// <summary>
            /// <para>使用飞书视频会议时，是否开启自动录制，默认false</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("auto_record")]
            public bool? AutoRecord { get; set; }

            /// <summary>
            /// <para>指定主持人列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assign_host_list")]
            public ReserveAssignHost[]? AssignHostLists { get; set; }

            /// <summary>
            /// <para>指定主持人列表</para>
            /// </summary>
            public record ReserveAssignHost
            {
                /// <summary>
                /// <para>用户类型，仅支持设置同租户下的 Lark 用户</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：飞书用户</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("user_type")]
                public int? UserType { get; set; }

                /// <summary>
                /// <para>用户ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }
        }
    }
}
