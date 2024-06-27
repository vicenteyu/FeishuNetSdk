// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="I18nLanguage.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>国际化内容节点</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 国际化内容节点
    /// </summary>
    public record I18nLanguage<T>
    {
        /// <summary>
        /// 简体中文
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public T? ZhCn { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [JsonPropertyName("en_us")]
        public T? EnUs { get; set; }

        /// <summary>
        /// 日文
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public T? JaJp { get; set; }

        /// <summary>
        /// 繁体中文（中国香港）
        /// </summary>
        [JsonPropertyName("zh_hk")]
        public T? ZhHk { get; set; }

        /// <summary>
        /// 繁体中文（中国台湾）
        /// </summary>
        [JsonPropertyName("zh_tw")]
        public T? ZhTw { get; set; }

        /// <summary>
        /// 印尼语
        /// </summary>
        [JsonPropertyName("id_id")]
        public T? IdId { get; set; }

        /// <summary>
        /// 越南语
        /// </summary>
        [JsonPropertyName("vi_vn")]
        public T? ViVn { get; set; }

        /// <summary>
        /// 泰语
        /// </summary>
        [JsonPropertyName("th_th")]
        public T? ThTh { get; set; }

        /// <summary>
        /// 葡萄牙语
        /// </summary>
        [JsonPropertyName("pt_br")]
        public T? PtBr { get; set; }

        /// <summary>
        /// 西班牙语
        /// </summary>
        [JsonPropertyName("es_es")]
        public T? EsEs { get; set; }

        /// <summary>
        /// 韩语
        /// </summary>
        [JsonPropertyName("ko_kr")]
        public T? KrKr { get; set; }

        /// <summary>
        /// 德语
        /// </summary>
        [JsonPropertyName("de_de")]
        public T? DeDe { get; set; }

        /// <summary>
        /// 法语
        /// </summary>
        [JsonPropertyName("fr_fr")]
        public T? FrFr { get; set; }

        /// <summary>
        /// 意大利语
        /// </summary>
        [JsonPropertyName("it_it")]
        public T? ItIt { get; set; }

        /// <summary>
        /// 俄语
        /// </summary>
        [JsonPropertyName("ru_ru")]
        public T? RuRu { get; set; }

        /// <summary>
        /// 马来语
        /// </summary>
        [JsonPropertyName("ms_my")]
        public T? MsMy { get; set; }
    }
}
