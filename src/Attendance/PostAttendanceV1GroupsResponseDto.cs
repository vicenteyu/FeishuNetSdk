// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PostAttendanceV1GroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或修改考勤组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 创建或修改考勤组 响应体
/// <para>考勤组，是对部门或者员工在某个特定场所及特定时间段内的出勤情况（包括上下班、迟到、早退、病假、婚假、丧假、公休、工作时间、加班情况等）的一种规则设定。</para>
/// <para>通过设置考勤组，可以从部门、员工两个维度，来设定考勤方式、考勤时间、考勤地点等考勤规则。</para>
/// <para>对应功能同设置-假勤设置-[考勤组](https://example.feishu.cn/people/workforce-management/setting/group/list)的“新建”功能</para>
/// <para>接口ID：7044467124773683201</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2fcreate</para>
/// </summary>
public record PostAttendanceV1GroupsResponseDto
{
    /// <summary>
    /// <para>考勤组信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("group")]
    public PostAttendanceV1GroupsResponseDtoGroup? Group { get; set; }

    /// <summary>
    /// <para>考勤组信息</para>
    /// </summary>
    public record PostAttendanceV1GroupsResponseDtoGroup
    {
        /// <summary>
        /// <para>考勤组 ID，可用于[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6919358128597097404</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// <para>考勤组名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：开心考勤</para>
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：是</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; } = string.Empty;

        /// <summary>
        /// <para>绑定的部门 ID（与「need_punch_members」同时使用时，以当前字段为准）。对应dept_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-fcb45c28a45311afd440b7869541fce8</para>
        /// </summary>
        [JsonPropertyName("bind_dept_ids")]
        public string[]? BindDeptIds { get; set; }

        /// <summary>
        /// <para>排除的部门 ID（该字段已下线）</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-fcb45c28a45311afd440b7869541fce8</para>
        /// </summary>
        [JsonPropertyName("except_dept_ids")]
        public string[]? ExceptDeptIds { get; set; }

        /// <summary>
        /// <para>绑定的用户 ID（与「need_punch_members」同时使用时，以当前字段为准），对应employee_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：52aa1fa1</para>
        /// </summary>
        [JsonPropertyName("bind_user_ids")]
        public string[]? BindUserIds { get; set; }

        /// <summary>
        /// <para>排除的用户 ID（该字段已下线）</para>
        /// <para>必填：否</para>
        /// <para>示例值：52aa1fa1</para>
        /// </summary>
        [JsonPropertyName("except_user_ids")]
        public string[]? ExceptUserIds { get; set; }

        /// <summary>
        /// <para>考勤主负责人 ID 列表，必选字段（需至少拥有考勤组管理员权限），对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：2bg4a9be</para>
        /// </summary>
        [JsonPropertyName("group_leader_ids")]
        public string[] GroupLeaderIds { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>考勤子负责人 ID 列表，对应employee_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：52aa1fa1</para>
        /// </summary>
        [JsonPropertyName("sub_group_leader_ids")]
        public string[]? SubGroupLeaderIds { get; set; }

        /// <summary>
        /// <para>是否允许外勤打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_out_punch")]
        public bool? AllowOutPunch { get; set; }

        /// <summary>
        /// <para>外勤打卡需审批（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_need_approval")]
        public bool? OutPunchNeedApproval { get; set; }

        /// <summary>
        /// <para>外勤打卡需审批，先打卡后审批（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_need_post_approval")]
        public bool? OutPunchNeedPostApproval { get; set; }

        /// <summary>
        /// <para>外勤打卡需填写备注（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_need_remark")]
        public bool? OutPunchNeedRemark { get; set; }

        /// <summary>
        /// <para>外勤打卡需拍照（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_need_photo")]
        public bool? OutPunchNeedPhoto { get; set; }

        /// <summary>
        /// <para>外勤打卡允许员工隐藏详细地址（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_allowed_hide_addr")]
        public bool? OutPunchAllowedHideAddr { get; set; }

        /// <summary>
        /// <para>外勤打卡允许微调地址（需要允许外勤打卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("out_punch_allowed_adjust_addr")]
        public bool? OutPunchAllowedAdjustAddr { get; set; }

        /// <summary>
        /// <para>微调范围，默认为 50 米</para>
        /// <para>必填：否</para>
        /// <para>示例值：50</para>
        /// </summary>
        [JsonPropertyName("adjust_range")]
        public int? AdjustRange { get; set; }

        /// <summary>
        /// <para>是否允许 PC 端打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_pc_punch")]
        public bool? AllowPcPunch { get; set; }

        /// <summary>
        /// <para>是否限制补卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_remedy")]
        public bool? AllowRemedy { get; set; }

        /// <summary>
        /// <para>是否限制补卡次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("remedy_limit")]
        public bool? RemedyLimit { get; set; }

        /// <summary>
        /// <para>补卡次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("remedy_limit_count")]
        public int? RemedyLimitCount { get; set; }

        /// <summary>
        /// <para>是否限制补卡时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("remedy_date_limit")]
        public bool? RemedyDateLimit { get; set; }

        /// <summary>
        /// <para>补卡时间，几天内补卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("remedy_date_num")]
        public int? RemedyDateNum { get; set; }

        /// <summary>
        /// <para>允许缺卡补卡（需要允许补卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_remedy_type_lack")]
        public bool? AllowRemedyTypeLack { get; set; }

        /// <summary>
        /// <para>允许迟到补卡（需要允许补卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_remedy_type_late")]
        public bool? AllowRemedyTypeLate { get; set; }

        /// <summary>
        /// <para>允许早退补卡（需要允许补卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_remedy_type_early")]
        public bool? AllowRemedyTypeEarly { get; set; }

        /// <summary>
        /// <para>允许正常补卡（需要允许补卡才能设置生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_remedy_type_normal")]
        public bool? AllowRemedyTypeNormal { get; set; }

        /// <summary>
        /// <para>是否展示累计时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("show_cumulative_time")]
        public bool? ShowCumulativeTime { get; set; }

        /// <summary>
        /// <para>是否展示加班时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("show_over_time")]
        public bool? ShowOverTime { get; set; }

        /// <summary>
        /// <para>是否隐藏员工打卡详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("hide_staff_punch_time")]
        public bool? HideStaffPunchTime { get; set; }

        /// <summary>
        /// <para>是否隐藏打卡规则（仅灰度租户有效，如需使用请联系技术支持）</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("hide_clock_in_rule")]
        public bool? HideClockInRule { get; set; }

        /// <summary>
        /// <para>是否开启人脸识别打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("face_punch")]
        public bool? FacePunch { get; set; }

        /// <summary>
        /// <para>人脸识别打卡规则</para>
        /// <para>**可选值有：**</para>
        /// <para>* 1：每次打卡均需人脸识别</para>
        /// <para>* 2：疑似作弊打卡时需要人脸识别</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("face_punch_cfg")]
        public int? FacePunchCfg { get; set; }

        /// <summary>
        /// <para>人脸打卡规则， false：开启活体验证 true：0动作验证，仅在 face_punch_cfg = 1 时有效</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("face_live_need_action")]
        public bool? FaceLiveNeedAction { get; set; }

        /// <summary>
        /// <para>人脸识别失败时是否允许普通拍照打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("face_downgrade")]
        public bool? FaceDowngrade { get; set; }

        /// <summary>
        /// <para>人脸识别失败时是否允许替换基准图片</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("replace_basic_pic")]
        public bool? ReplaceBasicPic { get; set; }

        /// <summary>
        /// <para>防作弊打卡配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("anti_cheat_punch_config")]
        public AntiCheatConfig? AntiCheatPunchConfig { get; set; }

        /// <summary>
        /// <para>防作弊打卡配置</para>
        /// </summary>
        public record AntiCheatConfig
        {
            /// <summary>
            /// <para>是否拦截疑似作弊打卡，默认关闭；关闭时，其余防作弊开关都为关闭</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("intercept_suspected_cheat_punch")]
            public bool InterceptSuspectedCheatPunch { get; set; }

            /// <summary>
            /// <para>是否校验疑似作弊软件打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("check_cheat_software_punch")]
            public bool? CheckCheatSoftwarePunch { get; set; }

            /// <summary>
            /// <para>是否校验疑似他人代打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("check_buddy_punch")]
            public bool? CheckBuddyPunch { get; set; }

            /// <summary>
            /// <para>是否校验疑似模拟 WI-FI 打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("check_simulate_wifi_punch")]
            public bool? CheckSimulateWifiPunch { get; set; }

            /// <summary>
            /// <para>是否校验更换设备打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("check_change_device_punch")]
            public bool? CheckChangeDevicePunch { get; set; }

            /// <summary>
            /// <para>同一考勤人员最多可绑定打卡设备数量上限，开启校验更换设备打卡时必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：3</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("allow_change_device_num")]
            public int? AllowChangeDeviceNum { get; set; }

            /// <summary>
            /// <para>疑似作弊打卡时的处理方式，开启拦截疑似作弊打卡时必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：2</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：使用人脸识别打卡</item>
            /// <item>2：仅记录疑似作弊信息</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("suspected_cheat_handle_method")]
            public int? SuspectedCheatHandleMethod { get; set; }
        }

        /// <summary>
        /// <para>考勤机列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("machines")]
        public Machine[]? Machines { get; set; }

        /// <summary>
        /// <para>考勤机列表</para>
        /// </summary>
        public record Machine
        {
            /// <summary>
            /// <para>考勤机序列号</para>
            /// <para>必填：是</para>
            /// <para>示例值：FS0701</para>
            /// </summary>
            [JsonPropertyName("machine_sn")]
            public string MachineSn { get; set; } = string.Empty;

            /// <summary>
            /// <para>考勤机名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：创实 9 楼</para>
            /// </summary>
            [JsonPropertyName("machine_name")]
            public string MachineName { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>GPS 打卡的有效范围（不建议使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：300</para>
        /// </summary>
        [JsonPropertyName("gps_range")]
        public int? GpsRange { get; set; }

        /// <summary>
        /// <para>地址列表（仅追加，不会覆盖之前的列表）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("locations")]
        public Location[]? Locations { get; set; }

        /// <summary>
        /// <para>地址列表（仅追加，不会覆盖之前的列表）</para>
        /// </summary>
        public record Location
        {
            /// <summary>
            /// <para>地址 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6921213751454744578</para>
            /// </summary>
            [JsonPropertyName("location_id")]
            public string? LocationId { get; set; }

            /// <summary>
            /// <para>地址名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：浙江省杭州市余杭区五常街道木桥头西溪八方城</para>
            /// </summary>
            [JsonPropertyName("location_name")]
            public string LocationName { get; set; } = string.Empty;

            /// <summary>
            /// <para>地址类型</para>
            /// <para>**可选值有：**</para>
            /// <para>* 1：GPS</para>
            /// <para>* 2：Wi-Fi</para>
            /// <para>* 8：IP</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("location_type")]
            public int LocationType { get; set; }

            /// <summary>
            /// <para>地址纬度</para>
            /// <para>必填：否</para>
            /// <para>示例值：30.28994</para>
            /// </summary>
            [JsonPropertyName("latitude")]
            public float? Latitude { get; set; }

            /// <summary>
            /// <para>地址经度</para>
            /// <para>必填：否</para>
            /// <para>示例值：120.04509</para>
            /// </summary>
            [JsonPropertyName("longitude")]
            public float? Longitude { get; set; }

            /// <summary>
            /// <para>Wi-Fi 名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：TP-Link-af12ca</para>
            /// </summary>
            [JsonPropertyName("ssid")]
            public string? Ssid { get; set; }

            /// <summary>
            /// <para>Wi-Fi 的 MAC 地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：08:00:20:0A:8C:6D</para>
            /// </summary>
            [JsonPropertyName("bssid")]
            public string? Bssid { get; set; }

            /// <summary>
            /// <para>地图类型，1：高德， 2：谷歌</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("map_type")]
            public int? MapType { get; set; }

            /// <summary>
            /// <para>地址名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市海淀区中航广场</para>
            /// </summary>
            [JsonPropertyName("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>IP 地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：122.224.123.146</para>
            /// </summary>
            [JsonPropertyName("ip")]
            public string? Ip { get; set; }

            /// <summary>
            /// <para>额外信息，例如：运营商信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国电信</para>
            /// </summary>
            [JsonPropertyName("feature")]
            public string? Feature { get; set; }

            /// <summary>
            /// <para>GPS 打卡的有效范围</para>
            /// <para>必填：否</para>
            /// <para>示例值：300</para>
            /// </summary>
            [JsonPropertyName("gps_range")]
            public int? GpsRange { get; set; }
        }

        /// <summary>
        /// <para>考勤类型</para>
        /// <para>**可选值有：**</para>
        /// <para>* 0：固定班制</para>
        /// <para>* 2：排班制</para>
        /// <para>* 3：自由班制</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("group_type")]
        public int GroupType { get; set; }

        /// <summary>
        /// <para>固定班制返回，可用于[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6921319402260496386</para>
        /// </summary>
        [JsonPropertyName("punch_day_shift_ids")]
        public string[] PunchDayShiftIds { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>配置自由班制</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("free_punch_cfg")]
        public PostAttendanceV1GroupsResponseDtoGroupFreePunchCfg? FreePunchCfg { get; set; }

        /// <summary>
        /// <para>配置自由班制</para>
        /// </summary>
        public record PostAttendanceV1GroupsResponseDtoGroupFreePunchCfg
        {
            /// <summary>
            /// <para>自由班制打卡开始时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：7:00</para>
            /// </summary>
            [JsonPropertyName("free_start_time")]
            public string FreeStartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>自由班制打卡结束时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：18:00</para>
            /// </summary>
            [JsonPropertyName("free_end_time")]
            public string FreeEndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>打卡的时间，为 7 位数字，每一位依次代表周一到周日，0 为不上班，1 为上班</para>
            /// <para>必填：是</para>
            /// <para>示例值：1111100</para>
            /// </summary>
            [JsonPropertyName("punch_day")]
            public int PunchDay { get; set; }

            /// <summary>
            /// <para>工作日不打卡是否记为缺卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("work_day_no_punch_as_lack")]
            public bool? WorkDayNoPunchAsLack { get; set; }

            /// <summary>
            /// <para>工作日出勤是否需满足时长要求</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("work_hours_demand")]
            public bool? WorkHoursDemand { get; set; }

            /// <summary>
            /// <para>每日工作时长（分钟),范围[0,1440]</para>
            /// <para>必填：否</para>
            /// <para>示例值：480</para>
            /// </summary>
            [JsonPropertyName("work_hours")]
            public int? WorkHours { get; set; }
        }

        /// <summary>
        /// <para>国家日历 ID</para>
        /// <para>**可选值有：**</para>
        /// <para>* 0：不根据国家日历排休</para>
        /// <para>* 1：中国大陆</para>
        /// <para>* 2：美国</para>
        /// <para>* 3：日本</para>
        /// <para>* 4：印度</para>
        /// <para>* 5：新加坡</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("calendar_id")]
        public int CalendarId { get; set; }

        /// <summary>
        /// <para>必须打卡的特殊日期</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("need_punch_special_days")]
        public PunchSpecialDateShift[]? NeedPunchSpecialDays { get; set; }

        /// <summary>
        /// <para>必须打卡的特殊日期</para>
        /// </summary>
        public record PunchSpecialDateShift
        {
            /// <summary>
            /// <para>打卡日期</para>
            /// <para>必填：是</para>
            /// <para>示例值：20190101</para>
            /// </summary>
            [JsonPropertyName("punch_day")]
            public int PunchDay { get; set; }

            /// <summary>
            /// <para>班次 ID，可用于[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
            /// <para>必填：是</para>
            /// <para>示例值：6919668827865513935</para>
            /// </summary>
            [JsonPropertyName("shift_id")]
            public string ShiftId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>无需打卡的特殊日期</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("no_need_punch_special_days")]
        public PunchSpecialDateShift[]? NoNeedPunchSpecialDays { get; set; }

        /// <summary>
        /// <para>自由班制下工作日不打卡是否记为缺卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("work_day_no_punch_as_lack")]
        public bool? WorkDayNoPunchAsLack { get; set; }

        /// <summary>
        /// <para>是否立即生效，默认 false</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("effect_now")]
        public bool? EffectNow { get; set; }

        /// <summary>
        /// <para>补卡周期类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("remedy_period_type")]
        public int? RemedyPeriodType { get; set; }

        /// <summary>
        /// <para>补卡自定义周期起始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("remedy_period_custom_date")]
        public int? RemedyPeriodCustomDate { get; set; }

        /// <summary>
        /// <para>打卡类型。</para>
        /// <para>位运算，即如果设置了 1 和 2 两种打卡类型，则对应的参数加和值为 3。</para>
        /// <para>**可选值**：</para>
        /// <para>* 1：GPS 打卡</para>
        /// <para>* 2：Wi-Fi 打卡</para>
        /// <para>* 4：考勤机打卡</para>
        /// <para>* 8：IP 打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("punch_type")]
        public int? PunchType { get; set; }

        /// <summary>
        /// <para>生效时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonPropertyName("effect_time")]
        public string? EffectTime { get; set; }

        /// <summary>
        /// <para>固定班次生效时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonPropertyName("fixshift_effect_time")]
        public string? FixshiftEffectTime { get; set; }

        /// <summary>
        /// <para>参加考勤的人员、部门变动生效时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonPropertyName("member_effect_time")]
        public string? MemberEffectTime { get; set; }

        /// <summary>
        /// <para>休息日打卡需审批</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("rest_clockIn_need_approval")]
        public bool? RestClockInNeedApproval { get; set; }

        /// <summary>
        /// <para>每次打卡均需拍照</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("clockIn_need_photo")]
        public bool? ClockInNeedPhoto { get; set; }

        /// <summary>
        /// <para>人员异动打卡设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_status_change")]
        public PostAttendanceV1GroupsResponseDtoGroupMemberStatusChange? MemberStatusChange { get; set; }

        /// <summary>
        /// <para>人员异动打卡设置</para>
        /// </summary>
        public record PostAttendanceV1GroupsResponseDtoGroupMemberStatusChange
        {
            /// <summary>
            /// <para>是否入职日上班无需打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("onboarding_on_no_need_punch")]
            public bool? OnboardingOnNoNeedPunch { get; set; }

            /// <summary>
            /// <para>是否入职日下班无需打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("onboarding_off_no_need_punch")]
            public bool? OnboardingOffNoNeedPunch { get; set; }

            /// <summary>
            /// <para>是否离职日上班无需打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("offboarding_on_no_need_punch")]
            public bool? OffboardingOnNoNeedPunch { get; set; }

            /// <summary>
            /// <para>是否离职日下班无需打卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("offboarding_off_no_need_punch")]
            public bool? OffboardingOffNoNeedPunch { get; set; }
        }

        /// <summary>
        /// <para>请假离岗或返岗是否需打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("leave_need_punch")]
        public bool? LeaveNeedPunch { get; set; }

        /// <summary>
        /// <para>请假离岗或返岗打卡规则，单位：分钟</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_need_punch_cfg")]
        public PostAttendanceV1GroupsResponseDtoGroupLeaveNeedPunchCfg? LeaveNeedPunchCfg { get; set; }

        /// <summary>
        /// <para>请假离岗或返岗打卡规则，单位：分钟</para>
        /// </summary>
        public record PostAttendanceV1GroupsResponseDtoGroupLeaveNeedPunchCfg
        {
            /// <summary>
            /// <para>晚到超过多久记为迟到</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("late_minutes_as_late")]
            public int? LateMinutesAsLate { get; set; }

            /// <summary>
            /// <para>晚到超过多久记为缺卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("late_minutes_as_lack")]
            public int? LateMinutesAsLack { get; set; }

            /// <summary>
            /// <para>早走超过多久记为早退</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("early_minutes_as_early")]
            public int? EarlyMinutesAsEarly { get; set; }

            /// <summary>
            /// <para>早走超过多久记为缺卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("early_minutes_as_lack")]
            public int? EarlyMinutesAsLack { get; set; }

            /// <summary>
            /// <para>班次中间请假，无需在离岗前或返岗后打卡（仅灰度租户有效，如需使用请联系技术支持）</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("not_during_shift")]
            public bool? NotDuringShift { get; set; }
        }

        /// <summary>
        /// <para>外出期间是否需打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("go_out_need_punch")]
        public int? GoOutNeedPunch { get; set; }

        /// <summary>
        /// <para>外出期间打卡规则，单位：分钟</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("go_out_need_punch_cfg")]
        public LeaveNeedPunchCfgSuffix? GoOutNeedPunchCfg { get; set; }

        /// <summary>
        /// <para>外出期间打卡规则，单位：分钟</para>
        /// </summary>
        public record LeaveNeedPunchCfgSuffix
        {
            /// <summary>
            /// <para>晚到超过多久记为迟到</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("late_minutes_as_late")]
            public int? LateMinutesAsLate { get; set; }

            /// <summary>
            /// <para>晚到超过多久记为缺卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("late_minutes_as_lack")]
            public int? LateMinutesAsLack { get; set; }

            /// <summary>
            /// <para>早走超过多久记为早退</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("early_minutes_as_early")]
            public int? EarlyMinutesAsEarly { get; set; }

            /// <summary>
            /// <para>早走超过多久记为缺卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("early_minutes_as_lack")]
            public int? EarlyMinutesAsLack { get; set; }

            /// <summary>
            /// <para>班次中间外出，无需在离岗前或返岗后打卡（仅灰度租户有效，如需使用请联系技术支持）</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("not_during_shift")]
            public bool? NotDuringShift { get; set; }
        }

        /// <summary>
        /// <para>出差期间是否需打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("travel_need_punch")]
        public int? TravelNeedPunch { get; set; }

        /// <summary>
        /// <para>出差期间打卡规则，单位：分钟</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("travel_need_punch_cfg")]
        public LeaveNeedPunchCfgSuffix? TravelNeedPunchCfg { get; set; }

        /// <summary>
        /// <para>需要打卡的人员集合（仅当不传「bind_dept_ids」和「bind_user_ids」时，才会使用该字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("need_punch_members")]
        public PunchMember[]? NeedPunchMembers { get; set; }

        /// <summary>
        /// <para>需要打卡的人员集合（仅当不传「bind_dept_ids」和「bind_user_ids」时，才会使用该字段）</para>
        /// </summary>
        public record PunchMember
        {
            /// <summary>
            /// <para>圈人方式：0 无 1全部 2自定义</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("rule_scope_type")]
            public int? RuleScopeType { get; set; }

            /// <summary>
            /// <para>圈人规则列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("scope_group_list")]
            public ScopeGroup? ScopeGroupList { get; set; }

            /// <summary>
            /// <para>圈人规则列表</para>
            /// </summary>
            public record ScopeGroup
            {
                /// <summary>
                /// <para>**类型**：</para>
                /// <para>* 1: 部门</para>
                /// <para>* 2:人员</para>
                /// <para>* 3: 国家地区</para>
                /// <para>* 4: 员工类型</para>
                /// <para>* 5: 工作城市</para>
                /// <para>* 6: 职级</para>
                /// <para>* 7: 序列</para>
                /// <para>* 8: 职务（企业版）</para>
                /// <para>* 9: 工时制度（企业版）</para>
                /// <para>* 100: 自定义字段（企业版）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("scope_value_type")]
                public int? ScopeValueType { get; set; }

                /// <summary>
                /// <para>范围类型（是否包含）</para>
                /// <para>* 1: 包含</para>
                /// <para>* 2: 不包含</para>
                /// <para>* 3: 相等</para>
                /// <para>* 4: 小于等于</para>
                /// <para>* 5: 大于等于</para>
                /// <para>* 6: 大于</para>
                /// <para>* 7: 小于</para>
                /// <para>* 8: 不相等</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("operation_type")]
                public int? OperationType { get; set; }

                /// <summary>
                /// <para>如果是人员/部门类型 不需要使用该字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("right")]
                public ScopeValue[]? Rights { get; set; }

                /// <summary>
                /// <para>如果是人员/部门类型 不需要使用该字段</para>
                /// </summary>
                public record ScopeValue
                {
                    /// <summary>
                    /// <para>标识Key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：CH</para>
                    /// </summary>
                    [JsonPropertyName("key")]
                    public string? Key { get; set; }

                    /// <summary>
                    /// <para>名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中国大陆</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }

                /// <summary>
                /// <para>部门/人员 ID 列表（根据 scope_value_type 判断为部门或人员）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("member_ids")]
                public string[]? MemberIds { get; set; }

                /// <summary>
                /// <para>企业版自定义字段唯一键 ID, 需要从飞书人事那边获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：123213123</para>
                /// </summary>
                [JsonPropertyName("custom_field_ID")]
                public string? CustomFieldID { get; set; }

                /// <summary>
                /// <para>企业版自定义字段对象类型</para>
                /// <para>* "Employment": 主数据对象，员工雇佣信息</para>
                /// <para>* "Person": 主数据对象，个人</para>
                /// <para>必填：否</para>
                /// <para>示例值：employment</para>
                /// </summary>
                [JsonPropertyName("custom_field_obj_type")]
                public string? CustomFieldObjType { get; set; }
            }
        }

        /// <summary>
        /// <para>无需打卡的人员集合（仅当不传「bind_default_dept_ids」和「bind_default_user_ids」时，才会使用该字段）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("no_need_punch_members")]
        public PunchMember[]? NoNeedPunchMembers { get; set; }

        /// <summary>
        /// <para>是否允许保存有冲突人员的考勤组。如果 true，则冲突人员将被自动拉入到当前设置的考勤组中，并从原考勤组中移除；如果 false，则需手动调整冲突人员。默认为 false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("save_auto_changes")]
        public bool? SaveAutoChanges { get; set; }

        /// <summary>
        /// <para>当有新员工入职或人员异动，符合条件的人员是否自动加入考勤组</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("org_change_auto_adjust")]
        public bool? OrgChangeAutoAdjust { get; set; }

        /// <summary>
        /// <para>参与无需打卡的部门 ID 列表（与「no_need_punch_members」同时使用时，以当前字段为准），对应dept_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bind_default_dept_ids")]
        public string[]? BindDefaultDeptIds { get; set; }

        /// <summary>
        /// <para>参与无需打卡的人员 ID 列表（与「no_need_punch_members」同时使用时，以当前字段为准），对应employee_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bind_default_user_ids")]
        public string[]? BindDefaultUserIds { get; set; }

        /// <summary>
        /// <para>加班打卡规则</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("overtime_clock_cfg")]
        public PostAttendanceV1GroupsResponseDtoGroupOvertimeClockCfg? OvertimeClockCfg { get; set; }

        /// <summary>
        /// <para>加班打卡规则</para>
        /// </summary>
        public record PostAttendanceV1GroupsResponseDtoGroupOvertimeClockCfg
        {
            /// <summary>
            /// <para>是否允许在非打卡时段申请打卡（仅灰度租户有效，如需使用请联系技术支持）</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("allow_punch_approval")]
            public bool? AllowPunchApproval { get; set; }

            /// <summary>
            /// <para>加班开始和结束需打卡（仅灰度租户有效，如需使用请联系技术支持）</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("need_clock_over_time_start_and_end")]
            public bool? NeedClockOverTimeStartAndEnd { get; set; }
        }

        /// <summary>
        /// <para>节假日id，（如果考勤组使用了自定义节假日，请用此参数传入节假日id，可在假勤设置-节假日模块页面路径获取）</para>
        /// <para>必填：否</para>
        /// <para>示例值：7302191700771358252</para>
        /// </summary>
        [JsonPropertyName("new_calendar_id")]
        public string? NewCalendarId { get; set; }

        /// <summary>
        /// <para>定位不准时是否允许申请打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("allow_apply_punch")]
        public bool? AllowApplyPunch { get; set; }

        /// <summary>
        /// <para>异常卡豁免配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("clock_in_abnormal_settings")]
        public PostAttendanceV1GroupsResponseDtoGroupClockInAbnormalSettings? ClockInAbnormalSettings { get; set; }

        /// <summary>
        /// <para>异常卡豁免配置</para>
        /// </summary>
        public record PostAttendanceV1GroupsResponseDtoGroupClockInAbnormalSettings
        {
            /// <summary>
            /// <para>在最晚下班打卡之前忽略异常卡（仅灰度租户有效，如需使用请联系技术支持）</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("ignore_until_latest_clockout")]
            public bool? IgnoreUntilLatestClockout { get; set; }
        }
    }
}
