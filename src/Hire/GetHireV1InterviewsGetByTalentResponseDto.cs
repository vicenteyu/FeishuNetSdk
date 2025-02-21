// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="GetHireV1InterviewsGetByTalentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才面试信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才面试信息 响应体
/// <para>获取人才下所有面试信息。</para>
/// <para>接口ID：7055229817129811969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/get_by_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview%2fget_by_talent</para>
/// </summary>
public record GetHireV1InterviewsGetByTalentResponseDto
{
    /// <summary>
    /// <para>投递面试列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TalentInterview[]? Items { get; set; }

    /// <summary>
    /// <para>投递面试列表</para>
    /// </summary>
    public record TalentInterview
    {
        /// <summary>
        /// <para>投递 ID，详情可查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>面试列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_list")]
        public InterviewExtend[]? InterviewLists { get; set; }

        /// <summary>
        /// <para>面试列表</para>
        /// </summary>
        public record InterviewExtend
        {
            /// <summary>
            /// <para>面试 ID，详情请查看：[获取面试信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试开始时间，毫秒时间戳（字段类型为：int64）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618899376474</para>
            /// </summary>
            [JsonPropertyName("begin_time")]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>面试结束时间，毫秒时间戳（字段类型为：int64）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618999376474</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>面试轮次</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("round")]
            public int? Round { get; set; }

            /// <summary>
            /// <para>面试评价信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_record_list")]
            public InterviewRecord[]? InterviewRecordLists { get; set; }

            /// <summary>
            /// <para>面试评价信息</para>
            /// </summary>
            public record InterviewRecord
            {
                /// <summary>
                /// <para>面试评价 ID，详情可参考：[获取面试评价详细信息（新版）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/interview_record/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>面试官用户 ID，与入参`user_id_type`类型一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618899376474</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }

                /// <summary>
                /// <para>系统预设题目内容，来自「飞书招聘」-「设置」-「面试设置」-「面试评价表设置」的面试评价表中预设字段「记录」，详情参考[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：符合要求，推荐录用</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>面试评价的提交状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：已提交</item>
                /// <item>2：未提交</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("commit_status")]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <para>面试结论</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：通过</item>
                /// <item>2：未通过</item>
                /// <item>3：未开始</item>
                /// <item>4：未提交</item>
                /// <item>5：未到场</item>
                /// <item>6：待定</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("conclusion")]
                public int? Conclusion { get; set; }

                /// <summary>
                /// <para>面试评分</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("interview_score")]
                public InterviewRecordInterviewScore? InterviewScore { get; set; }

                /// <summary>
                /// <para>面试评分</para>
                /// </summary>
                public record InterviewRecordInterviewScore
                {
                    /// <summary>
                    /// <para>面试评分 ID，对应[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)接口返回数据中的 `data.items.modules.dimensions.option_items.id` 字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6949805467799537964</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>分数级别</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
                    /// </summary>
                    [JsonPropertyName("level")]
                    public int? Level { get; set; }

                    /// <summary>
                    /// <para>面试评分中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：第一轮面试</para>
                    /// </summary>
                    [JsonPropertyName("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>面试评分中文描述</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：通过，能力达到要求， 建议录用</para>
                    /// </summary>
                    [JsonPropertyName("zh_description")]
                    public string? ZhDescription { get; set; }

                    /// <summary>
                    /// <para>面试评分英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：English name</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>面试评分英文描述</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Pass, ability to meet the requirements, suggest to hire</para>
                    /// </summary>
                    [JsonPropertyName("en_description")]
                    public string? EnDescription { get; set; }
                }

                /// <summary>
                /// <para>面试官信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("interviewer")]
                public IdNameObject? Interviewer { get; set; }

                /// <summary>
                /// <para>面试官信息</para>
                /// </summary>
                public record IdNameObject
                {
                    /// <summary>
                    /// <para>面试官 ID，与入参`user_id_type`类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_bc6dd7d30630700f443193d602841086</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>面试官姓名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：10</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>面试官姓名</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>面试官中文姓名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：周小二</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>面试官英文姓名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Tony Ma</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>面试评价提交时间，毫秒时间戳（字段类型为：int64）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1659318415000</para>
            /// </summary>
            [JsonPropertyName("feedback_submit_time")]
            public long? FeedbackSubmitTime { get; set; }

            /// <summary>
            /// <para>面试关联的投递阶段，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：634324253532232</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>投递 ID，详情参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_application/create)</para>
            /// <para>必填：否</para>
            /// <para>示例值：634324253532232</para>
            /// </summary>
            [JsonPropertyName("application_id")]
            public string? ApplicationId { get; set; }

            /// <summary>
            /// <para>阶段信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("stage")]
            public IdNameObject? Stage { get; set; }

            /// <summary>
            /// <para>阶段信息</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>投递阶段 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：1213213123123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>阶段信息名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>阶段信息名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>阶段信息中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：笔试</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>阶段信息英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：writing</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>创建人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("creator")]
            public IdNameObject? Creator { get; set; }

            /// <summary>
            /// <para>创建时间，毫秒时间戳（字段类型为：int64）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618999376474</para>
            /// </summary>
            [JsonPropertyName("biz_create_time")]
            public long? BizCreateTime { get; set; }

            /// <summary>
            /// <para>最近更新时间，毫秒时间戳（字段类型为：int64）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618999376474</para>
            /// </summary>
            [JsonPropertyName("biz_modify_time")]
            public long? BizModifyTime { get; set; }

            /// <summary>
            /// <para>面试状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>2：未开始</item>
            /// <item>3：全部未评价</item>
            /// <item>4：全部通过</item>
            /// <item>5：全部淘汰</item>
            /// <item>6：爽约</item>
            /// <item>7：部分评价且均评价通过</item>
            /// <item>8：部分评价且评价中有通过有淘汰的</item>
            /// <item>9：部分评价且均评价淘汰</item>
            /// <item>10：所有面试官都提交评价且评价中有通过有淘汰的</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("interview_round_summary")]
            public int? InterviewRoundSummary { get; set; }

            /// <summary>
            /// <para>面试安排 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1111111</para>
            /// </summary>
            [JsonPropertyName("interview_arrangement_id")]
            public string? InterviewArrangementId { get; set; }

            /// <summary>
            /// <para>面试类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：现场面试</item>
            /// <item>2：电话面试</item>
            /// <item>3：视频面试</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("interview_type")]
            public int? InterviewType { get; set; }

            /// <summary>
            /// <para>候选人时区</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("talent_time_zone")]
            public CodeNameObject? TalentTimeZone { get; set; }

            /// <summary>
            /// <para>候选人时区</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：UTC+08:00</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>候选人时区名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>候选人时区名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>候选人中文时区名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：亚洲/上海</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>候选人英文时区名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Asia/Shanghai</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>面试联系人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contact_user")]
            public IdNameObject? ContactUser { get; set; }

            /// <summary>
            /// <para>面试联系人电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：13333333333</para>
            /// </summary>
            [JsonPropertyName("contact_mobile")]
            public string? ContactMobile { get; set; }

            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一个备注</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>面试地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public InterviewAddress? Address { get; set; }

            /// <summary>
            /// <para>面试地址</para>
            /// </summary>
            public record InterviewAddress
            {
                /// <summary>
                /// <para>地址 ID，可通过[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>地址名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>地址名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>地址中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中国</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>地址英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：China</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>区域</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("district")]
                public CodeNameObject? District { get; set; }

                /// <summary>
                /// <para>区域</para>
                /// </summary>
                public record CodeNameObject
                {
                    /// <summary>
                    /// <para>区域编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：DS_1</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>区域名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>区域名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>区域中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：武侯区</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>区域英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Wu Hou</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>城市</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("city")]
                public CodeNameObject? City { get; set; }

                /// <summary>
                /// <para>省</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("state")]
                public CodeNameObject? State { get; set; }

                /// <summary>
                /// <para>国家</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("country")]
                public CodeNameObject? Country { get; set; }
            }

            /// <summary>
            /// <para>视频面试工具</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：Zoom</item>
            /// <item>2：牛客技术类型</item>
            /// <item>3：牛客非技术类型</item>
            /// <item>4：赛码</item>
            /// <item>5：飞书</item>
            /// <item>8：Hackerrank</item>
            /// <item>9：飞书（含代码考核）</item>
            /// <item>100：不使用系统工具</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("video_type")]
            public int? VideoType { get; set; }

            /// <summary>
            /// <para>当安排类型为集中面试时，此值表示集中面试的安排状态。非集中面试该字段无含义。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未开始</item>
            /// <item>2：进行中</item>
            /// <item>3：已结束</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("arrangement_status")]
            public int? ArrangementStatus { get; set; }

            /// <summary>
            /// <para>安排类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：社招单面</item>
            /// <item>2：集中面试</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("arrangement_type")]
            public int? ArrangementType { get; set; }

            /// <summary>
            /// <para>安排方式（是否使用自助约面）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：直接安排</item>
            /// <item>2：自助约面</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("arrangement_appointment_kind")]
            public int? ArrangementAppointmentKind { get; set; }

            /// <summary>
            /// <para>面试会议室</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("meeting_room_list")]
            public InterviewMeetingRoom[]? MeetingRoomLists { get; set; }

            /// <summary>
            /// <para>面试会议室</para>
            /// </summary>
            public record InterviewMeetingRoom
            {
                /// <summary>
                /// <para>会议室 ID，详情可查看：[查询会议室列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("room_id")]
                public string? RoomId { get; set; }

                /// <summary>
                /// <para>会议室名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：OCG111</para>
                /// </summary>
                [JsonPropertyName("room_name")]
                public string? RoomName { get; set; }

                /// <summary>
                /// <para>建筑名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：OCG</para>
                /// </summary>
                [JsonPropertyName("building_name")]
                public string? BuildingName { get; set; }

                /// <summary>
                /// <para>会议室预定状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：预约中</item>
                /// <item>2：预约成功</item>
                /// <item>3：预约失败</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("reserved_status")]
                public int? ReservedStatus { get; set; }

                /// <summary>
                /// <para>楼层</para>
                /// <para>必填：否</para>
                /// <para>示例值：17</para>
                /// </summary>
                [JsonPropertyName("floor_name")]
                public string? FloorName { get; set; }
            }

            /// <summary>
            /// <para>面试轮次类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_round_type")]
            public IdNameObject? InterviewRoundType { get; set; }
        }
    }
}
