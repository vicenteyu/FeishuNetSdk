namespace FeishuNetSdk.PersonalSettings;
/// <summary>
/// 创建系统状态 响应体
/// <para>创建租户维度的系统状态。</para>
/// <para>接口ID：7161608966368821251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fcreate</para>
/// </summary>
public record PostPersonalSettingsV1SystemStatusesResponseDto
{
    /// <summary>
    /// <para>系统状态</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("system_status")]
    public PostPersonalSettingsV1SystemStatusesResponseDtoSystemStatus? SystemStatus { get; set; }

    /// <summary>
    /// <para>系统状态</para>
    /// </summary>
    public record PostPersonalSettingsV1SystemStatusesResponseDtoSystemStatus
    {
        /// <summary>
        /// <para>系统状态ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7101214603622940633</para>
        /// </summary>
        [JsonPropertyName("system_status_id")]
        public string? SystemStatusId { get; set; }

        /// <summary>
        /// <para>系统状态名称，名称字符数要在1到20范围内。不同系统状态的title不能重复。</para>
        /// <para>**注意：**</para>
        /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：出差</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// <para>系统状态国际化名称，名称字符数要在1到20范围内。不同系统状态之间i18n_title中任何一种title都不能重复。</para>
        /// <para>**注意：**</para>
        /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_title")]
        public SystemStatusI18nName? I18nTitle { get; set; }

        /// <summary>
        /// <para>系统状态国际化名称，名称字符数要在1到20范围内。不同系统状态之间i18n_title中任何一种title都不能重复。</para>
        /// <para>**注意：**</para>
        /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
        /// </summary>
        public record SystemStatusI18nName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：出差</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Onbusinesstrip</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：出張中</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }
        }

        /// <summary>
        /// <para>图标</para>
        /// <para>[**了解icon_key可选值**](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/personal_settings-v1/system_status/overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：GeneralBusinessTrip</para>
        /// <para>可选值：<list type="bullet">
        /// <item>GeneralDoNotDisturb：GeneralDoNotDisturb</item>
        /// <item>GeneralInMeetingBusy：GeneralInMeetingBusy</item>
        /// <item>Coffee：Coffee</item>
        /// <item>GeneralBusinessTrip：GeneralBusinessTrip</item>
        /// <item>GeneralWorkFromHome：GeneralWorkFromHome</item>
        /// <item>StatusEnjoyLife：StatusEnjoyLife</item>
        /// <item>GeneralTravellingCar：GeneralTravellingCar</item>
        /// <item>StatusBus：StatusBus</item>
        /// <item>StatusInFlight：StatusInFlight</item>
        /// <item>Typing：Typing</item>
        /// <item>EatingFood：EatingFood</item>
        /// <item>SICK：SICK</item>
        /// <item>GeneralSun：GeneralSun</item>
        /// <item>GeneralMoonRest：GeneralMoonRest</item>
        /// <item>StatusReading：StatusReading</item>
        /// <item>Status_PrivateMessage：Status_PrivateMessage</item>
        /// <item>StatusFlashOfInspiration：StatusFlashOfInspiration</item>
        /// <item>GeneralVacation：GeneralVacation</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("icon_key")]
        public string IconKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>颜色</para>
        /// <para>必填：否</para>
        /// <para>示例值：BLUE</para>
        /// <para>可选值：<list type="bullet">
        /// <item>BLUE：蓝色</item>
        /// <item>GRAY：灰色</item>
        /// <item>INDIGO：靛青色</item>
        /// <item>WATHET：浅蓝色</item>
        /// <item>GREEN：绿色</item>
        /// <item>TURQUOISE：绿松石色</item>
        /// <item>YELLOW：黄色</item>
        /// <item>LIME：酸橙色</item>
        /// <item>RED：红色</item>
        /// <item>ORANGE：橙色</item>
        /// <item>PURPLE：紫色</item>
        /// <item>VIOLET：紫罗兰色</item>
        /// <item>CARMINE：胭脂红色</item>
        /// </list></para>
        /// <para>默认值：BLUE</para>
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// <para>优先级，数值越小，客户端展示的优先级越高。不同系统状态的优先级不能一样。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>同步设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sync_setting")]
        public SystemStatusSyncSetting? SyncSetting { get; set; }

        /// <summary>
        /// <para>同步设置</para>
        /// </summary>
        public record SystemStatusSyncSetting
        {
            /// <summary>
            /// <para>是否默认开启</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonPropertyName("is_open_by_default")]
            public bool? IsOpenByDefault { get; set; }

            /// <summary>
            /// <para>同步设置名称，名称字符数要在1到30范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// <para>必填：否</para>
            /// <para>示例值：出差期间自动开启</para>
            /// <para>默认值：自动开启</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>同步设置国际化名称，名称字符数要在1到30范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_title")]
            public SystemStatusSyncI18nName? I18nTitle { get; set; }

            /// <summary>
            /// <para>同步设置国际化名称，名称字符数要在1到30范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// </summary>
            public record SystemStatusSyncI18nName
            {
                /// <summary>
                /// <para>中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：出差期间自动开启</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：AutodisplayBusinessTrip</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }

                /// <summary>
                /// <para>日文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：出張中に自動的にオンにする</para>
                /// </summary>
                [JsonPropertyName("ja_jp")]
                public string? JaJp { get; set; }
            }

            /// <summary>
            /// <para>同步设置解释文案，解释字符数要在1到60范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// <para>必填：否</para>
            /// <para>示例值：出差审批通过后，将自动开启并优先展示该状态。</para>
            /// <para>默认值：从相关系统进行信息同步，同步后将自动开启并优先展示该状态。</para>
            /// </summary>
            [JsonPropertyName("explain")]
            public string? Explain { get; set; }

            /// <summary>
            /// <para>同步设置国际化解释文案，解释字符数要在1到60范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_explain")]
            public SystemStatusSyncI18nExplain? I18nExplain { get; set; }

            /// <summary>
            /// <para>同步设置国际化解释文案，解释字符数要在1到60范围内。</para>
            /// <para>**注意：**</para>
            /// <para>- 1中文=2英文=2其他语言字符=2字符</para>
            /// </summary>
            public record SystemStatusSyncI18nExplain
            {
                /// <summary>
                /// <para>中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：出差审批通过后，该状态将自动开启并优先展示</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Auto-displayaftertravelrequestisapproved.</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }

                /// <summary>
                /// <para>日文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：申請が承認されると、このステータスが優先的に表示されます</para>
                /// </summary>
                [JsonPropertyName("ja_jp")]
                public string? JaJp { get; set; }
            }
        }
    }
}
