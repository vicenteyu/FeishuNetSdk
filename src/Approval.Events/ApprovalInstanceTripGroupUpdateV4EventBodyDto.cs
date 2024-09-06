namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 出差审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/business-trip</para>
    /// </summary>
    public record ApprovalInstanceTripGroupUpdateV4EventBodyDto() : EventBodyDto("approval.instance.trip_group_update_v4")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public ObjectSuffix Object { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("old_object")]
        public object? OldObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record ObjectSuffix
        {
            /// <summary>
            /// 事件类型
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// 审批实例code
            /// </summary>
            [JsonPropertyName("instance_code")]
            public string? InstanceCode { get; set; }

            /// <summary>
            /// 提交人id
            /// </summary>
            [JsonPropertyName("start_user")]
            public UserSuffix StartUser { get; set; } = new();

            /// <summary>
            /// 审批实例开始时间
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// 审批实例结束时间
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// 出差计划
            /// </summary>
            [JsonPropertyName("schedules")]
            public Schedule[]? Schedules { get; set; }

            /// <summary>
            /// 出差时长
            /// </summary>
            [JsonPropertyName("trip_interval")]
            public string? TripInterval { get; set; }

            /// <summary>
            /// 出差原因
            /// </summary>
            [JsonPropertyName("trip_reason")]
            public string? TripReason { get; set; }

            /// <summary>
            /// 同行人
            /// </summary>
            [JsonPropertyName("trip_peers")]
            public UserSuffix[]? TripPeers { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record UserSuffix
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("id")]
                public UserIdSuffix Id { get; set; } = new();
            }

            /// <summary>
            /// 出差计划
            /// </summary>
            public record Schedule
            {
                /// <summary>
                /// 出差开始时间
                /// </summary>
                [JsonPropertyName("trip_start_time")]
                public string? TripStartTime { get; set; }

                /// <summary>
                /// 出差结束时间
                /// </summary>
                [JsonPropertyName("trip_end_time")]
                public string? TripEndTime { get; set; }

                /// <summary>
                /// 出差时长
                /// </summary>
                [JsonPropertyName("trip_interval")]
                public string? TripInterval { get; set; }

                /// <summary>
                /// 出发地
                /// </summary>
                [JsonPropertyName("departure")]
                public string? Departure { get; set; }

                /// <summary>
                /// 出发地
                /// </summary>
                [JsonPropertyName("departure_id")]
                public string? DepartureId { get; set; }

                /// <summary>
                /// 出差目的地
                /// </summary>
                [JsonPropertyName("destination")]
                public string? Destination { get; set; }

                /// <summary>
                /// 出差目的地
                /// </summary>
                [JsonPropertyName("destination_ids")]
                public string[]? DestinationIds { get; set; }

                /// <summary>
                /// 交通工具
                /// </summary>
                [JsonPropertyName("transportation")]
                public string? Transportation { get; set; }

                /// <summary>
                /// 出差类型
                /// </summary>
                [JsonPropertyName("trip_type")]
                public string? TripType { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }
    }
}
