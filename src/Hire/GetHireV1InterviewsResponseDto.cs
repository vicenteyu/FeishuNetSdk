namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试信息 响应体
/// <para>根据投递 ID 或面试时间获取面试信息。</para>
/// <para>接口ID：6989078472837267459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview%2flist</para>
/// </summary>
public record GetHireV1InterviewsResponseDto
{
    /// <summary>
    /// <para>面试列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public InterviewExtend[]? Items { get; set; }

    /// <summary>
    /// <para>面试列表</para>
    /// </summary>
    public record InterviewExtend
    {
        /// <summary>
        /// <para>面试 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试开始时间（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618899376474</para>
        /// </summary>
        [JsonPropertyName("begin_time")]
        public int? BeginTime { get; set; }

        /// <summary>
        /// <para>面试结束时间（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618999376474</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>面试轮次</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("round")]
        public int? Round { get; set; }

        /// <summary>
        /// <para>面试记录信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_record_list")]
        public InterviewRecord[]? InterviewRecordLists { get; set; }

        /// <summary>
        /// <para>面试记录信息</para>
        /// </summary>
        public record InterviewRecord
        {
            /// <summary>
            /// <para>面试记录 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试官用户 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618899376474</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>系统预设「记录」题目内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：代码还行，只是不够聪明</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>建议定级下限的职级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6435238827342432</para>
            /// </summary>
            [JsonPropertyName("min_job_level_id")]
            public string? MinJobLevelId { get; set; }

            /// <summary>
            /// <para>建议定级上限的职级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：643523885843573</para>
            /// </summary>
            [JsonPropertyName("max_job_level_id")]
            public string? MaxJobLevelId { get; set; }

            /// <summary>
            /// <para>提交状态</para>
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
                /// <para>面试评分 ID</para>
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
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：3</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：通过,能力达到要求,建议录用</para>
                /// </summary>
                [JsonPropertyName("zh_description")]
                public string? ZhDescription { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：three</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>英文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：Pass,abilitytomeettherequirements,suggesttohire</para>
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
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1213213123123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>面试评价提交时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1659318415000</para>
        /// </summary>
        [JsonPropertyName("feedback_submit_time")]
        public int? FeedbackSubmitTime { get; set; }

        /// <summary>
        /// <para>面试关联的投递阶段</para>
        /// <para>必填：否</para>
        /// <para>示例值：634324253532232</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        public string? StageId { get; set; }

        /// <summary>
        /// <para>投递 ID</para>
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
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public IdNameObject? Creator { get; set; }

        /// <summary>
        /// <para>创建时间（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618999376474</para>
        /// </summary>
        [JsonPropertyName("biz_create_time")]
        public int? BizCreateTime { get; set; }

        /// <summary>
        /// <para>最近更新时间（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618999376474</para>
        /// </summary>
        [JsonPropertyName("biz_modify_time")]
        public int? BizModifyTime { get; set; }

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
            /// <para>示例值：1111</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// <para>面试地点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address")]
        public InterviewAddress? Address { get; set; }

        /// <summary>
        /// <para>面试地点</para>
        /// </summary>
        public record InterviewAddress
        {
            /// <summary>
            /// <para>地址 ID</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
                /// <para>编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：1111</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
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
        /// <para>当安排类型为集中面试时，此值表示集中面试的安排状态</para>
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
            /// <para>会议室 ID</para>
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

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
