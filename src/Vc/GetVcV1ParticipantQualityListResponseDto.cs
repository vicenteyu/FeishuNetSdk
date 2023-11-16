namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询参会人会议质量数据 响应体
/// <para>查询参会人会议质量数据（仅支持已结束会议），具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7194805625628049411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fparticipant_quality_list%2fget</para>
/// </summary>
public record GetVcV1ParticipantQualityListResponseDto
{
    /// <summary>
    /// <para>参会人参会质量列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("participant_quality_list")]
    public ParticipantQuality[]? ParticipantQualityLists { get; set; }

    /// <summary>
    /// <para>参会人参会质量列表</para>
    /// </summary>
    public record ParticipantQuality
    {
        /// <summary>
        /// <para>网络</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("network")]
        public QualityNetwork? Network { get; set; }

        /// <summary>
        /// <para>网络</para>
        /// </summary>
        public record QualityNetwork
        {
            /// <summary>
            /// <para>时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022.12.23 11:16:00 (GMT+08:00)</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }

            /// <summary>
            /// <para>网络延迟</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("network_delay")]
            public string? NetworkDelay { get; set; }

            /// <summary>
            /// <para>码率（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：8kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_received")]
            public string? BitrateReceived { get; set; }

            /// <summary>
            /// <para>丢包 - 平均（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：8%</para>
            /// </summary>
            [JsonPropertyName("packet_loss_avg_received")]
            public string? PacketLossAvgReceived { get; set; }

            /// <summary>
            /// <para>丢包 - 最大（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：9%</para>
            /// </summary>
            [JsonPropertyName("packet_loss_max_received")]
            public string? PacketLossMaxReceived { get; set; }

            /// <summary>
            /// <para>码率（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：9kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_sent")]
            public string? BitrateSent { get; set; }

            /// <summary>
            /// <para>丢包 - 平均（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：8%</para>
            /// </summary>
            [JsonPropertyName("packet_loss_avg_sent")]
            public string? PacketLossAvgSent { get; set; }

            /// <summary>
            /// <para>丢包 - 最大（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：10%</para>
            /// </summary>
            [JsonPropertyName("packet_loss_max_sent")]
            public string? PacketLossMaxSent { get; set; }
        }

        /// <summary>
        /// <para>音频</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("audio")]
        public QualityAudio? Audio { get; set; }

        /// <summary>
        /// <para>音频</para>
        /// </summary>
        public record QualityAudio
        {
            /// <summary>
            /// <para>时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022.12.23 11:16:00 (GMT+08:00)</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }

            /// <summary>
            /// <para>麦克风采集音量</para>
            /// <para>必填：否</para>
            /// <para>示例值：6dB</para>
            /// </summary>
            [JsonPropertyName("mic_input_volume")]
            public string? MicInputVolume { get; set; }

            /// <summary>
            /// <para>扬声器播放音量</para>
            /// <para>必填：否</para>
            /// <para>示例值：8dB</para>
            /// </summary>
            [JsonPropertyName("speaker_volume")]
            public string? SpeakerVolume { get; set; }

            /// <summary>
            /// <para>码率（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：3kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_received")]
            public string? BitrateReceived { get; set; }

            /// <summary>
            /// <para>延迟（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("latency_received")]
            public string? LatencyReceived { get; set; }

            /// <summary>
            /// <para>抖动（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("jitter_received")]
            public string? JitterReceived { get; set; }

            /// <summary>
            /// <para>码率（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：9kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_sent")]
            public string? BitrateSent { get; set; }

            /// <summary>
            /// <para>延迟（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("latency_sent")]
            public string? LatencySent { get; set; }

            /// <summary>
            /// <para>抖动（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("jitter_sent")]
            public string? JitterSent { get; set; }
        }

        /// <summary>
        /// <para>视频</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("video")]
        public QualityVideoSharing? Video { get; set; }

        /// <summary>
        /// <para>视频</para>
        /// </summary>
        public record QualityVideoSharing
        {
            /// <summary>
            /// <para>时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022.12.23 11:16:00 (GMT+08:00)</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }

            /// <summary>
            /// <para>码率（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：8kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_received")]
            public string? BitrateReceived { get; set; }

            /// <summary>
            /// <para>延迟（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("latency_received")]
            public string? LatencyReceived { get; set; }

            /// <summary>
            /// <para>抖动（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("jitter_received")]
            public string? JitterReceived { get; set; }

            /// <summary>
            /// <para>最大分辨率（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1080P</para>
            /// </summary>
            [JsonPropertyName("maximum_resolution_received")]
            public string? MaximumResolutionReceived { get; set; }

            /// <summary>
            /// <para>帧率（接收）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100fps</para>
            /// </summary>
            [JsonPropertyName("framerate_received")]
            public string? FramerateReceived { get; set; }

            /// <summary>
            /// <para>码率（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：9kbps</para>
            /// </summary>
            [JsonPropertyName("bitrate_sent")]
            public string? BitrateSent { get; set; }

            /// <summary>
            /// <para>延迟（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("latency_sent")]
            public string? LatencySent { get; set; }

            /// <summary>
            /// <para>抖动（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100ms</para>
            /// </summary>
            [JsonPropertyName("jitter_sent")]
            public string? JitterSent { get; set; }

            /// <summary>
            /// <para>最大分辨率（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：4K</para>
            /// </summary>
            [JsonPropertyName("maximum_resolution_sent")]
            public string? MaximumResolutionSent { get; set; }

            /// <summary>
            /// <para>帧率（发送）</para>
            /// <para>必填：否</para>
            /// <para>示例值：90fps</para>
            /// </summary>
            [JsonPropertyName("framerate_sent")]
            public string? FramerateSent { get; set; }
        }

        /// <summary>
        /// <para>共享屏幕</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("screen_sharing")]
        public QualityVideoSharing? ScreenSharing { get; set; }

        /// <summary>
        /// <para>Cpu使用量</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cpu_usage")]
        public QualityCpuUsage? CpuUsage { get; set; }

        /// <summary>
        /// <para>Cpu使用量</para>
        /// </summary>
        public record QualityCpuUsage
        {
            /// <summary>
            /// <para>时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022.12.23 11:17:00</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }

            /// <summary>
            /// <para>客户端平均 CPU 占用</para>
            /// <para>必填：否</para>
            /// <para>示例值：0.8%</para>
            /// </summary>
            [JsonPropertyName("client_avg_cpu_usage")]
            public string? ClientAvgCpuUsage { get; set; }

            /// <summary>
            /// <para>客户端最大 CPU 占用</para>
            /// <para>必填：否</para>
            /// <para>示例值：2.3%</para>
            /// </summary>
            [JsonPropertyName("client_max_cpu_usage")]
            public string? ClientMaxCpuUsage { get; set; }

            /// <summary>
            /// <para>系统平均 CPU 占用</para>
            /// <para>必填：否</para>
            /// <para>示例值：8.3%</para>
            /// </summary>
            [JsonPropertyName("system_avg_cpu_usage")]
            public string? SystemAvgCpuUsage { get; set; }

            /// <summary>
            /// <para>系统最大 CPU 占用</para>
            /// <para>必填：否</para>
            /// <para>示例值：30%</para>
            /// </summary>
            [JsonPropertyName("system_max_cpu_usage")]
            public string? SystemMaxCpuUsage { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
